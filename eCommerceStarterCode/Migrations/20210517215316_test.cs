using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b034e35-c520-41fa-ae5d-511e23365823");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a57b95cc-624d-4c93-8397-3ba2866a12da");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ea604aa2-4e76-4346-a669-13f722435bc3", "fc8f501e-1cf2-4e04-b424-cb133ffccf4a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8795f4f3-7f11-4536-afe9-de78ca399a86", "4af62a9c-a4ff-4a7a-8bfe-4d8dec19cf5c", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8795f4f3-7f11-4536-afe9-de78ca399a86");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea604aa2-4e76-4346-a669-13f722435bc3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a57b95cc-624d-4c93-8397-3ba2866a12da", "8946fe3b-c521-499b-b6bc-001904da6e56", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b034e35-c520-41fa-ae5d-511e23365823", "73eb3f1e-30ce-40f8-825e-9b1182ed5b22", "Admin", "ADMIN" });
        }
    }
}
