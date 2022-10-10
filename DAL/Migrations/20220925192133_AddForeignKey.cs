using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class AddForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Candidates",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_DepartmentId",
                table: "Candidates",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Departments_DepartmentId",
                table: "Candidates",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Departments_DepartmentId",
                table: "Candidates");

            migrationBuilder.DropIndex(
                name: "IX_Candidates_DepartmentId",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Candidates");
        }
    }
}
