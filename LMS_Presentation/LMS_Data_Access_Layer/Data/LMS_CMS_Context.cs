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

namespace LMS_Data_Access_Layer.Data
{
    public class LMS_CMS_Context : DbContext
    {
        public LMS_CMS_Context(DbContextOptions<LMS_CMS_Context> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<AcademicYear> AcademicYears { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<AcademicDegree> AcademicDegrees { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<ReasonForLeavingWork> ReasonsForLeavingWork { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<SubjectCategory> SubjectCategory { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<SubjectSupervisor> SubjectSupervisor { get; set; }
        public DbSet<GradeSupervisor> GradeSupervisors { get; set; }
        public DbSet<LeaveRequest> leaveRequests { get; set; }
        public DbSet<EmployeeAttachment> EmployeeAttachment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Role>()
               .HasIndex(p => p.Name)   // to serche role by name
               .IsUnique();  // Ensure role names are unique

            modelBuilder.Entity<Student>()
                .HasIndex(p => p.Email)
                .IsUnique();
            modelBuilder.Entity<Student>()
                .HasIndex(p => p.User_Name)
                .IsUnique();

            modelBuilder.Entity<Employee>()
                .HasIndex(p => p.User_Name)
                .IsUnique();

            modelBuilder.Entity<Employee>()
                .HasIndex(p => p.Email)
                .IsUnique();



            //modelBuilder.Entity<AcademicYear>()
            //.HasIndex(c => c.SchoolID)
            //.HasDatabaseName("IX_AcademicYear_SchoolID_New");

            //        modelBuilder.Entity<Grade>()
            //            .HasIndex(c => c.SectionID)
            //            .HasDatabaseName("IX_Grade_SectionID_New");

            //        modelBuilder.Entity<Floor>()
            //            .HasIndex(c => c.buildingID)
            //            .HasDatabaseName("IX_Floor_buildingID_New");

            //        modelBuilder.Entity<Classroom>()
            //            .HasIndex(c => c.AcademicYearID)
            //            .HasDatabaseName("IX_Classroom_AcademicYearID_New");

            //        modelBuilder.Entity<Classroom>()
            //            .HasIndex(c => c.GradeID)
            //            .HasDatabaseName("IX_Classroom_GradeID_New");

            ///////////////////////// OnDelete: /////////////////////////

            modelBuilder.Entity<Employee>()
             .HasOne(p => p.Role)
             .WithMany(p => p.Employess)
             .HasForeignKey(p => p.Role_ID)
             .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Employee>()
            //     .HasOne(p => p.BusCompany)
            //     .WithMany(p => p.Employees)
            //     .HasForeignKey(p => p.BusCompanyID)
            //     .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Employee>()
            //     .HasOne(p => p.AccountNumber)
            //     .WithMany(p => p.Employees)
            //     .HasForeignKey(p => p.AccountNumberID)
            //     .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Employee>()
               .HasOne(p => p.ReasonForLeavingWork)
               .WithMany(p => p.Employees)
               .HasForeignKey(p => p.ReasonOfLeavingID)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Employee>()
                 .HasOne(p => p.Department)
                 .WithMany(p => p.Employees)
                 .HasForeignKey(p => p.DepartmentID)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Employee>()
                 .HasOne(p => p.Job)
                 .WithMany(p => p.Employees)
                 .HasForeignKey(p => p.JobID)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Employee>()
                 .HasOne(p => p.AcademicDegree)
                 .WithMany(p => p.Employees)
                 .HasForeignKey(p => p.AcademicDegreeID)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AcademicYear>()
               .HasOne(p => p.School)
               .WithMany(p => p.AcademicYears)
               .HasForeignKey(p => p.schoolId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Semester>()
              .HasOne(p => p.AcademicYear)
              .WithMany(p => p.Semesters)
              .HasForeignKey(p => p.AcademicYearID)
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Subject>()
               .HasOne(p => p.Grade)
               .WithMany(p => p.Subjects)
               .HasForeignKey(p => p.GradeID)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Subject>()
                 .HasOne(p => p.SubjectCategory)
                 .WithMany(p => p.Subjects)
                 .HasForeignKey(p => p.SubjectCategoryID)
                 .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Floor>()
               .HasOne(p => p.building)
               .WithMany(p => p.Floors)
               .HasForeignKey(p => p.buildingID)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Building>()
                 .HasOne(p => p.school)
                 .WithMany(p => p.Buildings)
                 .HasForeignKey(p => p.SchoolID)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Section>()
                 .HasOne(p => p.school)
                 .WithMany(p => p.Sections)
                 .HasForeignKey(p => p.SchoolID)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Grade>()
                 .HasOne(p => p.Section)
                 .WithMany(p => p.Grades)
                 .HasForeignKey(p => p.SectionID)
                 .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Classroom>()
                 .HasOne(p => p.Grade)
                 .WithMany(p => p.Classrooms)
                 .HasForeignKey(p => p.GradeID)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Classroom>()
                 .HasOne(p => p.Floor)
                 .WithMany(p => p.Classrooms)
                 .HasForeignKey(p => p.FloorID)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Employee>()
              .HasOne(p => p.EmployeeType)
              .WithMany(p => p.Employees)
              .HasForeignKey(p => p.EmployeeTypeID)
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LeaveRequest>()
              .HasOne(p => p.Employee)
              .WithMany(p => p.LeaveRequests)
              .HasForeignKey(p => p.EmployeeID)
              .OnDelete(DeleteBehavior.Restrict);   


            //modelBuilder.Entity<Floor>()
            //   .HasOne(f => f.DeletedByEmployee)
            //   .WithMany()
            //   .HasForeignKey(f => f.DeletedByUserId)
            //   .OnDelete(DeleteBehavior.Restrict);


            // تكوين علاقات AuditableEntity لـ Floor
            modelBuilder.Entity<Floor>()
                .HasOne(f => f.InsertedByEmployee)
                .WithMany()
                .HasForeignKey(f => f.InsertedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            modelBuilder.Entity<Floor>()
                .HasOne(f => f.UpdatedByEmployee)
                .WithMany()
                .HasForeignKey(f => f.UpdatedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            modelBuilder.Entity<Floor>()
                .HasOne(f => f.DeletedByEmployee)
                .WithMany()
                .HasForeignKey(f => f.DeletedByUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            // علاقة floorMonitor
            modelBuilder.Entity<Floor>()
                .HasOne(f => f.floorMonitor) // Floor له موظف مسؤول واحد
                .WithMany(e => e.Floors)  // Employee له عدة Floors
                .HasForeignKey(f => f.FloorMonitorID)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            modelBuilder.Entity<Employee>()
              .HasMany(e => e.EmployeeAttachments)
              .WithOne(ea => ea.Employee)
              .HasForeignKey(ea => ea.EmployeeID)
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SubjectSupervisor>()
              .HasOne(p => p.Employee)
              .WithMany(p => p.SubjectSupervisors)
              .HasForeignKey(p => p.EmployeeID)
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SubjectSupervisor>()
              .HasOne(p => p.Subject)
              .WithMany(p => p.SubjectSupervisors)
              .HasForeignKey(p => p.SubjectID)
              .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<SubjectSupervisor>()
               .HasOne(f => f.DeletedByEmployee)
               .WithMany()
               .HasForeignKey(f => f.DeletedByUserId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Student>()
            .HasOne(f => f.DeletedByEmployee)
            .WithMany()
            .HasForeignKey(f => f.DeletedByUserId)
            .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Classroom>()
           .HasOne(c => c.DeletedByEmployee)
           .WithMany()
           .HasForeignKey(c => c.DeletedByUserId)
           .OnDelete(DeleteBehavior.Restrict); // Optional

            modelBuilder.Entity<GradeSupervisor>()
                .HasOne(p => p.Grade)  // GradeSupervisor مرتبط بدرجة واحدة
                .WithMany(p => p.GradeSupervisors)     // Grade يمكن أن يكون له عدة مشرفين
                .HasForeignKey(p => p.GradeID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GradeSupervisor>()
              .HasOne(p => p.Employee)
              .WithMany(p => p.GradeSupervisors)
              .HasForeignKey(p => p.EmployeeID)
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GradeSupervisor>()
                .HasOne(f => f.DeletedByEmployee)
                .WithMany()
                .HasForeignKey(f => f.DeletedByUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LeaveRequest>()
                .HasOne(v => v.DeletedByEmployee)
                .WithMany()
                .HasForeignKey(v => v.DeletedByUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.AnnualLeaveBalance)
                      .HasPrecision(18, 2);

                entity.Property(e => e.CasualLeavesBalance)
                      .HasPrecision(18, 2);

                entity.Property(e => e.MonthSalary)
                      .HasPrecision(18, 2);

                entity.Property(e => e.MonthlyLeaveRequestBalance)
                      .HasPrecision(18, 2);
            });

        }

    }
}