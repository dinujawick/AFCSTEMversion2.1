using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AFCSTEM.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    School = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    KickAvg = table.Column<double>(nullable: false),
                    KickTotal = table.Column<int>(nullable: false),
                    HandballAvg = table.Column<double>(nullable: false),
                    HandballTotal = table.Column<int>(nullable: false),
                    DisposalAvg = table.Column<double>(nullable: false),
                    DisposalTotal = table.Column<int>(nullable: false),
                    MarksAvg = table.Column<double>(nullable: false),
                    MarksTotal = table.Column<int>(nullable: false),
                    HOAvg = table.Column<double>(nullable: false),
                    HOTotal = table.Column<int>(nullable: false),
                    ClearanceAvg = table.Column<double>(nullable: false),
                    ClearanceTotal = table.Column<int>(nullable: false),
                    CentreClearanceAvg = table.Column<double>(nullable: false),
                    CentreClearanceTotal = table.Column<int>(nullable: false),
                    TackleAvg = table.Column<double>(nullable: false),
                    TackleTotal = table.Column<int>(nullable: false),
                    GoalsAvg = table.Column<double>(nullable: false),
                    GoalsTotal = table.Column<int>(nullable: false),
                    BehindsAvg = table.Column<double>(nullable: false),
                    BehindsTotal = table.Column<int>(nullable: false),
                    Matches = table.Column<int>(nullable: false),
                    Hidden = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    DEF1 = table.Column<int>(nullable: false),
                    DEF2 = table.Column<int>(nullable: false),
                    DEF3 = table.Column<int>(nullable: false),
                    DEF4 = table.Column<int>(nullable: false),
                    DEF5 = table.Column<int>(nullable: false),
                    DEF6 = table.Column<int>(nullable: false),
                    FWD1 = table.Column<int>(nullable: false),
                    FWD2 = table.Column<int>(nullable: false),
                    FWD3 = table.Column<int>(nullable: false),
                    FWD4 = table.Column<int>(nullable: false),
                    FWD5 = table.Column<int>(nullable: false),
                    FWD6 = table.Column<int>(nullable: false),
                    RUCK1 = table.Column<int>(nullable: false),
                    RUCK2 = table.Column<int>(nullable: false),
                    MID1 = table.Column<int>(nullable: false),
                    MID2 = table.Column<int>(nullable: false),
                    MID3 = table.Column<int>(nullable: false),
                    MID4 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Workbook",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    Act1Table1 = table.Column<string>(nullable: true),
                    Act1Table2 = table.Column<string>(nullable: true),
                    Act1Row1 = table.Column<string>(nullable: true),
                    Act1Row2 = table.Column<string>(nullable: true),
                    Act1Row3 = table.Column<string>(nullable: true),
                    Act1Row4 = table.Column<string>(nullable: true),
                    Act1Table3 = table.Column<string>(nullable: true),
                    Act2CSWidth = table.Column<float>(nullable: false),
                    Act2CSArea = table.Column<float>(nullable: false),
                    Act2CSLength = table.Column<float>(nullable: false),
                    Act2GSLength = table.Column<float>(nullable: false),
                    Act2GSWidth = table.Column<float>(nullable: false),
                    Act2GSArea = table.Column<float>(nullable: false),
                    Act2GPLength = table.Column<float>(nullable: false),
                    Act2GPWidth = table.Column<float>(nullable: false),
                    Act2GPArea = table.Column<float>(nullable: false),
                    Act2BPLength = table.Column<float>(nullable: false),
                    Act2BPWidth = table.Column<float>(nullable: false),
                    Act2BPArea = table.Column<float>(nullable: false),
                    Act2box1 = table.Column<string>(nullable: true),
                    Act2box2 = table.Column<string>(nullable: true),
                    Act2box3 = table.Column<string>(nullable: true),
                    Act2text1 = table.Column<string>(nullable: true),
                    Act2t4 = table.Column<string>(nullable: true),
                    Act2t5 = table.Column<string>(nullable: true),
                    Act2GS2Length = table.Column<float>(nullable: false),
                    Act2GS2Width = table.Column<float>(nullable: false),
                    Act2GS2Area = table.Column<float>(nullable: false),
                    mcgLength = table.Column<float>(nullable: false),
                    mcgWidth = table.Column<float>(nullable: false),
                    mcgArea = table.Column<float>(nullable: false),
                    msLength = table.Column<float>(nullable: false),
                    msWidth = table.Column<float>(nullable: false),
                    msArea = table.Column<float>(nullable: false),
                    gmhLength = table.Column<float>(nullable: false),
                    gmhWidth = table.Column<float>(nullable: false),
                    gmhArea = table.Column<float>(nullable: false),
                    scgLength = table.Column<float>(nullable: false),
                    scgWidth = table.Column<float>(nullable: false),
                    scgArea = table.Column<float>(nullable: false),
                    ssLength = table.Column<float>(nullable: false),
                    ssWidth = table.Column<float>(nullable: false),
                    ssArea = table.Column<float>(nullable: false),
                    osLength = table.Column<float>(nullable: false),
                    osWidth = table.Column<float>(nullable: false),
                    osArea = table.Column<float>(nullable: false),
                    gLength = table.Column<float>(nullable: false),
                    gWidth = table.Column<float>(nullable: false),
                    gArea = table.Column<float>(nullable: false),
                    metLength = table.Column<float>(nullable: false),
                    metWidth = table.Column<float>(nullable: false),
                    metArea = table.Column<float>(nullable: false),
                    largestArea = table.Column<string>(nullable: true),
                    smallestArea = table.Column<string>(nullable: true),
                    crowdCapacity = table.Column<string>(nullable: true),
                    act3q4 = table.Column<string>(nullable: true),
                    act3q5 = table.Column<string>(nullable: true),
                    act3q6 = table.Column<string>(nullable: true),
                    act3q7 = table.Column<string>(nullable: true),
                    act3q8 = table.Column<string>(nullable: true),
                    act5table = table.Column<string>(nullable: true),
                    act5tablecount = table.Column<int>(nullable: false),
                    act5q1 = table.Column<string>(nullable: true),
                    act5q2 = table.Column<string>(nullable: true),
                    act5q3 = table.Column<string>(nullable: true),
                    act5q4 = table.Column<string>(nullable: true),
                    act5q5 = table.Column<string>(nullable: true),
                    act6table1 = table.Column<string>(nullable: true),
                    act6tablecount = table.Column<int>(nullable: false),
                    act6avgHeight = table.Column<string>(nullable: true),
                    act6avgAge = table.Column<string>(nullable: true),
                    act6q1 = table.Column<string>(nullable: true),
                    act6q2 = table.Column<string>(nullable: true),
                    act6q3 = table.Column<string>(nullable: true),
                    act6q4 = table.Column<string>(nullable: true),
                    act6q5 = table.Column<string>(nullable: true),
                    act6q6 = table.Column<string>(nullable: true),
                    act6q7 = table.Column<string>(nullable: true),
                    act6q8 = table.Column<string>(nullable: true),
                    act6q9 = table.Column<string>(nullable: true),
                    act6q10 = table.Column<string>(nullable: true),
                    act6q11 = table.Column<string>(nullable: true),
                    act6q12 = table.Column<string>(nullable: true),
                    act9table1 = table.Column<string>(nullable: true),
                    act9table2 = table.Column<string>(nullable: true),
                    act9table3 = table.Column<string>(nullable: true),
                    act9table4 = table.Column<string>(nullable: true),
                    act9table5 = table.Column<string>(nullable: true),
                    act10table1 = table.Column<string>(nullable: true),
                    act10q1 = table.Column<string>(nullable: true),
                    act10q2 = table.Column<string>(nullable: true),
                    act10table2 = table.Column<string>(nullable: true),
                    act10table3 = table.Column<string>(nullable: true),
                    act10q3 = table.Column<string>(nullable: true),
                    act11q1 = table.Column<string>(nullable: true),
                    act11table1 = table.Column<string>(nullable: true),
                    act11q2 = table.Column<string>(nullable: true),
                    act12table1 = table.Column<string>(nullable: true),
                    act12table2 = table.Column<string>(nullable: true),
                    act12q1 = table.Column<string>(nullable: true),
                    act13q1 = table.Column<string>(nullable: true),
                    act13table1 = table.Column<string>(nullable: true),
                    act13table2 = table.Column<string>(nullable: true),
                    act14graph1 = table.Column<string>(nullable: true),
                    act14graph2 = table.Column<string>(nullable: true),
                    act14graph3 = table.Column<string>(nullable: true),
                    act14q1 = table.Column<string>(nullable: true),
                    act14q2 = table.Column<string>(nullable: true),
                    act14q3 = table.Column<string>(nullable: true),
                    act14q4 = table.Column<string>(nullable: true),
                    act14q5 = table.Column<string>(nullable: true),
                    act14q6 = table.Column<string>(nullable: true),
                    act14q7 = table.Column<string>(nullable: true),
                    act14q8 = table.Column<string>(nullable: true),
                    act14q9 = table.Column<string>(nullable: true),
                    act14q10 = table.Column<string>(nullable: true),
                    act14q11 = table.Column<string>(nullable: true),
                    act15quad1 = table.Column<string>(nullable: true),
                    act15table1 = table.Column<string>(nullable: true),
                    act15quad2 = table.Column<string>(nullable: true),
                    act15table2 = table.Column<string>(nullable: true),
                    act15quad3 = table.Column<string>(nullable: true),
                    act15graphpoints = table.Column<string>(nullable: true),
                    act15graphlines = table.Column<string>(nullable: true),
                    act15table4 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workbook", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Workbook");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
