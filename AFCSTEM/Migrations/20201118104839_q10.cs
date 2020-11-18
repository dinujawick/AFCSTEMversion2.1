using Microsoft.EntityFrameworkCore.Migrations;

namespace AFCSTEM.Migrations
{
    public partial class q10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "act10q1",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act10q2",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act10q3",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act10table1",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act10table2",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act10table3",
                table: "Workbook",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "act10q1",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act10q2",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act10q3",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act10table1",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act10table2",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act10table3",
                table: "Workbook");
        }
    }
}
