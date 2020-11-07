using Microsoft.EntityFrameworkCore.Migrations;

namespace AFCSTEM.Migrations
{
    public partial class q5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "act5q1",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act5q2",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act5q3",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act5q4",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act5q5",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act5table",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "act5tablecount",
                table: "Workbook",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "act5q1",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act5q2",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act5q3",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act5q4",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act5q5",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act5table",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act5tablecount",
                table: "Workbook");
        }
    }
}
