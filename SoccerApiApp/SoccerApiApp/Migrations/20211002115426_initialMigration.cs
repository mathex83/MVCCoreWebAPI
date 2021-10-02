using Microsoft.EntityFrameworkCore.Migrations;

namespace SoccerApiApp.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fixture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    HomeTeam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AwayTeam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeScore = table.Column<int>(type: "int", nullable: false),
                    AwayScore = table.Column<int>(type: "int", nullable: false),
                    FixtureDateTime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fixture", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fixture");
        }
    }
}
