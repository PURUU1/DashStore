using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DashStore.Migrations
{
    /// <inheritdoc />
    public partial class adeedNewMonitorAndWearbles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "ImagesJson", "Price", "SpecificationsJson", "Title" },
                values: new object[,]
                {
                    { 20, 6, "The most rugged and capable Apple Watch. Featuring a robust titanium case and dual-frequency GPS.", "https://m.media-amazon.com/images/I/71Fu7m3Y3iL._AC_SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/71Fu7m3Y3iL._AC_SL1500_.jpg\"]", 799.0, "{\"Material\":[\"Titanium\"],\"Size\":[\"49mm\"],\"Battery\":[\"Up to 36 hours\"],\"Water Resistance\":[\"100m\"]}", "Apple Watch Ultra 2 GPS + Cellular" },
                    { 21, 6, "The pinnacle of Samsung wearables with advanced AI-driven health tracking and extreme durability.", "https://m.media-amazon.com/images/I/61N8qWInS0L._AC_SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/61N8qWInS0L._AC_SL1500_.jpg\"]", 649.99000000000001, "{\"OS\":[\"Wear OS 5\"],\"Processor\":[\"Exynos W1000\"],\"Display\":[\"Sapphire Crystal\"],\"Sensors\":[\"BioActive Sensor\"]}", "Samsung Galaxy Watch Ultra" },
                    { 22, 6, "Multisport GPS watch with solar charging lens and built-in LED flashlight for athletes.", "https://m.media-amazon.com/images/I/61mZ5Yt-TfL._AC_SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/61mZ5Yt-TfL._AC_SL1500_.jpg\"]", 899.99000000000001, "{\"Charging\":[\"Solar Powered\"],\"Maps\":[\"Preloaded TopoActive\"],\"Flashlight\":[\"Built-in LED\"],\"Battery\":[\"Up to 37 days (Smartwatch mode)\"]}", "Garmin Fenix 7X Pro Solar" },
                    { 23, 6, "The best of Google and Fitbit combined. Sleek circular design with deep integration into the Pixel ecosystem.", "https://m.media-amazon.com/images/I/61D5N40S-3L._AC_SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/61D5N40S-3L._AC_SL1500_.jpg\"]", 349.0, "{\"Display\":[\"Actua Display\"],\"Health\":[\"Daily Readiness Score\"],\"Safety\":[\"Fall Detection\"],\"Connectivity\":[\"Bluetooth/Wi-Fi\"]}", "Google Pixel Watch 3" },
                    { 24, 6, "Classic look with industry-first dual-band circularly-polarized GPS antenna technology.", "https://m.media-amazon.com/images/I/61Yp7f1FpML._AC_SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/61Yp7f1FpML._AC_SL1500_.jpg\"]", 199.99000000000001, "{\"Battery\":[\"14 Days\"],\"Sports Modes\":[\"150\\u002B\"],\"Display\":[\"1.43\\u0022 AMOLED\"],\"Assistant\":[\"Alexa Built-in\"]}", "Amazfit GTR 4 Smart Watch" },
                    { 25, 7, "The world's first 32-inch 4K OLED gaming monitor with a stunning 240Hz refresh rate.", "https://m.media-amazon.com/images/I/81mD-mI7HlL._AC_SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/81mD-mI7HlL._AC_SL1500_.jpg\"]", 1299.0, "{\"Resolution\":[\"3840 x 2160\"],\"Refresh Rate\":[\"240Hz\"],\"Panel\":[\"OLED\"],\"Response Time\":[\"0.03ms\"]}", "ASUS ROG Swift 32\" 4K OLED" },
                    { 26, 7, "High-performance gaming monitor with a built-in KVM switch to control multiple devices.", "https://m.media-amazon.com/images/I/71Y88f7R8sL._AC_SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/71Y88f7R8sL._AC_SL1500_.jpg\"]", 299.99000000000001, "{\"Panel\":[\"IPS\"],\"Refresh Rate\":[\"170Hz\"],\"Resolution\":[\"2560 x 1440\"],\"Special Feature\":[\"KVM Switch\"]}", "Gigabyte M27Q 27\" QHD" },
                    { 27, 7, "Immerse yourself in the action with a 1500R curvature and a 21:9 ultra-wide aspect ratio.", "https://m.media-amazon.com/images/I/71H2l28m3BL._AC_SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/71H2l28m3BL._AC_SL1500_.jpg\"]", 450.0, "{\"Curvature\":[\"1500R\"],\"Aspect Ratio\":[\"21:9\"],\"Resolution\":[\"UWQHD\"],\"Panel\":[\"VA\"]}", "MSI Optix 34\" Curved Ultrawide" },
                    { 28, 7, "Tailor-made for creative professionals with Mac-ready color precision and Thunderbolt 3.", "https://m.media-amazon.com/images/I/71vW8o-lD0L._AC_SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/71vW8o-lD0L._AC_SL1500_.jpg\"]", 1099.0, "{\"Color Space\":[\"100% sRGB\",\"95% P3\"],\"Connectivity\":[\"Thunderbolt 3\",\"USB-C\"],\"Display\":[\"4K UHD IPS\"],\"Feature\":[\"Hotkey Puck G2\"]}", "BenQ PD3220U 32\" Designer Monitor" },
                    { 29, 7, "Competitive esports monitor with ultra-fast 1ms response and G-Sync compatibility.", "https://m.media-amazon.com/images/I/71YyK8p6KGL._AC_SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/71YyK8p6KGL._AC_SL1500_.jpg\"]", 229.0, "{\"Size\":[\"24 inch\"],\"Refresh Rate\":[\"144Hz\"],\"Sync\":[\"NVIDIA G-Sync\"],\"Resolution\":[\"1080p FHD\"]}", "ViewSonic ELITE 24\" 1080p" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);
        }
    }
}
