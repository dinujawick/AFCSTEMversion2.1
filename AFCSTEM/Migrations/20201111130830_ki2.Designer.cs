﻿// <auto-generated />
using System;
using AFCSTEM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AFCSTEM.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201111130830_ki2")]
    partial class ki2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AFCSTEM.Areas.Identity.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("School");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("AFCSTEM.Models.Player", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<double>("BehindsAvg");

                    b.Property<int>("BehindsTotal");

                    b.Property<double>("CentreClearanceAvg");

                    b.Property<int>("CentreClearanceTotal");

                    b.Property<double>("ClearanceAvg");

                    b.Property<int>("ClearanceTotal");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<double>("DisposalAvg");

                    b.Property<int>("DisposalTotal");

                    b.Property<string>("Gender");

                    b.Property<double>("GoalsAvg");

                    b.Property<int>("GoalsTotal");

                    b.Property<double>("HOAvg");

                    b.Property<int>("HOTotal");

                    b.Property<double>("HandballAvg");

                    b.Property<int>("HandballTotal");

                    b.Property<int>("Height");

                    b.Property<bool>("Hidden");

                    b.Property<double>("KickAvg");

                    b.Property<int>("KickTotal");

                    b.Property<double>("MarksAvg");

                    b.Property<int>("MarksTotal");

                    b.Property<int>("Matches");

                    b.Property<string>("Name");

                    b.Property<int>("Number");

                    b.Property<string>("Position");

                    b.Property<int>("Price");

                    b.Property<double>("TackleAvg");

                    b.Property<int>("TackleTotal");

                    b.HasKey("ID");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("AFCSTEM.Models.Team", b =>
                {
                    b.Property<string>("StudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DEF1");

                    b.Property<int>("DEF2");

                    b.Property<int>("DEF3");

                    b.Property<int>("DEF4");

                    b.Property<int>("DEF5");

                    b.Property<int>("DEF6");

                    b.Property<int>("FWD1");

                    b.Property<int>("FWD2");

                    b.Property<int>("FWD3");

                    b.Property<int>("FWD4");

                    b.Property<int>("FWD5");

                    b.Property<int>("FWD6");

                    b.Property<int>("MID1");

                    b.Property<int>("MID2");

                    b.Property<int>("MID3");

                    b.Property<int>("MID4");

                    b.Property<int>("RUCK1");

                    b.Property<int>("RUCK2");

                    b.HasKey("StudentId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("AFCSTEM.Models.Workbook", b =>
                {
                    b.Property<string>("StudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Act1Row1");

                    b.Property<string>("Act1Row2");

                    b.Property<string>("Act1Row3");

                    b.Property<string>("Act1Row4");

                    b.Property<string>("Act1Table1");

                    b.Property<string>("Act1Table2");

                    b.Property<string>("Act1Table3");

                    b.Property<float>("Act2BPArea");

                    b.Property<float>("Act2BPLength");

                    b.Property<float>("Act2BPWidth");

                    b.Property<float>("Act2CSArea");

                    b.Property<float>("Act2CSLength");

                    b.Property<float>("Act2CSWidth");

                    b.Property<float>("Act2GPArea");

                    b.Property<float>("Act2GPLength");

                    b.Property<float>("Act2GPWidth");

                    b.Property<float>("Act2GS2Area");

                    b.Property<float>("Act2GS2Length");

                    b.Property<float>("Act2GS2Width");

                    b.Property<float>("Act2GSArea");

                    b.Property<float>("Act2GSLength");

                    b.Property<float>("Act2GSWidth");

                    b.Property<string>("Act2box1");

                    b.Property<string>("Act2box2");

                    b.Property<string>("Act2box3");

                    b.Property<string>("Act2t4");

                    b.Property<string>("Act2t5");

                    b.Property<string>("Act2text1");

                    b.Property<string>("act3q4");

                    b.Property<string>("act3q5");

                    b.Property<string>("act3q6");

                    b.Property<string>("act3q7");

                    b.Property<string>("act3q8");

                    b.Property<string>("act5q1");

                    b.Property<string>("act5q2");

                    b.Property<string>("act5q3");

                    b.Property<string>("act5q4");

                    b.Property<string>("act5q5");

                    b.Property<string>("act5table");

                    b.Property<int>("act5tablecount");

                    b.Property<string>("crowdCapacity");

                    b.Property<float>("gArea");

                    b.Property<float>("gLength");

                    b.Property<float>("gWidth");

                    b.Property<float>("gmhArea");

                    b.Property<float>("gmhLength");

                    b.Property<float>("gmhWidth");

                    b.Property<string>("largestArea");

                    b.Property<float>("mcgArea");

                    b.Property<float>("mcgLength");

                    b.Property<float>("mcgWidth");

                    b.Property<float>("metArea");

                    b.Property<float>("metLength");

                    b.Property<float>("metWidth");

                    b.Property<float>("msArea");

                    b.Property<float>("msLength");

                    b.Property<float>("msWidth");

                    b.Property<float>("osArea");

                    b.Property<float>("osLength");

                    b.Property<float>("osWidth");

                    b.Property<float>("scgArea");

                    b.Property<float>("scgLength");

                    b.Property<float>("scgWidth");

                    b.Property<string>("smallestArea");

                    b.Property<float>("ssArea");

                    b.Property<float>("ssLength");

                    b.Property<float>("ssWidth");

                    b.HasKey("StudentId");

                    b.ToTable("Workbook");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AFCSTEM.Areas.Identity.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AFCSTEM.Areas.Identity.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AFCSTEM.Areas.Identity.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AFCSTEM.Areas.Identity.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
