using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS_Data_Access_Layer.Migrations
{
    /// <inheritdoc />
    public partial class CreateAuditableEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_ReasonsForLeavingWork_ReasonOfLeavingID",
                table: "Employees");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "SubjectCategory",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByOctaId",
                table: "SubjectCategory",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByUserId",
                table: "SubjectCategory",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertedAt",
                table: "SubjectCategory",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByOctaId",
                table: "SubjectCategory",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByUserId",
                table: "SubjectCategory",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SubjectCategory",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "SubjectCategory",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByOctaId",
                table: "SubjectCategory",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "SubjectCategory",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Subject",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByOctaId",
                table: "Subject",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByUserId",
                table: "Subject",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertedAt",
                table: "Subject",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByOctaId",
                table: "Subject",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByUserId",
                table: "Subject",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Subject",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Subject",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByOctaId",
                table: "Subject",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "Subject",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Students",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByOctaId",
                table: "Students",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByUserId",
                table: "Students",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertedAt",
                table: "Students",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByOctaId",
                table: "Students",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByUserId",
                table: "Students",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Students",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Students",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByOctaId",
                table: "Students",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "Students",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Semesters",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByOctaId",
                table: "Semesters",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByUserId",
                table: "Semesters",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertedAt",
                table: "Semesters",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByOctaId",
                table: "Semesters",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByUserId",
                table: "Semesters",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Semesters",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Semesters",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByOctaId",
                table: "Semesters",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "Semesters",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByOctaId",
                table: "Sections",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByUserId",
                table: "Sections",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByOctaId",
                table: "Sections",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByUserId",
                table: "Sections",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Sections",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Sections",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByOctaId",
                table: "Sections",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "Sections",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Schools",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByOctaId",
                table: "Schools",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByUserId",
                table: "Schools",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertedAt",
                table: "Schools",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByOctaId",
                table: "Schools",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByUserId",
                table: "Schools",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Schools",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Schools",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByOctaId",
                table: "Schools",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "Schools",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Roles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByOctaId",
                table: "Roles",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByUserId",
                table: "Roles",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertedAt",
                table: "Roles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByOctaId",
                table: "Roles",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByUserId",
                table: "Roles",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Roles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByOctaId",
                table: "Roles",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "Roles",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "ReasonsForLeavingWork",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByOctaId",
                table: "ReasonsForLeavingWork",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByUserId",
                table: "ReasonsForLeavingWork",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertedAt",
                table: "ReasonsForLeavingWork",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByOctaId",
                table: "ReasonsForLeavingWork",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByUserId",
                table: "ReasonsForLeavingWork",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ReasonsForLeavingWork",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ReasonsForLeavingWork",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByOctaId",
                table: "ReasonsForLeavingWork",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "ReasonsForLeavingWork",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Jobs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByOctaId",
                table: "Jobs",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByUserId",
                table: "Jobs",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertedAt",
                table: "Jobs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByOctaId",
                table: "Jobs",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByUserId",
                table: "Jobs",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Jobs",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Jobs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByOctaId",
                table: "Jobs",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "Jobs",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "JobCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByOctaId",
                table: "JobCategories",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByUserId",
                table: "JobCategories",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertedAt",
                table: "JobCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByOctaId",
                table: "JobCategories",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByUserId",
                table: "JobCategories",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "JobCategories",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "JobCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByOctaId",
                table: "JobCategories",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "JobCategories",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Grades",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByOctaId",
                table: "Grades",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByUserId",
                table: "Grades",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertedAt",
                table: "Grades",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByOctaId",
                table: "Grades",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByUserId",
                table: "Grades",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Grades",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Grades",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByOctaId",
                table: "Grades",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "Grades",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Floors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByOctaId",
                table: "Floors",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByUserId",
                table: "Floors",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertedAt",
                table: "Floors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByOctaId",
                table: "Floors",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByUserId",
                table: "Floors",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Floors",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Floors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByOctaId",
                table: "Floors",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "Floors",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByOctaId",
                table: "Employees",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByUserId",
                table: "Employees",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertedAt",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByOctaId",
                table: "Employees",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByUserId",
                table: "Employees",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Employees",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByOctaId",
                table: "Employees",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "Employees",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Departments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByOctaId",
                table: "Departments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByUserId",
                table: "Departments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertedAt",
                table: "Departments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByOctaId",
                table: "Departments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByUserId",
                table: "Departments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Departments",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Departments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByOctaId",
                table: "Departments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "Departments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Classrooms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByOctaId",
                table: "Classrooms",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByUserId",
                table: "Classrooms",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertedAt",
                table: "Classrooms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByOctaId",
                table: "Classrooms",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByUserId",
                table: "Classrooms",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Classrooms",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Classrooms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByOctaId",
                table: "Classrooms",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "Classrooms",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Buildings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByOctaId",
                table: "Buildings",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByUserId",
                table: "Buildings",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertedAt",
                table: "Buildings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByOctaId",
                table: "Buildings",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByUserId",
                table: "Buildings",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Buildings",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Buildings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByOctaId",
                table: "Buildings",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "Buildings",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "AcademicYears",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByOctaId",
                table: "AcademicYears",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByUserId",
                table: "AcademicYears",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertedAt",
                table: "AcademicYears",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByOctaId",
                table: "AcademicYears",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByUserId",
                table: "AcademicYears",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AcademicYears",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "AcademicYears",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByOctaId",
                table: "AcademicYears",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "AcademicYears",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "AcademicDegrees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByOctaId",
                table: "AcademicDegrees",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedByUserId",
                table: "AcademicDegrees",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertedAt",
                table: "AcademicDegrees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByOctaId",
                table: "AcademicDegrees",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InsertedByUserId",
                table: "AcademicDegrees",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AcademicDegrees",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "AcademicDegrees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByOctaId",
                table: "AcademicDegrees",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "AcademicDegrees",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubjectCategory_DeletedByUserId",
                table: "SubjectCategory",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectCategory_InsertedByUserId",
                table: "SubjectCategory",
                column: "InsertedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectCategory_UpdatedByUserId",
                table: "SubjectCategory",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_DeletedByUserId",
                table: "Subject",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_InsertedByUserId",
                table: "Subject",
                column: "InsertedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_UpdatedByUserId",
                table: "Subject",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DeletedByUserId",
                table: "Students",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_InsertedByUserId",
                table: "Students",
                column: "InsertedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UpdatedByUserId",
                table: "Students",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Semesters_DeletedByUserId",
                table: "Semesters",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Semesters_InsertedByUserId",
                table: "Semesters",
                column: "InsertedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Semesters_UpdatedByUserId",
                table: "Semesters",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_DeletedByUserId",
                table: "Sections",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_InsertedByUserId",
                table: "Sections",
                column: "InsertedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_UpdatedByUserId",
                table: "Sections",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_DeletedByUserId",
                table: "Schools",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_InsertedByUserId",
                table: "Schools",
                column: "InsertedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_UpdatedByUserId",
                table: "Schools",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_DeletedByUserId",
                table: "Roles",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_InsertedByUserId",
                table: "Roles",
                column: "InsertedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_UpdatedByUserId",
                table: "Roles",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReasonsForLeavingWork_DeletedByUserId",
                table: "ReasonsForLeavingWork",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReasonsForLeavingWork_InsertedByUserId",
                table: "ReasonsForLeavingWork",
                column: "InsertedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReasonsForLeavingWork_UpdatedByUserId",
                table: "ReasonsForLeavingWork",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_DeletedByUserId",
                table: "Jobs",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_InsertedByUserId",
                table: "Jobs",
                column: "InsertedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_UpdatedByUserId",
                table: "Jobs",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_JobCategories_DeletedByUserId",
                table: "JobCategories",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_JobCategories_InsertedByUserId",
                table: "JobCategories",
                column: "InsertedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_JobCategories_UpdatedByUserId",
                table: "JobCategories",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_DeletedByUserId",
                table: "Grades",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_InsertedByUserId",
                table: "Grades",
                column: "InsertedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_UpdatedByUserId",
                table: "Grades",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Floors_DeletedByUserId",
                table: "Floors",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Floors_InsertedByUserId",
                table: "Floors",
                column: "InsertedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Floors_UpdatedByUserId",
                table: "Floors",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DeletedByUserId",
                table: "Employees",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_InsertedByUserId",
                table: "Employees",
                column: "InsertedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UpdatedByUserId",
                table: "Employees",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DeletedByUserId",
                table: "Departments",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_InsertedByUserId",
                table: "Departments",
                column: "InsertedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_UpdatedByUserId",
                table: "Departments",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Classrooms_DeletedByUserId",
                table: "Classrooms",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Classrooms_InsertedByUserId",
                table: "Classrooms",
                column: "InsertedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Classrooms_UpdatedByUserId",
                table: "Classrooms",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_DeletedByUserId",
                table: "Buildings",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_InsertedByUserId",
                table: "Buildings",
                column: "InsertedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_UpdatedByUserId",
                table: "Buildings",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicYears_DeletedByUserId",
                table: "AcademicYears",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicYears_InsertedByUserId",
                table: "AcademicYears",
                column: "InsertedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicYears_UpdatedByUserId",
                table: "AcademicYears",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicDegrees_DeletedByUserId",
                table: "AcademicDegrees",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicDegrees_InsertedByUserId",
                table: "AcademicDegrees",
                column: "InsertedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicDegrees_UpdatedByUserId",
                table: "AcademicDegrees",
                column: "UpdatedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicDegrees_Employees_DeletedByUserId",
                table: "AcademicDegrees",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicDegrees_Employees_InsertedByUserId",
                table: "AcademicDegrees",
                column: "InsertedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicDegrees_Employees_UpdatedByUserId",
                table: "AcademicDegrees",
                column: "UpdatedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicYears_Employees_DeletedByUserId",
                table: "AcademicYears",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicYears_Employees_InsertedByUserId",
                table: "AcademicYears",
                column: "InsertedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicYears_Employees_UpdatedByUserId",
                table: "AcademicYears",
                column: "UpdatedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_Employees_DeletedByUserId",
                table: "Buildings",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_Employees_InsertedByUserId",
                table: "Buildings",
                column: "InsertedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_Employees_UpdatedByUserId",
                table: "Buildings",
                column: "UpdatedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Classrooms_Employees_DeletedByUserId",
                table: "Classrooms",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Classrooms_Employees_InsertedByUserId",
                table: "Classrooms",
                column: "InsertedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Classrooms_Employees_UpdatedByUserId",
                table: "Classrooms",
                column: "UpdatedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_DeletedByUserId",
                table: "Departments",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_InsertedByUserId",
                table: "Departments",
                column: "InsertedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_UpdatedByUserId",
                table: "Departments",
                column: "UpdatedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_DeletedByUserId",
                table: "Employees",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_InsertedByUserId",
                table: "Employees",
                column: "InsertedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_UpdatedByUserId",
                table: "Employees",
                column: "UpdatedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_ReasonsForLeavingWork_ReasonOfLeavingID",
                table: "Employees",
                column: "ReasonOfLeavingID",
                principalTable: "ReasonsForLeavingWork",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Floors_Employees_DeletedByUserId",
                table: "Floors",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Floors_Employees_InsertedByUserId",
                table: "Floors",
                column: "InsertedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Floors_Employees_UpdatedByUserId",
                table: "Floors",
                column: "UpdatedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Employees_DeletedByUserId",
                table: "Grades",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Employees_InsertedByUserId",
                table: "Grades",
                column: "InsertedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Employees_UpdatedByUserId",
                table: "Grades",
                column: "UpdatedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_JobCategories_Employees_DeletedByUserId",
                table: "JobCategories",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_JobCategories_Employees_InsertedByUserId",
                table: "JobCategories",
                column: "InsertedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_JobCategories_Employees_UpdatedByUserId",
                table: "JobCategories",
                column: "UpdatedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Employees_DeletedByUserId",
                table: "Jobs",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Employees_InsertedByUserId",
                table: "Jobs",
                column: "InsertedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Employees_UpdatedByUserId",
                table: "Jobs",
                column: "UpdatedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReasonsForLeavingWork_Employees_DeletedByUserId",
                table: "ReasonsForLeavingWork",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReasonsForLeavingWork_Employees_InsertedByUserId",
                table: "ReasonsForLeavingWork",
                column: "InsertedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReasonsForLeavingWork_Employees_UpdatedByUserId",
                table: "ReasonsForLeavingWork",
                column: "UpdatedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Employees_DeletedByUserId",
                table: "Roles",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Employees_InsertedByUserId",
                table: "Roles",
                column: "InsertedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Employees_UpdatedByUserId",
                table: "Roles",
                column: "UpdatedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_Employees_DeletedByUserId",
                table: "Schools",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_Employees_InsertedByUserId",
                table: "Schools",
                column: "InsertedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_Employees_UpdatedByUserId",
                table: "Schools",
                column: "UpdatedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Employees_DeletedByUserId",
                table: "Sections",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Employees_InsertedByUserId",
                table: "Sections",
                column: "InsertedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Employees_UpdatedByUserId",
                table: "Sections",
                column: "UpdatedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Semesters_Employees_DeletedByUserId",
                table: "Semesters",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Semesters_Employees_InsertedByUserId",
                table: "Semesters",
                column: "InsertedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Semesters_Employees_UpdatedByUserId",
                table: "Semesters",
                column: "UpdatedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Employees_DeletedByUserId",
                table: "Students",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Employees_InsertedByUserId",
                table: "Students",
                column: "InsertedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Employees_UpdatedByUserId",
                table: "Students",
                column: "UpdatedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Employees_DeletedByUserId",
                table: "Subject",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Employees_InsertedByUserId",
                table: "Subject",
                column: "InsertedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Employees_UpdatedByUserId",
                table: "Subject",
                column: "UpdatedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectCategory_Employees_DeletedByUserId",
                table: "SubjectCategory",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectCategory_Employees_InsertedByUserId",
                table: "SubjectCategory",
                column: "InsertedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectCategory_Employees_UpdatedByUserId",
                table: "SubjectCategory",
                column: "UpdatedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcademicDegrees_Employees_DeletedByUserId",
                table: "AcademicDegrees");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicDegrees_Employees_InsertedByUserId",
                table: "AcademicDegrees");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicDegrees_Employees_UpdatedByUserId",
                table: "AcademicDegrees");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicYears_Employees_DeletedByUserId",
                table: "AcademicYears");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicYears_Employees_InsertedByUserId",
                table: "AcademicYears");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicYears_Employees_UpdatedByUserId",
                table: "AcademicYears");

            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_Employees_DeletedByUserId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_Employees_InsertedByUserId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_Employees_UpdatedByUserId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_Classrooms_Employees_DeletedByUserId",
                table: "Classrooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Classrooms_Employees_InsertedByUserId",
                table: "Classrooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Classrooms_Employees_UpdatedByUserId",
                table: "Classrooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_DeletedByUserId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_InsertedByUserId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_UpdatedByUserId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_DeletedByUserId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_InsertedByUserId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_UpdatedByUserId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_ReasonsForLeavingWork_ReasonOfLeavingID",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Floors_Employees_DeletedByUserId",
                table: "Floors");

            migrationBuilder.DropForeignKey(
                name: "FK_Floors_Employees_InsertedByUserId",
                table: "Floors");

            migrationBuilder.DropForeignKey(
                name: "FK_Floors_Employees_UpdatedByUserId",
                table: "Floors");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Employees_DeletedByUserId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Employees_InsertedByUserId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Employees_UpdatedByUserId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_JobCategories_Employees_DeletedByUserId",
                table: "JobCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_JobCategories_Employees_InsertedByUserId",
                table: "JobCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_JobCategories_Employees_UpdatedByUserId",
                table: "JobCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Employees_DeletedByUserId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Employees_InsertedByUserId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Employees_UpdatedByUserId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_ReasonsForLeavingWork_Employees_DeletedByUserId",
                table: "ReasonsForLeavingWork");

            migrationBuilder.DropForeignKey(
                name: "FK_ReasonsForLeavingWork_Employees_InsertedByUserId",
                table: "ReasonsForLeavingWork");

            migrationBuilder.DropForeignKey(
                name: "FK_ReasonsForLeavingWork_Employees_UpdatedByUserId",
                table: "ReasonsForLeavingWork");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Employees_DeletedByUserId",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Employees_InsertedByUserId",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Employees_UpdatedByUserId",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Schools_Employees_DeletedByUserId",
                table: "Schools");

            migrationBuilder.DropForeignKey(
                name: "FK_Schools_Employees_InsertedByUserId",
                table: "Schools");

            migrationBuilder.DropForeignKey(
                name: "FK_Schools_Employees_UpdatedByUserId",
                table: "Schools");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Employees_DeletedByUserId",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Employees_InsertedByUserId",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Employees_UpdatedByUserId",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_Semesters_Employees_DeletedByUserId",
                table: "Semesters");

            migrationBuilder.DropForeignKey(
                name: "FK_Semesters_Employees_InsertedByUserId",
                table: "Semesters");

            migrationBuilder.DropForeignKey(
                name: "FK_Semesters_Employees_UpdatedByUserId",
                table: "Semesters");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Employees_DeletedByUserId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Employees_InsertedByUserId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Employees_UpdatedByUserId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Employees_DeletedByUserId",
                table: "Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Employees_InsertedByUserId",
                table: "Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Employees_UpdatedByUserId",
                table: "Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectCategory_Employees_DeletedByUserId",
                table: "SubjectCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectCategory_Employees_InsertedByUserId",
                table: "SubjectCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectCategory_Employees_UpdatedByUserId",
                table: "SubjectCategory");

            migrationBuilder.DropIndex(
                name: "IX_SubjectCategory_DeletedByUserId",
                table: "SubjectCategory");

            migrationBuilder.DropIndex(
                name: "IX_SubjectCategory_InsertedByUserId",
                table: "SubjectCategory");

            migrationBuilder.DropIndex(
                name: "IX_SubjectCategory_UpdatedByUserId",
                table: "SubjectCategory");

            migrationBuilder.DropIndex(
                name: "IX_Subject_DeletedByUserId",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_InsertedByUserId",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_UpdatedByUserId",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Students_DeletedByUserId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_InsertedByUserId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_UpdatedByUserId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Semesters_DeletedByUserId",
                table: "Semesters");

            migrationBuilder.DropIndex(
                name: "IX_Semesters_InsertedByUserId",
                table: "Semesters");

            migrationBuilder.DropIndex(
                name: "IX_Semesters_UpdatedByUserId",
                table: "Semesters");

            migrationBuilder.DropIndex(
                name: "IX_Sections_DeletedByUserId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Sections_InsertedByUserId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Sections_UpdatedByUserId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Schools_DeletedByUserId",
                table: "Schools");

            migrationBuilder.DropIndex(
                name: "IX_Schools_InsertedByUserId",
                table: "Schools");

            migrationBuilder.DropIndex(
                name: "IX_Schools_UpdatedByUserId",
                table: "Schools");

            migrationBuilder.DropIndex(
                name: "IX_Roles_DeletedByUserId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_InsertedByUserId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_UpdatedByUserId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_ReasonsForLeavingWork_DeletedByUserId",
                table: "ReasonsForLeavingWork");

            migrationBuilder.DropIndex(
                name: "IX_ReasonsForLeavingWork_InsertedByUserId",
                table: "ReasonsForLeavingWork");

            migrationBuilder.DropIndex(
                name: "IX_ReasonsForLeavingWork_UpdatedByUserId",
                table: "ReasonsForLeavingWork");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_DeletedByUserId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_InsertedByUserId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_UpdatedByUserId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_JobCategories_DeletedByUserId",
                table: "JobCategories");

            migrationBuilder.DropIndex(
                name: "IX_JobCategories_InsertedByUserId",
                table: "JobCategories");

            migrationBuilder.DropIndex(
                name: "IX_JobCategories_UpdatedByUserId",
                table: "JobCategories");

            migrationBuilder.DropIndex(
                name: "IX_Grades_DeletedByUserId",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Grades_InsertedByUserId",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Grades_UpdatedByUserId",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Floors_DeletedByUserId",
                table: "Floors");

            migrationBuilder.DropIndex(
                name: "IX_Floors_InsertedByUserId",
                table: "Floors");

            migrationBuilder.DropIndex(
                name: "IX_Floors_UpdatedByUserId",
                table: "Floors");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DeletedByUserId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_InsertedByUserId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_UpdatedByUserId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Departments_DeletedByUserId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_InsertedByUserId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_UpdatedByUserId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Classrooms_DeletedByUserId",
                table: "Classrooms");

            migrationBuilder.DropIndex(
                name: "IX_Classrooms_InsertedByUserId",
                table: "Classrooms");

            migrationBuilder.DropIndex(
                name: "IX_Classrooms_UpdatedByUserId",
                table: "Classrooms");

            migrationBuilder.DropIndex(
                name: "IX_Buildings_DeletedByUserId",
                table: "Buildings");

            migrationBuilder.DropIndex(
                name: "IX_Buildings_InsertedByUserId",
                table: "Buildings");

            migrationBuilder.DropIndex(
                name: "IX_Buildings_UpdatedByUserId",
                table: "Buildings");

            migrationBuilder.DropIndex(
                name: "IX_AcademicYears_DeletedByUserId",
                table: "AcademicYears");

            migrationBuilder.DropIndex(
                name: "IX_AcademicYears_InsertedByUserId",
                table: "AcademicYears");

            migrationBuilder.DropIndex(
                name: "IX_AcademicYears_UpdatedByUserId",
                table: "AcademicYears");

            migrationBuilder.DropIndex(
                name: "IX_AcademicDegrees_DeletedByUserId",
                table: "AcademicDegrees");

            migrationBuilder.DropIndex(
                name: "IX_AcademicDegrees_InsertedByUserId",
                table: "AcademicDegrees");

            migrationBuilder.DropIndex(
                name: "IX_AcademicDegrees_UpdatedByUserId",
                table: "AcademicDegrees");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "SubjectCategory");

            migrationBuilder.DropColumn(
                name: "DeletedByOctaId",
                table: "SubjectCategory");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "SubjectCategory");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "SubjectCategory");

            migrationBuilder.DropColumn(
                name: "InsertedByOctaId",
                table: "SubjectCategory");

            migrationBuilder.DropColumn(
                name: "InsertedByUserId",
                table: "SubjectCategory");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SubjectCategory");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "SubjectCategory");

            migrationBuilder.DropColumn(
                name: "UpdatedByOctaId",
                table: "SubjectCategory");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "SubjectCategory");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "DeletedByOctaId",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "InsertedByOctaId",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "InsertedByUserId",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "UpdatedByOctaId",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DeletedByOctaId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "InsertedByOctaId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "InsertedByUserId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UpdatedByOctaId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Semesters");

            migrationBuilder.DropColumn(
                name: "DeletedByOctaId",
                table: "Semesters");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "Semesters");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "Semesters");

            migrationBuilder.DropColumn(
                name: "InsertedByOctaId",
                table: "Semesters");

            migrationBuilder.DropColumn(
                name: "InsertedByUserId",
                table: "Semesters");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Semesters");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Semesters");

            migrationBuilder.DropColumn(
                name: "UpdatedByOctaId",
                table: "Semesters");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Semesters");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "DeletedByOctaId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "InsertedByOctaId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "InsertedByUserId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "UpdatedByOctaId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "DeletedByOctaId",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "InsertedByOctaId",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "InsertedByUserId",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "UpdatedByOctaId",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "DeletedByOctaId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "InsertedByOctaId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "InsertedByUserId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "UpdatedByOctaId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "ReasonsForLeavingWork");

            migrationBuilder.DropColumn(
                name: "DeletedByOctaId",
                table: "ReasonsForLeavingWork");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "ReasonsForLeavingWork");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "ReasonsForLeavingWork");

            migrationBuilder.DropColumn(
                name: "InsertedByOctaId",
                table: "ReasonsForLeavingWork");

            migrationBuilder.DropColumn(
                name: "InsertedByUserId",
                table: "ReasonsForLeavingWork");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ReasonsForLeavingWork");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ReasonsForLeavingWork");

            migrationBuilder.DropColumn(
                name: "UpdatedByOctaId",
                table: "ReasonsForLeavingWork");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "ReasonsForLeavingWork");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "DeletedByOctaId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "InsertedByOctaId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "InsertedByUserId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "UpdatedByOctaId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "JobCategories");

            migrationBuilder.DropColumn(
                name: "DeletedByOctaId",
                table: "JobCategories");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "JobCategories");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "JobCategories");

            migrationBuilder.DropColumn(
                name: "InsertedByOctaId",
                table: "JobCategories");

            migrationBuilder.DropColumn(
                name: "InsertedByUserId",
                table: "JobCategories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "JobCategories");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "JobCategories");

            migrationBuilder.DropColumn(
                name: "UpdatedByOctaId",
                table: "JobCategories");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "JobCategories");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "DeletedByOctaId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "InsertedByOctaId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "InsertedByUserId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "UpdatedByOctaId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "DeletedByOctaId",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "InsertedByOctaId",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "InsertedByUserId",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "UpdatedByOctaId",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DeletedByOctaId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "InsertedByOctaId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "InsertedByUserId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "UpdatedByOctaId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DeletedByOctaId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "InsertedByOctaId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "InsertedByUserId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "UpdatedByOctaId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Classrooms");

            migrationBuilder.DropColumn(
                name: "DeletedByOctaId",
                table: "Classrooms");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "Classrooms");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "Classrooms");

            migrationBuilder.DropColumn(
                name: "InsertedByOctaId",
                table: "Classrooms");

            migrationBuilder.DropColumn(
                name: "InsertedByUserId",
                table: "Classrooms");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Classrooms");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Classrooms");

            migrationBuilder.DropColumn(
                name: "UpdatedByOctaId",
                table: "Classrooms");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Classrooms");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "DeletedByOctaId",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "InsertedByOctaId",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "InsertedByUserId",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "UpdatedByOctaId",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "AcademicYears");

            migrationBuilder.DropColumn(
                name: "DeletedByOctaId",
                table: "AcademicYears");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "AcademicYears");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "AcademicYears");

            migrationBuilder.DropColumn(
                name: "InsertedByOctaId",
                table: "AcademicYears");

            migrationBuilder.DropColumn(
                name: "InsertedByUserId",
                table: "AcademicYears");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AcademicYears");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "AcademicYears");

            migrationBuilder.DropColumn(
                name: "UpdatedByOctaId",
                table: "AcademicYears");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "AcademicYears");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "AcademicDegrees");

            migrationBuilder.DropColumn(
                name: "DeletedByOctaId",
                table: "AcademicDegrees");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "AcademicDegrees");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "AcademicDegrees");

            migrationBuilder.DropColumn(
                name: "InsertedByOctaId",
                table: "AcademicDegrees");

            migrationBuilder.DropColumn(
                name: "InsertedByUserId",
                table: "AcademicDegrees");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AcademicDegrees");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "AcademicDegrees");

            migrationBuilder.DropColumn(
                name: "UpdatedByOctaId",
                table: "AcademicDegrees");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "AcademicDegrees");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_ReasonsForLeavingWork_ReasonOfLeavingID",
                table: "Employees",
                column: "ReasonOfLeavingID",
                principalTable: "ReasonsForLeavingWork",
                principalColumn: "ID");
        }
    }
}
