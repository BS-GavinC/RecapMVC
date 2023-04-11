using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Recap.Migrations
{
    /// <inheritdoc />
    public partial class populate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "ID", "Email", "Firstname", "Lastname", "Password" },
                values: new object[,]
                {
                    { 1, "alice.dupont@email.com", "Alice", "Dupont", "Jt8L$ndm&kFq24cS" },
                    { 2, "bob.martin@email.com", "Bob", "Martin", "5Gh#zBvKw3PxYrE" },
                    { 3, "charlie.nguyen@email.com", "Charlie", "Nguyen", "fT7#eRm2QxLz9Dy$" },
                    { 4, "david.lee@email.com", "David", "Lee", "V6b$UwPcNz @hM8xK" },
                    { 5, "emma.garcia@email.com", "Emma", "Garcia", "aH5%kXjL9$qBm2W" },
                    { 6, "frank.chen@email.com", "Frank", "Chen", "qJ9@fM8cWu5$xLrE" },
                    { 7, "grace.wong@email.com", "Grace", "Wong", "7Km&zRb#vGy2hNj" },
                    { 8, "henry.zhang@email.com", "Henry", "Zhang", "T4c#nSv@wGj2RkF" },
                    { 9, "isabella.lopez@email.com", "Isabella", "Lopez", "H8f$kL3q#sVp9Xy" },
                    { 10, "jack.kim@email.com", "Jack", "Kim", "3ZgY*6tLx#pVfDhN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: 10);
        }
    }
}
