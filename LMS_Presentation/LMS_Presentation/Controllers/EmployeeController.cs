using AutoMapper;
using LMS_Business_Layer.Config;
using LMS_Business_Layer.DTO.EmployeeDTO;
using LMS_Data_Access_Layer.IUnitOfWorkfolder.UnitOfWork;
using LMS_Data_Access_Layer.IUnitOfWorkFolder.Interface;
using LMS_Data_Access_Layer.Models;
using LMS_Data_Access_Layer.Models.Administration;
using LMS_Data_Access_Layer.Models.HR;
using LMS_Data_Access_Layer.Models.Learning_Management_System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LMS_Presentation_Layer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public EmployeeController(IUnitOfWork unitOfWork, IMapper mapping)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapping;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            List<Employee> Employees = await unitOfWork.Employees_Repository.Select_All_With_IncludesById(
                ems => ems.IsDeleted != true,
                 query => query.Include(emp => emp.EmployeeType),
                 query => query.Include(emp => emp.Job)
                );
            if (Employees == null || Employees.Count == 0)
            {
                return NotFound("No employees found.");
            }
            List<Employee_GetDTO> EmployeesDTO = mapper.Map<List<Employee_GetDTO>>(Employees);
            if (EmployeesDTO != null || EmployeesDTO.Any())
            {
                
                foreach (var employeeDTO in EmployeesDTO)
                {
                   List<Floor> Floors =  unitOfWork.Floors_Repository.FindBy
                        (f => f.FloorMonitorID == employeeDTO.ID && f.IsDeleted != true);

                    if (Floors != null && Floors.Any())  
                        employeeDTO.FloorsSelected = Floors.Select(f => f.ID).ToList(); 
                    else
                       employeeDTO.FloorsSelected = new List<long>();  


                    // SubjectSupervisor -- 

                    List<SubjectSupervisor> SubjectSupervisors = unitOfWork.SubjectSupervisors_Repository.FindBy 
                           (ss => ss.EmployeeID == employeeDTO.ID && ss.IsDeleted != true);

                    var subjectIDs = SubjectSupervisors.Select(ss => ss.SubjectID).ToList();

                    // Subject

                    List<Subject> Subjects = unitOfWork.Subjects_Repository.FindBy 
                        (s => subjectIDs.Contains(s.ID) && s.IsDeleted != true);


                    if (Subjects != null && Subjects.Any())  
                        employeeDTO.SubjectSelected = Subjects.Select(s => s.ID).ToList();
                    else
                        employeeDTO.SubjectSelected = new List<long>();

                    // GradeSupervisor
                    List<GradeSupervisor> GradeSupervisors = unitOfWork.GradeSupervisors_Repository.FindBy
                           (gs => gs.EmployeeID == employeeDTO.ID && gs.IsDeleted != true);

                    var gradeIDs = GradeSupervisors.Select(gs => gs.GradeID).ToList();

                    List<Grade> Grades = unitOfWork.Grades_Repository.FindBy
                        (g => gradeIDs.Contains(g.ID) && g.IsDeleted != true);

                    // Grade

                    if (Grades != null && Grades.Any())
                        employeeDTO.GradeSelected = Grades.Select(g => g.ID).ToList();
                    else
                        employeeDTO.GradeSelected = new List<long>();



                    // Calculate the total number of vacation days (in hours) used by its employee during the current month only.

                    var currentDate = DateTime.UtcNow;
                    var currentMonth = currentDate.Month;
                    var currentYear = currentDate.Year;

                    List<LeaveRequest> leaveRequests = unitOfWork.LeaveRequests_Repository
                     .FindBy(le => le.EmployeeID == employeeDTO.ID
                              && le.IsDeleted != true
                              && le.Date.Month == currentMonth
                              && le.Date.Year == currentYear);

                    var AllHours = leaveRequests.Sum(lr => lr.Hours);  // مجموع ساعات الإجازات في الشهر الحالي
                    var AllMinutes = leaveRequests.Sum(lr => lr.Minutes);   // مجموع دقائق الإجازات في الشهر الحالي

                    // تحويل الدقائق إلى ساعات وإضافتها إلى المجموع الكلي للساعات
                   
                    AllHours += AllMinutes / 60;
                    AllMinutes = AllMinutes % 60;

                    employeeDTO.MonthlyLeaveRequestUsed = AllHours + (AllMinutes / 60.0m);   // إجمالي الإجازات المستخدمة في الشهر الحالي بالساعات (رقم عشري

                }

            }

            EmployeesDTO = EmployeesDTO.OrderBy(e => e.en_name).ToList();
            return Ok(EmployeesDTO);
        }



    }

}