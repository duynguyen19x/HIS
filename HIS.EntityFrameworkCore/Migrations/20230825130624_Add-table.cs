using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Addtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branchs",
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
                    table.PrimaryKey("PK_Branchs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Careers",
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
                    table.PrimaryKey("PK_Careers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChapterIcds",
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
                    table.PrimaryKey("PK_ChapterIcds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HeInCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentTypes",
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
                    table.PrimaryKey("PK_DepartmentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ethnics",
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
                    table.PrimaryKey("PK_Ethnics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
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
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hospitals",
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
                    table.PrimaryKey("PK_Hospitals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InOutStockTypes",
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
                    table.PrimaryKey("PK_InOutStockTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicineGroups",
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
                    table.PrimaryKey("PK_MedicineGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicineLines",
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
                    table.PrimaryKey("PK_MedicineLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
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
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
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
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
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
                    table.PrimaryKey("PK_RoomTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceGroupHeIns",
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
                    table.PrimaryKey("PK_ServiceGroupHeIns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceGroups",
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
                    table.PrimaryKey("PK_ServiceGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    TaxCode = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurgicalProcedureTypes",
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
                    table.PrimaryKey("PK_SurgicalProcedureTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SYSRefTypeCategories",
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
                    table.PrimaryKey("PK_SYSRefTypeCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
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
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
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
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Icds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChapterIcdId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_Icds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Icds_ChapterIcds_ChapterIcdId",
                        column: x => x.ChapterIcdId,
                        principalTable: "ChapterIcds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
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
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Provinces_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Departments",
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
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Branchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branchs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Departments_DepartmentTypes_DepartmentTypeId",
                        column: x => x.DepartmentTypeId,
                        principalTable: "DepartmentTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RolePermissionBranchs",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissionBranchs", x => new { x.RoleId, x.PermissionId });
                    table.ForeignKey(
                        name: "FK_RolePermissionBranchs_Branchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branchs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RolePermissionBranchs_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RolePermissionBranchs_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
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
                        name: "FK_SYSAutoNumbers_Branchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branchs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SYSAutoNumbers_SYSRefTypeCategories_RefTypeCategoryId",
                        column: x => x.RefTypeCategoryId,
                        principalTable: "SYSRefTypeCategories",
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
                        name: "FK_SYSRefTypes_SYSRefTypeCategories_RefTypeCategoryId",
                        column: x => x.RefTypeCategoryId,
                        principalTable: "SYSRefTypeCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
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
                    UnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_MaterialTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialTypes_Units_ServiceUnitId",
                        column: x => x.ServiceUnitId,
                        principalTable: "Units",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MaterialTypes_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedicineTypes",
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
                    PharmaceuticalFormulation = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                    AutoNumber = table.Column<int>(type: "int", nullable: false),
                    UnitId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_MedicineTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicineTypes_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedicineTypes_MedicineGroups_MedicineGroupId",
                        column: x => x.MedicineGroupId,
                        principalTable: "MedicineGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedicineTypes_MedicineLines_MedicineLineId",
                        column: x => x.MedicineLineId,
                        principalTable: "MedicineLines",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedicineTypes_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedicineTypes_Units_UnitId1",
                        column: x => x.UnitId1,
                        principalTable: "Units",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Services",
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
                    UnitId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_ServiceGroupHeIns_ServiceGroupHeInId",
                        column: x => x.ServiceGroupHeInId,
                        principalTable: "ServiceGroupHeIns",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Services_ServiceGroups_ServiceGroupId",
                        column: x => x.ServiceGroupId,
                        principalTable: "ServiceGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Services_SurgicalProcedureTypes_SurgicalProcedureTypeId",
                        column: x => x.SurgicalProcedureTypeId,
                        principalTable: "SurgicalProcedureTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Services_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Services_Units_UnitId1",
                        column: x => x.UnitId1,
                        principalTable: "Units",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tokens",
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
                    table.PrimaryKey("PK_Tokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Districts",
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
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
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
                    RoomTypeId1 = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rooms_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rooms_RoomTypes_RoomTypeId1",
                        column: x => x.RoomTypeId1,
                        principalTable: "RoomTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
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
                    MaterialTypeId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_Materials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materials_MaterialTypes_MaterialTypeId",
                        column: x => x.MaterialTypeId,
                        principalTable: "MaterialTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Materials_MaterialTypes_MaterialTypeId1",
                        column: x => x.MaterialTypeId1,
                        principalTable: "MaterialTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Materials_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Materials_Units_UnitId1",
                        column: x => x.UnitId1,
                        principalTable: "Units",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
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
                    UnitId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_Medicines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medicines_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Medicines_MedicineLines_MedicineLineId",
                        column: x => x.MedicineLineId,
                        principalTable: "MedicineLines",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Medicines_MedicineTypes_MedicineTypeId",
                        column: x => x.MedicineTypeId,
                        principalTable: "MedicineTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Medicines_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Medicines_Units_UnitId1",
                        column: x => x.UnitId1,
                        principalTable: "Units",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ServicePricePolicies",
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
                    table.PrimaryKey("PK_ServicePricePolicies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServicePricePolicies_PatientTypes_PatientTypeId",
                        column: x => x.PatientTypeId,
                        principalTable: "PatientTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServicePricePolicies_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ServiceResultIndices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MaleFrom = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MaleTo = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FemaleFrom = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FemaleTo = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceResultIndices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceResultIndices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Wards",
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
                    table.PrimaryKey("PK_Wards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wards_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExecutionRooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsMain = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExecutionRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExecutionRooms_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExecutionRooms_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedicinePricePolicies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientTypeId = table.Column<int>(type: "int", nullable: true),
                    OldUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NewUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CeilingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ExecutionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MedicineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_MedicinePricePolicies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicinePricePolicies_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedicinePricePolicies_PatientTypes_PatientTypeId",
                        column: x => x.PatientTypeId,
                        principalTable: "PatientTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedicineStocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MedicineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AvailableQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    table.PrimaryKey("PK_MedicineStocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicineStocks_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedicineStocks_Rooms_StockId",
                        column: x => x.StockId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PatientRecords",
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
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PatientTypeId = table.Column<int>(type: "int", nullable: false),
                    PatientRecordTypeId = table.Column<int>(type: "int", nullable: false),
                    ReceiptionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceiptionRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiptionDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsEmergency = table.Column<bool>(type: "bit", nullable: false),
                    HospitalizationReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StartDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EndDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_PatientRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientRecords_Branchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branchs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientRecords_Careers_CareerId",
                        column: x => x.CareerId,
                        principalTable: "Careers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientRecords_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientRecords_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PatientRecords_Ethnics_EthnicityId",
                        column: x => x.EthnicityId,
                        principalTable: "Ethnics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientRecords_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientRecords_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientRecords_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PatientRecords_Wards_WardId",
                        column: x => x.WardId,
                        principalTable: "Wards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InOutStocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    ImpStockId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExpStockId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InOutStockTypeId = table.Column<int>(type: "int", nullable: true),
                    ReceiverUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApproverUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApproverTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReqTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StockImpTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StockImpUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ReqRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReqDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PatientRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InvTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InvNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deliverer = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    StockExpTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StockExpUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_InOutStocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InOutStocks_Departments_ReqDepartmentId",
                        column: x => x.ReqDepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InOutStocks_InOutStockTypes_InOutStockTypeId",
                        column: x => x.InOutStockTypeId,
                        principalTable: "InOutStockTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InOutStocks_PatientRecords_PatientRecordId",
                        column: x => x.PatientRecordId,
                        principalTable: "PatientRecords",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InOutStocks_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InOutStocks_Rooms_ExpStockId",
                        column: x => x.ExpStockId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InOutStocks_Rooms_ImpStockId",
                        column: x => x.ImpStockId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InOutStocks_Rooms_ReqRoomId",
                        column: x => x.ReqRoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InOutStocks_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InOutStocks_Users_ApproverUserId",
                        column: x => x.ApproverUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InOutStocks_Users_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InOutStocks_Users_ReceiverUserId",
                        column: x => x.ReceiverUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InOutStocks_Users_StockExpUserId",
                        column: x => x.StockExpUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InOutStocks_Users_StockImpUserId",
                        column: x => x.StockImpUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InOutStockMedicines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InOutStockId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    MedicineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImpPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RequestQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ApprovedQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImpVatRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImpTaxRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InOutStockMedicines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InOutStockMedicines_InOutStocks_InOutStockId",
                        column: x => x.InOutStockId,
                        principalTable: "InOutStocks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InOutStockMedicines_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ChapterIcds",
                columns: new[] { "Id", "Code", "Inactive", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("0377427b-d6bd-4b58-99a9-d71789475bb2"), "38", false, "Chương XVI. Dị tật bẩm, biến dạng và bất thường về nhiễm sắc thể - U65", 39 },
                    { new Guid("08b63907-e7b9-4e6a-b075-706cca99f29c"), "32", false, "Chương X. Bệnh hệ hô hấp U59", 33 },
                    { new Guid("08f6a2b3-d5e6-4fad-a022-5f29d0117801"), "21", false, "21.Các yếu tố ảnh hưởng đến tình trạng sức khỏe và tiếp xúc dịch vụ y tế", 22 },
                    { new Guid("0d2992cf-6fba-4871-97b3-a8a1229e86fd"), "4", false, "4.Bệnh nội tiết, dinh dưỡng và chuyển hóa", 5 },
                    { new Guid("11baf250-7aed-4f3f-949b-82d8929d55ff"), "7", false, "7.Bệnh mắt và phần phụ", 8 },
                    { new Guid("134969e1-21e0-496c-8a7e-b40d5e52b4f4"), "23", false, "Chương I. Bệnh nhiễm trùng và ký sinh trùng U50", 24 },
                    { new Guid("30e5cab2-63d3-4b93-b430-042b04276e20"), "26", false, "Chương IV. Bệnh nội tiết, dinh dưỡng và rối loạn chuyển hóa - U53", 27 },
                    { new Guid("3a6de8c5-5bfd-4648-8225-42c79a224793"), "12", false, "12.Bệnh da và mô dưới da", 13 },
                    { new Guid("4104f31a-d1ad-4025-8756-4faddf40d453"), "34", false, "Chương XII. Bệnh của da và mô dưới da - U61", 35 },
                    { new Guid("4c8535f7-5852-435d-8b4d-66c198537fc4"), "6", false, "6.Bệnh hệ thần kinh", 7 },
                    { new Guid("5a91f9a2-5a73-4dce-9a99-532c3b75518e"), "9", false, "9.Bệnh tuần hoàn", 10 },
                    { new Guid("5d500bff-32f6-46ee-ba7a-f89a43fdd5b1"), "18", false, "18.Các triệu chứng, dấu hiệu và những biểu hiện lâm sàng bất thường, không phân loại ở phần khác", 19 },
                    { new Guid("5ec5c91b-db70-491b-b1b5-a617d9a82549"), "10", false, "10.Bệnh hô hấp", 11 },
                    { new Guid("613e5901-9552-40f8-b865-f9fd6e91d7e8"), "20", false, "20.Các nguyên nhân ngoại sinh của bệnh và tử vong", 21 },
                    { new Guid("6cd03dbd-dcbf-44d1-ab7a-3b32e71b3cb7"), "11", false, "11.Bệnh tiêu hóa", 12 },
                    { new Guid("723b5a32-b7a2-4d46-9e19-c42d096839e2"), "39", false, "Chương XVII. Các triệu chứng dấu hiệu và những biểu hiện lâm sàng bất thường, chưa được phân loại ở nơi khác - U66", 40 },
                    { new Guid("91c637c5-272c-488c-8489-98be3297d88e"), "17", false, "17.Dị tật bẩm sinh, biến dạng và bất thường về nhiễm sắc thể", 18 },
                    { new Guid("93672f0e-4d83-4214-9576-d29113acea27"), "14", false, "14.Bệnh hệ sinh dục - tiết niệu", 15 },
                    { new Guid("a0570373-f0ce-4051-93e7-3285476367cb"), "31", false, "Chương IX. Bệnh hệ tuần hoàn - U58", 32 },
                    { new Guid("a67315a8-8874-4a76-9d56-bb5103740e66"), "37", false, "Chương XV. Thai nghén, sinh đẻ và hậu sản - U64", 38 },
                    { new Guid("aaf07983-f9ed-43a5-8d9e-be42cdaa4044"), "22", false, "22.Kháng các thuốc kháng sinh và chống ung thư", 23 },
                    { new Guid("b4d1c297-0f9c-41d4-9aa9-b211ecf0cbee"), "30", false, "Chương VIII. Bệnh của tai xương chũm - U57", 31 },
                    { new Guid("bb4dd54d-2566-41be-a293-ed9398efeaa0"), "16", false, "16.Bệnh lý xuất phát trong thời ký chu kỳ", 17 },
                    { new Guid("c1747ec7-094e-4516-bd96-3e41327a317d"), "3", false, "3.Bệnh của máu, cơ quan tạo máu và các rối loạn liên quan đến cơ chế miễn dịch", 4 },
                    { new Guid("c27dbaeb-b11f-448b-bb63-be2f06d3e795"), "24", false, "Chương II. Bướu tân sinh - U51", 25 },
                    { new Guid("c3c34fe9-3d68-4f4c-98ab-abc10ec96ccc"), "40", false, "Chương XVIII. Vết thương ngộ độc và hậu quả của một số nguyên nhân bên ngoài - U67", 41 },
                    { new Guid("c81585c5-e57d-468f-99f2-1b403317ffd9"), "2", false, "2.Bướu tân sinh", 3 },
                    { new Guid("cb433c30-519a-40ad-aab8-479dfad013c3"), "15", false, "15.Thai nghén, sinh đẻ và hậu sản", 16 },
                    { new Guid("cd456287-b5aa-4d8c-b23d-7027c7676ce7"), "36", false, "Chương XIV. Bệnh hệ sinh dục - Tiết niệu - U63", 37 },
                    { new Guid("dd087168-fb8b-451f-bddd-56adff7a91b3"), "1", false, "1.Bệnh nhiễm trùng và ký sinh trùng", 2 },
                    { new Guid("dd240e2f-1434-4091-a691-12da1214424e"), "19", false, "19.Vết thương, ngộ độc và hậu quả của một số nguyên nhân bên ngoài", 20 },
                    { new Guid("e06c956c-1795-46a0-ba63-cb75f74ac431"), "5", false, "5.Rối loạn tâm thần và hành vi", 6 },
                    { new Guid("e71c20e6-9f6c-4998-8867-c29b3f0da643"), "27", false, "Chương V. Bệnh rối loạn tâm thần và hành vi - U54", 28 },
                    { new Guid("e96358f3-2f7c-4d6f-a4fa-0268039df244"), "33", false, "Chương XI. Bệnh tiêu hóa - U60", 34 },
                    { new Guid("f21cf99c-f691-43eb-92c7-d9cd595fc1b2"), "29", false, "Chương VII. Bệnh về mắt và phần phụ - U56", 30 },
                    { new Guid("f2b02143-9c76-4717-a9a5-711ce23bf81c"), "28", false, "Chương VI. Bệnh hệ thần kinh - U55", 29 },
                    { new Guid("f3685b6e-8b27-4e8e-8a7d-b07ae695805f"), "8", false, "8.Bệnh tai và xương chũm", 9 },
                    { new Guid("f8811c3e-61e4-4344-b139-b583dc0d94a3"), "25", false, "Chương III. Bệnh về máu, cơ quan tạo máu và các rối loạn liên quan đến cơ chế miễn dịch - U52", 26 },
                    { new Guid("f98e5ee7-4651-43fd-85fd-7e077785ad53"), "13", false, "13.Bệnh của hệ xương khớp và mô liên kết", 14 },
                    { new Guid("f9e407f1-0417-4067-9d25-dae91d19e1bf"), "35", false, "Chương XIII. Bệnh của hệ xương khớp và mô liên kết - U62", 36 },
                    { new Guid("ffa69c02-696f-4645-b72e-0f371b8cacfa"), "0", false, "Khác", 1 }
                });

            migrationBuilder.InsertData(
                table: "Countries",
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
                table: "DepartmentTypes",
                columns: new[] { "Id", "Code", "Description", "Inactive", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "LS", null, false, "Khoa lâm sàng", 1 },
                    { 2, "CLS", null, false, "Khoa cận lâm sàng", 2 },
                    { 3, "DUOC", null, false, "Khoa dược", 3 },
                    { 4, "KHTH", null, false, "Kế hoạch tổng hợp", 4 }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Code", "Description", "Inactive", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("97ac7fd8-edfa-4243-97fc-98468f492df1"), "KXD", null, false, "Chưa xác định", 0 },
                    { new Guid("e9497984-d355-41af-b917-091500956be9"), "NU", null, false, "Nữ", 2 },
                    { new Guid("fc153433-bf89-4e95-8523-df3d8cec8676"), "NAM", null, false, "Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "InOutStockTypes",
                columns: new[] { "Id", "Code", "Inactive", "Name" },
                values: new object[,]
                {
                    { 1, "01", false, "Nhập hàng hóa từ nhà cung cấp" },
                    { 2, "02", false, "Xuất hàng hóa trả nhà cung cấp" },
                    { 3, "03", false, "Nhập từ kho khác" },
                    { 4, "04", false, "Xuất trả kho khác" },
                    { 5, "05", false, "Nhập bù" },
                    { 6, "06", false, "Xuất thanh lý" },
                    { 7, "07", false, "Xuất kiểm nghiệm" },
                    { 8, "08", false, "Xuất hủy (Mất, hỏng, vỡ)" },
                    { 9, "09", false, "Xuất hao phí phòng khám" },
                    { 10, "10", false, "Xuất sử dụng phòng" },
                    { 11, "11", false, "Xuất sử dụng khoa" },
                    { 12, "12", false, "Nhập bù cơ số tủ trực" },
                    { 13, "13", false, "Xuất bù cơ số tủ trực" },
                    { 14, "14", false, "Bổ sung cơ số tủ trực" },
                    { 15, "15", false, "Hoàn trả cơ số tủ trực" },
                    { 16, "16", false, "Xuất bản cho khách hàng" },
                    { 17, "17", false, "Nhập trả từ khách hàng" },
                    { 99, "99", false, "Xuất khác" }
                });

            migrationBuilder.InsertData(
                table: "MedicineGroups",
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
                table: "MedicineLines",
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
                table: "PatientTypes",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "BHYT", null, new DateTime(2023, 8, 25, 20, 6, 22, 866, DateTimeKind.Local).AddTicks(5690), null, false, null, null, "Bảo hiểm y tế", 0 },
                    { 2, "VP", null, new DateTime(2023, 8, 25, 20, 6, 22, 866, DateTimeKind.Local).AddTicks(5703), null, false, null, null, "Viện phí", 0 },
                    { 3, "DV", null, new DateTime(2023, 8, 25, 20, 6, 22, 866, DateTimeKind.Local).AddTicks(5705), null, false, null, null, "Dịch vụ", 0 }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
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
                table: "ServiceGroupHeIns",
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
                table: "ServiceGroups",
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
                table: "SurgicalProcedureTypes",
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
                table: "Units",
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
                table: "Users",
                columns: new[] { "Id", "Address", "DistrictId", "Dob", "Email", "FirstName", "GenderId", "LastName", "Password", "PhoneNumber", "ProvinceId", "Status", "UseType", "UserName", "WardId" },
                values: new object[] { new Guid("3382be1c-2836-4246-99db-c4e1c781e868"), null, null, null, "administrator@gmail.com", "Admin", null, "Administrator", "79956B61E1B250869A6716CE37EFD6E6", null, null, 1, 0, "Administrator", null });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Code", "CountryId", "Inactive", "Name" },
                values: new object[,]
                {
                    { new Guid("003360aa-6adc-4e1c-8da9-fd1d1665729d"), "17", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Hoà Bình" },
                    { new Guid("0729fb2e-ae19-41f3-b948-b0f0c51fbf99"), "46", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Thừa Thiên Huế" },
                    { new Guid("0b13943c-ead8-4e76-80b8-33b31828dd7a"), "77", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Bà Rịa - Vũng Tàu" },
                    { new Guid("0fdfd770-bee4-4dc4-9eb5-d86816bfc2bf"), "35", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Hà Nam" },
                    { new Guid("198417f7-e503-4435-bde2-7547487c943a"), "33", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Hưng Yên" },
                    { new Guid("1d8b3ff0-1bbd-4fa4-a4c8-1a4e2c394a55"), "34", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Thái Bình" },
                    { new Guid("2c03541e-db56-4bcb-8012-52b0f130ca09"), "67", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Đắk Nông" },
                    { new Guid("2d80dbcf-c7d5-4450-9847-e7e6f737f567"), "27", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Bắc Ninh" },
                    { new Guid("3035b967-95aa-46a5-be3f-b1f7bec1fd51"), "44", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Quảng Bình" },
                    { new Guid("3109e53a-812d-455e-a968-e86ff499d74d"), "49", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Quảng Nam" },
                    { new Guid("33d6ec24-75ee-402e-b8d2-3296e90ea336"), "60", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Bình Thuận" },
                    { new Guid("37d13fe4-1fd2-4268-bbae-4ab301f634c5"), "22", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Quảng Ninh" },
                    { new Guid("38e1ffeb-7572-40c7-a716-cd880eb8d1ce"), "08", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Tuyên Quang" },
                    { new Guid("395f3325-851f-41ee-b652-5002ce7cf547"), "68", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Lâm Đồng" },
                    { new Guid("3baaffd5-90a2-471f-8581-b5969184fcbe"), "62", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Kon Tum" },
                    { new Guid("3fd18cc5-7204-42a9-a940-c5cf3128518f"), "94", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Sóc Trăng" },
                    { new Guid("40064e04-52c1-460d-b3d3-04f4e991f82c"), "48", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Thành phố Đà Nẵng" },
                    { new Guid("46ddf496-df97-40b4-9b23-bfd17357abbe"), "31", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Thành phố Hải Phòng" },
                    { new Guid("4e6a7717-9e60-4bae-a2d4-d29dacd8af47"), "12", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Lai Châu" },
                    { new Guid("528fe36b-ac63-4f15-96f5-104ac221a155"), "10", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Lào Cai" },
                    { new Guid("52b17f24-a4a1-4cc6-88a0-c526ee8256c6"), "11", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Điện Biên" },
                    { new Guid("5329306e-8290-4ca4-b110-0678c20752e0"), "56", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Khánh Hòa" },
                    { new Guid("619d7aee-4e6a-4993-9d7a-c6e32958851f"), "92", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Thành phố Cần Thơ" },
                    { new Guid("64a15171-a037-45b4-a55d-08ee58ce687d"), "66", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Đắk Lắk" },
                    { new Guid("68d199cc-b739-4d61-b412-40d2242f374d"), "58", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Ninh Thuận" },
                    { new Guid("6f51a702-3c62-4a43-8042-9cf6e8bf3186"), "72", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Tây Ninh" },
                    { new Guid("702c3cf1-d0b3-4647-8d39-7549dd42f610"), "84", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Trà Vinh" },
                    { new Guid("7184c251-1c62-4b69-a63f-de49e85633f0"), "79", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Thành phố Hồ Chí Minh" },
                    { new Guid("72478add-ca26-4a9b-92bd-2b075006f36a"), "89", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh An Giang" },
                    { new Guid("77e4b05d-6245-43ee-ba94-84faaece9018"), "15", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Yên Bái" },
                    { new Guid("7a3c3be6-fe62-42ab-9764-f8e62d7f5916"), "52", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Bình Định" },
                    { new Guid("7acbf3ec-7068-4007-a871-e0fee1ef28c5"), "26", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Vĩnh Phúc" },
                    { new Guid("839f0efb-168d-4110-a041-60b463ae48a1"), "70", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Bình Phước" },
                    { new Guid("889693ed-0453-4387-941b-d70dd4870dc5"), "01", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Thành phố Hà Nội" },
                    { new Guid("8eb57a8e-8281-41bb-a5ab-637dcac67177"), "14", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Sơn La" },
                    { new Guid("8ed43986-0586-4742-8f89-a673c9f63756"), "06", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Bắc Kạn" },
                    { new Guid("8f0f2a47-34e4-4af3-811a-4d9c1fbf1cae"), "45", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Quảng Trị" },
                    { new Guid("927f685b-f766-4bf8-93ed-ae7aabc4071c"), "19", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Thái Nguyên" },
                    { new Guid("94dab20e-c05d-4aa9-93e9-82e972792756"), "36", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Nam Định" },
                    { new Guid("952aa342-c05d-46d3-8ffe-6a22d7512dc2"), "83", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Bến Tre" },
                    { new Guid("9c2a8569-d860-459d-8c3a-49966ea0038d"), "24", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Bắc Giang" },
                    { new Guid("9d49b503-ac5f-47f3-aaa2-8d18853bfba6"), "80", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Long An" },
                    { new Guid("a1f48dda-f1a3-473a-b4f7-6843312303f4"), "25", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Phú Thọ" },
                    { new Guid("aee0f859-e3bd-41ae-be15-17060d5ad617"), "37", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Ninh Bình" },
                    { new Guid("af97b966-5b74-4580-a948-c8a9df0a5fba"), "51", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Quảng Ngãi" },
                    { new Guid("b2035ac5-5e24-4a18-8587-62e65fd64697"), "42", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Hà Tĩnh" },
                    { new Guid("b2cace92-0d42-4789-97c7-83ea3c3667c5"), "38", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Thanh Hóa" },
                    { new Guid("b42cba39-912a-4400-84a5-fe15eb71766e"), "64", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Gia Lai" },
                    { new Guid("b6bdda7d-b047-45a0-9d73-ffcb4e938e38"), "95", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Bạc Liêu" },
                    { new Guid("b6cf7563-f2be-4273-bcc7-58bb3cd4edec"), "75", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Đồng Nai" },
                    { new Guid("c16dbbe1-bea2-413b-9216-5b547deac9f5"), "20", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Lạng Sơn" },
                    { new Guid("c30f4992-257a-4abf-abb0-2ea4b36f247f"), "54", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Phú Yên" },
                    { new Guid("cd4eab40-92a3-4898-8a65-c67ccde721c0"), "93", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Hậu Giang" },
                    { new Guid("da06856d-9e6c-49f7-bbed-ca2a06ca81c1"), "91", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Kiên Giang" },
                    { new Guid("e5a4e82b-b29d-4b47-a563-82977ea93346"), "86", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Vĩnh Long" },
                    { new Guid("e7fe23cb-4304-4fb0-90a5-9ff4da5048aa"), "02", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Hà Giang" },
                    { new Guid("ec0b077d-3957-4089-85f8-c1d6742aab19"), "40", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Nghệ An" },
                    { new Guid("ed0a3763-3a96-46c5-8094-c47a4708e3cb"), "30", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Hải Dương" },
                    { new Guid("ef981a1e-0af1-4b7f-9fd7-42de078e7d97"), "74", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Bình Dương" },
                    { new Guid("f06e27bf-1470-4f7a-873f-f0dc77e405e4"), "82", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Tiền Giang" },
                    { new Guid("f2aac7ae-5a85-48fc-9166-d9ab6efb79ab"), "96", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Cà Mau" },
                    { new Guid("f5d76f98-2024-4c60-81ad-577359cb69d1"), "04", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Cao Bằng" },
                    { new Guid("fa11ad72-29b7-49f4-986d-fea0d53de210"), "87", new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), false, "Tỉnh Đồng Tháp" }
                });

            migrationBuilder.Sql(@"IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[AfterInsertMedicines]'))
DROP TRIGGER [dbo].[AfterInsertMedicines]
GO
-- =============================================
-- Author:		DuyNV
-- Create date: 11/08/2023
-- Description:	Lấy mã thuốc theo lô
-- =============================================
CREATE TRIGGER [dbo].[AfterInsertMedicines]
   ON  [dbo].[Medicines] 
   AFTER INSERT
AS 
BEGIN
	DECLARE @MedicineTypeId uniqueidentifier;
	DECLARE @MedicineId uniqueidentifier;

    DECLARE cursor_inserted CURSOR FOR

	SELECT MedicineTypeId, Id
    FROM INSERTED;

    OPEN cursor_inserted
    FETCH NEXT FROM cursor_inserted INTO @MedicineTypeId, @MedicineId

    WHILE @@FETCH_STATUS = 0
    BEGIN
		DECLARE @Code NVARCHAR(50);
		DECLARE @AutoNumber INT;
		
		SELECT @Code = Code, @AutoNumber = AutoNumber FROM MedicineTypes WHERE Id = @MedicineTypeId;
		SET @Code = @Code + '.' + CONVERT(NVARCHAR(50), @AutoNumber  + 1);

        UPDATE Medicines SET Code = @Code WHERE Id = @MedicineId;
		UPDATE MedicineTypes SET AutoNumber = @AutoNumber + 1 WHERE Id = @MedicineTypeId;

        FETCH NEXT FROM cursor_inserted INTO @MedicineTypeId, @MedicineId
    END

    CLOSE cursor_inserted
    DEALLOCATE cursor_inserted
END
GO
ALTER TABLE [dbo].[Medicines] ENABLE TRIGGER [AfterInsertMedicines]
GO");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_BranchId",
                table: "Departments",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DepartmentTypeId",
                table: "Departments",
                column: "DepartmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_ProvinceId",
                table: "Districts",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_ExecutionRooms_RoomId",
                table: "ExecutionRooms",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_ExecutionRooms_ServiceId",
                table: "ExecutionRooms",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Icds_ChapterIcdId",
                table: "Icds",
                column: "ChapterIcdId");

            migrationBuilder.CreateIndex(
                name: "IX_InOutStockMedicines_InOutStockId",
                table: "InOutStockMedicines",
                column: "InOutStockId");

            migrationBuilder.CreateIndex(
                name: "IX_InOutStockMedicines_MedicineId",
                table: "InOutStockMedicines",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_InOutStocks_ApproverUserId",
                table: "InOutStocks",
                column: "ApproverUserId");

            migrationBuilder.CreateIndex(
                name: "IX_InOutStocks_CreationUserId",
                table: "InOutStocks",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_InOutStocks_ExpStockId",
                table: "InOutStocks",
                column: "ExpStockId");

            migrationBuilder.CreateIndex(
                name: "IX_InOutStocks_ImpStockId",
                table: "InOutStocks",
                column: "ImpStockId");

            migrationBuilder.CreateIndex(
                name: "IX_InOutStocks_InOutStockTypeId",
                table: "InOutStocks",
                column: "InOutStockTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_InOutStocks_PatientId",
                table: "InOutStocks",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_InOutStocks_PatientRecordId",
                table: "InOutStocks",
                column: "PatientRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_InOutStocks_ReceiverUserId",
                table: "InOutStocks",
                column: "ReceiverUserId");

            migrationBuilder.CreateIndex(
                name: "IX_InOutStocks_ReqDepartmentId",
                table: "InOutStocks",
                column: "ReqDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_InOutStocks_ReqRoomId",
                table: "InOutStocks",
                column: "ReqRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_InOutStocks_StockExpUserId",
                table: "InOutStocks",
                column: "StockExpUserId");

            migrationBuilder.CreateIndex(
                name: "IX_InOutStocks_StockImpUserId",
                table: "InOutStocks",
                column: "StockImpUserId");

            migrationBuilder.CreateIndex(
                name: "IX_InOutStocks_SupplierId",
                table: "InOutStocks",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_MaterialTypeId",
                table: "Materials",
                column: "MaterialTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_MaterialTypeId1",
                table: "Materials",
                column: "MaterialTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_UnitId",
                table: "Materials",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_UnitId1",
                table: "Materials",
                column: "UnitId1");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialTypes_ServiceUnitId",
                table: "MaterialTypes",
                column: "ServiceUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialTypes_UnitId",
                table: "MaterialTypes",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicinePricePolicies_MedicineId",
                table: "MedicinePricePolicies",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicinePricePolicies_PatientTypeId",
                table: "MedicinePricePolicies",
                column: "PatientTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_CountryId",
                table: "Medicines",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_MedicineLineId",
                table: "Medicines",
                column: "MedicineLineId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_MedicineTypeId",
                table: "Medicines",
                column: "MedicineTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_UnitId",
                table: "Medicines",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_UnitId1",
                table: "Medicines",
                column: "UnitId1");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineStocks_MedicineId",
                table: "MedicineStocks",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineStocks_StockId",
                table: "MedicineStocks",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineTypes_CountryId",
                table: "MedicineTypes",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineTypes_MedicineGroupId",
                table: "MedicineTypes",
                column: "MedicineGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineTypes_MedicineLineId",
                table: "MedicineTypes",
                column: "MedicineLineId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineTypes_UnitId",
                table: "MedicineTypes",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineTypes_UnitId1",
                table: "MedicineTypes",
                column: "UnitId1");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_BranchId",
                table: "PatientRecords",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_CareerId",
                table: "PatientRecords",
                column: "CareerId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_CountryId",
                table: "PatientRecords",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_DistrictId",
                table: "PatientRecords",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_EthnicityId",
                table: "PatientRecords",
                column: "EthnicityId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_GenderId",
                table: "PatientRecords",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_PatientId",
                table: "PatientRecords",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_ProvinceId",
                table: "PatientRecords",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_WardId",
                table: "PatientRecords",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_CountryId",
                table: "Provinces",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissionBranchs_BranchId",
                table: "RolePermissionBranchs",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissionBranchs_PermissionId",
                table: "RolePermissionBranchs",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_DepartmentId",
                table: "Rooms",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeId1",
                table: "Rooms",
                column: "RoomTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePricePolicies_PatientTypeId",
                table: "ServicePricePolicies",
                column: "PatientTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePricePolicies_ServiceId",
                table: "ServicePricePolicies",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceResultIndices_ServiceId",
                table: "ServiceResultIndices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServiceGroupHeInId",
                table: "Services",
                column: "ServiceGroupHeInId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServiceGroupId",
                table: "Services",
                column: "ServiceGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_SurgicalProcedureTypeId",
                table: "Services",
                column: "SurgicalProcedureTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_UnitId",
                table: "Services",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_UnitId1",
                table: "Services",
                column: "UnitId1");

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

            migrationBuilder.CreateIndex(
                name: "IX_Tokens_UserId",
                table: "Tokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Wards_DistrictId",
                table: "Wards",
                column: "DistrictId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExecutionRooms");

            migrationBuilder.DropTable(
                name: "Hospitals");

            migrationBuilder.DropTable(
                name: "Icds");

            migrationBuilder.DropTable(
                name: "InOutStockMedicines");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "MedicinePricePolicies");

            migrationBuilder.DropTable(
                name: "MedicineStocks");

            migrationBuilder.DropTable(
                name: "RolePermissionBranchs");

            migrationBuilder.DropTable(
                name: "ServicePricePolicies");

            migrationBuilder.DropTable(
                name: "ServiceResultIndices");

            migrationBuilder.DropTable(
                name: "SYSAutoNumbers");

            migrationBuilder.DropTable(
                name: "SYSRefTypes");

            migrationBuilder.DropTable(
                name: "Tokens");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "ChapterIcds");

            migrationBuilder.DropTable(
                name: "InOutStocks");

            migrationBuilder.DropTable(
                name: "MaterialTypes");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "PatientTypes");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "SYSRefTypeCategories");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "InOutStockTypes");

            migrationBuilder.DropTable(
                name: "PatientRecords");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "MedicineTypes");

            migrationBuilder.DropTable(
                name: "ServiceGroupHeIns");

            migrationBuilder.DropTable(
                name: "ServiceGroups");

            migrationBuilder.DropTable(
                name: "SurgicalProcedureTypes");

            migrationBuilder.DropTable(
                name: "Careers");

            migrationBuilder.DropTable(
                name: "Ethnics");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Wards");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "RoomTypes");

            migrationBuilder.DropTable(
                name: "MedicineGroups");

            migrationBuilder.DropTable(
                name: "MedicineLines");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Branchs");

            migrationBuilder.DropTable(
                name: "DepartmentTypes");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
