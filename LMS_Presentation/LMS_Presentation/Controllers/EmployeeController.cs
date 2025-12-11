using AutoMapper;
using LMS_Business_Layer.Config;
using LMS_Business_Layer.DTO.EmployeeDTO;
using LMS_Data_Access_Layer.IUnitOfWorkfolder.UnitOfWork;
using LMS_Data_Access_Layer.IUnitOfWorkFolder.Interface;
using LMS_Data_Access_Layer.Models;
using LMS_Data_Access_Layer.Models.Administration;
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

            List<Floor> Floors =  unitOfWork.Floors_Repository.FindBy(s => s.FloorMonitorID == EmployeesDTO[0].ID && s.IsDeleted != true);
            return Ok(EmployeesDTO);
        }
    }

}