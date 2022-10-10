using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class RenameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateCompetions_Candidates_CandidateId",
                table: "CandidateCompetions");

            migrationBuilder.DropForeignKey(
                name: "FK_CandidateCompetions_Competions_CompetionId",
                table: "CandidateCompetions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CandidateCompetions",
                table: "CandidateCompetions");

            migrationBuilder.RenameTable(
                name: "CandidateCompetions",
                newName: "CandidateCompetitions");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateCompetions_CompetionId",
                table: "CandidateCompetitions",
                newName: "IX_CandidateCompetitions_CompetionId");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateCompetions_CandidateId",
                table: "CandidateCompetitions",
                newName: "IX_CandidateCompetitions_CandidateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CandidateCompetitions",
                table: "CandidateCompetitions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateCompetitions_Candidates_CandidateId",
                table: "CandidateCompetitions",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateCompetitions_Competions_CompetionId",
                table: "CandidateCompetitions",
                column: "CompetionId",
                principalTable: "Competions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateCompetitions_Candidates_CandidateId",
                table: "CandidateCompetitions");

            migrationBuilder.DropForeignKey(
                name: "FK_CandidateCompetitions_Competions_CompetionId",
                table: "CandidateCompetitions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CandidateCompetitions",
                table: "CandidateCompetitions");

            migrationBuilder.RenameTable(
                name: "CandidateCompetitions",
                newName: "CandidateCompetions");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateCompetitions_CompetionId",
                table: "CandidateCompetions",
                newName: "IX_CandidateCompetions_CompetionId");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateCompetitions_CandidateId",
                table: "CandidateCompetions",
                newName: "IX_CandidateCompetions_CandidateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CandidateCompetions",
                table: "CandidateCompetions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateCompetions_Candidates_CandidateId",
                table: "CandidateCompetions",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateCompetions_Competions_CompetionId",
                table: "CandidateCompetions",
                column: "CompetionId",
                principalTable: "Competions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
