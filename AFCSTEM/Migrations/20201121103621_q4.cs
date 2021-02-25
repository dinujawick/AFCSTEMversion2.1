using Microsoft.EntityFrameworkCore.Migrations;

namespace AFCSTEM.Migrations
{
    public partial class q4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "act4q1",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act4q2",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act4table1",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act4table2",
                table: "Workbook",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "act4q1",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act4q2",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act4table1",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act4table2",
                table: "Workbook");
        }
    }
}
