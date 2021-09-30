using Microsoft.EntityFrameworkCore.Migrations;

namespace Burgerking.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Burger",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prijs = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Broodje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vlees = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Saus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burger", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dessert",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prijs = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BevatSoja = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dessert", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Burger");

            migrationBuilder.DropTable(
                name: "Dessert");
        }
    }
}
