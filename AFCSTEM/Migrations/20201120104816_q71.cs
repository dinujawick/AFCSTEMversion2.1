using Microsoft.EntityFrameworkCore.Migrations;

namespace AFCSTEM.Migrations
{
    public partial class q71 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "act17q1",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act17q2",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act17q3",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act17q4",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act17q5",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act17q6",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act17q7",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act17table1",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act17table2",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act17table3",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act17table4",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act17table5",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act17table6",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act17table7",
                table: "Workbook",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "act17q1",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act17q2",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act17q3",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act17q4",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act17q5",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act17q6",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act17q7",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act17table1",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act17table2",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act17table3",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act17table4",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act17table5",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act17table6",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act17table7",
                table: "Workbook");
        }
    }
}
