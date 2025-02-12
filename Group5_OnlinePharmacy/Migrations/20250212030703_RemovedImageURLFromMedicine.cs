using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group5_OnlinePharmacy.Migrations
{
    /// <inheritdoc />
    public partial class RemovedImageURLFromMedicine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c8bfd23-1eb2-4904-bb61-143f0a2d1b60", "AQAAAAIAAYagAAAAEGSYt16jwi/dLpzVrXB9tQ4l1ExcLXEbt2HR7hzsX5d39GouN3BNp3799JuwCP1G5g==", "02934033-fa38-44c1-a4ea-6f8ec1f0c1b9" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c726cb7-259c-4642-b6e8-c88d1686ec2b", "AQAAAAIAAYagAAAAEDwkd1sdOm5MNUoPj7gHOm/gW3bgvmaNVSAePB8QHoeaElfsfzX3CyvLpQ7oAqkvEg==", "5362f096-2775-43ce-935f-c2d4f8dd0438" });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "/images/Cough/Difflam.jpg");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "/images/Cough/Pei Pa Koa.jpg");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: "/images/Diarrhea/Lacteolfort.jpg");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: "/images/Eye Care/Moist Eye-mo.jpg");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageURL",
                value: "/images/Flu/Clarityne.jpg");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageURL",
                value: "/images/Indigestion/Gaviscon.jpg");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageURL",
                value: "/images/Pain/Panadol.png");
        }
    }
}
