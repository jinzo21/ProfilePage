using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProfileWebCore.Migrations
{
    public partial class InitialMigrationProfileDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Configuration",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccessKey = table.Column<string>(type: "NVARCHAR(32)", nullable: false),
                    AccessValue = table.Column<string>(type: "NVARCHAR(128)", nullable: false),
                    Created = table.Column<DateTime>(type: "DATETIME2(7) DEFAULT (GETUTCDATE())", nullable: false),
                    Updated = table.Column<DateTime>(type: "DATETIME2(7) DEFAULT (GETUTCDATE())", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PokemonId = table.Column<string>(maxLength: 32, nullable: false),
                    PokemonName = table.Column<string>(maxLength: 128, nullable: false),
                    PokemonDescription = table.Column<string>(maxLength: 1000, nullable: false),
                    PokemonHeight = table.Column<string>(maxLength: 64, nullable: false),
                    PokemonWeight = table.Column<string>(maxLength: 64, nullable: false),
                    PokemonType = table.Column<string>(maxLength: 64, nullable: false),
                    PokemonImage = table.Column<string>(maxLength: 360, nullable: false),
                    PokemonImageSFront = table.Column<string>(maxLength: 360, nullable: false),
                    PokemonImageSBack = table.Column<string>(maxLength: 360, nullable: false),
                    StatHp = table.Column<string>(maxLength: 64, nullable: false),
                    StatAttack = table.Column<string>(maxLength: 64, nullable: false),
                    StatDefense = table.Column<string>(maxLength: 64, nullable: false),
                    StatSpAttack = table.Column<string>(maxLength: 64, nullable: false),
                    StatSpDefense = table.Column<string>(maxLength: 64, nullable: false),
                    StatSpeed = table.Column<string>(maxLength: 64, nullable: false),
                    StatTotal = table.Column<string>(maxLength: 64, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "DATETIME2(7) DEFAULT (GETUTCDATE())", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "DATETIME2(7) DEFAULT (GETUTCDATE())", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuration");

            migrationBuilder.DropTable(
                name: "Pokemon");
        }
    }
}
