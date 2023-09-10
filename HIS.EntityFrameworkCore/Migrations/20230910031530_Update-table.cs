using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Updatetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientRecords_Branchs_BranchID",
                table: "PatientRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientRecords_Careers_CareerID",
                table: "PatientRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientRecords_Countries_CountryID",
                table: "PatientRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientRecords_Districts_DistrictID",
                table: "PatientRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientRecords_Ethnics_EthnicityID",
                table: "PatientRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientRecords_Genders_GenderID",
                table: "PatientRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientRecords_Patients_PatientID",
                table: "PatientRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientRecords_Provinces_ProvinceID",
                table: "PatientRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientRecords_Wards_WardID",
                table: "PatientRecords");

            migrationBuilder.DropIndex(
                name: "IX_PatientRecords_BranchID",
                table: "PatientRecords");

            migrationBuilder.DropIndex(
                name: "IX_PatientRecords_CareerID",
                table: "PatientRecords");

            migrationBuilder.DropIndex(
                name: "IX_PatientRecords_CountryID",
                table: "PatientRecords");

            migrationBuilder.DropIndex(
                name: "IX_PatientRecords_DistrictID",
                table: "PatientRecords");

            migrationBuilder.DropIndex(
                name: "IX_PatientRecords_EthnicityID",
                table: "PatientRecords");

            migrationBuilder.DropIndex(
                name: "IX_PatientRecords_GenderID",
                table: "PatientRecords");

            migrationBuilder.DropIndex(
                name: "IX_PatientRecords_PatientID",
                table: "PatientRecords");

            migrationBuilder.DropIndex(
                name: "IX_PatientRecords_ProvinceID",
                table: "PatientRecords");

            migrationBuilder.DropIndex(
                name: "IX_PatientRecords_WardID",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "CountryCode",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "CountryName",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "DistrictCode",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "DistrictName",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "EndDepartmentID",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "EndRoomID",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "Fax",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "HospitalizationReason",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "Inactive",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "IsEmergency",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "PatientRecordStatusID",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "PatientRecordTypeID",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "ProvinceCode",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "ProvinceID",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "ProvinceName",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "StartDepartmentID",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "Tel",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "WardCode",
                table: "PatientRecords");

            migrationBuilder.DropColumn(
                name: "WardName",
                table: "PatientRecords");

            migrationBuilder.RenameColumn(
                name: "BloodTypeID",
                table: "Patients",
                newName: "BloodTypeId");

            migrationBuilder.RenameColumn(
                name: "BloodRhID",
                table: "Patients",
                newName: "BloodRhId");

            migrationBuilder.RenameColumn(
                name: "WardID",
                table: "PatientRecords",
                newName: "WardId");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "PatientRecords",
                newName: "PatientId");

            migrationBuilder.RenameColumn(
                name: "GenderID",
                table: "PatientRecords",
                newName: "GenderId");

            migrationBuilder.RenameColumn(
                name: "EthnicityID",
                table: "PatientRecords",
                newName: "EthnicityId");

            migrationBuilder.RenameColumn(
                name: "DistrictID",
                table: "PatientRecords",
                newName: "DistrictId");

            migrationBuilder.RenameColumn(
                name: "CountryID",
                table: "PatientRecords",
                newName: "CountryId");

            migrationBuilder.RenameColumn(
                name: "CareerID",
                table: "PatientRecords",
                newName: "CareerId");

            migrationBuilder.RenameColumn(
                name: "StartRoomID",
                table: "PatientRecords",
                newName: "ProvinceOrCityId");

            migrationBuilder.RenameColumn(
                name: "ReceiptionRoomID",
                table: "PatientRecords",
                newName: "ReceptionUserId");

            migrationBuilder.RenameColumn(
                name: "ReceiptionDepartmentID",
                table: "PatientRecords",
                newName: "ReceptionRoomId");

            migrationBuilder.RenameColumn(
                name: "ReceiptionDate",
                table: "PatientRecords",
                newName: "ReceptionDate");

            migrationBuilder.RenameColumn(
                name: "PatientTypeID",
                table: "PatientRecords",
                newName: "ReceptionTypeId");

            migrationBuilder.RenameColumn(
                name: "BranchID",
                table: "PatientRecords",
                newName: "ReceptionDepartmentId");

            migrationBuilder.AlterColumn<string>(
                name: "Workplace",
                table: "PatientRecords",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PatientName",
                table: "PatientRecords",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "IssueBy",
                table: "PatientRecords",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdentificationNumber",
                table: "PatientRecords",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "PatientRecords",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "BirthPlace",
                table: "PatientRecords",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "PatientRecords",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Insurance",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MediOrgCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MediOrgName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LevelCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LiveAreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasBirthCertificate = table.Column<bool>(type: "bit", nullable: false),
                    FreeCoPaidDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Join5YearDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceptionType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceptionType", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "DeathCauses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "DeathCauses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "DeathCauses",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "DeathWithins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "DeathWithins",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "DeathWithins",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "DeathWithins",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "PatientRecordTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "PatientRecordTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "PatientRecordTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "PatientTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "PatientTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "PatientTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.InsertData(
                table: "ReceptionType",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "KB", null, new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5732), null, false, null, null, "Khám bệnh", 1 },
                    { 2, "CC", null, new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5735), null, false, null, null, "Cấp cứu", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Insurance");

            migrationBuilder.DropTable(
                name: "ReceptionType");

            migrationBuilder.RenameColumn(
                name: "BloodTypeId",
                table: "Patients",
                newName: "BloodTypeID");

            migrationBuilder.RenameColumn(
                name: "BloodRhId",
                table: "Patients",
                newName: "BloodRhID");

            migrationBuilder.RenameColumn(
                name: "WardId",
                table: "PatientRecords",
                newName: "WardID");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "PatientRecords",
                newName: "PatientID");

            migrationBuilder.RenameColumn(
                name: "GenderId",
                table: "PatientRecords",
                newName: "GenderID");

            migrationBuilder.RenameColumn(
                name: "EthnicityId",
                table: "PatientRecords",
                newName: "EthnicityID");

            migrationBuilder.RenameColumn(
                name: "DistrictId",
                table: "PatientRecords",
                newName: "DistrictID");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "PatientRecords",
                newName: "CountryID");

            migrationBuilder.RenameColumn(
                name: "CareerId",
                table: "PatientRecords",
                newName: "CareerID");

            migrationBuilder.RenameColumn(
                name: "ReceptionUserId",
                table: "PatientRecords",
                newName: "ReceiptionRoomID");

            migrationBuilder.RenameColumn(
                name: "ReceptionTypeId",
                table: "PatientRecords",
                newName: "PatientTypeID");

            migrationBuilder.RenameColumn(
                name: "ReceptionRoomId",
                table: "PatientRecords",
                newName: "ReceiptionDepartmentID");

            migrationBuilder.RenameColumn(
                name: "ReceptionDepartmentId",
                table: "PatientRecords",
                newName: "BranchID");

            migrationBuilder.RenameColumn(
                name: "ReceptionDate",
                table: "PatientRecords",
                newName: "ReceiptionDate");

            migrationBuilder.RenameColumn(
                name: "ProvinceOrCityId",
                table: "PatientRecords",
                newName: "StartRoomID");

            migrationBuilder.AlterColumn<string>(
                name: "Workplace",
                table: "PatientRecords",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PatientName",
                table: "PatientRecords",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IssueBy",
                table: "PatientRecords",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdentificationNumber",
                table: "PatientRecords",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "PatientRecords",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BirthPlace",
                table: "PatientRecords",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "PatientRecords",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CountryCode",
                table: "PatientRecords",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CountryName",
                table: "PatientRecords",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PatientRecords",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DistrictCode",
                table: "PatientRecords",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DistrictName",
                table: "PatientRecords",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "PatientRecords",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "PatientRecords",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EndDepartmentID",
                table: "PatientRecords",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EndRoomID",
                table: "PatientRecords",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fax",
                table: "PatientRecords",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HospitalizationReason",
                table: "PatientRecords",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Inactive",
                table: "PatientRecords",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEmergency",
                table: "PatientRecords",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "PatientRecords",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientRecordStatusID",
                table: "PatientRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PatientRecordTypeID",
                table: "PatientRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProvinceCode",
                table: "PatientRecords",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProvinceID",
                table: "PatientRecords",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProvinceName",
                table: "PatientRecords",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "PatientRecords",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StartDepartmentID",
                table: "PatientRecords",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tel",
                table: "PatientRecords",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WardCode",
                table: "PatientRecords",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WardName",
                table: "PatientRecords",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DeathCauses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 166, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "DeathCauses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 166, DateTimeKind.Local).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "DeathCauses",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 166, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "DeathWithins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 166, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "DeathWithins",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 166, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "DeathWithins",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 166, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "DeathWithins",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 166, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "PatientRecordTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "PatientRecordTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "PatientRecordTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "PatientTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "PatientTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "PatientTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 5, 23, 16, 1, 167, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_BranchID",
                table: "PatientRecords",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_CareerID",
                table: "PatientRecords",
                column: "CareerID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_CountryID",
                table: "PatientRecords",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_DistrictID",
                table: "PatientRecords",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_EthnicityID",
                table: "PatientRecords",
                column: "EthnicityID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_GenderID",
                table: "PatientRecords",
                column: "GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_PatientID",
                table: "PatientRecords",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_ProvinceID",
                table: "PatientRecords",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_WardID",
                table: "PatientRecords",
                column: "WardID");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientRecords_Branchs_BranchID",
                table: "PatientRecords",
                column: "BranchID",
                principalTable: "Branchs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientRecords_Careers_CareerID",
                table: "PatientRecords",
                column: "CareerID",
                principalTable: "Careers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientRecords_Countries_CountryID",
                table: "PatientRecords",
                column: "CountryID",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientRecords_Districts_DistrictID",
                table: "PatientRecords",
                column: "DistrictID",
                principalTable: "Districts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientRecords_Ethnics_EthnicityID",
                table: "PatientRecords",
                column: "EthnicityID",
                principalTable: "Ethnics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientRecords_Genders_GenderID",
                table: "PatientRecords",
                column: "GenderID",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientRecords_Patients_PatientID",
                table: "PatientRecords",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientRecords_Provinces_ProvinceID",
                table: "PatientRecords",
                column: "ProvinceID",
                principalTable: "Provinces",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientRecords_Wards_WardID",
                table: "PatientRecords",
                column: "WardID",
                principalTable: "Wards",
                principalColumn: "Id");
        }
    }
}
