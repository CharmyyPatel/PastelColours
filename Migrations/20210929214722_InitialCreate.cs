using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace pastel.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Program1",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    PowerAcquisitionDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    meaning = table.Column<string>(type: "TEXT", nullable: true),
                    mix1 = table.Column<string>(type: "TEXT", nullable: true),
                    mix2 = table.Column<string>(type: "TEXT", nullable: true),
                    hexcode = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Program1", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Program1");
        }
    }
}
