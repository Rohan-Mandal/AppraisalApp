using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeAppraisal.Migrations
{
    public partial class hello : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appraisal",
                columns: table => new
                {
                    DetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppraisalID = table.Column<string>(nullable: false),
                    EmployeeRating = table.Column<string>(nullable: false),
                    EmployeeComments = table.Column<string>(nullable: false),
                    ManagerRating = table.Column<string>(nullable: false),
                    Objectives = table.Column<string>(nullable: false),
                    ManagerComments = table.Column<string>(nullable: false),
                    Competency = table.Column<string>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appraisal", x => x.DetailID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appraisal");
        }
    }
}
