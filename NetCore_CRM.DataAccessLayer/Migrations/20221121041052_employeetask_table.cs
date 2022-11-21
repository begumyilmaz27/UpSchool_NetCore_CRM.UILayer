using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCore_CRM.DataAccessLayer.Migrations
{
    public partial class employeetask_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "EmployeeTasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "EmployeeTasks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTasks_AppUserID",
                table: "EmployeeTasks",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTasks_EmployeeID",
                table: "EmployeeTasks",
                column: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTasks_AspNetUsers_AppUserID",
                table: "EmployeeTasks",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTasks_Employees_EmployeeID",
                table: "EmployeeTasks",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTasks_AspNetUsers_AppUserID",
                table: "EmployeeTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTasks_Employees_EmployeeID",
                table: "EmployeeTasks");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTasks_AppUserID",
                table: "EmployeeTasks");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTasks_EmployeeID",
                table: "EmployeeTasks");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "EmployeeTasks");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "EmployeeTasks");
        }
    }
}
