using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProductCatalog.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    BrandName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    CategoryName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(type: "varchar(4000)", maxLength: 4000, nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    SellersName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    State = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sku",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(type: "varchar(4000)", maxLength: 4000, nullable: false),
                    Ean = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    ProductId1 = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    SalePrice = table.Column<decimal>(type: "money", nullable: false),
                    State = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sku", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sku_Product_ProductId1",
                        column: x => x.ProductId1,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sku_ProductId1",
                table: "Sku",
                column: "ProductId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sku");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
