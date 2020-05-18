using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleAppEF_Core.Migrations
{
    public partial class CreateSchoolDB12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Courses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Courses");
        }
    }
}
