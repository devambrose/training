using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HrApplication.Migrations
{
    /// <inheritdoc />
    public partial class UpdateChangeDescriptionToDepartmentInEmployeeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Employees",
                newName: "Department");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Department",
                table: "Employees",
                newName: "Description");
        }
    }
}
