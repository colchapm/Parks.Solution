using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100) CHARACTER SET utf8mb4", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Type = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Location", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Washington", "Olympic National Park", "National" },
                    { 2, "Washington", "North Cascades National Park", "National" },
                    { 3, "Washington", "Mount Rainier National Park", "National" },
                    { 4, "Washington", "Cape Disappointment State Park", "State" },
                    { 5, "Washington", "Deception Pass State Park", "State" },
                    { 6, "Oregon", "Crater Lake National Park", "National" },
                    { 7, "Oregon", "Smith Rock State Park", "State" },
                    { 8, "California", "Joshua Tree National Park", "National" },
                    { 9, "California", "Sequoia National Park", "National" },
                    { 10, "Oregon", "Milo McIver State Park", "State" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
