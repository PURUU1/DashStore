using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DashStore.Migrations
{
    /// <inheritdoc />
    public partial class AddedMonitorAndStorageCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDateTime", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Storage" },
                    { 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Monitors" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "ImagesJson", "Price", "SpecificationsJson", "Title" },
                values: new object[,]
                {
                    { 9, 5, "USB 3.0 and USB 2.0 compatibility for fast data transfers and high capacity storage on the go.", "https://fakestoreapi.com/img/61IBBVJvSDL._AC_SY879_t.png", "[\"https://fakestoreapi.com/img/61IBBVJvSDL._AC_SY879_t.png\"]", 64.0, "{\"Capacity\":[\"2TB\"],\"Interface\":[\"USB 3.0\",\"USB 2.0\"],\"Type\":[\"HDD\"],\"Color\":[\"Black\"]}", "WD 2TB Elements Portable Hard Drive" },
                    { 10, 5, "Reliable and fast internal SSD for upgrading your PC performance and boot times.", "https://fakestoreapi.com/img/61U7T1koQqL._AC_SX679_t.png", "[\"https://fakestoreapi.com/img/61U7T1koQqL._AC_SX679_t.png\"]", 109.0, "{\"Capacity\":[\"1TB\"],\"Interface\":[\"SATA III 6 Gb/s\"],\"Read Speed\":[\"535MB/s\"],\"Write Speed\":[\"450MB/s\"]}", "SanDisk SSD PLUS 1TB Internal SSD" },
                    { 11, 5, "Remarkable transfer speeds that enable faster bootup and improved overall system performance.", "https://fakestoreapi.com/img/71kWymZ+c+L._AC_SX679_t.png", "[\"https://fakestoreapi.com/img/71kWymZ\\u002Bc\\u002BL._AC_SX679_t.png\"]", 109.0, "{\"Capacity\":[\"256GB\"],\"Technology\":[\"3D NAND\"],\"Form Factor\":[\"2.5 inch\"],\"Interface\":[\"SATA III\"]}", "Silicon Power 256GB SSD 3D NAND" },
                    { 12, 5, "High-capacity portable storage specifically designed for a seamless PlayStation 4 gaming experience.", "https://fakestoreapi.com/img/61mtL65D4cL._AC_SX679_t.png", "[\"https://fakestoreapi.com/img/61mtL65D4cL._AC_SX679_t.png\"]", 114.0, "{\"Capacity\":[\"4TB\"],\"Compatibility\":[\"PS4\",\"PS4 Pro\"],\"Warranty\":[\"3 Years\"]}", "WD 4TB Gaming Drive for PS4" },
                    { 13, 7, "Ultra-thin widescreen IPS display with Radeon FreeSync technology for smooth visuals.", "https://fakestoreapi.com/img/81QpkIctqPL._AC_SX679_t.png", "[\"https://fakestoreapi.com/img/81QpkIctqPL._AC_SX679_t.png\"]", 599.0, "{\"Screen Size\":[\"21.5 inches\"],\"Resolution\":[\"1920 x 1080\"],\"Panel Type\":[\"IPS\"],\"Refresh Rate\":[\"75Hz\"]}", "Acer SB220Q 21.5-inch IPS Monitor" },
                    { 14, 7, "Super Ultrawide 32:9 curved gaming monitor with QLED technology and HDR support.", "https://fakestoreapi.com/img/81Zt42ioCgL._AC_SX679_t.png", "[\"https://fakestoreapi.com/img/81Zt42ioCgL._AC_SX679_t.png\"]", 999.99000000000001, "{\"Size\":[\"49 Inch\"],\"Refresh Rate\":[\"144Hz\"],\"Display Type\":[\"QLED\"],\"Response Time\":[\"1ms\"]}", "Samsung 49-Inch Curved Gaming Monitor" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
