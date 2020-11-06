using Microsoft.EntityFrameworkCore.Migrations;

namespace AFCSTEM.Migrations
{
    public partial class q2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Act2BPArea",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Act2BPLength",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Act2BPWidth",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Act2GPArea",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Act2GPLength",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Act2GPWidth",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Act2GS2Area",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Act2GS2Length",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Act2GS2Width",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Act2GSArea",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Act2GSLength",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Act2GSWidth",
                table: "Workbook",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Act2box1",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Act2box2",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Act2box3",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Act2t4",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Act2t5",
                table: "Workbook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Act2text1",
                table: "Workbook",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Act2BPArea",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act2BPLength",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act2BPWidth",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act2GPArea",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act2GPLength",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act2GPWidth",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act2GS2Area",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act2GS2Length",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act2GS2Width",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act2GSArea",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act2GSLength",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act2GSWidth",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act2box1",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act2box2",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act2box3",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act2t4",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act2t5",
                table: "Workbook");

            migrationBuilder.DropColumn(
                name: "Act2text1",
                table: "Workbook");
        }
    }
}
