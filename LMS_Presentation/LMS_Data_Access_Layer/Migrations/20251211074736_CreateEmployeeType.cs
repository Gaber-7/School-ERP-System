using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS_Data_Access_Layer.Migrations
{
    /// <inheritdoc />
    public partial class CreateEmployeeType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "EmployeeTypeID",
                table: "Employees",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "EmployeeTypes",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTypes", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeTypeID",
                table: "Employees",
                column: "EmployeeTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeeTypes_EmployeeTypeID",
                table: "Employees",
                column: "EmployeeTypeID",
                principalTable: "EmployeeTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeeTypes_EmployeeTypeID",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "EmployeeTypes");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployeeTypeID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeTypeID",
                table: "Employees");
        }
    }
}
