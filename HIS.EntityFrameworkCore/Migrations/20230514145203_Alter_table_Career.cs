using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Alter_table_Career : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SGenders",
                keyColumn: "Id",
                keyValue: new Guid("170b6244-f4df-465e-a9ea-44c4ca9524e0"));

            migrationBuilder.DeleteData(
                table: "SGenders",
                keyColumn: "Id",
                keyValue: new Guid("5b16efcb-1060-4f9f-9d18-dcdcd075c86d"));

            migrationBuilder.DeleteData(
                table: "SGenders",
                keyColumn: "Id",
                keyValue: new Guid("facfadbf-22ce-4072-bbda-01a923e2e253"));

            migrationBuilder.DeleteData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: new Guid("6f9cf43e-fd34-4512-bb25-d504c28ae817"));

            migrationBuilder.DeleteData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: new Guid("a5bde015-3a01-461d-944f-489f96eb1899"));

            migrationBuilder.DeleteData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: new Guid("cb4c2b2c-48ee-4e06-90ee-812671df56b9"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("0b1bfc59-e9a3-498b-9a85-e8b9c3ca4ea6"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("14822dc5-de68-420e-8f99-862a6ecb9584"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("1c7aab18-f1d0-4af7-aad9-9c9b02fcfe8b"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("3cc3ef8b-3ea1-466d-8913-7ebb67fb547f"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("84603b63-71c4-4b3d-a4a9-f6c03f2c137e"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("8a560ca6-19f9-457d-86b2-93c9e1153939"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("9b1ebf8e-e0ef-4b85-a09d-226ec8156c51"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("9b899ec8-0496-4874-89d3-af9cc9ce7301"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("ab9f7bca-d77b-4f43-8cc2-d068528bb13f"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("ada58d4d-923b-4153-a084-64427ed638c5"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("b655575f-9d77-4950-afdd-ec8924ac6cf4"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("b82d10f1-96c1-499b-97be-f444835f3c8b"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("b91db5c8-0a06-4953-bc68-ba1877ab3751"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("c159f9fd-f8e8-40eb-a302-6b5bfeaa9947"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("fb880147-f2b8-47de-bca9-9ceb439964d9"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("fc0fff47-99d3-43c4-b976-ddbea276d130"));

            migrationBuilder.DeleteData(
                table: "SUsers",
                keyColumn: "Id",
                keyValue: new Guid("84c9f5ee-4042-4583-a4d5-7b607cbf08fc"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SCareers",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SCareers",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "SCareers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "SCareers",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "SGenders",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("0d4b0893-9280-46d7-96e5-c944e20c46ed"), 2, "Nữ" },
                    { new Guid("9260f520-9e08-4e42-b8ae-2d1907397bd6"), 0, "Chưa xác định" },
                    { new Guid("a15c24d8-f3d3-420d-b305-e5bb77662da8"), 1, "Nam" }
                });

            migrationBuilder.InsertData(
                table: "SPatientTypes",
                columns: new[] { "Id", "Code", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("c678ad0c-5796-4662-b147-b09a10881205"), "DV", true, "Dịch vụ" },
                    { new Guid("f0d4c17a-9ec3-4bd5-a680-cdd1563a9269"), "BHYT", true, "Bảo hiểm y tế" },
                    { new Guid("fbe3f357-562e-4b3d-a0db-39772b4ffc34"), "VP", true, "Viện phí" }
                });

            migrationBuilder.InsertData(
                table: "SServiceGroup",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("1027b1e0-42fc-4ac1-b88e-1e3edc595d22"), "TH", "Thuốc" },
                    { new Guid("145c85c8-c6ac-4492-88d9-18f735dbbb13"), "CL", "Khác" },
                    { new Guid("1d4eb8f6-944b-45e9-9562-2bedb81b0220"), "KH", "Khám" },
                    { new Guid("1e4092a9-fa62-4e4a-82b8-b63c3dc4ec88"), "PT", "Phẫu thuật" },
                    { new Guid("29364bd7-88f7-4eab-9ff6-8f9a10f5fead"), "PH", "Phục hồi chức năng" },
                    { new Guid("29f568e7-49de-47a0-86c3-1007348045f3"), "TT", "Thủ thuật" },
                    { new Guid("352d4f0c-abc5-470e-ad5a-5d1b626f3019"), "GB", "Giải phẫu bệnh lý" },
                    { new Guid("4a4a1a7e-3ab1-433c-89a5-193ffd283862"), "CN", "Thăm dò chức năng" },
                    { new Guid("53c01555-d3ff-4ac5-aa75-632bc31302b3"), "XN", "Xét nghiệm" },
                    { new Guid("5bf94a61-3ef4-477a-9ef0-b6ab41cf0df0"), "SA", "Siêu âm" },
                    { new Guid("8d1c9571-ae22-4af1-af18-8a2c5f9e687a"), "AN", "Suất ăn" },
                    { new Guid("8fd815e5-02be-4218-83de-5e43826573dc"), "GI", "Giường" },
                    { new Guid("9688c586-3368-4e25-b2fc-38b2f5400475"), "HA", "Chẩn đoán hình ảnh" },
                    { new Guid("c053c05f-2979-44cc-99dd-a53d8481366b"), "NS", "Nội soi" },
                    { new Guid("e411d05b-a53a-45f4-8e32-435ef5e926e0"), "MA", "Máu" },
                    { new Guid("fdb190e7-0818-4392-943a-119c1715ab4b"), "VT", "Vật tư" }
                });

            migrationBuilder.InsertData(
                table: "SUsers",
                columns: new[] { "Id", "Address", "DistrictId", "Dob", "Email", "FirstName", "GenderId", "LastName", "Password", "PhoneNumber", "ProvinceId", "Status", "UseType", "UserName", "WardId" },
                values: new object[] { new Guid("45a3660b-71a2-431d-ad08-ccbe123df94e"), null, null, null, "administrator@gmail.com", "Admin", null, "Administrator", "79956B61E1B250869A6716CE37EFD6E6", null, null, 1, 0, "Administrator", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SGenders",
                keyColumn: "Id",
                keyValue: new Guid("0d4b0893-9280-46d7-96e5-c944e20c46ed"));

            migrationBuilder.DeleteData(
                table: "SGenders",
                keyColumn: "Id",
                keyValue: new Guid("9260f520-9e08-4e42-b8ae-2d1907397bd6"));

            migrationBuilder.DeleteData(
                table: "SGenders",
                keyColumn: "Id",
                keyValue: new Guid("a15c24d8-f3d3-420d-b305-e5bb77662da8"));

            migrationBuilder.DeleteData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: new Guid("c678ad0c-5796-4662-b147-b09a10881205"));

            migrationBuilder.DeleteData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: new Guid("f0d4c17a-9ec3-4bd5-a680-cdd1563a9269"));

            migrationBuilder.DeleteData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: new Guid("fbe3f357-562e-4b3d-a0db-39772b4ffc34"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("1027b1e0-42fc-4ac1-b88e-1e3edc595d22"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("145c85c8-c6ac-4492-88d9-18f735dbbb13"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("1d4eb8f6-944b-45e9-9562-2bedb81b0220"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("1e4092a9-fa62-4e4a-82b8-b63c3dc4ec88"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("29364bd7-88f7-4eab-9ff6-8f9a10f5fead"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("29f568e7-49de-47a0-86c3-1007348045f3"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("352d4f0c-abc5-470e-ad5a-5d1b626f3019"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("4a4a1a7e-3ab1-433c-89a5-193ffd283862"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("53c01555-d3ff-4ac5-aa75-632bc31302b3"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("5bf94a61-3ef4-477a-9ef0-b6ab41cf0df0"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("8d1c9571-ae22-4af1-af18-8a2c5f9e687a"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("8fd815e5-02be-4218-83de-5e43826573dc"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("9688c586-3368-4e25-b2fc-38b2f5400475"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("c053c05f-2979-44cc-99dd-a53d8481366b"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("e411d05b-a53a-45f4-8e32-435ef5e926e0"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("fdb190e7-0818-4392-943a-119c1715ab4b"));

            migrationBuilder.DeleteData(
                table: "SUsers",
                keyColumn: "Id",
                keyValue: new Guid("45a3660b-71a2-431d-ad08-ccbe123df94e"));

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "SCareers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SCareers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SCareers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "SCareers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "SGenders",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("170b6244-f4df-465e-a9ea-44c4ca9524e0"), 2, "Nữ" },
                    { new Guid("5b16efcb-1060-4f9f-9d18-dcdcd075c86d"), 0, "Chưa xác định" },
                    { new Guid("facfadbf-22ce-4072-bbda-01a923e2e253"), 1, "Nam" }
                });

            migrationBuilder.InsertData(
                table: "SPatientTypes",
                columns: new[] { "Id", "Code", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("6f9cf43e-fd34-4512-bb25-d504c28ae817"), "DV", true, "Dịch vụ" },
                    { new Guid("a5bde015-3a01-461d-944f-489f96eb1899"), "VP", true, "Viện phí" },
                    { new Guid("cb4c2b2c-48ee-4e06-90ee-812671df56b9"), "BHYT", true, "Bảo hiểm y tế" }
                });

            migrationBuilder.InsertData(
                table: "SServiceGroup",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("0b1bfc59-e9a3-498b-9a85-e8b9c3ca4ea6"), "CN", "Thăm dò chức năng" },
                    { new Guid("14822dc5-de68-420e-8f99-862a6ecb9584"), "GB", "Giải phẫu bệnh lý" },
                    { new Guid("1c7aab18-f1d0-4af7-aad9-9c9b02fcfe8b"), "PT", "Phẫu thuật" },
                    { new Guid("3cc3ef8b-3ea1-466d-8913-7ebb67fb547f"), "SA", "Siêu âm" },
                    { new Guid("84603b63-71c4-4b3d-a4a9-f6c03f2c137e"), "TH", "Thuốc" },
                    { new Guid("8a560ca6-19f9-457d-86b2-93c9e1153939"), "KH", "Khám" },
                    { new Guid("9b1ebf8e-e0ef-4b85-a09d-226ec8156c51"), "XN", "Xét nghiệm" },
                    { new Guid("9b899ec8-0496-4874-89d3-af9cc9ce7301"), "MA", "Máu" },
                    { new Guid("ab9f7bca-d77b-4f43-8cc2-d068528bb13f"), "CL", "Khác" },
                    { new Guid("ada58d4d-923b-4153-a084-64427ed638c5"), "HA", "Chẩn đoán hình ảnh" },
                    { new Guid("b655575f-9d77-4950-afdd-ec8924ac6cf4"), "GI", "Giường" },
                    { new Guid("b82d10f1-96c1-499b-97be-f444835f3c8b"), "NS", "Nội soi" },
                    { new Guid("b91db5c8-0a06-4953-bc68-ba1877ab3751"), "TT", "Thủ thuật" },
                    { new Guid("c159f9fd-f8e8-40eb-a302-6b5bfeaa9947"), "AN", "Suất ăn" },
                    { new Guid("fb880147-f2b8-47de-bca9-9ceb439964d9"), "PH", "Phục hồi chức năng" },
                    { new Guid("fc0fff47-99d3-43c4-b976-ddbea276d130"), "VT", "Vật tư" }
                });

            migrationBuilder.InsertData(
                table: "SUsers",
                columns: new[] { "Id", "Address", "DistrictId", "Dob", "Email", "FirstName", "GenderId", "LastName", "Password", "PhoneNumber", "ProvinceId", "Status", "UseType", "UserName", "WardId" },
                values: new object[] { new Guid("84c9f5ee-4042-4583-a4d5-7b607cbf08fc"), null, null, null, "administrator@gmail.com", "Admin", null, "Administrator", "79956B61E1B250869A6716CE37EFD6E6", null, null, 1, 0, "Administrator", null });
        }
    }
}
