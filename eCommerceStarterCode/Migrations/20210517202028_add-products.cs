using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class addproducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3857d5e7-d75e-4cd6-9319-057c278f1db3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b57576fd-bfae-439a-bb76-f278274526a1");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuantityOnHand = table.Column<int>(type: "int", nullable: false),
                    ProductAverageRating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "24aeaa22-8121-4aa9-b491-75e8eb29719d", "ffe69a62-04c1-40fd-8a07-a71b95d733f4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "82becdaa-206f-4a6f-83f1-64b6a3b2848a", "eaabd597-8f1a-44a6-93b9-4b5a59dde1c5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductAverageRating", "ProductDescription", "ProductImage", "ProductPrice", "QuantityOnHand" },
                values: new object[] { 1, 4m, "Han Solo Action Figure", null, 15m, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24aeaa22-8121-4aa9-b491-75e8eb29719d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82becdaa-206f-4a6f-83f1-64b6a3b2848a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3857d5e7-d75e-4cd6-9319-057c278f1db3", "fde3caad-7c37-4f5e-8c6e-0f88c6c5ad08", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b57576fd-bfae-439a-bb76-f278274526a1", "38612b01-c7bc-4ba7-a76e-7348e45a6c9e", "Admin", "ADMIN" });
        }
    }
}
