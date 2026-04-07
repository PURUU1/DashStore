using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DashStore.Migrations
{
    /// <inheritdoc />
    public partial class changesRollBack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1696446701796-da61225697cc?q=80&w=800");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Google AI integrated.", "https://images.unsplash.com/photo-1697525381593-9c869094fe26?q=80&w=800", "{\"Color\":[\"Obsidian\",\"Bay\"],\"RAM\":[\"12GB\"],\"Storage\":[\"128GB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "SpecificationsJson" },
                values: new object[] { "https://images.unsplash.com/photo-1715437803023-74b5c77742bc?q=80&w=800", "{\"Color\":[\"Emerald\",\"Black\"],\"RAM\":[\"16GB\"],\"Storage\":[\"512GB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "SpecificationsJson" },
                values: new object[] { "https://images.unsplash.com/photo-1691435424756-32d8493f663f?q=80&w=800", "{\"Color\":[\"Phantom Black\"],\"RAM\":[\"12GB\"],\"Storage\":[\"512GB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Dynamic Island standard.", "https://images.unsplash.com/photo-1696423602143-6c845b469493?q=80&w=800", "{\"Color\":[\"Pink\",\"Blue\"],\"RAM\":[\"6GB\"],\"Storage\":[\"128GB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Fan edition premium.", "https://images.unsplash.com/photo-1678911820864-e2c567c655d7?q=80&w=800", "{\"Color\":[\"Mint\"],\"RAM\":[\"8GB\"],\"Storage\":[\"128GB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Incredible camera.", "https://images.unsplash.com/photo-1683935293214-3d964f40f2f3?q=80&w=800", "{\"Color\":[\"Sea\"],\"RAM\":[\"8GB\"],\"Storage\":[\"128GB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Bright side of tech.", "https://images.unsplash.com/photo-1689254060377-5047b36f73d1?q=80&w=800", "{\"Color\":[\"White\"],\"RAM\":[\"12GB\"],\"Storage\":[\"256GB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Curved display.", "https://images.unsplash.com/photo-1592890288564-76628a30a657?q=80&w=800", "{\"Color\":[\"Black\"],\"RAM\":[\"8GB\"],\"Storage\":[\"256GB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrl", "SpecificationsJson" },
                values: new object[] { "https://images.unsplash.com/photo-1544006659-f0b21f04cb1d?q=80&w=800", "{\"Size\":[\"45mm\"],\"Connectivity\":[\"GPS\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "SpecificationsJson" },
                values: new object[] { "Rotating bezel.", "{\"Size\":[\"47mm\"],\"Color\":[\"Silver\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "SpecificationsJson",
                value: "{\"Processor\":[\"M3 Max\"],\"RAM\":[\"64GB\"],\"Storage\":[\"1TB SSD\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Creator laptop.", "https://images.unsplash.com/photo-1593642632559-0c6d3fc72635?q=80&w=800", "{\"Processor\":[\"Intel i9\"],\"RAM\":[\"32GB\"],\"GPU\":[\"RTX 4060\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "SpecificationsJson" },
                values: new object[] { "Gaming portability.", "{\"Processor\":[\"Ryzen 9\"],\"RAM\":[\"16GB\"],\"GPU\":[\"RTX 4070\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageUrl", "SpecificationsJson" },
                values: new object[] { "https://images.unsplash.com/photo-1611186871348-b1ec696e5237?q=80&w=800", "{\"Processor\":[\"M2\"],\"RAM\":[\"16GB\"],\"Storage\":[\"512GB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Business standard.", "https://images.unsplash.com/photo-1541807084-5c52b6b3adef?q=80&w=800", "{\"Processor\":[\"Intel i7\"],\"RAM\":[\"32GB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Premium 2-in-1.", "https://images.unsplash.com/photo-1544731612-de7f96afe55f?q=80&w=800", "{\"Processor\":[\"Intel i7\"],\"RAM\":[\"16GB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "High level gaming.", "https://images.unsplash.com/photo-1605398407421-2ba722e03282?q=80&w=800", "{\"Processor\":[\"Intel i7\"],\"GPU\":[\"RTX 4070\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Ultra-lightweight.", "https://images.unsplash.com/photo-1496181133206-80ce9b88a853?q=80&w=800", "{\"Weight\":[\"1.35 kg\"],\"RAM\":[\"16GB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Empower creativity.", "https://images.unsplash.com/photo-1629131726692-1accd0c93ce0?q=80&w=800", "{\"Processor\":[\"M2 Ultra\"],\"RAM\":[\"128GB\"]}" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1695048133142-1a20484d2569?q=80&w=800");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Google AI integrated smartphone.", "https://images.unsplash.com/photo-1598327105666-5b89351aff97?q=80&w=800", "{\"Color\":[\"Obsidian\",\"Porcelain\",\"Bay\"],\"RAM\":[\"12GB\"],\"Storage\":[\"128GB\",\"256GB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "SpecificationsJson" },
                values: new object[] { "https://images.unsplash.com/photo-1678911820864-e2c567c655d7?q=80&w=800", "{\"Color\":[\"Flowy Emerald\",\"Silky Black\"],\"RAM\":[\"12GB\",\"16GB\"],\"Storage\":[\"256GB\",\"512GB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "SpecificationsJson" },
                values: new object[] { "https://images.unsplash.com/photo-1662955562095-8854bc8d7b38?q=80&w=800", "{\"Color\":[\"Phantom Black\",\"Icy Blue\"],\"RAM\":[\"12GB\"],\"Storage\":[\"512GB\",\"1TB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Dynamic Island comes to standard models.", "https://images.unsplash.com/photo-1695048133142-1a20484d2569?q=80&w=800", "{\"Color\":[\"Pink\",\"Yellow\",\"Green\"],\"RAM\":[\"6GB\"],\"Storage\":[\"128GB\",\"256GB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Fan edition premium phone.", "https://images.unsplash.com/photo-1610945265064-0e34e5519bbf?q=80&w=800", "{\"Color\":[\"Mint\",\"Graphite\"],\"RAM\":[\"8GB\"],\"Storage\":[\"128GB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Incredible camera, affordable price.", "https://images.unsplash.com/photo-1598327105666-5b89351aff97?q=80&w=800", "{\"Color\":[\"Charcoal\",\"Snow\",\"Sea\"],\"RAM\":[\"8GB\"],\"Storage\":[\"128GB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Come to the bright side.", "https://images.unsplash.com/photo-1678911820864-e2c567c655d7?q=80&w=800", "{\"Color\":[\"Dark Grey\",\"White\"],\"RAM\":[\"8GB\",\"12GB\"],\"Storage\":[\"256GB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Ultra-slim curved display.", "https://images.unsplash.com/photo-1610945265064-0e34e5519bbf?q=80&w=800", "{\"Color\":[\"Eclipse Black\",\"Nebula Green\"],\"RAM\":[\"8GB\"],\"Storage\":[\"256GB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrl", "SpecificationsJson" },
                values: new object[] { "https://images.unsplash.com/photo-1434493789847-2f02dc6ca35d?q=80&w=800", "{\"Size\":[\"41mm\",\"45mm\"],\"Connectivity\":[\"GPS\",\"Cellular\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "SpecificationsJson" },
                values: new object[] { "The rotating bezel is back.", "{\"Size\":[\"43mm\",\"47mm\"],\"Color\":[\"Black\",\"Silver\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "SpecificationsJson",
                value: "{\"Processor\":[\"M3 Max\"],\"RAM\":[\"36GB\",\"64GB\"],\"Storage\":[\"1TB SSD\",\"2TB SSD\"]}");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "High performance creator laptop.", "https://images.unsplash.com/photo-1593642632823-8f785ba67e45?q=80&w=800", "{\"Processor\":[\"Intel i7-13700H\",\"Intel i9-13900H\"],\"RAM\":[\"16GB\",\"32GB\"],\"GPU\":[\"RTX 4060\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "SpecificationsJson" },
                values: new object[] { "Ultra-portable gaming laptop.", "{\"Processor\":[\"Ryzen 9 7940HS\"],\"RAM\":[\"16GB\"],\"GPU\":[\"RTX 4060\",\"RTX 4070\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageUrl", "SpecificationsJson" },
                values: new object[] { "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?q=80&w=800", "{\"Processor\":[\"M2\"],\"RAM\":[\"8GB\",\"16GB\"],\"Storage\":[\"256GB SSD\",\"512GB SSD\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "The ultimate business laptop.", "https://images.unsplash.com/photo-1593642632823-8f785ba67e45?q=80&w=800", "{\"Processor\":[\"Intel i7-1355U\"],\"RAM\":[\"16GB\",\"32GB\"],\"Display\":[\"14 inch OLED\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Premium 2-in-1 convertible.", "https://images.unsplash.com/photo-1593642632823-8f785ba67e45?q=80&w=800", "{\"Processor\":[\"Intel i7-1355U\"],\"RAM\":[\"16GB\"],\"Color\":[\"Nightfall Black\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Desktop-level gaming performance.", "https://images.unsplash.com/photo-1603302576837-37561b2e2302?q=80&w=800", "{\"Processor\":[\"Intel i7-13700HX\"],\"RAM\":[\"16GB\"],\"GPU\":[\"RTX 4070\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Ultra-lightweight large screen laptop.", "https://images.unsplash.com/photo-1593642632823-8f785ba67e45?q=80&w=800", "{\"Weight\":[\"1.35 kg\"],\"Processor\":[\"Intel i7\"],\"RAM\":[\"16GB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Empower your creativity.", "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?q=80&w=800", "{\"Processor\":[\"M2 Ultra\"],\"RAM\":[\"64GB\",\"128GB\"],\"Storage\":[\"1TB\",\"2TB\"]}" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[,]
                {
                    { 22, 2, "High performance gaming desktop.", "https://images.unsplash.com/photo-1603302576837-37561b2e2302?q=80&w=800", 245000.0, "{\"Processor\":[\"Intel i9-13900KF\"],\"GPU\":[\"RTX 4080\",\"RTX 4090\"],\"RAM\":[\"32GB\"]}", "Alienware Aurora R15" },
                    { 23, 2, "Brilliant picture, incredible design.", "https://images.unsplash.com/photo-1593359677879-a4bb92f829d1?q=80&w=800", 210000.0, "{\"Panel\":[\"OLED\"],\"Resolution\":[\"4K UHD\"],\"Refresh Rate\":[\"120Hz\"]}", "LG OLED evo C3 65\"" },
                    { 24, 2, "Absolute detail and pure light.", "https://images.unsplash.com/photo-1593359677879-a4bb92f829d1?q=80&w=800", 450000.0, "{\"Panel\":[\"Mini LED\"],\"Resolution\":[\"8K UHD\"],\"Refresh Rate\":[\"144Hz\"]}", "Samsung Neo QLED 8K 75\"" },
                    { 25, 2, "Master Series QD-OLED.", "https://images.unsplash.com/photo-1593359677879-a4bb92f829d1?q=80&w=800", 280000.0, "{\"Panel\":[\"QD-OLED\"],\"Resolution\":[\"4K\"],\"Features\":[\"Cognitive Processor XR\"]}", "Sony Bravia XR A95L 55\"" },
                    { 26, 3, "Industry-leading noise cancellation.", "https://images.unsplash.com/photo-1618366712010-f4ae9c647dcb?q=80&w=800", 29990.0, "{\"Color\":[\"Black\",\"Silver\",\"Midnight Blue\"],\"Battery Life\":[\"30 Hours\"],\"Features\":[\"ANC\",\"Multipoint Connection\"]}", "Sony WH-1000XM5" },
                    { 27, 3, "World-class noise cancellation.", "https://images.unsplash.com/photo-1618366712010-f4ae9c647dcb?q=80&w=800", 35900.0, "{\"Color\":[\"Black\",\"White Smoke\"],\"Battery Life\":[\"24 Hours\"],\"Features\":[\"Immersive Audio\"]}", "Bose QuietComfort Ultra" },
                    { 28, 3, "Magical audio experience.", "https://images.unsplash.com/photo-1600294037681-c80b4cb5b434?q=80&w=800", 24900.0, "{\"Color\":[\"White\"],\"Charging\":[\"USB-C\",\"MagSafe\"],\"Features\":[\"ANC\",\"Transparency\"]}", "AirPods Pro (2nd Gen)" },
                    { 29, 3, "Bold sound for every adventure.", "https://images.unsplash.com/photo-1608043152269-423dbba4e7e1?q=80&w=800", 11999.0, "{\"Color\":[\"Black\",\"Blue\",\"Red\"],\"Battery Life\":[\"12 Hours\"],\"Water Resistance\":[\"IP67\"]}", "JBL Flip 6" },
                    { 30, 3, "Next-level spatial audio.", "https://images.unsplash.com/photo-1608043152269-423dbba4e7e1?q=80&w=800", 44999.0, "{\"Color\":[\"Black\",\"White\"],\"Connectivity\":[\"Wi-Fi\",\"Bluetooth\",\"Line-in\"]}", "Sonos Era 300" },
                    { 31, 3, "Superior sound quality.", "https://images.unsplash.com/photo-1618366712010-f4ae9c647dcb?q=80&w=800", 34990.0, "{\"Battery Life\":[\"60 Hours\"],\"Color\":[\"Black\",\"White\"],\"Driver\":[\"42mm Transducer\"]}", "Sennheiser Momentum 4" },
                    { 32, 3, "Heavyweight sound in a compact frame.", "https://images.unsplash.com/photo-1608043152269-423dbba4e7e1?q=80&w=800", 14999.0, "{\"Battery Life\":[\"30\\u002B Hours\"],\"Color\":[\"Black and Brass\",\"Cream\"],\"Water Resistance\":[\"IP67\"]}", "Marshall Emberton II" },
                    { 33, 3, "24-bit Hi-Fi audio.", "https://images.unsplash.com/photo-1600294037681-c80b4cb5b434?q=80&w=800", 16999.0, "{\"Color\":[\"Graphite\",\"White\",\"Bora Purple\"],\"Features\":[\"Active Noise Canceling\"]}", "Samsung Galaxy Buds 2 Pro" },
                    { 34, 3, "Audiophile wired earbuds.", "https://images.unsplash.com/photo-1600294037681-c80b4cb5b434?q=80&w=800", 12990.0, "{\"Connection\":[\"3.5mm Wired\"],\"Transducer\":[\"7mm TrueResponse\"],\"Impedance\":[\"18 Ohms\"]}", "Sennheiser IE 200" },
                    { 35, 3, "Professional large diaphragm headphones.", "https://images.unsplash.com/photo-1618366712010-f4ae9c647dcb?q=80&w=800", 8500.0, "{\"Design\":[\"Closed-Back\",\"Wired\"],\"Cable Type\":[\"Coiled\"],\"Driver Size\":[\"40mm\"]}", "Sony MDR-7506" },
                    { 36, 4, "Zero opposition gaming mouse.", "https://images.unsplash.com/photo-1595225476474-87563907a212?q=80&w=800", 12995.0, "{\"Color\":[\"Black\",\"White\",\"Red\"],\"Weight\":[\"\\u003C 63 grams\"],\"Sensor\":[\"HERO 25K\"]}", "Logitech G Pro X Superlight" },
                    { 37, 4, "For the Pro gamers.", "https://images.unsplash.com/photo-1595225476474-87563907a212?q=80&w=800", 13499.0, "{\"Weight\":[\"63g\"],\"Sensor\":[\"Focus Pro 30K Optical\"],\"Polling Rate\":[\"Up to 4000 Hz\"]}", "Razer DeathAdder V3 Pro" },
                    { 38, 4, "Analog mechanical keyboard.", "https://images.unsplash.com/photo-1595225476474-87563907a212?q=80&w=800", 18500.0, "{\"Switches\":[\"Lekker Magnetic Switches\"],\"Size\":[\"60% Layout\"],\"Features\":[\"Rapid Trigger\"]}", "Wooting 60HE" },
                    { 39, 4, "Legendary mechanical gaming keyboard.", "https://images.unsplash.com/photo-1595225476474-87563907a212?q=80&w=800", 14999.0, "{\"Switches\":[\"Cherry MX Red\",\"Cherry MX Speed\"],\"Size\":[\"Full Size\"],\"Polling Rate\":[\"8000Hz AXON\"]}", "Corsair K70 RGB PRO" },
                    { 40, 4, "Built with high performance and personalization in mind.", "https://images.unsplash.com/photo-1606144042614-b2417e99c4e3?q=80&w=800", 18990.0, "{\"Compatibility\":[\"PS5\",\"PC\"],\"Features\":[\"Swappable Stick Modules\",\"Back Buttons\"]}", "DualSense Edge Wireless Controller" },
                    { 41, 4, "Play like a pro.", "https://images.unsplash.com/photo-1606144042614-b2417e99c4e3?q=80&w=800", 15990.0, "{\"Compatibility\":[\"Xbox\",\"PC\",\"Mobile\"],\"Battery Life\":[\"Up to 40 Hours\"],\"Customization\":[\"Adjustable-tension thumbsticks\"]}", "Xbox Elite Wireless Controller Series 2" },
                    { 42, 4, "Endgame 1440p gaming monitor.", "https://images.unsplash.com/photo-1527443224154-c4a3942d3acf?q=80&w=800", 95000.0, "{\"Resolution\":[\"2560 x 1440\"],\"Refresh Rate\":[\"240Hz\"],\"Panel\":[\"OLED\"],\"Response Time\":[\"0.03ms\"]}", "ASUS ROG Swift OLED PG27AQDM" },
                    { 43, 4, "OLED Gaming Monitor.", "https://images.unsplash.com/photo-1527443224154-c4a3942d3acf?q=80&w=800", 85000.0, "{\"Resolution\":[\"2560 x 1440\"],\"Refresh Rate\":[\"240Hz\"],\"Response Time\":[\"0.03ms\"]}", "LG UltraGear 27GR95QE-B" },
                    { 44, 4, "Almighty Audio experience.", "https://images.unsplash.com/photo-1618366712010-f4ae9c647dcb?q=80&w=800", 32999.0, "{\"Compatibility\":[\"PC\",\"PS5\",\"Xbox\"],\"Features\":[\"Active Noise Cancellation\",\"Hot-swap Batteries\"]}", "SteelSeries Arctis Nova Pro Wireless" },
                    { 45, 4, "A legend reborn.", "https://images.unsplash.com/photo-1618366712010-f4ae9c647dcb?q=80&w=800", 14990.0, "{\"Battery Life\":[\"Up to 120 Hours\"],\"Audio\":[\"DTS Headphone:X Spatial\"],\"Microphone\":[\"Detachable with LED indicator\"]}", "HyperX Cloud III Wireless" },
                    { 46, 4, "The definitive esports gaming headset.", "https://images.unsplash.com/photo-1618366712010-f4ae9c647dcb?q=80&w=800", 16999.0, "{\"Microphone\":[\"HyperClear Super Wideband\"],\"Drivers\":[\"Triforce Titanium 50mm\"],\"Connection\":[\"2.4GHz Wireless\"]}", "Razer BlackShark V2 Pro" },
                    { 47, 4, "Custom mechanical keyboard.", "https://images.unsplash.com/photo-1595225476474-87563907a212?q=80&w=800", 18000.0, "{\"Layout\":[\"75%\"],\"Body\":[\"Full CNC Aluminum\"],\"Connectivity\":[\"Bluetooth 5.1\",\"Wired Type-C\"]}", "Keychron Q1 Pro" },
                    { 48, 4, "Iconic design, reimagined.", "https://images.unsplash.com/photo-1595225476474-87563907a212?q=80&w=800", 13995.0, "{\"Switches\":[\"Lightforce Hybrid Optical-Mechanical\"],\"RGB\":[\"8-zone array\"],\"Sensor\":[\"HERO 25K\"]}", "Logitech G502 X PLUS" },
                    { 49, 4, "49-inch curved gaming monitor.", "https://images.unsplash.com/photo-1527443224154-c4a3942d3acf?q=80&w=800", 135000.0, "{\"Resolution\":[\"5120 x 1440\"],\"Curve\":[\"1000R\"],\"Refresh Rate\":[\"240Hz\"]}", "Samsung Odyssey G9" },
                    { 50, 4, "Studio control at your fingertips.", "https://images.unsplash.com/photo-1595225476474-87563907a212?q=80&w=800", 14999.0, "{\"Keys\":[\"15 Customizable LCD Keys\"],\"Connection\":[\"USB-C\"],\"Compatibility\":[\"Windows\",\"macOS\"]}", "Elgato Stream Deck MK.2" }
                });
        }
    }
}
