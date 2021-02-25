using Microsoft.EntityFrameworkCore.Migrations;

namespace AFCSTEM.Migrations
{
    public partial class q8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "act8q1",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act8q10",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act8q11",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act8q12",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act8q13",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act8q14",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act8q15",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act8q16",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act8q17",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act8q18",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act8q2",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act8q3",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act8q4",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act8q5",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act8q6",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act8q7",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act8q8",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act8q9",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act8table1",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act8table2",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act8table3",
                table: "Workbook",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "act8q1",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act8q10",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act8q11",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act8q12",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act8q13",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act8q14",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act8q15",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act8q16",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act8q17",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act8q18",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act8q2",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act8q3",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act8q4",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act8q5",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act8q6",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act8q7",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act8q8",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act8q9",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act8table1",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act8table2",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act8table3",
                table: "Workbook");
        }
    }
}
