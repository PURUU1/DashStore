using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DashStore.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedImagesForAddedProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ImageUrl", "ImagesJson" },
                values: new object[] { "https://m.media-amazon.com/images/I/81Scp0aak9L._SX679_.jpg", "[\"https://m.media-amazon.com/images/I/81Scp0aak9L._SX679_.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ImageUrl", "ImagesJson" },
                values: new object[] { "https://m.media-amazon.com/images/I/81acmzia3+L._SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/81acmzia3\\u002BL._SL1500_.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ImageUrl", "ImagesJson" },
                values: new object[] { "https://m.media-amazon.com/images/I/31j27NoU-vL._SY300_SX300_QL70_FMwebp_.jpg", "[\"https://m.media-amazon.com/images/I/31j27NoU-vL._SY300_SX300_QL70_FMwebp_.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ImageUrl", "ImagesJson" },
                values: new object[] { "https://m.media-amazon.com/images/I/51i+zh+rQ0L._SX522_.jpg", "[\"https://m.media-amazon.com/images/I/51i\\u002Bzh\\u002BrQ0L._SX522_.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ImageUrl", "ImagesJson" },
                values: new object[] { "https://m.media-amazon.com/images/I/41Y9uYdxzjL._SY300_SX300_QL70_FMwebp_.jpg", "[\"https://m.media-amazon.com/images/I/41Y9uYdxzjL._SY300_SX300_QL70_FMwebp_.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ImageUrl", "ImagesJson" },
                values: new object[] { "https://m.media-amazon.com/images/I/81djcVFS+rL._SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/81djcVFS\\u002BrL._SL1500_.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ImageUrl", "ImagesJson" },
                values: new object[] { "https://m.media-amazon.com/images/I/81oosCN47KL._SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/81oosCN47KL._SL1500_.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ImageUrl", "ImagesJson" },
                values: new object[] { "https://m.media-amazon.com/images/I/71YsSgR-KpL._SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/71YsSgR-KpL._SL1500_.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ImageUrl", "ImagesJson" },
                values: new object[] { "https://m.media-amazon.com/images/I/41G+WEORaDL._SX300_SY300_QL70_FMwebp_.jpg", "[\"https://m.media-amazon.com/images/I/41G\\u002BWEORaDL._SX300_SY300_QL70_FMwebp_.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ImageUrl", "ImagesJson" },
                values: new object[] { "https://m.media-amazon.com/images/I/71LiIjEK06L._SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/71LiIjEK06L._SL1500_.jpg\"]" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ImageUrl", "ImagesJson" },
                values: new object[] { "https://m.media-amazon.com/images/I/71Fu7m3Y3iL._AC_SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/71Fu7m3Y3iL._AC_SL1500_.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ImageUrl", "ImagesJson" },
                values: new object[] { "https://m.media-amazon.com/images/I/61N8qWInS0L._AC_SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/61N8qWInS0L._AC_SL1500_.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ImageUrl", "ImagesJson" },
                values: new object[] { "https://m.media-amazon.com/images/I/61mZ5Yt-TfL._AC_SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/61mZ5Yt-TfL._AC_SL1500_.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ImageUrl", "ImagesJson" },
                values: new object[] { "https://m.media-amazon.com/images/I/61D5N40S-3L._AC_SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/61D5N40S-3L._AC_SL1500_.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ImageUrl", "ImagesJson" },
                values: new object[] { "https://m.media-amazon.com/images/I/61Yp7f1FpML._AC_SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/61Yp7f1FpML._AC_SL1500_.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ImageUrl", "ImagesJson" },
                values: new object[] { "https://m.media-amazon.com/images/I/81mD-mI7HlL._AC_SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/81mD-mI7HlL._AC_SL1500_.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ImageUrl", "ImagesJson" },
                values: new object[] { "https://m.media-amazon.com/images/I/71Y88f7R8sL._AC_SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/71Y88f7R8sL._AC_SL1500_.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ImageUrl", "ImagesJson" },
                values: new object[] { "https://m.media-amazon.com/images/I/71H2l28m3BL._AC_SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/71H2l28m3BL._AC_SL1500_.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ImageUrl", "ImagesJson" },
                values: new object[] { "https://m.media-amazon.com/images/I/71vW8o-lD0L._AC_SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/71vW8o-lD0L._AC_SL1500_.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ImageUrl", "ImagesJson" },
                values: new object[] { "https://m.media-amazon.com/images/I/71YyK8p6KGL._AC_SL1500_.jpg", "[\"https://m.media-amazon.com/images/I/71YyK8p6KGL._AC_SL1500_.jpg\"]" });
        }
    }
}
