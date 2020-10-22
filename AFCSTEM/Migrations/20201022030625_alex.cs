using Microsoft.EntityFrameworkCore.Migrations;

namespace AFCSTEM.Migrations
{
    public partial class alex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Act2CSArea",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Act2CSLength",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Act2CSWidth",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Act2CSArea",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act2CSLength",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act2CSWidth",
                table: "Workbook");
        }
    }
}
