using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleAppEF_Core.Migrations
{
    public partial class CreateSchoolDB6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "College",
                table: "Courses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "College",
                table: "Courses");
        }
    }
}
