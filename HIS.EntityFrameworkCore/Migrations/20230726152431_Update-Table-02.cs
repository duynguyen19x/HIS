using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTable02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SMedicineLines",
                columns: new[] { "Id", "Code", "Inactive", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("03bd1fdc-d2b8-4969-a029-5022ca68f31e"), "1.02", false, "Ngậm", 2 },
                    { new Guid("05a24915-0bed-4f61-b53d-b5e52482e44c"), "1.01", false, "Uống", 1 },
                    { new Guid("08f7b3c2-09da-4b4a-9c98-75c8562807ee"), "6.09", false, "Dung dịch", 44 },
                    { new Guid("0c8ba522-0e4b-40a0-9d93-936f5350853e"), "5.08", false, "Xịt họng", 38 },
                    { new Guid("0df82239-15dd-41ee-afc8-67cb51d5f3f6"), "5.03", false, "Bột hít", 33 },
                    { new Guid("13165217-8025-44e0-a92b-1f8318d56282"), "2.13", false, "Tiêm vào khối u", 18 },
                    { new Guid("1ef26d8f-57d7-423c-a8c6-e3a20a249b37"), "6.01", false, "Nhỏ mũi", 40 },
                    { new Guid("229172a9-7464-4216-8b11-4e587e4c280c"), "5.01", false, "Phun mù", 31 },
                    { new Guid("2bd555b2-74ae-4b3f-9d27-de30e10bf16f"), "3.01", false, "Bôi", 21 },
                    { new Guid("2f6e29a1-9a1f-44b0-8f9e-ea1c8716c23b"), "2.10", false, "Tiêm", 15 },
                    { new Guid("379c8a46-145d-4956-af5d-2d48d9d55087"), "6.03", false, "Tra mắt", 42 },
                    { new Guid("3df25942-afc9-4ed5-88b3-a0ff7b0ad968"), "4.02", false, "Đặt hậu môn", 26 },
                    { new Guid("41c24ffd-81f8-44f4-92f7-b3e5d418c8c7"), "2.15", false, "Tiêm truyền", 20 },
                    { new Guid("49783593-80ca-4a9f-8ff9-5d359307498c"), "4.03", false, "Thụt hậu môn - trực tràng", 27 },
                    { new Guid("5a807206-9aef-481d-87b6-88f464e6fd46"), "3.04", false, "Xịt ngoài da", 24 },
                    { new Guid("5d6b6689-0dc3-4f11-94ef-02d288cce18a"), "2.03", false, "Tiêm trong da", 8 },
                    { new Guid("5eada7db-843c-453b-8a44-3de2dacaa27b"), "1.05", false, "Ngậm dưới lưỡi", 5 },
                    { new Guid("5ef14843-323d-4fe9-a424-46ca3120fca9"), "2.02", false, "Tiêm dưới da", 7 },
                    { new Guid("60f3158e-73f2-453f-af90-072b6b25c644"), "3.05", false, "Dùng ngoài", 1 },
                    { new Guid("65ca8fd8-fb9b-4dea-9c0e-c9a3b6b8fbd8"), "2.11", false, "Tiêm động mạch khối u", 16 },
                    { new Guid("6cdf2301-9621-4f73-9c62-f48ab80245c8"), "5.02", false, "Dạng hít", 32 },
                    { new Guid("6edba7a9-20fe-49c0-9925-ba3b32ed32a0"), "2.14", false, "Tiêm truyền tĩnh mạch", 19 },
                    { new Guid("6f90ecfe-4ede-4241-918b-b18245208f56"), "2.01", false, "Tiêm bặp", 6 },
                    { new Guid("71edc6f8-3db6-4375-9005-c5328627fa28"), "3.03", false, "Dán trên da", 23 },
                    { new Guid("75017c25-2ad7-4cce-b206-38735fd3584d"), "3.02", false, "Xoa ngoài", 22 },
                    { new Guid("7990c54f-dc34-4a62-a8da-201d22c1069d"), "4.05", false, "Đặt tử cung", 29 },
                    { new Guid("7b3a86dc-9b0c-43f8-94a9-e4eec9916e30"), "5.09", false, "Thuốc mũi", 39 },
                    { new Guid("7d92b632-0ccf-4be5-a044-c3ee549fdb9f"), "6.04", false, "Nhỏ tai", 43 },
                    { new Guid("8d9cd0b1-2407-4cc3-9d94-314602e26508"), "5.07", false, "Xịt mũi", 37 },
                    { new Guid("8f65d7cf-bbd9-44f4-b556-20472aa4a5f0"), "4.06", false, "Thụt", 30 },
                    { new Guid("a26814e4-da59-4317-a297-5ca089ef2dad"), "1.04", false, "Đặt dưới lưỡi", 4 },
                    { new Guid("a29889f5-4943-4520-85fa-441c3ea9e979"), "1.03", false, "Nhai", 3 },
                    { new Guid("b12f310c-c12a-4f8f-a9bd-ddd38b4eebcf"), "5.06", false, "Đường hô hấp", 36 },
                    { new Guid("c0097373-f633-4bee-b670-2d2c35b5d172"), "2.12", false, "Tiêm vào khoang tự nhiên", 17 },
                    { new Guid("c6ffa735-8813-41ea-8984-5700dbee1ea7"), "2.09", false, "Tiêm vào các khoang của cơ thế", 14 },
                    { new Guid("ca37423b-25c7-4a84-a32d-8767bf14352b"), "5.04", false, "Xịt", 34 },
                    { new Guid("cae9f723-e795-48d5-9730-f19edceaa5b6"), "2.04", false, "Tiêm tĩnh mạch", 9 },
                    { new Guid("cb51640d-bd7e-4cba-b64d-191d4162efa4"), "4.01", false, "Đặt âm đạo", 25 },
                    { new Guid("d075055e-4ed2-4d37-82ae-c9c20cb4f08f"), "2.06", false, "Tiêm vào ổ khớp", 11 },
                    { new Guid("d36d932c-00db-451d-9a02-a401dbd89408"), "2.07", false, "Tiêm nội nhãn cầu", 12 },
                    { new Guid("d558492b-6628-40ca-aadf-5dda7701681a"), "4.04", false, "Đặt", 28 },
                    { new Guid("d81efde6-f750-4a66-adf3-a9092bb8ea9b"), "5.05", false, "Khí dung", 35 },
                    { new Guid("e485d3cc-5a96-48c9-9ed3-8725bb0136ef"), "6.02", false, "Nhỏ mắt", 41 },
                    { new Guid("e578f37b-9f1b-4098-8659-ac510ced491a"), "2.08", false, "Tiêm trong dịch kích của mắt", 13 },
                    { new Guid("febb52a6-15bc-4e28-bc84-e928b43b126b"), "2.05", false, "Tiêm truyền tĩnh mạch", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("03bd1fdc-d2b8-4969-a029-5022ca68f31e"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("05a24915-0bed-4f61-b53d-b5e52482e44c"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("08f7b3c2-09da-4b4a-9c98-75c8562807ee"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("0c8ba522-0e4b-40a0-9d93-936f5350853e"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("0df82239-15dd-41ee-afc8-67cb51d5f3f6"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("13165217-8025-44e0-a92b-1f8318d56282"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("1ef26d8f-57d7-423c-a8c6-e3a20a249b37"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("229172a9-7464-4216-8b11-4e587e4c280c"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("2bd555b2-74ae-4b3f-9d27-de30e10bf16f"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("2f6e29a1-9a1f-44b0-8f9e-ea1c8716c23b"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("379c8a46-145d-4956-af5d-2d48d9d55087"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("3df25942-afc9-4ed5-88b3-a0ff7b0ad968"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("41c24ffd-81f8-44f4-92f7-b3e5d418c8c7"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("49783593-80ca-4a9f-8ff9-5d359307498c"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("5a807206-9aef-481d-87b6-88f464e6fd46"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("5d6b6689-0dc3-4f11-94ef-02d288cce18a"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("5eada7db-843c-453b-8a44-3de2dacaa27b"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("5ef14843-323d-4fe9-a424-46ca3120fca9"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("60f3158e-73f2-453f-af90-072b6b25c644"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("65ca8fd8-fb9b-4dea-9c0e-c9a3b6b8fbd8"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("6cdf2301-9621-4f73-9c62-f48ab80245c8"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("6edba7a9-20fe-49c0-9925-ba3b32ed32a0"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("6f90ecfe-4ede-4241-918b-b18245208f56"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("71edc6f8-3db6-4375-9005-c5328627fa28"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("75017c25-2ad7-4cce-b206-38735fd3584d"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("7990c54f-dc34-4a62-a8da-201d22c1069d"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("7b3a86dc-9b0c-43f8-94a9-e4eec9916e30"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("7d92b632-0ccf-4be5-a044-c3ee549fdb9f"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("8d9cd0b1-2407-4cc3-9d94-314602e26508"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("8f65d7cf-bbd9-44f4-b556-20472aa4a5f0"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("a26814e4-da59-4317-a297-5ca089ef2dad"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("a29889f5-4943-4520-85fa-441c3ea9e979"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("b12f310c-c12a-4f8f-a9bd-ddd38b4eebcf"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("c0097373-f633-4bee-b670-2d2c35b5d172"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("c6ffa735-8813-41ea-8984-5700dbee1ea7"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("ca37423b-25c7-4a84-a32d-8767bf14352b"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("cae9f723-e795-48d5-9730-f19edceaa5b6"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("cb51640d-bd7e-4cba-b64d-191d4162efa4"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("d075055e-4ed2-4d37-82ae-c9c20cb4f08f"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("d36d932c-00db-451d-9a02-a401dbd89408"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("d558492b-6628-40ca-aadf-5dda7701681a"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("d81efde6-f750-4a66-adf3-a9092bb8ea9b"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("e485d3cc-5a96-48c9-9ed3-8725bb0136ef"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("e578f37b-9f1b-4098-8659-ac510ced491a"));

            migrationBuilder.DeleteData(
                table: "SMedicineLines",
                keyColumn: "Id",
                keyValue: new Guid("febb52a6-15bc-4e28-bc84-e928b43b126b"));
        }
    }
}
