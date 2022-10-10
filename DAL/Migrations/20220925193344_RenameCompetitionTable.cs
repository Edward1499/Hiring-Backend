using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class RenameCompetitionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateCompetitions_Competions_CompetionId",
                table: "CandidateCompetitions");

            migrationBuilder.DropTable(
                name: "Competions");

            migrationBuilder.RenameColumn(
                name: "CompetionId",
                table: "CandidateCompetitions",
                newName: "CompetitionId");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateCompetitions_CompetionId",
                table: "CandidateCompetitions",
                newName: "IX_CandidateCompetitions_CompetitionId");

            migrationBuilder.CreateTable(
                name: "Competitions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateCompetitions_Competitions_CompetitionId",
                table: "CandidateCompetitions",
                column: "CompetitionId",
                principalTable: "Competitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateCompetitions_Competitions_CompetitionId",
                table: "CandidateCompetitions");

            migrationBuilder.DropTable(
                name: "Competitions");

            migrationBuilder.RenameColumn(
                name: "CompetitionId",
                table: "CandidateCompetitions",
                newName: "CompetionId");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateCompetitions_CompetitionId",
                table: "CandidateCompetitions",
                newName: "IX_CandidateCompetitions_CompetionId");

            migrationBuilder.CreateTable(
                name: "Competions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UpatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competions", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateCompetitions_Competions_CompetionId",
                table: "CandidateCompetitions",
                column: "CompetionId",
                principalTable: "Competions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
