using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleAppEF_Core.Migrations
{
    public partial class CreateSchoolDB4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Chemistry",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "English",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Maths",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Physics",
                table: "Students",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chemistry",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "English",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Maths",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Physics",
                table: "Students");
                        
        }
    }
}
