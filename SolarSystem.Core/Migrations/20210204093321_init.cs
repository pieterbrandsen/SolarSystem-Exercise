using Microsoft.EntityFrameworkCore.Migrations;

namespace SolarSystem.Core.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Class = table.Column<int>(type: "int", nullable: false),
                    OrbitDistance = table.Column<long>(type: "bigint", nullable: false),
                    OrbitPeriod = table.Column<double>(type: "float", nullable: false),
                    KnownMoons = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diameter = table.Column<long>(type: "bigint", nullable: false),
                    SurfaceTempMax = table.Column<double>(type: "float", nullable: false),
                    SurfaceTempMin = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmountOfOrbitingPlanets = table.Column<byte>(type: "tinyint", nullable: false),
                    Age = table.Column<long>(type: "bigint", nullable: false),
                    CoreTemp = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diameter = table.Column<long>(type: "bigint", nullable: false),
                    SurfaceTempMax = table.Column<double>(type: "float", nullable: false),
                    SurfaceTempMin = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "Class", "Diameter", "KnownMoons", "Name", "OrbitDistance", "OrbitPeriod", "SurfaceTempMax", "SurfaceTempMin" },
                values: new object[,]
                {
                    { 1, 0, 4879L, (byte)0, "Mercury", 57900000L, 88.0, 173.0, -427.0 },
                    { 2, 0, 12104L, (byte)0, "Venus", 108200000L, 224.69999999999999, 462.0, 462.0 },
                    { 3, 0, 12756L, (byte)1, "Earth", 149600000L, 365.19999999999999, 58.0, -88.0 },
                    { 4, 0, 6805L, (byte)2, "Mars", 227900000L, 693.5, -63.0, -63.0 },
                    { 5, 1, 950L, (byte)0, "Ceres", 413700000L, 1678.9999999999998, -105.0, -105.0 },
                    { 6, 0, 142984L, (byte)67, "Jupiter", 778300000L, 4343.5, -108.0, -108.0 },
                    { 7, 0, 120536L, (byte)62, "Saturn", 1400000000L, 10767.5, -139.0, -139.0 },
                    { 8, 0, 51118L, (byte)27, "Uranus", 2900000000L, 30660.0, -197.0, -197.0 },
                    { 9, 0, 49528L, (byte)14, "Neptune", 4500000000L, 60152.000000000007, -201.0, -201.0 },
                    { 10, 1, 2306L, (byte)5, "Uranus", 5900000000L, 89790.0, -229.0, -229.0 }
                });

            migrationBuilder.InsertData(
                table: "Stars",
                columns: new[] { "Id", "Age", "AmountOfOrbitingPlanets", "CoreTemp", "Diameter", "Name", "SurfaceTempMax", "SurfaceTempMin" },
                values: new object[] { 1, 4600000000L, (byte)13, 15000000L, 1392684L, "Sun", 5500.0, 5500.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planets");

            migrationBuilder.DropTable(
                name: "Stars");
        }
    }
}
