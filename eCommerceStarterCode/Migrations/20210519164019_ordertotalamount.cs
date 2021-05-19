using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class ordertotalamount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a1fff2d-63c1-4631-8109-6e2e916ea90e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b35da6ef-681e-4494-8ef7-521e87be3c4a");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmt",
                table: "OrderHeader",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bdafd720-b90e-4a43-b25e-3c3ab4676b6c", "238d626b-d5b4-4e39-9be2-0e6d71e2c6fa", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e93d1e09-7779-454e-91eb-155678f70c0d", "ba094932-e60a-4719-b06a-1367644fcd55", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bdafd720-b90e-4a43-b25e-3c3ab4676b6c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e93d1e09-7779-454e-91eb-155678f70c0d");

            migrationBuilder.AlterColumn<int>(
                name: "TotalAmt",
                table: "OrderHeader",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b35da6ef-681e-4494-8ef7-521e87be3c4a", "e8747357-61a1-4aec-bbf5-ecf30f339d7b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4a1fff2d-63c1-4631-8109-6e2e916ea90e", "e8f90239-63f9-41b0-9517-9177f7566645", "Admin", "ADMIN" });
        }
    }
}
