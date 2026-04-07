using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DashStore.Migrations
{
    /// <inheritdoc />
    public partial class redo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Titanium frame and flat display.", "https://images.unsplash.com/photo-1610945265064-0e34e5519bbf?q=80&w=800", 124999.0, "{\"Color\":[\"Titanium Black\",\"Titanium Gray\"],\"RAM\":[\"12GB\"],\"Storage\":[\"256GB\",\"512GB\"]}", "Galaxy S24 Ultra" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Forged in titanium.", "https://images.unsplash.com/photo-1695048133142-1a20484d2569?q=80&w=800", 159900.0, "{\"Color\":[\"Natural Titanium\",\"Blue Titanium\"],\"RAM\":[\"8GB\"],\"Storage\":[\"256GB\",\"1TB\"]}", "iPhone 15 Pro Max" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson", "Title" },
                values: new object[] { "Google AI integrated smartphone.", "https://images.unsplash.com/photo-1598327105666-5b89351aff97?q=80&w=800", "{\"Color\":[\"Obsidian\",\"Porcelain\",\"Bay\"],\"RAM\":[\"12GB\"],\"Storage\":[\"128GB\",\"256GB\"]}", "Pixel 8 Pro" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Smooth beyond belief.", "https://images.unsplash.com/photo-1678911820864-e2c567c655d7?q=80&w=800", "{\"Color\":[\"Flowy Emerald\",\"Silky Black\"],\"RAM\":[\"12GB\",\"16GB\"],\"Storage\":[\"256GB\",\"512GB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson", "Title" },
                values: new object[] { "The ultimate foldable.", "https://images.unsplash.com/photo-1662955562095-8854bc8d7b38?q=80&w=800", "{\"Color\":[\"Phantom Black\",\"Icy Blue\"],\"RAM\":[\"12GB\"],\"Storage\":[\"512GB\",\"1TB\"]}", "Galaxy Z Fold 5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Dynamic Island comes to standard models.", "https://images.unsplash.com/photo-1695048133142-1a20484d2569?q=80&w=800", 79900.0, "{\"Color\":[\"Pink\",\"Yellow\",\"Green\"],\"RAM\":[\"6GB\"],\"Storage\":[\"128GB\",\"256GB\"]}", "iPhone 15" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Fan edition premium phone.", 54999.0, "{\"Color\":[\"Mint\",\"Graphite\"],\"RAM\":[\"8GB\"],\"Storage\":[\"128GB\"]}", "Galaxy S23 FE" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Incredible camera, affordable price.", "https://images.unsplash.com/photo-1598327105666-5b89351aff97?q=80&w=800", 43999.0, "{\"Color\":[\"Charcoal\",\"Snow\",\"Sea\"],\"RAM\":[\"8GB\"],\"Storage\":[\"128GB\"]}", "Pixel 7a" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Come to the bright side.", "https://images.unsplash.com/photo-1678911820864-e2c567c655d7?q=80&w=800", 44999.0, "{\"Color\":[\"Dark Grey\",\"White\"],\"RAM\":[\"8GB\",\"12GB\"],\"Storage\":[\"256GB\"]}", "Nothing Phone (2)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Ultra-slim curved display.", "https://images.unsplash.com/photo-1610945265064-0e34e5519bbf?q=80&w=800", 29999.0, "{\"Color\":[\"Eclipse Black\",\"Nebula Green\"],\"RAM\":[\"8GB\"],\"Storage\":[\"256GB\"]}", "Moto Edge 40" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "A brighter mind.", "https://images.unsplash.com/photo-1434493789847-2f02dc6ca35d?q=80&w=800", 41900.0, "{\"Size\":[\"41mm\",\"45mm\"],\"Connectivity\":[\"GPS\",\"Cellular\"]}", "Apple Watch Series 9" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "The rotating bezel is back.", "https://images.unsplash.com/photo-1508685096489-7aacd43bd3b1?q=80&w=800", 36999.0, "{\"Size\":[\"43mm\",\"47mm\"],\"Color\":[\"Black\",\"Silver\"]}", "Galaxy Watch 6 Classic" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "SpecificationsJson" },
                values: new object[] { "Mind-blowing performance.", "{\"Processor\":[\"M3 Max\"],\"RAM\":[\"36GB\",\"64GB\"],\"Storage\":[\"1TB SSD\",\"2TB SSD\"]}" });

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
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Ultra-portable gaming laptop.", "https://images.unsplash.com/photo-1603302576837-37561b2e2302?q=80&w=800", 145000.0, "{\"Processor\":[\"Ryzen 9 7940HS\"],\"RAM\":[\"16GB\"],\"GPU\":[\"RTX 4060\",\"RTX 4070\"]}", "ASUS ROG Zephyrus G14" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Supercharged by M2.", "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?q=80&w=800", 134900.0, "{\"Processor\":[\"M2\"],\"RAM\":[\"8GB\",\"16GB\"],\"Storage\":[\"256GB SSD\",\"512GB SSD\"]}", "MacBook Air 15\" M2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "The ultimate business laptop.", "https://images.unsplash.com/photo-1593642632823-8f785ba67e45?q=80&w=800", 165000.0, "{\"Processor\":[\"Intel i7-1355U\"],\"RAM\":[\"16GB\",\"32GB\"],\"Display\":[\"14 inch OLED\"]}", "Lenovo ThinkPad X1 Carbon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson", "Title" },
                values: new object[] { "Premium 2-in-1 convertible.", "https://images.unsplash.com/photo-1593642632823-8f785ba67e45?q=80&w=800", "{\"Processor\":[\"Intel i7-1355U\"],\"RAM\":[\"16GB\"],\"Color\":[\"Nightfall Black\"]}", "HP Spectre x360" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Desktop-level gaming performance.", "https://images.unsplash.com/photo-1603302576837-37561b2e2302?q=80&w=800", 175000.0, "{\"Processor\":[\"Intel i7-13700HX\"],\"RAM\":[\"16GB\"],\"GPU\":[\"RTX 4070\"]}", "Acer Predator Helios 16" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Ultra-lightweight large screen laptop.", "https://images.unsplash.com/photo-1593642632823-8f785ba67e45?q=80&w=800", 125000.0, "{\"Weight\":[\"1.35 kg\"],\"Processor\":[\"Intel i7\"],\"RAM\":[\"16GB\"]}", "LG Gram 17" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Empower your creativity.", "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?q=80&w=800", 419900.0, "{\"Processor\":[\"M2 Ultra\"],\"RAM\":[\"64GB\",\"128GB\"],\"Storage\":[\"1TB\",\"2TB\"]}", "Mac Studio M2 Ultra" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "High performance gaming desktop.", 245000.0, "{\"Processor\":[\"Intel i9-13900KF\"],\"GPU\":[\"RTX 4080\",\"RTX 4090\"],\"RAM\":[\"32GB\"]}", "Alienware Aurora R15" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Brilliant picture, incredible design.", "https://images.unsplash.com/photo-1593359677879-a4bb92f829d1?q=80&w=800", 210000.0, "{\"Panel\":[\"OLED\"],\"Resolution\":[\"4K UHD\"],\"Refresh Rate\":[\"120Hz\"]}", "LG OLED evo C3 65\"" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Absolute detail and pure light.", "https://images.unsplash.com/photo-1593359677879-a4bb92f829d1?q=80&w=800", 450000.0, "{\"Panel\":[\"Mini LED\"],\"Resolution\":[\"8K UHD\"],\"Refresh Rate\":[\"144Hz\"]}", "Samsung Neo QLED 8K 75\"" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { 2, "Master Series QD-OLED.", "https://images.unsplash.com/photo-1593359677879-a4bb92f829d1?q=80&w=800", 280000.0, "{\"Panel\":[\"QD-OLED\"],\"Resolution\":[\"4K\"],\"Features\":[\"Cognitive Processor XR\"]}", "Sony Bravia XR A95L 55\"" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Industry-leading noise cancellation.", "https://images.unsplash.com/photo-1618366712010-f4ae9c647dcb?q=80&w=800", 29990.0, "{\"Color\":[\"Black\",\"Silver\",\"Midnight Blue\"],\"Battery Life\":[\"30 Hours\"],\"Features\":[\"ANC\",\"Multipoint Connection\"]}", "Sony WH-1000XM5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "World-class noise cancellation.", "https://images.unsplash.com/photo-1618366712010-f4ae9c647dcb?q=80&w=800" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Magical audio experience.", "https://images.unsplash.com/photo-1600294037681-c80b4cb5b434?q=80&w=800", 24900.0, "{\"Color\":[\"White\"],\"Charging\":[\"USB-C\",\"MagSafe\"],\"Features\":[\"ANC\",\"Transparency\"]}", "AirPods Pro (2nd Gen)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Bold sound for every adventure.", "https://images.unsplash.com/photo-1608043152269-423dbba4e7e1?q=80&w=800", "{\"Color\":[\"Black\",\"Blue\",\"Red\"],\"Battery Life\":[\"12 Hours\"],\"Water Resistance\":[\"IP67\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Next-level spatial audio.", "https://images.unsplash.com/photo-1608043152269-423dbba4e7e1?q=80&w=800" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Superior sound quality.", "https://images.unsplash.com/photo-1618366712010-f4ae9c647dcb?q=80&w=800", 34990.0, "{\"Battery Life\":[\"60 Hours\"],\"Color\":[\"Black\",\"White\"],\"Driver\":[\"42mm Transducer\"]}", "Sennheiser Momentum 4" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Heavyweight sound in a compact frame.", "https://images.unsplash.com/photo-1608043152269-423dbba4e7e1?q=80&w=800", 14999.0, "{\"Battery Life\":[\"30\\u002B Hours\"],\"Color\":[\"Black and Brass\",\"Cream\"],\"Water Resistance\":[\"IP67\"]}", "Marshall Emberton II" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "24-bit Hi-Fi audio.", "https://images.unsplash.com/photo-1600294037681-c80b4cb5b434?q=80&w=800", 16999.0, "{\"Color\":[\"Graphite\",\"White\",\"Bora Purple\"],\"Features\":[\"Active Noise Canceling\"]}", "Samsung Galaxy Buds 2 Pro" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Audiophile wired earbuds.", "https://images.unsplash.com/photo-1600294037681-c80b4cb5b434?q=80&w=800", 12990.0, "{\"Connection\":[\"3.5mm Wired\"],\"Transducer\":[\"7mm TrueResponse\"],\"Impedance\":[\"18 Ohms\"]}", "Sennheiser IE 200" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Professional large diaphragm headphones.", "https://images.unsplash.com/photo-1618366712010-f4ae9c647dcb?q=80&w=800", 8500.0, "{\"Design\":[\"Closed-Back\",\"Wired\"],\"Cable Type\":[\"Coiled\"],\"Driver Size\":[\"40mm\"]}", "Sony MDR-7506" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { 4, "Zero opposition gaming mouse.", "https://images.unsplash.com/photo-1595225476474-87563907a212?q=80&w=800", 12995.0, "{\"Color\":[\"Black\",\"White\",\"Red\"],\"Weight\":[\"\\u003C 63 grams\"],\"Sensor\":[\"HERO 25K\"]}", "Logitech G Pro X Superlight" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "For the Pro gamers.", "https://images.unsplash.com/photo-1595225476474-87563907a212?q=80&w=800", 13499.0, "{\"Weight\":[\"63g\"],\"Sensor\":[\"Focus Pro 30K Optical\"],\"Polling Rate\":[\"Up to 4000 Hz\"]}", "Razer DeathAdder V3 Pro" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Analog mechanical keyboard.", "https://images.unsplash.com/photo-1595225476474-87563907a212?q=80&w=800", 18500.0, "{\"Switches\":[\"Lekker Magnetic Switches\"],\"Size\":[\"60% Layout\"],\"Features\":[\"Rapid Trigger\"]}", "Wooting 60HE" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Legendary mechanical gaming keyboard.", "https://images.unsplash.com/photo-1595225476474-87563907a212?q=80&w=800", 14999.0, "{\"Switches\":[\"Cherry MX Red\",\"Cherry MX Speed\"],\"Size\":[\"Full Size\"],\"Polling Rate\":[\"8000Hz AXON\"]}", "Corsair K70 RGB PRO" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Built with high performance and personalization in mind.", 18990.0, "{\"Compatibility\":[\"PS5\",\"PC\"],\"Features\":[\"Swappable Stick Modules\",\"Back Buttons\"]}", "DualSense Edge Wireless Controller" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Play like a pro.", 15990.0, "{\"Compatibility\":[\"Xbox\",\"PC\",\"Mobile\"],\"Battery Life\":[\"Up to 40 Hours\"],\"Customization\":[\"Adjustable-tension thumbsticks\"]}", "Xbox Elite Wireless Controller Series 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Endgame 1440p gaming monitor.", "https://images.unsplash.com/photo-1527443224154-c4a3942d3acf?q=80&w=800", 95000.0, "{\"Resolution\":[\"2560 x 1440\"],\"Refresh Rate\":[\"240Hz\"],\"Panel\":[\"OLED\"],\"Response Time\":[\"0.03ms\"]}", "ASUS ROG Swift OLED PG27AQDM" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "OLED Gaming Monitor.", "https://images.unsplash.com/photo-1527443224154-c4a3942d3acf?q=80&w=800", 85000.0, "{\"Resolution\":[\"2560 x 1440\"],\"Refresh Rate\":[\"240Hz\"],\"Response Time\":[\"0.03ms\"]}", "LG UltraGear 27GR95QE-B" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Almighty Audio experience.", "https://images.unsplash.com/photo-1618366712010-f4ae9c647dcb?q=80&w=800", 32999.0, "{\"Compatibility\":[\"PC\",\"PS5\",\"Xbox\"],\"Features\":[\"Active Noise Cancellation\",\"Hot-swap Batteries\"]}", "SteelSeries Arctis Nova Pro Wireless" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "A legend reborn.", "https://images.unsplash.com/photo-1618366712010-f4ae9c647dcb?q=80&w=800", 14990.0, "{\"Battery Life\":[\"Up to 120 Hours\"],\"Audio\":[\"DTS Headphone:X Spatial\"],\"Microphone\":[\"Detachable with LED indicator\"]}", "HyperX Cloud III Wireless" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "The definitive esports gaming headset.", "https://images.unsplash.com/photo-1618366712010-f4ae9c647dcb?q=80&w=800", 16999.0, "{\"Microphone\":[\"HyperClear Super Wideband\"],\"Drivers\":[\"Triforce Titanium 50mm\"],\"Connection\":[\"2.4GHz Wireless\"]}", "Razer BlackShark V2 Pro" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Custom mechanical keyboard.", "https://images.unsplash.com/photo-1595225476474-87563907a212?q=80&w=800", 18000.0, "{\"Layout\":[\"75%\"],\"Body\":[\"Full CNC Aluminum\"],\"Connectivity\":[\"Bluetooth 5.1\",\"Wired Type-C\"]}", "Keychron Q1 Pro" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Iconic design, reimagined.", 13995.0, "{\"Switches\":[\"Lightforce Hybrid Optical-Mechanical\"],\"RGB\":[\"8-zone array\"],\"Sensor\":[\"HERO 25K\"]}", "Logitech G502 X PLUS" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { 4, "49-inch curved gaming monitor.", "https://images.unsplash.com/photo-1527443224154-c4a3942d3acf?q=80&w=800", 135000.0, "{\"Resolution\":[\"5120 x 1440\"],\"Curve\":[\"1000R\"],\"Refresh Rate\":[\"240Hz\"]}", "Samsung Odyssey G9" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { 4, "Studio control at your fingertips.", "https://images.unsplash.com/photo-1595225476474-87563907a212?q=80&w=800", 14999.0, "{\"Keys\":[\"15 Customizable LCD Keys\"],\"Connection\":[\"USB-C\"],\"Compatibility\":[\"Windows\",\"macOS\"]}", "Elgato Stream Deck MK.2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDateTime", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Monitors" },
                    { 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Wearables" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Forged in titanium with the revolutionary A17 Pro chip.", "https://images.unsplash.com/photo-1696446701796-da61225697cc?q=80&w=800", 159900.0, "{\"Color\":[\"Natural Titanium\",\"Blue Titanium\"],\"Storage\":[\"256GB\",\"1TB\"],\"RAM\":[\"8GB\"]}", "iPhone 15 Pro Max" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Galaxy AI is here. Embedded S-Pen and titanium exterior.", "https://images.unsplash.com/photo-1610945265064-0e34e5519bbf?q=80&w=800", 129999.0, "{\"Color\":[\"Titanium Black\",\"Titanium Gray\"],\"Storage\":[\"256GB\",\"512GB\"],\"RAM\":[\"12GB\"]}", "Samsung Galaxy S24 Ultra" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson", "Title" },
                values: new object[] { "The pro-level Pixel with advanced AI camera features.", "https://images.unsplash.com/photo-1697525381593-9c869094fe26?q=80&w=800", "{\"Color\":[\"Obsidian\",\"Bay Blue\"],\"Storage\":[\"128GB\",\"256GB\"],\"RAM\":[\"12GB\"]}", "Google Pixel 8 Pro" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Smooth beyond belief with Snapdragon 8 Gen 3.", "https://images.unsplash.com/photo-1715437803023-74b5c77742bc?q=80&w=800", "{\"Color\":[\"Flowy Emerald\",\"Silky Black\"],\"Storage\":[\"256GB\",\"512GB\"],\"RAM\":[\"12GB\",\"16GB\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson", "Title" },
                values: new object[] { "Unfold a massive screen for immersive productivity.", "https://images.unsplash.com/photo-1691435424756-32d8493f663f?q=80&w=800", "{\"Color\":[\"Phantom Black\",\"Icy Blue\"],\"Storage\":[\"512GB\",\"1TB\"],\"RAM\":[\"12GB\"]}", "Samsung Galaxy Z Fold 5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Come to the bright side with the Glyph Interface.", "https://images.unsplash.com/photo-1689254060377-5047b36f73d1?q=80&w=800", 44999.0, "{\"Color\":[\"Dark Grey\",\"White\"],\"Storage\":[\"256GB\",\"512GB\"],\"RAM\":[\"12GB\"]}", "Nothing Phone (2)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Photography reinvented with Leica optics.", 99999.0, "{\"Color\":[\"Black\",\"White\"],\"Storage\":[\"512GB\"],\"RAM\":[\"16GB\"]}", "Xiaomi 14 Ultra" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Dynamic Island, 48MP Main camera, USB-C.", "https://images.unsplash.com/photo-1696423602143-6c845b469493?q=80&w=800", 79900.0, "{\"Color\":[\"Pink\",\"Blue\",\"Black\"],\"Storage\":[\"128GB\",\"256GB\"],\"RAM\":[\"6GB\"]}", "iPhone 15" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Beyond gaming. Unmatched performance and cooling.", "https://images.unsplash.com/photo-1715437803023-74b5c77742bc?q=80&w=800", 94999.0, "{\"Color\":[\"Phantom Black\"],\"Storage\":[\"512GB\"],\"RAM\":[\"16GB\"]}", "Asus ROG Phone 8 Pro" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "AI-powered camera and ultra-fast charging.", "https://images.unsplash.com/photo-1592890288564-76628a30a657?q=80&w=800", 31999.0, "{\"Color\":[\"Black Beauty\",\"Luxe Lavender\"],\"Storage\":[\"256GB\"],\"RAM\":[\"8GB\",\"12GB\"]}", "Motorola Edge 50 Pro" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "The essential Google phone at a great price.", "https://images.unsplash.com/photo-1683935293214-3d964f40f2f3?q=80&w=800", 43999.0, "{\"Color\":[\"Sea\",\"Charcoal\",\"Snow\"],\"Storage\":[\"128GB\"],\"RAM\":[\"8GB\"]}", "Google Pixel 7a" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "The ultimate pocket-sized self-expression tool.", "https://images.unsplash.com/photo-1691435424756-32d8493f663f?q=80&w=800", 99999.0, "{\"Color\":[\"Mint\",\"Graphite\"],\"Storage\":[\"256GB\"],\"RAM\":[\"8GB\"]}", "Samsung Galaxy Z Flip 5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "SpecificationsJson" },
                values: new object[] { "Mind-blowing performance for the heaviest workflows.", "{\"Processor\":[\"Apple M3 Max\"],\"RAM\":[\"36GB\",\"64GB\"],\"Storage\":[\"1TB SSD\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "A perfect balance of power and portability for creators.", "https://images.unsplash.com/photo-1593642632559-0c6d3fc72635?q=80&w=800", "{\"Processor\":[\"Intel Core i7\",\"Intel Core i9\"],\"RAM\":[\"16GB\",\"32GB\"],\"GPU\":[\"RTX 4060\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "The gold standard for premium business laptops.", "https://images.unsplash.com/photo-1632733711679-5292d7763695?q=80&w=800", 165000.0, "{\"Processor\":[\"Intel Core i7-1355U\"],\"RAM\":[\"16GB\",\"32GB\"],\"Storage\":[\"512GB SSD\"]}", "Lenovo ThinkPad X1 Carbon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Ultra-portable 14-inch gaming laptop with OLED display.", "https://images.unsplash.com/photo-1603302576837-37561b2e2302?q=80&w=800", 145000.0, "{\"Processor\":[\"AMD Ryzen 9\"],\"RAM\":[\"16GB\",\"32GB\"],\"GPU\":[\"RTX 4070\"]}", "ASUS ROG Zephyrus G14" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Lean. Mean. M3 machine.", "https://images.unsplash.com/photo-1611186871348-b1ec696e5237?q=80&w=800", 134900.0, "{\"Processor\":[\"Apple M3\"],\"RAM\":[\"8GB\",\"16GB\"],\"Storage\":[\"256GB SSD\",\"512GB SSD\"]}", "MacBook Air 15\" M3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson", "Title" },
                values: new object[] { "Stunning 2-in-1 design with an OLED touch display.", "https://images.unsplash.com/photo-1544731612-de7f96afe55f?q=80&w=800", "{\"Processor\":[\"Intel Core Ultra 7\"],\"RAM\":[\"16GB\"],\"Storage\":[\"1TB SSD\"]}", "HP Spectre x360 14" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Empower your studio with the M2 Ultra chip.", "https://images.unsplash.com/photo-1629131726692-1accd0c93ce0?q=80&w=800", 419900.0, "{\"Processor\":[\"Apple M2 Ultra\"],\"RAM\":[\"64GB\",\"128GB\"],\"Storage\":[\"1TB SSD\"]}", "Apple Mac Studio" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Redesigned high-performance liquid-cooled gaming desktop.", "https://images.unsplash.com/photo-1547082299-de196ea013d6?q=80&w=800", 245000.0, "{\"Processor\":[\"Intel Core i9-14900KF\"],\"GPU\":[\"RTX 4080\",\"RTX 4090\"],\"RAM\":[\"32GB\"]}", "Alienware Aurora R16" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "A massive 17-inch screen in an impossibly light chassis.", "https://images.unsplash.com/photo-1496181133206-80ce9b88a853?q=80&w=800", 125000.0, "{\"Weight\":[\"1.35 kg\"],\"Processor\":[\"Intel Core i7\"],\"RAM\":[\"16GB\"]}", "LG Gram 17" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "The world's first dual-mode mini-LED gaming display.", 320000.0, "{\"Processor\":[\"Intel Core i9-14900HX\"],\"GPU\":[\"RTX 4090\"],\"RAM\":[\"32GB\"]}", "Razer Blade 16" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Built for business, with AI-powered features.", "https://images.unsplash.com/photo-1541807084-5c52b6b3adef?q=80&w=800", 145000.0, "{\"Processor\":[\"Intel Core Ultra 5\",\"Intel Core Ultra 7\"],\"RAM\":[\"16GB\"],\"Storage\":[\"512GB SSD\"]}", "Microsoft Surface Laptop 6" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Compact, quiet, and exceptionally powerful PC.", "https://images.unsplash.com/photo-1547082299-de196ea013d6?q=80&w=800", 350000.0, "{\"Processor\":[\"Intel Core i9\"],\"GPU\":[\"RTX 4090\"],\"RAM\":[\"64GB DDR5\"]}", "Corsair One i500" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { 3, "Industry-leading noise cancellation headphones.", "https://images.unsplash.com/photo-1644794106430-22d74189d704?q=80&w=800", 29990.0, "{\"Color\":[\"Black\",\"Silver\",\"Midnight Blue\"],\"Battery Life\":[\"30 Hours\"],\"Features\":[\"ANC\"]}", "Sony WH-1000XM5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Magical audio experience with adaptive transparency.", "https://images.unsplash.com/photo-1627989580309-bfaf3e58af6f?q=80&w=800", 24900.0, "{\"Color\":[\"White\"],\"Charging\":[\"USB-C\"],\"Features\":[\"ANC\",\"Spatial Audio\"]}", "Apple AirPods Pro 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "World-class noise cancellation with spatial audio.", "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?q=80&w=800" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Audiophile-inspired sound and 60-hour battery life.", "https://images.unsplash.com/photo-1524670497267-35d7a81c17e2?q=80&w=800", 34990.0, "{\"Color\":[\"Black\",\"White\"],\"Battery Life\":[\"60 Hours\"],\"Driver\":[\"42mm Transducer\"]}", "Sennheiser Momentum 4" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "ImageUrl", "SpecificationsJson" },
                values: new object[] { "Bold sound for every adventure. Waterproof and dustproof.", "https://images.unsplash.com/photo-1589003077984-894e133dabab?q=80&w=800", "{\"Color\":[\"Black\",\"Blue\",\"Red\"],\"Battery Life\":[\"12 Hours\"],\"Durability\":[\"IP67\"]}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Next-level spatial audio that fills the room.", "https://images.unsplash.com/photo-1545454675-3531b543be5d?q=80&w=800" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Heavyweight sound in a compact, iconic frame.", "https://images.unsplash.com/photo-1524289286702-f07229da36f5?q=80&w=800", 14999.0, "{\"Color\":[\"Black and Brass\",\"Cream\"],\"Battery Life\":[\"30\\u002B Hours\"],\"Durability\":[\"IP67\"]}", "Marshall Emberton II" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "24-bit Hi-Fi audio for the ultimate listening experience.", "https://images.unsplash.com/photo-1590658268037-6bf12165a8df?q=80&w=800", 16999.0, "{\"Color\":[\"Graphite\",\"White\",\"Bora Purple\"],\"Features\":[\"Active Noise Canceling\"]}", "Samsung Galaxy Buds 2 Pro" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "The ultimate wireless HiFi speakers.", "https://images.unsplash.com/photo-1545454675-3531b543be5d?q=80&w=800", 249000.0, "{\"Type\":[\"Active Bookshelf\"],\"Streaming\":[\"AirPlay 2\",\"Chromecast\",\"Roon\"]}", "KEF LS50 Wireless II" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "The legendary vocal microphone for broadcasting and podcasting.", "https://images.unsplash.com/photo-1590658268037-6bf12165a8df?q=80&w=800", 38999.0, "{\"Type\":[\"Dynamic\"],\"Polar Pattern\":[\"Cardioid\"],\"Connection\":[\"XLR\"]}", "Shure SM7B" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Professional studio monitor headphones.", "https://images.unsplash.com/photo-1484704849700-f032a568e944?q=80&w=800", 14500.0, "{\"Type\":[\"Closed-Back\"],\"Connection\":[\"Wired\"],\"Driver\":[\"45mm\"]}", "Audio-Technica ATH-M50x" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { 3, "Super-portable wireless Bluetooth speaker.", "https://images.unsplash.com/photo-1589003077984-894e133dabab?q=80&w=800", 19990.0, "{\"Battery Life\":[\"20 Hours\"],\"Durability\":[\"IP67 Waterproof\"],\"Audio\":[\"360-degree sound\"]}", "Ultimate Ears MEGABOOM 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Experience lightning-fast loading and deeper immersion.", "https://images.unsplash.com/photo-1605901309584-818e25960b8f?q=80&w=800", 54990.0, "{\"Storage\":[\"1TB SSD\"],\"Resolution\":[\"4K at 120Hz\",\"8K Support\"],\"Drive\":[\"Disc Edition\"]}", "PlayStation 5 Console" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "The fastest, most powerful Xbox ever.", "https://images.unsplash.com/photo-1605901309584-818e25960b8f?q=80&w=800", 54990.0, "{\"Storage\":[\"1TB Custom NVMe SSD\"],\"Performance\":[\"12 Teraflops\"],\"Resolution\":[\"True 4K Gaming\"]}", "Xbox Series X" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Play at home or on the go with a vibrant 7-inch OLED screen.", "https://images.unsplash.com/photo-1606144042614-b2417e99c4e3?q=80&w=800", 34990.0, "{\"Display\":[\"7-inch OLED\"],\"Storage\":[\"64GB\"],\"Modes\":[\"TV\",\"Tabletop\",\"Handheld\"]}", "Nintendo Switch OLED" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "PC gaming anywhere, now with an HDR OLED display.", 58000.0, "{\"Display\":[\"7.4-inch HDR OLED\"],\"Storage\":[\"512GB NVMe SSD\"],\"Refresh Rate\":[\"90Hz\"]}", "Steam Deck OLED" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Get an edge in gameplay with customizable controls.", 18990.0, "{\"Platform\":[\"PS5\",\"PC\"],\"Features\":[\"Swappable Stick Modules\",\"Back Buttons\"]}", "DualSense Edge Wireless Controller" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Play like a pro with adjustable-tension thumbsticks.", "https://images.unsplash.com/photo-1596041061998-68b759527717?q=80&w=800", 15990.0, "{\"Platform\":[\"Xbox\",\"PC\",\"Mobile\"],\"Battery Life\":[\"Up to 40 Hours\"],\"Features\":[\"Wrap-around rubberized grip\"]}", "Xbox Elite Wireless Controller Series 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Zero opposition. The ultimate esports gaming mouse.", "https://images.unsplash.com/photo-1615663245857-ac93bb7c39e7?q=80&w=800", 14995.0, "{\"Weight\":[\"60g\"],\"Sensor\":[\"HERO 2\",\"32K DPI\"],\"Switches\":[\"Lightforce Hybrid\"]}", "Logitech G Pro X Superlight 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "For the Pro. Ergonomic, ultra-lightweight design.", "https://images.unsplash.com/photo-1629429408209-1f912961dbd8?q=80&w=800", 13499.0, "{\"Weight\":[\"63g\"],\"Sensor\":[\"Focus Pro 30K Optical\"],\"Polling Rate\":[\"Up to 4000Hz via Dongle\"]}", "Razer DeathAdder V3 Pro" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Analog mechanical keyboard with Rapid Trigger technology.", "https://images.unsplash.com/photo-1511467687858-23d96c32e4ae?q=80&w=800", 18500.0, "{\"Switches\":[\"Lekker Magnetic Switches\"],\"Layout\":[\"60%\"],\"Features\":[\"Adjustable Actuation Point\"]}", "Wooting 60HE" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Magnetic-Mechanical gaming keyboard.", "https://images.unsplash.com/photo-1595225476474-87563907a212?q=80&w=800", 19999.0, "{\"Switches\":[\"Corsair MGX Magnetic\"],\"Polling Rate\":[\"8000Hz AXON\"],\"Layout\":[\"Full Size\"]}", "Corsair K70 MAX RGB" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Almighty Audio experience with Active Noise Cancellation.", "https://images.unsplash.com/photo-1583394838336-acd977730f90?q=80&w=800", 32999.0, "{\"Platform\":[\"PC\",\"PS5\",\"Xbox\"],\"Features\":[\"Infinity Power System (Hot-swap Batteries)\"]}", "SteelSeries Arctis Nova Pro Wireless" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "Price", "SpecificationsJson", "Title" },
                values: new object[] { "Studio control at your fingertips with 15 LCD keys.", 14999.0, "{\"Keys\":[\"15 Customizable LCD Keys\"],\"Connection\":[\"USB-C\"],\"Compatibility\":[\"Windows\",\"macOS\"]}", "Elgato Stream Deck MK.2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { 5, "49-inch curved super ultrawide gaming monitor.", "https://images.unsplash.com/photo-1525598912003-663126343e1f?q=80&w=800", 165000.0, "{\"Resolution\":[\"5120 x 1440 (DQHD)\"],\"Refresh Rate\":[\"240Hz\"],\"Panel\":[\"OLED\",\"1800R Curve\"]}", "Samsung Odyssey OLED G9" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[] { 5, "34-inch QD-OLED curved gaming monitor.", "https://images.unsplash.com/photo-1527443224154-c4a3942d3acf?q=80&w=800", 105000.0, "{\"Resolution\":[\"3440 x 1440\"],\"Refresh Rate\":[\"165Hz\"],\"Response Time\":[\"0.1ms GtG\"]}", "Alienware AW3423DWF" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[,]
                {
                    { 51, 5, "27-inch OLED gaming monitor with 240Hz refresh rate.", "https://images.unsplash.com/photo-1542393545-10f5cde2c810?q=80&w=800", 85000.0, "{\"Resolution\":[\"2560 x 1440 (QHD)\"],\"Refresh Rate\":[\"240Hz\"],\"Response Time\":[\"0.03ms\"]}", "LG UltraGear 27GR95QE" },
                    { 52, 5, "Endgame 1440p gaming monitor with custom heatsink.", "https://images.unsplash.com/photo-1527443224154-c4a3942d3acf?q=80&w=800", 95000.0, "{\"Resolution\":[\"2560 x 1440\"],\"Refresh Rate\":[\"240Hz\"],\"Panel\":[\"OLED\"]}", "ASUS ROG Swift OLED PG27AQDM" },
                    { 53, 5, "32-inch 4K monitor with IPS Black technology.", "https://images.unsplash.com/photo-1542393545-10f5cde2c810?q=80&w=800", 75000.0, "{\"Resolution\":[\"3840 x 2160 (4K)\"],\"Panel\":[\"IPS Black\"],\"Color Accuracy\":[\"98% DCI-P3\"]}", "Dell UltraSharp U3223QE" },
                    { 54, 5, "A sight to be bold. 27-inch 5K Retina display.", "https://images.unsplash.com/photo-1527443224154-c4a3942d3acf?q=80&w=800", 159900.0, "{\"Resolution\":[\"5120 x 2880 (5K)\"],\"Brightness\":[\"600 nits\"],\"Features\":[\"12MP Ultra Wide camera\"]}", "Apple Studio Display" },
                    { 55, 5, "DesignVue 32-inch 4K monitor for Mac designers.", "https://images.unsplash.com/photo-1542393545-10f5cde2c810?q=80&w=800", 89990.0, "{\"Resolution\":[\"3840 x 2160\"],\"Color Space\":[\"100% sRGB\",\"95% P3\"],\"Connectivity\":[\"Thunderbolt 3\"]}", "BenQ PD3220U" },
                    { 56, 5, "32-inch 4K gaming monitor with built-in KVM.", "https://images.unsplash.com/photo-1525598912003-663126343e1f?q=80&w=800", 65000.0, "{\"Resolution\":[\"3840 x 2160\"],\"Refresh Rate\":[\"144Hz\"],\"Features\":[\"KVM Switch\"]}", "Gigabyte M32U" },
                    { 57, 5, "Esports 4K gaming monitor.", "https://images.unsplash.com/photo-1527443224154-c4a3942d3acf?q=80&w=800", 48000.0, "{\"Resolution\":[\"3840 x 2160 (4K)\"],\"Refresh Rate\":[\"144Hz\"],\"Panel\":[\"Rapid IPS\"]}", "MSI MAG 274UPF" },
                    { 58, 5, "Watch, play, live in style without a PC.", "https://images.unsplash.com/photo-1542393545-10f5cde2c810?q=80&w=800", 55000.0, "{\"Resolution\":[\"4K UHD\"],\"Features\":[\"Built-in Smart TV Apps\",\"SlimFit Camera\"]}", "Samsung Smart Monitor M8" },
                    { 59, 5, "27-inch OLED 240Hz Gaming Monitor.", "https://images.unsplash.com/photo-1527443224154-c4a3942d3acf?q=80&w=800", 82000.0, "{\"Resolution\":[\"2560 x 1440\"],\"Refresh Rate\":[\"240Hz\"],\"Panel\":[\"OLED\"]}", "Acer Predator X27U" },
                    { 60, 5, "Porsche Design 32-inch Mini-LED Gaming Monitor.", "https://images.unsplash.com/photo-1525598912003-663126343e1f?q=80&w=800", 125000.0, "{\"Resolution\":[\"4K UHD\"],\"Panel\":[\"Mini-LED\",\"DisplayHDR 1400\"],\"Refresh Rate\":[\"144Hz\"]}", "AOC Agon PRO PD32M" },
                    { 61, 6, "The ultimate sports and adventure watch.", "https://images.unsplash.com/photo-1544006659-f0b21f04cb1d?q=80&w=800", 89900.0, "{\"Material\":[\"Titanium\"],\"Display\":[\"3000 nits brightness\"],\"Battery\":[\"Up to 36 hours\"]}", "Apple Watch Ultra 2" },
                    { 62, 6, "The iconic rotating bezel is back.", "https://images.unsplash.com/photo-1508685096489-7aacd43bd3b1?q=80&w=800", 36999.0, "{\"Size\":[\"43mm\",\"47mm\"],\"Material\":[\"Stainless Steel\"],\"Display\":[\"Super AMOLED\"]}", "Samsung Galaxy Watch 6 Classic" },
                    { 63, 6, "Premium multisport GPS smartwatch with solar charging.", "https://images.unsplash.com/photo-1508685096489-7aacd43bd3b1?q=80&w=800", 75000.0, "{\"Features\":[\"Built-in Flashlight\",\"Solar Charging\"],\"Battery Life\":[\"Up to 22 Days\"]}", "Garmin Fenix 7 Pro" },
                    { 64, 6, "A brighter mind. Double tap gesture support.", "https://images.unsplash.com/photo-1434493789847-2f02dc6ca35d?q=80&w=800", 41900.0, "{\"Size\":[\"41mm\",\"45mm\"],\"Connectivity\":[\"GPS\",\"Cellular\"],\"Processor\":[\"S9 SiP\"]}", "Apple Watch Series 9" },
                    { 65, 6, "Help by Google. Health by Fitbit.", "https://images.unsplash.com/photo-1508685096489-7aacd43bd3b1?q=80&w=800", 39999.0, "{\"Material\":[\"100% Recycled Aluminum\"],\"Sensors\":[\"Heart Rate\",\"Skin Temperature\",\"cEDA\"]}", "Google Pixel Watch 2" },
                    { 66, 6, "Revolutionary smart ring for health and sleep tracking.", "https://images.unsplash.com/photo-1544006659-f0b21f04cb1d?q=80&w=800", 28000.0, "{\"Material\":[\"Titanium\"],\"Battery Life\":[\"Up to 7 Days\"],\"Tracking\":[\"Sleep\",\"Activity\",\"Readiness\"]}", "Oura Ring Gen 3" },
                    { 67, 6, "Advanced fitness tracker with Google apps.", "https://images.unsplash.com/photo-1434493789847-2f02dc6ca35d?q=80&w=800", 14999.0, "{\"Display\":[\"AMOLED Color Touchscreen\"],\"Battery Life\":[\"Up to 7 Days\"],\"Sensors\":[\"ECG\",\"GPS\"]}", "Fitbit Charge 6" },
                    { 68, 6, "24/7 fitness and health coach. Screen-free design.", "https://images.unsplash.com/photo-1544006659-f0b21f04cb1d?q=80&w=800", 25000.0, "{\"Form Factor\":[\"Wristband\",\"Apparel Integrations\"],\"Battery\":[\"Wireless Battery Pack\"]}", "Whoop 4.0" },
                    { 69, 6, "Business-styled smartwatch with dual-band GPS.", "https://images.unsplash.com/photo-1508685096489-7aacd43bd3b1?q=80&w=800", 16999.0, "{\"Display\":[\"1.43-inch AMOLED\"],\"Battery Life\":[\"Up to 14 Days\"],\"GPS\":[\"Dual-band Circularly-polarized\"]}", "Amazfit GTR 4" },
                    { 70, 6, "Ultra-thin, tough GPS multisport watch.", "https://images.unsplash.com/photo-1508685096489-7aacd43bd3b1?q=80&w=800", 45000.0, "{\"Durability\":[\"Military Grade\",\"Titanium Option\"],\"Water Resistance\":[\"100m\"],\"Battery\":[\"40h in best GPS mode\"]}", "Suunto 9 Peak Pro" }
                });
        }
    }
}
