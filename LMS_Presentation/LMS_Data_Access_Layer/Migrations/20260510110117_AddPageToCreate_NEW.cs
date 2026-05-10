using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS_Data_Access_Layer.Migrations
{
    /// <inheritdoc />
    public partial class AddPageToCreate_NEW : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "en_name",
                table: "Page",
                newName: "En_name");

            migrationBuilder.RenameColumn(
                name: "ar_name",
                table: "Page",
                newName: "Ar_name");

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Page",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Page",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PermissionKey",
                table: "Page",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Route",
                table: "Page",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Page");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Page");

            migrationBuilder.DropColumn(
                name: "PermissionKey",
                table: "Page");

            migrationBuilder.DropColumn(
                name: "Route",
                table: "Page");

            migrationBuilder.RenameColumn(
                name: "En_name",
                table: "Page",
                newName: "en_name");

            migrationBuilder.RenameColumn(
                name: "Ar_name",
                table: "Page",
                newName: "ar_name");
        }
    }
}
