using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class AddSNationalSProvinceSDistrictSCommune : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SNationals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsAcctive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SNationals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SProvinces",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NationalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsAcctive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SProvinces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SProvinces_SNationals_NationalId",
                        column: x => x.NationalId,
                        principalTable: "SNationals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SDistricts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NationalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsAcctive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SDistricts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SDistricts_SNationals_NationalId",
                        column: x => x.NationalId,
                        principalTable: "SNationals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SDistricts_SProvinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "SProvinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SCommunes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NationalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsAcctive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCommunes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SCommunes_SDistricts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "SDistricts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SCommunes_SNationals_NationalId",
                        column: x => x.NationalId,
                        principalTable: "SNationals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SCommunes_SProvinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "SProvinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_SDistricts_NationalId",
                table: "SDistricts",
                column: "NationalId");

            migrationBuilder.CreateIndex(
                name: "IX_SDistricts_ProvinceId",
                table: "SDistricts",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_SProvinces_NationalId",
                table: "SProvinces",
                column: "NationalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SCommunes");

            migrationBuilder.DropTable(
                name: "SDistricts");

            migrationBuilder.DropTable(
                name: "SProvinces");

            migrationBuilder.DropTable(
                name: "SNationals");
        }
    }
}
