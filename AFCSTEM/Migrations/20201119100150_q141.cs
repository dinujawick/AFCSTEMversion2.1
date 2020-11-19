using Microsoft.EntityFrameworkCore.Migrations;

namespace AFCSTEM.Migrations
{
    public partial class q141 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "act14graph1",
                table: "Workbook",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "act14graph1",
                table: "Workbook");
        }
    }
}
