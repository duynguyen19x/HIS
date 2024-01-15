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
                name: "BUS_InOutStockType",
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
                    table.PrimaryKey("PK_BUS_InOutStockType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BUS_MedicalRecord",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicalRecordCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MedicalRecordDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicalRecordTypeId = table.Column<int>(type: "int", nullable: false),
                    MedicalRecordStatusId = table.Column<int>(type: "int", nullable: false),
                    TreatmentResultTypeId = table.Column<int>(type: "int", nullable: false),
                    TreatmentEndTypeId = table.Column<int>(type: "int", nullable: false),
                    PreviusMedicalRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NextMedicalRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PatientRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DoctorUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InIcdCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InIcdName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    InIcdSubCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InIcdText = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    InTraditionalIcdCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InTraditionalIcdName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    InTraditionalIcdSubCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InTraditionalIcdText = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    OutTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IcdCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IcdName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IcdSubCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IcdText = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    TraditionalIcdCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TraditionalIcdName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    TraditionalIcdSubCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TraditionalIcdText = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsSurgery = table.Column<bool>(type: "bit", nullable: false),
                    IsProcedure = table.Column<bool>(type: "bit", nullable: false),
                    IsStroke = table.Column<bool>(type: "bit", nullable: false),
                    IsComplication = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BUS_MedicalRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BUS_MedicalRecordStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalRecordStatusName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BUS_MedicalRecordStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BUS_PatientRecordStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientRecordStatusName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BUS_PatientRecordStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BUS_ServiceRequest",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceRequestCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ServiceRequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServiceRequestUseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NumOrder = table.Column<int>(type: "int", nullable: false),
                    IsPriority = table.Column<bool>(type: "bit", nullable: false),
                    IcdCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IcdName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IcdSubCode = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IcdText = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ServiceRequestTypeId = table.Column<int>(type: "int", nullable: false),
                    ServiceRequestStatusId = table.Column<int>(type: "int", nullable: false),
                    PatientRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicalRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TreatmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExecuteDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExecuteRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExecuteUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BUS_ServiceRequest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_BirthCertBook",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    StartNumOrder = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_BirthCertBook", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_BloodType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_BloodType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_BloodTypeRh",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_BloodTypeRh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_Career",
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
                    table.PrimaryKey("PK_DIC_Career", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_ChapterIcd",
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
                    table.PrimaryKey("PK_DIC_ChapterIcd", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_Country",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HeInCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_DeathCause",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_DeathCause", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_DeathCertBook",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    StartNumOrder = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_DeathCertBook", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_DeathWithin",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_DeathWithin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_DepartmentType",
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
                    table.PrimaryKey("PK_DIC_DepartmentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_Ethnic",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    MohCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_Ethnic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_Gender",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_Hospital",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MohCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Grade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Line = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_Hospital", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_ItemGroup",
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
                    table.PrimaryKey("PK_DIC_ItemGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_ItemLine",
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
                    table.PrimaryKey("PK_DIC_ItemLine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_LiveArea",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    MohCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_LiveArea", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_MedicalRecordTypeGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalRecordTypeGroupCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MedicalRecordTypeGroupName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_MedicalRecordTypeGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_PatientRecordType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientRecordTypeCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PatientRecordTypeName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_PatientRecordType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_PatientType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientTypeCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PatientTypeName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_PatientType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_PaymentMethod",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentMethodCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PaymentMethodName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_PaymentMethod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_Province",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProvinceCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ProvinceName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_Province", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_ReceptionObjectType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceptionTypeCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ReceptionTypeName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_ReceptionObjectType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_RelativeType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RelativeTypeCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RelativeTypeName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_RelativeType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_Religion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReligionCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ReligionName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_Religion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_RightRouteType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RightRouteTypeCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RightRouteTypeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_RightRouteType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_RoomType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_RoomType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_ServiceGroup",
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
                    table.PrimaryKey("PK_DIC_ServiceGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_ServiceGroupHeIn",
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
                    table.PrimaryKey("PK_DIC_ServiceGroupHeIn", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_Supplier",
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_Supplier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_SurgicalProcedureType",
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
                    table.PrimaryKey("PK_DIC_SurgicalProcedureType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_TransactionType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionTypeCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TransactionTypeName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_TransactionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_TransferForm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransferFormCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TransferFormName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_TransferForm", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_TransferReason",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransferReasonCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TransferReasonName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_TransferReason", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_TreatmentEndType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TreatmentEndTypeCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TreatmentEndTypeName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    IsForOutPatient = table.Column<bool>(type: "bit", nullable: false),
                    IsForInPatient = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_TreatmentEndType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_TreatmentResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TreatmentResultCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TreatmentResultName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_TreatmentResult", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_Unit",
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
                    table.PrimaryKey("PK_DIC_Unit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SYS_DbOption",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DbOptionId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    DbOptionValue = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DbOptionType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsParent = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_DbOption", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SYS_Permission",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_Permission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SYS_Role",
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
                    table.PrimaryKey("PK_SYS_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SYS_User",
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
                    table.PrimaryKey("PK_SYS_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SYSRefTypeCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefTypeCategoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYSRefTypeCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIC_Icd",
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_Icd", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DIC_Icd_DIC_ChapterIcd_ChapterIcdId",
                        column: x => x.ChapterIcdId,
                        principalTable: "DIC_ChapterIcd",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DIC_MedicalRecordType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalRecordTypeCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MedicalRecordTypeName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    MedicalRecordTypeGroupID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_MedicalRecordType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DIC_MedicalRecordType_DIC_MedicalRecordTypeGroup_MedicalRecordTypeGroupID",
                        column: x => x.MedicalRecordTypeGroupID,
                        principalTable: "DIC_MedicalRecordTypeGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DIC_District",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_District", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DIC_District_DIC_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "DIC_Province",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DIC_ItemType",
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_ItemType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DIC_ItemType_DIC_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "DIC_Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DIC_ItemType_DIC_ItemGroup_ItemGroupId",
                        column: x => x.ItemGroupId,
                        principalTable: "DIC_ItemGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DIC_ItemType_DIC_ItemLine_ItemLineId",
                        column: x => x.ItemLineId,
                        principalTable: "DIC_ItemLine",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DIC_ItemType_DIC_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "DIC_Unit",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DIC_Service",
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_Service", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DIC_Service_DIC_ServiceGroupHeIn_ServiceGroupHeInId",
                        column: x => x.ServiceGroupHeInId,
                        principalTable: "DIC_ServiceGroupHeIn",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DIC_Service_DIC_ServiceGroup_ServiceGroupId",
                        column: x => x.ServiceGroupId,
                        principalTable: "DIC_ServiceGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DIC_Service_DIC_SurgicalProcedureType_SurgicalProcedureTypeId",
                        column: x => x.SurgicalProcedureTypeId,
                        principalTable: "DIC_SurgicalProcedureType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DIC_Service_DIC_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "DIC_Unit",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SYS_Token",
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
                    table.PrimaryKey("PK_SYS_Token", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SYS_Token_SYS_User_UserId",
                        column: x => x.UserId,
                        principalTable: "SYS_User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SYS_UserRole",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_UserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_SYS_UserRole_SYS_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "SYS_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SYS_UserRole_SYS_User_UserId",
                        column: x => x.UserId,
                        principalTable: "SYS_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SYSRefType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefTypeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RefTypeCategoryId = table.Column<int>(type: "int", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYSRefType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SYSRefType_SYSRefTypeCategory_RefTypeCategoryId",
                        column: x => x.RefTypeCategoryId,
                        principalTable: "SYSRefTypeCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DIC_Ward",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WardCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    WardName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ShortText = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_Ward", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DIC_Ward_DIC_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "DIC_District",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DIC_Item",
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DIC_Item_DIC_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "DIC_Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DIC_Item_DIC_ItemLine_ItemLineId",
                        column: x => x.ItemLineId,
                        principalTable: "DIC_ItemLine",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DIC_Item_DIC_ItemType_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "DIC_ItemType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DIC_Item_DIC_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "DIC_Unit",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BUS_ServiceRequestData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InsuranceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PatientTypeId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BUS_ServiceRequestData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BUS_ServiceRequestData_BUS_ServiceRequest_ServiceRequestId",
                        column: x => x.ServiceRequestId,
                        principalTable: "BUS_ServiceRequest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BUS_ServiceRequestData_DIC_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "DIC_Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DIC_ServicePricePolicy",
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_ServicePricePolicy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DIC_ServicePricePolicy_DIC_PatientType_PatientTypeId",
                        column: x => x.PatientTypeId,
                        principalTable: "DIC_PatientType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DIC_ServicePricePolicy_DIC_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "DIC_Service",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DIC_ServiceResultIndice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    MaleFrom = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MaleTo = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FemaleFrom = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FemaleTo = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Normal = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_ServiceResultIndice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DIC_ServiceResultIndice_DIC_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "DIC_Service",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BUS_Patient",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PatientName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BirthYear = table.Column<int>(type: "int", nullable: false),
                    Birthplace = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EthnicId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReligionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CareerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Workplace = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IssueBy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BUS_Patient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BUS_Patient_DIC_Career_CareerId",
                        column: x => x.CareerId,
                        principalTable: "DIC_Career",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_Patient_DIC_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "DIC_Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_Patient_DIC_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "DIC_District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_Patient_DIC_Ethnic_EthnicId",
                        column: x => x.EthnicId,
                        principalTable: "DIC_Ethnic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_Patient_DIC_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "DIC_Gender",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_Patient_DIC_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "DIC_Province",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_Patient_DIC_Religion_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "DIC_Religion",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_Patient_DIC_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "DIC_Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BUS_PatientRecord",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientRecordCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PatientRecordDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatientRecordStatusId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientTypeId = table.Column<int>(type: "int", nullable: false),
                    ReceptionObjectTypeId = table.Column<int>(type: "int", nullable: false),
                    HospitalizationReason = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsPriority = table.Column<bool>(type: "bit", nullable: false),
                    PatientName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BirthYear = table.Column<int>(type: "int", nullable: false),
                    Birthplace = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EthnicId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReligionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NationalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CareerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Workplace = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IssueBy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    RelativeTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RelativeName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    RelativeAddress = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    RelativeTel = table.Column<string>(type: "nvarchar(56)", maxLength: 56, nullable: true),
                    RelativeMobile = table.Column<string>(type: "nvarchar(56)", maxLength: 56, nullable: true),
                    RelativeIdentificationNumber = table.Column<string>(type: "nvarchar(56)", maxLength: 56, nullable: true),
                    RelativeIssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RelativeIssueBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    InsuranceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsTransferIn = table.Column<bool>(type: "bit", nullable: false),
                    TransferInCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TransferInMediOrgCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TransferInMediOrgName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TransferInTimeFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TransferInTimeTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TransferInIcdCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TransferInIcdName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    TransferInFormId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransferInReasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransferInRightRoute = table.Column<bool>(type: "bit", nullable: false),
                    TransferInOverRoute = table.Column<bool>(type: "bit", nullable: false),
                    ClinicalTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClinicalDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClinicalRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClinicalUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InIcdCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InIcdName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    InIcdSubCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InIcdText = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    OutTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OutDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OutRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OutUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TreatmentResultTypeId = table.Column<int>(type: "int", nullable: false),
                    TreatmentEndTypeId = table.Column<int>(type: "int", nullable: false),
                    OutIcdCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OutIcdName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    OutIcdSubCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OutIcdText = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    OutIcdCauseCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OutIcdCauseName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    TreatmentDirection = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    TreatmentMethod = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Advise = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    AppointmentTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TransferTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TransferTypeId = table.Column<int>(type: "int", nullable: false),
                    TransferMediOrgCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TransferMediOrgName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Transporter = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    TransportVehicle = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    TransferFormId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransferReasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransferRouteRight = table.Column<bool>(type: "bit", nullable: false),
                    TransferRouteOver = table.Column<bool>(type: "bit", nullable: false),
                    DeathTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeathCertBookId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeathCertNum = table.Column<int>(type: "int", nullable: false),
                    DeathWithinId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeathCauseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsHasAutopsy = table.Column<bool>(type: "bit", nullable: false),
                    AutopsyIcdCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AutopsyIcdName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    StoreTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StoreCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BUS_PatientRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BUS_PatientRecord_DIC_Career_CareerId",
                        column: x => x.CareerId,
                        principalTable: "DIC_Career",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_PatientRecord_DIC_Country_NationalId",
                        column: x => x.NationalId,
                        principalTable: "DIC_Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_PatientRecord_DIC_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "DIC_District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_PatientRecord_DIC_Ethnic_EthnicId",
                        column: x => x.EthnicId,
                        principalTable: "DIC_Ethnic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_PatientRecord_DIC_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "DIC_Gender",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_PatientRecord_DIC_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "DIC_Province",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_PatientRecord_DIC_Religion_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "DIC_Religion",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_PatientRecord_DIC_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "DIC_Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DIC_Branch",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MediOrgCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MediOrgAcceptCode = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Level = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Line = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ParentOrganizationName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_Branch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DIC_Branch_DIC_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "DIC_District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DIC_Branch_DIC_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "DIC_Province",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DIC_Branch_DIC_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "DIC_Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DIC_ItemPricePolicy",
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_ItemPricePolicy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DIC_ItemPricePolicy_DIC_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "DIC_Item",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DIC_ItemPricePolicy_DIC_PatientType_PatientTypeId",
                        column: x => x.PatientTypeId,
                        principalTable: "DIC_PatientType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BUS_ServiceResultData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceResultIndiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceRequestDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Result = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    TestingMachine = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    ResultType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BUS_ServiceResultData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BUS_ServiceResultData_BUS_ServiceRequestData_ServiceRequestDataId",
                        column: x => x.ServiceRequestDataId,
                        principalTable: "BUS_ServiceRequestData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_ServiceResultData_BUS_ServiceRequest_ServiceRequestId",
                        column: x => x.ServiceRequestId,
                        principalTable: "BUS_ServiceRequest",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_ServiceResultData_DIC_ServiceResultIndice_ServiceResultIndiceId",
                        column: x => x.ServiceResultIndiceId,
                        principalTable: "DIC_ServiceResultIndice",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_ServiceResultData_DIC_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "DIC_Service",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BUS_Insurance",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InsuranceCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MediOrgCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MediOrgName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    LiveAreaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    RightRouteTypeId = table.Column<int>(type: "int", nullable: false),
                    Join5YearTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FreeCoPaidTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HasBirthCertificate = table.Column<bool>(type: "bit", nullable: false),
                    PatientRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BUS_Insurance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BUS_Insurance_BUS_PatientRecord_PatientRecordId",
                        column: x => x.PatientRecordId,
                        principalTable: "BUS_PatientRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BUS_Insurance_BUS_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "BUS_Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BUS_Insurance_DIC_LiveArea_LiveAreaId",
                        column: x => x.LiveAreaId,
                        principalTable: "DIC_LiveArea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BUS_Insurance_DIC_RightRouteType_RightRouteTypeId",
                        column: x => x.RightRouteTypeId,
                        principalTable: "DIC_RightRouteType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DIC_Department",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    MohCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
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
                    table.PrimaryKey("PK_DIC_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DIC_Department_DIC_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "DIC_Branch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DIC_Department_DIC_DepartmentType_DepartmentTypeId",
                        column: x => x.DepartmentTypeId,
                        principalTable: "DIC_DepartmentType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SYS_RolePermissionBranch",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_RolePermissionBranch", x => new { x.RoleId, x.PermissionId });
                    table.ForeignKey(
                        name: "FK_SYS_RolePermissionBranch_DIC_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "DIC_Branch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SYS_RolePermissionBranch_SYS_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "SYS_Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SYS_RolePermissionBranch_SYS_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "SYS_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DIC_Room",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MohCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_Room", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DIC_Room_DIC_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "DIC_Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DIC_Room_DIC_RoomType_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "DIC_RoomType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BUS_InOutStock",
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
                    InvNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deliverer = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    StockExpTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StockExpUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CommodityType = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BUS_InOutStock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BUS_InOutStock_BUS_InOutStockType_InOutStockTypeId",
                        column: x => x.InOutStockTypeId,
                        principalTable: "BUS_InOutStockType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_InOutStock_BUS_MedicalRecord_PatientRecordId",
                        column: x => x.PatientRecordId,
                        principalTable: "BUS_MedicalRecord",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_InOutStock_BUS_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "BUS_Patient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_InOutStock_DIC_Department_ReqDepartmentId",
                        column: x => x.ReqDepartmentId,
                        principalTable: "DIC_Department",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_InOutStock_DIC_Room_ExpStockId",
                        column: x => x.ExpStockId,
                        principalTable: "DIC_Room",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_InOutStock_DIC_Room_ImpStockId",
                        column: x => x.ImpStockId,
                        principalTable: "DIC_Room",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_InOutStock_DIC_Room_ReqRoomId",
                        column: x => x.ReqRoomId,
                        principalTable: "DIC_Room",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_InOutStock_DIC_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "DIC_Supplier",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_InOutStock_SYS_User_ApproverUserId",
                        column: x => x.ApproverUserId,
                        principalTable: "SYS_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_InOutStock_SYS_User_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "SYS_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_InOutStock_SYS_User_ReceiverUserId",
                        column: x => x.ReceiverUserId,
                        principalTable: "SYS_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_InOutStock_SYS_User_StockExpUserId",
                        column: x => x.StockExpUserId,
                        principalTable: "SYS_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_InOutStock_SYS_User_StockImpUserId",
                        column: x => x.StockImpUserId,
                        principalTable: "SYS_User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BUS_ItemStock",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AvailableQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BUS_ItemStock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BUS_ItemStock_DIC_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "DIC_Item",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_ItemStock_DIC_Room_StockId",
                        column: x => x.StockId,
                        principalTable: "DIC_Room",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DIC_ExecutionRoom",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsMain = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_ExecutionRoom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DIC_ExecutionRoom_DIC_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "DIC_Room",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DIC_ExecutionRoom_DIC_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "DIC_Service",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BUS_InOutStockItem",
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
                    table.PrimaryKey("PK_BUS_InOutStockItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BUS_InOutStockItem_BUS_InOutStock_InOutStockId",
                        column: x => x.InOutStockId,
                        principalTable: "BUS_InOutStock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_InOutStockItem_DIC_ItemType_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "DIC_ItemType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BUS_InOutStockItem_DIC_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "DIC_Item",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "BUS_InOutStockType",
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
                table: "BUS_PatientRecordStatus",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "PatientRecordStatusName", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1753, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Mới", 1 },
                    { 2, null, new DateTime(1753, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Đang điều trị", 2 },
                    { 3, null, new DateTime(1753, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Kết thúc", 3 }
                });

            migrationBuilder.InsertData(
                table: "DIC_ChapterIcd",
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
                table: "DIC_Country",
                columns: new[] { "Id", "Code", "Description", "HeInCode", "Inactive", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), "VN", null, "000", false, "Việt Nam", 0 },
                    { new Guid("0105cfd9-5265-4dcc-b2d8-790abecd5577"), "PS", null, "PS", false, "Palestinian Authority", 0 },
                    { new Guid("02cd862f-7bf2-4dee-9d8d-869f67659eac"), "CX", null, "CX", false, "Christmas island", 0 },
                    { new Guid("05600686-62bc-4be9-b009-58ae6fac5dc2"), "UM", null, "UM", false, "United States Minor Outlying Islands", 0 },
                    { new Guid("05f8a24e-3764-41af-b79b-3e05da6964ad"), "TO", null, "276", false, "Tonga", 0 },
                    { new Guid("060539cd-d169-45c2-bec2-28a91e41bcb3"), "IL", null, "184", false, "Israel", 0 },
                    { new Guid("067dbcfb-9729-4016-aa0f-526f43657542"), "CL", null, "141", false, "Chile", 0 },
                    { new Guid("07c04d8d-4e1c-4896-ba8a-7d8172562b37"), "KP", null, "277", false, "Triều Tiên", 0 },
                    { new Guid("09127bf0-ff5d-4660-8fef-18b3107bf295"), "BI", null, "135", false, "Burundi", 0 },
                    { new Guid("0d9bf5f6-20bb-4b4f-8c3e-0b7205eabe19"), "PR", null, "PR", false, "Puerto Rico", 0 },
                    { new Guid("0f42743d-f2ae-4d4d-9e9c-6dcd785204ff"), "SE", null, "273", false, "Thụy Điển", 0 },
                    { new Guid("10a98338-7167-4e5b-b3e4-9515f63bb43d"), "FI", null, "241", false, "Phần Lan", 0 },
                    { new Guid("10f310c4-857b-431b-934c-19ebc560571c"), "IS", null, "179", false, "Iceland", 0 },
                    { new Guid("1137907c-6292-4973-8a6a-5a8a55216701"), "OM", null, "233", false, "Oman", 0 },
                    { new Guid("16bfb332-7ffe-4d31-a2a2-05e7cc250969"), "Z1", null, "Z1", false, "Sovereign Military Order of Malta (SMOM)", 0 },
                    { new Guid("1760cdb2-5d9e-4a4d-a422-9d2d54333b72"), "VA", null, "290", false, "Thành Vatican", 0 },
                    { new Guid("18be6a2d-0cc9-4e57-9b95-0fd5e0999094"), "LA", null, "193", false, "Lào", 0 },
                    { new Guid("19b9d4e2-dd04-4d66-ba70-e71a800b8563"), "CO", null, "142", false, "Colombia", 0 },
                    { new Guid("1a52542a-e4e8-4514-b84f-d8f7a0ce8bf5"), "HU", null, "177", false, "Hungary", 0 },
                    { new Guid("1bb67a2c-65b1-4437-b7db-61bb5c5c945a"), "NZ", null, "227", false, "New Zealand", 0 },
                    { new Guid("1bd96043-4837-4ab4-8812-0230d7cdc37c"), "BH", null, "117", false, "Bahrain", 0 },
                    { new Guid("1c1e8f0d-fa36-4dd5-a349-51f8f8cf1e11"), "RU", null, "231", false, "Nga", 0 },
                    { new Guid("1c3907c5-3cd4-4530-a28c-6d4acceec175"), "AZ", null, "113", false, "Azerbaijan", 0 },
                    { new Guid("1cb83a16-11a1-438b-8fd9-22e661c5904a"), "TN", null, "281", false, "Tunisia", 0 },
                    { new Guid("1cc02fda-f061-49ad-a4f1-ecb564a28c88"), "KZ", null, "187", false, "Kazakhstan", 0 },
                    { new Guid("1d374c8c-88c5-49ae-9c9c-0b2b362b1198"), "BR", null, "131", false, "Brasil", 0 },
                    { new Guid("1d41f179-ba78-41d6-8ecf-595c7d6de65a"), "MA", null, "209", false, "Maroc", 0 },
                    { new Guid("1df44627-4127-48c0-bbc7-2afc64cb75d2"), "CH", null, "274", false, "Thụy Sĩ", 0 },
                    { new Guid("1f0c0c80-dceb-47c4-9bfb-d9e2b29e8010"), "NR", null, "224", false, "Nauru", 0 },
                    { new Guid("20aa6e3b-0838-45fc-9769-161b291e5e24"), "Z4", null, "Z4", false, "Scotland", 0 },
                    { new Guid("212573b7-ec34-4844-b150-74f567de2c5d"), "GF", null, "GF", false, "French guiana", 0 },
                    { new Guid("21668f2b-b3d0-4927-9d67-3f9eee4736d6"), "AS", null, "AS", false, "Samoa thuộc Hoa Kỳ", 0 },
                    { new Guid("22174cd0-7b2d-4c6b-bb6c-5273e63d28f0"), "MY", null, "205", false, "Malaysia", 0 },
                    { new Guid("226d663e-46ee-4ab2-b385-b062345debd9"), "FR", null, "240", false, "Pháp", 0 },
                    { new Guid("23063395-5d36-41c9-9711-66722ab8849f"), "CZ", null, "252", false, "Séc", 0 },
                    { new Guid("24c5f9fa-e493-43a1-9d2a-c6d25dc2ea89"), "FY", null, "254", false, "Serbia", 0 },
                    { new Guid("25b7ed9b-8bfd-4601-a4c5-a59dfe5a3fab"), "AN", null, "AN", false, "Netherlands antilles", 0 },
                    { new Guid("25df127f-9fb7-4f1d-8a4f-484364e15f91"), "GN", null, "170", false, "Guinea", 0 },
                    { new Guid("264432ff-ba3d-4402-ae05-d3cbbdf7eef4"), "NE", null, "229", false, "Niger", 0 },
                    { new Guid("26d0e10a-43ea-4654-93be-00a21f60b760"), "PG", null, "237", false, "Papua New Guinea", 0 },
                    { new Guid("298cf3d9-cf13-401f-86b5-368d1c71ec77"), "GQ", null, "169", false, "Guinea Xích Đạo", 0 },
                    { new Guid("2e24284d-fe7b-477b-a3e9-23505ccbe379"), "Z6", null, "Z6", false, "Great Britain (See United Kingdom)", 0 },
                    { new Guid("2eab2085-d20b-4cc4-a85b-7567c9ce6ea9"), "LC", null, "247", false, "Saint Lucia", 0 },
                    { new Guid("2eb9de76-3d99-43a5-b17d-ba2f0e08c64a"), "NI", null, "228", false, "Nicaragua", 0 },
                    { new Guid("2eead3fb-8c57-4699-a48d-b9eb2a781d23"), "TF", null, "TF", false, "French Southern Territories", 0 },
                    { new Guid("2f4455d6-efee-4959-8dfd-6f7db81faadd"), "NP", null, "226", false, "Nepal", 0 },
                    { new Guid("2facb682-01d5-4798-bf0a-928bd471ecb3"), "CC", null, "CC", false, "Cocos (keeling) islands", 0 },
                    { new Guid("332e0e9e-0182-47a0-b894-ade71da83708"), "BB", null, "120", false, "Barbados", 0 },
                    { new Guid("33aeb885-ea5c-4343-8011-b1dccebdd65f"), "SA", null, "110", false, "Ả Rập Saudi", 0 },
                    { new Guid("347a0e24-276d-4a54-b92b-4b88b60179af"), "GM", null, "163", false, "Gambia", 0 },
                    { new Guid("36299397-b100-420b-bd1b-3f18eda310fa"), "TD", null, "270", false, "Tchad", 0 },
                    { new Guid("3671801a-1c88-4dc6-9e75-d766644c2af9"), "SR", null, "264", false, "Suriname", 0 },
                    { new Guid("36ddc306-adf0-4897-a200-6377ff0d9042"), "TT", null, "278", false, "Trinidad và Tobago", 0 },
                    { new Guid("39351753-1af5-4797-89e2-b97589db8d2e"), "AZ", null, "114", false, "Cộng hòa Azerbaijan", 0 },
                    { new Guid("39ef7fcd-b539-46be-90a6-bc3f6d1524d8"), "KR", null, "174", false, "Hàn Quốc", 0 },
                    { new Guid("3adb70b0-ae40-4ac0-8a27-15398cc79d49"), "GS", null, "GS", false, "South georgia and the south sandwich islands", 0 },
                    { new Guid("3af1daa8-65e1-4502-823d-3c8530608104"), "MP", null, "MP", false, "Northern mariana islands", 0 },
                    { new Guid("3d9d9ca5-3356-48b3-b518-eb806a6128ee"), "VU", null, "289", false, "Vanuatu", 0 },
                    { new Guid("3dac050e-a2a6-469b-b0bb-def2e17544a5"), "GW", null, "168", false, "Guinea-Bissau", 0 },
                    { new Guid("3de67d92-a46e-4113-bd12-2e89a48aa1f0"), "CN", null, "279", false, "Trung Quốc", 0 },
                    { new Guid("3edffd99-5e14-4466-9f3e-a72ab48711d7"), "HM", null, "HM", false, "Heard and mc donald islands", 0 },
                    { new Guid("3f3e1d5e-ca7b-45ef-9e1e-f3c471e8894f"), "ST", null, "251", false, "São Tomé và Príncipe", 0 },
                    { new Guid("426516a2-46e9-4103-8b44-22b4a30b21ae"), "LS", null, "195", false, "Lesotho", 0 },
                    { new Guid("4452efd3-9727-4c5c-9cc9-76f7270c673d"), "CI", null, "130", false, "Bờ Biển Ngà", 0 },
                    { new Guid("44ff82d4-3356-4f71-9aa2-dc5f161537f0"), "SY", null, "266", false, "Syria", 0 },
                    { new Guid("45696681-b325-4d55-b4ea-56a920227907"), "SL", null, "256", false, "Sierra Leone", 0 },
                    { new Guid("4589f414-2018-4196-a42a-68fa60b41dae"), "MZ", null, "219", false, "Mozambique", 0 },
                    { new Guid("45a0ebe0-51be-423b-8885-7a7bf06e6f95"), "BA", null, "127", false, "Bosna và Hercegovina", 0 },
                    { new Guid("46651a82-3d63-4a24-baff-9bb1ee8ac492"), "CF", null, "280", false, "Trung Phi", 0 },
                    { new Guid("484be820-41ff-4911-94c6-2d2969764ac4"), "CD", null, "145", false, "Cộng hòa Dân chủ Congo", 0 },
                    { new Guid("4b12f61e-5980-415f-a62b-b296753fd70d"), "PT", null, "129", false, "Bồ Đào Nha", 0 },
                    { new Guid("4b7309a1-de33-4f43-a2ff-3f11e0e5869b"), "SM", null, "250", false, "San Marino", 0 },
                    { new Guid("4bab2495-c861-47e7-82e6-1806fd87b767"), "IM", null, "IM", false, "Isle of man", 0 },
                    { new Guid("4dbc51c5-3faa-4e76-b0d5-a28df95c5c01"), "GT", null, "167", false, "Guatemala", 0 },
                    { new Guid("4dcd4bda-0da9-415d-8f7e-ecd5841ad250"), "ER", null, "158", false, "Eritrea", 0 },
                    { new Guid("4e6e77af-56d6-4314-ac68-c39713511d70"), "IE", null, "183", false, "Ireland", 0 },
                    { new Guid("50202b21-f7c0-42eb-89bd-4470e82f3943"), "JE", null, "JE", false, "Jersey", 0 },
                    { new Guid("502c14cb-18ea-461f-9bc0-9591b056284c"), "DK", null, "153", false, "Đan Mạch", 0 },
                    { new Guid("506ddd2c-4f81-4d6d-806c-4c9e605bab3f"), "KN", null, "246", false, "Saint Kitts và Nevis", 0 },
                    { new Guid("509f7d40-e740-472f-8a7a-84b5a527eb96"), "KG", null, "192", false, "Kyrgyzstan", 0 },
                    { new Guid("50c044c3-6cd1-46ad-b10a-e879291806f2"), "NU", null, "NU", false, "Niue", 0 },
                    { new Guid("52595376-4b2b-4746-bb17-16f7ba234a33"), "MW", null, "204", false, "Malawi", 0 },
                    { new Guid("5300fbb8-1d3b-48c2-b251-c9daab165b94"), "SH", null, "SH", false, "St. Helena", 0 },
                    { new Guid("5351587c-9713-44c9-9088-9626d01300c8"), "TK", null, "TK", false, "Tokelau", 0 },
                    { new Guid("539247ef-f9a9-4893-b250-2aa204a87640"), "VG", null, "VG", false, "Virgin Islands (British)", 0 },
                    { new Guid("53b7d739-4b49-4a35-9d04-93520d79d105"), "TJ", null, "267", false, "Tajikistan", 0 },
                    { new Guid("53fdbb96-c808-4474-83bc-084e422a8b95"), "BY", null, "121", false, "Belarus", 0 },
                    { new Guid("54ca17f4-f6f7-4bcf-9809-8d45153c2271"), "LR", null, "197", false, "Liberia", 0 },
                    { new Guid("561d896e-c3c5-4dfc-b13c-790aa25fbd5d"), "PA", null, "236", false, "Panama", 0 },
                    { new Guid("5701a860-793e-4660-9302-005b27d4348e"), "AO", null, "106", false, "Angola", 0 },
                    { new Guid("573dec77-5908-42b2-b1a5-8a5ee8407dee"), "GD", null, "165", false, "Grenada", 0 },
                    { new Guid("57c01cf1-7f20-4a6c-bec9-bcc9a3a039fe"), "SG", null, "257", false, "Singapore", 0 },
                    { new Guid("58357a87-d3a9-4ea4-82ea-eb7775f1c568"), "IR", null, "181", false, "Iran", 0 },
                    { new Guid("58486abc-86a6-4bb8-a610-eb0e4bdf0b73"), "LT", null, "200", false, "Litva", 0 },
                    { new Guid("58776bc3-ee4b-44ae-ac9e-a501437bde2f"), "PF", null, "PF", false, "French Polynesia", 0 },
                    { new Guid("58d12ab1-4946-45f9-bef5-354e5803f357"), "DO", null, "152", false, "Cộng hòa Dominicana", 0 },
                    { new Guid("59e93599-98e9-44de-b9d1-bbbf17c599bf"), "ZA", null, "223", false, "Nam Phi", 0 },
                    { new Guid("5a68453d-81d4-4417-a579-33d6a1c27ea6"), "PE", null, "239", false, "Peru", 0 },
                    { new Guid("5b526a49-1694-4eb8-b602-4e150d12184d"), "MC", null, "216", false, "Monaco", 0 },
                    { new Guid("5bd03273-5b23-4181-892c-397126e8da56"), "PK", null, "234", false, "Pakistan", 0 },
                    { new Guid("5d60e969-8387-42e4-b866-31dfb209f433"), "Z3", null, "Z3", false, "England", 0 },
                    { new Guid("5dc567de-1249-4aaa-9d49-04dcd3501220"), "ES", null, "269", false, "Tây Ban Nha", 0 },
                    { new Guid("5f4a7dfd-c3ed-4796-bde2-94199e595ef0"), "BV", null, "BV", false, "Bouvet island", 0 },
                    { new Guid("62947f31-4a3e-441b-a9d2-9642ce61de2f"), "KI", null, "189", false, "Kiribati", 0 },
                    { new Guid("62b0c6c0-4a45-4f33-b35e-d184d815518e"), "GH", null, "164", false, "Ghana", 0 },
                    { new Guid("63c8621a-fc44-4abe-ba08-8d80520280cf"), "SC", null, "255", false, "Seychelles", 0 },
                    { new Guid("6477d7a3-465e-4277-a4eb-ef09b13f5eca"), "MO", null, "MO", false, "Macau", 0 },
                    { new Guid("66169c75-2aa7-409a-a7b9-d8cfe6ac80c0"), "LB", null, "196", false, "Li ban", 0 },
                    { new Guid("66400b32-893a-489c-a5e1-180d55fb20d4"), "KE", null, "188", false, "Kenya", 0 },
                    { new Guid("66533605-d826-4aec-9536-e4d30effefda"), "AL", null, "103", false, "Albania", 0 },
                    { new Guid("665d03c6-346e-43d8-ad21-31492b4382aa"), "JO", null, "186", false, "Jordan", 0 },
                    { new Guid("686b79de-db2f-4ccd-946c-1bef80cd503e"), "CA", null, "140", false, "Canada", 0 },
                    { new Guid("6b24b562-1294-4537-a69a-26ac34c41521"), "AD", null, "105", false, "Andorra", 0 },
                    { new Guid("6b8836aa-2476-4d82-98f1-0b7f56e66f7a"), "TL", null, "TL", false, "Timor Leste", 0 },
                    { new Guid("6c408b50-b4be-4eca-a710-11a6d914cf4f"), "AT", null, "109", false, "Áo", 0 },
                    { new Guid("6d2d2371-8785-4a7b-94ba-84c804b2b0a2"), "RE", null, "RE", false, "Reunion", 0 },
                    { new Guid("6d5a6761-432b-4bd2-9b04-5e01c421de23"), "NF", null, "NF", false, "Norfolk Island", 0 },
                    { new Guid("716a0688-0378-4941-af8f-c11dc4c45ac2"), "TC", null, "TC", false, "Turks and Caicos Islands", 0 },
                    { new Guid("720aaa71-3cc0-470f-b56c-472ac37a6574"), "BE", null, "125", false, "Bỉ", 0 },
                    { new Guid("72d527d4-00df-4f9a-b0e1-e1fa84a4ba6d"), "SO", null, "261", false, "Somalia", 0 },
                    { new Guid("74c266fd-7287-4525-aca3-6bb66ddcf61f"), "WS", null, "249", false, "Samoa", 0 },
                    { new Guid("75de9dea-ef0f-4492-890a-f5af36cce7aa"), "CG", null, "144", false, "Cộng hòa Congo", 0 },
                    { new Guid("76c42f0f-bfb2-4a11-b5a4-e854f74e72cd"), "BZ", null, "122", false, "Belize", 0 },
                    { new Guid("77365013-80d7-44d5-bd8d-472542cac431"), "MQ", null, "MQ", false, "Martinique", 0 },
                    { new Guid("788693d2-4ac9-4f85-94bf-13d021bc000d"), "PM", null, "PM", false, "St. Pierre and Miquelon", 0 },
                    { new Guid("78dcfd52-de7b-4c1d-9ded-0e5d3f7a8a35"), "MT", null, "208", false, "Malta", 0 },
                    { new Guid("79bc1ba0-a0f6-4065-9783-9e01ade32cde"), "PN", null, "PN", false, "Pitcairn", 0 },
                    { new Guid("7a384197-d55e-44b8-b389-a65f17e74e1f"), "PH", null, "242", false, "Philippines", 0 },
                    { new Guid("7af80a81-41e5-47de-abd3-7ce25f9c39b4"), "TM", null, "282", false, "Turkmenistan", 0 },
                    { new Guid("7afaefc0-9aa8-4ba7-98ae-618682a5be7f"), "KM", null, "143", false, "Comoros", 0 },
                    { new Guid("7b0c9a9c-e730-4b96-9372-e9ef8ab5339b"), "BM", null, "BM", false, "Bermuda", 0 },
                    { new Guid("7bea406c-221d-45dd-aca6-a2ceb90741aa"), "DM", null, "151", false, "Dominica", 0 },
                    { new Guid("7e27cb42-41fb-4b20-b26b-3c1ea9b4ff5c"), "SB", null, "260", false, "Solomon", 0 },
                    { new Guid("7ef68b6d-2d6b-4688-95bc-d0fd79ffb6c5"), "CY", null, "191", false, "Síp", 0 },
                    { new Guid("7f233816-fe94-4941-8125-b62c88410fa9"), "BD", null, "119", false, "Bangladesh", 0 },
                    { new Guid("8562fd7f-49aa-46cf-bbc9-71f7460c6ba7"), "SZ", null, "265", false, "Swaziland", 0 },
                    { new Guid("8592d87f-720b-48e7-82ee-e82d64cbf984"), "AG", null, "108", false, "Antigua và Barbuda", 0 },
                    { new Guid("8764ee96-c950-44cf-a1f4-7636126c671b"), "BS", null, "116", false, "Bahamas", 0 },
                    { new Guid("882c80ef-806d-4370-9fb1-f00a13a7a5c1"), "LV", null, "194", false, "Latvia", 0 },
                    { new Guid("8a003437-323c-451c-b211-1886f79c25f1"), "MV", null, "206", false, "Maldives", 0 },
                    { new Guid("8a6a8442-1533-4bba-9a05-ed707122573e"), "GR", null, "178", false, "Hy Lạp", 0 },
                    { new Guid("8f800608-e254-418d-8163-78f71be4873f"), "EG", null, "102", false, "Ai Cập", 0 },
                    { new Guid("8ff51ea0-476b-4dec-8736-70cc36ea1d2c"), "NO", null, "225", false, "Na Uy", 0 },
                    { new Guid("90b2a6a0-bacd-4175-80e9-b8fde9233786"), "KW", null, "190", false, "Kuwait", 0 },
                    { new Guid("90ef0553-8520-4d57-ae3b-112ebf28b313"), "ZW", null, "295", false, "Zimbabwe", 0 },
                    { new Guid("92aea1da-5cf2-40fa-92a2-cce297949451"), "SI", null, "259", false, "Slovenia", 0 },
                    { new Guid("92b69f82-f3e2-4ea9-9d4b-1763b1a75dec"), "MX", null, "213", false, "Mexico", 0 },
                    { new Guid("93fc49be-bd23-41c3-8538-4b424a7806da"), "CV", null, "CV", false, "Cape verde", 0 },
                    { new Guid("9412c9e0-c4fe-442f-8b13-ea064bf48703"), "LI", null, "199", false, "Liechtenstein", 0 },
                    { new Guid("9601fc62-41b1-44af-af8e-8a03c91c96b8"), "JP", null, "232", false, "Nhật Bản", 0 },
                    { new Guid("97bc234b-7d4c-4870-801b-74f1998741be"), "US", null, "175", false, "Hoa Kỳ", 0 },
                    { new Guid("98062645-5015-4d8c-886e-3fb70c247ada"), "GP", null, "GP", false, "Guadeloupe", 0 },
                    { new Guid("994cf06f-b833-4415-84e0-94f3847b6dd8"), "KY", null, "KY", false, "Cayman islands", 0 },
                    { new Guid("99cfce62-6540-4525-97b8-9a2e62618e05"), "SJ", null, "SJ", false, "Svalbard and Jan Mayen Islands", 0 },
                    { new Guid("9acb769e-d2de-479c-b66a-424ce710a036"), "NG", null, "230", false, "Nigeria", 0 },
                    { new Guid("9d5769fe-b3ae-4697-9150-44674e8008ba"), "DE", null, "155", false, "Đức", 0 },
                    { new Guid("9ded845f-06a1-4651-8903-bc46f7978c84"), "GE", null, "GE", false, "Georgia", 0 },
                    { new Guid("9eb57842-f592-4080-affd-71b43f7d0517"), "AQ", null, "AQ", false, "Antarctica", 0 },
                    { new Guid("9ee7b166-4c6f-4136-8928-c6246c3e76d5"), "UZ", null, "288", false, "Uzbekistan", 0 },
                    { new Guid("a1080c01-e5bb-4e3f-8784-f0678f1eff58"), "DJ", null, "150", false, "Djibouti", 0 },
                    { new Guid("a1ba5be8-fef9-470a-a5f7-efcf7fc900a4"), "ME", null, "218", false, "Montenegro", 0 },
                    { new Guid("a1f120ed-4785-486e-b796-dd8cd569a415"), "VC", null, "248", false, "Saint Vincent và Grenadines", 0 },
                    { new Guid("a30f588b-166d-4118-9d33-b8294e15ad44"), "SD", null, "263", false, "Sudan", 0 },
                    { new Guid("a3597652-cc84-40ff-b143-208ee8473e93"), "EA", null, "154", false, "Đông Timor", 0 },
                    { new Guid("a3c5c224-a013-4e23-8655-641a0a76b38a"), "PW", null, "235", false, "Palau", 0 },
                    { new Guid("a695b824-cfc2-40a3-b5a1-35243a6e2116"), "YE", null, "293", false, "Yemen", 0 },
                    { new Guid("a7a696de-3fd8-48c2-b87a-6464b222af87"), "VE", null, "291", false, "Venezuela", 0 },
                    { new Guid("a8b38e56-d3ea-435f-907a-615ed7ced805"), "AF", null, "101", false, "Afghanistan", 0 },
                    { new Guid("aa3d56b9-f398-4be1-b8ae-9f8563101b6e"), "IT", null, "292", false, "Ý", 0 },
                    { new Guid("aa4399ec-1ff3-4837-a68e-0df0720162cb"), "MR", null, "211", false, "Mauritanie", 0 },
                    { new Guid("aa745539-b444-49d2-ad13-14149f8a1645"), "BO", null, "126", false, "Bolivia", 0 },
                    { new Guid("ab16a3ed-00cd-4445-8e7c-770b1965232e"), "NL", null, "173", false, "Hà Lan", 0 },
                    { new Guid("abdfeb5b-a4b8-4ab1-b6b8-83f7fb72ec23"), "EE", null, "159", false, "Estonia", 0 },
                    { new Guid("ad4ef5f1-e823-4ed4-9ad5-cec4a2cae6af"), "UG", null, "285", false, "Uganda", 0 },
                    { new Guid("af24512b-01ae-4420-96cb-62051ede96cc"), "UA", null, "286", false, "Ukraina", 0 },
                    { new Guid("af3badc9-b6da-4eb0-8a42-ecf8dfd6ae19"), "AM", null, "112", false, "Armenia", 0 },
                    { new Guid("af9c2425-679e-4459-8c68-2d357f4f93e5"), "PY", null, "238", false, "Paraguay", 0 },
                    { new Guid("affdf19e-5ed4-497a-97d0-0fc95a547785"), "LK", null, "262", false, "Sri Lanka", 0 },
                    { new Guid("b16a509f-5c70-42b1-a05e-6d4426c721ca"), "IQ", null, "182", false, "Iraq", 0 },
                    { new Guid("b171e933-4b7d-46f5-802a-14c5c9234ed7"), "ML", null, "207", false, "Mali", 0 },
                    { new Guid("b1829e62-c3dd-4f65-8c41-fdbe26aedb93"), "MG", null, "203", false, "Madagascar", 0 },
                    { new Guid("b4e019b1-042b-465c-baf9-60d525d9b85c"), "CK", null, "CK", false, "Cook islands", 0 },
                    { new Guid("b6169a90-920f-425d-a275-82601862a220"), "SK", null, "258", false, "Slovakia", 0 },
                    { new Guid("b83926c4-6963-4f82-97f7-dffa6e87ea7d"), "MK", null, "202", false, "Macedonia", 0 },
                    { new Guid("b83be42b-cde9-4dc3-a838-d8197d2c678f"), "FO", null, "FO", false, "Faroe islands", 0 },
                    { new Guid("ba7304bd-7e25-4731-a60f-10c13589c71a"), "ET", null, "160", false, "Ethiopia", 0 },
                    { new Guid("ba947c48-36fb-420b-b2d9-663fe308b18c"), "TG", null, "275", false, "Togo", 0 },
                    { new Guid("bcb96598-0e05-4316-86d3-80413326555a"), "MH", null, "210", false, "Quần đảo Marshall", 0 },
                    { new Guid("be946a16-a1af-499c-9bd8-ca12a22fb69c"), "CU", null, "149", false, "Cuba", 0 },
                    { new Guid("bf1bf333-4604-4974-838f-886100c006f3"), "TW", null, "TW", false, "Đài Loan", 0 },
                    { new Guid("c4065df0-2539-4046-bb77-7d699a072734"), "FM", null, "214", false, "Micronesia", 0 },
                    { new Guid("c5c14db2-753f-4e28-88b5-3b9e502fa0c6"), "BN", null, "132", false, "Brunei", 0 },
                    { new Guid("c6f6287f-39f6-4470-ad46-ac539eef3052"), "EC", null, "156", false, "Ecuador", 0 },
                    { new Guid("c7f500b0-be15-4ab8-ae5c-1db430d19b8c"), "YT", null, "YT", false, "Mayotte", 0 },
                    { new Guid("c831fb16-910b-4939-804a-1052b8f8adc1"), "HT", null, "172", false, "Haiti", 0 },
                    { new Guid("c8766416-ed13-4631-a9c4-e89e782055c9"), "Z7", null, "Z7", false, "Wales", 0 },
                    { new Guid("cba207c9-9ee4-4a20-876b-ecb1160d0845"), "SN", null, "253", false, "Sénégal", 0 },
                    { new Guid("cbf1c521-494b-4981-9dc9-b6a1b229c01d"), "JM", null, "185", false, "Jamaica", 0 },
                    { new Guid("cc2a4d3b-bae2-4602-9d23-4d4d2d918699"), "MD", null, "215", false, "Moldova", 0 },
                    { new Guid("cdd52492-d981-4972-9f41-4b1774c002ee"), "GI", null, "GI", false, "Gibraltar", 0 },
                    { new Guid("cf8c2ebc-2ed1-404c-875c-d2151d54ab9e"), "MM", null, "220", false, "Myanma", 0 },
                    { new Guid("d0357290-582a-47cd-984c-8815d38454be"), "Z5", null, "Z5", false, "Northern Ireland", 0 },
                    { new Guid("d1fef153-87bc-403a-9590-0ec4cc8d676e"), "PL", null, "118", false, "Ba Lan", 0 },
                    { new Guid("d200b4b5-7435-41a9-be8b-b6a80e14120b"), "IO", null, "IO", false, "British indian ocean territory", 0 },
                    { new Guid("d2ebac27-3463-40cb-9eb2-86e1da12a3ba"), "MS", null, "MS", false, "Montserrat", 0 },
                    { new Guid("d34d65e5-253f-4324-9aee-f74045802e47"), "GG", null, "GG", false, "Guernsey", 0 },
                    { new Guid("d3c10501-b94f-4a0e-b871-80d4b3d7bbbb"), "HK", null, "HK", false, "Hong kong", 0 },
                    { new Guid("d50a063a-82ef-4b56-858e-1a8794b32878"), "HN", null, "176", false, "Honduras", 0 },
                    { new Guid("d576474f-de6a-45fc-bd19-e18a2915f1a4"), "CR", null, "146", false, "Costa Rica", 0 },
                    { new Guid("d892c6c0-bf86-4487-ab8b-5af35cc32a0c"), "GV", null, "171", false, "Guyana", 0 },
                    { new Guid("d94b5935-e6d2-4aa7-b9f7-d332badacd8d"), "BT", null, "124", false, "Bhutan", 0 },
                    { new Guid("da333d92-e16c-4b49-b9d8-669df9032f82"), "FJ", null, "161", false, "Fiji", 0 },
                    { new Guid("dd79ead4-6e12-4cb8-aff5-8f00d8bf9e99"), "SD", null, "222", false, "Nam Sudan", 0 },
                    { new Guid("dd951a03-c803-4351-aac5-ed4ec9922bab"), "QA", null, "243", false, "Qatar", 0 },
                    { new Guid("ddf4ecad-6f97-4bde-84fe-2b9dc51f0ffd"), "BW", null, "128", false, "Botswana", 0 },
                    { new Guid("de0d7be8-8a87-4358-b93e-e809ab17f238"), "RO", null, "244", false, "Romania", 0 },
                    { new Guid("e180ff8a-4e49-4edd-9168-21b372b8d9b7"), "BG", null, "133", false, "Bulgaria", 0 },
                    { new Guid("e1fc9395-73b5-4fd6-8c31-37fef3a3e866"), "ZM", null, "294", false, "Zambia", 0 },
                    { new Guid("e369137c-1730-4809-88e4-e43031327233"), "BF", null, "134", false, "Burkina Faso", 0 },
                    { new Guid("e3a2237c-9d57-462f-bad8-7a78856303c8"), "ID", null, "180", false, "Indonesia", 0 },
                    { new Guid("e43c3f5c-e8d7-430a-9869-e61337bd4188"), "Z2", null, "Z2", false, "British Southern and Antarctic Territories", 0 },
                    { new Guid("e4acc3fd-7e2d-4927-b7e8-797cb8a29a86"), "GU", null, "GU", false, "Guam", 0 },
                    { new Guid("e4c05566-0c8d-42a4-a2e9-ad4d6d33b35f"), "AI", null, "AI", false, "Anguilla", 0 },
                    { new Guid("e5439053-279d-4094-852d-0c2edc6992ed"), "SV", null, "157", false, "El Salvador", 0 },
                    { new Guid("e5837adb-d926-41f1-8434-73fed9db7504"), "AW", null, "AW", false, "Aruba việt nam", 0 },
                    { new Guid("e6e7518f-73eb-4010-b0cf-6dcc5c8f8e01"), "DZ", null, "104", false, "Algérie", 0 },
                    { new Guid("e9455b51-bd57-482f-a979-5ecf6c8c4afd"), "GB", null, "107", false, "Vương quốc Liên hiệp Anh và Bắc Ireland", 0 },
                    { new Guid("edb5a6e1-b084-4e46-87ab-22d38da9cf0a"), "UY", null, "287", false, "Uruguay", 0 },
                    { new Guid("edcecb3c-ffcb-451f-8e24-02a0bf6499ae"), "IN", null, "115", false, "Cộng hòa Ấn Độ", 0 },
                    { new Guid("ee02aa87-f8dc-44ac-9ac9-830120f05656"), "TR", null, "272", false, "Thổ Nhĩ Kỳ", 0 },
                    { new Guid("ee707e39-4195-426c-abf9-1ce21a771350"), "NA", null, "221", false, "Namibia", 0 },
                    { new Guid("f034e368-335c-4a9f-a039-b7ea83f8a315"), "LU", null, "201", false, "Luxembourg", 0 },
                    { new Guid("f07d3dde-aea1-4f0a-ba9d-310cda4fa6e9"), "TH", null, "271", false, "Thái Lan", 0 },
                    { new Guid("f1218849-b5cf-43c8-b3c4-b1ff145f27fc"), "MU", null, "212", false, "Mauritius", 0 },
                    { new Guid("f1c02c7d-3154-4e55-817c-1e24f6eef729"), "GA", null, "162", false, "Gabon", 0 },
                    { new Guid("f21a86da-a1de-4023-93c9-3a23d315a8cd"), "RW", null, "245", false, "Rwanda", 0 },
                    { new Guid("f36eb030-510e-4ca0-b7c4-a1c1ef656dd6"), "FK", null, "FK", false, "Falkland islands (malvinas)", 0 },
                    { new Guid("f468cb27-57fb-4b75-b3b7-70bb33ca2705"), "KH", null, "139", false, "Campuchia", 0 },
                    { new Guid("f5874f17-6c1e-4c07-b8bf-41b76546f6f0"), "CM", null, "138", false, "Cameroon", 0 },
                    { new Guid("f5f9c1ed-f4fb-4cff-aee3-2bcb0d8eed3e"), "NC", null, "NC", false, "New Caledonia", 0 },
                    { new Guid("f5fdcb6c-e0c5-4a57-adca-e743ba60ccee"), "LY", null, "198", false, "Libya", 0 },
                    { new Guid("f79baaf7-6191-4ba9-b38a-2f1b50d05598"), "TV", null, "283", false, "Tuvalu", 0 },
                    { new Guid("f9375017-9897-4487-8916-c98d22fd05b9"), "GL", null, "GL", false, "Greenland", 0 },
                    { new Guid("fb10ce71-e68a-4a70-bf7e-5edee9388d48"), "AE", null, "137", false, "Các Tiểu Vương quốc Ả Rập Thống nhất", 0 },
                    { new Guid("fb67b422-6903-494e-945d-fa09f031b4f1"), "VI", null, "VI", false, "Virgin Islands (U.S.)", 0 },
                    { new Guid("fc5a0c05-ebac-4906-8a9f-dddcdbcc0a9d"), "AU", null, "284", false, "Úc", 0 },
                    { new Guid("fd0ac376-bf65-4bf8-9067-245691aa1827"), "HR", null, "147", false, "Croatia", 0 },
                    { new Guid("fd21963c-7b5e-44a8-8d70-2edbda437946"), "MN", null, "217", false, "Mông Cổ", 0 },
                    { new Guid("fd235817-1607-4f4c-83c7-ff5bd0012896"), "BJ", null, "123", false, "Benin", 0 },
                    { new Guid("fd32d265-24dd-4073-a4b8-59e6358b59ed"), "AR", null, "111", false, "Argentina", 0 },
                    { new Guid("fe657d37-7960-4bb3-8f15-81666fca928d"), "EH", null, "EH", false, "Western sahara", 0 },
                    { new Guid("ff78779a-45cd-4076-8c61-442a9a3873f2"), "TZ", null, "268", false, "Tanzania", 0 },
                    { new Guid("ffd3fabd-a5f1-4442-837b-d53b5d89272e"), "WF", null, "WF", false, "Wallis and Futuna Islands", 0 }
                });

            migrationBuilder.InsertData(
                table: "DIC_DeathCause",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("4333ca55-4d7c-4be0-b9a2-2125624f0229"), "DO_TAI_BIEN", null, new DateTime(2024, 1, 16, 0, 27, 36, 334, DateTimeKind.Local).AddTicks(3912), null, false, null, null, "Do tai biến điều trị", 2 },
                    { new Guid("4d5b5c50-6be0-434e-8baa-a528af4a58b5"), "KHAC", null, new DateTime(2024, 1, 16, 0, 27, 36, 334, DateTimeKind.Local).AddTicks(3914), null, false, null, null, "Khác", 3 },
                    { new Guid("c0a4d767-7ba9-4006-a0a9-020b6322c2ef"), "DO_BENH", null, new DateTime(2024, 1, 16, 0, 27, 36, 334, DateTimeKind.Local).AddTicks(3894), null, false, null, null, "Do bệnh", 1 }
                });

            migrationBuilder.InsertData(
                table: "DIC_DeathWithin",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("66c3a43b-f9d0-4876-81e2-b13c5f188589"), "TRONG_24H", null, new DateTime(2024, 1, 16, 0, 27, 36, 335, DateTimeKind.Local).AddTicks(6640), null, false, null, null, "Trong 24h vào", 1 },
                    { new Guid("7693d6ec-cf0f-44c1-a9d7-fb997335ae10"), "TRONG_72H", null, new DateTime(2024, 1, 16, 0, 27, 36, 335, DateTimeKind.Local).AddTicks(6654), null, false, null, null, "Trong 72h vào", 3 },
                    { new Guid("8f2b1eeb-a4bd-4f84-b59c-98145c58b1ab"), "KHAC", null, new DateTime(2024, 1, 16, 0, 27, 36, 335, DateTimeKind.Local).AddTicks(6663), null, false, null, null, "Khác", 4 },
                    { new Guid("f91d8342-619c-435b-b51c-8b3d7f541222"), "TRONG_48H", null, new DateTime(2024, 1, 16, 0, 27, 36, 335, DateTimeKind.Local).AddTicks(6652), null, false, null, null, "Trong 48h vào", 2 }
                });

            migrationBuilder.InsertData(
                table: "DIC_DepartmentType",
                columns: new[] { "Id", "Code", "Description", "Inactive", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "LS", null, false, "Khoa lâm sàng", 1 },
                    { 2, "CLS", null, false, "Khoa cận lâm sàng", 2 },
                    { 3, "DUOC", null, false, "Khoa dược", 3 },
                    { 4, "KHTH", null, false, "Kế hoạch tổng hợp", 4 }
                });

            migrationBuilder.InsertData(
                table: "DIC_Ethnic",
                columns: new[] { "Id", "Code", "Description", "Inactive", "MohCode", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170901"), "01", null, false, "13", "Ba na", 1 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170902"), "02", null, false, "49", "Bố y", 2 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170903"), "03", null, false, "52", "Brâu", 3 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170904"), "04", null, false, "17", "Chăm", 4 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170905"), "05", null, false, "32", "Chơ ro", 5 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170906"), "06", null, false, "36", "Chu ru", 6 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170907"), "07", null, false, "44", "Chứt", 7 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170908"), "08", null, false, "30", "Co", 8 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170909"), "09", null, false, "48", "Cống", 9 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170910"), "10", null, false, "16", "Cơ ho", 10 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170911"), "11", null, false, "47", "Cờ lao", 11 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170912"), "12", null, false, "9", "Dao", 12 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170913"), "13", null, false, "12", "Ê đê", 13 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170914"), "14", null, false, "10", "Gia rai", 14 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170915"), "15", null, false, "25", "Giấy", 15 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170916"), "16", null, false, "27", "Gié triêng", 16 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170917"), "17", null, false, "8", "H mông", 17 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170918"), "18", null, false, "19", "H rê", 18 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170919"), "19", null, false, "35", "Hà nhì", 19 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170920"), "20", null, false, "4", "Hoa", 20 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170921"), "21", null, false, "26", "K tu", 21 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170922"), "22", null, false, "33", "Kháng", 22 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170923"), "23", null, false, "5", "Khơ me", 23 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170924"), "24", null, false, "29", "Khơ mú", 24 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170925"), "25", null, false, "1", "Kinh", 25 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170926"), "26", null, false, "38", "La chí", 26 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170927"), "27", null, false, "39", "La ha", 27 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170928"), "28", null, false, "41", "La hù", 28 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170929"), "29", null, false, "37", "Lào", 29 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170930"), "30", null, false, "43", "Lô lô", 30 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170931"), "31", null, false, "42", "Lự", 31 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170932"), "32", null, false, "20", "M nông", 32 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170933"), "33", null, false, "28", "Mạ", 33 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170934"), "34", null, false, "45", "Mảng", 34 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170935"), "35", null, false, "6", "Mường", 35 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170936"), "36", null, false, "11", "Ngái", 36 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170937"), "37", null, false, "7", "Nùng", 37 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170938"), "38", null, false, "53", "Ơ đu", 38 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170939"), "39", null, false, "46", "Pà thén", 39 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170940"), "40", null, false, "40", "Phù lá", 40 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170941"), "41", null, false, "51", "Pu péo", 41 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170942"), "42", null, false, "21", "Rag lai", 42 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170943"), "43", null, false, "54", "Rơ man", 43 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170944"), "44", null, false, "15", "Sán chay", 44 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170945"), "45", null, false, "18", "Sán dìu", 45 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170946"), "46", null, false, "50", "Si la", 46 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170947"), "47", null, false, "31", "Tà ôi", 47 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170948"), "48", null, false, "2", "Tày", 48 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170949"), "49", null, false, "3", "Thái", 49 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170950"), "50", null, false, "24", "Thố", 50 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170951"), "51", null, false, "23", "Vân kiều", 51 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170952"), "52", null, false, "22", "X tiêng", 52 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170953"), "53", null, false, "34", "Xinh mun", 53 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170954"), "54", null, false, "14", "Xơ đăng", 54 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170999"), "99", null, false, "55", "Nước ngoài", 99 }
                });

            migrationBuilder.InsertData(
                table: "DIC_Gender",
                columns: new[] { "Id", "Code", "Description", "Inactive", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("97ac7fd8-edfa-4243-97fc-98468f492df1"), "KXD", null, false, "Chưa xác định", 0 },
                    { new Guid("e9497984-d355-41af-b917-091500956be9"), "NU", null, false, "Nữ", 2 },
                    { new Guid("fc153433-bf89-4e95-8523-df3d8cec8676"), "NAM", null, false, "Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "DIC_ItemGroup",
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
                table: "DIC_ItemLine",
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
                table: "DIC_MedicalRecordTypeGroup",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Inactive", "MedicalRecordTypeGroupCode", "MedicalRecordTypeGroupName", "ModifiedBy", "ModifiedDate", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(529), null, false, "1", "Khám bệnh", null, null, 3 },
                    { 2, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(528), null, false, "2", "Ngoại trú", null, null, 2 },
                    { 3, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(513), null, false, "3", "Nội trú", null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "DIC_PatientRecordType",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "PatientRecordTypeCode", "PatientRecordTypeName", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 1, 16, 0, 27, 36, 340, DateTimeKind.Local).AddTicks(2096), null, false, null, null, "1", "Ngoại trú", 1 },
                    { 2, null, new DateTime(2024, 1, 16, 0, 27, 36, 340, DateTimeKind.Local).AddTicks(2107), null, false, null, null, "2", "Nội trú", 2 },
                    { 3, null, new DateTime(2024, 1, 16, 0, 27, 36, 340, DateTimeKind.Local).AddTicks(2109), null, false, null, null, "3", "Dịch vụ", 3 }
                });

            migrationBuilder.InsertData(
                table: "DIC_PatientType",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "PatientTypeCode", "PatientTypeName", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 1, 16, 0, 27, 36, 340, DateTimeKind.Local).AddTicks(4014), null, false, null, null, "1", "Bảo hiểm y tế", 1 },
                    { 2, null, new DateTime(2024, 1, 16, 0, 27, 36, 340, DateTimeKind.Local).AddTicks(4021), null, false, null, null, "2", "Viện phí", 2 },
                    { 3, null, new DateTime(2024, 1, 16, 0, 27, 36, 340, DateTimeKind.Local).AddTicks(4034), null, false, null, null, "3", "Dịch vụ", 3 },
                    { 4, null, new DateTime(2024, 1, 16, 0, 27, 36, 340, DateTimeKind.Local).AddTicks(4036), null, false, null, null, "4", "Người nước ngoài", 4 },
                    { 5, null, new DateTime(2024, 1, 16, 0, 27, 36, 340, DateTimeKind.Local).AddTicks(4037), null, false, null, null, "5", "Miễn phí", 5 }
                });

            migrationBuilder.InsertData(
                table: "DIC_PaymentMethod",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "PaymentMethodCode", "PaymentMethodName", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("0b348363-c888-4c9a-b145-c3389fdcca37"), null, new DateTime(2024, 1, 16, 0, 27, 36, 340, DateTimeKind.Local).AddTicks(5902), null, false, null, null, "TM/CK", "Tiền mặt hoặc chuyển khoản", 3 },
                    { new Guid("8bff9824-1df2-419e-88ab-e098a6fc4e7e"), null, new DateTime(2024, 1, 16, 0, 27, 36, 340, DateTimeKind.Local).AddTicks(5891), null, false, null, null, "TM", "Tiền mặt", 1 },
                    { new Guid("dd39afc0-1de0-4287-a126-4dada6788508"), null, new DateTime(2024, 1, 16, 0, 27, 36, 340, DateTimeKind.Local).AddTicks(5900), null, false, null, null, "CK", "Chuyển khoản", 2 }
                });

            migrationBuilder.InsertData(
                table: "DIC_Province",
                columns: new[] { "Id", "Description", "Inactive", "ProvinceCode", "ProvinceName", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("003360aa-6adc-4e1c-8da9-fd1d1665729d"), null, false, "17", "Tỉnh Hoà Bình", 0 },
                    { new Guid("0729fb2e-ae19-41f3-b948-b0f0c51fbf99"), null, false, "46", "Tỉnh Thừa Thiên Huế", 0 },
                    { new Guid("0b13943c-ead8-4e76-80b8-33b31828dd7a"), null, false, "77", "Tỉnh Bà Rịa - Vũng Tàu", 0 },
                    { new Guid("0fdfd770-bee4-4dc4-9eb5-d86816bfc2bf"), null, false, "35", "Tỉnh Hà Nam", 0 },
                    { new Guid("198417f7-e503-4435-bde2-7547487c943a"), null, false, "33", "Tỉnh Hưng Yên", 0 },
                    { new Guid("1d8b3ff0-1bbd-4fa4-a4c8-1a4e2c394a55"), null, false, "34", "Tỉnh Thái Bình", 0 },
                    { new Guid("2c03541e-db56-4bcb-8012-52b0f130ca09"), null, false, "67", "Tỉnh Đắk Nông", 0 },
                    { new Guid("2d80dbcf-c7d5-4450-9847-e7e6f737f567"), null, false, "27", "Tỉnh Bắc Ninh", 0 },
                    { new Guid("3035b967-95aa-46a5-be3f-b1f7bec1fd51"), null, false, "44", "Tỉnh Quảng Bình", 0 },
                    { new Guid("3109e53a-812d-455e-a968-e86ff499d74d"), null, false, "49", "Tỉnh Quảng Nam", 0 },
                    { new Guid("33d6ec24-75ee-402e-b8d2-3296e90ea336"), null, false, "60", "Tỉnh Bình Thuận", 0 },
                    { new Guid("37d13fe4-1fd2-4268-bbae-4ab301f634c5"), null, false, "22", "Tỉnh Quảng Ninh", 0 },
                    { new Guid("38e1ffeb-7572-40c7-a716-cd880eb8d1ce"), null, false, "08", "Tỉnh Tuyên Quang", 0 },
                    { new Guid("395f3325-851f-41ee-b652-5002ce7cf547"), null, false, "68", "Tỉnh Lâm Đồng", 0 },
                    { new Guid("3baaffd5-90a2-471f-8581-b5969184fcbe"), null, false, "62", "Tỉnh Kon Tum", 0 },
                    { new Guid("3fd18cc5-7204-42a9-a940-c5cf3128518f"), null, false, "94", "Tỉnh Sóc Trăng", 0 },
                    { new Guid("40064e04-52c1-460d-b3d3-04f4e991f82c"), null, false, "48", "Thành phố Đà Nẵng", 0 },
                    { new Guid("46ddf496-df97-40b4-9b23-bfd17357abbe"), null, false, "31", "Thành phố Hải Phòng", 0 },
                    { new Guid("4e6a7717-9e60-4bae-a2d4-d29dacd8af47"), null, false, "12", "Tỉnh Lai Châu", 0 },
                    { new Guid("528fe36b-ac63-4f15-96f5-104ac221a155"), null, false, "10", "Tỉnh Lào Cai", 0 },
                    { new Guid("52b17f24-a4a1-4cc6-88a0-c526ee8256c6"), null, false, "11", "Tỉnh Điện Biên", 0 },
                    { new Guid("5329306e-8290-4ca4-b110-0678c20752e0"), null, false, "56", "Tỉnh Khánh Hòa", 0 },
                    { new Guid("619d7aee-4e6a-4993-9d7a-c6e32958851f"), null, false, "92", "Thành phố Cần Thơ", 0 },
                    { new Guid("64a15171-a037-45b4-a55d-08ee58ce687d"), null, false, "66", "Tỉnh Đắk Lắk", 0 },
                    { new Guid("68d199cc-b739-4d61-b412-40d2242f374d"), null, false, "58", "Tỉnh Ninh Thuận", 0 },
                    { new Guid("6f51a702-3c62-4a43-8042-9cf6e8bf3186"), null, false, "72", "Tỉnh Tây Ninh", 0 },
                    { new Guid("702c3cf1-d0b3-4647-8d39-7549dd42f610"), null, false, "84", "Tỉnh Trà Vinh", 0 },
                    { new Guid("7184c251-1c62-4b69-a63f-de49e85633f0"), null, false, "79", "Thành phố Hồ Chí Minh", 0 },
                    { new Guid("72478add-ca26-4a9b-92bd-2b075006f36a"), null, false, "89", "Tỉnh An Giang", 0 },
                    { new Guid("77e4b05d-6245-43ee-ba94-84faaece9018"), null, false, "15", "Tỉnh Yên Bái", 0 },
                    { new Guid("7a3c3be6-fe62-42ab-9764-f8e62d7f5916"), null, false, "52", "Tỉnh Bình Định", 0 },
                    { new Guid("7acbf3ec-7068-4007-a871-e0fee1ef28c5"), null, false, "26", "Tỉnh Vĩnh Phúc", 0 },
                    { new Guid("839f0efb-168d-4110-a041-60b463ae48a1"), null, false, "70", "Tỉnh Bình Phước", 0 },
                    { new Guid("889693ed-0453-4387-941b-d70dd4870dc5"), null, false, "01", "Thành phố Hà Nội", 0 },
                    { new Guid("8eb57a8e-8281-41bb-a5ab-637dcac67177"), null, false, "14", "Tỉnh Sơn La", 0 },
                    { new Guid("8ed43986-0586-4742-8f89-a673c9f63756"), null, false, "06", "Tỉnh Bắc Kạn", 0 },
                    { new Guid("8f0f2a47-34e4-4af3-811a-4d9c1fbf1cae"), null, false, "45", "Tỉnh Quảng Trị", 0 },
                    { new Guid("927f685b-f766-4bf8-93ed-ae7aabc4071c"), null, false, "19", "Tỉnh Thái Nguyên", 0 },
                    { new Guid("94dab20e-c05d-4aa9-93e9-82e972792756"), null, false, "36", "Tỉnh Nam Định", 0 },
                    { new Guid("952aa342-c05d-46d3-8ffe-6a22d7512dc2"), null, false, "83", "Tỉnh Bến Tre", 0 },
                    { new Guid("9c2a8569-d860-459d-8c3a-49966ea0038d"), null, false, "24", "Tỉnh Bắc Giang", 0 },
                    { new Guid("9d49b503-ac5f-47f3-aaa2-8d18853bfba6"), null, false, "80", "Tỉnh Long An", 0 },
                    { new Guid("a1f48dda-f1a3-473a-b4f7-6843312303f4"), null, false, "25", "Tỉnh Phú Thọ", 0 },
                    { new Guid("aee0f859-e3bd-41ae-be15-17060d5ad617"), null, false, "37", "Tỉnh Ninh Bình", 0 },
                    { new Guid("af97b966-5b74-4580-a948-c8a9df0a5fba"), null, false, "51", "Tỉnh Quảng Ngãi", 0 },
                    { new Guid("b2035ac5-5e24-4a18-8587-62e65fd64697"), null, false, "42", "Tỉnh Hà Tĩnh", 0 },
                    { new Guid("b2cace92-0d42-4789-97c7-83ea3c3667c5"), null, false, "38", "Tỉnh Thanh Hóa", 0 },
                    { new Guid("b42cba39-912a-4400-84a5-fe15eb71766e"), null, false, "64", "Tỉnh Gia Lai", 0 },
                    { new Guid("b6bdda7d-b047-45a0-9d73-ffcb4e938e38"), null, false, "95", "Tỉnh Bạc Liêu", 0 },
                    { new Guid("b6cf7563-f2be-4273-bcc7-58bb3cd4edec"), null, false, "75", "Tỉnh Đồng Nai", 0 },
                    { new Guid("c16dbbe1-bea2-413b-9216-5b547deac9f5"), null, false, "20", "Tỉnh Lạng Sơn", 0 },
                    { new Guid("c30f4992-257a-4abf-abb0-2ea4b36f247f"), null, false, "54", "Tỉnh Phú Yên", 0 },
                    { new Guid("cd4eab40-92a3-4898-8a65-c67ccde721c0"), null, false, "93", "Tỉnh Hậu Giang", 0 },
                    { new Guid("da06856d-9e6c-49f7-bbed-ca2a06ca81c1"), null, false, "91", "Tỉnh Kiên Giang", 0 },
                    { new Guid("e5a4e82b-b29d-4b47-a563-82977ea93346"), null, false, "86", "Tỉnh Vĩnh Long", 0 },
                    { new Guid("e7fe23cb-4304-4fb0-90a5-9ff4da5048aa"), null, false, "02", "Tỉnh Hà Giang", 0 },
                    { new Guid("ec0b077d-3957-4089-85f8-c1d6742aab19"), null, false, "40", "Tỉnh Nghệ An", 0 },
                    { new Guid("ed0a3763-3a96-46c5-8094-c47a4708e3cb"), null, false, "30", "Tỉnh Hải Dương", 0 },
                    { new Guid("ef981a1e-0af1-4b7f-9fd7-42de078e7d97"), null, false, "74", "Tỉnh Bình Dương", 0 },
                    { new Guid("f06e27bf-1470-4f7a-873f-f0dc77e405e4"), null, false, "82", "Tỉnh Tiền Giang", 0 },
                    { new Guid("f2aac7ae-5a85-48fc-9166-d9ab6efb79ab"), null, false, "96", "Tỉnh Cà Mau", 0 },
                    { new Guid("f5d76f98-2024-4c60-81ad-577359cb69d1"), null, false, "04", "Tỉnh Cao Bằng", 0 },
                    { new Guid("fa11ad72-29b7-49f4-986d-fea0d53de210"), null, false, "87", "Tỉnh Đồng Tháp", 0 }
                });

            migrationBuilder.InsertData(
                table: "DIC_ReceptionObjectType",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "ReceptionTypeCode", "ReceptionTypeName", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 1, 16, 0, 27, 36, 340, DateTimeKind.Local).AddTicks(9802), null, false, null, null, "1", "Khám bệnh", 1 },
                    { 2, null, new DateTime(2024, 1, 16, 0, 27, 36, 340, DateTimeKind.Local).AddTicks(9810), null, false, null, null, "2", "Cấp cứu", 2 }
                });

            migrationBuilder.InsertData(
                table: "DIC_RelativeType",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "RelativeTypeCode", "RelativeTypeName", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f01"), null, new DateTime(1753, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "01", "Bố đẻ", 1 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f02"), null, new DateTime(1753, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "02", "Mẹ đẻ", 2 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f03"), null, new DateTime(1753, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "03", "Bố nuôi", 3 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f04"), null, new DateTime(1753, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "04", "Mẹ nuôi", 4 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f05"), null, new DateTime(1753, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "05", "Anh ruột", 5 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f06"), null, new DateTime(1753, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "06", "Chị ruột", 6 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f07"), null, new DateTime(1753, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "07", "Em ruột", 7 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f08"), null, new DateTime(1753, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "08", "Ông", 8 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f09"), null, new DateTime(1753, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "09", "Bà", 9 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f10"), null, new DateTime(1753, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "10", "Vợ", 10 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f11"), null, new DateTime(1753, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "11", "Chồng", 11 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f12"), null, new DateTime(1753, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "12", "Con", 12 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f13"), null, new DateTime(1753, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "13", "Cháu", 13 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f14"), null, new DateTime(1753, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "14", "Bác, chú, cậu", 14 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f15"), null, new DateTime(1753, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "15", "Bác, cô, dì", 15 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f99"), null, new DateTime(1753, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "99", "Khác", 99 }
                });

            migrationBuilder.InsertData(
                table: "DIC_RoomType",
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
                table: "DIC_ServiceGroup",
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
                table: "DIC_ServiceGroupHeIn",
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
                table: "DIC_SurgicalProcedureType",
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
                table: "DIC_Unit",
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
                table: "SYSRefTypeCategory",
                columns: new[] { "Id", "Description", "RefTypeCategoryName", "SortOrder" },
                values: new object[,]
                {
                    { 1, "Các chức năng quản lý và xử lý hệ thống", "Hệ thống", 1 },
                    { 2, "Các chức năng người dùng khai báo", "Danh mục", 2 },
                    { 3, "Các chức năng tiếp đón", "Đón tiếp", 3 },
                    { 4, "Các chức năng khám bệnh", "Khám bệnh", 4 },
                    { 99, "Khác", "Khác", 99 }
                });

            migrationBuilder.InsertData(
                table: "SYS_User",
                columns: new[] { "Id", "Address", "DistrictId", "Dob", "Email", "FirstName", "GenderId", "LastName", "Password", "PhoneNumber", "ProvinceId", "Status", "UseType", "UserName", "WardId" },
                values: new object[,]
                {
                    { new Guid("3382be1c-2836-4246-99db-c4e1c781e868"), null, null, null, "administrator@gmail.com", "Admin", null, "Administrator", "79956B61E1B250869A6716CE37EFD6E6", null, null, 1, 0, "Administrator", null },
                    { new Guid("49ba7fd4-2edb-4482-a419-00c81f023f5c"), null, null, null, "nghiemhai293@gmail.com", "Hai", null, "Nghiem", "46F94C8DE14FB36680850768FF1B7F2A", null, null, 1, 0, "hainx", null }
                });

            migrationBuilder.InsertData(
                table: "DIC_MedicalRecordType",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Inactive", "MedicalRecordTypeCode", "MedicalRecordTypeGroupID", "MedicalRecordTypeName", "ModifiedBy", "ModifiedDate", "SortOrder" },
                values: new object[,]
                {
                    { 100, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(3108), null, false, "100", 1, "Khám Bệnh", null, null, 1 },
                    { 200, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(3117), null, false, "200", 2, "Bệnh Án Ngoại Trú (Chung)", null, null, 1 },
                    { 201, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(3118), null, false, "201", 2, "Bệnh Án Ngoại Trú (Răng - Hàm - Mặt)", null, null, 2 },
                    { 202, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(3120), null, false, "202", 2, "Bệnh Án Ngoại Trú (Tai - Mũi - Họng)", null, null, 3 },
                    { 203, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(3121), null, false, "203", 2, "Bệnh Án Ngoại Trú (Y Học Cổ Truyền)", null, null, 4 },
                    { 204, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(3123), null, false, "204", 2, "Bệnh Án Ngoại Trú (Mắt)", null, null, 5 },
                    { 301, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(3124), null, false, "301", 3, "Bệnh Án Nội Khoa", null, null, 2 },
                    { 302, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(3126), null, false, "302", 3, "Bệnh Án Nhi Khoa", null, null, 3 },
                    { 303, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(3127), null, false, "303", 3, "Bệnh Án Truyền Nhiễm", null, null, 4 },
                    { 304, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(3129), null, false, "304", 3, "Bệnh Án Phụ Khoa", null, null, 5 },
                    { 305, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(3130), null, false, "305", 3, "Bệnh Án Sản Khoa", null, null, 6 },
                    { 306, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(3132), null, false, "306", 3, "Bệnh Án Sơ Sinh", null, null, 7 },
                    { 307, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(3140), null, false, "307", 3, "Bệnh Án Tâm Thần", null, null, 8 },
                    { 308, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(3141), null, false, "308", 3, "Bệnh Án Da Liễu", null, null, 9 },
                    { 309, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(3148), null, false, "309", 3, "Bệnh Án Điều Dưỡng - Phục Hồi Chức Năng", null, null, 10 },
                    { 310, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(3149), null, false, "310", 3, "Bệnh Án Huyết Học - Truyền Máu", null, null, 11 },
                    { 311, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(3165), null, false, "311", 3, "Bệnh Án Ngoại Khoa", null, null, 12 },
                    { 312, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(3186), null, false, "312", 3, "Bệnh Án Bỏng", null, null, 13 },
                    { 313, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(3188), null, false, "313", 3, "Bệnh Án Ung Bướu", null, null, 14 },
                    { 314, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(3189), null, false, "314", 3, "Bệnh Án Răng-Hàm-Mặt", null, null, 15 },
                    { 315, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(3191), null, false, "315", 3, "Bệnh Án Tai-Mũi-Họng", null, null, 16 },
                    { 316, null, new DateTime(2024, 1, 16, 0, 27, 36, 339, DateTimeKind.Local).AddTicks(3192), null, false, "316", 3, "Bệnh Án Mắt", null, null, 17 }
                });

            migrationBuilder.InsertData(
                table: "SYSRefType",
                columns: new[] { "Id", "Description", "ParentId", "RefTypeCategoryId", "RefTypeName", "SortOrder" },
                values: new object[,]
                {
                    { 101, null, null, 1, "Quản lý người dùng", 2 },
                    { 102, null, null, 1, "Loại đối tượng bệnh nhân", 3 },
                    { 103, null, null, 1, "Loại đối tượng đăng ký khám", 4 },
                    { 104, null, null, 1, "Loại bệnh án", 5 },
                    { 199, null, null, 1, "Tùy chọn", 9 },
                    { 201, null, null, 2, "Chi nhánh", 1 },
                    { 202, null, null, 2, "Khoa", 2 },
                    { 203, null, null, 2, "Phòng", 3 },
                    { 204, null, null, 2, "Quốc tịch", 4 },
                    { 205, null, null, 2, "Tỉnh, thành phố", 5 },
                    { 206, null, null, 2, "Quận, huyện", 6 },
                    { 207, null, null, 2, "Xã, phường", 7 },
                    { 208, null, null, 2, "Dân tộc", 8 },
                    { 209, null, null, 2, "Giới tính", 9 },
                    { 210, null, null, 2, "Nghề nghiệp", 10 },
                    { 211, null, null, 2, "Tôn giáo", 11 },
                    { 212, null, null, 2, "Nơi sống", 12 },
                    { 301, null, null, 3, "Đón tiếp", 1 },
                    { 401, null, null, 4, "Khám bệnh", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BUS_InOutStock_ApproverUserId",
                table: "BUS_InOutStock",
                column: "ApproverUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_InOutStock_CreationUserId",
                table: "BUS_InOutStock",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_InOutStock_ExpStockId",
                table: "BUS_InOutStock",
                column: "ExpStockId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_InOutStock_ImpStockId",
                table: "BUS_InOutStock",
                column: "ImpStockId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_InOutStock_InOutStockTypeId",
                table: "BUS_InOutStock",
                column: "InOutStockTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_InOutStock_PatientId",
                table: "BUS_InOutStock",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_InOutStock_PatientRecordId",
                table: "BUS_InOutStock",
                column: "PatientRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_InOutStock_ReceiverUserId",
                table: "BUS_InOutStock",
                column: "ReceiverUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_InOutStock_ReqDepartmentId",
                table: "BUS_InOutStock",
                column: "ReqDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_InOutStock_ReqRoomId",
                table: "BUS_InOutStock",
                column: "ReqRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_InOutStock_StockExpUserId",
                table: "BUS_InOutStock",
                column: "StockExpUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_InOutStock_StockImpUserId",
                table: "BUS_InOutStock",
                column: "StockImpUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_InOutStock_SupplierId",
                table: "BUS_InOutStock",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_InOutStockItem_InOutStockId",
                table: "BUS_InOutStockItem",
                column: "InOutStockId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_InOutStockItem_ItemId",
                table: "BUS_InOutStockItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_InOutStockItem_ItemTypeId",
                table: "BUS_InOutStockItem",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_Insurance_LiveAreaId",
                table: "BUS_Insurance",
                column: "LiveAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_Insurance_PatientId",
                table: "BUS_Insurance",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_Insurance_PatientRecordId",
                table: "BUS_Insurance",
                column: "PatientRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_Insurance_RightRouteTypeId",
                table: "BUS_Insurance",
                column: "RightRouteTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_ItemStock_ItemId",
                table: "BUS_ItemStock",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_ItemStock_StockId",
                table: "BUS_ItemStock",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_Patient_CareerId",
                table: "BUS_Patient",
                column: "CareerId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_Patient_CountryId",
                table: "BUS_Patient",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_Patient_DistrictId",
                table: "BUS_Patient",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_Patient_EthnicId",
                table: "BUS_Patient",
                column: "EthnicId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_Patient_GenderId",
                table: "BUS_Patient",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_Patient_ProvinceId",
                table: "BUS_Patient",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_Patient_ReligionId",
                table: "BUS_Patient",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_Patient_WardId",
                table: "BUS_Patient",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_PatientRecord_CareerId",
                table: "BUS_PatientRecord",
                column: "CareerId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_PatientRecord_DistrictId",
                table: "BUS_PatientRecord",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_PatientRecord_EthnicId",
                table: "BUS_PatientRecord",
                column: "EthnicId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_PatientRecord_GenderId",
                table: "BUS_PatientRecord",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_PatientRecord_NationalId",
                table: "BUS_PatientRecord",
                column: "NationalId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_PatientRecord_ProvinceId",
                table: "BUS_PatientRecord",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_PatientRecord_ReligionId",
                table: "BUS_PatientRecord",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_PatientRecord_WardId",
                table: "BUS_PatientRecord",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_ServiceRequestData_ServiceId",
                table: "BUS_ServiceRequestData",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_ServiceRequestData_ServiceRequestId",
                table: "BUS_ServiceRequestData",
                column: "ServiceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_ServiceResultData_ServiceId",
                table: "BUS_ServiceResultData",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_ServiceResultData_ServiceRequestDataId",
                table: "BUS_ServiceResultData",
                column: "ServiceRequestDataId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_ServiceResultData_ServiceRequestId",
                table: "BUS_ServiceResultData",
                column: "ServiceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_BUS_ServiceResultData_ServiceResultIndiceId",
                table: "BUS_ServiceResultData",
                column: "ServiceResultIndiceId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_Branch_DistrictId",
                table: "DIC_Branch",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_Branch_ProvinceId",
                table: "DIC_Branch",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_Branch_WardId",
                table: "DIC_Branch",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_Department_BranchId",
                table: "DIC_Department",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_Department_DepartmentTypeId",
                table: "DIC_Department",
                column: "DepartmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_District_ProvinceId",
                table: "DIC_District",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_ExecutionRoom_RoomId",
                table: "DIC_ExecutionRoom",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_ExecutionRoom_ServiceId",
                table: "DIC_ExecutionRoom",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_Icd_ChapterIcdId",
                table: "DIC_Icd",
                column: "ChapterIcdId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_Item_CountryId",
                table: "DIC_Item",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_Item_ItemLineId",
                table: "DIC_Item",
                column: "ItemLineId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_Item_ItemTypeId",
                table: "DIC_Item",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_Item_UnitId",
                table: "DIC_Item",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_ItemPricePolicy_ItemId",
                table: "DIC_ItemPricePolicy",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_ItemPricePolicy_PatientTypeId",
                table: "DIC_ItemPricePolicy",
                column: "PatientTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_ItemType_CountryId",
                table: "DIC_ItemType",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_ItemType_ItemGroupId",
                table: "DIC_ItemType",
                column: "ItemGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_ItemType_ItemLineId",
                table: "DIC_ItemType",
                column: "ItemLineId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_ItemType_UnitId",
                table: "DIC_ItemType",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_MedicalRecordType_MedicalRecordTypeGroupID",
                table: "DIC_MedicalRecordType",
                column: "MedicalRecordTypeGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_Room_DepartmentId",
                table: "DIC_Room",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_Room_RoomTypeId",
                table: "DIC_Room",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_Service_ServiceGroupHeInId",
                table: "DIC_Service",
                column: "ServiceGroupHeInId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_Service_ServiceGroupId",
                table: "DIC_Service",
                column: "ServiceGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_Service_SurgicalProcedureTypeId",
                table: "DIC_Service",
                column: "SurgicalProcedureTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_Service_UnitId",
                table: "DIC_Service",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_ServicePricePolicy_PatientTypeId",
                table: "DIC_ServicePricePolicy",
                column: "PatientTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_ServicePricePolicy_ServiceId",
                table: "DIC_ServicePricePolicy",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_ServiceResultIndice_ServiceId",
                table: "DIC_ServiceResultIndice",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_DIC_Ward_DistrictId",
                table: "DIC_Ward",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_SYS_RolePermissionBranch_BranchId",
                table: "SYS_RolePermissionBranch",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_SYS_RolePermissionBranch_PermissionId",
                table: "SYS_RolePermissionBranch",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SYS_Token_UserId",
                table: "SYS_Token",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SYS_UserRole_RoleId",
                table: "SYS_UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SYSRefType_RefTypeCategoryId",
                table: "SYSRefType",
                column: "RefTypeCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BUS_InOutStockItem");

            migrationBuilder.DropTable(
                name: "BUS_Insurance");

            migrationBuilder.DropTable(
                name: "BUS_ItemStock");

            migrationBuilder.DropTable(
                name: "BUS_MedicalRecordStatus");

            migrationBuilder.DropTable(
                name: "BUS_PatientRecordStatus");

            migrationBuilder.DropTable(
                name: "BUS_ServiceResultData");

            migrationBuilder.DropTable(
                name: "DIC_BirthCertBook");

            migrationBuilder.DropTable(
                name: "DIC_BloodType");

            migrationBuilder.DropTable(
                name: "DIC_BloodTypeRh");

            migrationBuilder.DropTable(
                name: "DIC_DeathCause");

            migrationBuilder.DropTable(
                name: "DIC_DeathCertBook");

            migrationBuilder.DropTable(
                name: "DIC_DeathWithin");

            migrationBuilder.DropTable(
                name: "DIC_ExecutionRoom");

            migrationBuilder.DropTable(
                name: "DIC_Hospital");

            migrationBuilder.DropTable(
                name: "DIC_Icd");

            migrationBuilder.DropTable(
                name: "DIC_ItemPricePolicy");

            migrationBuilder.DropTable(
                name: "DIC_MedicalRecordType");

            migrationBuilder.DropTable(
                name: "DIC_PatientRecordType");

            migrationBuilder.DropTable(
                name: "DIC_PaymentMethod");

            migrationBuilder.DropTable(
                name: "DIC_ReceptionObjectType");

            migrationBuilder.DropTable(
                name: "DIC_RelativeType");

            migrationBuilder.DropTable(
                name: "DIC_ServicePricePolicy");

            migrationBuilder.DropTable(
                name: "DIC_TransactionType");

            migrationBuilder.DropTable(
                name: "DIC_TransferForm");

            migrationBuilder.DropTable(
                name: "DIC_TransferReason");

            migrationBuilder.DropTable(
                name: "DIC_TreatmentEndType");

            migrationBuilder.DropTable(
                name: "DIC_TreatmentResult");

            migrationBuilder.DropTable(
                name: "SYS_DbOption");

            migrationBuilder.DropTable(
                name: "SYS_RolePermissionBranch");

            migrationBuilder.DropTable(
                name: "SYS_Token");

            migrationBuilder.DropTable(
                name: "SYS_UserRole");

            migrationBuilder.DropTable(
                name: "SYSRefType");

            migrationBuilder.DropTable(
                name: "BUS_InOutStock");

            migrationBuilder.DropTable(
                name: "BUS_PatientRecord");

            migrationBuilder.DropTable(
                name: "DIC_LiveArea");

            migrationBuilder.DropTable(
                name: "DIC_RightRouteType");

            migrationBuilder.DropTable(
                name: "BUS_ServiceRequestData");

            migrationBuilder.DropTable(
                name: "DIC_ServiceResultIndice");

            migrationBuilder.DropTable(
                name: "DIC_ChapterIcd");

            migrationBuilder.DropTable(
                name: "DIC_Item");

            migrationBuilder.DropTable(
                name: "DIC_MedicalRecordTypeGroup");

            migrationBuilder.DropTable(
                name: "DIC_PatientType");

            migrationBuilder.DropTable(
                name: "SYS_Permission");

            migrationBuilder.DropTable(
                name: "SYS_Role");

            migrationBuilder.DropTable(
                name: "SYSRefTypeCategory");

            migrationBuilder.DropTable(
                name: "BUS_InOutStockType");

            migrationBuilder.DropTable(
                name: "BUS_MedicalRecord");

            migrationBuilder.DropTable(
                name: "BUS_Patient");

            migrationBuilder.DropTable(
                name: "DIC_Room");

            migrationBuilder.DropTable(
                name: "DIC_Supplier");

            migrationBuilder.DropTable(
                name: "SYS_User");

            migrationBuilder.DropTable(
                name: "BUS_ServiceRequest");

            migrationBuilder.DropTable(
                name: "DIC_Service");

            migrationBuilder.DropTable(
                name: "DIC_ItemType");

            migrationBuilder.DropTable(
                name: "DIC_Career");

            migrationBuilder.DropTable(
                name: "DIC_Ethnic");

            migrationBuilder.DropTable(
                name: "DIC_Gender");

            migrationBuilder.DropTable(
                name: "DIC_Religion");

            migrationBuilder.DropTable(
                name: "DIC_Department");

            migrationBuilder.DropTable(
                name: "DIC_RoomType");

            migrationBuilder.DropTable(
                name: "DIC_ServiceGroupHeIn");

            migrationBuilder.DropTable(
                name: "DIC_ServiceGroup");

            migrationBuilder.DropTable(
                name: "DIC_SurgicalProcedureType");

            migrationBuilder.DropTable(
                name: "DIC_Country");

            migrationBuilder.DropTable(
                name: "DIC_ItemGroup");

            migrationBuilder.DropTable(
                name: "DIC_ItemLine");

            migrationBuilder.DropTable(
                name: "DIC_Unit");

            migrationBuilder.DropTable(
                name: "DIC_Branch");

            migrationBuilder.DropTable(
                name: "DIC_DepartmentType");

            migrationBuilder.DropTable(
                name: "DIC_Ward");

            migrationBuilder.DropTable(
                name: "DIC_District");

            migrationBuilder.DropTable(
                name: "DIC_Province");
        }
    }
}
