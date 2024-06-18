using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HrApplication.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeTableFromMybranch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "jobTitle",
                table: "Employees",
                newName: "JobTitle");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JobTitle",
                table: "Employees",
                newName: "jobTitle");
        }
    }
}
