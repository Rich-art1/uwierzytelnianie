using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FizzBuzzNET.Migrations
{
    public partial class InitSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fizzbuzz",
                columns: table => new
                {
            userMail = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
            Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: true),
                    Number = table.Column<int>(nullable: false),
                    Wynik = table.Column<string>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fizzbuzz", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fizzbuzz");
        }
    }
}
