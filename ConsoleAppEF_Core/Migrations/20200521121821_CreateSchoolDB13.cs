using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleAppEF_Core.Migrations
{
    public partial class CreateSchoolDB13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Zoology",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Contry",
                table: "Courses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Zoology",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Contry",
                table: "Courses");
        }
    }
}
