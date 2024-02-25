using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day6_efcore1.Migrations
{
    /// <inheritdoc />
    public partial class db_relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branch_db",
                columns: table => new
                {
                    branch_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    branch_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch_db", x => x.branch_id);
                });

            migrationBuilder.CreateTable(
                name: "Outfits_db",
                columns: table => new
                {
                    outfit_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    outfit_type = table.Column<int>(type: "int", nullable: false),
                    outfit_no = table.Column<short>(type: "smallint", nullable: false),
                    outfit_brand_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outfits_db", x => x.outfit_id);
                });

            migrationBuilder.CreateTable(
                name: "Teams_db",
                columns: table => new
                {
                    team_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    team_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams_db", x => x.team_id);
                });

            migrationBuilder.CreateTable(
                name: "Players_db",
                columns: table => new
                {
                    player_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    player_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    player_age = table.Column<int>(type: "int", nullable: false),
                    branch_id = table.Column<int>(type: "int", nullable: false),
                    team_id = table.Column<int>(type: "int", nullable: false),
                    outfit_id = table.Column<int>(type: "int", nullable: false),
                    player_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players_db", x => x.player_id);
                    table.ForeignKey(
                        name: "FK_Players_db_Branch_db_branch_id",
                        column: x => x.branch_id,
                        principalTable: "Branch_db",
                        principalColumn: "branch_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Players_db_Outfits_db_outfit_id",
                        column: x => x.outfit_id,
                        principalTable: "Outfits_db",
                        principalColumn: "outfit_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Players_db_Teams_db_team_id",
                        column: x => x.team_id,
                        principalTable: "Teams_db",
                        principalColumn: "team_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Branch_db",
                columns: new[] { "branch_id", "branch_name" },
                values: new object[] { 1, "Football" });

            migrationBuilder.InsertData(
                table: "Outfits_db",
                columns: new[] { "outfit_id", "outfit_brand_name", "outfit_no", "outfit_type" },
                values: new object[] { 1, "Adidas", (short)42, 0 });

            migrationBuilder.InsertData(
                table: "Teams_db",
                columns: new[] { "team_id", "team_name" },
                values: new object[] { 1, "Galatasaray" });

            migrationBuilder.InsertData(
                table: "Players_db",
                columns: new[] { "player_id", "player_age", "branch_id", "player_name", "outfit_id", "player_price", "team_id" },
                values: new object[] { 1, 30, 1, "Mauro Icardi", 1, 300000000m, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Players_db_branch_id",
                table: "Players_db",
                column: "branch_id");

            migrationBuilder.CreateIndex(
                name: "IX_Players_db_outfit_id",
                table: "Players_db",
                column: "outfit_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_db_team_id",
                table: "Players_db",
                column: "team_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players_db");

            migrationBuilder.DropTable(
                name: "Branch_db");

            migrationBuilder.DropTable(
                name: "Outfits_db");

            migrationBuilder.DropTable(
                name: "Teams_db");
        }
    }
}
