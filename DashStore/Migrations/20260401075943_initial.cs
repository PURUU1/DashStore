using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DashStore.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SpecificationsJson = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDateTime", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Smartphones" },
                    { 2, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Laptops & PCs" },
                    { 3, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Audio & Sound" },
                    { 4, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Gaming" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "SpecificationsJson", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Titanium frame and flat display.", "https://images.unsplash.com/photo-1610945265064-0e34e5519bbf?q=80&w=800", 124999.0, "{\"Color\":[\"Titanium Black\",\"Titanium Gray\"],\"RAM\":[\"12GB\"],\"Storage\":[\"256GB\",\"512GB\"]}", "Galaxy S24 Ultra" },
                    { 2, 1, "Forged in titanium.", "https://images.unsplash.com/photo-1695048133142-1a20484d2569?q=80&w=800", 159900.0, "{\"Color\":[\"Natural Titanium\",\"Blue Titanium\"],\"RAM\":[\"8GB\"],\"Storage\":[\"256GB\",\"1TB\"]}", "iPhone 15 Pro Max" },
                    { 3, 1, "Google AI integrated smartphone.", "https://images.unsplash.com/photo-1598327105666-5b89351aff97?q=80&w=800", 106999.0, "{\"Color\":[\"Obsidian\",\"Porcelain\",\"Bay\"],\"RAM\":[\"12GB\"],\"Storage\":[\"128GB\",\"256GB\"]}", "Pixel 8 Pro" },
                    { 4, 1, "Smooth beyond belief.", "https://images.unsplash.com/photo-1678911820864-e2c567c655d7?q=80&w=800", 64999.0, "{\"Color\":[\"Flowy Emerald\",\"Silky Black\"],\"RAM\":[\"12GB\",\"16GB\"],\"Storage\":[\"256GB\",\"512GB\"]}", "OnePlus 12" },
                    { 5, 1, "The ultimate foldable.", "https://images.unsplash.com/photo-1662955562095-8854bc8d7b38?q=80&w=800", 154999.0, "{\"Color\":[\"Phantom Black\",\"Icy Blue\"],\"RAM\":[\"12GB\"],\"Storage\":[\"512GB\",\"1TB\"]}", "Galaxy Z Fold 5" },
                    { 6, 1, "Dynamic Island comes to standard models.", "https://images.unsplash.com/photo-1695048133142-1a20484d2569?q=80&w=800", 79900.0, "{\"Color\":[\"Pink\",\"Yellow\",\"Green\"],\"RAM\":[\"6GB\"],\"Storage\":[\"128GB\",\"256GB\"]}", "iPhone 15" },
                    { 7, 1, "Fan edition premium phone.", "https://images.unsplash.com/photo-1610945265064-0e34e5519bbf?q=80&w=800", 54999.0, "{\"Color\":[\"Mint\",\"Graphite\"],\"RAM\":[\"8GB\"],\"Storage\":[\"128GB\"]}", "Galaxy S23 FE" },
                    { 8, 1, "Incredible camera, affordable price.", "https://images.unsplash.com/photo-1598327105666-5b89351aff97?q=80&w=800", 43999.0, "{\"Color\":[\"Charcoal\",\"Snow\",\"Sea\"],\"RAM\":[\"8GB\"],\"Storage\":[\"128GB\"]}", "Pixel 7a" },
                    { 9, 1, "Come to the bright side.", "https://images.unsplash.com/photo-1678911820864-e2c567c655d7?q=80&w=800", 44999.0, "{\"Color\":[\"Dark Grey\",\"White\"],\"RAM\":[\"8GB\",\"12GB\"],\"Storage\":[\"256GB\"]}", "Nothing Phone (2)" },
                    { 10, 1, "Ultra-slim curved display.", "https://images.unsplash.com/photo-1610945265064-0e34e5519bbf?q=80&w=800", 29999.0, "{\"Color\":[\"Eclipse Black\",\"Nebula Green\"],\"RAM\":[\"8GB\"],\"Storage\":[\"256GB\"]}", "Moto Edge 40" },
                    { 11, 1, "A brighter mind.", "https://images.unsplash.com/photo-1434493789847-2f02dc6ca35d?q=80&w=800", 41900.0, "{\"Size\":[\"41mm\",\"45mm\"],\"Connectivity\":[\"GPS\",\"Cellular\"]}", "Apple Watch Series 9" },
                    { 12, 1, "The rotating bezel is back.", "https://images.unsplash.com/photo-1508685096489-7aacd43bd3b1?q=80&w=800", 36999.0, "{\"Size\":[\"43mm\",\"47mm\"],\"Color\":[\"Black\",\"Silver\"]}", "Galaxy Watch 6 Classic" },
                    { 13, 2, "Mind-blowing performance.", "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?q=80&w=800", 349900.0, "{\"Processor\":[\"M3 Max\"],\"RAM\":[\"36GB\",\"64GB\"],\"Storage\":[\"1TB SSD\",\"2TB SSD\"]}", "MacBook Pro 16\" M3 Max" },
                    { 14, 2, "High performance creator laptop.", "https://images.unsplash.com/photo-1593642632823-8f785ba67e45?q=80&w=800", 185000.0, "{\"Processor\":[\"Intel i7-13700H\",\"Intel i9-13900H\"],\"RAM\":[\"16GB\",\"32GB\"],\"GPU\":[\"RTX 4060\"]}", "Dell XPS 15" },
                    { 15, 2, "Ultra-portable gaming laptop.", "https://images.unsplash.com/photo-1603302576837-37561b2e2302?q=80&w=800", 145000.0, "{\"Processor\":[\"Ryzen 9 7940HS\"],\"RAM\":[\"16GB\"],\"GPU\":[\"RTX 4060\",\"RTX 4070\"]}", "ASUS ROG Zephyrus G14" },
                    { 16, 2, "Supercharged by M2.", "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?q=80&w=800", 134900.0, "{\"Processor\":[\"M2\"],\"RAM\":[\"8GB\",\"16GB\"],\"Storage\":[\"256GB SSD\",\"512GB SSD\"]}", "MacBook Air 15\" M2" },
                    { 17, 2, "The ultimate business laptop.", "https://images.unsplash.com/photo-1593642632823-8f785ba67e45?q=80&w=800", 165000.0, "{\"Processor\":[\"Intel i7-1355U\"],\"RAM\":[\"16GB\",\"32GB\"],\"Display\":[\"14 inch OLED\"]}", "Lenovo ThinkPad X1 Carbon" },
                    { 18, 2, "Premium 2-in-1 convertible.", "https://images.unsplash.com/photo-1593642632823-8f785ba67e45?q=80&w=800", 139999.0, "{\"Processor\":[\"Intel i7-1355U\"],\"RAM\":[\"16GB\"],\"Color\":[\"Nightfall Black\"]}", "HP Spectre x360" },
                    { 19, 2, "Desktop-level gaming performance.", "https://images.unsplash.com/photo-1603302576837-37561b2e2302?q=80&w=800", 175000.0, "{\"Processor\":[\"Intel i7-13700HX\"],\"RAM\":[\"16GB\"],\"GPU\":[\"RTX 4070\"]}", "Acer Predator Helios 16" },
                    { 20, 2, "Ultra-lightweight large screen laptop.", "https://images.unsplash.com/photo-1593642632823-8f785ba67e45?q=80&w=800", 125000.0, "{\"Weight\":[\"1.35 kg\"],\"Processor\":[\"Intel i7\"],\"RAM\":[\"16GB\"]}", "LG Gram 17" },
                    { 21, 2, "Empower your creativity.", "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?q=80&w=800", 419900.0, "{\"Processor\":[\"M2 Ultra\"],\"RAM\":[\"64GB\",\"128GB\"],\"Storage\":[\"1TB\",\"2TB\"]}", "Mac Studio M2 Ultra" },
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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
