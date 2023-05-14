using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Update_table_location : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SDistricts_SNationals_NationalId",
                table: "SDistricts");

            migrationBuilder.DropForeignKey(
                name: "FK_SDistricts_SProvinces_ProvinceId",
                table: "SDistricts");

            migrationBuilder.DropForeignKey(
                name: "FK_SProvinces_SNationals_NationalId",
                table: "SProvinces");

            migrationBuilder.DropTable(
                name: "SCommunes");

            migrationBuilder.DropTable(
                name: "SNationals");

            migrationBuilder.DropIndex(
                name: "IX_SProvinces_NationalId",
                table: "SProvinces");

            migrationBuilder.DropIndex(
                name: "IX_SDistricts_NationalId",
                table: "SDistricts");

            migrationBuilder.RenameColumn(
                name: "NationalId",
                table: "SProvinces",
                newName: "ModifiedBy");

            migrationBuilder.RenameColumn(
                name: "IsAcctive",
                table: "SProvinces",
                newName: "Inactive");

            migrationBuilder.RenameColumn(
                name: "NationalId",
                table: "SDistricts",
                newName: "ModifiedBy");

            migrationBuilder.RenameColumn(
                name: "IsAcctive",
                table: "SDistricts",
                newName: "Inactive");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SProvinces",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "SProvinces",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "SProvinces",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "SProvinces",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "SProvinces",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "SProvinces",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "SProvinces",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SProvinces",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "SProvinces",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ProvinceId",
                table: "SDistricts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SDistricts",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "SDistricts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "SDistricts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "SDistricts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "SDistricts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "SDistricts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SDistricts",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "SDistricts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SCountries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCountries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SWards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SWards_SDistricts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "SDistricts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SProvinces_CountryId",
                table: "SProvinces",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_SWards_DistrictId",
                table: "SWards",
                column: "DistrictId");

            migrationBuilder.AddForeignKey(
                name: "FK_SDistricts_SProvinces_ProvinceId",
                table: "SDistricts",
                column: "ProvinceId",
                principalTable: "SProvinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SProvinces_SCountries_CountryId",
                table: "SProvinces",
                column: "CountryId",
                principalTable: "SCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SDistricts_SProvinces_ProvinceId",
                table: "SDistricts");

            migrationBuilder.DropForeignKey(
                name: "FK_SProvinces_SCountries_CountryId",
                table: "SProvinces");

            migrationBuilder.DropTable(
                name: "SCountries");

            migrationBuilder.DropTable(
                name: "SWards");

            migrationBuilder.DropIndex(
                name: "IX_SProvinces_CountryId",
                table: "SProvinces");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "SProvinces");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SProvinces");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "SProvinces");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "SProvinces");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "SProvinces");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "SProvinces");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "SProvinces");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SDistricts");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "SDistricts");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "SDistricts");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "SDistricts");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "SDistricts");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "SDistricts");

            migrationBuilder.RenameColumn(
                name: "ModifiedBy",
                table: "SProvinces",
                newName: "NationalId");

            migrationBuilder.RenameColumn(
                name: "Inactive",
                table: "SProvinces",
                newName: "IsAcctive");

            migrationBuilder.RenameColumn(
                name: "ModifiedBy",
                table: "SDistricts",
                newName: "NationalId");

            migrationBuilder.RenameColumn(
                name: "Inactive",
                table: "SDistricts",
                newName: "IsAcctive");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SProvinces",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "SProvinces",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<Guid>(
                name: "ProvinceId",
                table: "SDistricts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SDistricts",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "SDistricts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateTable(
                name: "SNationals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsAcctive = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SNationals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SCommunes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NationalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsAcctive = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCommunes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SCommunes_SDistricts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "SDistricts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SCommunes_SNationals_NationalId",
                        column: x => x.NationalId,
                        principalTable: "SNationals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SCommunes_SProvinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "SProvinces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SProvinces_NationalId",
                table: "SProvinces",
                column: "NationalId");

            migrationBuilder.CreateIndex(
                name: "IX_SDistricts_NationalId",
                table: "SDistricts",
                column: "NationalId");

            migrationBuilder.CreateIndex(
                name: "IX_SCommunes_DistrictId",
                table: "SCommunes",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_SCommunes_NationalId",
                table: "SCommunes",
                column: "NationalId");

            migrationBuilder.CreateIndex(
                name: "IX_SCommunes_ProvinceId",
                table: "SCommunes",
                column: "ProvinceId");

            migrationBuilder.AddForeignKey(
                name: "FK_SDistricts_SNationals_NationalId",
                table: "SDistricts",
                column: "NationalId",
                principalTable: "SNationals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SDistricts_SProvinces_ProvinceId",
                table: "SDistricts",
                column: "ProvinceId",
                principalTable: "SProvinces",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SProvinces_SNationals_NationalId",
                table: "SProvinces",
                column: "NationalId",
                principalTable: "SNationals",
                principalColumn: "Id");
        }
    }
}
