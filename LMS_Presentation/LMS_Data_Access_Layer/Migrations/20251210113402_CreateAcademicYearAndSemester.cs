using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS_Data_Access_Layer.Migrations
{
    /// <inheritdoc />
    public partial class CreateAcademicYearAndSemester : Migration
    {
        /// <inheritdoc />    // Add-Migration CreateAuditableEntity -OutputDir Migrations
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcademicDegrees",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicDegrees", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JobCategories",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCategories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ReasonsForLeavingWork",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReasonsForLeavingWork", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportHeaderOneEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportHeaderOneAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportHeaderTwoEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportHeaderTwoAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaximumPeriodCountTimeTable = table.Column<int>(type: "int", nullable: true),
                    MaximumPeriodCountRemedials = table.Column<int>(type: "int", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitySubdivision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VatNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CRN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecretNumber1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecretNumber2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SubjectCategory",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectCategory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    JobCategoryID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Jobs_JobCategories_JobCategoryID",
                        column: x => x.JobCategoryID,
                        principalTable: "JobCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcademicYears",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateFrom = table.Column<DateOnly>(type: "date", nullable: false),
                    DateTo = table.Column<DateOnly>(type: "date", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    schoolId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicYears", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AcademicYears_Schools_schoolId",
                        column: x => x.schoolId,
                        principalTable: "Schools",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SchoolID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Buildings_Schools_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "Schools",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SchoolID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sections_Schools_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "Schools",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    en_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ar_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalIDExpiredDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<long>(type: "bigint", nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Governate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegionCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Floor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Room = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandMark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSuspended = table.Column<bool>(type: "bit", nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Religion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportExpiredDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousSchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyContactRelation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyContactMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PickUpContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PickUpContactRelation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PickUpContactMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRegisteredInNoor = table.Column<bool>(type: "bit", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherPassportNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherPassportExpireDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherNationalID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherNationalIDExpiredDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherQualification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherWorkPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherExperiences = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherProfession = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuardianRelation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdmissionDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Students_Schools_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "Schools",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    en_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ar_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LicenseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpireDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResidenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthdayDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<long>(type: "bigint", nullable: true),
                    HireDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DateOfLeavingWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonthSalary = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    HasAttendance = table.Column<bool>(type: "bit", nullable: true),
                    AttendanceTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartureTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DelayAllowance = table.Column<float>(type: "real", nullable: true),
                    AnnualLeaveBalance = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    CasualLeavesBalance = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    MonthlyLeaveRequestBalance = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    GraduationYear = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CanReceiveRequest = table.Column<bool>(type: "bit", nullable: true),
                    CanReceiveRequestFromParent = table.Column<bool>(type: "bit", nullable: true),
                    CanReceiveMessageFromParent = table.Column<bool>(type: "bit", nullable: true),
                    IsSuspended = table.Column<bool>(type: "bit", nullable: false),
                    IsRestrictedForLoctaion = table.Column<bool>(type: "bit", nullable: false),
                    ReasonOfLeavingID = table.Column<long>(type: "bigint", nullable: true),
                    AcademicDegreeID = table.Column<long>(type: "bigint", nullable: true),
                    DepartmentID = table.Column<long>(type: "bigint", nullable: true),
                    Role_ID = table.Column<long>(type: "bigint", nullable: false),
                    JobID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employees_AcademicDegrees_AcademicDegreeID",
                        column: x => x.AcademicDegreeID,
                        principalTable: "AcademicDegrees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Jobs_JobID",
                        column: x => x.JobID,
                        principalTable: "Jobs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_ReasonsForLeavingWork_ReasonOfLeavingID",
                        column: x => x.ReasonOfLeavingID,
                        principalTable: "ReasonsForLeavingWork",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Employees_Roles_Role_ID",
                        column: x => x.Role_ID,
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Semesters",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCurrent = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    AcademicYearID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semesters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Semesters_AcademicYears_AcademicYearID",
                        column: x => x.AcademicYearID,
                        principalTable: "AcademicYears",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Floors",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    buildingID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Floors_Buildings_buildingID",
                        column: x => x.buildingID,
                        principalTable: "Buildings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SectionID = table.Column<long>(type: "bigint", nullable: false),
                    SAT = table.Column<int>(type: "int", nullable: true),
                    SUN = table.Column<int>(type: "int", nullable: true),
                    MON = table.Column<int>(type: "int", nullable: true),
                    TUS = table.Column<int>(type: "int", nullable: true),
                    WED = table.Column<int>(type: "int", nullable: true),
                    THRU = table.Column<int>(type: "int", nullable: true),
                    FRI = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Grades_Sections_SectionID",
                        column: x => x.SectionID,
                        principalTable: "Sections",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    AcademicYearID = table.Column<long>(type: "bigint", nullable: false),
                    FloorID = table.Column<long>(type: "bigint", nullable: false),
                    GradeID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Classrooms_AcademicYears_AcademicYearID",
                        column: x => x.AcademicYearID,
                        principalTable: "AcademicYears",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classrooms_Floors_FloorID",
                        column: x => x.FloorID,
                        principalTable: "Floors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Classrooms_Grades_GradeID",
                        column: x => x.GradeID,
                        principalTable: "Grades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    en_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ar_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SubjectEnglishNameInCertificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectArabicNameInCertificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderInCertificate = table.Column<int>(type: "int", nullable: false),
                    CreditHours = table.Column<double>(type: "float", nullable: false),
                    SubjectCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassByDegree = table.Column<float>(type: "real", nullable: false),
                    TotalMark = table.Column<float>(type: "real", nullable: false),
                    HideFromGradeReport = table.Column<bool>(type: "bit", nullable: false),
                    IconLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfSessionPerWeek = table.Column<int>(type: "int", nullable: false),
                    AssignmentCutOffDatePercentage = table.Column<float>(type: "real", nullable: false),
                    GradeID = table.Column<long>(type: "bigint", nullable: false),
                    SubjectCategoryID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Subject_Grades_GradeID",
                        column: x => x.GradeID,
                        principalTable: "Grades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subject_SubjectCategory_SubjectCategoryID",
                        column: x => x.SubjectCategoryID,
                        principalTable: "SubjectCategory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcademicYears_schoolId",
                table: "AcademicYears",
                column: "schoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_SchoolID",
                table: "Buildings",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_Classrooms_AcademicYearID",
                table: "Classrooms",
                column: "AcademicYearID");

            migrationBuilder.CreateIndex(
                name: "IX_Classrooms_FloorID",
                table: "Classrooms",
                column: "FloorID");

            migrationBuilder.CreateIndex(
                name: "IX_Classrooms_GradeID",
                table: "Classrooms",
                column: "GradeID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AcademicDegreeID",
                table: "Employees",
                column: "AcademicDegreeID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentID",
                table: "Employees",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Email",
                table: "Employees",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobID",
                table: "Employees",
                column: "JobID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ReasonOfLeavingID",
                table: "Employees",
                column: "ReasonOfLeavingID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Role_ID",
                table: "Employees",
                column: "Role_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_User_Name",
                table: "Employees",
                column: "User_Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Floors_buildingID",
                table: "Floors",
                column: "buildingID");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_SectionID",
                table: "Grades",
                column: "SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_JobCategoryID",
                table: "Jobs",
                column: "JobCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Name",
                table: "Roles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sections_SchoolID",
                table: "Sections",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_Semesters_AcademicYearID",
                table: "Semesters",
                column: "AcademicYearID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Email",
                table: "Students",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolID",
                table: "Students",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_User_Name",
                table: "Students",
                column: "User_Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subject_GradeID",
                table: "Subject",
                column: "GradeID");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_SubjectCategoryID",
                table: "Subject",
                column: "SubjectCategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Semesters");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "Floors");

            migrationBuilder.DropTable(
                name: "AcademicDegrees");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "ReasonsForLeavingWork");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "AcademicYears");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "SubjectCategory");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "JobCategories");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Schools");
        }
    }
}
