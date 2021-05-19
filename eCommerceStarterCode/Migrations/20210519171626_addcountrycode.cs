using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class addcountrycode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66cb27a3-03e6-4096-850a-2076c555a69c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afd38af6-dcde-42ec-adbb-29d81a1265e0");

            migrationBuilder.AddColumn<string>(
                name: "CountryCode",
                table: "OrderHeader",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0b7b077a-ab1a-4574-8908-5c38758ef753", "590a2c3b-021f-44fe-880c-949f8a03258d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cf3a37f2-f4f4-41e9-8247-0c8b64d8f53c", "e6c45377-c74a-460f-80b1-d18dd4564832", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b7b077a-ab1a-4574-8908-5c38758ef753");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf3a37f2-f4f4-41e9-8247-0c8b64d8f53c");

            migrationBuilder.DropColumn(
                name: "CountryCode",
                table: "OrderHeader");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "afd38af6-dcde-42ec-adbb-29d81a1265e0", "e094b27f-8b35-4a63-b6bb-328130e6a663", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "66cb27a3-03e6-4096-850a-2076c555a69c", "c9a2b8fb-9c90-4c11-b5c1-8008d386d0a2", "Admin", "ADMIN" });
        }
    }
}
