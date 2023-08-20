using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePatientAndPatientRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DImpMests_SPatients_PatientId",
                table: "DImpMests");

            migrationBuilder.DropForeignKey(
                name: "FK_DImpMests_STreatments_TreatmentId",
                table: "DImpMests");

            migrationBuilder.DropTable(
                name: "SPatients");

            migrationBuilder.DropTable(
                name: "STreatments");

            migrationBuilder.RenameColumn(
                name: "TreatmentId",
                table: "DImpMests",
                newName: "PatientRecordId");

            migrationBuilder.RenameIndex(
                name: "IX_DImpMests_TreatmentId",
                table: "DImpMests",
                newName: "IX_DImpMests_PatientRecordId");

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sYSRefTypeCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sYSRefTypeCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientRecord",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BirthYear = table.Column<int>(type: "int", nullable: false),
                    BirthPlace = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IssueBy = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EthnicityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CareerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PatientTypeId = table.Column<int>(type: "int", nullable: false),
                    PatientRecordTypeId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientRecord_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientRecord_SCareers_CareerId",
                        column: x => x.CareerId,
                        principalTable: "SCareers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientRecord_SCountries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "SCountries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientRecord_SDistricts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "SDistricts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PatientRecord_SEthnics_EthnicityId",
                        column: x => x.EthnicityId,
                        principalTable: "SEthnics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientRecord_SGenders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "SGenders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientRecord_SProvinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "SProvinces",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PatientRecord_SWards_WardId",
                        column: x => x.WardId,
                        principalTable: "SWards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SYSAutoNumbers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Prefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LengthOfValue = table.Column<int>(type: "int", nullable: false),
                    Suffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefTypeCategoryId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYSAutoNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SYSAutoNumbers_SBranchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "SBranchs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SYSAutoNumbers_sYSRefTypeCategories_RefTypeCategoryId",
                        column: x => x.RefTypeCategoryId,
                        principalTable: "sYSRefTypeCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SYSRefTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    RefTypeCategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYSRefTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SYSRefTypes_sYSRefTypeCategories_RefTypeCategoryId",
                        column: x => x.RefTypeCategoryId,
                        principalTable: "sYSRefTypeCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "SGenders",
                keyColumn: "Id",
                keyValue: new Guid("97ac7fd8-edfa-4243-97fc-98468f492df1"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 15, 10, 41, 874, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "SGenders",
                keyColumn: "Id",
                keyValue: new Guid("e9497984-d355-41af-b917-091500956be9"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 15, 10, 41, 874, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "SGenders",
                keyColumn: "Id",
                keyValue: new Guid("fc153433-bf89-4e95-8523-df3d8cec8676"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 15, 10, 41, 874, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 15, 10, 41, 874, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 15, 10, 41, 874, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 15, 10, 41, 874, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecord_CareerId",
                table: "PatientRecord",
                column: "CareerId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecord_CountryId",
                table: "PatientRecord",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecord_DistrictId",
                table: "PatientRecord",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecord_EthnicityId",
                table: "PatientRecord",
                column: "EthnicityId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecord_GenderId",
                table: "PatientRecord",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecord_PatientId",
                table: "PatientRecord",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecord_ProvinceId",
                table: "PatientRecord",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecord_WardId",
                table: "PatientRecord",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_SYSAutoNumbers_BranchId",
                table: "SYSAutoNumbers",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_SYSAutoNumbers_RefTypeCategoryId",
                table: "SYSAutoNumbers",
                column: "RefTypeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SYSRefTypes_RefTypeCategoryId",
                table: "SYSRefTypes",
                column: "RefTypeCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_DImpMests_PatientRecord_PatientRecordId",
                table: "DImpMests",
                column: "PatientRecordId",
                principalTable: "PatientRecord",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DImpMests_Patient_PatientId",
                table: "DImpMests",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DImpMests_PatientRecord_PatientRecordId",
                table: "DImpMests");

            migrationBuilder.DropForeignKey(
                name: "FK_DImpMests_Patient_PatientId",
                table: "DImpMests");

            migrationBuilder.DropTable(
                name: "PatientRecord");

            migrationBuilder.DropTable(
                name: "SYSAutoNumbers");

            migrationBuilder.DropTable(
                name: "SYSRefTypes");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "sYSRefTypeCategories");

            migrationBuilder.RenameColumn(
                name: "PatientRecordId",
                table: "DImpMests",
                newName: "TreatmentId");

            migrationBuilder.RenameIndex(
                name: "IX_DImpMests_PatientRecordId",
                table: "DImpMests",
                newName: "IX_DImpMests_TreatmentId");

            migrationBuilder.CreateTable(
                name: "SPatients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BirthYear = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPatients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SPatients_SGenders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "SGenders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "STreatments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    CareerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EthnicId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InTimeClinical = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OutTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STreatments", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "SGenders",
                keyColumn: "Id",
                keyValue: new Guid("97ac7fd8-edfa-4243-97fc-98468f492df1"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 16, 23, 5, 6, 995, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "SGenders",
                keyColumn: "Id",
                keyValue: new Guid("e9497984-d355-41af-b917-091500956be9"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 16, 23, 5, 6, 995, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "SGenders",
                keyColumn: "Id",
                keyValue: new Guid("fc153433-bf89-4e95-8523-df3d8cec8676"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 16, 23, 5, 6, 995, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 16, 23, 5, 6, 995, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 16, 23, 5, 6, 995, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "SPatientTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 16, 23, 5, 6, 995, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.CreateIndex(
                name: "IX_SPatients_GenderId",
                table: "SPatients",
                column: "GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_DImpMests_SPatients_PatientId",
                table: "DImpMests",
                column: "PatientId",
                principalTable: "SPatients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DImpMests_STreatments_TreatmentId",
                table: "DImpMests",
                column: "TreatmentId",
                principalTable: "STreatments",
                principalColumn: "Id");
        }
    }
}
