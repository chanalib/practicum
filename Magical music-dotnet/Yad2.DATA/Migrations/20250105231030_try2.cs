using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yad2.DATA.Migrations
{
    public partial class try2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Advertisers_AdvertiserId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Advertisers_AdvertiserId1",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Customers_CustomerId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Customers_CustomerId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_AdvertiserId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CustomerId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AdvertiserId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "Products");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Advertisers_AdvertiserId",
                table: "Products",
                column: "AdvertiserId",
                principalTable: "Advertisers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Customers_CustomerId",
                table: "Products",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Advertisers_AdvertiserId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Customers_CustomerId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "AdvertiserId1",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId1",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_AdvertiserId1",
                table: "Products",
                column: "AdvertiserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CustomerId1",
                table: "Products",
                column: "CustomerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Advertisers_AdvertiserId",
                table: "Products",
                column: "AdvertiserId",
                principalTable: "Advertisers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Advertisers_AdvertiserId1",
                table: "Products",
                column: "AdvertiserId1",
                principalTable: "Advertisers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Customers_CustomerId",
                table: "Products",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Customers_CustomerId1",
                table: "Products",
                column: "CustomerId1",
                principalTable: "Customers",
                principalColumn: "Id");
        }
    }
}
