using Microsoft.EntityFrameworkCore.Migrations;

namespace AFCSTEM.Migrations
{
    public partial class q9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "act9table1",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act9table2",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act9table3",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act9table4",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act9table5",
                table: "Workbook",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "act9table1",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act9table2",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act9table3",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act9table4",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act9table5",
                table: "Workbook");
        }
    }
}
