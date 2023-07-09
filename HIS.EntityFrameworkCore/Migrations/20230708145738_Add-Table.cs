using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class AddTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SBranchs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SBranchs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SCareers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCareers", x => x.Id);
                });

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
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCountries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SDepartmentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SDepartmentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SEthnics",
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
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEthnics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SGenders",
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
                    table.PrimaryKey("PK_SGenders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SHospitals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MohCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Grade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Line = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SHospitals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SIcds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MohReportCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    NameEnglish = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    NameCommon = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ChapterCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ChapterName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ChapterNameEnglish = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    MainGroupCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MainGroupName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    MainGroupNameEnglish = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SubGroup1Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubGroup1Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SubGroup1NameEnglish = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SubGroup2Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubGroup2Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SubGroup2NameEnglish = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    TypeCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TypeName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    TypeNameEnglish = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIcds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SMedicineGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SoftOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMedicineGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SMedicineLines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SoftOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMedicineLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SPatientTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPatientTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SPermissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPermissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    IsSystem = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SRoomTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SRoomTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SServiceGroupHeIns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SServiceGroupHeIns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SServiceGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SServiceGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SServiceUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SServiceUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SSurgicalProcedureTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSurgicalProcedureTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "STreatments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    InTimeClinical = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OutTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CareerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EthnicId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STreatments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(1020)", maxLength: 1020, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UseType = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SProvinces",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SProvinces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SProvinces_SCountries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "SCountries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SDepartments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MohCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DepartmentTypeId = table.Column<int>(type: "int", nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SDepartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SDepartments_SBranchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "SBranchs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SDepartments_SDepartmentTypes_DepartmentTypeId",
                        column: x => x.DepartmentTypeId,
                        principalTable: "SDepartmentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    EthnicId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CareerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranhId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdentificationNumberIssuedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IdentificationNumberIssuedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RelativeName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    RelativeAddress = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    RelativeIdentificationNumber = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    RelativePhoneNumbar = table.Column<string>(type: "nvarchar(56)", maxLength: 56, nullable: true),
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
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "SRolePermissionBranchs",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SRolePermissionBranchs", x => new { x.RoleId, x.PermissionId });
                    table.ForeignKey(
                        name: "FK_SRolePermissionBranchs_SBranchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "SBranchs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SRolePermissionBranchs_SPermissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "SPermissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SRolePermissionBranchs_SRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "SRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SServices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HeInCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    HeInName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    ServiceTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceGroupHeInId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SurgicalProcedureTypeId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SServices_SServiceGroupHeIns_ServiceGroupHeInId",
                        column: x => x.ServiceGroupHeInId,
                        principalTable: "SServiceGroupHeIns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SServices_SServiceGroups_ServiceGroupId",
                        column: x => x.ServiceGroupId,
                        principalTable: "SServiceGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SServices_SServiceUnits_ServiceUnitId",
                        column: x => x.ServiceUnitId,
                        principalTable: "SServiceUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SServices_SSurgicalProcedureTypes_SurgicalProcedureTypeId",
                        column: x => x.SurgicalProcedureTypeId,
                        principalTable: "SSurgicalProcedureTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "STokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TokenValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jti = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    IsRevoked = table.Column<bool>(type: "bit", nullable: false),
                    IssueAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiredAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_STokens_SUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "SUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_SUserRoles_SRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "SRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SUserRoles_SUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "SUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SDistricts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SDistricts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SDistricts_SProvinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "SProvinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SRooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MohCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    RoomTypeId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_SRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SRooms_SDepartments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "SDepartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SRooms_SRoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "SRoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SMaterialTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoftOrder = table.Column<int>(type: "int", nullable: true),
                    ServiceUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Tutorial = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NationalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImpPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImpVatRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InternalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    SMedicineGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMaterialTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SMaterialTypes_SMedicineGroups_SMedicineGroupId",
                        column: x => x.SMedicineGroupId,
                        principalTable: "SMedicineGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SMaterialTypes_SServiceUnits_ServiceUnitId",
                        column: x => x.ServiceUnitId,
                        principalTable: "SServiceUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SMaterialTypes_SServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SMedicineTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoftOrder = table.Column<int>(type: "int", nullable: true),
                    MedicineLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MedicineGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Tutorial = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NationalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImpPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImpVatRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InternalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMedicineTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SMedicineTypes_SMedicineLines_MedicineLineId",
                        column: x => x.MedicineLineId,
                        principalTable: "SMedicineLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SMedicineTypes_SServiceUnits_ServiceUnitId",
                        column: x => x.ServiceUnitId,
                        principalTable: "SServiceUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SMedicineTypes_SServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SServicePricePolicies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PatientTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OldUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NewUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CeilingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ExecutionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SServicePricePolicies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SServicePricePolicies_SPatientTypes_PatientTypeId",
                        column: x => x.PatientTypeId,
                        principalTable: "SPatientTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SServicePricePolicies_SServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SWards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SWards_SDistricts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "SDistricts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SExecutionRooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsMain = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SExecutionRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SExecutionRooms_SRooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "SRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SExecutionRooms_SServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SMaterials",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoftOrder = table.Column<int>(type: "int", nullable: true),
                    MaterialTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NationalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImpPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImpQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImpVatRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InternalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SMaterials_SMaterialTypes_MaterialTypeId",
                        column: x => x.MaterialTypeId,
                        principalTable: "SMaterialTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SMaterials_SServiceUnits_ServiceUnitId",
                        column: x => x.ServiceUnitId,
                        principalTable: "SServiceUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SMaterials_SServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SMedicines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoftOrder = table.Column<int>(type: "int", nullable: true),
                    MedicineLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MedicineGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MedicineTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Tutorial = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NationalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImpPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImpQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImpVatRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InternalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMedicines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SMedicines_SMedicineLines_MedicineLineId",
                        column: x => x.MedicineLineId,
                        principalTable: "SMedicineLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SMedicines_SMedicineTypes_MedicineTypeId",
                        column: x => x.MedicineTypeId,
                        principalTable: "SMedicineTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SMedicines_SServiceUnits_ServiceUnitId",
                        column: x => x.ServiceUnitId,
                        principalTable: "SServiceUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SMedicines_SServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "SDepartmentTypes",
                columns: new[] { "Id", "Code", "Description", "Inactive", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "LS", null, false, "Khoa lâm sàng", 1 },
                    { 2, "CLS", null, false, "Khoa cận lâm sàng", 2 },
                    { 3, "DUOC", null, false, "Khoa dược", 3 },
                    { 4, "KHTH", null, false, "Kế hoạch tổng hợp", 4 }
                });

            migrationBuilder.InsertData(
                table: "SGenders",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("97ac7fd8-edfa-4243-97fc-98468f492df1"), "KXD", null, null, null, false, null, null, "Chưa xác định", 0 },
                    { new Guid("e9497984-d355-41af-b917-091500956be9"), "NU", null, null, null, false, null, null, "Nữ", 2 },
                    { new Guid("fc153433-bf89-4e95-8523-df3d8cec8676"), "NAM", null, null, null, false, null, null, "Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "SPatientTypes",
                columns: new[] { "Id", "Code", "Inactive", "Name" },
                values: new object[,]
                {
                    { new Guid("447fe0b2-6f08-4e1a-b456-ebc0ddb6feed"), "DV", false, "Dịch vụ" },
                    { new Guid("8522aa82-5b5e-4d46-a001-26bad813db10"), "VP", false, "Viện phí" },
                    { new Guid("a080ecaa-6cd6-459d-a450-d89351e0904d"), "BHYT", false, "Bảo hiểm y tế" }
                });

            migrationBuilder.InsertData(
                table: "SRoomTypes",
                columns: new[] { "Id", "Code", "Description", "Inactive", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "TD", null, false, "Tiếp đón", 1 },
                    { 2, "HC", null, false, "Hành chính", 2 },
                    { 3, "KHAM", null, false, "Khám bệnh", 3 },
                    { 4, "NT", null, false, "Nội trú", 4 },
                    { 5, "NgT", null, false, "Ngoại trú", 5 },
                    { 6, "XN", null, false, "Xét nghiệm", 6 },
                    { 7, "CDHA", null, false, "Chẩn đoán hình ảnh", 7 },
                    { 8, "KHO-TONG", null, false, "Kho tổng", 8 },
                    { 9, "KHO-NgT", null, false, "Kho ngoại trú", 9 },
                    { 10, "KHO-NT", null, false, "Kho nội trú", 10 },
                    { 11, "TT", null, false, "Tủ trực", 11 },
                    { 12, "QLT", null, false, "Quản lý thuốc", 12 },
                    { 13, "QLVT", null, false, "Quản lý vật tư", 13 }
                });

            migrationBuilder.InsertData(
                table: "SServiceGroupHeIns",
                columns: new[] { "Id", "Code", "Inactive", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("156ec951-453d-4e3f-800e-33f850942874"), "GI-NT", false, "Giường điều trị nội trú", 15 },
                    { new Guid("199b0c88-0ef5-475c-a426-c0547cd13443"), "TT", false, "Thủ thuật", 18 },
                    { new Guid("22048fa7-a9e4-4ac7-89a6-e9e34e4811b4"), "GI-LUU", false, "Ngày giường lưu", 16 },
                    { new Guid("45e3f5de-4096-4944-a6b6-69b829b0f61f"), "XN", false, "Xét nghiệm", 1 },
                    { new Guid("53bf47c7-1414-47cf-8c88-5ba96aa2c978"), "THUOC-TT", false, "Thuốc thanh toán theo tỷ lệ", 6 },
                    { new Guid("675d16db-cd35-4229-b042-82aef4718aff"), "14", false, "Giường điều trị ngoại trú", 14 },
                    { new Guid("75b2f46f-f841-4cbe-9513-93c44306e78e"), "KHAM", false, "Khám bệnh", 13 },
                    { new Guid("7802d629-9e6a-48a7-825c-c91f530785ac"), "CPM", false, "Chế phẩm máu", 17 },
                    { new Guid("7a871ff7-c167-4fc8-b652-0aa2ecd72444"), "TDCN", false, "Thăm dò chức năng", 3 },
                    { new Guid("7c84bd56-f322-477c-b64d-50655cbc06e5"), "DVKT-TL", false, "DVKT thanh toán theo tỷ lệ", 9 },
                    { new Guid("7d39f21a-3f78-4c5a-b288-02532a9769d7"), "THUOC-BHYT", false, "Thuốc trong danh mục BHYT", 4 },
                    { new Guid("81a882db-d465-402f-a391-d3726d698950"), "VC", false, "Vận chuyển", 12 },
                    { new Guid("8868dfd1-fbc7-40c2-83b1-cb0f894cf566"), "VTYT-TT", false, "VTYT thanh toán theo tỷ lệ", 11 },
                    { new Guid("8a360961-1c49-4382-a7ce-ce70358ae25a"), "VTYT-BHYT", false, "Vật tư y tế trong danh mục BHYT", 10 },
                    { new Guid("8a6eee59-ecb3-4bea-89cd-1a83b2d8edd6"), "MAU", false, "Máu", 7 },
                    { new Guid("8c7964ad-f476-4009-a630-a14de7f982d6"), "PT", false, "Phẫu thuật", 8 },
                    { new Guid("90adcfc5-7518-46e2-995f-d304c31583b5"), "THUOC-NgBHYT", false, "Thuốc điều trị ung thư, chống thải ghép ngoài danh mục", 5 },
                    { new Guid("b2e25f8f-ea5b-4255-b2d8-379bd50a5160"), "CDHA", false, "Chẩn đoán hình ảnh", 2 },
                    { new Guid("dc75e4bb-6e85-4a90-ae29-112b7d2873f9"), "VTYT-NgBHYT", false, "Vật tư y tế ngoài danh mục BHYT", 19 }
                });

            migrationBuilder.InsertData(
                table: "SServiceGroups",
                columns: new[] { "Id", "Code", "Inactive", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("0711132b-d3a9-46d1-9ee1-74154facef37"), "CDHA-MRI", false, "Cộng hưởng từ", 17 },
                    { new Guid("0a5a8dc0-67a7-41e9-8fb3-1f5e6f8d874d"), "KHAC", false, "Khác", 28 },
                    { new Guid("0ddd75be-a32c-47f2-b5f1-5138b5997791"), "TT", false, "Thủ thuật", 13 },
                    { new Guid("12105142-6179-41c2-a56c-5364a2b852f5"), "SA", false, "Suất ăn", 21 },
                    { new Guid("1219fe7a-cecb-4a94-8fdc-2f6d0f48fbc9"), "TDCN-DND", false, "Điện não đồ", 10 },
                    { new Guid("17819944-bc22-47c5-afc3-108881fd5714"), "CDHA-XQ", false, "XQuang thường", 15 },
                    { new Guid("1fd09e01-450a-43ce-8bf4-c32aee87753d"), "MAU", false, "Máu", 22 },
                    { new Guid("33dd59d7-ab44-47fe-8b21-8500bf6e6cee"), "XN-HS", false, "Xét nghiệm hóa sinh", 2 },
                    { new Guid("3b082a29-237d-4926-8209-f2876d292189"), "VC", false, "Vận chuyển", 27 },
                    { new Guid("3b3ded9e-71ab-4d31-868c-a704d0604509"), "TDCN", false, "Phục hồi chức năng", 12 },
                    { new Guid("401dbb33-3eb1-44ae-8b3f-51e25996c311"), "KH", false, "Khám", 9 },
                    { new Guid("4be0ad49-ac80-4a2b-9a92-03b3ffd4f3b6"), "CDHA-CT", false, "Cắt lớp vi tính", 18 },
                    { new Guid("8878fb20-578e-46a6-8f61-62789c234bde"), "XN-NT", false, "Xét nghiệm nước tiểu", 4 },
                    { new Guid("906307b7-f7e2-457a-a3d1-62a10ba9daa3"), "TDCN-DTD", false, "Điện tâm đồ", 11 },
                    { new Guid("914b8e89-4c56-4998-9707-def10fd23fbb"), "CDHA-SA", false, "Siêu âm thường", 19 },
                    { new Guid("9414782a-9194-4801-91a0-253963a605eb"), "XN-DCD", false, "Dịch chọc dò", 5 },
                    { new Guid("964200b8-4ae6-434d-a461-909391444b40"), "VTYT", false, "Vật tư", 24 },
                    { new Guid("998836b2-3b5b-4c1c-9b4b-7f6cc1e52b74"), "GI", false, "Giường", 26 },
                    { new Guid("9b9dfabb-abf9-4fea-b17a-6b5f2c3c01b1"), "XN-KHAC", false, "Xét nghiệm khác", 7 },
                    { new Guid("9f474388-e722-4ad2-b194-8a7d8def97fd"), "CDHA-NS", false, "Nội soi", 14 },
                    { new Guid("a080ecaa-6cd6-459d-a450-d89351e0904d"), "XN-HH", false, "Xét nghiệm huyết học", 1 },
                    { new Guid("a13fa2cd-851c-4e89-a8ca-bdacee567757"), "XN-VS", false, "Xét nghiệm vi sinh", 3 },
                    { new Guid("b4573fb1-32a6-45e3-9782-07066d090a5c"), "THUOC", false, "Thuốc", 25 },
                    { new Guid("d4837941-9cc1-4f53-84f7-3e99edc8f508"), "XN-GPB", false, "Giải phẫu bệnh lý", 6 },
                    { new Guid("da2f4b6d-fd50-4cab-bebd-319458064222"), "CPM", false, "Chế phẩm máu", 23 },
                    { new Guid("e43040fc-0e85-436c-8537-5c18e29f61da"), "CDHA-Doppler", false, "Siêu âm màu", 20 },
                    { new Guid("e70f016c-39e7-4ded-aa20-9bffd9fadd59"), "PT", false, "Phẫu thuật", 8 },
                    { new Guid("ff0073ef-be7c-46e1-adc3-99e58871f5c6"), "CDHA-KTS", false, "XQuang kỹ thuật số", 16 }
                });

            migrationBuilder.InsertData(
                table: "SServiceUnits",
                columns: new[] { "Id", "Code", "Inactive", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("0762aebf-cbb8-4102-b923-a30df490f75d"), "6", false, "Hộp", 6 },
                    { new Guid("2198d1c0-57fa-453f-b605-9cef55929067"), "CUON", false, "Cuộn", 9 },
                    { new Guid("3be8bc27-3940-451c-87f5-c062df716872"), "GAM", false, "Gam", 12 },
                    { new Guid("44ab6ffc-f1a9-47d0-90ab-9f09d767c286"), "ONG", false, "Ống", 5 },
                    { new Guid("49793db4-c0ce-43c1-b439-eacd554fa06e"), "MET", false, "Met", 14 },
                    { new Guid("6cc9258a-5f48-4c22-8cd6-61c0795f5405"), "LAN", false, "Lần", 2 },
                    { new Guid("7a0fed4a-e62a-4e9f-8e92-7332127ca248"), "TUB", false, "Tub", 7 },
                    { new Guid("9e12370e-b3ce-4862-8e7d-83d8f7ec56d1"), "11", false, "Lít", 11 },
                    { new Guid("9ff4f404-68bd-4780-99bc-1033227cbe3d"), "GOI", false, "Gói", 8 },
                    { new Guid("a7e37e54-47b8-4716-b493-b657d4981e35"), "MINI", false, "Minimet", 15 },
                    { new Guid("ae0ece26-bb4c-4b23-95cb-1a5d66114634"), "LO", false, "Lọ", 3 },
                    { new Guid("bf42cbf7-b5ac-4503-b73d-d91f4051fa8f"), "ML", false, "ml", 10 },
                    { new Guid("c587599c-a6a6-454f-8e30-2a92dac6f588"), "VIEN", false, "Viên", 1 },
                    { new Guid("cc8713c1-536a-4835-bd7e-187603566f95"), "KG", false, "Kg", 13 },
                    { new Guid("da514a31-4dfc-4445-99bd-4ae29359ad48"), "TUYT", false, "Tuýt", 4 }
                });

            migrationBuilder.InsertData(
                table: "SSurgicalProcedureTypes",
                columns: new[] { "Id", "Code", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "PTDB", "Phẫu thuật đặc biệt", 1 },
                    { 2, "PT01", "Phẫu thuật loại 1", 2 },
                    { 3, "PT02", "Phẫu thuật loại 2", 3 },
                    { 4, "PT03", "Phẫu thuật loại 3", 4 },
                    { 5, "TTDB", "Thủ thuật đặc biệt", 5 },
                    { 6, "TT01", "Thủ thuật loại 1", 6 },
                    { 7, "TT02", "Thủ thuật loại 2", 7 },
                    { 8, "TT03", "Thủ thuật loại 3", 8 }
                });

            migrationBuilder.InsertData(
                table: "SUsers",
                columns: new[] { "Id", "Address", "DistrictId", "Dob", "Email", "FirstName", "GenderId", "LastName", "Password", "PhoneNumber", "ProvinceId", "Status", "UseType", "UserName", "WardId" },
                values: new object[] { new Guid("3382be1c-2836-4246-99db-c4e1c781e868"), null, null, null, "administrator@gmail.com", "Admin", null, "Administrator", "79956B61E1B250869A6716CE37EFD6E6", null, null, 1, 0, "Administrator", null });

            migrationBuilder.CreateIndex(
                name: "IX_SDepartments_BranchId",
                table: "SDepartments",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_SDepartments_DepartmentTypeId",
                table: "SDepartments",
                column: "DepartmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SDistricts_ProvinceId",
                table: "SDistricts",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_SExecutionRooms_RoomId",
                table: "SExecutionRooms",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_SExecutionRooms_ServiceId",
                table: "SExecutionRooms",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SMaterials_MaterialTypeId",
                table: "SMaterials",
                column: "MaterialTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SMaterials_ServiceId",
                table: "SMaterials",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SMaterials_ServiceUnitId",
                table: "SMaterials",
                column: "ServiceUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SMaterialTypes_ServiceId",
                table: "SMaterialTypes",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SMaterialTypes_ServiceUnitId",
                table: "SMaterialTypes",
                column: "ServiceUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SMaterialTypes_SMedicineGroupId",
                table: "SMaterialTypes",
                column: "SMedicineGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicines_MedicineLineId",
                table: "SMedicines",
                column: "MedicineLineId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicines_MedicineTypeId",
                table: "SMedicines",
                column: "MedicineTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicines_ServiceId",
                table: "SMedicines",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicines_ServiceUnitId",
                table: "SMedicines",
                column: "ServiceUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicineTypes_MedicineLineId",
                table: "SMedicineTypes",
                column: "MedicineLineId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicineTypes_ServiceId",
                table: "SMedicineTypes",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicineTypes_ServiceUnitId",
                table: "SMedicineTypes",
                column: "ServiceUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SPatients_GenderId",
                table: "SPatients",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_SPatients_PatientTypeId",
                table: "SPatients",
                column: "PatientTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SProvinces_CountryId",
                table: "SProvinces",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_SRolePermissionBranchs_BranchId",
                table: "SRolePermissionBranchs",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_SRolePermissionBranchs_PermissionId",
                table: "SRolePermissionBranchs",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SRooms_DepartmentId",
                table: "SRooms",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SRooms_RoomTypeId",
                table: "SRooms",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SServicePricePolicies_PatientTypeId",
                table: "SServicePricePolicies",
                column: "PatientTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SServicePricePolicies_ServiceId",
                table: "SServicePricePolicies",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SServices_ServiceGroupHeInId",
                table: "SServices",
                column: "ServiceGroupHeInId");

            migrationBuilder.CreateIndex(
                name: "IX_SServices_ServiceGroupId",
                table: "SServices",
                column: "ServiceGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_SServices_ServiceUnitId",
                table: "SServices",
                column: "ServiceUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SServices_SurgicalProcedureTypeId",
                table: "SServices",
                column: "SurgicalProcedureTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_STokens_UserId",
                table: "STokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SUserRoles_RoleId",
                table: "SUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SWards_DistrictId",
                table: "SWards",
                column: "DistrictId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SCareers");

            migrationBuilder.DropTable(
                name: "SEthnics");

            migrationBuilder.DropTable(
                name: "SExecutionRooms");

            migrationBuilder.DropTable(
                name: "SHospitals");

            migrationBuilder.DropTable(
                name: "SIcds");

            migrationBuilder.DropTable(
                name: "SMaterials");

            migrationBuilder.DropTable(
                name: "SMedicines");

            migrationBuilder.DropTable(
                name: "SPatients");

            migrationBuilder.DropTable(
                name: "SRolePermissionBranchs");

            migrationBuilder.DropTable(
                name: "SServicePricePolicies");

            migrationBuilder.DropTable(
                name: "STokens");

            migrationBuilder.DropTable(
                name: "STreatments");

            migrationBuilder.DropTable(
                name: "SUserRoles");

            migrationBuilder.DropTable(
                name: "SWards");

            migrationBuilder.DropTable(
                name: "SRooms");

            migrationBuilder.DropTable(
                name: "SMaterialTypes");

            migrationBuilder.DropTable(
                name: "SMedicineTypes");

            migrationBuilder.DropTable(
                name: "SGenders");

            migrationBuilder.DropTable(
                name: "SPermissions");

            migrationBuilder.DropTable(
                name: "SPatientTypes");

            migrationBuilder.DropTable(
                name: "SRoles");

            migrationBuilder.DropTable(
                name: "SUsers");

            migrationBuilder.DropTable(
                name: "SDistricts");

            migrationBuilder.DropTable(
                name: "SDepartments");

            migrationBuilder.DropTable(
                name: "SRoomTypes");

            migrationBuilder.DropTable(
                name: "SMedicineGroups");

            migrationBuilder.DropTable(
                name: "SMedicineLines");

            migrationBuilder.DropTable(
                name: "SServices");

            migrationBuilder.DropTable(
                name: "SProvinces");

            migrationBuilder.DropTable(
                name: "SBranchs");

            migrationBuilder.DropTable(
                name: "SDepartmentTypes");

            migrationBuilder.DropTable(
                name: "SServiceGroupHeIns");

            migrationBuilder.DropTable(
                name: "SServiceGroups");

            migrationBuilder.DropTable(
                name: "SServiceUnits");

            migrationBuilder.DropTable(
                name: "SSurgicalProcedureTypes");

            migrationBuilder.DropTable(
                name: "SCountries");
        }
    }
}
