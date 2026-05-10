using LMS_Data_Access_Layer.IRepository.Interfaces;
using LMS_Data_Access_Layer.Models;
using LMS_Data_Access_Layer.Models.Administration;
using LMS_Data_Access_Layer.Models.HR;
using LMS_Data_Access_Layer.Models.Learning_Management_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Data_Access_Layer.IUnitOfWorkFolder.Interface
{
    public interface IUnitOfWork 
    {
        IGenericRepository<AcademicYear> AcademicYears_Repository { get; }
        IGenericRepository<Semester> Semesters_Repository { get; }
        IGenericRepository<Classroom> Classrooms_Repository { get; }
        IGenericRepository<Grade> Grades_Repository { get; }
        IGenericRepository<Building> Buildings_Repository { get; }
        IGenericRepository<Department> Departmentes_Repository { get; }
        IGenericRepository<AcademicDegree> AcademicDegrees_Repository { get; }
        IGenericRepository<Floor> Floors_Repository { get; }
        IGenericRepository<Section> Sections_Repository { get; }
        IGenericRepository<Subject> Subjects_Repository { get; }
        IGenericRepository<SubjectCategory> SubjectCategories_Repository { get; }
        IGenericRepository<School> Schools_Repository { get; }
        IGenericRepository<Student> Students_Repository { get; }
        IGenericRepository<Employee> Employees_Repository { get; }
        IGenericRepository<Role> Roles_Repository { get; }
        IGenericRepository<Job> Jobs_Repository { get; }
        IGenericRepository<JobCategory> JobCategories_Repository { get; }
        IGenericRepository<ReasonForLeavingWork> ReasonsForLeavingWork_Repository { get; }
        IGenericRepository<EmployeeType> EmployeeTypes_Repository { get; }
        IGenericRepository<SubjectSupervisor> SubjectSupervisors_Repository { get; }
        IGenericRepository<GradeSupervisor> GradeSupervisors_Repository { get; }
        IGenericRepository<LeaveRequest> LeaveRequests_Repository { get; }
        IGenericRepository<EmployeeAttachment> EmployeeAttachment_Repository { get; }
        IGenericRepository<Page> Page_Repository { get; }


    }
}
