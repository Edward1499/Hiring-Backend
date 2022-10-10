using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class RenameColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ToDate",
                table: "CandidateTrainings",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "FromDate",
                table: "CandidateTrainings",
                newName: "EndDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "CandidateTrainings",
                newName: "ToDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "CandidateTrainings",
                newName: "FromDate");
        }
    }
}
