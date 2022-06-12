using Microsoft.EntityFrameworkCore.Migrations;

namespace EduAfri.Migrations
{
    public partial class StudentIDUpdatedtoID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "StudentId",
                table: "Students",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Classes",
                newName: "ClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Id",
                table: "Students",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "Classes",
                newName: "Id");
        }
    }
}
