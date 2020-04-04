using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class SeedForestType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ForestTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Oak" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ForestTypes",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
