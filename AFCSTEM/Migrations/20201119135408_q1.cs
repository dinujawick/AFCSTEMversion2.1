using Microsoft.EntityFrameworkCore.Migrations;

namespace AFCSTEM.Migrations
{
    public partial class q1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "act14q1",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act14q10",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act14q11",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act14q12",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act14q13",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act14q2",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act14q3",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act14q4",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act14q5",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act14q6",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act14q7",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act14q8",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act14q9",
                table: "Workbook",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "act14q1",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act14q10",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act14q11",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act14q12",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act14q13",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act14q2",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act14q3",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act14q4",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act14q5",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act14q6",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act14q7",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act14q8",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act14q9",
                table: "Workbook");
        }
    }
}
