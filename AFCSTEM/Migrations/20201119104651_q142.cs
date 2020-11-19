using Microsoft.EntityFrameworkCore.Migrations;

namespace AFCSTEM.Migrations
{
    public partial class q142 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "act14graph2",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act14graph3",
                table: "Workbook",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "act14graph2",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act14graph3",
                table: "Workbook");
        }
    }
}
