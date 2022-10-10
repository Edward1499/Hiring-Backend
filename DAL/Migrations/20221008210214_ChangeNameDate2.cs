using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class ChangeNameDate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "PositionSkills",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "Positions",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "Languages",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "Employees",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "Departments",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "Competitions",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "CandidateTrainings",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "Candidates",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "CandidatePositions",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "CandidateLanguages",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "CandidateExpiriences",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "CandidateCompetitions",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "AcademicLevels",
                newName: "UpdatedAt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "PositionSkills",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Positions",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Languages",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Employees",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Departments",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Competitions",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "CandidateTrainings",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Candidates",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "CandidatePositions",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "CandidateLanguages",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "CandidateExpiriences",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "CandidateCompetitions",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "AcademicLevels",
                newName: "UpdateddAt");
        }
    }
}
