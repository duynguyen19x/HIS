using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Init7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HISPatientRecord_SBloodRhType_BloodTypeRhId",
                table: "HISPatientRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_HISPatientRecord_SBloodType_BloodTypeId",
                table: "HISPatientRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_HISPatientRecord_SCareer_CareerId",
                table: "HISPatientRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_HISPatientRecord_SCountry_CountryId",
                table: "HISPatientRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_HISPatientRecord_SDistrict_DistrictId",
                table: "HISPatientRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_HISPatientRecord_SEthnicity_EthnicId",
                table: "HISPatientRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_HISPatientRecord_SGender_GenderId",
                table: "HISPatientRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_HISPatientRecord_SProvince_ProvinceId",
                table: "HISPatientRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_HISPatientRecord_SReligion_ReligionId",
                table: "HISPatientRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_HISPatientRecord_SWard_WardId",
                table: "HISPatientRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HISPatientRecord",
                table: "HISPatientRecord");

            migrationBuilder.RenameTable(
                name: "HISPatientRecord",
                newName: "DPatientRecord");

            migrationBuilder.RenameIndex(
                name: "IX_HISPatientRecord_WardId",
                table: "DPatientRecord",
                newName: "IX_DPatientRecord_WardId");

            migrationBuilder.RenameIndex(
                name: "IX_HISPatientRecord_ReligionId",
                table: "DPatientRecord",
                newName: "IX_DPatientRecord_ReligionId");

            migrationBuilder.RenameIndex(
                name: "IX_HISPatientRecord_ProvinceId",
                table: "DPatientRecord",
                newName: "IX_DPatientRecord_ProvinceId");

            migrationBuilder.RenameIndex(
                name: "IX_HISPatientRecord_IsDeleted",
                table: "DPatientRecord",
                newName: "IX_DPatientRecord_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_HISPatientRecord_GenderId",
                table: "DPatientRecord",
                newName: "IX_DPatientRecord_GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_HISPatientRecord_EthnicId",
                table: "DPatientRecord",
                newName: "IX_DPatientRecord_EthnicId");

            migrationBuilder.RenameIndex(
                name: "IX_HISPatientRecord_DistrictId",
                table: "DPatientRecord",
                newName: "IX_DPatientRecord_DistrictId");

            migrationBuilder.RenameIndex(
                name: "IX_HISPatientRecord_CountryId",
                table: "DPatientRecord",
                newName: "IX_DPatientRecord_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_HISPatientRecord_CareerId",
                table: "DPatientRecord",
                newName: "IX_DPatientRecord_CareerId");

            migrationBuilder.RenameIndex(
                name: "IX_HISPatientRecord_BloodTypeRhId",
                table: "DPatientRecord",
                newName: "IX_DPatientRecord_BloodTypeRhId");

            migrationBuilder.RenameIndex(
                name: "IX_HISPatientRecord_BloodTypeId",
                table: "DPatientRecord",
                newName: "IX_DPatientRecord_BloodTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "MediOrgCode",
                table: "SBranch",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DPatientRecord",
                table: "DPatientRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DPatientRecord_SBloodRhType_BloodTypeRhId",
                table: "DPatientRecord",
                column: "BloodTypeRhId",
                principalTable: "SBloodRhType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DPatientRecord_SBloodType_BloodTypeId",
                table: "DPatientRecord",
                column: "BloodTypeId",
                principalTable: "SBloodType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DPatientRecord_SCareer_CareerId",
                table: "DPatientRecord",
                column: "CareerId",
                principalTable: "SCareer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DPatientRecord_SCountry_CountryId",
                table: "DPatientRecord",
                column: "CountryId",
                principalTable: "SCountry",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DPatientRecord_SDistrict_DistrictId",
                table: "DPatientRecord",
                column: "DistrictId",
                principalTable: "SDistrict",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DPatientRecord_SEthnicity_EthnicId",
                table: "DPatientRecord",
                column: "EthnicId",
                principalTable: "SEthnicity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DPatientRecord_SGender_GenderId",
                table: "DPatientRecord",
                column: "GenderId",
                principalTable: "SGender",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DPatientRecord_SProvince_ProvinceId",
                table: "DPatientRecord",
                column: "ProvinceId",
                principalTable: "SProvince",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DPatientRecord_SReligion_ReligionId",
                table: "DPatientRecord",
                column: "ReligionId",
                principalTable: "SReligion",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DPatientRecord_SWard_WardId",
                table: "DPatientRecord",
                column: "WardId",
                principalTable: "SWard",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DPatientRecord_SBloodRhType_BloodTypeRhId",
                table: "DPatientRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DPatientRecord_SBloodType_BloodTypeId",
                table: "DPatientRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DPatientRecord_SCareer_CareerId",
                table: "DPatientRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DPatientRecord_SCountry_CountryId",
                table: "DPatientRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DPatientRecord_SDistrict_DistrictId",
                table: "DPatientRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DPatientRecord_SEthnicity_EthnicId",
                table: "DPatientRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DPatientRecord_SGender_GenderId",
                table: "DPatientRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DPatientRecord_SProvince_ProvinceId",
                table: "DPatientRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DPatientRecord_SReligion_ReligionId",
                table: "DPatientRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DPatientRecord_SWard_WardId",
                table: "DPatientRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DPatientRecord",
                table: "DPatientRecord");

            migrationBuilder.RenameTable(
                name: "DPatientRecord",
                newName: "HISPatientRecord");

            migrationBuilder.RenameIndex(
                name: "IX_DPatientRecord_WardId",
                table: "HISPatientRecord",
                newName: "IX_HISPatientRecord_WardId");

            migrationBuilder.RenameIndex(
                name: "IX_DPatientRecord_ReligionId",
                table: "HISPatientRecord",
                newName: "IX_HISPatientRecord_ReligionId");

            migrationBuilder.RenameIndex(
                name: "IX_DPatientRecord_ProvinceId",
                table: "HISPatientRecord",
                newName: "IX_HISPatientRecord_ProvinceId");

            migrationBuilder.RenameIndex(
                name: "IX_DPatientRecord_IsDeleted",
                table: "HISPatientRecord",
                newName: "IX_HISPatientRecord_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_DPatientRecord_GenderId",
                table: "HISPatientRecord",
                newName: "IX_HISPatientRecord_GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_DPatientRecord_EthnicId",
                table: "HISPatientRecord",
                newName: "IX_HISPatientRecord_EthnicId");

            migrationBuilder.RenameIndex(
                name: "IX_DPatientRecord_DistrictId",
                table: "HISPatientRecord",
                newName: "IX_HISPatientRecord_DistrictId");

            migrationBuilder.RenameIndex(
                name: "IX_DPatientRecord_CountryId",
                table: "HISPatientRecord",
                newName: "IX_HISPatientRecord_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_DPatientRecord_CareerId",
                table: "HISPatientRecord",
                newName: "IX_HISPatientRecord_CareerId");

            migrationBuilder.RenameIndex(
                name: "IX_DPatientRecord_BloodTypeRhId",
                table: "HISPatientRecord",
                newName: "IX_HISPatientRecord_BloodTypeRhId");

            migrationBuilder.RenameIndex(
                name: "IX_DPatientRecord_BloodTypeId",
                table: "HISPatientRecord",
                newName: "IX_HISPatientRecord_BloodTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "MediOrgCode",
                table: "SBranch",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HISPatientRecord",
                table: "HISPatientRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HISPatientRecord_SBloodRhType_BloodTypeRhId",
                table: "HISPatientRecord",
                column: "BloodTypeRhId",
                principalTable: "SBloodRhType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HISPatientRecord_SBloodType_BloodTypeId",
                table: "HISPatientRecord",
                column: "BloodTypeId",
                principalTable: "SBloodType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HISPatientRecord_SCareer_CareerId",
                table: "HISPatientRecord",
                column: "CareerId",
                principalTable: "SCareer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HISPatientRecord_SCountry_CountryId",
                table: "HISPatientRecord",
                column: "CountryId",
                principalTable: "SCountry",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HISPatientRecord_SDistrict_DistrictId",
                table: "HISPatientRecord",
                column: "DistrictId",
                principalTable: "SDistrict",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HISPatientRecord_SEthnicity_EthnicId",
                table: "HISPatientRecord",
                column: "EthnicId",
                principalTable: "SEthnicity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HISPatientRecord_SGender_GenderId",
                table: "HISPatientRecord",
                column: "GenderId",
                principalTable: "SGender",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HISPatientRecord_SProvince_ProvinceId",
                table: "HISPatientRecord",
                column: "ProvinceId",
                principalTable: "SProvince",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HISPatientRecord_SReligion_ReligionId",
                table: "HISPatientRecord",
                column: "ReligionId",
                principalTable: "SReligion",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HISPatientRecord_SWard_WardId",
                table: "HISPatientRecord",
                column: "WardId",
                principalTable: "SWard",
                principalColumn: "Id");
        }
    }
}
