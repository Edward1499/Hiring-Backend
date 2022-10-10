using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class ChangeNameDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpatedAt",
                table: "PositionSkills",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpatedAt",
                table: "Positions",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpatedAt",
                table: "Languages",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpatedAt",
                table: "Employees",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpatedAt",
                table: "Departments",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpatedAt",
                table: "Competitions",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpatedAt",
                table: "CandidateTrainings",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpatedAt",
                table: "Candidates",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpatedAt",
                table: "CandidatePositions",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpatedAt",
                table: "CandidateLanguages",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpatedAt",
                table: "CandidateExpiriences",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpatedAt",
                table: "CandidateCompetitions",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpatedAt",
                table: "AcademicLevels",
                newName: "UpdateddAt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "PositionSkills",
                newName: "UpatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "Positions",
                newName: "UpatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "Languages",
                newName: "UpatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "Employees",
                newName: "UpatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "Departments",
                newName: "UpatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "Competitions",
                newName: "UpatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "CandidateTrainings",
                newName: "UpatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "Candidates",
                newName: "UpatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "CandidatePositions",
                newName: "UpatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "CandidateLanguages",
                newName: "UpatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "CandidateExpiriences",
                newName: "UpatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "CandidateCompetitions",
                newName: "UpatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "AcademicLevels",
                newName: "UpatedAt");
        }
    }
}
