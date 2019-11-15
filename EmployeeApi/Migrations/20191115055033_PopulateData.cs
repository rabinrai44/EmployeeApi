using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeApi.Migrations
{
    public partial class PopulateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "LastName", "Position", "Salary" },
                values: new object[] { 1, "Mark", "Kall", "Developer", 80000.0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "LastName", "Position", "Salary" },
                values: new object[] { 2, "Jason", "Rai", "Assistant", 20000.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
