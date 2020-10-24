using Microsoft.EntityFrameworkCore.Migrations;

namespace Cotizacion.App.Migrations
{
    public partial class Sql2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Clients_ClientId",
                table: "Quotes");

            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Products_ProductId",
                table: "Quotes");

            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Sellers_SellerId",
                table: "Quotes");

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "Quotes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Quotes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Quotes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Clients_ClientId",
                table: "Quotes",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Products_ProductId",
                table: "Quotes",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Sellers_SellerId",
                table: "Quotes",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Clients_ClientId",
                table: "Quotes");

            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Products_ProductId",
                table: "Quotes");

            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Sellers_SellerId",
                table: "Quotes");

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "Quotes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Quotes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Quotes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Clients_ClientId",
                table: "Quotes",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Products_ProductId",
                table: "Quotes",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Sellers_SellerId",
                table: "Quotes",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
