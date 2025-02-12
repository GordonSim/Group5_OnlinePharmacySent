using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group5_OnlinePharmacy.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMedicineImageURL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3e71057-57d0-49fe-840d-dc41935ec77c", "AQAAAAIAAYagAAAAEE15vFB3+k5t1KnEtt7OZFaHeigQR0AK+0f2jO0m0DIjcWCw5WrDYbZmjAaVuZlIqw==", "3f5f92db-5f94-41a0-b3a8-09634adf4e13" });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "Difflam.jpg");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "Pei Pa Koa.jpg");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: "Lacteolfort.jpg");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: "Moist Eye-mo.jpg");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageURL",
                value: "Clarityne.jpg");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageURL",
                value: "Gaviscon.jpg");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageURL",
                value: "Panadol.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81934920-abd5-48a4-99c5-76449cf4b4c6", "AQAAAAIAAYagAAAAEMdhpJLiPrwazp+b7GrN/Qi43Vv2NHs11O1XQ07Dst1wIJ/wduJGw9Mq91/ywgpiJw==", "39c7d584-a3eb-4078-a53b-c79928112af6" });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "Images/Difflam.jpg");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "Images/Pei Pa Koa.jpg");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: "Images/Lacteolfort.jpg");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: "Images/Moist Eye-mo.jpg");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageURL",
                value: "Images/Clarityne.jpg");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageURL",
                value: "Images/Gaviscon.jpg");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageURL",
                value: "Images/Panadol.jpg");
        }
    }
}
