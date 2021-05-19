using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class orderdetailextprice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bdafd720-b90e-4a43-b25e-3c3ab4676b6c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e93d1e09-7779-454e-91eb-155678f70c0d");

            migrationBuilder.AlterColumn<decimal>(
                name: "ExtPrice",
                table: "OrderDetail",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "afd38af6-dcde-42ec-adbb-29d81a1265e0", "e094b27f-8b35-4a63-b6bb-328130e6a663", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "66cb27a3-03e6-4096-850a-2076c555a69c", "c9a2b8fb-9c90-4c11-b5c1-8008d386d0a2", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66cb27a3-03e6-4096-850a-2076c555a69c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afd38af6-dcde-42ec-adbb-29d81a1265e0");

            migrationBuilder.AlterColumn<int>(
                name: "ExtPrice",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bdafd720-b90e-4a43-b25e-3c3ab4676b6c", "238d626b-d5b4-4e39-9be2-0e6d71e2c6fa", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e93d1e09-7779-454e-91eb-155678f70c0d", "ba094932-e60a-4719-b06a-1367644fcd55", "Admin", "ADMIN" });
        }
    }
}
