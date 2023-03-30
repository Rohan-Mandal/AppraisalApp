using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeAppraisal.Migrations
{
    public partial class inisss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Competency",
                table: "createappraisals");

            migrationBuilder.CreateTable(
                name: "compitencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AID = table.Column<int>(nullable: false),
                    compi = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_compitencies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "compitencies");

            migrationBuilder.AddColumn<string>(
                name: "Competency",
                table: "createappraisals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
