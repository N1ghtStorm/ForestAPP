using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ForestTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForestTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TreeTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Forests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    ForestTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Forests_ForestTypes_ForestTypeId",
                        column: x => x.ForestTypeId,
                        principalTable: "ForestTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    TreeTypeId = table.Column<int>(nullable: false),
                    ForestID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trees_Forests_ForestID",
                        column: x => x.ForestID,
                        principalTable: "Forests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trees_TreeTypes_TreeTypeId",
                        column: x => x.TreeTypeId,
                        principalTable: "TreeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Forests_ForestTypeId",
                table: "Forests",
                column: "ForestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Trees_ForestID",
                table: "Trees",
                column: "ForestID");

            migrationBuilder.CreateIndex(
                name: "IX_Trees_TreeTypeId",
                table: "Trees",
                column: "TreeTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trees");

            migrationBuilder.DropTable(
                name: "Forests");

            migrationBuilder.DropTable(
                name: "TreeTypes");

            migrationBuilder.DropTable(
                name: "ForestTypes");
        }
    }
}
