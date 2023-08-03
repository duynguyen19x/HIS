using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DImExMestTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DImExMestTypes", x => x.Id);
                });

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
                    HeInCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    IsSystem = table.Column<bool>(type: "bit", nullable: false)
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
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMedicineLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SPatientTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                name: "SSupplier",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_SSupplier", x => x.Id);
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
                    table.PrimaryKey("PK_STreatments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    UnitType = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUnits", x => x.Id);
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
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BirthYear = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_SPatients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SPatients_SGenders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "SGenders",
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
                    UnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceGroupHeInId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SurgicalProcedureTypeId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_SServices_SSurgicalProcedureTypes_SurgicalProcedureTypeId",
                        column: x => x.SurgicalProcedureTypeId,
                        principalTable: "SSurgicalProcedureTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SServices_SUnits_UnitId",
                        column: x => x.UnitId,
                        principalTable: "SUnits",
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_SMaterialTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SMaterialTypes_SServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SMaterialTypes_SUnits_ServiceUnitId",
                        column: x => x.ServiceUnitId,
                        principalTable: "SUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SMedicineTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HeInCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    MedicineLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceGroupHeInId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MedicineGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Tutorial = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ActiveSubstance = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Concentration = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ProprietaryDrug = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PackagingSpecifications = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ImpPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImpVatRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    IsAntibiotics = table.Column<bool>(type: "bit", nullable: false),
                    IsNewDrug = table.Column<bool>(type: "bit", nullable: false),
                    IsPrescriptionDrug = table.Column<bool>(type: "bit", nullable: false),
                    IsNutraceutical = table.Column<bool>(type: "bit", nullable: false),
                    IsSponsoredDrug = table.Column<bool>(type: "bit", nullable: false),
                    IsInhalantDrug = table.Column<bool>(type: "bit", nullable: false),
                    IsPrescriptionDrugForChildren = table.Column<bool>(type: "bit", nullable: false),
                    IsTraditionalHerbalDrug = table.Column<bool>(type: "bit", nullable: false),
                    IsTraditionalDrugFormulation = table.Column<bool>(type: "bit", nullable: false),
                    IsDrugContainerReturnRequest = table.Column<bool>(type: "bit", nullable: false),
                    IsAllowZeroQuantity = table.Column<bool>(type: "bit", nullable: false),
                    IsRadiolabeledDrug = table.Column<bool>(type: "bit", nullable: false),
                    PharmaceuticalFormulation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ScientificName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ScientificNameChildren = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DugStatus = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    RequirementUseDug = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PharmaceuticalDivision = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ProcessingLossRate = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    OtherExpenses = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PreparationMethod = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    QualityStandards = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_SMedicineTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SMedicineTypes_SCountries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "SCountries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SMedicineTypes_SMedicineGroups_MedicineGroupId",
                        column: x => x.MedicineGroupId,
                        principalTable: "SMedicineGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SMedicineTypes_SMedicineLines_MedicineLineId",
                        column: x => x.MedicineLineId,
                        principalTable: "SMedicineLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SMedicineTypes_SServices_SServiceId",
                        column: x => x.SServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SMedicineTypes_SUnits_UnitId",
                        column: x => x.UnitId,
                        principalTable: "SUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SServicePricePolicies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PatientTypeId = table.Column<int>(type: "int", nullable: true),
                    OldUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NewUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CeilingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ExecutionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                name: "SServiceResultIndices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaleFrom = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MaleTo = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FemaleFrom = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FemaleTo = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    SServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SServiceResultIndices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SServiceResultIndices_SServices_SServiceId",
                        column: x => x.SServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id");
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
                    table.PrimaryKey("PK_SWards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SWards_SDistricts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "SDistricts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DImMests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ImMestStatus = table.Column<int>(type: "int", nullable: false),
                    ImStockId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExStockId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImExMestTypeId = table.Column<int>(type: "int", nullable: true),
                    ReceiverUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApproverUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImpTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApproverTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ReqRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReqDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TreatmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InvTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deliverer = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                    table.PrimaryKey("PK_DImMests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DImMests_DImExMestTypes_ImExMestTypeId",
                        column: x => x.ImExMestTypeId,
                        principalTable: "DImExMestTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DImMests_SDepartments_ReqDepartmentId",
                        column: x => x.ReqDepartmentId,
                        principalTable: "SDepartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DImMests_SPatients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "SPatients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DImMests_SRooms_ExStockId",
                        column: x => x.ExStockId,
                        principalTable: "SRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DImMests_SRooms_ImStockId",
                        column: x => x.ImStockId,
                        principalTable: "SRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DImMests_SRooms_ReqRoomId",
                        column: x => x.ReqRoomId,
                        principalTable: "SRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DImMests_SSupplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "SSupplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DImMests_STreatments_TreatmentId",
                        column: x => x.TreatmentId,
                        principalTable: "STreatments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DImMests_SUsers_ApproverUserId",
                        column: x => x.ApproverUserId,
                        principalTable: "SUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DImMests_SUsers_ReceiverUserId",
                        column: x => x.ReceiverUserId,
                        principalTable: "SUsers",
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
                    UnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NationalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImpPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImpQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImpVatRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InternalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
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
                    table.PrimaryKey("PK_SMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SMaterials_SMaterialTypes_MaterialTypeId",
                        column: x => x.MaterialTypeId,
                        principalTable: "SMaterialTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SMaterials_SServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SMaterials_SUnits_UnitId",
                        column: x => x.UnitId,
                        principalTable: "SUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SMedicines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HeInCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    MedicineLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MedicineGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MedicineTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Tutorial = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImpPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImpQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImpVatRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ActiveSubstance = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Concentration = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PackagingSpecifications = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Dosage = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Lot = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TenderDecision = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    TenderPackage = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    TenderGroup = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    TenderYear = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    SServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_SMedicines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SMedicines_SCountries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "SCountries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        name: "FK_SMedicines_SServices_SServiceId",
                        column: x => x.SServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SMedicines_SUnits_UnitId",
                        column: x => x.UnitId,
                        principalTable: "SUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    SPatientTypeId = table.Column<int>(type: "int", nullable: true),
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

            migrationBuilder.InsertData(
                table: "SCountries",
                columns: new[] { "Id", "Code", "HeInCode", "Inactive", "Name" },
                values: new object[,]
                {
                    { new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), "VN", "000", false, "Việt Nam" },
                    { new Guid("0105cfd9-5265-4dcc-b2d8-790abecd5577"), "PS", "PS", false, "Palestinian Authority" },
                    { new Guid("02cd862f-7bf2-4dee-9d8d-869f67659eac"), "CX", "CX", false, "Christmas island" },
                    { new Guid("05600686-62bc-4be9-b009-58ae6fac5dc2"), "UM", "UM", false, "United States Minor Outlying Islands" },
                    { new Guid("05f8a24e-3764-41af-b79b-3e05da6964ad"), "TO", "276", false, "Tonga" },
                    { new Guid("060539cd-d169-45c2-bec2-28a91e41bcb3"), "IL", "184", false, "Israel" },
                    { new Guid("067dbcfb-9729-4016-aa0f-526f43657542"), "CL", "141", false, "Chile" },
                    { new Guid("07c04d8d-4e1c-4896-ba8a-7d8172562b37"), "KP", "277", false, "Triều Tiên" },
                    { new Guid("09127bf0-ff5d-4660-8fef-18b3107bf295"), "BI", "135", false, "Burundi" },
                    { new Guid("0d9bf5f6-20bb-4b4f-8c3e-0b7205eabe19"), "PR", "PR", false, "Puerto Rico" },
                    { new Guid("0f42743d-f2ae-4d4d-9e9c-6dcd785204ff"), "SE", "273", false, "Thụy Điển" },
                    { new Guid("10a98338-7167-4e5b-b3e4-9515f63bb43d"), "FI", "241", false, "Phần Lan" },
                    { new Guid("10f310c4-857b-431b-934c-19ebc560571c"), "IS", "179", false, "Iceland" },
                    { new Guid("1137907c-6292-4973-8a6a-5a8a55216701"), "OM", "233", false, "Oman" },
                    { new Guid("16bfb332-7ffe-4d31-a2a2-05e7cc250969"), "Z1", "Z1", false, "Sovereign Military Order of Malta (SMOM)" },
                    { new Guid("1760cdb2-5d9e-4a4d-a422-9d2d54333b72"), "VA", "290", false, "Thành Vatican" },
                    { new Guid("18be6a2d-0cc9-4e57-9b95-0fd5e0999094"), "LA", "193", false, "Lào" },
                    { new Guid("19b9d4e2-dd04-4d66-ba70-e71a800b8563"), "CO", "142", false, "Colombia" },
                    { new Guid("1a52542a-e4e8-4514-b84f-d8f7a0ce8bf5"), "HU", "177", false, "Hungary" },
                    { new Guid("1bb67a2c-65b1-4437-b7db-61bb5c5c945a"), "NZ", "227", false, "New Zealand" },
                    { new Guid("1bd96043-4837-4ab4-8812-0230d7cdc37c"), "BH", "117", false, "Bahrain" },
                    { new Guid("1c1e8f0d-fa36-4dd5-a349-51f8f8cf1e11"), "RU", "231", false, "Nga" },
                    { new Guid("1c3907c5-3cd4-4530-a28c-6d4acceec175"), "AZ", "113", false, "Azerbaijan" },
                    { new Guid("1cb83a16-11a1-438b-8fd9-22e661c5904a"), "TN", "281", false, "Tunisia" },
                    { new Guid("1cc02fda-f061-49ad-a4f1-ecb564a28c88"), "KZ", "187", false, "Kazakhstan" },
                    { new Guid("1d374c8c-88c5-49ae-9c9c-0b2b362b1198"), "BR", "131", false, "Brasil" },
                    { new Guid("1d41f179-ba78-41d6-8ecf-595c7d6de65a"), "MA", "209", false, "Maroc" },
                    { new Guid("1df44627-4127-48c0-bbc7-2afc64cb75d2"), "CH", "274", false, "Thụy Sĩ" },
                    { new Guid("1f0c0c80-dceb-47c4-9bfb-d9e2b29e8010"), "NR", "224", false, "Nauru" },
                    { new Guid("20aa6e3b-0838-45fc-9769-161b291e5e24"), "Z4", "Z4", false, "Scotland" },
                    { new Guid("212573b7-ec34-4844-b150-74f567de2c5d"), "GF", "GF", false, "French guiana" },
                    { new Guid("21668f2b-b3d0-4927-9d67-3f9eee4736d6"), "AS", "AS", false, "Samoa thuộc Hoa Kỳ" },
                    { new Guid("22174cd0-7b2d-4c6b-bb6c-5273e63d28f0"), "MY", "205", false, "Malaysia" },
                    { new Guid("226d663e-46ee-4ab2-b385-b062345debd9"), "FR", "240", false, "Pháp" },
                    { new Guid("23063395-5d36-41c9-9711-66722ab8849f"), "CZ", "252", false, "Séc" },
                    { new Guid("24c5f9fa-e493-43a1-9d2a-c6d25dc2ea89"), "FY", "254", false, "Serbia" },
                    { new Guid("25b7ed9b-8bfd-4601-a4c5-a59dfe5a3fab"), "AN", "AN", false, "Netherlands antilles" },
                    { new Guid("25df127f-9fb7-4f1d-8a4f-484364e15f91"), "GN", "170", false, "Guinea" },
                    { new Guid("264432ff-ba3d-4402-ae05-d3cbbdf7eef4"), "NE", "229", false, "Niger" },
                    { new Guid("26d0e10a-43ea-4654-93be-00a21f60b760"), "PG", "237", false, "Papua New Guinea" },
                    { new Guid("298cf3d9-cf13-401f-86b5-368d1c71ec77"), "GQ", "169", false, "Guinea Xích Đạo" },
                    { new Guid("2e24284d-fe7b-477b-a3e9-23505ccbe379"), "Z6", "Z6", false, "Great Britain (See United Kingdom)" },
                    { new Guid("2eab2085-d20b-4cc4-a85b-7567c9ce6ea9"), "LC", "247", false, "Saint Lucia" },
                    { new Guid("2eb9de76-3d99-43a5-b17d-ba2f0e08c64a"), "NI", "228", false, "Nicaragua" },
                    { new Guid("2eead3fb-8c57-4699-a48d-b9eb2a781d23"), "TF", "TF", false, "French Southern Territories" },
                    { new Guid("2f4455d6-efee-4959-8dfd-6f7db81faadd"), "NP", "226", false, "Nepal" },
                    { new Guid("2facb682-01d5-4798-bf0a-928bd471ecb3"), "CC", "CC", false, "Cocos (keeling) islands" },
                    { new Guid("332e0e9e-0182-47a0-b894-ade71da83708"), "BB", "120", false, "Barbados" },
                    { new Guid("33aeb885-ea5c-4343-8011-b1dccebdd65f"), "SA", "110", false, "Ả Rập Saudi" },
                    { new Guid("347a0e24-276d-4a54-b92b-4b88b60179af"), "GM", "163", false, "Gambia" },
                    { new Guid("36299397-b100-420b-bd1b-3f18eda310fa"), "TD", "270", false, "Tchad" },
                    { new Guid("3671801a-1c88-4dc6-9e75-d766644c2af9"), "SR", "264", false, "Suriname" },
                    { new Guid("36ddc306-adf0-4897-a200-6377ff0d9042"), "TT", "278", false, "Trinidad và Tobago" },
                    { new Guid("39351753-1af5-4797-89e2-b97589db8d2e"), "AZ", "114", false, "Cộng hòa Azerbaijan" },
                    { new Guid("39ef7fcd-b539-46be-90a6-bc3f6d1524d8"), "KR", "174", false, "Hàn Quốc" },
                    { new Guid("3adb70b0-ae40-4ac0-8a27-15398cc79d49"), "GS", "GS", false, "South georgia and the south sandwich islands" },
                    { new Guid("3af1daa8-65e1-4502-823d-3c8530608104"), "MP", "MP", false, "Northern mariana islands" },
                    { new Guid("3d9d9ca5-3356-48b3-b518-eb806a6128ee"), "VU", "289", false, "Vanuatu" },
                    { new Guid("3dac050e-a2a6-469b-b0bb-def2e17544a5"), "GW", "168", false, "Guinea-Bissau" },
                    { new Guid("3de67d92-a46e-4113-bd12-2e89a48aa1f0"), "CN", "279", false, "Trung Quốc" },
                    { new Guid("3edffd99-5e14-4466-9f3e-a72ab48711d7"), "HM", "HM", false, "Heard and mc donald islands" },
                    { new Guid("3f3e1d5e-ca7b-45ef-9e1e-f3c471e8894f"), "ST", "251", false, "São Tomé và Príncipe" },
                    { new Guid("426516a2-46e9-4103-8b44-22b4a30b21ae"), "LS", "195", false, "Lesotho" },
                    { new Guid("4452efd3-9727-4c5c-9cc9-76f7270c673d"), "CI", "130", false, "Bờ Biển Ngà" },
                    { new Guid("44ff82d4-3356-4f71-9aa2-dc5f161537f0"), "SY", "266", false, "Syria" },
                    { new Guid("45696681-b325-4d55-b4ea-56a920227907"), "SL", "256", false, "Sierra Leone" },
                    { new Guid("4589f414-2018-4196-a42a-68fa60b41dae"), "MZ", "219", false, "Mozambique" },
                    { new Guid("45a0ebe0-51be-423b-8885-7a7bf06e6f95"), "BA", "127", false, "Bosna và Hercegovina" },
                    { new Guid("46651a82-3d63-4a24-baff-9bb1ee8ac492"), "CF", "280", false, "Trung Phi" },
                    { new Guid("484be820-41ff-4911-94c6-2d2969764ac4"), "CD", "145", false, "Cộng hòa Dân chủ Congo" },
                    { new Guid("4b12f61e-5980-415f-a62b-b296753fd70d"), "PT", "129", false, "Bồ Đào Nha" },
                    { new Guid("4b7309a1-de33-4f43-a2ff-3f11e0e5869b"), "SM", "250", false, "San Marino" },
                    { new Guid("4bab2495-c861-47e7-82e6-1806fd87b767"), "IM", "IM", false, "Isle of man" },
                    { new Guid("4dbc51c5-3faa-4e76-b0d5-a28df95c5c01"), "GT", "167", false, "Guatemala" },
                    { new Guid("4dcd4bda-0da9-415d-8f7e-ecd5841ad250"), "ER", "158", false, "Eritrea" },
                    { new Guid("4e6e77af-56d6-4314-ac68-c39713511d70"), "IE", "183", false, "Ireland" },
                    { new Guid("50202b21-f7c0-42eb-89bd-4470e82f3943"), "JE", "JE", false, "Jersey" },
                    { new Guid("502c14cb-18ea-461f-9bc0-9591b056284c"), "DK", "153", false, "Đan Mạch" },
                    { new Guid("506ddd2c-4f81-4d6d-806c-4c9e605bab3f"), "KN", "246", false, "Saint Kitts và Nevis" },
                    { new Guid("509f7d40-e740-472f-8a7a-84b5a527eb96"), "KG", "192", false, "Kyrgyzstan" },
                    { new Guid("50c044c3-6cd1-46ad-b10a-e879291806f2"), "NU", "NU", false, "Niue" },
                    { new Guid("52595376-4b2b-4746-bb17-16f7ba234a33"), "MW", "204", false, "Malawi" },
                    { new Guid("5300fbb8-1d3b-48c2-b251-c9daab165b94"), "SH", "SH", false, "St. Helena" },
                    { new Guid("5351587c-9713-44c9-9088-9626d01300c8"), "TK", "TK", false, "Tokelau" },
                    { new Guid("539247ef-f9a9-4893-b250-2aa204a87640"), "VG", "VG", false, "Virgin Islands (British)" },
                    { new Guid("53b7d739-4b49-4a35-9d04-93520d79d105"), "TJ", "267", false, "Tajikistan" },
                    { new Guid("53fdbb96-c808-4474-83bc-084e422a8b95"), "BY", "121", false, "Belarus" },
                    { new Guid("54ca17f4-f6f7-4bcf-9809-8d45153c2271"), "LR", "197", false, "Liberia" },
                    { new Guid("561d896e-c3c5-4dfc-b13c-790aa25fbd5d"), "PA", "236", false, "Panama" },
                    { new Guid("5701a860-793e-4660-9302-005b27d4348e"), "AO", "106", false, "Angola" },
                    { new Guid("573dec77-5908-42b2-b1a5-8a5ee8407dee"), "GD", "165", false, "Grenada" },
                    { new Guid("57c01cf1-7f20-4a6c-bec9-bcc9a3a039fe"), "SG", "257", false, "Singapore" },
                    { new Guid("58357a87-d3a9-4ea4-82ea-eb7775f1c568"), "IR", "181", false, "Iran" },
                    { new Guid("58486abc-86a6-4bb8-a610-eb0e4bdf0b73"), "LT", "200", false, "Litva" },
                    { new Guid("58776bc3-ee4b-44ae-ac9e-a501437bde2f"), "PF", "PF", false, "French Polynesia" },
                    { new Guid("58d12ab1-4946-45f9-bef5-354e5803f357"), "DO", "152", false, "Cộng hòa Dominicana" },
                    { new Guid("59e93599-98e9-44de-b9d1-bbbf17c599bf"), "ZA", "223", false, "Nam Phi" },
                    { new Guid("5a68453d-81d4-4417-a579-33d6a1c27ea6"), "PE", "239", false, "Peru" },
                    { new Guid("5b526a49-1694-4eb8-b602-4e150d12184d"), "MC", "216", false, "Monaco" },
                    { new Guid("5bd03273-5b23-4181-892c-397126e8da56"), "PK", "234", false, "Pakistan" },
                    { new Guid("5d60e969-8387-42e4-b866-31dfb209f433"), "Z3", "Z3", false, "England" },
                    { new Guid("5dc567de-1249-4aaa-9d49-04dcd3501220"), "ES", "269", false, "Tây Ban Nha" },
                    { new Guid("5f4a7dfd-c3ed-4796-bde2-94199e595ef0"), "BV", "BV", false, "Bouvet island" },
                    { new Guid("62947f31-4a3e-441b-a9d2-9642ce61de2f"), "KI", "189", false, "Kiribati" },
                    { new Guid("62b0c6c0-4a45-4f33-b35e-d184d815518e"), "GH", "164", false, "Ghana" },
                    { new Guid("63c8621a-fc44-4abe-ba08-8d80520280cf"), "SC", "255", false, "Seychelles" },
                    { new Guid("6477d7a3-465e-4277-a4eb-ef09b13f5eca"), "MO", "MO", false, "Macau" },
                    { new Guid("66169c75-2aa7-409a-a7b9-d8cfe6ac80c0"), "LB", "196", false, "Li ban" },
                    { new Guid("66400b32-893a-489c-a5e1-180d55fb20d4"), "KE", "188", false, "Kenya" },
                    { new Guid("66533605-d826-4aec-9536-e4d30effefda"), "AL", "103", false, "Albania" },
                    { new Guid("665d03c6-346e-43d8-ad21-31492b4382aa"), "JO", "186", false, "Jordan" },
                    { new Guid("686b79de-db2f-4ccd-946c-1bef80cd503e"), "CA", "140", false, "Canada" },
                    { new Guid("6b24b562-1294-4537-a69a-26ac34c41521"), "AD", "105", false, "Andorra" },
                    { new Guid("6b8836aa-2476-4d82-98f1-0b7f56e66f7a"), "TL", "TL", false, "Timor Leste" },
                    { new Guid("6c408b50-b4be-4eca-a710-11a6d914cf4f"), "AT", "109", false, "Áo" },
                    { new Guid("6d2d2371-8785-4a7b-94ba-84c804b2b0a2"), "RE", "RE", false, "Reunion" },
                    { new Guid("6d5a6761-432b-4bd2-9b04-5e01c421de23"), "NF", "NF", false, "Norfolk Island" },
                    { new Guid("716a0688-0378-4941-af8f-c11dc4c45ac2"), "TC", "TC", false, "Turks and Caicos Islands" },
                    { new Guid("720aaa71-3cc0-470f-b56c-472ac37a6574"), "BE", "125", false, "Bỉ" },
                    { new Guid("72d527d4-00df-4f9a-b0e1-e1fa84a4ba6d"), "SO", "261", false, "Somalia" },
                    { new Guid("74c266fd-7287-4525-aca3-6bb66ddcf61f"), "WS", "249", false, "Samoa" },
                    { new Guid("75de9dea-ef0f-4492-890a-f5af36cce7aa"), "CG", "144", false, "Cộng hòa Congo" },
                    { new Guid("76c42f0f-bfb2-4a11-b5a4-e854f74e72cd"), "BZ", "122", false, "Belize" },
                    { new Guid("77365013-80d7-44d5-bd8d-472542cac431"), "MQ", "MQ", false, "Martinique" },
                    { new Guid("788693d2-4ac9-4f85-94bf-13d021bc000d"), "PM", "PM", false, "St. Pierre and Miquelon" },
                    { new Guid("78dcfd52-de7b-4c1d-9ded-0e5d3f7a8a35"), "MT", "208", false, "Malta" },
                    { new Guid("79bc1ba0-a0f6-4065-9783-9e01ade32cde"), "PN", "PN", false, "Pitcairn" },
                    { new Guid("7a384197-d55e-44b8-b389-a65f17e74e1f"), "PH", "242", false, "Philippines" },
                    { new Guid("7af80a81-41e5-47de-abd3-7ce25f9c39b4"), "TM", "282", false, "Turkmenistan" },
                    { new Guid("7afaefc0-9aa8-4ba7-98ae-618682a5be7f"), "KM", "143", false, "Comoros" },
                    { new Guid("7b0c9a9c-e730-4b96-9372-e9ef8ab5339b"), "BM", "BM", false, "Bermuda" },
                    { new Guid("7bea406c-221d-45dd-aca6-a2ceb90741aa"), "DM", "151", false, "Dominica" },
                    { new Guid("7e27cb42-41fb-4b20-b26b-3c1ea9b4ff5c"), "SB", "260", false, "Solomon" },
                    { new Guid("7ef68b6d-2d6b-4688-95bc-d0fd79ffb6c5"), "CY", "191", false, "Síp" },
                    { new Guid("7f233816-fe94-4941-8125-b62c88410fa9"), "BD", "119", false, "Bangladesh" },
                    { new Guid("8562fd7f-49aa-46cf-bbc9-71f7460c6ba7"), "SZ", "265", false, "Swaziland" },
                    { new Guid("8592d87f-720b-48e7-82ee-e82d64cbf984"), "AG", "108", false, "Antigua và Barbuda" },
                    { new Guid("8764ee96-c950-44cf-a1f4-7636126c671b"), "BS", "116", false, "Bahamas" },
                    { new Guid("882c80ef-806d-4370-9fb1-f00a13a7a5c1"), "LV", "194", false, "Latvia" },
                    { new Guid("8a003437-323c-451c-b211-1886f79c25f1"), "MV", "206", false, "Maldives" },
                    { new Guid("8a6a8442-1533-4bba-9a05-ed707122573e"), "GR", "178", false, "Hy Lạp" },
                    { new Guid("8f800608-e254-418d-8163-78f71be4873f"), "EG", "102", false, "Ai Cập" },
                    { new Guid("8ff51ea0-476b-4dec-8736-70cc36ea1d2c"), "NO", "225", false, "Na Uy" },
                    { new Guid("90b2a6a0-bacd-4175-80e9-b8fde9233786"), "KW", "190", false, "Kuwait" },
                    { new Guid("90ef0553-8520-4d57-ae3b-112ebf28b313"), "ZW", "295", false, "Zimbabwe" },
                    { new Guid("92aea1da-5cf2-40fa-92a2-cce297949451"), "SI", "259", false, "Slovenia" },
                    { new Guid("92b69f82-f3e2-4ea9-9d4b-1763b1a75dec"), "MX", "213", false, "Mexico" },
                    { new Guid("93fc49be-bd23-41c3-8538-4b424a7806da"), "CV", "CV", false, "Cape verde" },
                    { new Guid("9412c9e0-c4fe-442f-8b13-ea064bf48703"), "LI", "199", false, "Liechtenstein" },
                    { new Guid("9601fc62-41b1-44af-af8e-8a03c91c96b8"), "JP", "232", false, "Nhật Bản" },
                    { new Guid("97bc234b-7d4c-4870-801b-74f1998741be"), "US", "175", false, "Hoa Kỳ" },
                    { new Guid("98062645-5015-4d8c-886e-3fb70c247ada"), "GP", "GP", false, "Guadeloupe" },
                    { new Guid("994cf06f-b833-4415-84e0-94f3847b6dd8"), "KY", "KY", false, "Cayman islands" },
                    { new Guid("99cfce62-6540-4525-97b8-9a2e62618e05"), "SJ", "SJ", false, "Svalbard and Jan Mayen Islands" },
                    { new Guid("9acb769e-d2de-479c-b66a-424ce710a036"), "NG", "230", false, "Nigeria" },
                    { new Guid("9d5769fe-b3ae-4697-9150-44674e8008ba"), "DE", "155", false, "Đức" },
                    { new Guid("9ded845f-06a1-4651-8903-bc46f7978c84"), "GE", "GE", false, "Georgia" },
                    { new Guid("9eb57842-f592-4080-affd-71b43f7d0517"), "AQ", "AQ", false, "Antarctica" },
                    { new Guid("9ee7b166-4c6f-4136-8928-c6246c3e76d5"), "UZ", "288", false, "Uzbekistan" },
                    { new Guid("a1080c01-e5bb-4e3f-8784-f0678f1eff58"), "DJ", "150", false, "Djibouti" },
                    { new Guid("a1ba5be8-fef9-470a-a5f7-efcf7fc900a4"), "ME", "218", false, "Montenegro" },
                    { new Guid("a1f120ed-4785-486e-b796-dd8cd569a415"), "VC", "248", false, "Saint Vincent và Grenadines" },
                    { new Guid("a30f588b-166d-4118-9d33-b8294e15ad44"), "SD", "263", false, "Sudan" },
                    { new Guid("a3597652-cc84-40ff-b143-208ee8473e93"), "EA", "154", false, "Đông Timor" },
                    { new Guid("a3c5c224-a013-4e23-8655-641a0a76b38a"), "PW", "235", false, "Palau" },
                    { new Guid("a695b824-cfc2-40a3-b5a1-35243a6e2116"), "YE", "293", false, "Yemen" },
                    { new Guid("a7a696de-3fd8-48c2-b87a-6464b222af87"), "VE", "291", false, "Venezuela" },
                    { new Guid("a8b38e56-d3ea-435f-907a-615ed7ced805"), "AF", "101", false, "Afghanistan" },
                    { new Guid("aa3d56b9-f398-4be1-b8ae-9f8563101b6e"), "IT", "292", false, "Ý" },
                    { new Guid("aa4399ec-1ff3-4837-a68e-0df0720162cb"), "MR", "211", false, "Mauritanie" },
                    { new Guid("aa745539-b444-49d2-ad13-14149f8a1645"), "BO", "126", false, "Bolivia" },
                    { new Guid("ab16a3ed-00cd-4445-8e7c-770b1965232e"), "NL", "173", false, "Hà Lan" },
                    { new Guid("abdfeb5b-a4b8-4ab1-b6b8-83f7fb72ec23"), "EE", "159", false, "Estonia" },
                    { new Guid("ad4ef5f1-e823-4ed4-9ad5-cec4a2cae6af"), "UG", "285", false, "Uganda" },
                    { new Guid("af24512b-01ae-4420-96cb-62051ede96cc"), "UA", "286", false, "Ukraina" },
                    { new Guid("af3badc9-b6da-4eb0-8a42-ecf8dfd6ae19"), "AM", "112", false, "Armenia" },
                    { new Guid("af9c2425-679e-4459-8c68-2d357f4f93e5"), "PY", "238", false, "Paraguay" },
                    { new Guid("affdf19e-5ed4-497a-97d0-0fc95a547785"), "LK", "262", false, "Sri Lanka" },
                    { new Guid("b16a509f-5c70-42b1-a05e-6d4426c721ca"), "IQ", "182", false, "Iraq" },
                    { new Guid("b171e933-4b7d-46f5-802a-14c5c9234ed7"), "ML", "207", false, "Mali" },
                    { new Guid("b1829e62-c3dd-4f65-8c41-fdbe26aedb93"), "MG", "203", false, "Madagascar" },
                    { new Guid("b4e019b1-042b-465c-baf9-60d525d9b85c"), "CK", "CK", false, "Cook islands" },
                    { new Guid("b6169a90-920f-425d-a275-82601862a220"), "SK", "258", false, "Slovakia" },
                    { new Guid("b83926c4-6963-4f82-97f7-dffa6e87ea7d"), "MK", "202", false, "Macedonia" },
                    { new Guid("b83be42b-cde9-4dc3-a838-d8197d2c678f"), "FO", "FO", false, "Faroe islands" },
                    { new Guid("ba7304bd-7e25-4731-a60f-10c13589c71a"), "ET", "160", false, "Ethiopia" },
                    { new Guid("ba947c48-36fb-420b-b2d9-663fe308b18c"), "TG", "275", false, "Togo" },
                    { new Guid("bcb96598-0e05-4316-86d3-80413326555a"), "MH", "210", false, "Quần đảo Marshall" },
                    { new Guid("be946a16-a1af-499c-9bd8-ca12a22fb69c"), "CU", "149", false, "Cuba" },
                    { new Guid("bf1bf333-4604-4974-838f-886100c006f3"), "TW", "TW", false, "Đài Loan" },
                    { new Guid("c4065df0-2539-4046-bb77-7d699a072734"), "FM", "214", false, "Micronesia" },
                    { new Guid("c5c14db2-753f-4e28-88b5-3b9e502fa0c6"), "BN", "132", false, "Brunei" },
                    { new Guid("c6f6287f-39f6-4470-ad46-ac539eef3052"), "EC", "156", false, "Ecuador" },
                    { new Guid("c7f500b0-be15-4ab8-ae5c-1db430d19b8c"), "YT", "YT", false, "Mayotte" },
                    { new Guid("c831fb16-910b-4939-804a-1052b8f8adc1"), "HT", "172", false, "Haiti" },
                    { new Guid("c8766416-ed13-4631-a9c4-e89e782055c9"), "Z7", "Z7", false, "Wales" },
                    { new Guid("cba207c9-9ee4-4a20-876b-ecb1160d0845"), "SN", "253", false, "Sénégal" },
                    { new Guid("cbf1c521-494b-4981-9dc9-b6a1b229c01d"), "JM", "185", false, "Jamaica" },
                    { new Guid("cc2a4d3b-bae2-4602-9d23-4d4d2d918699"), "MD", "215", false, "Moldova" },
                    { new Guid("cdd52492-d981-4972-9f41-4b1774c002ee"), "GI", "GI", false, "Gibraltar" },
                    { new Guid("cf8c2ebc-2ed1-404c-875c-d2151d54ab9e"), "MM", "220", false, "Myanma" },
                    { new Guid("d0357290-582a-47cd-984c-8815d38454be"), "Z5", "Z5", false, "Northern Ireland" },
                    { new Guid("d1fef153-87bc-403a-9590-0ec4cc8d676e"), "PL", "118", false, "Ba Lan" },
                    { new Guid("d200b4b5-7435-41a9-be8b-b6a80e14120b"), "IO", "IO", false, "British indian ocean territory" },
                    { new Guid("d2ebac27-3463-40cb-9eb2-86e1da12a3ba"), "MS", "MS", false, "Montserrat" },
                    { new Guid("d34d65e5-253f-4324-9aee-f74045802e47"), "GG", "GG", false, "Guernsey" },
                    { new Guid("d3c10501-b94f-4a0e-b871-80d4b3d7bbbb"), "HK", "HK", false, "Hong kong" },
                    { new Guid("d50a063a-82ef-4b56-858e-1a8794b32878"), "HN", "176", false, "Honduras" },
                    { new Guid("d576474f-de6a-45fc-bd19-e18a2915f1a4"), "CR", "146", false, "Costa Rica" },
                    { new Guid("d892c6c0-bf86-4487-ab8b-5af35cc32a0c"), "GV", "171", false, "Guyana" },
                    { new Guid("d94b5935-e6d2-4aa7-b9f7-d332badacd8d"), "BT", "124", false, "Bhutan" },
                    { new Guid("da333d92-e16c-4b49-b9d8-669df9032f82"), "FJ", "161", false, "Fiji" },
                    { new Guid("dd79ead4-6e12-4cb8-aff5-8f00d8bf9e99"), "SD", "222", false, "Nam Sudan" },
                    { new Guid("dd951a03-c803-4351-aac5-ed4ec9922bab"), "QA", "243", false, "Qatar" },
                    { new Guid("ddf4ecad-6f97-4bde-84fe-2b9dc51f0ffd"), "BW", "128", false, "Botswana" },
                    { new Guid("de0d7be8-8a87-4358-b93e-e809ab17f238"), "RO", "244", false, "Romania" },
                    { new Guid("e180ff8a-4e49-4edd-9168-21b372b8d9b7"), "BG", "133", false, "Bulgaria" },
                    { new Guid("e1fc9395-73b5-4fd6-8c31-37fef3a3e866"), "ZM", "294", false, "Zambia" },
                    { new Guid("e369137c-1730-4809-88e4-e43031327233"), "BF", "134", false, "Burkina Faso" },
                    { new Guid("e3a2237c-9d57-462f-bad8-7a78856303c8"), "ID", "180", false, "Indonesia" },
                    { new Guid("e43c3f5c-e8d7-430a-9869-e61337bd4188"), "Z2", "Z2", false, "British Southern and Antarctic Territories" },
                    { new Guid("e4acc3fd-7e2d-4927-b7e8-797cb8a29a86"), "GU", "GU", false, "Guam" },
                    { new Guid("e4c05566-0c8d-42a4-a2e9-ad4d6d33b35f"), "AI", "AI", false, "Anguilla" },
                    { new Guid("e5439053-279d-4094-852d-0c2edc6992ed"), "SV", "157", false, "El Salvador" },
                    { new Guid("e5837adb-d926-41f1-8434-73fed9db7504"), "AW", "AW", false, "Aruba việt nam" },
                    { new Guid("e6e7518f-73eb-4010-b0cf-6dcc5c8f8e01"), "DZ", "104", false, "Algérie" },
                    { new Guid("e9455b51-bd57-482f-a979-5ecf6c8c4afd"), "GB", "107", false, "Vương quốc Liên hiệp Anh và Bắc Ireland" },
                    { new Guid("edb5a6e1-b084-4e46-87ab-22d38da9cf0a"), "UY", "287", false, "Uruguay" },
                    { new Guid("edcecb3c-ffcb-451f-8e24-02a0bf6499ae"), "IN", "115", false, "Cộng hòa Ấn Độ" },
                    { new Guid("ee02aa87-f8dc-44ac-9ac9-830120f05656"), "TR", "272", false, "Thổ Nhĩ Kỳ" },
                    { new Guid("ee707e39-4195-426c-abf9-1ce21a771350"), "NA", "221", false, "Namibia" },
                    { new Guid("f034e368-335c-4a9f-a039-b7ea83f8a315"), "LU", "201", false, "Luxembourg" },
                    { new Guid("f07d3dde-aea1-4f0a-ba9d-310cda4fa6e9"), "TH", "271", false, "Thái Lan" },
                    { new Guid("f1218849-b5cf-43c8-b3c4-b1ff145f27fc"), "MU", "212", false, "Mauritius" },
                    { new Guid("f1c02c7d-3154-4e55-817c-1e24f6eef729"), "GA", "162", false, "Gabon" },
                    { new Guid("f21a86da-a1de-4023-93c9-3a23d315a8cd"), "RW", "245", false, "Rwanda" },
                    { new Guid("f36eb030-510e-4ca0-b7c4-a1c1ef656dd6"), "FK", "FK", false, "Falkland islands (malvinas)" },
                    { new Guid("f468cb27-57fb-4b75-b3b7-70bb33ca2705"), "KH", "139", false, "Campuchia" },
                    { new Guid("f5874f17-6c1e-4c07-b8bf-41b76546f6f0"), "CM", "138", false, "Cameroon" },
                    { new Guid("f5f9c1ed-f4fb-4cff-aee3-2bcb0d8eed3e"), "NC", "NC", false, "New Caledonia" },
                    { new Guid("f5fdcb6c-e0c5-4a57-adca-e743ba60ccee"), "LY", "198", false, "Libya" },
                    { new Guid("f79baaf7-6191-4ba9-b38a-2f1b50d05598"), "TV", "283", false, "Tuvalu" },
                    { new Guid("f9375017-9897-4487-8916-c98d22fd05b9"), "GL", "GL", false, "Greenland" },
                    { new Guid("fb10ce71-e68a-4a70-bf7e-5edee9388d48"), "AE", "137", false, "Các Tiểu Vương quốc Ả Rập Thống nhất" },
                    { new Guid("fb67b422-6903-494e-945d-fa09f031b4f1"), "VI", "VI", false, "Virgin Islands (U.S.)" },
                    { new Guid("fc5a0c05-ebac-4906-8a9f-dddcdbcc0a9d"), "AU", "284", false, "Úc" },
                    { new Guid("fd0ac376-bf65-4bf8-9067-245691aa1827"), "HR", "147", false, "Croatia" },
                    { new Guid("fd21963c-7b5e-44a8-8d70-2edbda437946"), "MN", "217", false, "Mông Cổ" },
                    { new Guid("fd235817-1607-4f4c-83c7-ff5bd0012896"), "BJ", "123", false, "Benin" },
                    { new Guid("fd32d265-24dd-4073-a4b8-59e6358b59ed"), "AR", "111", false, "Argentina" },
                    { new Guid("fe657d37-7960-4bb3-8f15-81666fca928d"), "EH", "EH", false, "Western sahara" },
                    { new Guid("ff78779a-45cd-4076-8c61-442a9a3873f2"), "TZ", "268", false, "Tanzania" },
                    { new Guid("ffd3fabd-a5f1-4442-837b-d53b5d89272e"), "WF", "WF", false, "Wallis and Futuna Islands" }
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
                    { new Guid("97ac7fd8-edfa-4243-97fc-98468f492df1"), "KXD", null, new DateTime(2023, 8, 4, 0, 50, 23, 556, DateTimeKind.Local).AddTicks(631), null, false, null, null, "Chưa xác định", 0 },
                    { new Guid("e9497984-d355-41af-b917-091500956be9"), "NU", null, new DateTime(2023, 8, 4, 0, 50, 23, 556, DateTimeKind.Local).AddTicks(665), null, false, null, null, "Nữ", 2 },
                    { new Guid("fc153433-bf89-4e95-8523-df3d8cec8676"), "NAM", null, new DateTime(2023, 8, 4, 0, 50, 23, 556, DateTimeKind.Local).AddTicks(662), null, false, null, null, "Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "SMedicineGroups",
                columns: new[] { "Id", "Code", "Inactive", "IsSystem", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("00be783e-d679-4f1c-9ae2-a4f4c79de0ef"), "TKSV", false, true, "Thuốc kháng sinh viên", 4 },
                    { new Guid("05a24915-0bed-4f61-b53d-b5e52482e44c"), "TK", false, true, "Thuốc khác", 21 },
                    { new Guid("25454ce7-bff0-4fd5-a47a-069554c1535a"), "VC", false, true, "Vaccine", 19 },
                    { new Guid("2f5148cb-8adf-45ec-88ee-f84530cfa164"), "THTT", false, true, "Thuốc hướng tâm thần", 10 },
                    { new Guid("2fd41f93-ddb9-47dd-9833-4507ce71128c"), "TV", false, true, "Thuốc viên", 1 },
                    { new Guid("3144745c-477c-4ce2-9c33-a38eb2153057"), "SP", false, true, "Sinh phẩm", 18 },
                    { new Guid("31d26ca7-2b5f-4dfd-b961-f3609e6a0b69"), "TCO", false, true, "Nhóm thuốc corticoid", 12 },
                    { new Guid("35df3868-8db6-440d-809f-f4c345d804a7"), "TS", false, true, "Thuốc siro", 6 },
                    { new Guid("6375b8a1-b6e7-4724-a1b4-8cc3acc98e43"), "KCVI", false, true, "Khoáng chất và Vitamin", 5 },
                    { new Guid("8590ae3d-351c-4438-bfe5-3f69dcf97349"), "TB", false, true, "Thuốc bột", 8 },
                    { new Guid("914ca65d-6579-4590-b963-fee8a743bae1"), "DC", false, true, "Dịch truyền", 3 },
                    { new Guid("9e144dff-29f6-47da-b7ed-b55abd1a2cd3"), "VTNT", false, true, "Vật tư nhà thuốc", 20 },
                    { new Guid("a28fb46e-e9b9-410e-9c31-d8ebfd22015c"), "TKTT", false, true, "Thuốc kê tự túc", 16 },
                    { new Guid("ae04abd7-d012-470d-9b8a-f38d9c5c94a8"), "TG", false, true, "Thuốc gói", 14 },
                    { new Guid("b5f03233-d733-4349-93df-db562b7d4376"), "THD", false, true, "Thuốc hỗn dịch", 6 },
                    { new Guid("c987b9d2-e599-49cc-99f3-d075d27cee7c"), "TDY", false, true, "Thuốc đông y", 5 },
                    { new Guid("cc48bb40-fbf0-4054-818c-eb49545aaeea"), "TDN", false, true, "Thuốc dùng ngoài", 7 },
                    { new Guid("cd5d7538-b1d2-448d-b6ff-c139c35f9dc7"), "TGTM", false, true, "Thuốc gây tê, mê", 13 },
                    { new Guid("ddf105e8-6534-46e4-832b-598daa84c4d5"), "TGN", false, true, "Thuốc gây nghiện", 9 },
                    { new Guid("e47ab5de-9ea5-4075-8da5-7ae9f36538e2"), "TUT", false, true, "Thuốc ung thư", 15 },
                    { new Guid("e482e866-9243-49d8-8676-403377de353c"), "TKSO", false, true, "Thuốc kháng sinh ống", 11 },
                    { new Guid("ea57a262-6647-4e88-880c-82bc4227e916"), "TNM", false, true, "Thuốc nhỏ mắt", 17 },
                    { new Guid("ff9be71e-a958-4244-9df1-1582229c67d5"), "TU", false, true, "Thuốc uống", 2 }
                });

            migrationBuilder.InsertData(
                table: "SMedicineLines",
                columns: new[] { "Id", "Code", "Inactive", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("03bd1fdc-d2b8-4969-a029-5022ca68f31e"), "1.02", false, "Ngậm", 2 },
                    { new Guid("05a24915-0bed-4f61-b53d-b5e52482e44c"), "1.01", false, "Uống", 1 },
                    { new Guid("08f7b3c2-09da-4b4a-9c98-75c8562807ee"), "6.09", false, "Dung dịch", 44 },
                    { new Guid("0c8ba522-0e4b-40a0-9d93-936f5350853e"), "5.08", false, "Xịt họng", 38 },
                    { new Guid("0df82239-15dd-41ee-afc8-67cb51d5f3f6"), "5.03", false, "Bột hít", 33 },
                    { new Guid("13165217-8025-44e0-a92b-1f8318d56282"), "2.13", false, "Tiêm vào khối u", 18 },
                    { new Guid("1ef26d8f-57d7-423c-a8c6-e3a20a249b37"), "6.01", false, "Nhỏ mũi", 40 },
                    { new Guid("229172a9-7464-4216-8b11-4e587e4c280c"), "5.01", false, "Phun mù", 31 },
                    { new Guid("2bd555b2-74ae-4b3f-9d27-de30e10bf16f"), "3.01", false, "Bôi", 21 },
                    { new Guid("2f6e29a1-9a1f-44b0-8f9e-ea1c8716c23b"), "2.10", false, "Tiêm", 15 },
                    { new Guid("379c8a46-145d-4956-af5d-2d48d9d55087"), "6.03", false, "Tra mắt", 42 },
                    { new Guid("3df25942-afc9-4ed5-88b3-a0ff7b0ad968"), "4.02", false, "Đặt hậu môn", 26 },
                    { new Guid("41c24ffd-81f8-44f4-92f7-b3e5d418c8c7"), "2.15", false, "Tiêm truyền", 20 },
                    { new Guid("49783593-80ca-4a9f-8ff9-5d359307498c"), "4.03", false, "Thụt hậu môn - trực tràng", 27 },
                    { new Guid("5a807206-9aef-481d-87b6-88f464e6fd46"), "3.04", false, "Xịt ngoài da", 24 },
                    { new Guid("5d6b6689-0dc3-4f11-94ef-02d288cce18a"), "2.03", false, "Tiêm trong da", 8 },
                    { new Guid("5eada7db-843c-453b-8a44-3de2dacaa27b"), "1.05", false, "Ngậm dưới lưỡi", 5 },
                    { new Guid("5ef14843-323d-4fe9-a424-46ca3120fca9"), "2.02", false, "Tiêm dưới da", 7 },
                    { new Guid("60f3158e-73f2-453f-af90-072b6b25c644"), "3.05", false, "Dùng ngoài", 1 },
                    { new Guid("65ca8fd8-fb9b-4dea-9c0e-c9a3b6b8fbd8"), "2.11", false, "Tiêm động mạch khối u", 16 },
                    { new Guid("6cdf2301-9621-4f73-9c62-f48ab80245c8"), "5.02", false, "Dạng hít", 32 },
                    { new Guid("6edba7a9-20fe-49c0-9925-ba3b32ed32a0"), "2.14", false, "Tiêm truyền tĩnh mạch", 19 },
                    { new Guid("6f90ecfe-4ede-4241-918b-b18245208f56"), "2.01", false, "Tiêm bặp", 6 },
                    { new Guid("71edc6f8-3db6-4375-9005-c5328627fa28"), "3.03", false, "Dán trên da", 23 },
                    { new Guid("75017c25-2ad7-4cce-b206-38735fd3584d"), "3.02", false, "Xoa ngoài", 22 },
                    { new Guid("7990c54f-dc34-4a62-a8da-201d22c1069d"), "4.05", false, "Đặt tử cung", 29 },
                    { new Guid("7b3a86dc-9b0c-43f8-94a9-e4eec9916e30"), "5.09", false, "Thuốc mũi", 39 },
                    { new Guid("7d92b632-0ccf-4be5-a044-c3ee549fdb9f"), "6.04", false, "Nhỏ tai", 43 },
                    { new Guid("8d9cd0b1-2407-4cc3-9d94-314602e26508"), "5.07", false, "Xịt mũi", 37 },
                    { new Guid("8f65d7cf-bbd9-44f4-b556-20472aa4a5f0"), "4.06", false, "Thụt", 30 },
                    { new Guid("a26814e4-da59-4317-a297-5ca089ef2dad"), "1.04", false, "Đặt dưới lưỡi", 4 },
                    { new Guid("a29889f5-4943-4520-85fa-441c3ea9e979"), "1.03", false, "Nhai", 3 },
                    { new Guid("b12f310c-c12a-4f8f-a9bd-ddd38b4eebcf"), "5.06", false, "Đường hô hấp", 36 },
                    { new Guid("c0097373-f633-4bee-b670-2d2c35b5d172"), "2.12", false, "Tiêm vào khoang tự nhiên", 17 },
                    { new Guid("c6ffa735-8813-41ea-8984-5700dbee1ea7"), "2.09", false, "Tiêm vào các khoang của cơ thế", 14 },
                    { new Guid("ca37423b-25c7-4a84-a32d-8767bf14352b"), "5.04", false, "Xịt", 34 },
                    { new Guid("cae9f723-e795-48d5-9730-f19edceaa5b6"), "2.04", false, "Tiêm tĩnh mạch", 9 },
                    { new Guid("cb51640d-bd7e-4cba-b64d-191d4162efa4"), "4.01", false, "Đặt âm đạo", 25 },
                    { new Guid("d075055e-4ed2-4d37-82ae-c9c20cb4f08f"), "2.06", false, "Tiêm vào ổ khớp", 11 },
                    { new Guid("d36d932c-00db-451d-9a02-a401dbd89408"), "2.07", false, "Tiêm nội nhãn cầu", 12 },
                    { new Guid("d558492b-6628-40ca-aadf-5dda7701681a"), "4.04", false, "Đặt", 28 },
                    { new Guid("d81efde6-f750-4a66-adf3-a9092bb8ea9b"), "5.05", false, "Khí dung", 35 },
                    { new Guid("e485d3cc-5a96-48c9-9ed3-8725bb0136ef"), "6.02", false, "Nhỏ mắt", 41 },
                    { new Guid("e578f37b-9f1b-4098-8659-ac510ced491a"), "2.08", false, "Tiêm trong dịch kích của mắt", 13 },
                    { new Guid("febb52a6-15bc-4e28-bc84-e928b43b126b"), "2.05", false, "Tiêm truyền tĩnh mạch", 10 }
                });

            migrationBuilder.InsertData(
                table: "SPatientTypes",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "BHYT", null, new DateTime(2023, 8, 4, 0, 50, 23, 556, DateTimeKind.Local).AddTicks(1938), null, false, null, null, "Bảo hiểm y tế", 0 },
                    { 2, "VP", null, new DateTime(2023, 8, 4, 0, 50, 23, 556, DateTimeKind.Local).AddTicks(1942), null, false, null, null, "Viện phí", 0 },
                    { 3, "DV", null, new DateTime(2023, 8, 4, 0, 50, 23, 556, DateTimeKind.Local).AddTicks(1943), null, false, null, null, "Dịch vụ", 0 }
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
                    { 9, "KHO-NgT", null, false, "Kho thuốc ngoại trú", 9 },
                    { 10, "KHO-NT", null, false, "Kho thuốc nội trú", 10 },
                    { 11, "TT-TH", null, false, "Tủ trực thuốc", 11 },
                    { 12, "KHO-VTYT", null, false, "Kho vật tự y tế", 12 },
                    { 13, "KHO-MAU", null, false, "Kho máu", 13 },
                    { 14, "TT-VT", null, false, "Tủ trực VTYT", 14 },
                    { 15, "QLT", null, false, "Quản lý thuốc", 15 },
                    { 16, "QLVT", null, false, "Quản lý vật tư", 16 }
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
                table: "SUnits",
                columns: new[] { "Id", "Code", "Inactive", "Name", "SortOrder", "UnitType" },
                values: new object[,]
                {
                    { new Guid("0762aebf-cbb8-4102-b923-a30df490f75d"), "6", false, "Hộp", 6, 0 },
                    { new Guid("2198d1c0-57fa-453f-b605-9cef55929067"), "CUON", false, "Cuộn", 9, 0 },
                    { new Guid("3be8bc27-3940-451c-87f5-c062df716872"), "GAM", false, "Gam", 12, 0 },
                    { new Guid("44ab6ffc-f1a9-47d0-90ab-9f09d767c286"), "ONG", false, "Ống", 5, 0 },
                    { new Guid("46ea45ff-ba5e-4f6f-bbc6-ebe65446efe8"), "GAM", false, "Gam", 20, 0 },
                    { new Guid("49793db4-c0ce-43c1-b439-eacd554fa06e"), "MET", false, "Met", 14, 0 },
                    { new Guid("6cc9258a-5f48-4c22-8cd6-61c0795f5405"), "LAN", false, "Lần", 2, 0 },
                    { new Guid("7a0fed4a-e62a-4e9f-8e92-7332127ca248"), "TUB", false, "Tub", 7, 0 },
                    { new Guid("8d7a7b33-f2ed-4b4b-a869-3ad32fd9d192"), "TUI", false, "Túi", 17, 0 },
                    { new Guid("9e12370e-b3ce-4862-8e7d-83d8f7ec56d1"), "LIT", false, "Lít", 11, 0 },
                    { new Guid("9ff4f404-68bd-4780-99bc-1033227cbe3d"), "GOI", false, "Gói", 8, 0 },
                    { new Guid("a7e37e54-47b8-4716-b493-b657d4981e35"), "MINI", false, "Minimet", 15, 0 },
                    { new Guid("ae0ece26-bb4c-4b23-95cb-1a5d66114634"), "LO", false, "Lọ", 3, 0 },
                    { new Guid("bf42cbf7-b5ac-4503-b73d-d91f4051fa8f"), "ML", false, "ml", 10, 0 },
                    { new Guid("c587599c-a6a6-454f-8e30-2a92dac6f588"), "VIEN", false, "Viên", 1, 0 },
                    { new Guid("cc8713c1-536a-4835-bd7e-187603566f95"), "KG", false, "Kg", 13, 0 },
                    { new Guid("da514a31-4dfc-4445-99bd-4ae29359ad48"), "TUYT", false, "Tuýt", 4, 0 },
                    { new Guid("e04b1f07-6f05-403e-ac09-b999cac0df3e"), "CAI", false, "Cái", 18, 0 },
                    { new Guid("e46826b4-76f9-4b32-84b3-b9730e732839"), "CHIEC", false, "Chiếc", 19, 0 },
                    { new Guid("fc7acf3a-2c10-4200-9448-c3180c0a4400"), "MIENG", false, "Miếng", 21, 0 },
                    { new Guid("fd96bad9-b254-4b37-8eb9-ada68fe7dada"), "CHAI", false, "Chai", 16, 0 }
                });

            migrationBuilder.InsertData(
                table: "SUsers",
                columns: new[] { "Id", "Address", "DistrictId", "Dob", "Email", "FirstName", "GenderId", "LastName", "Password", "PhoneNumber", "ProvinceId", "Status", "UseType", "UserName", "WardId" },
                values: new object[] { new Guid("3382be1c-2836-4246-99db-c4e1c781e868"), null, null, null, "administrator@gmail.com", "Admin", null, "Administrator", "79956B61E1B250869A6716CE37EFD6E6", null, null, 1, 0, "Administrator", null });

            migrationBuilder.CreateIndex(
                name: "IX_DImMests_ApproverUserId",
                table: "DImMests",
                column: "ApproverUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DImMests_ExStockId",
                table: "DImMests",
                column: "ExStockId");

            migrationBuilder.CreateIndex(
                name: "IX_DImMests_ImExMestTypeId",
                table: "DImMests",
                column: "ImExMestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DImMests_ImStockId",
                table: "DImMests",
                column: "ImStockId");

            migrationBuilder.CreateIndex(
                name: "IX_DImMests_PatientId",
                table: "DImMests",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_DImMests_ReceiverUserId",
                table: "DImMests",
                column: "ReceiverUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DImMests_ReqDepartmentId",
                table: "DImMests",
                column: "ReqDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DImMests_ReqRoomId",
                table: "DImMests",
                column: "ReqRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_DImMests_SupplierId",
                table: "DImMests",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_DImMests_TreatmentId",
                table: "DImMests",
                column: "TreatmentId");

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
                name: "IX_SMaterials_UnitId",
                table: "SMaterials",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SMaterialTypes_ServiceId",
                table: "SMaterialTypes",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SMaterialTypes_ServiceUnitId",
                table: "SMaterialTypes",
                column: "ServiceUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicinePricePolicy_SMedicineId",
                table: "SMedicinePricePolicy",
                column: "SMedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicinePricePolicy_SPatientTypeId",
                table: "SMedicinePricePolicy",
                column: "SPatientTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicines_CountryId",
                table: "SMedicines",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicines_MedicineLineId",
                table: "SMedicines",
                column: "MedicineLineId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicines_MedicineTypeId",
                table: "SMedicines",
                column: "MedicineTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicines_SServiceId",
                table: "SMedicines",
                column: "SServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicines_UnitId",
                table: "SMedicines",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicineTypes_CountryId",
                table: "SMedicineTypes",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicineTypes_MedicineGroupId",
                table: "SMedicineTypes",
                column: "MedicineGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicineTypes_MedicineLineId",
                table: "SMedicineTypes",
                column: "MedicineLineId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicineTypes_SServiceId",
                table: "SMedicineTypes",
                column: "SServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicineTypes_UnitId",
                table: "SMedicineTypes",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SPatients_GenderId",
                table: "SPatients",
                column: "GenderId");

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
                name: "IX_SServiceResultIndices_SServiceId",
                table: "SServiceResultIndices",
                column: "SServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SServices_ServiceGroupHeInId",
                table: "SServices",
                column: "ServiceGroupHeInId");

            migrationBuilder.CreateIndex(
                name: "IX_SServices_ServiceGroupId",
                table: "SServices",
                column: "ServiceGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_SServices_SurgicalProcedureTypeId",
                table: "SServices",
                column: "SurgicalProcedureTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SServices_UnitId",
                table: "SServices",
                column: "UnitId");

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
                name: "DImMests");

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
                name: "SMedicinePricePolicy");

            migrationBuilder.DropTable(
                name: "SRolePermissionBranchs");

            migrationBuilder.DropTable(
                name: "SServicePricePolicies");

            migrationBuilder.DropTable(
                name: "SServiceResultIndices");

            migrationBuilder.DropTable(
                name: "STokens");

            migrationBuilder.DropTable(
                name: "SUserRoles");

            migrationBuilder.DropTable(
                name: "SWards");

            migrationBuilder.DropTable(
                name: "DImExMestTypes");

            migrationBuilder.DropTable(
                name: "SPatients");

            migrationBuilder.DropTable(
                name: "SSupplier");

            migrationBuilder.DropTable(
                name: "STreatments");

            migrationBuilder.DropTable(
                name: "SRooms");

            migrationBuilder.DropTable(
                name: "SMaterialTypes");

            migrationBuilder.DropTable(
                name: "SMedicines");

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
                name: "SGenders");

            migrationBuilder.DropTable(
                name: "SDepartments");

            migrationBuilder.DropTable(
                name: "SRoomTypes");

            migrationBuilder.DropTable(
                name: "SMedicineTypes");

            migrationBuilder.DropTable(
                name: "SProvinces");

            migrationBuilder.DropTable(
                name: "SBranchs");

            migrationBuilder.DropTable(
                name: "SDepartmentTypes");

            migrationBuilder.DropTable(
                name: "SMedicineGroups");

            migrationBuilder.DropTable(
                name: "SMedicineLines");

            migrationBuilder.DropTable(
                name: "SServices");

            migrationBuilder.DropTable(
                name: "SCountries");

            migrationBuilder.DropTable(
                name: "SServiceGroupHeIns");

            migrationBuilder.DropTable(
                name: "SServiceGroups");

            migrationBuilder.DropTable(
                name: "SSurgicalProcedureTypes");

            migrationBuilder.DropTable(
                name: "SUnits");
        }
    }
}
