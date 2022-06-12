using Microsoft.EntityFrameworkCore.Migrations;

namespace EduAfri.Migrations
{
    public partial class Idnamed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TutorId",
                table: "Tutors",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "Subjects",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "Classes",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tutors",
                newName: "TutorId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Subjects",
                newName: "SubjectId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Classes",
                newName: "ClassId");
        }
    }
}
