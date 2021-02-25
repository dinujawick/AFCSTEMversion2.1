using Microsoft.EntityFrameworkCore.Migrations;

namespace AFCSTEM.Migrations
{
    public partial class q6tabes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "act6table3",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act6table4",
                table: "Workbook",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "act6table3",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act6table4",
                table: "Workbook");
        }
    }
}
