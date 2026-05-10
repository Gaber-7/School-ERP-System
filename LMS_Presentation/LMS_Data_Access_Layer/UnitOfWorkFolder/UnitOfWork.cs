using LMS_Business_Layer.Repository;
using LMS_Data_Access_Layer.Data;
using LMS_Data_Access_Layer.IRepository.Interfaces;
using LMS_Data_Access_Layer.IUnitOfWorkFolder.Interface;
using LMS_Data_Access_Layer.Models;
using LMS_Data_Access_Layer.Models.Administration;
using LMS_Data_Access_Layer.Models.HR;
using LMS_Data_Access_Layer.Models.Learning_Management_System;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Data_Access_Layer.IUnitOfWorkfolder.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LMS_CMS_Context _context;
        public UnitOfWork(LMS_CMS_Context context)
        {
            _context = context;

            AcademicYears_Repository = new GenericRepo<AcademicYear>(_context);
            Semesters_Repository = new GenericRepo<Semester>(_context);
            Classrooms_Repository = new GenericRepo<Classroom>(_context);
            Grades_Repository = new GenericRepo<Grade>(_context);
            Buildings_Repository = new GenericRepo<Building>(_context);
            Departmentes_Repository = new GenericRepo<Department>(_context);
            AcademicDegrees_Repository = new GenericRepo<AcademicDegree>(_context);
            Floors_Repository = new GenericRepo<Floor>(_context);
            Sections_Repository = new GenericRepo<Section>(_context);
            Subjects_Repository = new GenericRepo<Subject>(_context);
            SubjectCategories_Repository = new GenericRepo<SubjectCategory>(_context);
            Schools_Repository = new GenericRepo<School>(_context);
            Students_Repository = new GenericRepo<Student>(_context);
            Employees_Repository = new GenericRepo<Employee>(_context);
            Roles_Repository = new GenericRepo<Role>(_context);
            Jobs_Repository = new GenericRepo<Job>(_context);
            JobCategories_Repository = new GenericRepo<JobCategory>(_context);
            ReasonsForLeavingWork_Repository = new GenericRepo<ReasonForLeavingWork>(_context);
            EmployeeTypes_Repository = new GenericRepo<EmployeeType>(_context);
            SubjectSupervisors_Repository = new GenericRepo<SubjectSupervisor>(_context);
            GradeSupervisors_Repository = new GenericRepo<GradeSupervisor>(_context);
            LeaveRequests_Repository = new GenericRepo<LeaveRequest>(_context);
            EmployeeAttachment_Repository = new GenericRepo<EmployeeAttachment>(_context);
            Page_Repository = new GenericRepo<Page>(_context);

        }

        public IGenericRepository<AcademicYear> AcademicYears_Repository { get; }

        public IGenericRepository<Semester> Semesters_Repository { get; }

        public IGenericRepository<Classroom> Classrooms_Repository { get; }

        public IGenericRepository<Grade> Grades_Repository { get; }

        public IGenericRepository<Building> Buildings_Repository { get; }

        public IGenericRepository<Department> Departmentes_Repository { get; }

        public IGenericRepository<AcademicDegree> AcademicDegrees_Repository { get; }

        public IGenericRepository<Floor> Floors_Repository { get; }

        public IGenericRepository<Section> Sections_Repository { get; }

        public IGenericRepository<Subject> Subjects_Repository { get; }

        public IGenericRepository<SubjectCategory> SubjectCategories_Repository { get; }

        public IGenericRepository<School> Schools_Repository { get; }

        public IGenericRepository<Student> Students_Repository { get; }

        public IGenericRepository<Employee> Employees_Repository { get; }

        public IGenericRepository<Role> Roles_Repository { get; }

        public IGenericRepository<Job> Jobs_Repository { get; }

        public IGenericRepository<JobCategory> JobCategories_Repository { get; }

        public IGenericRepository<ReasonForLeavingWork> ReasonsForLeavingWork_Repository { get; }

        public IGenericRepository<EmployeeType> EmployeeTypes_Repository { get; }

        public IGenericRepository<SubjectSupervisor> SubjectSupervisors_Repository { get; }

        public IGenericRepository<GradeSupervisor> GradeSupervisors_Repository { get; }
        public IGenericRepository<LeaveRequest> LeaveRequests_Repository { get; }

        public IGenericRepository<EmployeeAttachment> EmployeeAttachment_Repository { get; }
        public IGenericRepository<Page> Page_Repository { get; }

    }


}
