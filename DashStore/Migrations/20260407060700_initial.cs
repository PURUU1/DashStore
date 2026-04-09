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
                    ImagesJson = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Smartphones" },
                    { 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Laptops & PCs" },
                    { 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Audio & Sound" },
                    { 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Wearables" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "ImagesJson", "Price", "SpecificationsJson", "Title" },
                values: new object[,]
                {
                    { 78, 2, "The MacBook Pro 14 Inch in Space Grey is a powerful and sleek laptop, featuring Apple's M1 Pro chip for exceptional performance and a stunning Retina display.", "https://cdn.dummyjson.com/product-images/laptops/apple-macbook-pro-14-inch-space-grey/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/laptops/apple-macbook-pro-14-inch-space-grey/1.webp\",\"https://cdn.dummyjson.com/product-images/laptops/apple-macbook-pro-14-inch-space-grey/2.webp\",\"https://cdn.dummyjson.com/product-images/laptops/apple-macbook-pro-14-inch-space-grey/3.webp\"]", 1999.99, "{}", "Apple MacBook Pro 14 Inch Space Grey" },
                    { 79, 2, "The Asus Zenbook Pro Dual Screen Laptop is a high-performance device with dual screens, providing productivity and versatility for creative professionals.", "https://cdn.dummyjson.com/product-images/laptops/asus-zenbook-pro-dual-screen-laptop/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/laptops/asus-zenbook-pro-dual-screen-laptop/1.webp\",\"https://cdn.dummyjson.com/product-images/laptops/asus-zenbook-pro-dual-screen-laptop/2.webp\",\"https://cdn.dummyjson.com/product-images/laptops/asus-zenbook-pro-dual-screen-laptop/3.webp\"]", 1799.99, "{}", "Asus Zenbook Pro Dual Screen Laptop" },
                    { 80, 2, "The Huawei Matebook X Pro is a slim and stylish laptop with a high-resolution touchscreen display, offering a premium experience for users on the go.", "https://cdn.dummyjson.com/product-images/laptops/huawei-matebook-x-pro/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/laptops/huawei-matebook-x-pro/1.webp\",\"https://cdn.dummyjson.com/product-images/laptops/huawei-matebook-x-pro/2.webp\",\"https://cdn.dummyjson.com/product-images/laptops/huawei-matebook-x-pro/3.webp\"]", 1399.99, "{}", "Huawei Matebook X Pro" },
                    { 81, 2, "The Lenovo Yoga 920 is a 2-in-1 convertible laptop with a flexible hinge, allowing you to use it as a laptop or tablet, offering versatility and portability.", "https://cdn.dummyjson.com/product-images/laptops/lenovo-yoga-920/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/laptops/lenovo-yoga-920/1.webp\",\"https://cdn.dummyjson.com/product-images/laptops/lenovo-yoga-920/2.webp\",\"https://cdn.dummyjson.com/product-images/laptops/lenovo-yoga-920/3.webp\"]", 1099.99, "{}", "Lenovo Yoga 920" },
                    { 82, 2, "The New DELL XPS 13 9300 Laptop is a compact and powerful device, featuring a virtually borderless InfinityEdge display and high-end performance for various tasks.", "https://cdn.dummyjson.com/product-images/laptops/new-dell-xps-13-9300-laptop/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/laptops/new-dell-xps-13-9300-laptop/1.webp\",\"https://cdn.dummyjson.com/product-images/laptops/new-dell-xps-13-9300-laptop/2.webp\",\"https://cdn.dummyjson.com/product-images/laptops/new-dell-xps-13-9300-laptop/3.webp\"]", 1499.99, "{}", "New DELL XPS 13 9300 Laptop" },
                    { 99, 3, "The Amazon Echo Plus is a smart speaker with built-in Alexa voice control. It features premium sound quality and serves as a hub for controlling smart home devices.", "https://cdn.dummyjson.com/product-images/mobile-accessories/amazon-echo-plus/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/mobile-accessories/amazon-echo-plus/1.webp\",\"https://cdn.dummyjson.com/product-images/mobile-accessories/amazon-echo-plus/2.webp\"]", 99.989999999999995, "{}", "Amazon Echo Plus" },
                    { 100, 3, "The Apple Airpods offer a seamless wireless audio experience. With easy pairing, high-quality sound, and Siri integration, they are perfect for on-the-go listening.", "https://cdn.dummyjson.com/product-images/mobile-accessories/apple-airpods/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/mobile-accessories/apple-airpods/1.webp\",\"https://cdn.dummyjson.com/product-images/mobile-accessories/apple-airpods/2.webp\",\"https://cdn.dummyjson.com/product-images/mobile-accessories/apple-airpods/3.webp\"]", 129.99000000000001, "{}", "Apple Airpods" },
                    { 101, 3, "The Apple AirPods Max in Silver are premium over-ear headphones with high-fidelity audio, adaptive EQ, and active noise cancellation. Experience immersive sound in style.", "https://cdn.dummyjson.com/product-images/mobile-accessories/apple-airpods-max-silver/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/mobile-accessories/apple-airpods-max-silver/1.webp\"]", 549.99000000000001, "{}", "Apple AirPods Max Silver" },
                    { 102, 3, "The Apple AirPower Wireless Charger provides a convenient way to charge your compatible Apple devices wirelessly. Simply place your devices on the charging mat for effortless charging.", "https://cdn.dummyjson.com/product-images/mobile-accessories/apple-airpower-wireless-charger/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/mobile-accessories/apple-airpower-wireless-charger/1.webp\"]", 79.989999999999995, "{}", "Apple Airpower Wireless Charger" },
                    { 103, 3, "The Apple HomePod Mini in Cosmic Grey is a compact smart speaker that delivers impressive audio and integrates seamlessly with the Apple ecosystem for a smart home experience.", "https://cdn.dummyjson.com/product-images/mobile-accessories/apple-homepod-mini-cosmic-grey/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/mobile-accessories/apple-homepod-mini-cosmic-grey/1.webp\"]", 99.989999999999995, "{}", "Apple HomePod Mini Cosmic Grey" },
                    { 104, 3, "The Apple iPhone Charger is a high-quality charger designed for fast and efficient charging of your iPhone. Ensure your device stays powered up and ready to go.", "https://cdn.dummyjson.com/product-images/mobile-accessories/apple-iphone-charger/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/mobile-accessories/apple-iphone-charger/1.webp\",\"https://cdn.dummyjson.com/product-images/mobile-accessories/apple-iphone-charger/2.webp\"]", 19.989999999999998, "{}", "Apple iPhone Charger" },
                    { 105, 3, "The Apple MagSafe Battery Pack is a portable and convenient way to add extra battery life to your MagSafe-compatible iPhone. Attach it magnetically for a secure connection.", "https://cdn.dummyjson.com/product-images/mobile-accessories/apple-magsafe-battery-pack/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/mobile-accessories/apple-magsafe-battery-pack/1.webp\",\"https://cdn.dummyjson.com/product-images/mobile-accessories/apple-magsafe-battery-pack/2.webp\"]", 99.989999999999995, "{}", "Apple MagSafe Battery Pack" },
                    { 106, 6, "The Apple Watch Series 4 in Gold is a stylish and advanced smartwatch with features like heart rate monitoring, fitness tracking, and a beautiful Retina display.", "https://cdn.dummyjson.com/product-images/mobile-accessories/apple-watch-series-4-gold/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/mobile-accessories/apple-watch-series-4-gold/1.webp\",\"https://cdn.dummyjson.com/product-images/mobile-accessories/apple-watch-series-4-gold/2.webp\",\"https://cdn.dummyjson.com/product-images/mobile-accessories/apple-watch-series-4-gold/3.webp\"]", 349.99000000000001, "{}", "Apple Watch Series 4 Gold" },
                    { 107, 3, "The Beats Flex Wireless Earphones offer a comfortable and versatile audio experience. With magnetic earbuds and up to 12 hours of battery life, they are ideal for everyday use.", "https://cdn.dummyjson.com/product-images/mobile-accessories/beats-flex-wireless-earphones/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/mobile-accessories/beats-flex-wireless-earphones/1.webp\"]", 49.990000000000002, "{}", "Beats Flex Wireless Earphones" },
                    { 108, 3, "The iPhone 12 Silicone Case with MagSafe in Plum is a stylish and protective case designed for the iPhone 12. It features MagSafe technology for easy attachment of accessories.", "https://cdn.dummyjson.com/product-images/mobile-accessories/iphone-12-silicone-case-with-magsafe-plum/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/mobile-accessories/iphone-12-silicone-case-with-magsafe-plum/1.webp\",\"https://cdn.dummyjson.com/product-images/mobile-accessories/iphone-12-silicone-case-with-magsafe-plum/2.webp\",\"https://cdn.dummyjson.com/product-images/mobile-accessories/iphone-12-silicone-case-with-magsafe-plum/3.webp\",\"https://cdn.dummyjson.com/product-images/mobile-accessories/iphone-12-silicone-case-with-magsafe-plum/4.webp\"]", 29.989999999999998, "{}", "iPhone 12 Silicone Case with MagSafe Plum" },
                    { 109, 3, "The Monopod is a versatile camera accessory for stable and adjustable shooting. Perfect for capturing selfies, group photos, and videos with ease.", "https://cdn.dummyjson.com/product-images/mobile-accessories/monopod/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/mobile-accessories/monopod/1.webp\",\"https://cdn.dummyjson.com/product-images/mobile-accessories/monopod/2.webp\"]", 19.989999999999998, "{}", "Monopod" },
                    { 110, 3, "The Selfie Lamp with iPhone is a portable and adjustable LED light designed to enhance your selfies and video calls. Attach it to your iPhone for well-lit photos.", "https://cdn.dummyjson.com/product-images/mobile-accessories/selfie-lamp-with-iphone/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/mobile-accessories/selfie-lamp-with-iphone/1.webp\"]", 14.99, "{}", "Selfie Lamp with iPhone" },
                    { 111, 3, "The Selfie Stick Monopod is a extendable and foldable device for capturing the perfect selfie or group photo. Compatible with smartphones and cameras.", "https://cdn.dummyjson.com/product-images/mobile-accessories/selfie-stick-monopod/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/mobile-accessories/selfie-stick-monopod/1.webp\"]", 12.99, "{}", "Selfie Stick Monopod" },
                    { 112, 3, "The TV Studio Camera Pedestal is a professional-grade camera support system for smooth and precise camera movements in a studio setting. Ideal for broadcast and production.", "https://cdn.dummyjson.com/product-images/mobile-accessories/tv-studio-camera-pedestal/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/mobile-accessories/tv-studio-camera-pedestal/1.webp\"]", 499.99000000000001, "{}", "TV Studio Camera Pedestal" },
                    { 121, 1, "The iPhone 5s is a classic smartphone known for its compact design and advanced features during its release. While it's an older model, it still provides a reliable user experience.", "https://cdn.dummyjson.com/product-images/smartphones/iphone-5s/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/smartphones/iphone-5s/1.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/iphone-5s/2.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/iphone-5s/3.webp\"]", 199.99000000000001, "{}", "iPhone 5s" },
                    { 122, 1, "The iPhone 6 is a stylish and capable smartphone with a larger display and improved performance. It introduced new features and design elements, making it a popular choice in its time.", "https://cdn.dummyjson.com/product-images/smartphones/iphone-6/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/smartphones/iphone-6/1.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/iphone-6/2.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/iphone-6/3.webp\"]", 299.99000000000001, "{}", "iPhone 6" },
                    { 123, 1, "The iPhone 13 Pro is a cutting-edge smartphone with a powerful camera system, high-performance chip, and stunning display. It offers advanced features for users who demand top-notch technology.", "https://cdn.dummyjson.com/product-images/smartphones/iphone-13-pro/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/smartphones/iphone-13-pro/1.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/iphone-13-pro/2.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/iphone-13-pro/3.webp\"]", 1099.99, "{}", "iPhone 13 Pro" },
                    { 124, 1, "The iPhone X is a flagship smartphone featuring a bezel-less OLED display, facial recognition technology (Face ID), and impressive performance. It represents a milestone in iPhone design and innovation.", "https://cdn.dummyjson.com/product-images/smartphones/iphone-x/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/smartphones/iphone-x/1.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/iphone-x/2.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/iphone-x/3.webp\"]", 899.99000000000001, "{}", "iPhone X" },
                    { 125, 1, "The Oppo A57 is a mid-range smartphone known for its sleek design and capable features. It offers a balance of performance and affordability, making it a popular choice.", "https://cdn.dummyjson.com/product-images/smartphones/oppo-a57/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/smartphones/oppo-a57/1.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/oppo-a57/2.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/oppo-a57/3.webp\"]", 249.99000000000001, "{}", "Oppo A57" },
                    { 126, 1, "The Oppo F19 Pro Plus is a feature-rich smartphone with a focus on camera capabilities. It boasts advanced photography features and a powerful performance for a premium user experience.", "https://cdn.dummyjson.com/product-images/smartphones/oppo-f19-pro-plus/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/smartphones/oppo-f19-pro-plus/1.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/oppo-f19-pro-plus/2.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/oppo-f19-pro-plus/3.webp\"]", 399.99000000000001, "{}", "Oppo F19 Pro Plus" },
                    { 127, 1, "The Oppo K1 series offers a range of smartphones with various features and specifications. Known for their stylish design and reliable performance, the Oppo K1 series caters to diverse user preferences.", "https://cdn.dummyjson.com/product-images/smartphones/oppo-k1/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/smartphones/oppo-k1/1.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/oppo-k1/2.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/oppo-k1/3.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/oppo-k1/4.webp\"]", 299.99000000000001, "{}", "Oppo K1" },
                    { 128, 1, "The Realme C35 is a budget-friendly smartphone with a focus on providing essential features for everyday use. It offers a reliable performance and user-friendly experience.", "https://cdn.dummyjson.com/product-images/smartphones/realme-c35/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/smartphones/realme-c35/1.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/realme-c35/2.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/realme-c35/3.webp\"]", 149.99000000000001, "{}", "Realme C35" },
                    { 129, 1, "The Realme X is a mid-range smartphone known for its sleek design and impressive display. It offers a good balance of performance and camera capabilities for users seeking a quality device.", "https://cdn.dummyjson.com/product-images/smartphones/realme-x/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/smartphones/realme-x/1.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/realme-x/2.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/realme-x/3.webp\"]", 299.99000000000001, "{}", "Realme X" },
                    { 130, 1, "The Realme XT is a feature-rich smartphone with a focus on camera technology. It comes equipped with advanced camera sensors, delivering high-quality photos and videos for photography enthusiasts.", "https://cdn.dummyjson.com/product-images/smartphones/realme-xt/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/smartphones/realme-xt/1.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/realme-xt/2.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/realme-xt/3.webp\"]", 349.99000000000001, "{}", "Realme XT" },
                    { 131, 1, "The Samsung Galaxy S7 is a flagship smartphone known for its sleek design and advanced features. It features a high-resolution display, powerful camera, and robust performance.", "https://cdn.dummyjson.com/product-images/smartphones/samsung-galaxy-s7/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/smartphones/samsung-galaxy-s7/1.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/samsung-galaxy-s7/2.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/samsung-galaxy-s7/3.webp\"]", 299.99000000000001, "{}", "Samsung Galaxy S7" },
                    { 132, 1, "The Samsung Galaxy S8 is a premium smartphone with an Infinity Display, offering a stunning visual experience. It boasts advanced camera capabilities and cutting-edge technology.", "https://cdn.dummyjson.com/product-images/smartphones/samsung-galaxy-s8/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/smartphones/samsung-galaxy-s8/1.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/samsung-galaxy-s8/2.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/samsung-galaxy-s8/3.webp\"]", 499.99000000000001, "{}", "Samsung Galaxy S8" },
                    { 133, 1, "The Samsung Galaxy S10 is a flagship device featuring a dynamic AMOLED display, versatile camera system, and powerful performance. It represents innovation and excellence in smartphone technology.", "https://cdn.dummyjson.com/product-images/smartphones/samsung-galaxy-s10/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/smartphones/samsung-galaxy-s10/1.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/samsung-galaxy-s10/2.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/samsung-galaxy-s10/3.webp\"]", 699.99000000000001, "{}", "Samsung Galaxy S10" },
                    { 134, 1, "The Vivo S1 is a stylish and mid-range smartphone offering a blend of design and performance. It features a vibrant display, capable camera system, and reliable functionality.", "https://cdn.dummyjson.com/product-images/smartphones/vivo-s1/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/smartphones/vivo-s1/1.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/vivo-s1/2.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/vivo-s1/3.webp\"]", 249.99000000000001, "{}", "Vivo S1" },
                    { 135, 1, "The Vivo V9 is a smartphone known for its sleek design and emphasis on capturing high-quality selfies. It features a notch display, dual-camera setup, and a modern design.", "https://cdn.dummyjson.com/product-images/smartphones/vivo-v9/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/smartphones/vivo-v9/1.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/vivo-v9/2.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/vivo-v9/3.webp\"]", 299.99000000000001, "{}", "Vivo V9" },
                    { 136, 1, "The Vivo X21 is a premium smartphone with a focus on cutting-edge technology. It features an in-display fingerprint sensor, a high-resolution display, and advanced camera capabilities.", "https://cdn.dummyjson.com/product-images/smartphones/vivo-x21/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/smartphones/vivo-x21/1.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/vivo-x21/2.webp\",\"https://cdn.dummyjson.com/product-images/smartphones/vivo-x21/3.webp\"]", 499.99000000000001, "{}", "Vivo X21" },
                    { 159, 2, "The iPad Mini 2021 in Starlight is a compact and powerful tablet from Apple. Featuring a stunning Retina display, powerful A-series chip, and a sleek design, it offers a premium tablet experience.", "https://cdn.dummyjson.com/product-images/tablets/ipad-mini-2021-starlight/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/tablets/ipad-mini-2021-starlight/1.webp\",\"https://cdn.dummyjson.com/product-images/tablets/ipad-mini-2021-starlight/2.webp\",\"https://cdn.dummyjson.com/product-images/tablets/ipad-mini-2021-starlight/3.webp\",\"https://cdn.dummyjson.com/product-images/tablets/ipad-mini-2021-starlight/4.webp\"]", 499.99000000000001, "{}", "iPad Mini 2021 Starlight" },
                    { 160, 2, "The Samsung Galaxy Tab S8 Plus in Grey is a high-performance Android tablet by Samsung. With a large AMOLED display, powerful processor, and S Pen support, it's ideal for productivity and entertainment.", "https://cdn.dummyjson.com/product-images/tablets/samsung-galaxy-tab-s8-plus-grey/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/tablets/samsung-galaxy-tab-s8-plus-grey/1.webp\",\"https://cdn.dummyjson.com/product-images/tablets/samsung-galaxy-tab-s8-plus-grey/2.webp\",\"https://cdn.dummyjson.com/product-images/tablets/samsung-galaxy-tab-s8-plus-grey/3.webp\",\"https://cdn.dummyjson.com/product-images/tablets/samsung-galaxy-tab-s8-plus-grey/4.webp\"]", 599.99000000000001, "{}", "Samsung Galaxy Tab S8 Plus Grey" },
                    { 161, 2, "The Samsung Galaxy Tab in White is a sleek and versatile Android tablet. With a vibrant display, long-lasting battery, and a range of features, it offers a great user experience for various tasks.", "https://cdn.dummyjson.com/product-images/tablets/samsung-galaxy-tab-white/thumbnail.webp", "[\"https://cdn.dummyjson.com/product-images/tablets/samsung-galaxy-tab-white/1.webp\",\"https://cdn.dummyjson.com/product-images/tablets/samsung-galaxy-tab-white/2.webp\",\"https://cdn.dummyjson.com/product-images/tablets/samsung-galaxy-tab-white/3.webp\",\"https://cdn.dummyjson.com/product-images/tablets/samsung-galaxy-tab-white/4.webp\"]", 349.99000000000001, "{}", "Samsung Galaxy Tab White" }
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
