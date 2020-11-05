using Microsoft.EntityFrameworkCore.Migrations;

namespace AFCSTEM.Migrations
{
    public partial class ax : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Act1Row1",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Act1Row2",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Act1Row3",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Act1Row4",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Act1Table3",
                table: "Workbook",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Act1Row1",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act1Row2",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act1Row3",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act1Row4",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act1Table3",
                table: "Workbook");
        }
    }
}
