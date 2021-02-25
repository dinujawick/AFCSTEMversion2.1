using Microsoft.EntityFrameworkCore.Migrations;

namespace AFCSTEM.Migrations
{
    public partial class q16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "act16table1",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act16table2",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act16table3",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act16table4",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act16table5",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act16table6",
                table: "Workbook",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "act16table1",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act16table2",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act16table3",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act16table4",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act16table5",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act16table6",
                table: "Workbook");
        }
    }
}
