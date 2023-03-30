using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeAppraisal.Migrations
{
    public partial class iniss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Competency",
                table: "createappraisals",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Competency",
                table: "createappraisals",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
