using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class AddCandiatePosition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateTrainings_AcademicLevel_AcademicLevelId",
                table: "CandidateTrainings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AcademicLevel",
                table: "AcademicLevel");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Candidates");

            migrationBuilder.RenameTable(
                name: "AcademicLevel",
                newName: "AcademicLevels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AcademicLevels",
                table: "AcademicLevels",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CandidatePositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidatePositions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CandidatePositions_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidatePositions_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidatePositions_CandidateId",
                table: "CandidatePositions",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidatePositions_PositionId",
                table: "CandidatePositions",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateTrainings_AcademicLevels_AcademicLevelId",
                table: "CandidateTrainings",
                column: "AcademicLevelId",
                principalTable: "AcademicLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateTrainings_AcademicLevels_AcademicLevelId",
                table: "CandidateTrainings");

            migrationBuilder.DropTable(
                name: "CandidatePositions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AcademicLevels",
                table: "AcademicLevels");

            migrationBuilder.RenameTable(
                name: "AcademicLevels",
                newName: "AcademicLevel");

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "Candidates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AcademicLevel",
                table: "AcademicLevel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateTrainings_AcademicLevel_AcademicLevelId",
                table: "CandidateTrainings",
                column: "AcademicLevelId",
                principalTable: "AcademicLevel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
