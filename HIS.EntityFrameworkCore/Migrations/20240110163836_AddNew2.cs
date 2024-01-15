using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class AddNew2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BUS_Patient_DIC_Country_NationalId",
                table: "BUS_Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_SYSRefType_SYSRefTypeCategory_SYSRefTypeCategoryId",
                table: "SYSRefType");

            migrationBuilder.DropIndex(
                name: "IX_SYSRefType_SYSRefTypeCategoryId",
                table: "SYSRefType");

            migrationBuilder.DropColumn(
                name: "SYSRefTypeCategoryId",
                table: "SYSRefType");

            migrationBuilder.RenameColumn(
                name: "NationalId",
                table: "BUS_Patient",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_BUS_Patient_NationalId",
                table: "BUS_Patient",
                newName: "IX_BUS_Patient_CountryId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "BUS_Patient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DIC_DeathCause",
                keyColumn: "Id",
                keyValue: new Guid("4333ca55-4d7c-4be0-b9a2-2125624f0229"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 112, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "DIC_DeathCause",
                keyColumn: "Id",
                keyValue: new Guid("4d5b5c50-6be0-434e-8baa-a528af4a58b5"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 112, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "DIC_DeathCause",
                keyColumn: "Id",
                keyValue: new Guid("c0a4d767-7ba9-4006-a0a9-020b6322c2ef"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 112, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "DIC_DeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("66c3a43b-f9d0-4876-81e2-b13c5f188589"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 113, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "DIC_DeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("7693d6ec-cf0f-44c1-a9d7-fb997335ae10"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 113, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "DIC_DeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("8f2b1eeb-a4bd-4f84-b59c-98145c58b1ab"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 113, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "DIC_DeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("f91d8342-619c-435b-b51c-8b3d7f541222"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 113, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordTypeGroup",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordTypeGroup",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordTypeGroup",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 116, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "DIC_PatientRecordType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 117, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "DIC_PatientRecordType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 117, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "DIC_PatientRecordType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 117, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "DIC_PatientType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 117, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "DIC_PatientType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 117, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "DIC_PatientType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 117, DateTimeKind.Local).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "DIC_PatientType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 117, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "DIC_PatientType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 117, DateTimeKind.Local).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "DIC_PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("0b348363-c888-4c9a-b145-c3389fdcca37"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 117, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "DIC_PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("8bff9824-1df2-419e-88ab-e098a6fc4e7e"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 117, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "DIC_PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("dd39afc0-1de0-4287-a126-4dada6788508"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 117, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "DIC_ReceptionObjectType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 118, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "DIC_ReceptionObjectType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 23, 38, 35, 118, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.CreateIndex(
                name: "IX_SYSRefType_RefTypeCategoryID",
                table: "SYSRefType",
                column: "RefTypeCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_BUS_Patient_DIC_Country_CountryId",
                table: "BUS_Patient",
                column: "CountryId",
                principalTable: "DIC_Country",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SYSRefType_SYSRefTypeCategory_RefTypeCategoryID",
                table: "SYSRefType",
                column: "RefTypeCategoryID",
                principalTable: "SYSRefTypeCategory",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BUS_Patient_DIC_Country_CountryId",
                table: "BUS_Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_SYSRefType_SYSRefTypeCategory_RefTypeCategoryID",
                table: "SYSRefType");

            migrationBuilder.DropIndex(
                name: "IX_SYSRefType_RefTypeCategoryID",
                table: "SYSRefType");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "BUS_Patient");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "BUS_Patient",
                newName: "NationalId");

            migrationBuilder.RenameIndex(
                name: "IX_BUS_Patient_CountryId",
                table: "BUS_Patient",
                newName: "IX_BUS_Patient_NationalId");

            migrationBuilder.AddColumn<int>(
                name: "SYSRefTypeCategoryId",
                table: "SYSRefType",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DIC_DeathCause",
                keyColumn: "Id",
                keyValue: new Guid("4333ca55-4d7c-4be0-b9a2-2125624f0229"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 843, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "DIC_DeathCause",
                keyColumn: "Id",
                keyValue: new Guid("4d5b5c50-6be0-434e-8baa-a528af4a58b5"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 843, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "DIC_DeathCause",
                keyColumn: "Id",
                keyValue: new Guid("c0a4d767-7ba9-4006-a0a9-020b6322c2ef"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 843, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "DIC_DeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("66c3a43b-f9d0-4876-81e2-b13c5f188589"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 844, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "DIC_DeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("7693d6ec-cf0f-44c1-a9d7-fb997335ae10"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 844, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "DIC_DeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("8f2b1eeb-a4bd-4f84-b59c-98145c58b1ab"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 844, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "DIC_DeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("f91d8342-619c-435b-b51c-8b3d7f541222"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 844, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordTypeGroup",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordTypeGroup",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordTypeGroup",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "DIC_PatientRecordType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 848, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "DIC_PatientRecordType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 848, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "DIC_PatientRecordType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 848, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "DIC_PatientType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 848, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "DIC_PatientType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 848, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "DIC_PatientType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 848, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "DIC_PatientType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 848, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "DIC_PatientType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 848, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "DIC_PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("0b348363-c888-4c9a-b145-c3389fdcca37"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 848, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "DIC_PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("8bff9824-1df2-419e-88ab-e098a6fc4e7e"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 848, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "DIC_PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("dd39afc0-1de0-4287-a126-4dada6788508"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 848, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "DIC_ReceptionObjectType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 849, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "DIC_ReceptionObjectType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 849, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "SYSRefType",
                keyColumn: "Id",
                keyValue: 101,
                column: "SYSRefTypeCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SYSRefType",
                keyColumn: "Id",
                keyValue: 102,
                column: "SYSRefTypeCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SYSRefType",
                keyColumn: "Id",
                keyValue: 103,
                column: "SYSRefTypeCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SYSRefType",
                keyColumn: "Id",
                keyValue: 104,
                column: "SYSRefTypeCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SYSRefType",
                keyColumn: "Id",
                keyValue: 199,
                column: "SYSRefTypeCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SYSRefType",
                keyColumn: "Id",
                keyValue: 201,
                column: "SYSRefTypeCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SYSRefType",
                keyColumn: "Id",
                keyValue: 202,
                column: "SYSRefTypeCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SYSRefType",
                keyColumn: "Id",
                keyValue: 203,
                column: "SYSRefTypeCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SYSRefType",
                keyColumn: "Id",
                keyValue: 204,
                column: "SYSRefTypeCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SYSRefType",
                keyColumn: "Id",
                keyValue: 205,
                column: "SYSRefTypeCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SYSRefType",
                keyColumn: "Id",
                keyValue: 206,
                column: "SYSRefTypeCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SYSRefType",
                keyColumn: "Id",
                keyValue: 207,
                column: "SYSRefTypeCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SYSRefType",
                keyColumn: "Id",
                keyValue: 208,
                column: "SYSRefTypeCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SYSRefType",
                keyColumn: "Id",
                keyValue: 209,
                column: "SYSRefTypeCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SYSRefType",
                keyColumn: "Id",
                keyValue: 210,
                column: "SYSRefTypeCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SYSRefType",
                keyColumn: "Id",
                keyValue: 211,
                column: "SYSRefTypeCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SYSRefType",
                keyColumn: "Id",
                keyValue: 212,
                column: "SYSRefTypeCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SYSRefType",
                keyColumn: "Id",
                keyValue: 301,
                column: "SYSRefTypeCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SYSRefType",
                keyColumn: "Id",
                keyValue: 401,
                column: "SYSRefTypeCategoryId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_SYSRefType_SYSRefTypeCategoryId",
                table: "SYSRefType",
                column: "SYSRefTypeCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BUS_Patient_DIC_Country_NationalId",
                table: "BUS_Patient",
                column: "NationalId",
                principalTable: "DIC_Country",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SYSRefType_SYSRefTypeCategory_SYSRefTypeCategoryId",
                table: "SYSRefType",
                column: "SYSRefTypeCategoryId",
                principalTable: "SYSRefTypeCategory",
                principalColumn: "Id");
        }
    }
}
