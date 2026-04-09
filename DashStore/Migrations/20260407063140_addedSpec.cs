using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DashStore.Migrations
{
    /// <inheritdoc />
    public partial class addedSpec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Space Grey\"],\"Processor\":[\"Apple M1 Pro\"],\"RAM\":[\"16GB\"],\"Storage\":[\"512GB SSD\"],\"Display\":[\"14.2-inch Liquid Retina XDR\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Celestial Blue\"],\"Processor\":[\"Intel Core i9\"],\"RAM\":[\"32GB\"],\"Storage\":[\"1TB NVMe SSD\"],\"Graphics\":[\"NVIDIA GeForce RTX 3060\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Emerald Green\"],\"Processor\":[\"Intel Core i7\"],\"RAM\":[\"16GB\"],\"Storage\":[\"512GB SSD\"],\"Display\":[\"13.9-inch 3K Touchscreen\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Platinum\"],\"Processor\":[\"Intel Core i5\"],\"RAM\":[\"8GB\"],\"Storage\":[\"256GB SSD\"],\"Form Factor\":[\"2-in-1 Convertible\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Silver\"],\"Processor\":[\"Intel Core i7 10th Gen\"],\"RAM\":[\"16GB\"],\"Storage\":[\"512GB SSD\"],\"Display\":[\"13.4-inch FHD\\u002B InfinityEdge\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Charcoal\"],\"Connectivity\":[\"Wi-Fi, Bluetooth\"],\"Smart Home Hub\":[\"Built-in Zigbee\"],\"Audio\":[\"Premium Dolby Sound\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"White\"],\"Connectivity\":[\"Bluetooth\"],\"Battery Life\":[\"Up to 24 hours (with case)\"],\"Chip\":[\"H1 Headphone Chip\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Silver\"],\"Design\":[\"Over-Ear\"],\"Noise Cancellation\":[\"Active Noise Cancellation (ANC)\"],\"Battery Life\":[\"Up to 20 hours\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"White\"],\"Output\":[\"15W Fast Charging\"],\"Compatibility\":[\"Qi-enabled Apple Devices\"],\"Type\":[\"Wireless Charging Mat\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Space Grey\"],\"Connectivity\":[\"Wi-Fi 802.11n\"],\"Audio\":[\"360-degree sound\"],\"Voice Assistant\":[\"Siri built-in\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"White\"],\"Output\":[\"20W\"],\"Interface\":[\"USB-C\"],\"Type\":[\"Power Adapter\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"White\"],\"Capacity\":[\"1460 mAh\"],\"Compatibility\":[\"iPhone 12 and newer\"],\"Connection\":[\"Magnetic Attachment\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Gold\"],\"Size\":[\"44mm\"],\"Connectivity\":[\"GPS \\u002B Cellular\"],\"Material\":[\"Aluminum Case\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Beats Black\"],\"Connectivity\":[\"Bluetooth\"],\"Battery Life\":[\"Up to 12 hours\"],\"Charging\":[\"USB-C Fast Fuel\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Plum\"],\"Material\":[\"Silicone\"],\"Compatibility\":[\"iPhone 12 / 12 Pro\"],\"Features\":[\"Built-in MagSafe\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Black\"],\"Material\":[\"Aluminum\"],\"Max Height\":[\"60 inches\"],\"Mount Type\":[\"Standard 1/4-inch screw\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"White\"],\"Light Levels\":[\"3 Brightness Levels\"],\"Connection\":[\"Clip-on\"],\"Power\":[\"Rechargeable USB\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Black\"],\"Connectivity\":[\"Bluetooth Remote\"],\"Folded Length\":[\"7.5 inches\"],\"Compatibility\":[\"iOS \\u0026 Android\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Black\"],\"Material\":[\"Heavy-duty Aluminum\"],\"Max Load\":[\"66 lbs (30 kg)\"],\"Mobility\":[\"Locking Casters\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Silver\"],\"RAM\":[\"1GB\"],\"Storage\":[\"16GB\"],\"Processor\":[\"Apple A7\"],\"Screen Size\":[\"4.0 inches\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Space Gray\"],\"RAM\":[\"1GB\"],\"Storage\":[\"64GB\"],\"Processor\":[\"Apple A8\"],\"Screen Size\":[\"4.7 inches\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Sierra Blue\"],\"RAM\":[\"6GB\"],\"Storage\":[\"256GB\"],\"Processor\":[\"Apple A15 Bionic\"],\"Refresh Rate\":[\"120Hz ProMotion\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Silver\"],\"RAM\":[\"3GB\"],\"Storage\":[\"64GB\"],\"Processor\":[\"Apple A11 Bionic\"],\"Display\":[\"5.8-inch Super Retina OLED\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Glowing Green\"],\"RAM\":[\"4GB\"],\"Storage\":[\"64GB\"],\"Battery\":[\"5000 mAh\"],\"Camera\":[\"13MP Dual Camera\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Space Silver\"],\"RAM\":[\"8GB\"],\"Storage\":[\"128GB\"],\"Processor\":[\"MediaTek Dimensity 800U\"],\"Charging\":[\"50W Flash Charge\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Astral Blue\"],\"RAM\":[\"4GB\"],\"Storage\":[\"64GB\"],\"Processor\":[\"Snapdragon 660\"],\"Security\":[\"In-Display Fingerprint\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Glowing Black\"],\"RAM\":[\"4GB\"],\"Storage\":[\"128GB\"],\"Display\":[\"6.6-inch FHD\\u002B\"],\"Camera\":[\"50MP AI Triple Camera\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Polar White\"],\"RAM\":[\"8GB\"],\"Storage\":[\"128GB\"],\"Processor\":[\"Snapdragon 710\"],\"Camera\":[\"Pop-up Selfie Camera\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Pearl Blue\"],\"RAM\":[\"8GB\"],\"Storage\":[\"128GB\"],\"Processor\":[\"Snapdragon 712\"],\"Camera\":[\"64MP Quad Camera\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Black Onyx\"],\"RAM\":[\"4GB\"],\"Storage\":[\"32GB\"],\"Display\":[\"5.1-inch Super AMOLED\"],\"Durability\":[\"IP68 Water Resistant\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Midnight Black\"],\"RAM\":[\"4GB\"],\"Storage\":[\"64GB\"],\"Display\":[\"5.8-inch Infinity Display\"],\"Security\":[\"Iris Scanner\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Prism White\"],\"RAM\":[\"8GB\"],\"Storage\":[\"128GB\"],\"Display\":[\"6.1-inch Dynamic AMOLED\"],\"Security\":[\"Ultrasonic Fingerprint\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Skyline Blue\"],\"RAM\":[\"4GB\"],\"Storage\":[\"128GB\"],\"Battery\":[\"4500 mAh\"],\"Display\":[\"Super AMOLED\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Pearl Black\"],\"RAM\":[\"4GB\"],\"Storage\":[\"64GB\"],\"Camera\":[\"24MP AI Selfie Camera\"],\"Display\":[\"6.3-inch FHD\\u002B\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Black\"],\"RAM\":[\"6GB\"],\"Storage\":[\"128GB\"],\"Processor\":[\"Snapdragon 660\"],\"Security\":[\"In-Display Fingerprint\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Starlight\"],\"Storage\":[\"64GB\"],\"Processor\":[\"A15 Bionic chip\"],\"Display\":[\"8.3-inch Liquid Retina\"],\"Connectivity\":[\"Wi-Fi\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"Graphite Grey\"],\"RAM\":[\"8GB\"],\"Storage\":[\"128GB\"],\"Display\":[\"12.4-inch Super AMOLED\"],\"Accessories\":[\"S Pen Included\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                column: "SpecificationsJson",
                value: "{\"Color\":[\"White\"],\"RAM\":[\"3GB\"],\"Storage\":[\"32GB\"],\"Display\":[\"10.1-inch TFT\"],\"Connectivity\":[\"Wi-Fi\"]}");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                column: "SpecificationsJson",
                value: "{}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                column: "SpecificationsJson",
                value: "{}");
        }
    }
}
