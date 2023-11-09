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
                name: "BloodType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BloodTypeRh",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodTypeRh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branch",
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
                    table.PrimaryKey("PK_Branch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Career",
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
                    table.PrimaryKey("PK_Career", x => x.Id);
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
                name: "ColumnTemplates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TemplateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefType = table.Column<int>(type: "int", nullable: false),
                    FieldName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FieldType = table.Column<int>(type: "int", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultCaption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TooltipText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visible = table.Column<bool>(type: "bit", nullable: false),
                    VisibleIndex = table.Column<bool>(type: "bit", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    IsReadOnly = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColumnTemplates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HeInCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeathCauses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeathCauses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeathWithins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeathWithins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentType",
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
                    table.PrimaryKey("PK_DepartmentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ethnic",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MohCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Ethnic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
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
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hospital",
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
                    table.PrimaryKey("PK_Hospital", x => x.Id);
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
                name: "Insurance",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MediOrgCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MediOrgName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LevelCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LiveAreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasBirthCertificate = table.Column<bool>(type: "bit", nullable: false),
                    FreeCoPaidDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Join5YearDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    IsSystem = table.Column<bool>(type: "bit", nullable: false),
                    CommodityType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemLines",
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
                    table.PrimaryKey("PK_ItemLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalRecord",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicalRecordDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RooomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IcdCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IcdName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IcdSubCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IcdText = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_MedicalRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalRecordEndTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsForOutPatient = table.Column<bool>(type: "bit", nullable: false),
                    IsForInPatient = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRecordEndTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalRecordResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRecordResults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalRecordTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    GroupTypeId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRecordTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientRecordTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientRecordTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientType",
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
                    table.PrimaryKey("PK_PatientType", x => x.Id);
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
                name: "ReceptionType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceptionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RelativeType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelativeType", x => x.Id);
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
                name: "RoomType",
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
                    table.PrimaryKey("PK_RoomType", x => x.Id);
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
                name: "ServiceRequest",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicalRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TreatmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RequestTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
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
                    table.PrimaryKey("PK_ServiceRequest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceRequestServe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicalRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TreatmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
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
                    table.PrimaryKey("PK_ServiceRequestServe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
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
                    table.PrimaryKey("PK_Supplier", x => x.Id);
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
                name: "Treatments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicalRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TreatmentCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TreatmentTypeID = table.Column<int>(type: "int", nullable: false),
                    TreatmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Temperature = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TemperatureType = table.Column<int>(type: "int", nullable: false),
                    BloodPressureMin = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BloodPressureMax = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Pulse = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BreathRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SPO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BranchID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Treatments", x => x.Id);
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
                name: "Icd",
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
                    table.PrimaryKey("PK_Icd", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Icd_ChapterIcds_ChapterIcdId",
                        column: x => x.ChapterIcdId,
                        principalTable: "ChapterIcds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Province",
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
                    table.PrimaryKey("PK_Province", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Province_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Department",
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
                    table.PrimaryKey("PK_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Department_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Department_DepartmentType_DepartmentTypeId",
                        column: x => x.DepartmentTypeId,
                        principalTable: "DepartmentType",
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
                        name: "FK_RolePermissionBranchs_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RolePermissionBranchs_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissionBranchs_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_SYSAutoNumbers_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
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
                name: "ItemTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HeInCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    ItemLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceGroupHeInId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    ImpTaxRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
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
                    CommodityType = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ItemTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemTypes_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemTypes_ItemGroups_ItemGroupId",
                        column: x => x.ItemGroupId,
                        principalTable: "ItemGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemTypes_ItemLines_ItemLineId",
                        column: x => x.ItemLineId,
                        principalTable: "ItemLines",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemTypes_Units_UnitId",
                        column: x => x.UnitId,
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "District",
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
                    table.PrimaryKey("PK_District", x => x.Id);
                    table.ForeignKey(
                        name: "FK_District_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Room",
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
                    table.PrimaryKey("PK_Room", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Room_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Room_RoomType_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Room_RoomType_RoomTypeId1",
                        column: x => x.RoomTypeId1,
                        principalTable: "RoomType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HeInCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    ItemLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Tutorial = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImpPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImpQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImpVatRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImpTaxRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
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
                    CommodityType = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Items_ItemLines_ItemLineId",
                        column: x => x.ItemLineId,
                        principalTable: "ItemLines",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Items_ItemTypes_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Items_Units_UnitId",
                        column: x => x.UnitId,
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
                        name: "FK_ServicePricePolicies_PatientType_PatientTypeId",
                        column: x => x.PatientTypeId,
                        principalTable: "PatientType",
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
                name: "Ward",
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
                    table.PrimaryKey("PK_Ward", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ward_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
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
                        name: "FK_ExecutionRooms_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExecutionRooms_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemPricePolicies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientTypeId = table.Column<int>(type: "int", nullable: true),
                    OldUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NewUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CeilingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ExecutionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_ItemPricePolicies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemPricePolicies_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemPricePolicies_PatientType_PatientTypeId",
                        column: x => x.PatientTypeId,
                        principalTable: "PatientType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemStocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_ItemStocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemStocks_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemStocks_Room_StockId",
                        column: x => x.StockId,
                        principalTable: "Room",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BirthYear = table.Column<int>(type: "int", nullable: false),
                    BirthPlace = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EthnicId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BloodTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BloodTypeRhId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CareerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkPlace = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IssueBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Patient_BloodTypeRh_BloodTypeRhId",
                        column: x => x.BloodTypeRhId,
                        principalTable: "BloodTypeRh",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patient_BloodType_BloodTypeId",
                        column: x => x.BloodTypeId,
                        principalTable: "BloodType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patient_Career_CareerId",
                        column: x => x.CareerId,
                        principalTable: "Career",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patient_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patient_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patient_Ethnic_EthnicId",
                        column: x => x.EthnicId,
                        principalTable: "Ethnic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patient_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patient_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patient_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PatientRecord",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BirthYear = table.Column<int>(type: "int", nullable: false),
                    BirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EthnicId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CareerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IssueBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RalativeTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RelativeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelativeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelativeTel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelativeMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelativeIdentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelativeIssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RelativeIssueBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceptionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceptionDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceptionRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceptionType = table.Column<int>(type: "int", nullable: false),
                    ReceptionObjectType = table.Column<int>(type: "int", nullable: false),
                    HospitalizationReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPriority = table.Column<bool>(type: "bit", nullable: false),
                    IsEmergency = table.Column<bool>(type: "bit", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClinicalTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClinicalDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClinicalRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OutTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OutDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OutRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IcdCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IcdName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IcdSubCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IcdText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BloodTypeRhId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        name: "FK_PatientRecord_BloodTypeRh_BloodTypeRhId",
                        column: x => x.BloodTypeRhId,
                        principalTable: "BloodTypeRh",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PatientRecord_BloodType_BloodTypeId",
                        column: x => x.BloodTypeId,
                        principalTable: "BloodType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PatientRecord_Career_CareerId",
                        column: x => x.CareerId,
                        principalTable: "Career",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientRecord_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PatientRecord_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PatientRecord_Ethnic_EthnicId",
                        column: x => x.EthnicId,
                        principalTable: "Ethnic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientRecord_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientRecord_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientRecord_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PatientRecord_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
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
                    CommodityType = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_InOutStocks_Department_ReqDepartmentId",
                        column: x => x.ReqDepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InOutStocks_InOutStockTypes_InOutStockTypeId",
                        column: x => x.InOutStockTypeId,
                        principalTable: "InOutStockTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InOutStocks_PatientRecord_PatientRecordId",
                        column: x => x.PatientRecordId,
                        principalTable: "PatientRecord",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InOutStocks_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InOutStocks_Room_ExpStockId",
                        column: x => x.ExpStockId,
                        principalTable: "Room",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InOutStocks_Room_ImpStockId",
                        column: x => x.ImpStockId,
                        principalTable: "Room",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InOutStocks_Room_ReqRoomId",
                        column: x => x.ReqRoomId,
                        principalTable: "Room",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InOutStocks_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
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
                name: "InOutStockItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InOutStockId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImpPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RequestQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ApprovedQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImpVatRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImpTaxRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InOutStockItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InOutStockItems_InOutStocks_InOutStockId",
                        column: x => x.InOutStockId,
                        principalTable: "InOutStocks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InOutStockItems_ItemTypes_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InOutStockItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
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
                table: "Country",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "HeInCode", "Inactive", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), "VN", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2915), "000", false, null, null, "Việt Nam" },
                    { new Guid("0105cfd9-5265-4dcc-b2d8-790abecd5577"), "PS", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2760), "PS", false, null, null, "Palestinian Authority" },
                    { new Guid("02cd862f-7bf2-4dee-9d8d-869f67659eac"), "CX", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2498), "CX", false, null, null, "Christmas island" },
                    { new Guid("05600686-62bc-4be9-b009-58ae6fac5dc2"), "UM", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2897), "UM", false, null, null, "United States Minor Outlying Islands" },
                    { new Guid("05f8a24e-3764-41af-b79b-3e05da6964ad"), "TO", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2872), "276", false, null, null, "Tonga" },
                    { new Guid("060539cd-d169-45c2-bec2-28a91e41bcb3"), "IL", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2604), "184", false, null, null, "Israel" },
                    { new Guid("067dbcfb-9729-4016-aa0f-526f43657542"), "CL", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2484), "141", false, null, null, "Chile" },
                    { new Guid("07c04d8d-4e1c-4896-ba8a-7d8172562b37"), "KP", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2639), "277", false, null, null, "Triều Tiên" },
                    { new Guid("09127bf0-ff5d-4660-8fef-18b3107bf295"), "BI", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2321), "135", false, null, null, "Burundi" },
                    { new Guid("0d9bf5f6-20bb-4b4f-8c3e-0b7205eabe19"), "PR", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2758), "PR", false, null, null, "Puerto Rico" },
                    { new Guid("0f42743d-f2ae-4d4d-9e9c-6dcd785204ff"), "SE", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2788), "273", false, null, null, "Thụy Điển" },
                    { new Guid("10a98338-7167-4e5b-b3e4-9515f63bb43d"), "FI", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2532), "241", false, null, null, "Phần Lan" },
                    { new Guid("10f310c4-857b-431b-934c-19ebc560571c"), "IS", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2615), "179", false, null, null, "Iceland" },
                    { new Guid("1137907c-6292-4973-8a6a-5a8a55216701"), "OM", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2739), "233", false, null, null, "Oman" },
                    { new Guid("16bfb332-7ffe-4d31-a2a2-05e7cc250969"), "Z1", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2928), "Z1", false, null, null, "Sovereign Military Order of Malta (SMOM)" },
                    { new Guid("1760cdb2-5d9e-4a4d-a422-9d2d54333b72"), "VA", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2904), "290", false, null, null, "Thành Vatican" },
                    { new Guid("18be6a2d-0cc9-4e57-9b95-0fd5e0999094"), "LA", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2648), "193", false, null, null, "Lào" },
                    { new Guid("19b9d4e2-dd04-4d66-ba70-e71a800b8563"), "CO", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2490), "142", false, null, null, "Colombia" },
                    { new Guid("1a52542a-e4e8-4514-b84f-d8f7a0ce8bf5"), "HU", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2598), "177", false, null, null, "Hungary" },
                    { new Guid("1bb67a2c-65b1-4437-b7db-61bb5c5c945a"), "NZ", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2737), "227", false, null, null, "New Zealand" },
                    { new Guid("1bd96043-4837-4ab4-8812-0230d7cdc37c"), "BH", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2319), "117", false, null, null, "Bahrain" },
                    { new Guid("1c1e8f0d-fa36-4dd5-a349-51f8f8cf1e11"), "RU", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2774), "231", false, null, null, "Nga" },
                    { new Guid("1c3907c5-3cd4-4530-a28c-6d4acceec175"), "AZ", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2305), "113", false, null, null, "Azerbaijan" },
                    { new Guid("1cb83a16-11a1-438b-8fd9-22e661c5904a"), "TN", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2863), "281", false, null, null, "Tunisia" },
                    { new Guid("1cc02fda-f061-49ad-a4f1-ecb564a28c88"), "KZ", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2646), "187", false, null, null, "Kazakhstan" },
                    { new Guid("1d374c8c-88c5-49ae-9c9c-0b2b362b1198"), "BR", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2336), "131", false, null, null, "Brasil" },
                    { new Guid("1d41f179-ba78-41d6-8ecf-595c7d6de65a"), "MA", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2671), "209", false, null, null, "Maroc" },
                    { new Guid("1df44627-4127-48c0-bbc7-2afc64cb75d2"), "CH", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2477), "274", false, null, null, "Thụy Sĩ" },
                    { new Guid("1f0c0c80-dceb-47c4-9bfb-d9e2b29e8010"), "NR", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2733), "224", false, null, null, "Nauru" },
                    { new Guid("20aa6e3b-0838-45fc-9769-161b291e5e24"), "Z4", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2934), "Z4", false, null, null, "Scotland" },
                    { new Guid("212573b7-ec34-4844-b150-74f567de2c5d"), "GF", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2554), "GF", false, null, null, "French guiana" },
                    { new Guid("21668f2b-b3d0-4927-9d67-3f9eee4736d6"), "AS", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2296), "AS", false, null, null, "Samoa thuộc Hoa Kỳ" },
                    { new Guid("22174cd0-7b2d-4c6b-bb6c-5273e63d28f0"), "MY", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2712), "205", false, null, null, "Malaysia" },
                    { new Guid("226d663e-46ee-4ab2-b385-b062345debd9"), "FR", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2542), "240", false, null, null, "Pháp" },
                    { new Guid("23063395-5d36-41c9-9711-66722ab8849f"), "CZ", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2502), "252", false, null, null, "Séc" },
                    { new Guid("24c5f9fa-e493-43a1-9d2a-c6d25dc2ea89"), "FY", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2544), "254", false, null, null, "Serbia" },
                    { new Guid("25b7ed9b-8bfd-4601-a4c5-a59dfe5a3fab"), "AN", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2288), "AN", false, null, null, "Netherlands antilles" },
                    { new Guid("25df127f-9fb7-4f1d-8a4f-484364e15f91"), "GN", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2565), "170", false, null, null, "Guinea" },
                    { new Guid("264432ff-ba3d-4402-ae05-d3cbbdf7eef4"), "NE", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2720), "229", false, null, null, "Niger" },
                    { new Guid("26d0e10a-43ea-4654-93be-00a21f60b760"), "PG", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2747), "237", false, null, null, "Papua New Guinea" },
                    { new Guid("298cf3d9-cf13-401f-86b5-368d1c71ec77"), "GQ", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2569), "169", false, null, null, "Guinea Xích Đạo" },
                    { new Guid("2e24284d-fe7b-477b-a3e9-23505ccbe379"), "Z6", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2938), "Z6", false, null, null, "Great Britain (See United Kingdom)" },
                    { new Guid("2eab2085-d20b-4cc4-a85b-7567c9ce6ea9"), "LC", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2652), "247", false, null, null, "Saint Lucia" },
                    { new Guid("2eb9de76-3d99-43a5-b17d-ba2f0e08c64a"), "NI", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2726), "228", false, null, null, "Nicaragua" },
                    { new Guid("2eead3fb-8c57-4699-a48d-b9eb2a781d23"), "TF", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2834), "TF", false, null, null, "French Southern Territories" },
                    { new Guid("2f4455d6-efee-4959-8dfd-6f7db81faadd"), "NP", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2732), "226", false, null, null, "Nepal" },
                    { new Guid("2facb682-01d5-4798-bf0a-928bd471ecb3"), "CC", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2469), "CC", false, null, null, "Cocos (keeling) islands" },
                    { new Guid("332e0e9e-0182-47a0-b894-ade71da83708"), "BB", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2309), "120", false, null, null, "Barbados" },
                    { new Guid("33aeb885-ea5c-4343-8011-b1dccebdd65f"), "SA", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2778), "110", false, null, null, "Ả Rập Saudi" },
                    { new Guid("347a0e24-276d-4a54-b92b-4b88b60179af"), "GM", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2563), "163", false, null, null, "Gambia" },
                    { new Guid("36299397-b100-420b-bd1b-3f18eda310fa"), "TD", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2831), "270", false, null, null, "Tchad" },
                    { new Guid("3671801a-1c88-4dc6-9e75-d766644c2af9"), "SR", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2811), "264", false, null, null, "Suriname" },
                    { new Guid("36ddc306-adf0-4897-a200-6377ff0d9042"), "TT", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2880), "278", false, null, null, "Trinidad và Tobago" },
                    { new Guid("39351753-1af5-4797-89e2-b97589db8d2e"), "AZ", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2947), "114", false, null, null, "Cộng hòa Azerbaijan" },
                    { new Guid("39ef7fcd-b539-46be-90a6-bc3f6d1524d8"), "KR", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2641), "174", false, null, null, "Hàn Quốc" },
                    { new Guid("3adb70b0-ae40-4ac0-8a27-15398cc79d49"), "GS", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2573), "GS", false, null, null, "South georgia and the south sandwich islands" },
                    { new Guid("3af1daa8-65e1-4502-823d-3c8530608104"), "MP", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2690), "MP", false, null, null, "Northern mariana islands" },
                    { new Guid("3d9d9ca5-3356-48b3-b518-eb806a6128ee"), "VU", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2917), "289", false, null, null, "Vanuatu" },
                    { new Guid("3dac050e-a2a6-469b-b0bb-def2e17544a5"), "GW", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2586), "168", false, null, null, "Guinea-Bissau" },
                    { new Guid("3de67d92-a46e-4113-bd12-2e89a48aa1f0"), "CN", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2488), "279", false, null, null, "Trung Quốc" },
                    { new Guid("3edffd99-5e14-4466-9f3e-a72ab48711d7"), "HM", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2590), "HM", false, null, null, "Heard and mc donald islands" },
                    { new Guid("3f3e1d5e-ca7b-45ef-9e1e-f3c471e8894f"), "ST", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2813), "251", false, null, null, "São Tomé và Príncipe" },
                    { new Guid("426516a2-46e9-4103-8b44-22b4a30b21ae"), "LS", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2661), "195", false, null, null, "Lesotho" },
                    { new Guid("4452efd3-9727-4c5c-9cc9-76f7270c673d"), "CI", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2479), "130", false, null, null, "Bờ Biển Ngà" },
                    { new Guid("44ff82d4-3356-4f71-9aa2-dc5f161537f0"), "SY", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2819), "266", false, null, null, "Syria" },
                    { new Guid("45696681-b325-4d55-b4ea-56a920227907"), "SL", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2800), "256", false, null, null, "Sierra Leone" },
                    { new Guid("4589f414-2018-4196-a42a-68fa60b41dae"), "MZ", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2714), "219", false, null, null, "Mozambique" },
                    { new Guid("45a0ebe0-51be-423b-8885-7a7bf06e6f95"), "BA", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2307), "127", false, null, null, "Bosna và Hercegovina" },
                    { new Guid("46651a82-3d63-4a24-baff-9bb1ee8ac492"), "CF", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2473), "280", false, null, null, "Trung Phi" },
                    { new Guid("484be820-41ff-4911-94c6-2d2969764ac4"), "CD", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2471), "145", false, null, null, "Cộng hòa Dân chủ Congo" },
                    { new Guid("4b12f61e-5980-415f-a62b-b296753fd70d"), "PT", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2762), "129", false, null, null, "Bồ Đào Nha" },
                    { new Guid("4b7309a1-de33-4f43-a2ff-3f11e0e5869b"), "SM", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2802), "250", false, null, null, "San Marino" },
                    { new Guid("4bab2495-c861-47e7-82e6-1806fd87b767"), "IM", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2606), "IM", false, null, null, "Isle of man" },
                    { new Guid("4dbc51c5-3faa-4e76-b0d5-a28df95c5c01"), "GT", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2580), "167", false, null, null, "Guatemala" },
                    { new Guid("4dcd4bda-0da9-415d-8f7e-ecd5841ad250"), "ER", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2526), "158", false, null, null, "Eritrea" },
                    { new Guid("4e6e77af-56d6-4314-ac68-c39713511d70"), "IE", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2602), "183", false, null, null, "Ireland" },
                    { new Guid("50202b21-f7c0-42eb-89bd-4470e82f3943"), "JE", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2619), "JE", false, null, null, "Jersey" },
                    { new Guid("502c14cb-18ea-461f-9bc0-9591b056284c"), "DK", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2508), "153", false, null, null, "Đan Mạch" },
                    { new Guid("506ddd2c-4f81-4d6d-806c-4c9e605bab3f"), "KN", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2637), "246", false, null, null, "Saint Kitts và Nevis" },
                    { new Guid("509f7d40-e740-472f-8a7a-84b5a527eb96"), "KG", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2629), "192", false, null, null, "Kyrgyzstan" },
                    { new Guid("50c044c3-6cd1-46ad-b10a-e879291806f2"), "NU", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2735), "NU", false, null, null, "Niue" },
                    { new Guid("52595376-4b2b-4746-bb17-16f7ba234a33"), "MW", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2704), "204", false, null, null, "Malawi" },
                    { new Guid("5300fbb8-1d3b-48c2-b251-c9daab165b94"), "SH", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2792), "SH", false, null, null, "St. Helena" },
                    { new Guid("5351587c-9713-44c9-9088-9626d01300c8"), "TK", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2851), "TK", false, null, null, "Tokelau" },
                    { new Guid("539247ef-f9a9-4893-b250-2aa204a87640"), "VG", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2911), "VG", false, null, null, "Virgin Islands (British)" },
                    { new Guid("53b7d739-4b49-4a35-9d04-93520d79d105"), "TJ", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2847), "267", false, null, null, "Tajikistan" },
                    { new Guid("53fdbb96-c808-4474-83bc-084e422a8b95"), "BY", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2462), "121", false, null, null, "Belarus" },
                    { new Guid("54ca17f4-f6f7-4bcf-9809-8d45153c2271"), "LR", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2659), "197", false, null, null, "Liberia" },
                    { new Guid("561d896e-c3c5-4dfc-b13c-790aa25fbd5d"), "PA", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2741), "236", false, null, null, "Panama" },
                    { new Guid("5701a860-793e-4660-9302-005b27d4348e"), "AO", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2290), "106", false, null, null, "Angola" },
                    { new Guid("573dec77-5908-42b2-b1a5-8a5ee8407dee"), "GD", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2550), "165", false, null, null, "Grenada" },
                    { new Guid("57c01cf1-7f20-4a6c-bec9-bcc9a3a039fe"), "SG", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2790), "257", false, null, null, "Singapore" },
                    { new Guid("58357a87-d3a9-4ea4-82ea-eb7775f1c568"), "IR", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2613), "181", false, null, null, "Iran" },
                    { new Guid("58486abc-86a6-4bb8-a610-eb0e4bdf0b73"), "LT", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2663), "200", false, null, null, "Litva" },
                    { new Guid("58776bc3-ee4b-44ae-ac9e-a501437bde2f"), "PF", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2745), "PF", false, null, null, "French Polynesia" },
                    { new Guid("58d12ab1-4946-45f9-bef5-354e5803f357"), "DO", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2512), "152", false, null, null, "Cộng hòa Dominicana" },
                    { new Guid("59e93599-98e9-44de-b9d1-bbbf17c599bf"), "ZA", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2941), "223", false, null, null, "Nam Phi" },
                    { new Guid("5a68453d-81d4-4417-a579-33d6a1c27ea6"), "PE", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2743), "239", false, null, null, "Peru" },
                    { new Guid("5b526a49-1694-4eb8-b602-4e150d12184d"), "MC", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2673), "216", false, null, null, "Monaco" },
                    { new Guid("5bd03273-5b23-4181-892c-397126e8da56"), "PK", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2751), "234", false, null, null, "Pakistan" },
                    { new Guid("5d60e969-8387-42e4-b866-31dfb209f433"), "Z3", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2932), "Z3", false, null, null, "England" },
                    { new Guid("5dc567de-1249-4aaa-9d49-04dcd3501220"), "ES", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2528), "269", false, null, null, "Tây Ban Nha" },
                    { new Guid("5f4a7dfd-c3ed-4796-bde2-94199e595ef0"), "BV", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2458), "BV", false, null, null, "Bouvet island" },
                    { new Guid("62947f31-4a3e-441b-a9d2-9642ce61de2f"), "KI", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2633), "189", false, null, null, "Kiribati" },
                    { new Guid("62b0c6c0-4a45-4f33-b35e-d184d815518e"), "GH", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2557), "164", false, null, null, "Ghana" },
                    { new Guid("63c8621a-fc44-4abe-ba08-8d80520280cf"), "SC", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2783), "255", false, null, null, "Seychelles" },
                    { new Guid("6477d7a3-465e-4277-a4eb-ef09b13f5eca"), "MO", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2688), "MO", false, null, null, "Macau" },
                    { new Guid("66169c75-2aa7-409a-a7b9-d8cfe6ac80c0"), "LB", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2650), "196", false, null, null, "Li ban" },
                    { new Guid("66400b32-893a-489c-a5e1-180d55fb20d4"), "KE", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2627), "188", false, null, null, "Kenya" },
                    { new Guid("66533605-d826-4aec-9536-e4d30effefda"), "AL", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2284), "103", false, null, null, "Albania" },
                    { new Guid("665d03c6-346e-43d8-ad21-31492b4382aa"), "JO", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2623), "186", false, null, null, "Jordan" },
                    { new Guid("686b79de-db2f-4ccd-946c-1bef80cd503e"), "CA", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2467), "140", false, null, null, "Canada" },
                    { new Guid("6b24b562-1294-4537-a69a-26ac34c41521"), "AD", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2256), "105", false, null, null, "Andorra" },
                    { new Guid("6b8836aa-2476-4d82-98f1-0b7f56e66f7a"), "TL", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2855), "TL", false, null, null, "Timor Leste" },
                    { new Guid("6c408b50-b4be-4eca-a710-11a6d914cf4f"), "AT", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2298), "109", false, null, null, "Áo" },
                    { new Guid("6d2d2371-8785-4a7b-94ba-84c804b2b0a2"), "RE", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2770), "RE", false, null, null, "Reunion" },
                    { new Guid("6d5a6761-432b-4bd2-9b04-5e01c421de23"), "NF", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2722), "NF", false, null, null, "Norfolk Island" },
                    { new Guid("716a0688-0378-4941-af8f-c11dc4c45ac2"), "TC", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2827), "TC", false, null, null, "Turks and Caicos Islands" },
                    { new Guid("720aaa71-3cc0-470f-b56c-472ac37a6574"), "BE", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2313), "125", false, null, null, "Bỉ" },
                    { new Guid("72d527d4-00df-4f9a-b0e1-e1fa84a4ba6d"), "SO", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2809), "261", false, null, null, "Somalia" },
                    { new Guid("74c266fd-7287-4525-aca3-6bb66ddcf61f"), "WS", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2921), "249", false, null, null, "Samoa" },
                    { new Guid("75de9dea-ef0f-4492-890a-f5af36cce7aa"), "CG", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2475), "144", false, null, null, "Cộng hòa Congo" },
                    { new Guid("76c42f0f-bfb2-4a11-b5a4-e854f74e72cd"), "BZ", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2465), "122", false, null, null, "Belize" },
                    { new Guid("77365013-80d7-44d5-bd8d-472542cac431"), "MQ", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2692), "MQ", false, null, null, "Martinique" },
                    { new Guid("788693d2-4ac9-4f85-94bf-13d021bc000d"), "PM", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2755), "PM", false, null, null, "St. Pierre and Miquelon" },
                    { new Guid("78dcfd52-de7b-4c1d-9ded-0e5d3f7a8a35"), "MT", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2698), "208", false, null, null, "Malta" },
                    { new Guid("79bc1ba0-a0f6-4065-9783-9e01ade32cde"), "PN", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2757), "PN", false, null, null, "Pitcairn" },
                    { new Guid("7a384197-d55e-44b8-b389-a65f17e74e1f"), "PH", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2749), "242", false, null, null, "Philippines" },
                    { new Guid("7af80a81-41e5-47de-abd3-7ce25f9c39b4"), "TM", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2859), "282", false, null, null, "Turkmenistan" },
                    { new Guid("7afaefc0-9aa8-4ba7-98ae-618682a5be7f"), "KM", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2635), "143", false, null, null, "Comoros" },
                    { new Guid("7b0c9a9c-e730-4b96-9372-e9ef8ab5339b"), "BM", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2330), "BM", false, null, null, "Bermuda" },
                    { new Guid("7bea406c-221d-45dd-aca6-a2ceb90741aa"), "DM", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2510), "151", false, null, null, "Dominica" },
                    { new Guid("7e27cb42-41fb-4b20-b26b-3c1ea9b4ff5c"), "SB", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2780), "260", false, null, null, "Solomon" },
                    { new Guid("7ef68b6d-2d6b-4688-95bc-d0fd79ffb6c5"), "CY", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2500), "191", false, null, null, "Síp" },
                    { new Guid("7f233816-fe94-4941-8125-b62c88410fa9"), "BD", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2311), "119", false, null, null, "Bangladesh" },
                    { new Guid("8562fd7f-49aa-46cf-bbc9-71f7460c6ba7"), "SZ", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2823), "265", false, null, null, "Swaziland" },
                    { new Guid("8592d87f-720b-48e7-82ee-e82d64cbf984"), "AG", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2278), "108", false, null, null, "Antigua và Barbuda" },
                    { new Guid("8764ee96-c950-44cf-a1f4-7636126c671b"), "BS", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2338), "116", false, null, null, "Bahamas" },
                    { new Guid("882c80ef-806d-4370-9fb1-f00a13a7a5c1"), "LV", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2667), "194", false, null, null, "Latvia" },
                    { new Guid("8a003437-323c-451c-b211-1886f79c25f1"), "MV", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2702), "206", false, null, null, "Maldives" },
                    { new Guid("8a6a8442-1533-4bba-9a05-ed707122573e"), "GR", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2571), "178", false, null, null, "Hy Lạp" },
                    { new Guid("8f800608-e254-418d-8163-78f71be4873f"), "EG", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2522), "102", false, null, null, "Ai Cập" },
                    { new Guid("8ff51ea0-476b-4dec-8736-70cc36ea1d2c"), "NO", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2730), "225", false, null, null, "Na Uy" },
                    { new Guid("90b2a6a0-bacd-4175-80e9-b8fde9233786"), "KW", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2643), "190", false, null, null, "Kuwait" },
                    { new Guid("90ef0553-8520-4d57-ae3b-112ebf28b313"), "ZW", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2945), "295", false, null, null, "Zimbabwe" },
                    { new Guid("92aea1da-5cf2-40fa-92a2-cce297949451"), "SI", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2794), "259", false, null, null, "Slovenia" },
                    { new Guid("92b69f82-f3e2-4ea9-9d4b-1763b1a75dec"), "MX", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2710), "213", false, null, null, "Mexico" },
                    { new Guid("93fc49be-bd23-41c3-8538-4b424a7806da"), "CV", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2496), "CV", false, null, null, "Cape verde" },
                    { new Guid("9412c9e0-c4fe-442f-8b13-ea064bf48703"), "LI", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2655), "199", false, null, null, "Liechtenstein" },
                    { new Guid("9601fc62-41b1-44af-af8e-8a03c91c96b8"), "JP", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2625), "232", false, null, null, "Nhật Bản" },
                    { new Guid("97bc234b-7d4c-4870-801b-74f1998741be"), "US", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2899), "175", false, null, null, "Hoa Kỳ" },
                    { new Guid("98062645-5015-4d8c-886e-3fb70c247ada"), "GP", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2567), "GP", false, null, null, "Guadeloupe" },
                    { new Guid("994cf06f-b833-4415-84e0-94f3847b6dd8"), "KY", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2644), "KY", false, null, null, "Cayman islands" },
                    { new Guid("99cfce62-6540-4525-97b8-9a2e62618e05"), "SJ", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2796), "SJ", false, null, null, "Svalbard and Jan Mayen Islands" },
                    { new Guid("9acb769e-d2de-479c-b66a-424ce710a036"), "NG", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2724), "230", false, null, null, "Nigeria" },
                    { new Guid("9d5769fe-b3ae-4697-9150-44674e8008ba"), "DE", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2504), "155", false, null, null, "Đức" },
                    { new Guid("9ded845f-06a1-4651-8903-bc46f7978c84"), "GE", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2552), "GE", false, null, null, "Georgia" },
                    { new Guid("9eb57842-f592-4080-affd-71b43f7d0517"), "AQ", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2292), "AQ", false, null, null, "Antarctica" },
                    { new Guid("9ee7b166-4c6f-4136-8928-c6246c3e76d5"), "UZ", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2902), "288", false, null, null, "Uzbekistan" },
                    { new Guid("a1080c01-e5bb-4e3f-8784-f0678f1eff58"), "DJ", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2506), "150", false, null, null, "Djibouti" },
                    { new Guid("a1ba5be8-fef9-470a-a5f7-efcf7fc900a4"), "ME", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2926), "218", false, null, null, "Montenegro" },
                    { new Guid("a1f120ed-4785-486e-b796-dd8cd569a415"), "VC", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2906), "248", false, null, null, "Saint Vincent và Grenadines" },
                    { new Guid("a30f588b-166d-4118-9d33-b8294e15ad44"), "SD", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2786), "263", false, null, null, "Sudan" },
                    { new Guid("a3597652-cc84-40ff-b143-208ee8473e93"), "EA", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2516), "154", false, null, null, "Đông Timor" },
                    { new Guid("a3c5c224-a013-4e23-8655-641a0a76b38a"), "PW", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2764), "235", false, null, null, "Palau" },
                    { new Guid("a695b824-cfc2-40a3-b5a1-35243a6e2116"), "YE", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2923), "293", false, null, null, "Yemen" },
                    { new Guid("a7a696de-3fd8-48c2-b87a-6464b222af87"), "VE", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2908), "291", false, null, null, "Venezuela" },
                    { new Guid("a8b38e56-d3ea-435f-907a-615ed7ced805"), "AF", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2951), "101", false, null, null, "Afghanistan" },
                    { new Guid("aa3d56b9-f398-4be1-b8ae-9f8563101b6e"), "IT", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2617), "292", false, null, null, "Ý" },
                    { new Guid("aa4399ec-1ff3-4837-a68e-0df0720162cb"), "MR", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2694), "211", false, null, null, "Mauritanie" },
                    { new Guid("aa745539-b444-49d2-ad13-14149f8a1645"), "BO", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2334), "126", false, null, null, "Bolivia" },
                    { new Guid("ab16a3ed-00cd-4445-8e7c-770b1965232e"), "NL", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2728), "173", false, null, null, "Hà Lan" },
                    { new Guid("abdfeb5b-a4b8-4ab1-b6b8-83f7fb72ec23"), "EE", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2520), "159", false, null, null, "Estonia" },
                    { new Guid("ad4ef5f1-e823-4ed4-9ad5-cec4a2cae6af"), "UG", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2895), "285", false, null, null, "Uganda" },
                    { new Guid("af24512b-01ae-4420-96cb-62051ede96cc"), "UA", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2893), "286", false, null, null, "Ukraina" },
                    { new Guid("af3badc9-b6da-4eb0-8a42-ecf8dfd6ae19"), "AM", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2286), "112", false, null, null, "Armenia" },
                    { new Guid("af9c2425-679e-4459-8c68-2d357f4f93e5"), "PY", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2766), "238", false, null, null, "Paraguay" },
                    { new Guid("affdf19e-5ed4-497a-97d0-0fc95a547785"), "LK", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2657), "262", false, null, null, "Sri Lanka" },
                    { new Guid("b16a509f-5c70-42b1-a05e-6d4426c721ca"), "IQ", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2612), "182", false, null, null, "Iraq" },
                    { new Guid("b171e933-4b7d-46f5-802a-14c5c9234ed7"), "ML", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2682), "207", false, null, null, "Mali" },
                    { new Guid("b1829e62-c3dd-4f65-8c41-fdbe26aedb93"), "MG", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2677), "203", false, null, null, "Madagascar" },
                    { new Guid("b4e019b1-042b-465c-baf9-60d525d9b85c"), "CK", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2482), "CK", false, null, null, "Cook islands" },
                    { new Guid("b6169a90-920f-425d-a275-82601862a220"), "SK", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2798), "258", false, null, null, "Slovakia" },
                    { new Guid("b83926c4-6963-4f82-97f7-dffa6e87ea7d"), "MK", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2681), "202", false, null, null, "Macedonia" },
                    { new Guid("b83be42b-cde9-4dc3-a838-d8197d2c678f"), "FO", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2540), "FO", false, null, null, "Faroe islands" },
                    { new Guid("ba7304bd-7e25-4731-a60f-10c13589c71a"), "ET", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2530), "160", false, null, null, "Ethiopia" },
                    { new Guid("ba947c48-36fb-420b-b2d9-663fe308b18c"), "TG", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2839), "275", false, null, null, "Togo" },
                    { new Guid("bcb96598-0e05-4316-86d3-80413326555a"), "MH", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2679), "210", false, null, null, "Quần đảo Marshall" },
                    { new Guid("be946a16-a1af-499c-9bd8-ca12a22fb69c"), "CU", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2494), "149", false, null, null, "Cuba" },
                    { new Guid("bf1bf333-4604-4974-838f-886100c006f3"), "TW", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2889), "TW", false, null, null, "Đài Loan" },
                    { new Guid("c4065df0-2539-4046-bb77-7d699a072734"), "FM", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2538), "214", false, null, null, "Micronesia" },
                    { new Guid("c5c14db2-753f-4e28-88b5-3b9e502fa0c6"), "BN", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2332), "132", false, null, null, "Brunei" },
                    { new Guid("c6f6287f-39f6-4470-ad46-ac539eef3052"), "EC", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2518), "156", false, null, null, "Ecuador" },
                    { new Guid("c7f500b0-be15-4ab8-ae5c-1db430d19b8c"), "YT", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2924), "YT", false, null, null, "Mayotte" },
                    { new Guid("c831fb16-910b-4939-804a-1052b8f8adc1"), "HT", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2596), "172", false, null, null, "Haiti" },
                    { new Guid("c8766416-ed13-4631-a9c4-e89e782055c9"), "Z7", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2940), "Z7", false, null, null, "Wales" },
                    { new Guid("cba207c9-9ee4-4a20-876b-ecb1160d0845"), "SN", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2807), "253", false, null, null, "Sénégal" },
                    { new Guid("cbf1c521-494b-4981-9dc9-b6a1b229c01d"), "JM", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2621), "185", false, null, null, "Jamaica" },
                    { new Guid("cc2a4d3b-bae2-4602-9d23-4d4d2d918699"), "MD", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2675), "215", false, null, null, "Moldova" },
                    { new Guid("cdd52492-d981-4972-9f41-4b1774c002ee"), "GI", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2559), "GI", false, null, null, "Gibraltar" },
                    { new Guid("cf8c2ebc-2ed1-404c-875c-d2151d54ab9e"), "MM", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2684), "220", false, null, null, "Myanma" },
                    { new Guid("d0357290-582a-47cd-984c-8815d38454be"), "Z5", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2936), "Z5", false, null, null, "Northern Ireland" },
                    { new Guid("d1fef153-87bc-403a-9590-0ec4cc8d676e"), "PL", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2753), "118", false, null, null, "Ba Lan" },
                    { new Guid("d200b4b5-7435-41a9-be8b-b6a80e14120b"), "IO", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2610), "IO", false, null, null, "British indian ocean territory" },
                    { new Guid("d2ebac27-3463-40cb-9eb2-86e1da12a3ba"), "MS", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2696), "MS", false, null, null, "Montserrat" },
                    { new Guid("d34d65e5-253f-4324-9aee-f74045802e47"), "GG", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2556), "GG", false, null, null, "Guernsey" },
                    { new Guid("d3c10501-b94f-4a0e-b871-80d4b3d7bbbb"), "HK", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2588), "HK", false, null, null, "Hong kong" },
                    { new Guid("d50a063a-82ef-4b56-858e-1a8794b32878"), "HN", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2592), "176", false, null, null, "Honduras" },
                    { new Guid("d576474f-de6a-45fc-bd19-e18a2915f1a4"), "CR", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2492), "146", false, null, null, "Costa Rica" },
                    { new Guid("d892c6c0-bf86-4487-ab8b-5af35cc32a0c"), "GV", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2584), "171", false, null, null, "Guyana" },
                    { new Guid("d94b5935-e6d2-4aa7-b9f7-d332badacd8d"), "BT", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2344), "124", false, null, null, "Bhutan" },
                    { new Guid("da333d92-e16c-4b49-b9d8-669df9032f82"), "FJ", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2534), "161", false, null, null, "Fiji" },
                    { new Guid("dd79ead4-6e12-4cb8-aff5-8f00d8bf9e99"), "SD", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2949), "222", false, null, null, "Nam Sudan" },
                    { new Guid("dd951a03-c803-4351-aac5-ed4ec9922bab"), "QA", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2768), "243", false, null, null, "Qatar" },
                    { new Guid("ddf4ecad-6f97-4bde-84fe-2b9dc51f0ffd"), "BW", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2460), "128", false, null, null, "Botswana" },
                    { new Guid("de0d7be8-8a87-4358-b93e-e809ab17f238"), "RO", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2772), "244", false, null, null, "Romania" },
                    { new Guid("e180ff8a-4e49-4edd-9168-21b372b8d9b7"), "BG", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2317), "133", false, null, null, "Bulgaria" },
                    { new Guid("e1fc9395-73b5-4fd6-8c31-37fef3a3e866"), "ZM", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2943), "294", false, null, null, "Zambia" },
                    { new Guid("e369137c-1730-4809-88e4-e43031327233"), "BF", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2315), "134", false, null, null, "Burkina Faso" },
                    { new Guid("e3a2237c-9d57-462f-bad8-7a78856303c8"), "ID", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2600), "180", false, null, null, "Indonesia" },
                    { new Guid("e43c3f5c-e8d7-430a-9869-e61337bd4188"), "Z2", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2930), "Z2", false, null, null, "British Southern and Antarctic Territories" },
                    { new Guid("e4acc3fd-7e2d-4927-b7e8-797cb8a29a86"), "GU", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2582), "GU", false, null, null, "Guam" },
                    { new Guid("e4c05566-0c8d-42a4-a2e9-ad4d6d33b35f"), "AI", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2282), "AI", false, null, null, "Anguilla" },
                    { new Guid("e5439053-279d-4094-852d-0c2edc6992ed"), "SV", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2815), "157", false, null, null, "El Salvador" },
                    { new Guid("e5837adb-d926-41f1-8434-73fed9db7504"), "AW", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2303), "AW", false, null, null, "Aruba việt nam" },
                    { new Guid("e6e7518f-73eb-4010-b0cf-6dcc5c8f8e01"), "DZ", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2514), "104", false, null, null, "Algérie" },
                    { new Guid("e9455b51-bd57-482f-a979-5ecf6c8c4afd"), "GB", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2548), "107", false, null, null, "Vương quốc Liên hiệp Anh và Bắc Ireland" },
                    { new Guid("edb5a6e1-b084-4e46-87ab-22d38da9cf0a"), "UY", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2900), "287", false, null, null, "Uruguay" },
                    { new Guid("edcecb3c-ffcb-451f-8e24-02a0bf6499ae"), "IN", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2608), "115", false, null, null, "Cộng hòa Ấn Độ" },
                    { new Guid("ee02aa87-f8dc-44ac-9ac9-830120f05656"), "TR", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2876), "272", false, null, null, "Thổ Nhĩ Kỳ" },
                    { new Guid("ee707e39-4195-426c-abf9-1ce21a771350"), "NA", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2716), "221", false, null, null, "Namibia" },
                    { new Guid("f034e368-335c-4a9f-a039-b7ea83f8a315"), "LU", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2665), "201", false, null, null, "Luxembourg" },
                    { new Guid("f07d3dde-aea1-4f0a-ba9d-310cda4fa6e9"), "TH", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2843), "271", false, null, null, "Thái Lan" },
                    { new Guid("f1218849-b5cf-43c8-b3c4-b1ff145f27fc"), "MU", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2700), "212", false, null, null, "Mauritius" },
                    { new Guid("f1c02c7d-3154-4e55-817c-1e24f6eef729"), "GA", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2546), "162", false, null, null, "Gabon" },
                    { new Guid("f21a86da-a1de-4023-93c9-3a23d315a8cd"), "RW", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2776), "245", false, null, null, "Rwanda" },
                    { new Guid("f36eb030-510e-4ca0-b7c4-a1c1ef656dd6"), "FK", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2536), "FK", false, null, null, "Falkland islands (malvinas)" },
                    { new Guid("f468cb27-57fb-4b75-b3b7-70bb33ca2705"), "KH", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2631), "139", false, null, null, "Campuchia" },
                    { new Guid("f5874f17-6c1e-4c07-b8bf-41b76546f6f0"), "CM", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2486), "138", false, null, null, "Cameroon" },
                    { new Guid("f5f9c1ed-f4fb-4cff-aee3-2bcb0d8eed3e"), "NC", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2718), "NC", false, null, null, "New Caledonia" },
                    { new Guid("f5fdcb6c-e0c5-4a57-adca-e743ba60ccee"), "LY", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2669), "198", false, null, null, "Libya" },
                    { new Guid("f79baaf7-6191-4ba9-b38a-2f1b50d05598"), "TV", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2887), "283", false, null, null, "Tuvalu" },
                    { new Guid("f9375017-9897-4487-8916-c98d22fd05b9"), "GL", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2561), "GL", false, null, null, "Greenland" },
                    { new Guid("fb10ce71-e68a-4a70-bf7e-5edee9388d48"), "AE", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2276), "137", false, null, null, "Các Tiểu Vương quốc Ả Rập Thống nhất" },
                    { new Guid("fb67b422-6903-494e-945d-fa09f031b4f1"), "VI", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2913), "VI", false, null, null, "Virgin Islands (U.S.)" },
                    { new Guid("fc5a0c05-ebac-4906-8a9f-dddcdbcc0a9d"), "AU", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2301), "284", false, null, null, "Úc" },
                    { new Guid("fd0ac376-bf65-4bf8-9067-245691aa1827"), "HR", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2594), "147", false, null, null, "Croatia" },
                    { new Guid("fd21963c-7b5e-44a8-8d70-2edbda437946"), "MN", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2686), "217", false, null, null, "Mông Cổ" },
                    { new Guid("fd235817-1607-4f4c-83c7-ff5bd0012896"), "BJ", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2323), "123", false, null, null, "Benin" },
                    { new Guid("fd32d265-24dd-4073-a4b8-59e6358b59ed"), "AR", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2294), "111", false, null, null, "Argentina" },
                    { new Guid("fe657d37-7960-4bb3-8f15-81666fca928d"), "EH", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2524), "EH", false, null, null, "Western sahara" },
                    { new Guid("ff78779a-45cd-4076-8c61-442a9a3873f2"), "TZ", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2891), "268", false, null, null, "Tanzania" },
                    { new Guid("ffd3fabd-a5f1-4442-837b-d53b5d89272e"), "WF", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(2919), "WF", false, null, null, "Wallis and Futuna Islands" }
                });

            migrationBuilder.InsertData(
                table: "DeathCauses",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "DISEASE", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Do bệnh", 1 },
                    { 2, "COMPLICATION", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Do tai biến điều trị", 2 },
                    { 99, "OTHER", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Khác", 99 }
                });

            migrationBuilder.InsertData(
                table: "DeathWithins",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "WITHIN_24H", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Trong 24h vào", 1 },
                    { 2, "WITHIN_48H", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Trong 48h vào", 2 },
                    { 3, "WITHIN_72H", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Trong 72h vào", 3 },
                    { 99, "OTHER", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Khác", 99 }
                });

            migrationBuilder.InsertData(
                table: "DepartmentType",
                columns: new[] { "Id", "Code", "Description", "Inactive", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "LS", null, false, "Khoa lâm sàng", 1 },
                    { 2, "CLS", null, false, "Khoa cận lâm sàng", 2 },
                    { 3, "DUOC", null, false, "Khoa dược", 3 },
                    { 4, "KHTH", null, false, "Kế hoạch tổng hợp", 4 }
                });

            migrationBuilder.InsertData(
                table: "Ethnic",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Description", "Inactive", "IsDeleted", "ModifiedBy", "ModifiedDate", "MohCode", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170901"), "01", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(3972), null, null, null, false, false, null, null, "13", "Ba na", 1 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170902"), "02", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(3975), null, null, null, false, false, null, null, "49", "Bố y", 2 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170903"), "03", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(3977), null, null, null, false, false, null, null, "52", "Brâu", 3 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170904"), "04", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(3978), null, null, null, false, false, null, null, "17", "Chăm", 4 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170905"), "05", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(3980), null, null, null, false, false, null, null, "32", "Chơ ro", 5 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170906"), "06", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(3982), null, null, null, false, false, null, null, "36", "Chu ru", 6 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170907"), "07", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(3983), null, null, null, false, false, null, null, "44", "Chứt", 7 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170908"), "08", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(3985), null, null, null, false, false, null, null, "30", "Co", 8 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170909"), "09", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(3987), null, null, null, false, false, null, null, "48", "Cống", 9 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170910"), "10", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(3989), null, null, null, false, false, null, null, "16", "Cơ ho", 10 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170911"), "11", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(3990), null, null, null, false, false, null, null, "47", "Cờ lao", 11 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170912"), "12", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(3992), null, null, null, false, false, null, null, "9", "Dao", 12 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170913"), "13", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(3994), null, null, null, false, false, null, null, "12", "Ê đê", 13 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170914"), "14", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(3996), null, null, null, false, false, null, null, "10", "Gia rai", 14 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170915"), "15", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(3997), null, null, null, false, false, null, null, "25", "Giấy", 15 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170916"), "16", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(3999), null, null, null, false, false, null, null, "27", "Gié triêng", 16 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170917"), "17", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4001), null, null, null, false, false, null, null, "8", "H mông", 17 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170918"), "18", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4002), null, null, null, false, false, null, null, "19", "H rê", 18 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170919"), "19", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4004), null, null, null, false, false, null, null, "35", "Hà nhì", 19 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170920"), "20", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4006), null, null, null, false, false, null, null, "4", "Hoa", 20 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170921"), "21", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4008), null, null, null, false, false, null, null, "26", "K tu", 21 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170922"), "22", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4009), null, null, null, false, false, null, null, "33", "Kháng", 22 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170923"), "23", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4011), null, null, null, false, false, null, null, "5", "Khơ me", 23 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170924"), "24", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4013), null, null, null, false, false, null, null, "29", "Khơ mú", 24 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170925"), "25", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4014), null, null, null, false, false, null, null, "1", "Kinh", 25 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170926"), "26", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4016), null, null, null, false, false, null, null, "38", "La chí", 26 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170927"), "27", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4018), null, null, null, false, false, null, null, "39", "La ha", 27 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170928"), "28", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4019), null, null, null, false, false, null, null, "41", "La hù", 28 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170929"), "29", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4021), null, null, null, false, false, null, null, "37", "Lào", 29 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170930"), "30", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4023), null, null, null, false, false, null, null, "43", "Lô lô", 30 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170931"), "31", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4024), null, null, null, false, false, null, null, "42", "Lự", 31 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170932"), "32", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4026), null, null, null, false, false, null, null, "20", "M nông", 32 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170933"), "33", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4028), null, null, null, false, false, null, null, "28", "Mạ", 33 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170934"), "34", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4029), null, null, null, false, false, null, null, "45", "Mảng", 34 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170935"), "35", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4036), null, null, null, false, false, null, null, "6", "Mường", 35 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170936"), "36", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4038), null, null, null, false, false, null, null, "11", "Ngái", 36 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170937"), "37", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4040), null, null, null, false, false, null, null, "7", "Nùng", 37 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170938"), "38", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4042), null, null, null, false, false, null, null, "53", "Ơ đu", 38 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170939"), "39", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4043), null, null, null, false, false, null, null, "46", "Pà thén", 39 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170940"), "40", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4045), null, null, null, false, false, null, null, "40", "Phù lá", 40 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170941"), "41", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4047), null, null, null, false, false, null, null, "51", "Pu péo", 41 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170942"), "42", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4048), null, null, null, false, false, null, null, "21", "Rag lai", 42 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170943"), "43", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4050), null, null, null, false, false, null, null, "54", "Rơ man", 43 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170944"), "44", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4052), null, null, null, false, false, null, null, "15", "Sán chay", 44 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170945"), "45", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4054), null, null, null, false, false, null, null, "18", "Sán dìu", 45 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170946"), "46", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4055), null, null, null, false, false, null, null, "50", "Si la", 46 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170947"), "47", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4057), null, null, null, false, false, null, null, "31", "Tà ôi", 47 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170948"), "48", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4059), null, null, null, false, false, null, null, "2", "Tày", 48 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170949"), "49", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4060), null, null, null, false, false, null, null, "3", "Thái", 49 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170950"), "50", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4062), null, null, null, false, false, null, null, "24", "Thố", 50 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170951"), "51", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4064), null, null, null, false, false, null, null, "23", "Vân kiều", 51 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170952"), "52", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4065), null, null, null, false, false, null, null, "22", "X tiêng", 52 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170953"), "53", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4067), null, null, null, false, false, null, null, "34", "Xinh mun", 53 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170954"), "54", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4069), null, null, null, false, false, null, null, "14", "Xơ đăng", 54 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170999"), "99", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4070), null, null, null, false, false, null, null, "55", "Nước ngoài", 99 }
                });

            migrationBuilder.InsertData(
                table: "Gender",
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
                table: "ItemGroups",
                columns: new[] { "Id", "Code", "CommodityType", "Inactive", "IsSystem", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("00be783e-d679-4f1c-9ae2-a4f4c79de0ef"), "TKSV", 0, false, true, "Thuốc kháng sinh viên", 4 },
                    { new Guid("05a24915-0bed-4f61-b53d-b5e52482e44c"), "TK", 0, false, true, "Thuốc khác", 21 },
                    { new Guid("077fe8b3-03d1-4c4c-b7be-5f7fb2015957"), "VTAC", 1, false, true, "Vật tư ấn chỉ", 27 },
                    { new Guid("18b82fb4-2ba8-4713-871f-3ba51c031b42"), "VTTH", 1, false, true, "Vật tư tiêu hoa", 23 },
                    { new Guid("25454ce7-bff0-4fd5-a47a-069554c1535a"), "VC", 0, false, true, "Vaccine", 19 },
                    { new Guid("27988a81-eeab-41f0-a279-c774259ecdcf"), "VTCC", 1, false, true, "Vật tư công cụ - dụng cụ", 30 },
                    { new Guid("2a8c130b-8170-4776-b3bc-51eb9da01d35"), "VTNV", 1, false, true, "Vật tư nẹp vít", 26 },
                    { new Guid("2f5148cb-8adf-45ec-88ee-f84530cfa164"), "THTT", 0, false, true, "Thuốc hướng tâm thần", 10 },
                    { new Guid("2fd41f93-ddb9-47dd-9833-4507ce71128c"), "TV", 0, false, true, "Thuốc viên", 1 },
                    { new Guid("3144745c-477c-4ce2-9c33-a38eb2153057"), "SP", 0, false, true, "Sinh phẩm", 18 },
                    { new Guid("31d26ca7-2b5f-4dfd-b961-f3609e6a0b69"), "TCO", 0, false, true, "Nhóm thuốc corticoid", 12 },
                    { new Guid("35df3868-8db6-440d-809f-f4c345d804a7"), "TS", 0, false, true, "Thuốc siro", 6 },
                    { new Guid("54eed868-2c02-46b3-acdf-e064a4ddb893"), "VTXH", 1, false, true, "Vật tư xã hội hóa", 31 },
                    { new Guid("58215bd0-ff85-45b4-90bb-4550f7e97838"), "VTHC", 1, false, true, "Vật tư hóa chất", 25 },
                    { new Guid("58291959-c2ca-45d6-b68d-ef81568fc163"), "VTXH", 1, false, true, "Vật tư khác", 32 },
                    { new Guid("6375b8a1-b6e7-4724-a1b4-8cc3acc98e43"), "KCVI", 0, false, true, "Khoáng chất và Vitamin", 5 },
                    { new Guid("8590ae3d-351c-4438-bfe5-3f69dcf97349"), "TB", 0, false, true, "Thuốc bột", 8 },
                    { new Guid("891ad741-f6dc-48ee-be99-3e678b5e8f6c"), "VTTT", 1, false, true, "Vật tư thay thế", 24 },
                    { new Guid("914ca65d-6579-4590-b963-fee8a743bae1"), "DC", 0, false, true, "Dịch truyền", 3 },
                    { new Guid("9e144dff-29f6-47da-b7ed-b55abd1a2cd3"), "VTNT", 0, false, true, "Vật tư nhà thuốc", 20 },
                    { new Guid("a15b74b8-1a38-42de-b958-a62bbd5d8a02"), "VTTB", 1, false, true, "Vật tư thiết bị y tế", 28 },
                    { new Guid("a28fb46e-e9b9-410e-9c31-d8ebfd22015c"), "TKTT", 0, false, true, "Thuốc kê tự túc", 16 },
                    { new Guid("ae04abd7-d012-470d-9b8a-f38d9c5c94a8"), "TG", 0, false, true, "Thuốc gói", 14 },
                    { new Guid("b5f03233-d733-4349-93df-db562b7d4376"), "THD", 0, false, true, "Thuốc hỗn dịch", 6 },
                    { new Guid("c987b9d2-e599-49cc-99f3-d075d27cee7c"), "TDY", 0, false, true, "Thuốc đông y", 5 },
                    { new Guid("c9c64187-bf8c-49f4-8b5b-2a04c9aafb5b"), "VTYT", 1, false, true, "Vật tư y tế", 22 },
                    { new Guid("cc48bb40-fbf0-4054-818c-eb49545aaeea"), "TDN", 0, false, true, "Thuốc dùng ngoài", 7 },
                    { new Guid("cd5d7538-b1d2-448d-b6ff-c139c35f9dc7"), "TGTM", 0, false, true, "Thuốc gây tê, mê", 13 },
                    { new Guid("d3ee2c41-ac9f-4356-8b76-a9b319929970"), "VTDC", 1, false, true, "Vật tư dụng cụ", 29 },
                    { new Guid("ddf105e8-6534-46e4-832b-598daa84c4d5"), "TGN", 0, false, true, "Thuốc gây nghiện", 9 },
                    { new Guid("e47ab5de-9ea5-4075-8da5-7ae9f36538e2"), "TUT", 0, false, true, "Thuốc ung thư", 15 },
                    { new Guid("e482e866-9243-49d8-8676-403377de353c"), "TKSO", 0, false, true, "Thuốc kháng sinh ống", 11 },
                    { new Guid("ea57a262-6647-4e88-880c-82bc4227e916"), "TNM", 0, false, true, "Thuốc nhỏ mắt", 17 },
                    { new Guid("ff9be71e-a958-4244-9df1-1582229c67d5"), "TU", 0, false, true, "Thuốc uống", 2 }
                });

            migrationBuilder.InsertData(
                table: "ItemLines",
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
                table: "MedicalRecordEndTypes",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "IsForInPatient", "IsForOutPatient", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "CAPTOACHOVE", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, true, null, null, "Cấp toa cho về", 1 },
                    { 2, "HEN", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, true, null, null, "Hẹn", 1 },
                    { 3, "CHUYEN_PHONGKHAM", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, true, null, null, "Chuyển phòng khám", 2 },
                    { 4, "DTRI_NGOAITRU", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, true, null, null, "Điều trị ngoại trú", 3 },
                    { 5, "NHAPVIEN", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, true, null, null, "Nhập viện", 4 },
                    { 6, "BOKHAM", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, true, null, null, "Bỏ khám", 5 },
                    { 7, "CHUYEN_KHOA", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, true, null, null, "Chuyển khoa", 8 },
                    { 8, "RAVIEN", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, false, null, null, "Ra viện", 1 },
                    { 9, "XINVE", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, false, null, null, "Xin về", 2 },
                    { 10, "DUAVE", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, false, null, null, "Đưa về", 3 },
                    { 11, "TRONVIEN", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, false, null, null, "Trốn viện", 4 },
                    { 12, "CHUYEN_TUYEN", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, true, null, null, "Chuyển tuyến", 6 },
                    { 13, "TUVONG", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, true, null, null, "Tử vong", 7 },
                    { 99, "KHAC", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, true, null, null, "Khác", 99 }
                });

            migrationBuilder.InsertData(
                table: "MedicalRecordResults",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "KHOI", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Khỏi", 1 },
                    { 2, "DO_GIAM", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Đỡ, giảm", 2 },
                    { 3, "KHONGTHAYDOI", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Không thay đổi", 3 },
                    { 4, "NANGHON", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Nặng hơn", 4 },
                    { 5, "TUVONG", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Tử vong", 5 },
                    { 99, "KHAC", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, null, null, "Khác", 6 }
                });

            migrationBuilder.InsertData(
                table: "PatientRecordTypes",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "NOITRU", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Nội trú", 1 },
                    { 2, "NGOAITRU", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Ngoại trú", 2 },
                    { 3, "DICHVU", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Dịch vụ", 3 }
                });

            migrationBuilder.InsertData(
                table: "PatientType",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "BHYT", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Bảo hiểm y tế", 1 },
                    { 2, "VP", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Viện phí", 2 },
                    { 3, "DV", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Dịch vụ", 3 }
                });

            migrationBuilder.InsertData(
                table: "ReceptionType",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "KB", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Khám bệnh", 1 },
                    { 2, "CC", null, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Cấp cứu", 2 }
                });

            migrationBuilder.InsertData(
                table: "RelativeType",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("1376a459-2acd-42e2-a7a7-2591f74b21eb"), "03", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4101), null, false, null, null, "Bố nuôi", 3 },
                    { new Guid("1daedd7e-7ca2-4fdb-9956-4fa4c7718a79"), "07", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4108), null, false, null, null, "Em ruột", 7 },
                    { new Guid("3b8fbd78-7899-4b81-832a-da090f149077"), "00", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4111), null, false, null, null, "Bà", 9 },
                    { new Guid("4252af04-6cfe-4476-bb99-4a922b6bc0ad"), "05", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4104), null, false, null, null, "Anh ruột", 5 },
                    { new Guid("694a319f-11d3-4e0e-bf68-c99aa89b8d95"), "01", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4095), null, false, null, null, "Bố đẻ", 1 },
                    { new Guid("6a46d932-03d2-477b-be50-1a5e791ecb94"), "10", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4113), null, false, null, null, "Vợ", 10 },
                    { new Guid("826cfc0a-538b-4cb8-86cf-3f61b3c58a7f"), "99", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4118), null, false, null, null, "Khác", 99 },
                    { new Guid("8e15b578-7302-4e88-97aa-0b956759eaee"), "11", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4114), null, false, null, null, "Chồng", 11 },
                    { new Guid("9f3e6fc7-ef22-4ba4-9e59-8cca8b6cb195"), "08", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4109), null, false, null, null, "Ông", 8 },
                    { new Guid("a08c20c4-3e67-429f-a6c8-f32aeaeb3532"), "12", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4116), null, false, null, null, "Con", 12 },
                    { new Guid("a734da32-8028-4210-bae5-98bda97961ff"), "06", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4106), null, false, null, null, "Chị ruột", 6 },
                    { new Guid("bcabc031-806f-452a-84da-77d554e5a5b4"), "04", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4103), null, false, null, null, "Mẹ nuôi", 4 },
                    { new Guid("ccbee237-acf6-47f2-9c39-ed544222712e"), "02", null, new DateTime(2023, 11, 9, 21, 19, 46, 401, DateTimeKind.Local).AddTicks(4097), null, false, null, null, "Mẹ đẻ", 2 }
                });

            migrationBuilder.InsertData(
                table: "RoomType",
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
                    { new Guid("675d16db-cd35-4229-b042-82aef4718aff"), "GI-NgT", false, "Giường điều trị ngoại trú", 14 },
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
                values: new object[,]
                {
                    { new Guid("3382be1c-2836-4246-99db-c4e1c781e868"), null, null, null, "administrator@gmail.com", "Admin", null, "Administrator", "79956B61E1B250869A6716CE37EFD6E6", null, null, 1, 0, "Administrator", null },
                    { new Guid("49ba7fd4-2edb-4482-a419-00c81f023f5c"), null, null, null, "nghiemhai293@gmail.com", "Hai", null, "Nghiem", "46F94C8DE14FB36680850768FF1B7F2A", null, null, 1, 0, "hainx", null }
                });

            migrationBuilder.InsertData(
                table: "Province",
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

            migrationBuilder.CreateIndex(
                name: "IX_Department_BranchId",
                table: "Department",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_DepartmentTypeId",
                table: "Department",
                column: "DepartmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_District_ProvinceId",
                table: "District",
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
                name: "IX_Icd_ChapterIcdId",
                table: "Icd",
                column: "ChapterIcdId");

            migrationBuilder.CreateIndex(
                name: "IX_InOutStockItems_InOutStockId",
                table: "InOutStockItems",
                column: "InOutStockId");

            migrationBuilder.CreateIndex(
                name: "IX_InOutStockItems_ItemId",
                table: "InOutStockItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_InOutStockItems_ItemTypeId",
                table: "InOutStockItems",
                column: "ItemTypeId");

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
                name: "IX_ItemPricePolicies_ItemId",
                table: "ItemPricePolicies",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPricePolicies_PatientTypeId",
                table: "ItemPricePolicies",
                column: "PatientTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CountryId",
                table: "Items",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemLineId",
                table: "Items",
                column: "ItemLineId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemTypeId",
                table: "Items",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_UnitId",
                table: "Items",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStocks_ItemId",
                table: "ItemStocks",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStocks_StockId",
                table: "ItemStocks",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTypes_CountryId",
                table: "ItemTypes",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTypes_ItemGroupId",
                table: "ItemTypes",
                column: "ItemGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTypes_ItemLineId",
                table: "ItemTypes",
                column: "ItemLineId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTypes_UnitId",
                table: "ItemTypes",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_BloodTypeId",
                table: "Patient",
                column: "BloodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_BloodTypeRhId",
                table: "Patient",
                column: "BloodTypeRhId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_CareerId",
                table: "Patient",
                column: "CareerId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_CountryId",
                table: "Patient",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_DistrictId",
                table: "Patient",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_EthnicId",
                table: "Patient",
                column: "EthnicId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_GenderId",
                table: "Patient",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_ProvinceId",
                table: "Patient",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_WardId",
                table: "Patient",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecord_BloodTypeId",
                table: "PatientRecord",
                column: "BloodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecord_BloodTypeRhId",
                table: "PatientRecord",
                column: "BloodTypeRhId");

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
                name: "IX_PatientRecord_EthnicId",
                table: "PatientRecord",
                column: "EthnicId");

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
                name: "IX_Province_CountryId",
                table: "Province",
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
                name: "IX_Room_DepartmentId",
                table: "Room",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_RoomTypeId",
                table: "Room",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_RoomTypeId1",
                table: "Room",
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
                name: "IX_Ward_DistrictId",
                table: "Ward",
                column: "DistrictId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColumnTemplates");

            migrationBuilder.DropTable(
                name: "DeathCauses");

            migrationBuilder.DropTable(
                name: "DeathWithins");

            migrationBuilder.DropTable(
                name: "ExecutionRooms");

            migrationBuilder.DropTable(
                name: "Hospital");

            migrationBuilder.DropTable(
                name: "Icd");

            migrationBuilder.DropTable(
                name: "InOutStockItems");

            migrationBuilder.DropTable(
                name: "Insurance");

            migrationBuilder.DropTable(
                name: "ItemPricePolicies");

            migrationBuilder.DropTable(
                name: "ItemStocks");

            migrationBuilder.DropTable(
                name: "MedicalRecord");

            migrationBuilder.DropTable(
                name: "MedicalRecordEndTypes");

            migrationBuilder.DropTable(
                name: "MedicalRecordResults");

            migrationBuilder.DropTable(
                name: "MedicalRecordTypes");

            migrationBuilder.DropTable(
                name: "PatientRecordTypes");

            migrationBuilder.DropTable(
                name: "ReceptionType");

            migrationBuilder.DropTable(
                name: "RelativeType");

            migrationBuilder.DropTable(
                name: "RolePermissionBranchs");

            migrationBuilder.DropTable(
                name: "ServicePricePolicies");

            migrationBuilder.DropTable(
                name: "ServiceRequest");

            migrationBuilder.DropTable(
                name: "ServiceRequestServe");

            migrationBuilder.DropTable(
                name: "ServiceResultIndices");

            migrationBuilder.DropTable(
                name: "SYSAutoNumbers");

            migrationBuilder.DropTable(
                name: "SYSRefTypes");

            migrationBuilder.DropTable(
                name: "Tokens");

            migrationBuilder.DropTable(
                name: "Treatments");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "ChapterIcds");

            migrationBuilder.DropTable(
                name: "InOutStocks");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "PatientType");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "SYSRefTypeCategories");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "InOutStockTypes");

            migrationBuilder.DropTable(
                name: "PatientRecord");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ItemTypes");

            migrationBuilder.DropTable(
                name: "ServiceGroupHeIns");

            migrationBuilder.DropTable(
                name: "ServiceGroups");

            migrationBuilder.DropTable(
                name: "SurgicalProcedureTypes");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "RoomType");

            migrationBuilder.DropTable(
                name: "ItemGroups");

            migrationBuilder.DropTable(
                name: "ItemLines");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "BloodTypeRh");

            migrationBuilder.DropTable(
                name: "BloodType");

            migrationBuilder.DropTable(
                name: "Career");

            migrationBuilder.DropTable(
                name: "Ethnic");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Ward");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "DepartmentType");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
