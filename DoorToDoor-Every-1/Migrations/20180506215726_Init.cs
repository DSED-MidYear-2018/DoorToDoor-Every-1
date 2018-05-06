using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DoorToDoor_Every_1.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressContact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AddressId = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    DoorAnswered = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    FollowUp = table.Column<bool>(nullable: false),
                    Interested = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: true),
                    StreetName = table.Column<string>(nullable: true),
                    StreetNumber = table.Column<int>(nullable: false),
                    Suburb = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    Visited = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressContact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    City = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    DoorAnswered = table.Column<bool>(nullable: false),
                    FollowUp = table.Column<bool>(nullable: false),
                    Interested = table.Column<bool>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: false),
                    StreetName = table.Column<string>(nullable: false),
                    StreetNumber = table.Column<int>(nullable: false),
                    Suburb = table.Column<string>(nullable: false),
                    Unit = table.Column<string>(nullable: true),
                    Visited = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdminRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AddressId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FollowUps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AddressId = table.Column<int>(nullable: false),
                    DateReturn = table.Column<string>(nullable: true),
                    OccuranceId = table.Column<int>(nullable: false),
                    TimeReturn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowUps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Occurances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occurances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AdminRoleId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admins_AdminRole_AdminRoleId",
                        column: x => x.AdminRoleId,
                        principalTable: "AdminRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_AdminRoleId",
                table: "Admins",
                column: "AdminRoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressContact");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "FollowUps");

            migrationBuilder.DropTable(
                name: "Occurances");

            migrationBuilder.DropTable(
                name: "AdminRole");
        }
    }
}
