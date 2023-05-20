using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Add_service_Patient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SGenders",
                keyColumn: "Id",
                keyValue: new Guid("332ffd30-a432-4b1d-b604-7383d86b1d78"));

            migrationBuilder.DeleteData(
                table: "SGenders",
                keyColumn: "Id",
                keyValue: new Guid("4d0e19f3-32cd-4a60-9e3e-f8e6d5e97e0e"));

            migrationBuilder.DeleteData(
                table: "SGenders",
                keyColumn: "Id",
                keyValue: new Guid("809c4d51-0061-42b4-bcca-903f74b16618"));

            migrationBuilder.DeleteData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: new Guid("181a6f9f-acb6-47c9-8435-e690c76677fa"));

            migrationBuilder.DeleteData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: new Guid("1e837911-d6b9-4f09-b067-dde0fc147edf"));

            migrationBuilder.DeleteData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: new Guid("da912b9f-b57c-4177-bedf-003b53741d7c"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("0ae71ad6-4bd1-42fb-985f-7dd73e37e4c0"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("15fe5e0d-809a-4356-870d-5d66bc4a2569"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("4bd5c1ea-34dc-468b-a056-9217c4087707"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("4f8e1b6c-8bda-4b38-b496-675d3beaf3b9"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("57d30d12-1e3b-4a87-b035-1e8a70dcf43f"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("6217e200-3168-446c-a6a7-16b0ed444359"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("6cc944cf-0b2a-49b9-a022-cec4c6d3f56b"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("7f62efdf-1d97-4e95-8879-c1a2a5849d0a"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("818d6eea-1c94-4658-b9b2-705d2bc53ca4"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("862bc01a-4b1c-4c28-a3a3-0769b833f279"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("9ec9b9d2-cf8c-4908-bd6e-f00fbab4c130"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("b59feb3f-91a7-4c2d-8f77-db42d9de43a9"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("bbdf76c4-38c4-478d-93e9-218c2b26b20e"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("cf62fdf0-506b-4d5a-b0c7-882fe8b09837"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("ea15bc7d-2eaa-4f21-9884-8a3e60c1b781"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("f6915ae3-0b3d-4366-9f89-9eaf362a38d2"));

            migrationBuilder.DeleteData(
                table: "SUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdfdc919-f460-4fa4-acae-393a1b4859e2"));

            migrationBuilder.DropColumn(
                name: "IdentificationNumber",
                table: "STreatments");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "STreatments");

            migrationBuilder.DropColumn(
                name: "RelateAddress",
                table: "STreatments");

            migrationBuilder.DropColumn(
                name: "RelateIdentificationNumber",
                table: "STreatments");

            migrationBuilder.DropColumn(
                name: "RelateName",
                table: "STreatments");

            migrationBuilder.DropColumn(
                name: "RelatePhoneNumbar",
                table: "STreatments");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "SPatients",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "NationalId",
                table: "SPatients",
                newName: "WardId");

            migrationBuilder.RenameColumn(
                name: "CommuneId",
                table: "SPatients",
                newName: "EthnicId");

            migrationBuilder.RenameColumn(
                name: "CitizenIdNumber",
                table: "SPatients",
                newName: "IdentificationNumber");

            migrationBuilder.RenameColumn(
                name: "CitizenIdIssuedBy",
                table: "SPatients",
                newName: "IdentificationNumberIssuedBy");

            migrationBuilder.RenameColumn(
                name: "CitizenIdDate",
                table: "SPatients",
                newName: "IdentificationNumberIssuedDate");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DOB",
                table: "SPatients",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "SPatients",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RelativeAddress",
                table: "SPatients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RelativeIdentificationNumber",
                table: "SPatients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RelativeName",
                table: "SPatients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RelativePhoneNumbar",
                table: "SPatients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "SPatients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "SGenders",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("1b3ef3f7-eb71-4b9e-80e8-142dac943c45"), 1, "Nam" },
                    { new Guid("9a3067c2-9f4c-471d-96b4-5f22acd4c868"), 2, "Nữ" },
                    { new Guid("c0aed2c8-22ee-4efa-b965-fa1098934a24"), 0, "Chưa xác định" }
                });

            migrationBuilder.InsertData(
                table: "SPatientTypes",
                columns: new[] { "Id", "Code", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("92d334af-4bec-45c4-83fe-4522bddd9bc6"), "DV", true, "Dịch vụ" },
                    { new Guid("a6331da2-d50e-4665-b66e-247ce2d90e0b"), "BHYT", true, "Bảo hiểm y tế" },
                    { new Guid("f06fd769-fceb-461e-9020-83ddc81afad9"), "VP", true, "Viện phí" }
                });

            migrationBuilder.InsertData(
                table: "SServiceGroup",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("32ade4bc-08cf-43b5-8e95-0fa9ad4d7fb9"), "PT", "Phẫu thuật" },
                    { new Guid("36503926-dbbd-460c-84ad-715e71b48861"), "CL", "Khác" },
                    { new Guid("3a559b5d-66c5-4485-ae54-3c38a2562814"), "CN", "Thăm dò chức năng" },
                    { new Guid("814b3eee-5479-4120-8d24-c6ed06f9b746"), "VT", "Vật tư" },
                    { new Guid("86c50b9c-c2c7-4bb6-bdbd-d6228ad2bc61"), "NS", "Nội soi" },
                    { new Guid("9117cec2-39c4-477c-9d94-77066f565337"), "PH", "Phục hồi chức năng" },
                    { new Guid("95195990-b367-4a76-9989-965b490c33e7"), "MA", "Máu" },
                    { new Guid("9625b3ce-45b0-4f8b-abf0-b544c891d5e4"), "SA", "Siêu âm" },
                    { new Guid("a3d0a754-1180-426e-b341-f2a046d5d0a5"), "TH", "Thuốc" },
                    { new Guid("b51e4358-6add-42b9-a0a6-48fef3329215"), "HA", "Chẩn đoán hình ảnh" },
                    { new Guid("c1c8a692-13c5-448f-8b47-f50cbf0fa618"), "AN", "Suất ăn" },
                    { new Guid("d22129f3-8bfa-4457-8bdc-ebf4cbb2c412"), "GI", "Giường" },
                    { new Guid("d8125a7d-b072-4413-9885-74179ec1e423"), "KH", "Khám" },
                    { new Guid("ed304128-352d-4217-9918-4de64e0bc61d"), "TT", "Thủ thuật" },
                    { new Guid("ed56ecb7-3548-4b26-9052-ca5a23f14b69"), "GB", "Giải phẫu bệnh lý" },
                    { new Guid("f14d6c60-6004-4de3-891f-b6d2f30ce2c9"), "XN", "Xét nghiệm" }
                });

            migrationBuilder.InsertData(
                table: "SUsers",
                columns: new[] { "Id", "Address", "DistrictId", "Dob", "Email", "FirstName", "GenderId", "LastName", "Password", "PhoneNumber", "ProvinceId", "Status", "UseType", "UserName", "WardId" },
                values: new object[] { new Guid("1b591bfd-a3e0-4497-8820-4c0fe16c6c63"), null, null, null, "administrator@gmail.com", "Admin", null, "Administrator", "79956B61E1B250869A6716CE37EFD6E6", null, null, 1, 0, "Administrator", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SGenders",
                keyColumn: "Id",
                keyValue: new Guid("1b3ef3f7-eb71-4b9e-80e8-142dac943c45"));

            migrationBuilder.DeleteData(
                table: "SGenders",
                keyColumn: "Id",
                keyValue: new Guid("9a3067c2-9f4c-471d-96b4-5f22acd4c868"));

            migrationBuilder.DeleteData(
                table: "SGenders",
                keyColumn: "Id",
                keyValue: new Guid("c0aed2c8-22ee-4efa-b965-fa1098934a24"));

            migrationBuilder.DeleteData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: new Guid("92d334af-4bec-45c4-83fe-4522bddd9bc6"));

            migrationBuilder.DeleteData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: new Guid("a6331da2-d50e-4665-b66e-247ce2d90e0b"));

            migrationBuilder.DeleteData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: new Guid("f06fd769-fceb-461e-9020-83ddc81afad9"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("32ade4bc-08cf-43b5-8e95-0fa9ad4d7fb9"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("36503926-dbbd-460c-84ad-715e71b48861"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("3a559b5d-66c5-4485-ae54-3c38a2562814"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("814b3eee-5479-4120-8d24-c6ed06f9b746"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("86c50b9c-c2c7-4bb6-bdbd-d6228ad2bc61"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("9117cec2-39c4-477c-9d94-77066f565337"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("95195990-b367-4a76-9989-965b490c33e7"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("9625b3ce-45b0-4f8b-abf0-b544c891d5e4"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("a3d0a754-1180-426e-b341-f2a046d5d0a5"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("b51e4358-6add-42b9-a0a6-48fef3329215"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("c1c8a692-13c5-448f-8b47-f50cbf0fa618"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("d22129f3-8bfa-4457-8bdc-ebf4cbb2c412"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("d8125a7d-b072-4413-9885-74179ec1e423"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("ed304128-352d-4217-9918-4de64e0bc61d"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("ed56ecb7-3548-4b26-9052-ca5a23f14b69"));

            migrationBuilder.DeleteData(
                table: "SServiceGroup",
                keyColumn: "Id",
                keyValue: new Guid("f14d6c60-6004-4de3-891f-b6d2f30ce2c9"));

            migrationBuilder.DeleteData(
                table: "SUsers",
                keyColumn: "Id",
                keyValue: new Guid("1b591bfd-a3e0-4497-8820-4c0fe16c6c63"));

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "SPatients");

            migrationBuilder.DropColumn(
                name: "RelativeAddress",
                table: "SPatients");

            migrationBuilder.DropColumn(
                name: "RelativeIdentificationNumber",
                table: "SPatients");

            migrationBuilder.DropColumn(
                name: "RelativeName",
                table: "SPatients");

            migrationBuilder.DropColumn(
                name: "RelativePhoneNumbar",
                table: "SPatients");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "SPatients");

            migrationBuilder.RenameColumn(
                name: "WardId",
                table: "SPatients",
                newName: "NationalId");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "SPatients",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "IdentificationNumberIssuedDate",
                table: "SPatients",
                newName: "CitizenIdDate");

            migrationBuilder.RenameColumn(
                name: "IdentificationNumberIssuedBy",
                table: "SPatients",
                newName: "CitizenIdIssuedBy");

            migrationBuilder.RenameColumn(
                name: "IdentificationNumber",
                table: "SPatients",
                newName: "CitizenIdNumber");

            migrationBuilder.RenameColumn(
                name: "EthnicId",
                table: "SPatients",
                newName: "CommuneId");

            migrationBuilder.AddColumn<string>(
                name: "IdentificationNumber",
                table: "STreatments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "STreatments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RelateAddress",
                table: "STreatments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RelateIdentificationNumber",
                table: "STreatments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RelateName",
                table: "STreatments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RelatePhoneNumbar",
                table: "STreatments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DOB",
                table: "SPatients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "SGenders",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("332ffd30-a432-4b1d-b604-7383d86b1d78"), 0, "Chưa xác định" },
                    { new Guid("4d0e19f3-32cd-4a60-9e3e-f8e6d5e97e0e"), 2, "Nữ" },
                    { new Guid("809c4d51-0061-42b4-bcca-903f74b16618"), 1, "Nam" }
                });

            migrationBuilder.InsertData(
                table: "SPatientTypes",
                columns: new[] { "Id", "Code", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("181a6f9f-acb6-47c9-8435-e690c76677fa"), "DV", true, "Dịch vụ" },
                    { new Guid("1e837911-d6b9-4f09-b067-dde0fc147edf"), "BHYT", true, "Bảo hiểm y tế" },
                    { new Guid("da912b9f-b57c-4177-bedf-003b53741d7c"), "VP", true, "Viện phí" }
                });

            migrationBuilder.InsertData(
                table: "SServiceGroup",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("0ae71ad6-4bd1-42fb-985f-7dd73e37e4c0"), "PT", "Phẫu thuật" },
                    { new Guid("15fe5e0d-809a-4356-870d-5d66bc4a2569"), "SA", "Siêu âm" },
                    { new Guid("4bd5c1ea-34dc-468b-a056-9217c4087707"), "KH", "Khám" },
                    { new Guid("4f8e1b6c-8bda-4b38-b496-675d3beaf3b9"), "GB", "Giải phẫu bệnh lý" },
                    { new Guid("57d30d12-1e3b-4a87-b035-1e8a70dcf43f"), "TT", "Thủ thuật" },
                    { new Guid("6217e200-3168-446c-a6a7-16b0ed444359"), "PH", "Phục hồi chức năng" },
                    { new Guid("6cc944cf-0b2a-49b9-a022-cec4c6d3f56b"), "AN", "Suất ăn" },
                    { new Guid("7f62efdf-1d97-4e95-8879-c1a2a5849d0a"), "CN", "Thăm dò chức năng" },
                    { new Guid("818d6eea-1c94-4658-b9b2-705d2bc53ca4"), "HA", "Chẩn đoán hình ảnh" },
                    { new Guid("862bc01a-4b1c-4c28-a3a3-0769b833f279"), "NS", "Nội soi" },
                    { new Guid("9ec9b9d2-cf8c-4908-bd6e-f00fbab4c130"), "VT", "Vật tư" },
                    { new Guid("b59feb3f-91a7-4c2d-8f77-db42d9de43a9"), "GI", "Giường" },
                    { new Guid("bbdf76c4-38c4-478d-93e9-218c2b26b20e"), "TH", "Thuốc" },
                    { new Guid("cf62fdf0-506b-4d5a-b0c7-882fe8b09837"), "CL", "Khác" },
                    { new Guid("ea15bc7d-2eaa-4f21-9884-8a3e60c1b781"), "XN", "Xét nghiệm" },
                    { new Guid("f6915ae3-0b3d-4366-9f89-9eaf362a38d2"), "MA", "Máu" }
                });

            migrationBuilder.InsertData(
                table: "SUsers",
                columns: new[] { "Id", "Address", "DistrictId", "Dob", "Email", "FirstName", "GenderId", "LastName", "Password", "PhoneNumber", "ProvinceId", "Status", "UseType", "UserName", "WardId" },
                values: new object[] { new Guid("bdfdc919-f460-4fa4-acae-393a1b4859e2"), null, null, null, "administrator@gmail.com", "Admin", null, "Administrator", "79956B61E1B250869A6716CE37EFD6E6", null, null, 1, 0, "Administrator", null });
        }
    }
}
