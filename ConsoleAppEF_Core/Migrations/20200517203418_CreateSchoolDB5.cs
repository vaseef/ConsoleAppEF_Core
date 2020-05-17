using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleAppEF_Core.Migrations
{
    public partial class CreateSchoolDB5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CertificateName",
                table: "Courses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CertificateName",
                table: "Courses");
        }
    }
}
