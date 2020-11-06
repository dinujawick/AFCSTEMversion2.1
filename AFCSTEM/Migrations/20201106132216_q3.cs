using Microsoft.EntityFrameworkCore.Migrations;

namespace AFCSTEM.Migrations
{
    public partial class q3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "act3q4",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act3q5",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act3q6",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act3q7",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "act3q8",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "crowdCapacity",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "gArea",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "gLength",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "gWidth",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "gmhArea",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "gmhLength",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "gmhWidth",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "largestArea",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "mcgArea",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "mcgLength",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "mcgWidth",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "metArea",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "metLength",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "metWidth",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "msArea",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "msLength",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "msWidth",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "osArea",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "osLength",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "osWidth",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "scgArea",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "scgLength",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "scgWidth",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "smallestArea",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "ssArea",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ssLength",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ssWidth",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "act3q4",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act3q5",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act3q6",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act3q7",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "act3q8",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "crowdCapacity",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "gArea",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "gLength",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "gWidth",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "gmhArea",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "gmhLength",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "gmhWidth",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "largestArea",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "mcgArea",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "mcgLength",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "mcgWidth",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "metArea",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "metLength",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "metWidth",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "msArea",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "msLength",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "msWidth",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "osArea",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "osLength",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "osWidth",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "scgArea",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "scgLength",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "scgWidth",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "smallestArea",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "ssArea",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "ssLength",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "ssWidth",
                table: "Workbook");
        }
    }
}
