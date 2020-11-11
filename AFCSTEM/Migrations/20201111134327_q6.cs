using Microsoft.EntityFrameworkCore.Migrations;

namespace AFCSTEM.Migrations
{
    public partial class q6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "act6avgAge",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act6avgHeight",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act6q1",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act6q10",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act6q11",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act6q12",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act6q2",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act6q3",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act6q4",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act6q5",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act6q6",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act6q7",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act6q8",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act6q9",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act6table1",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "act6tablecount",
                table: "Workbook",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "act6avgAge",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act6avgHeight",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act6q1",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act6q10",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act6q11",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act6q12",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act6q2",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act6q3",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act6q4",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act6q5",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act6q6",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act6q7",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act6q8",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act6q9",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act6table1",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act6tablecount",
                table: "Workbook");
        }
    }
}
