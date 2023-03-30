using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeAppraisal.Migrations
{
    public partial class inis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "createappraisals",
                columns: table => new
                {
                    AppraisalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppraisalStatus = table.Column<string>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: false),
                    Competency = table.Column<int>(nullable: false),
                    Objectives = table.Column<string>(nullable: false),
                    ManagerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_createappraisals", x => x.AppraisalID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "createappraisals");
        }
    }
}
