using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class RenameColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateLanguages_Languages_LanguageId",
                table: "CandidateLanguages");

            migrationBuilder.DropColumn(
                name: "LaguageId",
                table: "CandidateLanguages");

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "CandidateLanguages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateLanguages_Languages_LanguageId",
                table: "CandidateLanguages",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateLanguages_Languages_LanguageId",
                table: "CandidateLanguages");

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "CandidateLanguages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "LaguageId",
                table: "CandidateLanguages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateLanguages_Languages_LanguageId",
                table: "CandidateLanguages",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id");
        }
    }
}
