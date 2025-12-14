using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS_Data_Access_Layer.Migrations
{
    /// <inheritdoc />
    public partial class CreateSubjectSupervisor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classrooms_Employees_DeletedByUserId",
                table: "Classrooms");

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
                name: "FK_Students_Employees_DeletedByUserId",
                table: "Students");

            migrationBuilder.AddColumn<long>(
                name: "FloorMonitorID",
                table: "Floors",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SubjectSupervisor",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectID = table.Column<long>(type: "bigint", nullable: false),
                    EmployeeID = table.Column<long>(type: "bigint", nullable: false),
                    InsertedByUserId = table.Column<long>(type: "bigint", nullable: true),
                    InsertedByOctaId = table.Column<long>(type: "bigint", nullable: true),
                    InsertedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedByUserId = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedByOctaId = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedByUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletedByOctaId = table.Column<long>(type: "bigint", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectSupervisor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SubjectSupervisor_Employees_DeletedByUserId",
                        column: x => x.DeletedByUserId,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubjectSupervisor_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubjectSupervisor_Employees_InsertedByUserId",
                        column: x => x.InsertedByUserId,
                        principalTable: "Employees",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SubjectSupervisor_Employees_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Employees",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SubjectSupervisor_Subject_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "Subject",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Floors_FloorMonitorID",
                table: "Floors",
                column: "FloorMonitorID");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectSupervisor_DeletedByUserId",
                table: "SubjectSupervisor",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectSupervisor_EmployeeID",
                table: "SubjectSupervisor",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectSupervisor_InsertedByUserId",
                table: "SubjectSupervisor",
                column: "InsertedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectSupervisor_SubjectID",
                table: "SubjectSupervisor",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectSupervisor_UpdatedByUserId",
                table: "SubjectSupervisor",
                column: "UpdatedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classrooms_Employees_DeletedByUserId",
                table: "Classrooms",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Floors_Employees_DeletedByUserId",
                table: "Floors",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Floors_Employees_FloorMonitorID",
                table: "Floors",
                column: "FloorMonitorID",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Floors_Employees_InsertedByUserId",
                table: "Floors",
                column: "InsertedByUserId",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Floors_Employees_UpdatedByUserId",
                table: "Floors",
                column: "UpdatedByUserId",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Employees_DeletedByUserId",
                table: "Students",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classrooms_Employees_DeletedByUserId",
                table: "Classrooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Floors_Employees_DeletedByUserId",
                table: "Floors");

            migrationBuilder.DropForeignKey(
                name: "FK_Floors_Employees_FloorMonitorID",
                table: "Floors");

            migrationBuilder.DropForeignKey(
                name: "FK_Floors_Employees_InsertedByUserId",
                table: "Floors");

            migrationBuilder.DropForeignKey(
                name: "FK_Floors_Employees_UpdatedByUserId",
                table: "Floors");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Employees_DeletedByUserId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "SubjectSupervisor");

            migrationBuilder.DropIndex(
                name: "IX_Floors_FloorMonitorID",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "FloorMonitorID",
                table: "Floors");

            migrationBuilder.AddForeignKey(
                name: "FK_Classrooms_Employees_DeletedByUserId",
                table: "Classrooms",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");

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
                name: "FK_Students_Employees_DeletedByUserId",
                table: "Students",
                column: "DeletedByUserId",
                principalTable: "Employees",
                principalColumn: "ID");
        }
    }
}
