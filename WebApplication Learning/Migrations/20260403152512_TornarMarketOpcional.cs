using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication_Learning.Migrations
{
    /// <inheritdoc />
    public partial class TornarMarketOpcional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_products_markets_market_id",
                table: "products");

            migrationBuilder.AlterColumn<int>(
                name: "market_id",
                table: "products",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "fk_products_markets_market_id",
                table: "products",
                column: "market_id",
                principalTable: "markets",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_products_markets_market_id",
                table: "products");

            migrationBuilder.AlterColumn<int>(
                name: "market_id",
                table: "products",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "fk_products_markets_market_id",
                table: "products",
                column: "market_id",
                principalTable: "markets",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
