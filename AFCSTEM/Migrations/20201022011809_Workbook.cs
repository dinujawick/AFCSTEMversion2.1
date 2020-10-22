using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AFCSTEM.Migrations
{
    public partial class Workbook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "Workbook",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    Act1Table1 = table.Column<string>(nullable: true),
                    Act1Table2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workbook", x => x.StudentId);
                });

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
