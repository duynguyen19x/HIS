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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
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
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
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
                    DepartmentTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SDepartments_SDepartmentTypes_DepartmentTypeId",
                        column: x => x.DepartmentTypeId,
                        principalTable: "SDepartmentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SPatients_SPatientTypes_PatientTypeId",
                        column: x => x.PatientTypeId,
                        principalTable: "SPatientTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SRolePermissionBranchs_SRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "SRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SServiceTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    ServiceUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_SServiceTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SServiceTypes_SServiceUnits_ServiceUnitId",
                        column: x => x.ServiceUnitId,
                        principalTable: "SServiceUnits",
                        principalColumn: "Id");
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
                        principalColumn: "Id");
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SUserRoles_SUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "SUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SDistricts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SRooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MohCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    RoomTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SRooms_SRoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "SRoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    SurgicalProcedureTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SServices_SServiceGroups_ServiceGroupId",
                        column: x => x.ServiceGroupId,
                        principalTable: "SServiceGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SServices_SServiceTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "SServiceTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SServices_SServiceUnits_ServiceUnitId",
                        column: x => x.ServiceUnitId,
                        principalTable: "SServiceUnits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SServices_SSurgicalProcedureTypes_SurgicalProcedureTypeId",
                        column: x => x.SurgicalProcedureTypeId,
                        principalTable: "SSurgicalProcedureTypes",
                        principalColumn: "Id");
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
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SMaterialTypes_SServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id");
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SMedicineTypes_SServiceUnits_ServiceUnitId",
                        column: x => x.ServiceUnitId,
                        principalTable: "SServiceUnits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SMedicineTypes_SServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id");
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SServicePricePolicies_SServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id");
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SMaterials_SServiceUnits_ServiceUnitId",
                        column: x => x.ServiceUnitId,
                        principalTable: "SServiceUnits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SMaterials_SServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id");
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SMedicines_SMedicineTypes_MedicineTypeId",
                        column: x => x.MedicineTypeId,
                        principalTable: "SMedicineTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SMedicines_SServiceUnits_ServiceUnitId",
                        column: x => x.ServiceUnitId,
                        principalTable: "SServiceUnits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SMedicines_SServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "SGenders",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("3addca6b-aeb4-4833-8bf1-e04980b0ab9b"), "Male", null, null, null, false, null, null, "Nam", null },
                    { new Guid("3f8b0cbc-7b89-467c-9950-303bc2c5b6b8"), "None", null, null, null, false, null, null, "Chưa xác định", null },
                    { new Guid("ecf8d468-b917-49ab-ba5b-def5b0773db0"), "Female", null, null, null, false, null, null, "Nữ", null }
                });

            migrationBuilder.InsertData(
                table: "SPatientTypes",
                columns: new[] { "Id", "Code", "Inactive", "Name" },
                values: new object[,]
                {
                    { new Guid("0251c635-dcc4-40a6-8023-d4bda5cb1f79"), "DV", false, "Dịch vụ" },
                    { new Guid("c94ab6ba-5955-4c21-9d9d-416588117a94"), "BHYT", false, "Bảo hiểm y tế" },
                    { new Guid("d78bc647-2d40-41b2-b330-5385bfbe4229"), "VP", false, "Viện phí" }
                });

            migrationBuilder.InsertData(
                table: "SServiceGroupHeIns",
                columns: new[] { "Id", "Code", "Inactive", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("1521895a-753a-4468-aa45-f7c5d4d2e2ca"), "3", false, "Thăm dò chức năng", 3 },
                    { new Guid("19b25bfc-87c6-4128-8006-e12d328e50fd"), "7", false, "Máu và chế phẩm máu", 7 },
                    { new Guid("1a5ee1b9-3a90-4ed8-9266-06702df072f6"), "13", false, "Khám bệnh", 13 },
                    { new Guid("2189b983-2064-4487-a99c-6bb78afcc0fa"), "14", false, "Giường điều trị ngoại trú", 14 },
                    { new Guid("2cff84c3-b2ca-4a3e-8f4a-7d9b3b34a7e6"), "9", false, "DVKT thanh toán theo tỷ lệ", 9 },
                    { new Guid("2f358448-3962-4640-82e8-8bc71e6607f7"), "8", false, "Phẫu thuật", 8 },
                    { new Guid("3a050e31-f1c5-49ef-9a47-1ac6785737c6"), "11", false, "VTYT thanh toán theo tỷ lệ", 11 },
                    { new Guid("5f649cce-a6c4-4131-8e18-ad6db3e93a1a"), "6", false, "Thuốc thanh toán theo tỷ lệ", 6 },
                    { new Guid("66cf0414-eac4-4988-a6fc-dd6a69c37648"), "10", false, "Vật tư y tế trong danh mục BHYT", 10 },
                    { new Guid("81786062-3b8f-4916-bca6-bd98eb3d3ade"), "1", false, "Xét nghiệm", 1 },
                    { new Guid("97b47f59-98c6-4700-a892-4990511ccec3"), "16", false, "Ngày giường lưu", 16 },
                    { new Guid("9dff4b9d-b250-44c0-ab09-f8d8e9351555"), "12", false, "Vận chuyển", 12 },
                    { new Guid("b0756f95-ec78-47ff-8d76-6bbaa8f1f1bf"), "17", false, "Chế phẩm máu", 17 },
                    { new Guid("b85aeffc-cd8c-41b7-84f9-9b4b54433686"), "4", false, "Thuốc trong danh mục BHYT", 4 },
                    { new Guid("ba56d5cc-c5c8-422b-8973-30e07a60ca57"), "2", false, "Chẩn đoán hình ảnh", 2 },
                    { new Guid("c32790a5-9f63-4594-9950-2949b6201835"), "15", false, "Giường điều trị nội trú", 15 },
                    { new Guid("f79303e8-570f-4c55-be1b-6aa6b8d88206"), "5", false, "Thuốc điều trị ung thư, chống thải ghép ngoài danh mục", 5 },
                    { new Guid("f7b495fc-a3a7-48df-a23b-c18bcd244f26"), "18", false, "Thủ thuật", 18 }
                });

            migrationBuilder.InsertData(
                table: "SServiceGroups",
                columns: new[] { "Id", "Code", "Inactive", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("2c81894b-b029-40d2-ba11-1781b9400fa9"), "XN-NT", false, "Xét nghiệm nước tiểu", 4 },
                    { new Guid("39085951-2171-4e1a-87f1-938c11eb6151"), "VT", false, "Vật tư", 21 },
                    { new Guid("4b6fcc13-6143-4a0e-962e-53844bd60686"), "CDHA-MRI", false, "Cộng hưởng từ", 16 },
                    { new Guid("4dbd730c-7aee-4e3c-bc6c-fc1918880bf5"), "CDHA-CT", false, "Cắt lớp vi tính", null },
                    { new Guid("4e5cddfa-af78-4c73-b7b1-8ed30058b0fb"), "KH", false, "Khám", 8 },
                    { new Guid("52cb9264-8d47-4435-8014-6eba0bc3b89d"), "CDHA-SA", false, "Siêu âm thường", 17 },
                    { new Guid("62c9898b-c3fb-45f9-9a3a-64ba915c4d25"), "XN-DCD", false, "Dịch chọc dò", 5 },
                    { new Guid("6433596a-f71a-4483-b1d6-72ef4710c7f9"), "XN-HH", false, "Xét nghiệm huyết học", 1 },
                    { new Guid("665b13f2-00cc-45f5-a3ad-e2074f7c8df0"), "MA", false, "Máu", 20 },
                    { new Guid("66732353-c68f-4b72-aa19-bd908167f5b0"), "TH", false, "Thuốc", 22 },
                    { new Guid("6bd5b40c-1142-4881-9e65-2bb12c887d2f"), "XN-SH", false, "Xét nghiệm sinh hóa", 2 },
                    { new Guid("726b8c63-bfc9-405f-89ae-2d950f303f6e"), "CDHA-SA-M", false, "Siêu âm màu", 18 },
                    { new Guid("72a09264-64eb-47b8-a3c8-cac3f2a31193"), "CDHA-XQ-KTS", false, "XQuang kỹ thuật số", 15 },
                    { new Guid("735946f5-8c00-483b-8d23-384abc27030c"), "AN", false, "Suất ăn", 19 },
                    { new Guid("780e750f-5bc8-4f0d-bc86-4cc0116a5351"), "PH", false, "Phục hồi chức năng", 11 },
                    { new Guid("7a0bc683-6e7e-480f-89b6-1b633bc4a5d7"), "PT", false, "Phẫu thuật", 7 },
                    { new Guid("aa435015-00ac-4063-b9d8-25b8afc8bd65"), "XN-VS", false, "Xét nghiệm vi sinh", 3 },
                    { new Guid("aa525f71-8af5-428a-b222-7b8b4e4ff4b2"), "VC", false, "Vận chuyển", 24 },
                    { new Guid("b11abc28-7dbc-4add-8d49-726c7572d824"), "TDCN-DND", false, "Điện não đồ", 9 },
                    { new Guid("ccbfde50-f639-4a69-a479-c78b11f0b499"), "CDHA-XQ", false, "XQuang thường", 14 },
                    { new Guid("ce7f2711-3874-44f5-92ef-32eda93da8bc"), "TT", false, "Thủ thuật", 12 },
                    { new Guid("dc4ba36b-56fa-4271-ad45-4e658120ba62"), "CDHA-NS", false, "Nội soi", 13 },
                    { new Guid("e3971ab1-210f-4663-9ed3-dab4b1efed01"), "TDCN-TTD", false, "Điện tâm đồ", 10 },
                    { new Guid("e4b10d90-b939-43ce-9465-37d7e4064ef2"), "GB", false, "Giải phẫu bệnh lý", 6 },
                    { new Guid("fa491c1c-9e01-42c3-94fe-082b516accbe"), "GI", false, "Giường", 23 },
                    { new Guid("fe78f957-8977-43f4-9640-015eb4ddf1b3"), "CL", false, "Khác", 25 }
                });

            migrationBuilder.InsertData(
                table: "SServiceUnits",
                columns: new[] { "Id", "Code", "Inactive", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("1188ca0e-9ac3-44e3-817c-847a26999a0b"), "04", false, "Tuýt", 4 },
                    { new Guid("1eef2b35-8cc5-4f8b-9118-018203fd3c03"), "11", false, "Lít", 11 },
                    { new Guid("2a8869fd-0cea-47e2-b48f-7c2cb8b20d1c"), "14", false, "Met", 14 },
                    { new Guid("30fd6a09-2fc5-4046-9c3d-7058b3aff4d5"), "03", false, "Lọ", 3 },
                    { new Guid("4efbf8ae-bdd8-45da-8bb3-14c9f0f91e6e"), "06", false, "Hộp", 6 },
                    { new Guid("66846338-0d57-428c-9933-4e734b26f31c"), "08", false, "Gói", 8 },
                    { new Guid("6957fe26-fd27-4acb-b27d-a6c803e8c4e6"), "09", false, "Cuộn", 9 },
                    { new Guid("7b227bb3-7c04-49ce-b0c6-f3919382fa8c"), "05", false, "Ống", 5 },
                    { new Guid("97951608-4915-4e34-a578-f5fc79e505ad"), "01", false, "Viên", 1 },
                    { new Guid("bcdca037-2e5d-423a-9952-67fc521b365e"), "10", false, "ml", 10 },
                    { new Guid("c3a08ab9-663a-4eb3-b112-babb59a64601"), "12", false, "Gam", 12 },
                    { new Guid("c8120273-3dda-404c-a447-cc5cabb30d33"), "07", false, "Tub", 7 },
                    { new Guid("e83b24d6-c2bb-4735-8cc2-f6c2cca8748f"), "15", false, "Minimet", 9 },
                    { new Guid("e8439932-47e6-487e-898e-8631dbd45dea"), "02", false, "Lần", 2 },
                    { new Guid("f4e6ee3a-3164-4c2a-a1cd-71e860f049bf"), "13", false, "Kg", 13 }
                });

            migrationBuilder.InsertData(
                table: "SSurgicalProcedureTypes",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "DeleteBy", "DeleteDate", "IsDelete", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("2f5bd512-57ea-4c7d-9432-7983ba5eb93b"), "PT-3", null, null, null, null, null, null, null, "Phẫu thuật loại 3", 4 },
                    { new Guid("68373bbc-ddf6-4094-b1ba-53835c4d278b"), "PT-1", null, null, null, null, null, null, null, "Phẫu thuật loại 1", 2 },
                    { new Guid("6d35af6f-9833-42ca-9345-e9a7aad7d9e1"), "TT-3", null, null, null, null, null, null, null, "Thủ thuật loại 3", 8 },
                    { new Guid("a0d68c86-c0b0-4c51-acf3-ceb201cf12bb"), "TT-1", null, null, null, null, null, null, null, "Thủ thuật loại 1", 6 },
                    { new Guid("ce5ac5b9-39ea-4aeb-abf5-ccb9b39104db"), "TT-DB", null, null, null, null, null, null, null, "Thủ thuật đặc biệt", 5 },
                    { new Guid("d38dc24b-464d-40b0-8e5f-73f68f37861e"), "TT-2", null, null, null, null, null, null, null, "Thủ thuật loại 2", 7 },
                    { new Guid("d6dcfa41-1a20-4e57-9b7b-e88195172b37"), "PT-DB", null, null, null, null, null, null, null, "Phẫu thuật đặc biệt", 1 },
                    { new Guid("ecfa4b60-2a32-4997-a00d-2292a8c3b513"), "PT-2", null, null, null, null, null, null, null, "Phẫu thuật loại 2", 3 }
                });

            migrationBuilder.InsertData(
                table: "SUsers",
                columns: new[] { "Id", "Address", "DistrictId", "Dob", "Email", "FirstName", "GenderId", "LastName", "Password", "PhoneNumber", "ProvinceId", "Status", "UseType", "UserName", "WardId" },
                values: new object[] { new Guid("4d5bdea5-4a2c-4e6e-b6b4-58a1d78b1050"), null, null, null, "administrator@gmail.com", "Admin", null, "Administrator", "79956B61E1B250869A6716CE37EFD6E6", null, null, 1, 0, "Administrator", null });

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
                name: "IX_SServices_ServiceTypeId",
                table: "SServices",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SServices_ServiceUnitId",
                table: "SServices",
                column: "ServiceUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SServices_SurgicalProcedureTypeId",
                table: "SServices",
                column: "SurgicalProcedureTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SServiceTypes_ServiceUnitId",
                table: "SServiceTypes",
                column: "ServiceUnitId");

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
                name: "SRooms");

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
                name: "SMaterialTypes");

            migrationBuilder.DropTable(
                name: "SMedicineTypes");

            migrationBuilder.DropTable(
                name: "SGenders");

            migrationBuilder.DropTable(
                name: "SPermissions");

            migrationBuilder.DropTable(
                name: "SDepartments");

            migrationBuilder.DropTable(
                name: "SRoomTypes");

            migrationBuilder.DropTable(
                name: "SPatientTypes");

            migrationBuilder.DropTable(
                name: "SRoles");

            migrationBuilder.DropTable(
                name: "SUsers");

            migrationBuilder.DropTable(
                name: "SDistricts");

            migrationBuilder.DropTable(
                name: "SMedicineGroups");

            migrationBuilder.DropTable(
                name: "SMedicineLines");

            migrationBuilder.DropTable(
                name: "SServices");

            migrationBuilder.DropTable(
                name: "SBranchs");

            migrationBuilder.DropTable(
                name: "SDepartmentTypes");

            migrationBuilder.DropTable(
                name: "SProvinces");

            migrationBuilder.DropTable(
                name: "SServiceGroupHeIns");

            migrationBuilder.DropTable(
                name: "SServiceGroups");

            migrationBuilder.DropTable(
                name: "SServiceTypes");

            migrationBuilder.DropTable(
                name: "SSurgicalProcedureTypes");

            migrationBuilder.DropTable(
                name: "SCountries");

            migrationBuilder.DropTable(
                name: "SServiceUnits");
        }
    }
}
