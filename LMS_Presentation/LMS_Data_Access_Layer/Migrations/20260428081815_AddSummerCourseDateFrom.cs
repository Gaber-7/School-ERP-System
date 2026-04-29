using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS_Data_Access_Layer.Migrations
{
    /// <inheritdoc />
    public partial class AddSummerCourseDateFrom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "SummerCourseDateFrom",
                table: "AcademicYears",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "SummerCourseDateTo",
                table: "AcademicYears",
                type: "date",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SummerCourseDateFrom",
                table: "AcademicYears");

            migrationBuilder.DropColumn(
                name: "SummerCourseDateTo",
                table: "AcademicYears");
        }
    }
}
