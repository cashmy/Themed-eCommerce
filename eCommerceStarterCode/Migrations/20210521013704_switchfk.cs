using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class switchfk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59452131-f19c-499d-bc3b-fabcb1dd21cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a95f00cc-6203-40d4-9b60-3a84042be72b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5bc8d3c3-e2a8-42b0-88e3-df184d134439", "0e4b2b86-aa6c-4966-b74a-d03aec0662c2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "673b519e-ec25-4873-94af-d938de07fb88", "6b37cc22-6a87-4582-b425-4f349d4b72fc", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5bc8d3c3-e2a8-42b0-88e3-df184d134439");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "673b519e-ec25-4873-94af-d938de07fb88");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59452131-f19c-499d-bc3b-fabcb1dd21cc", "1587808d-2482-4af5-ae53-e1f9c05cce74", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a95f00cc-6203-40d4-9b60-3a84042be72b", "474555a5-0d50-4cab-8366-d00afcca7e51", "Admin", "ADMIN" });
        }
    }
}
