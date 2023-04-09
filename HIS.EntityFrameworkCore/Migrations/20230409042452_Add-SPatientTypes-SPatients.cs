using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class AddSPatientTypesSPatients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SPatientTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPatientTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SPatients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PatientTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NationalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CommuneId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    JobId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranhId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CitizenIdNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CitizenIdIssuedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CitizenIdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HeinCardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TaxCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PatientFather = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    FatherEducationalLevel = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    PatientMother = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    MotherEducationalLevel = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Join5Year = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PassPortNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PassPortDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PassPortIssuedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPatients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SPatients_SGenders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "SGenders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SPatients_SPatientTypes_PatientTypeId",
                        column: x => x.PatientTypeId,
                        principalTable: "SPatientTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SPatients_GenderId",
                table: "SPatients",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_SPatients_PatientTypeId",
                table: "SPatients",
                column: "PatientTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SPatients");

            migrationBuilder.DropTable(
                name: "SPatientTypes");
        }
    }
}
