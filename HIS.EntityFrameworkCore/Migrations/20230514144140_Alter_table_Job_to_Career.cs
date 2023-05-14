using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Alter_table_Job_to_Career : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SJobs");

            migrationBuilder.DeleteData(
                table: "SGenders",
                keyColumn: "Id",
                keyValue: new Guid("5f6ac5f2-f490-4bf6-8f41-6346963b5349"));

            migrationBuilder.DeleteData(
                table: "SGenders",
                keyColumn: "Id",
                keyValue: new Guid("78b4ece8-069e-462c-9c11-42dda6510edb"));

            migrationBuilder.DeleteData(
                table: "SGenders",
                keyColumn: "Id",
                keyValue: new Guid("aa49c357-44e7-43af-af42-c7e323cd4cac"));

            migrationBuilder.DeleteData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: new Guid("727a895c-5e30-4f94-8486-4127cb5f0eba"));

            migrationBuilder.DeleteData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: new Guid("784fd08e-aa81-4f5f-9307-e000aa5b29cc"));

            migrationBuilder.DeleteData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: new Guid("cf067c3e-087f-43c8-88b7-bbd72bc6d53d"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("08f13ede-f19c-4e78-b10e-2a08884f4ad8"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("183d02e6-57a3-411c-982d-582c6d27b89f"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("1880a455-0caa-4c07-a742-3779c3aeb283"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("2690fc9e-02e1-40d9-8a25-3625b00c2782"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("412a0557-8bfe-489b-96b5-a92a92203b5e"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("57c8bbd1-3c9c-40d3-9827-dad5af11e01c"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("7a653382-d530-47da-9249-0d85eb32d0b0"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("863c4ce4-211a-4738-b4af-a5c93c224c21"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("9d03afb4-c735-40d6-962d-530ec4a84b4a"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("c00dc9aa-4385-48fe-b23b-4076dbb8fac8"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("c7502187-7a70-4b50-ab68-942b76d3a3b1"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("cc704cd1-d178-4a1e-8ce7-7e21d630c9d8"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("dea56446-b762-4cc9-8c78-59be4462ddbb"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("f220cc06-e5e3-44b8-b92e-5ce41866fd8c"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("f3beb81e-b0c3-4422-baa8-5cb3c521e900"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("fa83a756-fe6a-4692-a37e-6da2ffa60603"));

            migrationBuilder.DeleteData(
                table: "SUsers",
                keyColumn: "Id",
                keyValue: new Guid("75242840-69a8-468e-ac78-967bcbdc673d"));

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "SPatients",
                newName: "CareerId");

            migrationBuilder.CreateTable(
                name: "SCareers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCareers", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SCareers");

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

            migrationBuilder.RenameColumn(
                name: "CareerId",
                table: "SPatients",
                newName: "JobId");

            migrationBuilder.CreateTable(
                name: "SJobs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SJobs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SGenders",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("5f6ac5f2-f490-4bf6-8f41-6346963b5349"), 2, "Nữ" },
                    { new Guid("78b4ece8-069e-462c-9c11-42dda6510edb"), 1, "Nam" },
                    { new Guid("aa49c357-44e7-43af-af42-c7e323cd4cac"), 0, "Chưa xác định" }
                });

            migrationBuilder.InsertData(
                table: "SPatientTypes",
                columns: new[] { "Id", "Code", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("727a895c-5e30-4f94-8486-4127cb5f0eba"), "DV", true, "Dịch vụ" },
                    { new Guid("784fd08e-aa81-4f5f-9307-e000aa5b29cc"), "BHYT", true, "Bảo hiểm y tế" },
                    { new Guid("cf067c3e-087f-43c8-88b7-bbd72bc6d53d"), "VP", true, "Viện phí" }
                });

            migrationBuilder.InsertData(
                table: "SServiceGroup",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("08f13ede-f19c-4e78-b10e-2a08884f4ad8"), "GB", "Giải phẫu bệnh lý" },
                    { new Guid("183d02e6-57a3-411c-982d-582c6d27b89f"), "XN", "Xét nghiệm" },
                    { new Guid("1880a455-0caa-4c07-a742-3779c3aeb283"), "CN", "Thăm dò chức năng" },
                    { new Guid("2690fc9e-02e1-40d9-8a25-3625b00c2782"), "TH", "Thuốc" },
                    { new Guid("412a0557-8bfe-489b-96b5-a92a92203b5e"), "NS", "Nội soi" },
                    { new Guid("57c8bbd1-3c9c-40d3-9827-dad5af11e01c"), "VT", "Vật tư" },
                    { new Guid("7a653382-d530-47da-9249-0d85eb32d0b0"), "CL", "Khác" },
                    { new Guid("863c4ce4-211a-4738-b4af-a5c93c224c21"), "GI", "Giường" },
                    { new Guid("9d03afb4-c735-40d6-962d-530ec4a84b4a"), "HA", "Chẩn đoán hình ảnh" },
                    { new Guid("c00dc9aa-4385-48fe-b23b-4076dbb8fac8"), "KH", "Khám" },
                    { new Guid("c7502187-7a70-4b50-ab68-942b76d3a3b1"), "AN", "Suất ăn" },
                    { new Guid("cc704cd1-d178-4a1e-8ce7-7e21d630c9d8"), "TT", "Thủ thuật" },
                    { new Guid("dea56446-b762-4cc9-8c78-59be4462ddbb"), "PT", "Phẫu thuật" },
                    { new Guid("f220cc06-e5e3-44b8-b92e-5ce41866fd8c"), "PH", "Phục hồi chức năng" },
                    { new Guid("f3beb81e-b0c3-4422-baa8-5cb3c521e900"), "MA", "Máu" },
                    { new Guid("fa83a756-fe6a-4692-a37e-6da2ffa60603"), "SA", "Siêu âm" }
                });

            migrationBuilder.InsertData(
                table: "SUsers",
                columns: new[] { "Id", "Address", "DistrictId", "Dob", "Email", "FirstName", "GenderId", "LastName", "Password", "PhoneNumber", "ProvinceId", "Status", "UseType", "UserName", "WardId" },
                values: new object[] { new Guid("75242840-69a8-468e-ac78-967bcbdc673d"), null, null, null, "administrator@gmail.com", "Admin", null, "Administrator", "79956B61E1B250869A6716CE37EFD6E6", null, null, 1, 0, "Administrator", null });
        }
    }
}
