using Microsoft.EntityFrameworkCore.Migrations;

namespace AFCSTEM.Migrations
{
    public partial class q14l : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "act14q12",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act14q13",
                table: "Workbook");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "act14q12",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act14q13",
                table: "Workbook",
                nullable: true);
        }
    }
}
