using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group5_OnlinePharmacy.Migrations
{
    /// <inheritdoc />
    public partial class AddedMedicineImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b7fb4a9-b94d-4d0a-9e47-a4eae8186f00", "AQAAAAIAAYagAAAAEAlXXvpE4r1nSb/HNFGe3uF/pcwxqWCPQE5hqQgZGYtbE7x3EjUW9PaGvF3FLuCVpQ==", "c14a3344-4a8e-414b-8b6d-e7951ea74a6e" });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageURL",
                value: null);
        }
    }
}
