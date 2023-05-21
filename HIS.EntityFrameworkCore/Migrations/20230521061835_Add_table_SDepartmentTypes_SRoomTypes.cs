using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Add_table_SDepartmentTypes_SRoomTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: new Guid("081d52b3-d809-4ce1-82a1-5584b55b9a10"));

            migrationBuilder.DeleteData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: new Guid("6bac540b-50a1-44b9-b24b-04cfd72b5cf8"));

            migrationBuilder.DeleteData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: new Guid("e390340c-8453-43f7-86e7-00730515aa58"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("013156e1-e051-4fd8-a7e0-a036bc414530"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("17b34b73-77c4-46b2-b59c-594abf18c181"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("1f95ac99-4271-4579-ad14-f24a6960d6ac"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("2baf4933-d0e7-4227-b426-9bdb20856dcb"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("3567ee76-fbfe-4216-9121-470bf3562083"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("4f4b5d00-cd93-4a19-898a-1f21195c857f"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("6fb4583f-ad3f-4613-8bc4-9b5173444b1c"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("77ac08c2-124c-44ac-92fb-b56f6e6a6275"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("8a90899a-99cd-4785-bbe9-d5b0569962cf"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("973c61cd-9de6-495d-a751-d39df606436d"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("9b6feea1-0a46-4dff-ba79-ec14d787201e"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("cf0513be-2da0-429d-8fe3-5baecba48c73"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("d31703b3-92f0-486b-88f6-1941c6a0fd6a"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("e1445290-7514-4390-a8be-efa79f85b293"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("ed17ff0d-7e6d-4bdf-b88f-bb12cd9a1eb9"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("ee26d855-5745-4956-993f-eb3c876a283b"));

            migrationBuilder.DeleteData(
                table: "SUsers",
                keyColumn: "Id",
                keyValue: new Guid("9e57092b-d1bb-4061-81d0-c34dd152c21e"));

            migrationBuilder.AddColumn<Guid>(
                name: "RoomTypeId",
                table: "SRooms",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "SRooms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentTypeId",
                table: "SDepartments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "SDepartments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "SBranchs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SDepartmentTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SDepartmentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SRoomTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SRoomTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SRooms_RoomTypeId",
                table: "SRooms",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SDepartments_DepartmentTypeId",
                table: "SDepartments",
                column: "DepartmentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SDepartments_SDepartmentTypes_DepartmentTypeId",
                table: "SDepartments",
                column: "DepartmentTypeId",
                principalTable: "SDepartmentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SRooms_SRoomTypes_RoomTypeId",
                table: "SRooms",
                column: "RoomTypeId",
                principalTable: "SRoomTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SDepartments_SDepartmentTypes_DepartmentTypeId",
                table: "SDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_SRooms_SRoomTypes_RoomTypeId",
                table: "SRooms");

            migrationBuilder.DropTable(
                name: "SDepartmentTypes");

            migrationBuilder.DropTable(
                name: "SRoomTypes");

            migrationBuilder.DropIndex(
                name: "IX_SRooms_RoomTypeId",
                table: "SRooms");

            migrationBuilder.DropIndex(
                name: "IX_SDepartments_DepartmentTypeId",
                table: "SDepartments");

            migrationBuilder.DropColumn(
                name: "RoomTypeId",
                table: "SRooms");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "SRooms");

            migrationBuilder.DropColumn(
                name: "DepartmentTypeId",
                table: "SDepartments");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "SDepartments");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "SBranchs");

            migrationBuilder.InsertData(
                table: "SPatientTypes",
                columns: new[] { "Id", "Code", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("081d52b3-d809-4ce1-82a1-5584b55b9a10"), "VP", true, "Viện phí" },
                    { new Guid("6bac540b-50a1-44b9-b24b-04cfd72b5cf8"), "DV", true, "Dịch vụ" },
                    { new Guid("e390340c-8453-43f7-86e7-00730515aa58"), "BHYT", true, "Bảo hiểm y tế" }
                });

            migrationBuilder.InsertData(
                table: "SServiceGroup",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("013156e1-e051-4fd8-a7e0-a036bc414530"), "XN", "Xét nghiệm" },
                    { new Guid("17b34b73-77c4-46b2-b59c-594abf18c181"), "MA", "Máu" },
                    { new Guid("1f95ac99-4271-4579-ad14-f24a6960d6ac"), "VT", "Vật tư" },
                    { new Guid("2baf4933-d0e7-4227-b426-9bdb20856dcb"), "GB", "Giải phẫu bệnh lý" },
                    { new Guid("3567ee76-fbfe-4216-9121-470bf3562083"), "PT", "Phẫu thuật" },
                    { new Guid("4f4b5d00-cd93-4a19-898a-1f21195c857f"), "HA", "Chẩn đoán hình ảnh" },
                    { new Guid("6fb4583f-ad3f-4613-8bc4-9b5173444b1c"), "TT", "Thủ thuật" },
                    { new Guid("77ac08c2-124c-44ac-92fb-b56f6e6a6275"), "CL", "Khác" },
                    { new Guid("8a90899a-99cd-4785-bbe9-d5b0569962cf"), "TH", "Thuốc" },
                    { new Guid("973c61cd-9de6-495d-a751-d39df606436d"), "AN", "Suất ăn" },
                    { new Guid("9b6feea1-0a46-4dff-ba79-ec14d787201e"), "NS", "Nội soi" },
                    { new Guid("cf0513be-2da0-429d-8fe3-5baecba48c73"), "PH", "Phục hồi chức năng" },
                    { new Guid("d31703b3-92f0-486b-88f6-1941c6a0fd6a"), "KH", "Khám" },
                    { new Guid("e1445290-7514-4390-a8be-efa79f85b293"), "SA", "Siêu âm" },
                    { new Guid("ed17ff0d-7e6d-4bdf-b88f-bb12cd9a1eb9"), "CN", "Thăm dò chức năng" },
                    { new Guid("ee26d855-5745-4956-993f-eb3c876a283b"), "GI", "Giường" }
                });

            migrationBuilder.InsertData(
                table: "SUsers",
                columns: new[] { "Id", "Address", "DistrictId", "Dob", "Email", "FirstName", "GenderId", "LastName", "Password", "PhoneNumber", "ProvinceId", "Status", "UseType", "UserName", "WardId" },
                values: new object[] { new Guid("9e57092b-d1bb-4061-81d0-c34dd152c21e"), null, null, null, "administrator@gmail.com", "Admin", null, "Administrator", "79956B61E1B250869A6716CE37EFD6E6", null, null, 1, 0, "Administrator", null });
        }
    }
}
