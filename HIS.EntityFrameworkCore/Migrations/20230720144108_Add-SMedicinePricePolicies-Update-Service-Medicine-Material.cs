using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class AddSMedicinePricePoliciesUpdateServiceMedicineMaterial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SMaterials_SServiceUnits_ServiceUnitId",
                table: "SMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_SMaterialTypes_SMedicineGroups_SMedicineGroupId",
                table: "SMaterialTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_SMedicines_SServiceUnits_ServiceUnitId",
                table: "SMedicines");

            migrationBuilder.DropForeignKey(
                name: "FK_SMedicines_SServices_ServiceId",
                table: "SMedicines");

            migrationBuilder.DropForeignKey(
                name: "FK_SMedicineTypes_SServiceUnits_ServiceUnitId",
                table: "SMedicineTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_SMedicineTypes_SServices_ServiceId",
                table: "SMedicineTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_SServices_SServiceUnits_ServiceUnitId",
                table: "SServices");

            migrationBuilder.DropIndex(
                name: "IX_SMaterialTypes_SMedicineGroupId",
                table: "SMaterialTypes");

            migrationBuilder.DropColumn(
                name: "ImpPrice",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "ImpVatRate",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "InternalPrice",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "NationalId",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "NationalId",
                table: "SMedicines");

            migrationBuilder.DropColumn(
                name: "SMedicineGroupId",
                table: "SMaterialTypes");

            migrationBuilder.RenameColumn(
                name: "ServiceUnitId",
                table: "SServices",
                newName: "UnitId");

            migrationBuilder.RenameIndex(
                name: "IX_SServices_ServiceUnitId",
                table: "SServices",
                newName: "IX_SServices_UnitId");

            migrationBuilder.RenameColumn(
                name: "ServiceUnitId",
                table: "SMedicineTypes",
                newName: "UnitId");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "SMedicineTypes",
                newName: "SServiceId");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "SMedicineTypes",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_SMedicineTypes_ServiceUnitId",
                table: "SMedicineTypes",
                newName: "IX_SMedicineTypes_UnitId");

            migrationBuilder.RenameIndex(
                name: "IX_SMedicineTypes_ServiceId",
                table: "SMedicineTypes",
                newName: "IX_SMedicineTypes_SServiceId");

            migrationBuilder.RenameColumn(
                name: "ServiceUnitId",
                table: "SMedicines",
                newName: "UnitId");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "SMedicines",
                newName: "SServiceId");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "SMedicines",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_SMedicines_ServiceUnitId",
                table: "SMedicines",
                newName: "IX_SMedicines_UnitId");

            migrationBuilder.RenameIndex(
                name: "IX_SMedicines_ServiceId",
                table: "SMedicines",
                newName: "IX_SMedicines_SServiceId");

            migrationBuilder.RenameColumn(
                name: "ServiceUnitId",
                table: "SMaterials",
                newName: "UnitId");

            migrationBuilder.RenameIndex(
                name: "IX_SMaterials_ServiceUnitId",
                table: "SMaterials",
                newName: "IX_SMaterials_UnitId");

            migrationBuilder.AddColumn<int>(
                name: "UnitType",
                table: "SServiceUnits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ActiveSubstance",
                table: "SMedicineTypes",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Concentration",
                table: "SMedicineTypes",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "SMedicineTypes",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dosage",
                table: "SMedicineTypes",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "SMedicineTypes",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PackagingSpecifications",
                table: "SMedicineTypes",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ActiveSubstance",
                table: "SMedicines",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Concentration",
                table: "SMedicines",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "SMedicines",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dosage",
                table: "SMedicines",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "SMedicines",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PackagingSpecifications",
                table: "SMedicines",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SMedicinePricePolicy",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PatientTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OldUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NewUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CeilingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ExecutionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SMedicineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SPatientTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMedicinePricePolicy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SMedicinePricePolicy_SMedicines_SMedicineId",
                        column: x => x.SMedicineId,
                        principalTable: "SMedicines",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SMedicinePricePolicy_SPatientTypes_SPatientTypeId",
                        column: x => x.SPatientTypeId,
                        principalTable: "SPatientTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "SRoomTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Kho thuốc ngoại trú");

            migrationBuilder.UpdateData(
                table: "SRoomTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Kho thuốc nội trú");

            migrationBuilder.UpdateData(
                table: "SRoomTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "Name" },
                values: new object[] { "TT-TH", "Tủ trực thuốc" });

            migrationBuilder.UpdateData(
                table: "SRoomTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "Name" },
                values: new object[] { "KHO-VT-NgT", "Kho VTYT ngoại trú" });

            migrationBuilder.UpdateData(
                table: "SRoomTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "Name" },
                values: new object[] { "KHO-VT-NT", "Kho VTYT nội trú" });

            migrationBuilder.InsertData(
                table: "SRoomTypes",
                columns: new[] { "Id", "Code", "Description", "Inactive", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 14, "TT-VT", null, false, "Tủ trực VTYT", 14 },
                    { 15, "QLT", null, false, "Quản lý thuốc", 15 },
                    { 16, "QLVT", null, false, "Quản lý vật tư", 16 }
                });

            migrationBuilder.UpdateData(
                table: "SServiceUnits",
                keyColumn: "Id",
                keyValue: new Guid("0762aebf-cbb8-4102-b923-a30df490f75d"),
                column: "UnitType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SServiceUnits",
                keyColumn: "Id",
                keyValue: new Guid("2198d1c0-57fa-453f-b605-9cef55929067"),
                column: "UnitType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SServiceUnits",
                keyColumn: "Id",
                keyValue: new Guid("3be8bc27-3940-451c-87f5-c062df716872"),
                column: "UnitType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SServiceUnits",
                keyColumn: "Id",
                keyValue: new Guid("44ab6ffc-f1a9-47d0-90ab-9f09d767c286"),
                column: "UnitType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SServiceUnits",
                keyColumn: "Id",
                keyValue: new Guid("49793db4-c0ce-43c1-b439-eacd554fa06e"),
                column: "UnitType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SServiceUnits",
                keyColumn: "Id",
                keyValue: new Guid("6cc9258a-5f48-4c22-8cd6-61c0795f5405"),
                column: "UnitType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SServiceUnits",
                keyColumn: "Id",
                keyValue: new Guid("7a0fed4a-e62a-4e9f-8e92-7332127ca248"),
                column: "UnitType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SServiceUnits",
                keyColumn: "Id",
                keyValue: new Guid("9e12370e-b3ce-4862-8e7d-83d8f7ec56d1"),
                column: "UnitType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SServiceUnits",
                keyColumn: "Id",
                keyValue: new Guid("9ff4f404-68bd-4780-99bc-1033227cbe3d"),
                column: "UnitType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SServiceUnits",
                keyColumn: "Id",
                keyValue: new Guid("a7e37e54-47b8-4716-b493-b657d4981e35"),
                column: "UnitType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SServiceUnits",
                keyColumn: "Id",
                keyValue: new Guid("ae0ece26-bb4c-4b23-95cb-1a5d66114634"),
                column: "UnitType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SServiceUnits",
                keyColumn: "Id",
                keyValue: new Guid("bf42cbf7-b5ac-4503-b73d-d91f4051fa8f"),
                column: "UnitType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SServiceUnits",
                keyColumn: "Id",
                keyValue: new Guid("c587599c-a6a6-454f-8e30-2a92dac6f588"),
                column: "UnitType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SServiceUnits",
                keyColumn: "Id",
                keyValue: new Guid("cc8713c1-536a-4835-bd7e-187603566f95"),
                column: "UnitType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SServiceUnits",
                keyColumn: "Id",
                keyValue: new Guid("da514a31-4dfc-4445-99bd-4ae29359ad48"),
                column: "UnitType",
                value: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SMedicineTypes_CountryId",
                table: "SMedicineTypes",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicineTypes_MedicineGroupId",
                table: "SMedicineTypes",
                column: "MedicineGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicines_CountryId",
                table: "SMedicines",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicinePricePolicy_SMedicineId",
                table: "SMedicinePricePolicy",
                column: "SMedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicinePricePolicy_SPatientTypeId",
                table: "SMedicinePricePolicy",
                column: "SPatientTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SMaterials_SServiceUnits_UnitId",
                table: "SMaterials",
                column: "UnitId",
                principalTable: "SServiceUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SMedicines_SCountries_CountryId",
                table: "SMedicines",
                column: "CountryId",
                principalTable: "SCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SMedicines_SServiceUnits_UnitId",
                table: "SMedicines",
                column: "UnitId",
                principalTable: "SServiceUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SMedicines_SServices_SServiceId",
                table: "SMedicines",
                column: "SServiceId",
                principalTable: "SServices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SMedicineTypes_SCountries_CountryId",
                table: "SMedicineTypes",
                column: "CountryId",
                principalTable: "SCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SMedicineTypes_SMedicineGroups_MedicineGroupId",
                table: "SMedicineTypes",
                column: "MedicineGroupId",
                principalTable: "SMedicineGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SMedicineTypes_SServiceUnits_UnitId",
                table: "SMedicineTypes",
                column: "UnitId",
                principalTable: "SServiceUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SMedicineTypes_SServices_SServiceId",
                table: "SMedicineTypes",
                column: "SServiceId",
                principalTable: "SServices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SServices_SServiceUnits_UnitId",
                table: "SServices",
                column: "UnitId",
                principalTable: "SServiceUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SMaterials_SServiceUnits_UnitId",
                table: "SMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_SMedicines_SCountries_CountryId",
                table: "SMedicines");

            migrationBuilder.DropForeignKey(
                name: "FK_SMedicines_SServiceUnits_UnitId",
                table: "SMedicines");

            migrationBuilder.DropForeignKey(
                name: "FK_SMedicines_SServices_SServiceId",
                table: "SMedicines");

            migrationBuilder.DropForeignKey(
                name: "FK_SMedicineTypes_SCountries_CountryId",
                table: "SMedicineTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_SMedicineTypes_SMedicineGroups_MedicineGroupId",
                table: "SMedicineTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_SMedicineTypes_SServiceUnits_UnitId",
                table: "SMedicineTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_SMedicineTypes_SServices_SServiceId",
                table: "SMedicineTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_SServices_SServiceUnits_UnitId",
                table: "SServices");

            migrationBuilder.DropTable(
                name: "SMedicinePricePolicy");

            migrationBuilder.DropIndex(
                name: "IX_SMedicineTypes_CountryId",
                table: "SMedicineTypes");

            migrationBuilder.DropIndex(
                name: "IX_SMedicineTypes_MedicineGroupId",
                table: "SMedicineTypes");

            migrationBuilder.DropIndex(
                name: "IX_SMedicines_CountryId",
                table: "SMedicines");

            migrationBuilder.DeleteData(
                table: "SRoomTypes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SRoomTypes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SRoomTypes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DropColumn(
                name: "UnitType",
                table: "SServiceUnits");

            migrationBuilder.DropColumn(
                name: "ActiveSubstance",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "Concentration",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "Dosage",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "PackagingSpecifications",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "ActiveSubstance",
                table: "SMedicines");

            migrationBuilder.DropColumn(
                name: "Concentration",
                table: "SMedicines");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "SMedicines");

            migrationBuilder.DropColumn(
                name: "Dosage",
                table: "SMedicines");

            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "SMedicines");

            migrationBuilder.DropColumn(
                name: "PackagingSpecifications",
                table: "SMedicines");

            migrationBuilder.RenameColumn(
                name: "UnitId",
                table: "SServices",
                newName: "ServiceUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_SServices_UnitId",
                table: "SServices",
                newName: "IX_SServices_ServiceUnitId");

            migrationBuilder.RenameColumn(
                name: "UnitId",
                table: "SMedicineTypes",
                newName: "ServiceUnitId");

            migrationBuilder.RenameColumn(
                name: "SServiceId",
                table: "SMedicineTypes",
                newName: "ServiceId");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "SMedicineTypes",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_SMedicineTypes_UnitId",
                table: "SMedicineTypes",
                newName: "IX_SMedicineTypes_ServiceUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_SMedicineTypes_SServiceId",
                table: "SMedicineTypes",
                newName: "IX_SMedicineTypes_ServiceId");

            migrationBuilder.RenameColumn(
                name: "UnitId",
                table: "SMedicines",
                newName: "ServiceUnitId");

            migrationBuilder.RenameColumn(
                name: "SServiceId",
                table: "SMedicines",
                newName: "ServiceId");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "SMedicines",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_SMedicines_UnitId",
                table: "SMedicines",
                newName: "IX_SMedicines_ServiceUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_SMedicines_SServiceId",
                table: "SMedicines",
                newName: "IX_SMedicines_ServiceId");

            migrationBuilder.RenameColumn(
                name: "UnitId",
                table: "SMaterials",
                newName: "ServiceUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_SMaterials_UnitId",
                table: "SMaterials",
                newName: "IX_SMaterials_ServiceUnitId");

            migrationBuilder.AddColumn<decimal>(
                name: "ImpPrice",
                table: "SMedicineTypes",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ImpVatRate",
                table: "SMedicineTypes",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "InternalPrice",
                table: "SMedicineTypes",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "NationalId",
                table: "SMedicineTypes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "NationalId",
                table: "SMedicines",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SMedicineGroupId",
                table: "SMaterialTypes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SRoomTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Kho ngoại trú");

            migrationBuilder.UpdateData(
                table: "SRoomTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Kho nội trú");

            migrationBuilder.UpdateData(
                table: "SRoomTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "Name" },
                values: new object[] { "TT", "Tủ trực" });

            migrationBuilder.UpdateData(
                table: "SRoomTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "Name" },
                values: new object[] { "QLT", "Quản lý thuốc" });

            migrationBuilder.UpdateData(
                table: "SRoomTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "Name" },
                values: new object[] { "QLVT", "Quản lý vật tư" });

            migrationBuilder.CreateIndex(
                name: "IX_SMaterialTypes_SMedicineGroupId",
                table: "SMaterialTypes",
                column: "SMedicineGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_SMaterials_SServiceUnits_ServiceUnitId",
                table: "SMaterials",
                column: "ServiceUnitId",
                principalTable: "SServiceUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SMaterialTypes_SMedicineGroups_SMedicineGroupId",
                table: "SMaterialTypes",
                column: "SMedicineGroupId",
                principalTable: "SMedicineGroups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SMedicines_SServiceUnits_ServiceUnitId",
                table: "SMedicines",
                column: "ServiceUnitId",
                principalTable: "SServiceUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SMedicines_SServices_ServiceId",
                table: "SMedicines",
                column: "ServiceId",
                principalTable: "SServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SMedicineTypes_SServiceUnits_ServiceUnitId",
                table: "SMedicineTypes",
                column: "ServiceUnitId",
                principalTable: "SServiceUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SMedicineTypes_SServices_ServiceId",
                table: "SMedicineTypes",
                column: "ServiceId",
                principalTable: "SServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SServices_SServiceUnits_ServiceUnitId",
                table: "SServices",
                column: "ServiceUnitId",
                principalTable: "SServiceUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
