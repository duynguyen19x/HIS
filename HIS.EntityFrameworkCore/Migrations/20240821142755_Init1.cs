using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DExaminations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExaminationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExaminationTypeId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicalRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TreatmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReceptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IcdCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IcdName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IcdSubCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IcdText = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    TraditionalIcdCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TraditionalIcdName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    TraditionalIcdSubCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TraditionalIcdText = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ChiefComplaint = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsAllergy = table.Column<bool>(type: "bit", nullable: false),
                    AllergyHistory = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PathologicalProcess = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    GeneralExam = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PartExam = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Pulse = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Temperature = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SpO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BloodPressureLow = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BloodPressureHight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RespiratoryRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DExaminations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DInOutStockTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DInOutStockTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DInsurances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicalRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InsuranceCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MediOrgCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MediOrgName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LiveAreaId = table.Column<int>(type: "int", nullable: false),
                    RightRouteTypeId = table.Column<int>(type: "int", nullable: false),
                    Join5YearTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FreeCoPaidTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HasBirthCertificate = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DInsurances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DInvoices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvoiceTypeId = table.Column<int>(type: "int", nullable: false),
                    InvoiceGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentMethodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicalRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TreatmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DInvoices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DPatientNumbers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientNumberDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DPatientNumbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DServiceRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceRequestCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RequestTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UseTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NumOrder = table.Column<int>(type: "int", nullable: false),
                    IsPriority = table.Column<bool>(type: "bit", nullable: false),
                    IcdCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IcdName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IcdSubCode = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IcdText = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ServiceRequestTypeId = table.Column<int>(type: "int", nullable: false),
                    PatientRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MedicalRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TreatmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StartUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EndUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExecuteDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExecuteRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DServiceRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SBloodRhTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BloodRhTypeCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BloodRhTypeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_SBloodRhTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SBloodTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BloodTypeCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BloodTypeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_SBloodTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SCareers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_SCareers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SChapterIcds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SChapterIcds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SCountries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MediCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
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
                    table.PrimaryKey("PK_SCountries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SDbOptions",
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
                    table.PrimaryKey("PK_SDbOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SDeathCauses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_SDeathCauses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SDeathWithins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_SDeathWithins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SDepartmentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_SDepartmentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SEthnicities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MediCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
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
                    table.PrimaryKey("PK_SEthnicities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SGenders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_SGenders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SHospitalLevels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HospitalLevelCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HospitalLevelName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_SHospitalLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SHospitalLines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HospitalLineCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HospitalLineName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_SHospitalLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SHospitals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MediOrgCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
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
                    table.PrimaryKey("PK_SHospitals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SHospitalSpecialities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HospitalSpecialityCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HospitalSpecialityName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_SHospitalSpecialities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SInvoiceGroupBelongToUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SInvoiceGroupBelongToUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SInvoiceGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    StartNumOrder = table.Column<int>(type: "int", nullable: false),
                    InvTemplateNo = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    InvSeries = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    InvoiceTypeList = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SInvoiceGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SInvoiceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_SInvoiceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SItemGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    IsSystem = table.Column<bool>(type: "bit", nullable: false),
                    CommodityType = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SItemGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SItemLines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SItemLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SLiveAreas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MediCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
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
                    table.PrimaryKey("PK_SLiveAreas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SMedicalRecordTypeGroups",
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
                    table.PrimaryKey("PK_SMedicalRecordTypeGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SOptionCategorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOptionCategorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SOrderTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderTypeCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OrderTypeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_SOrderTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SPatientObjectTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_SPatientObjectTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SPaymentMethods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_SPaymentMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SPermissions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ParentId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPermissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SProvinces",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProvinceCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProvinceName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SProvinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SReceptionObjectTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_SReceptionObjectTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SRelationships",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RelationshipCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RelationshipName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_SRelationships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SReligions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_SReligions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SReportCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SReportCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SRightRouteTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_SRightRouteTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                name: "SSuppliers",
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSuppliers", x => x.Id);
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
                name: "STransferForms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_STransferForms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "STransferReasons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_STransferReasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "STreatmentEndTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_STreatmentEndTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "STreatmentResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_STreatmentResults", x => x.Id);
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
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SIcds",
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
                    table.PrimaryKey("PK_SIcds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SIcds_SChapterIcds_ChapterIcdId",
                        column: x => x.ChapterIcdId,
                        principalTable: "SChapterIcds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SMedicalRecordTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalRecordTypeCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MedicalRecordTypeName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    MedicalRecordTypeGroupId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMedicalRecordTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SMedicalRecordTypes_SMedicalRecordTypeGroups_MedicalRecordTypeGroupId",
                        column: x => x.MedicalRecordTypeGroupId,
                        principalTable: "SMedicalRecordTypeGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderTypeID = table.Column<int>(type: "int", nullable: false),
                    OrderStatusID = table.Column<int>(type: "int", nullable: false),
                    NumOrder = table.Column<int>(type: "int", nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MedicalRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TreatmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InsuranceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SampleStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SampleEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SampleUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SampleDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SampleRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReceiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReceiveUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExecuteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExecuteUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExecuteDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExecuteRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IcdCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IcdName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IcdSubCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IcdText = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    TraditionalIcdCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TraditionalIcdName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    TraditionalIcdSubCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TraditionalIcdText = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsEmergency = table.Column<bool>(type: "bit", nullable: false),
                    IsPriority = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DOrders_SOrderTypes_OrderTypeID",
                        column: x => x.OrderTypeID,
                        principalTable: "SOrderTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SDistricts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DistrictCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DistrictName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                name: "SReports",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ParentId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    ReportCategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SReports_SReportCategories_ReportCategoryId",
                        column: x => x.ReportCategoryId,
                        principalTable: "SReportCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SRolePermissionMappings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermissionId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SRolePermissionMappings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SRolePermissionMappings_SPermissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "SPermissions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SRolePermissionMappings_SRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "SRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SItemTypes",
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SItemTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SItemTypes_SCountries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "SCountries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SItemTypes_SItemGroups_ItemGroupId",
                        column: x => x.ItemGroupId,
                        principalTable: "SItemGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SItemTypes_SItemLines_ItemLineId",
                        column: x => x.ItemLineId,
                        principalTable: "SItemLines",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SItemTypes_SUnits_UnitId",
                        column: x => x.UnitId,
                        principalTable: "SUnits",
                        principalColumn: "Id");
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                        name: "FK_SServices_SSurgicalProcedureTypes_SurgicalProcedureTypeId",
                        column: x => x.SurgicalProcedureTypeId,
                        principalTable: "SSurgicalProcedureTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SServices_SUnits_UnitId",
                        column: x => x.UnitId,
                        principalTable: "SUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SWards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WardCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WardName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SearchCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                name: "SItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SItems_SCountries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "SCountries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SItems_SItemLines_ItemLineId",
                        column: x => x.ItemLineId,
                        principalTable: "SItemLines",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SItems_SItemTypes_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "SItemTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SItems_SUnits_UnitId",
                        column: x => x.UnitId,
                        principalTable: "SUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DServiceRequestDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InsuranceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsSampled = table.Column<bool>(type: "bit", nullable: false),
                    SampleTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SampleRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DServiceRequestDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DServiceRequestDetails_DServiceRequests_ServiceRequestId",
                        column: x => x.ServiceRequestId,
                        principalTable: "DServiceRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DServiceRequestDetails_SServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SServicePricePolicies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SServicePricePolicies_SPatientObjectTypes_PatientTypeId",
                        column: x => x.PatientTypeId,
                        principalTable: "SPatientObjectTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SServicePricePolicies_SServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SServiceResultIndices",
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
                    table.PrimaryKey("PK_SServiceResultIndices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SServiceResultIndices_SServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DPatientRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientRecordTypeId = table.Column<int>(type: "int", nullable: false),
                    PatientRecordStatusId = table.Column<int>(type: "int", nullable: false),
                    PatientRecordDate = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BirthYear = table.Column<int>(type: "int", nullable: false),
                    BirthPlace = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EthnicId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReligionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CareerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WorkPlace = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BloodTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BloodTypeRhId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IssueBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ContactType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactTel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactMobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactIdentificationNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactIssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactIssueBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ReceptionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatientObjectTypeId = table.Column<int>(type: "int", nullable: false),
                    IsPriority = table.Column<bool>(type: "bit", nullable: false),
                    HospitalizationReason = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsTransferIn = table.Column<bool>(type: "bit", nullable: false),
                    TransferInCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TransferInMediOrgCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TransferInMediOrgName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TransferInTimeFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TransferInTimeTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TransferInIcdCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TransferInIcdName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TransferInFormId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransferInReasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransferInRightRoute = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DPatientRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DPatientRecords_SBloodRhTypes_BloodTypeRhId",
                        column: x => x.BloodTypeRhId,
                        principalTable: "SBloodRhTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DPatientRecords_SBloodTypes_BloodTypeId",
                        column: x => x.BloodTypeId,
                        principalTable: "SBloodTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DPatientRecords_SCareers_CareerId",
                        column: x => x.CareerId,
                        principalTable: "SCareers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DPatientRecords_SCountries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "SCountries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DPatientRecords_SDistricts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "SDistricts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DPatientRecords_SEthnicities_EthnicId",
                        column: x => x.EthnicId,
                        principalTable: "SEthnicities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DPatientRecords_SGenders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "SGenders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DPatientRecords_SProvinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "SProvinces",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DPatientRecords_SReligions_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "SReligions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DPatientRecords_SWards_WardId",
                        column: x => x.WardId,
                        principalTable: "SWards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DPatients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PatientName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BirthYear = table.Column<int>(type: "int", nullable: false),
                    BirthPlace = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientNumberId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BloodTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BloodRhTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CareerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EthnicityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReligionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WorkPlace = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IssueBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ContactRelationshipName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ContactIdentificationNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactIssueBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ContactIssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactPhoneNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ContactAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DPatients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DPatients_DPatientNumbers_PatientNumberId",
                        column: x => x.PatientNumberId,
                        principalTable: "DPatientNumbers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DPatients_SBloodRhTypes_BloodRhTypeId",
                        column: x => x.BloodRhTypeId,
                        principalTable: "SBloodRhTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DPatients_SBloodTypes_BloodTypeId",
                        column: x => x.BloodTypeId,
                        principalTable: "SBloodTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DPatients_SCareers_CareerId",
                        column: x => x.CareerId,
                        principalTable: "SCareers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DPatients_SCountries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "SCountries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DPatients_SEthnicities_EthnicityId",
                        column: x => x.EthnicityId,
                        principalTable: "SEthnicities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DPatients_SGenders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "SGenders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DPatients_SProvinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "SProvinces",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DPatients_SReligions_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "SReligions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DPatients_SWards_WardId",
                        column: x => x.WardId,
                        principalTable: "SWards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SItemPricePolicies",
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SItemPricePolicies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SItemPricePolicies_SItems_ItemId",
                        column: x => x.ItemId,
                        principalTable: "SItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SItemPricePolicies_SPatientObjectTypes_PatientTypeId",
                        column: x => x.PatientTypeId,
                        principalTable: "SPatientObjectTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DServiceRequestDetailResults",
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
                    table.PrimaryKey("PK_DServiceRequestDetailResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DServiceRequestDetailResults_DServiceRequestDetails_ServiceRequestDataId",
                        column: x => x.ServiceRequestDataId,
                        principalTable: "DServiceRequestDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DServiceRequestDetailResults_DServiceRequests_ServiceRequestId",
                        column: x => x.ServiceRequestId,
                        principalTable: "DServiceRequests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DServiceRequestDetailResults_SServiceResultIndices_ServiceResultIndiceId",
                        column: x => x.ServiceResultIndiceId,
                        principalTable: "SServiceResultIndices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DServiceRequestDetailResults_SServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DMedicalRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicalRecordCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MedicalRecordDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicalRecordTypeId = table.Column<int>(type: "int", nullable: false),
                    MedicalRecordStatusId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PatientName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BirthYear = table.Column<int>(type: "int", nullable: false),
                    BirthPlace = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    BloodTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BloodRhTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CareerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EthnicityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReligionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    WorkPlace = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IssueBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ContactRelationshipName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ContactIdentificationNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactIssueBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ContactIssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactPhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactAddress = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ReceptionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChiefComplaint = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PatientObjectTypeId = table.Column<int>(type: "int", nullable: false),
                    ReceptionObjectTypeId = table.Column<int>(type: "int", nullable: false),
                    IsPriority = table.Column<bool>(type: "bit", nullable: false),
                    IsTransferIn = table.Column<bool>(type: "bit", nullable: false),
                    TransferInCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TransferInMediOrgCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TransferInMediOrgName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    TransferInTimeFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TransferInTimeTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TransferInIcdCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TransferInIcdName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    TransferInFormId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransferInReasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsTransferInRightRoute = table.Column<bool>(type: "bit", nullable: true),
                    HospitalizationReason = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    NumOrder = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMedicalRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DMedicalRecords_DPatients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "DPatients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DInOutStockItems",
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
                    table.PrimaryKey("PK_DInOutStockItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DInOutStockItems_SItemTypes_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "SItemTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DInOutStockItems_SItems_ItemId",
                        column: x => x.ItemId,
                        principalTable: "SItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DInOutStocks",
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DInOutStocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DInOutStocks_DInOutStockTypes_InOutStockTypeId",
                        column: x => x.InOutStockTypeId,
                        principalTable: "DInOutStockTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DInOutStocks_DMedicalRecords_PatientRecordId",
                        column: x => x.PatientRecordId,
                        principalTable: "DMedicalRecords",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DInOutStocks_DPatients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "DPatients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DInOutStocks_SSuppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "SSuppliers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DItemStocks",
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DItemStocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DItemStocks_SItems_ItemId",
                        column: x => x.ItemId,
                        principalTable: "SItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Machines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    MachineType = table.Column<int>(type: "int", nullable: false),
                    MachineOrderType = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    UsageStandard = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SBirthCertBooks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    StartNumOrder = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SBirthCertBooks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SBranchs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MediOrgCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MediOrgAcceptCode = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    HospitalLevelID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HospitalLineID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HospitalSpecialityID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParentOrganizationName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ProvinceID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DistrictID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WardID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DirectorID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_SBranchs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SBranchs_SDistricts_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "SDistricts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SBranchs_SHospitalLevels_HospitalLevelID",
                        column: x => x.HospitalLevelID,
                        principalTable: "SHospitalLevels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SBranchs_SHospitalLines_HospitalLineID",
                        column: x => x.HospitalLineID,
                        principalTable: "SHospitalLines",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SBranchs_SHospitalSpecialities_HospitalSpecialityID",
                        column: x => x.HospitalSpecialityID,
                        principalTable: "SHospitalSpecialities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SBranchs_SProvinces_ProvinceID",
                        column: x => x.ProvinceID,
                        principalTable: "SProvinces",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SBranchs_SWards_WardID",
                        column: x => x.WardID,
                        principalTable: "SWards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SDeathCertBooks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    StartNumOrder = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SDeathCertBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SDeathCertBooks_SBranchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "SBranchs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastWorkingBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SUsers_SBranchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "SBranchs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SDepartments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MediCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DepartmentTypeId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChiefId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
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
                    table.ForeignKey(
                        name: "FK_SDepartments_SUsers_ChiefId",
                        column: x => x.ChiefId,
                        principalTable: "SUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    OptionCategoryId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OptionValue = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ValueType = table.Column<int>(type: "int", nullable: false),
                    IsGlobalOption = table.Column<bool>(type: "bit", nullable: false),
                    IsUserOption = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SOptions_SBranchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "SBranchs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SOptions_SOptionCategorys_OptionCategoryId",
                        column: x => x.OptionCategoryId,
                        principalTable: "SOptionCategorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SOptions_SUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "SUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SUserRoleMappings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUserRoleMappings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SUserRoleMappings_SRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "SRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SUserRoleMappings_SUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "SUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SYSTokens",
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
                    table.PrimaryKey("PK_SYSTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SYSTokens_SUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "SUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SRooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MediCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SExecutionRooms_SServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SUserRoomMappings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUserRoomMappings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SUserRoomMappings_SRooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "SRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SUserRoomMappings_SUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "SUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DInOutStockTypes",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Inactive", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "01", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Nhập hàng hóa từ nhà cung cấp" },
                    { 2, "02", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Xuất hàng hóa trả nhà cung cấp" },
                    { 3, "03", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Nhập từ kho khác" },
                    { 4, "04", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Xuất trả kho khác" },
                    { 5, "05", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Nhập bù" },
                    { 6, "06", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Xuất thanh lý" },
                    { 7, "07", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Xuất kiểm nghiệm" },
                    { 8, "08", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Xuất hủy (Mất, hỏng, vỡ)" },
                    { 9, "09", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Xuất hao phí phòng khám" },
                    { 10, "10", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Xuất sử dụng phòng" },
                    { 11, "11", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Xuất sử dụng khoa" },
                    { 12, "12", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Nhập bù cơ số tủ trực" },
                    { 13, "13", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Xuất bù cơ số tủ trực" },
                    { 14, "14", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Bổ sung cơ số tủ trực" },
                    { 15, "15", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Hoàn trả cơ số tủ trực" },
                    { 16, "16", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Xuất bán cho khách hàng" },
                    { 17, "17", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Nhập trả từ khách hàng" },
                    { 18, "18", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Nhập đầu kỳ" },
                    { 99, "99", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Xuất khác" }
                });

            migrationBuilder.InsertData(
                table: "SBloodRhTypes",
                columns: new[] { "Id", "BloodRhTypeCode", "BloodRhTypeName", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("0569461c-35a7-46b5-b285-d158b6729dcc"), "Rh-", "Rh âm", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 2 },
                    { new Guid("c8444f53-6712-4726-9b86-714b789648bb"), "Rh+", "Rh dương", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "SBloodTypes",
                columns: new[] { "Id", "BloodTypeCode", "BloodTypeName", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("29a04857-f834-4f4a-896b-db0a829125c4"), "B", "Nhóm máu B", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 3 },
                    { new Guid("96fc1f86-2e95-4aac-bb4b-bd5eb2ef09fe"), "O", "Nhóm máu O", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 1 },
                    { new Guid("b5ce25e2-95a5-4a2f-ac25-b886ee18e56e"), "AB", "Nhóm máu AB", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 4 },
                    { new Guid("be2cd126-228c-4fbf-9470-c5cb8195465b"), "A", "Nhóm máu A", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "SCareers",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("27f97033-2472-46b2-ad8a-763039cac120"), "3", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Trẻ dưới 6 tuổi đi học, dưới 15 tuổi không đi học", 3 },
                    { new Guid("2bebf89a-f496-4da5-aabb-787c4dca82a7"), "13", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Thương binh", 13 },
                    { new Guid("343e6492-50e0-4f84-b323-a9411196e694"), "1", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Nông dân", 1 },
                    { new Guid("343e6492-50e0-4f84-b323-a9411196e695"), "4", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Sinh viên, học sinh", 4 },
                    { new Guid("343e6492-50e0-4f84-b323-a9411196e696"), "5", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Công nhân", 5 },
                    { new Guid("343e6492-50e0-4f84-b323-a9411196e697"), "6", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Trí thức", 6 },
                    { new Guid("43d31da7-5889-4fbd-94cb-4800507ac9d8"), "14", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Kế toán", 14 },
                    { new Guid("508ab49b-78a7-47fe-b5c9-e06589fb8126"), "7", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Hành chính, sự nghiệp", 7 },
                    { new Guid("824af7e8-3526-4b6f-9005-bf0fde1974a8"), "12", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Giáo viên", 12 },
                    { new Guid("855ded87-0521-4322-93f5-69e36e3a89d8"), "11", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Nhân dân", 11 },
                    { new Guid("89bc4bca-f38b-4808-a64d-325b03dc240c"), "15", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Khác", 15 },
                    { new Guid("9f21b51a-dd3b-4f22-b3b5-e3d6b59107ae"), "2", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Lực lượng vũ trang", 2 },
                    { new Guid("a373a40c-5097-4716-b683-4a5c3b69fe6e"), "9", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Dịch vụ", 9 },
                    { new Guid("a373a40c-5097-4716-b683-4a5c3b69fe7e"), "10", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Ngoại kiều", 10 },
                    { new Guid("e17526d6-1ae3-4649-86be-e143474d3a89"), "8", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Y tế", 8 }
                });

            migrationBuilder.InsertData(
                table: "SChapterIcds",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("0377427b-d6bd-4b58-99a9-d71789475bb2"), "38", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Chương XVI. Dị tật bẩm, biến dạng và bất thường về nhiễm sắc thể - U65", 39 },
                    { new Guid("08b63907-e7b9-4e6a-b075-706cca99f29c"), "32", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Chương X. Bệnh hệ hô hấp U59", 33 },
                    { new Guid("08f6a2b3-d5e6-4fad-a022-5f29d0117801"), "21", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "21.Các yếu tố ảnh hưởng đến tình trạng sức khỏe và tiếp xúc dịch vụ y tế", 22 },
                    { new Guid("0d2992cf-6fba-4871-97b3-a8a1229e86fd"), "4", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "4.Bệnh nội tiết, dinh dưỡng và chuyển hóa", 5 },
                    { new Guid("11baf250-7aed-4f3f-949b-82d8929d55ff"), "7", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "7.Bệnh mắt và phần phụ", 8 },
                    { new Guid("134969e1-21e0-496c-8a7e-b40d5e52b4f4"), "23", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Chương I. Bệnh nhiễm trùng và ký sinh trùng U50", 24 },
                    { new Guid("30e5cab2-63d3-4b93-b430-042b04276e20"), "26", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Chương IV. Bệnh nội tiết, dinh dưỡng và rối loạn chuyển hóa - U53", 27 },
                    { new Guid("3a6de8c5-5bfd-4648-8225-42c79a224793"), "12", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "12.Bệnh da và mô dưới da", 13 },
                    { new Guid("4104f31a-d1ad-4025-8756-4faddf40d453"), "34", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Chương XII. Bệnh của da và mô dưới da - U61", 35 },
                    { new Guid("4c8535f7-5852-435d-8b4d-66c198537fc4"), "6", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "6.Bệnh hệ thần kinh", 7 },
                    { new Guid("5a91f9a2-5a73-4dce-9a99-532c3b75518e"), "9", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "9.Bệnh tuần hoàn", 10 },
                    { new Guid("5d500bff-32f6-46ee-ba7a-f89a43fdd5b1"), "18", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "18.Các triệu chứng, dấu hiệu và những biểu hiện lâm sàng bất thường, không phân loại ở phần khác", 19 },
                    { new Guid("5ec5c91b-db70-491b-b1b5-a617d9a82549"), "10", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "10.Bệnh hô hấp", 11 },
                    { new Guid("613e5901-9552-40f8-b865-f9fd6e91d7e8"), "20", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "20.Các nguyên nhân ngoại sinh của bệnh và tử vong", 21 },
                    { new Guid("6cd03dbd-dcbf-44d1-ab7a-3b32e71b3cb7"), "11", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "11.Bệnh tiêu hóa", 12 },
                    { new Guid("723b5a32-b7a2-4d46-9e19-c42d096839e2"), "39", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Chương XVII. Các triệu chứng dấu hiệu và những biểu hiện lâm sàng bất thường, chưa được phân loại ở nơi khác - U66", 40 },
                    { new Guid("91c637c5-272c-488c-8489-98be3297d88e"), "17", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "17.Dị tật bẩm sinh, biến dạng và bất thường về nhiễm sắc thể", 18 },
                    { new Guid("93672f0e-4d83-4214-9576-d29113acea27"), "14", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "14.Bệnh hệ sinh dục - tiết niệu", 15 },
                    { new Guid("a0570373-f0ce-4051-93e7-3285476367cb"), "31", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Chương IX. Bệnh hệ tuần hoàn - U58", 32 },
                    { new Guid("a67315a8-8874-4a76-9d56-bb5103740e66"), "37", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Chương XV. Thai nghén, sinh đẻ và hậu sản - U64", 38 },
                    { new Guid("aaf07983-f9ed-43a5-8d9e-be42cdaa4044"), "22", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "22.Kháng các thuốc kháng sinh và chống ung thư", 23 },
                    { new Guid("b4d1c297-0f9c-41d4-9aa9-b211ecf0cbee"), "30", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Chương VIII. Bệnh của tai xương chũm - U57", 31 },
                    { new Guid("bb4dd54d-2566-41be-a293-ed9398efeaa0"), "16", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "16.Bệnh lý xuất phát trong thời ký chu kỳ", 17 },
                    { new Guid("c1747ec7-094e-4516-bd96-3e41327a317d"), "3", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "3.Bệnh của máu, cơ quan tạo máu và các rối loạn liên quan đến cơ chế miễn dịch", 4 },
                    { new Guid("c27dbaeb-b11f-448b-bb63-be2f06d3e795"), "24", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Chương II. Bướu tân sinh - U51", 25 },
                    { new Guid("c3c34fe9-3d68-4f4c-98ab-abc10ec96ccc"), "40", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Chương XVIII. Vết thương ngộ độc và hậu quả của một số nguyên nhân bên ngoài - U67", 41 },
                    { new Guid("c81585c5-e57d-468f-99f2-1b403317ffd9"), "2", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "2.Bướu tân sinh", 3 },
                    { new Guid("cb433c30-519a-40ad-aab8-479dfad013c3"), "15", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "15.Thai nghén, sinh đẻ và hậu sản", 16 },
                    { new Guid("cd456287-b5aa-4d8c-b23d-7027c7676ce7"), "36", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Chương XIV. Bệnh hệ sinh dục - Tiết niệu - U63", 37 },
                    { new Guid("dd087168-fb8b-451f-bddd-56adff7a91b3"), "1", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "1.Bệnh nhiễm trùng và ký sinh trùng", 2 },
                    { new Guid("dd240e2f-1434-4091-a691-12da1214424e"), "19", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "19.Vết thương, ngộ độc và hậu quả của một số nguyên nhân bên ngoài", 20 },
                    { new Guid("e06c956c-1795-46a0-ba63-cb75f74ac431"), "5", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "5.Rối loạn tâm thần và hành vi", 6 },
                    { new Guid("e71c20e6-9f6c-4998-8867-c29b3f0da643"), "27", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Chương V. Bệnh rối loạn tâm thần và hành vi - U54", 28 },
                    { new Guid("e96358f3-2f7c-4d6f-a4fa-0268039df244"), "33", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Chương XI. Bệnh tiêu hóa - U60", 34 },
                    { new Guid("f21cf99c-f691-43eb-92c7-d9cd595fc1b2"), "29", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Chương VII. Bệnh về mắt và phần phụ - U56", 30 },
                    { new Guid("f2b02143-9c76-4717-a9a5-711ce23bf81c"), "28", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Chương VI. Bệnh hệ thần kinh - U55", 29 },
                    { new Guid("f3685b6e-8b27-4e8e-8a7d-b07ae695805f"), "8", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "8.Bệnh tai và xương chũm", 9 },
                    { new Guid("f8811c3e-61e4-4344-b139-b583dc0d94a3"), "25", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Chương III. Bệnh về máu, cơ quan tạo máu và các rối loạn liên quan đến cơ chế miễn dịch - U52", 26 },
                    { new Guid("f98e5ee7-4651-43fd-85fd-7e077785ad53"), "13", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "13.Bệnh của hệ xương khớp và mô liên kết", 14 },
                    { new Guid("f9e407f1-0417-4067-9d25-dae91d19e1bf"), "35", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Chương XIII. Bệnh của hệ xương khớp và mô liên kết - U62", 36 },
                    { new Guid("ffa69c02-696f-4645-b72e-0f371b8cacfa"), "0", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Khác", 1 }
                });

            migrationBuilder.InsertData(
                table: "SCountries",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "MediCode", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), "VN", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "000", null, null, "Việt Nam", 0 },
                    { new Guid("0105cfd9-5265-4dcc-b2d8-790abecd5577"), "PS", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "PS", null, null, "Palestinian Authority", 0 },
                    { new Guid("02cd862f-7bf2-4dee-9d8d-869f67659eac"), "CX", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "CX", null, null, "Christmas island", 0 },
                    { new Guid("05600686-62bc-4be9-b009-58ae6fac5dc2"), "UM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "UM", null, null, "United States Minor Outlying Islands", 0 },
                    { new Guid("05f8a24e-3764-41af-b79b-3e05da6964ad"), "TO", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "276", null, null, "Tonga", 0 },
                    { new Guid("060539cd-d169-45c2-bec2-28a91e41bcb3"), "IL", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "184", null, null, "Israel", 0 },
                    { new Guid("067dbcfb-9729-4016-aa0f-526f43657542"), "CL", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "141", null, null, "Chile", 0 },
                    { new Guid("07c04d8d-4e1c-4896-ba8a-7d8172562b37"), "KP", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "277", null, null, "Triều Tiên", 0 },
                    { new Guid("09127bf0-ff5d-4660-8fef-18b3107bf295"), "BI", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "135", null, null, "Burundi", 0 },
                    { new Guid("0d9bf5f6-20bb-4b4f-8c3e-0b7205eabe19"), "PR", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "PR", null, null, "Puerto Rico", 0 },
                    { new Guid("0f42743d-f2ae-4d4d-9e9c-6dcd785204ff"), "SE", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "273", null, null, "Thụy Điển", 0 },
                    { new Guid("10a98338-7167-4e5b-b3e4-9515f63bb43d"), "FI", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "241", null, null, "Phần Lan", 0 },
                    { new Guid("10f310c4-857b-431b-934c-19ebc560571c"), "IS", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "179", null, null, "Iceland", 0 },
                    { new Guid("1137907c-6292-4973-8a6a-5a8a55216701"), "OM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "233", null, null, "Oman", 0 },
                    { new Guid("16bfb332-7ffe-4d31-a2a2-05e7cc250969"), "Z1", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Z1", null, null, "Sovereign Military Order of Malta (SMOM)", 0 },
                    { new Guid("1760cdb2-5d9e-4a4d-a422-9d2d54333b72"), "VA", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "290", null, null, "Thành Vatican", 0 },
                    { new Guid("18be6a2d-0cc9-4e57-9b95-0fd5e0999094"), "LA", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "193", null, null, "Lào", 0 },
                    { new Guid("19b9d4e2-dd04-4d66-ba70-e71a800b8563"), "CO", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "142", null, null, "Colombia", 0 },
                    { new Guid("1a52542a-e4e8-4514-b84f-d8f7a0ce8bf5"), "HU", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "177", null, null, "Hungary", 0 },
                    { new Guid("1bb67a2c-65b1-4437-b7db-61bb5c5c945a"), "NZ", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "227", null, null, "New Zealand", 0 },
                    { new Guid("1bd96043-4837-4ab4-8812-0230d7cdc37c"), "BH", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "117", null, null, "Bahrain", 0 },
                    { new Guid("1c1e8f0d-fa36-4dd5-a349-51f8f8cf1e11"), "RU", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "231", null, null, "Nga", 0 },
                    { new Guid("1c3907c5-3cd4-4530-a28c-6d4acceec175"), "AZ", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "113", null, null, "Azerbaijan", 0 },
                    { new Guid("1cb83a16-11a1-438b-8fd9-22e661c5904a"), "TN", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "281", null, null, "Tunisia", 0 },
                    { new Guid("1cc02fda-f061-49ad-a4f1-ecb564a28c88"), "KZ", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "187", null, null, "Kazakhstan", 0 },
                    { new Guid("1d374c8c-88c5-49ae-9c9c-0b2b362b1198"), "BR", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "131", null, null, "Brasil", 0 },
                    { new Guid("1d41f179-ba78-41d6-8ecf-595c7d6de65a"), "MA", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "209", null, null, "Maroc", 0 },
                    { new Guid("1df44627-4127-48c0-bbc7-2afc64cb75d2"), "CH", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "274", null, null, "Thụy Sĩ", 0 },
                    { new Guid("1f0c0c80-dceb-47c4-9bfb-d9e2b29e8010"), "NR", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "224", null, null, "Nauru", 0 },
                    { new Guid("20aa6e3b-0838-45fc-9769-161b291e5e24"), "Z4", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Z4", null, null, "Scotland", 0 },
                    { new Guid("212573b7-ec34-4844-b150-74f567de2c5d"), "GF", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "GF", null, null, "French guiana", 0 },
                    { new Guid("21668f2b-b3d0-4927-9d67-3f9eee4736d6"), "AS", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "AS", null, null, "Samoa thuộc Hoa Kỳ", 0 },
                    { new Guid("22174cd0-7b2d-4c6b-bb6c-5273e63d28f0"), "MY", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "205", null, null, "Malaysia", 0 },
                    { new Guid("226d663e-46ee-4ab2-b385-b062345debd9"), "FR", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "240", null, null, "Pháp", 0 },
                    { new Guid("23063395-5d36-41c9-9711-66722ab8849f"), "CZ", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "252", null, null, "Séc", 0 },
                    { new Guid("24c5f9fa-e493-43a1-9d2a-c6d25dc2ea89"), "FY", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "254", null, null, "Serbia", 0 },
                    { new Guid("25b7ed9b-8bfd-4601-a4c5-a59dfe5a3fab"), "AN", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "AN", null, null, "Netherlands antilles", 0 },
                    { new Guid("25df127f-9fb7-4f1d-8a4f-484364e15f91"), "GN", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "170", null, null, "Guinea", 0 },
                    { new Guid("264432ff-ba3d-4402-ae05-d3cbbdf7eef4"), "NE", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "229", null, null, "Niger", 0 },
                    { new Guid("26d0e10a-43ea-4654-93be-00a21f60b760"), "PG", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "237", null, null, "Papua New Guinea", 0 },
                    { new Guid("298cf3d9-cf13-401f-86b5-368d1c71ec77"), "GQ", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "169", null, null, "Guinea Xích Đạo", 0 },
                    { new Guid("2e24284d-fe7b-477b-a3e9-23505ccbe379"), "Z6", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Z6", null, null, "Great Britain (See United Kingdom)", 0 },
                    { new Guid("2eab2085-d20b-4cc4-a85b-7567c9ce6ea9"), "LC", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "247", null, null, "Saint Lucia", 0 },
                    { new Guid("2eb9de76-3d99-43a5-b17d-ba2f0e08c64a"), "NI", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "228", null, null, "Nicaragua", 0 },
                    { new Guid("2eead3fb-8c57-4699-a48d-b9eb2a781d23"), "TF", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "TF", null, null, "French Southern Territories", 0 },
                    { new Guid("2f4455d6-efee-4959-8dfd-6f7db81faadd"), "NP", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "226", null, null, "Nepal", 0 },
                    { new Guid("2facb682-01d5-4798-bf0a-928bd471ecb3"), "CC", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "CC", null, null, "Cocos (keeling) islands", 0 },
                    { new Guid("332e0e9e-0182-47a0-b894-ade71da83708"), "BB", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "120", null, null, "Barbados", 0 },
                    { new Guid("33aeb885-ea5c-4343-8011-b1dccebdd65f"), "SA", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "110", null, null, "Ả Rập Saudi", 0 },
                    { new Guid("347a0e24-276d-4a54-b92b-4b88b60179af"), "GM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "163", null, null, "Gambia", 0 },
                    { new Guid("36299397-b100-420b-bd1b-3f18eda310fa"), "TD", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "270", null, null, "Tchad", 0 },
                    { new Guid("3671801a-1c88-4dc6-9e75-d766644c2af9"), "SR", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "264", null, null, "SuriCountryName", 0 },
                    { new Guid("36ddc306-adf0-4897-a200-6377ff0d9042"), "TT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "278", null, null, "Trinidad và Tobago", 0 },
                    { new Guid("39351753-1af5-4797-89e2-b97589db8d2e"), "AZ", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "114", null, null, "Cộng hòa Azerbaijan", 0 },
                    { new Guid("39ef7fcd-b539-46be-90a6-bc3f6d1524d8"), "KR", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "174", null, null, "Hàn Quốc", 0 },
                    { new Guid("3adb70b0-ae40-4ac0-8a27-15398cc79d49"), "GS", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "GS", null, null, "South georgia and the south sandwich islands", 0 },
                    { new Guid("3af1daa8-65e1-4502-823d-3c8530608104"), "MP", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "MP", null, null, "Northern mariana islands", 0 },
                    { new Guid("3d9d9ca5-3356-48b3-b518-eb806a6128ee"), "VU", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "289", null, null, "Vanuatu", 0 },
                    { new Guid("3dac050e-a2a6-469b-b0bb-def2e17544a5"), "GW", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "168", null, null, "Guinea-Bissau", 0 },
                    { new Guid("3de67d92-a46e-4113-bd12-2e89a48aa1f0"), "CN", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "279", null, null, "Trung Quốc", 0 },
                    { new Guid("3edffd99-5e14-4466-9f3e-a72ab48711d7"), "HM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "HM", null, null, "Heard and mc donald islands", 0 },
                    { new Guid("3f3e1d5e-ca7b-45ef-9e1e-f3c471e8894f"), "ST", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "251", null, null, "São Tomé và Príncipe", 0 },
                    { new Guid("426516a2-46e9-4103-8b44-22b4a30b21ae"), "LS", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "195", null, null, "Lesotho", 0 },
                    { new Guid("4452efd3-9727-4c5c-9cc9-76f7270c673d"), "CI", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "130", null, null, "Bờ Biển Ngà", 0 },
                    { new Guid("44ff82d4-3356-4f71-9aa2-dc5f161537f0"), "SY", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "266", null, null, "Syria", 0 },
                    { new Guid("45696681-b325-4d55-b4ea-56a920227907"), "SL", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "256", null, null, "Sierra Leone", 0 },
                    { new Guid("4589f414-2018-4196-a42a-68fa60b41dae"), "MZ", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "219", null, null, "Mozambique", 0 },
                    { new Guid("45a0ebe0-51be-423b-8885-7a7bf06e6f95"), "BA", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "127", null, null, "Bosna và Hercegovina", 0 },
                    { new Guid("46651a82-3d63-4a24-baff-9bb1ee8ac492"), "CF", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "280", null, null, "Trung Phi", 0 },
                    { new Guid("484be820-41ff-4911-94c6-2d2969764ac4"), "CD", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "145", null, null, "Cộng hòa Dân chủ Congo", 0 },
                    { new Guid("4b12f61e-5980-415f-a62b-b296753fd70d"), "PT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "129", null, null, "Bồ Đào Nha", 0 },
                    { new Guid("4b7309a1-de33-4f43-a2ff-3f11e0e5869b"), "SM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "250", null, null, "San Marino", 0 },
                    { new Guid("4bab2495-c861-47e7-82e6-1806fd87b767"), "IM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "IM", null, null, "Isle of man", 0 },
                    { new Guid("4dbc51c5-3faa-4e76-b0d5-a28df95c5c01"), "GT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "167", null, null, "Guatemala", 0 },
                    { new Guid("4dcd4bda-0da9-415d-8f7e-ecd5841ad250"), "ER", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "158", null, null, "Eritrea", 0 },
                    { new Guid("4e6e77af-56d6-4314-ac68-c39713511d70"), "IE", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "183", null, null, "Ireland", 0 },
                    { new Guid("50202b21-f7c0-42eb-89bd-4470e82f3943"), "JE", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "JE", null, null, "Jersey", 0 },
                    { new Guid("502c14cb-18ea-461f-9bc0-9591b056284c"), "DK", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "153", null, null, "Đan Mạch", 0 },
                    { new Guid("506ddd2c-4f81-4d6d-806c-4c9e605bab3f"), "KN", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "246", null, null, "Saint Kitts và Nevis", 0 },
                    { new Guid("509f7d40-e740-472f-8a7a-84b5a527eb96"), "KG", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "192", null, null, "Kyrgyzstan", 0 },
                    { new Guid("50c044c3-6cd1-46ad-b10a-e879291806f2"), "NU", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "NU", null, null, "Niue", 0 },
                    { new Guid("52595376-4b2b-4746-bb17-16f7ba234a33"), "MW", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "204", null, null, "Malawi", 0 },
                    { new Guid("5300fbb8-1d3b-48c2-b251-c9daab165b94"), "SH", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "SH", null, null, "St. Helena", 0 },
                    { new Guid("5351587c-9713-44c9-9088-9626d01300c8"), "TK", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "TK", null, null, "Tokelau", 0 },
                    { new Guid("539247ef-f9a9-4893-b250-2aa204a87640"), "VG", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "VG", null, null, "Virgin Islands (British)", 0 },
                    { new Guid("53b7d739-4b49-4a35-9d04-93520d79d105"), "TJ", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "267", null, null, "Tajikistan", 0 },
                    { new Guid("53fdbb96-c808-4474-83bc-084e422a8b95"), "BY", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "121", null, null, "Belarus", 0 },
                    { new Guid("54ca17f4-f6f7-4bcf-9809-8d45153c2271"), "LR", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "197", null, null, "Liberia", 0 },
                    { new Guid("561d896e-c3c5-4dfc-b13c-790aa25fbd5d"), "PA", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "236", null, null, "Panama", 0 },
                    { new Guid("5701a860-793e-4660-9302-005b27d4348e"), "AO", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "106", null, null, "Angola", 0 },
                    { new Guid("573dec77-5908-42b2-b1a5-8a5ee8407dee"), "GD", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "165", null, null, "Grenada", 0 },
                    { new Guid("57c01cf1-7f20-4a6c-bec9-bcc9a3a039fe"), "SG", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "257", null, null, "Singapore", 0 },
                    { new Guid("58357a87-d3a9-4ea4-82ea-eb7775f1c568"), "IR", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "181", null, null, "Iran", 0 },
                    { new Guid("58486abc-86a6-4bb8-a610-eb0e4bdf0b73"), "LT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "200", null, null, "Litva", 0 },
                    { new Guid("58776bc3-ee4b-44ae-ac9e-a501437bde2f"), "PF", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "PF", null, null, "French Polynesia", 0 },
                    { new Guid("58d12ab1-4946-45f9-bef5-354e5803f357"), "DO", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "152", null, null, "Cộng hòa Dominicana", 0 },
                    { new Guid("59e93599-98e9-44de-b9d1-bbbf17c599bf"), "ZA", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "223", null, null, "Nam Phi", 0 },
                    { new Guid("5a68453d-81d4-4417-a579-33d6a1c27ea6"), "PE", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "239", null, null, "Peru", 0 },
                    { new Guid("5b526a49-1694-4eb8-b602-4e150d12184d"), "MC", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "216", null, null, "Monaco", 0 },
                    { new Guid("5bd03273-5b23-4181-892c-397126e8da56"), "PK", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "234", null, null, "Pakistan", 0 },
                    { new Guid("5d60e969-8387-42e4-b866-31dfb209f433"), "Z3", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Z3", null, null, "England", 0 },
                    { new Guid("5dc567de-1249-4aaa-9d49-04dcd3501220"), "ES", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "269", null, null, "Tây Ban Nha", 0 },
                    { new Guid("5f4a7dfd-c3ed-4796-bde2-94199e595ef0"), "BV", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "BV", null, null, "Bouvet island", 0 },
                    { new Guid("62947f31-4a3e-441b-a9d2-9642ce61de2f"), "KI", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "189", null, null, "Kiribati", 0 },
                    { new Guid("62b0c6c0-4a45-4f33-b35e-d184d815518e"), "GH", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "164", null, null, "Ghana", 0 },
                    { new Guid("63c8621a-fc44-4abe-ba08-8d80520280cf"), "SC", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "255", null, null, "Seychelles", 0 },
                    { new Guid("6477d7a3-465e-4277-a4eb-ef09b13f5eca"), "MO", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "MO", null, null, "Macau", 0 },
                    { new Guid("66169c75-2aa7-409a-a7b9-d8cfe6ac80c0"), "LB", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "196", null, null, "Li ban", 0 },
                    { new Guid("66400b32-893a-489c-a5e1-180d55fb20d4"), "KE", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "188", null, null, "Kenya", 0 },
                    { new Guid("66533605-d826-4aec-9536-e4d30effefda"), "AL", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "103", null, null, "Albania", 0 },
                    { new Guid("665d03c6-346e-43d8-ad21-31492b4382aa"), "JO", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "186", null, null, "Jordan", 0 },
                    { new Guid("686b79de-db2f-4ccd-946c-1bef80cd503e"), "CA", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "140", null, null, "Canada", 0 },
                    { new Guid("6b24b562-1294-4537-a69a-26ac34c41521"), "AD", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "105", null, null, "Andorra", 0 },
                    { new Guid("6b8836aa-2476-4d82-98f1-0b7f56e66f7a"), "TL", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "TL", null, null, "Timor Leste", 0 },
                    { new Guid("6c408b50-b4be-4eca-a710-11a6d914cf4f"), "AT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "109", null, null, "Áo", 0 },
                    { new Guid("6d2d2371-8785-4a7b-94ba-84c804b2b0a2"), "RE", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "RE", null, null, "Reunion", 0 },
                    { new Guid("6d5a6761-432b-4bd2-9b04-5e01c421de23"), "NF", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "NF", null, null, "Norfolk Island", 0 },
                    { new Guid("716a0688-0378-4941-af8f-c11dc4c45ac2"), "TC", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "TC", null, null, "Turks and Caicos Islands", 0 },
                    { new Guid("720aaa71-3cc0-470f-b56c-472ac37a6574"), "BE", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "125", null, null, "Bỉ", 0 },
                    { new Guid("72d527d4-00df-4f9a-b0e1-e1fa84a4ba6d"), "SO", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "261", null, null, "Somalia", 0 },
                    { new Guid("74c266fd-7287-4525-aca3-6bb66ddcf61f"), "WS", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "249", null, null, "Samoa", 0 },
                    { new Guid("75de9dea-ef0f-4492-890a-f5af36cce7aa"), "CG", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "144", null, null, "Cộng hòa Congo", 0 },
                    { new Guid("76c42f0f-bfb2-4a11-b5a4-e854f74e72cd"), "BZ", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "122", null, null, "Belize", 0 },
                    { new Guid("77365013-80d7-44d5-bd8d-472542cac431"), "MQ", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "MQ", null, null, "Martinique", 0 },
                    { new Guid("788693d2-4ac9-4f85-94bf-13d021bc000d"), "PM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "PM", null, null, "St. Pierre and Miquelon", 0 },
                    { new Guid("78dcfd52-de7b-4c1d-9ded-0e5d3f7a8a35"), "MT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "208", null, null, "Malta", 0 },
                    { new Guid("79bc1ba0-a0f6-4065-9783-9e01ade32cde"), "PN", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "PN", null, null, "Pitcairn", 0 },
                    { new Guid("7a384197-d55e-44b8-b389-a65f17e74e1f"), "PH", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "242", null, null, "Philippines", 0 },
                    { new Guid("7af80a81-41e5-47de-abd3-7ce25f9c39b4"), "TM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "282", null, null, "Turkmenistan", 0 },
                    { new Guid("7afaefc0-9aa8-4ba7-98ae-618682a5be7f"), "KM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "143", null, null, "Comoros", 0 },
                    { new Guid("7b0c9a9c-e730-4b96-9372-e9ef8ab5339b"), "BM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "BM", null, null, "Bermuda", 0 },
                    { new Guid("7bea406c-221d-45dd-aca6-a2ceb90741aa"), "DM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "151", null, null, "Dominica", 0 },
                    { new Guid("7e27cb42-41fb-4b20-b26b-3c1ea9b4ff5c"), "SB", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "260", null, null, "Solomon", 0 },
                    { new Guid("7ef68b6d-2d6b-4688-95bc-d0fd79ffb6c5"), "CY", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "191", null, null, "Síp", 0 },
                    { new Guid("7f233816-fe94-4941-8125-b62c88410fa9"), "BD", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "119", null, null, "Bangladesh", 0 },
                    { new Guid("8562fd7f-49aa-46cf-bbc9-71f7460c6ba7"), "SZ", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "265", null, null, "Swaziland", 0 },
                    { new Guid("8592d87f-720b-48e7-82ee-e82d64cbf984"), "AG", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "108", null, null, "Antigua và Barbuda", 0 },
                    { new Guid("8764ee96-c950-44cf-a1f4-7636126c671b"), "BS", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "116", null, null, "Bahamas", 0 },
                    { new Guid("882c80ef-806d-4370-9fb1-f00a13a7a5c1"), "LV", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "194", null, null, "Latvia", 0 },
                    { new Guid("8a003437-323c-451c-b211-1886f79c25f1"), "MV", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "206", null, null, "Maldives", 0 },
                    { new Guid("8a6a8442-1533-4bba-9a05-ed707122573e"), "GR", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "178", null, null, "Hy Lạp", 0 },
                    { new Guid("8f800608-e254-418d-8163-78f71be4873f"), "EG", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "102", null, null, "Ai Cập", 0 },
                    { new Guid("8ff51ea0-476b-4dec-8736-70cc36ea1d2c"), "NO", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "225", null, null, "Na Uy", 0 },
                    { new Guid("90b2a6a0-bacd-4175-80e9-b8fde9233786"), "KW", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "190", null, null, "Kuwait", 0 },
                    { new Guid("90ef0553-8520-4d57-ae3b-112ebf28b313"), "ZW", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "295", null, null, "Zimbabwe", 0 },
                    { new Guid("92aea1da-5cf2-40fa-92a2-cce297949451"), "SI", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "259", null, null, "Slovenia", 0 },
                    { new Guid("92b69f82-f3e2-4ea9-9d4b-1763b1a75dec"), "MX", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "213", null, null, "Mexico", 0 },
                    { new Guid("93fc49be-bd23-41c3-8538-4b424a7806da"), "CV", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "CV", null, null, "Cape verde", 0 },
                    { new Guid("9412c9e0-c4fe-442f-8b13-ea064bf48703"), "LI", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "199", null, null, "Liechtenstein", 0 },
                    { new Guid("9601fc62-41b1-44af-af8e-8a03c91c96b8"), "JP", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "232", null, null, "Nhật Bản", 0 },
                    { new Guid("97bc234b-7d4c-4870-801b-74f1998741be"), "US", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "175", null, null, "Hoa Kỳ", 0 },
                    { new Guid("98062645-5015-4d8c-886e-3fb70c247ada"), "GP", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "GP", null, null, "Guadeloupe", 0 },
                    { new Guid("994cf06f-b833-4415-84e0-94f3847b6dd8"), "KY", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "KY", null, null, "Cayman islands", 0 },
                    { new Guid("99cfce62-6540-4525-97b8-9a2e62618e05"), "SJ", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "SJ", null, null, "Svalbard and Jan Mayen Islands", 0 },
                    { new Guid("9acb769e-d2de-479c-b66a-424ce710a036"), "NG", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "230", null, null, "Nigeria", 0 },
                    { new Guid("9d5769fe-b3ae-4697-9150-44674e8008ba"), "DE", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "155", null, null, "Đức", 0 },
                    { new Guid("9ded845f-06a1-4651-8903-bc46f7978c84"), "GE", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "GE", null, null, "Georgia", 0 },
                    { new Guid("9eb57842-f592-4080-affd-71b43f7d0517"), "AQ", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "AQ", null, null, "Antarctica", 0 },
                    { new Guid("9ee7b166-4c6f-4136-8928-c6246c3e76d5"), "UZ", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "288", null, null, "Uzbekistan", 0 },
                    { new Guid("a1080c01-e5bb-4e3f-8784-f0678f1eff58"), "DJ", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "150", null, null, "Djibouti", 0 },
                    { new Guid("a1ba5be8-fef9-470a-a5f7-efcf7fc900a4"), "ME", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "218", null, null, "Montenegro", 0 },
                    { new Guid("a1f120ed-4785-486e-b796-dd8cd569a415"), "VC", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "248", null, null, "Saint Vincent và Grenadines", 0 },
                    { new Guid("a30f588b-166d-4118-9d33-b8294e15ad44"), "SD", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "263", null, null, "Sudan", 0 },
                    { new Guid("a3597652-cc84-40ff-b143-208ee8473e93"), "EA", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "154", null, null, "Đông Timor", 0 },
                    { new Guid("a3c5c224-a013-4e23-8655-641a0a76b38a"), "PW", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "235", null, null, "Palau", 0 },
                    { new Guid("a695b824-cfc2-40a3-b5a1-35243a6e2116"), "YE", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "293", null, null, "Yemen", 0 },
                    { new Guid("a7a696de-3fd8-48c2-b87a-6464b222af87"), "VE", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "291", null, null, "Venezuela", 0 },
                    { new Guid("a8b38e56-d3ea-435f-907a-615ed7ced805"), "AF", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "101", null, null, "Afghanistan", 0 },
                    { new Guid("aa3d56b9-f398-4be1-b8ae-9f8563101b6e"), "IT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "292", null, null, "Ý", 0 },
                    { new Guid("aa4399ec-1ff3-4837-a68e-0df0720162cb"), "MR", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "211", null, null, "Mauritanie", 0 },
                    { new Guid("aa745539-b444-49d2-ad13-14149f8a1645"), "BO", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "126", null, null, "Bolivia", 0 },
                    { new Guid("ab16a3ed-00cd-4445-8e7c-770b1965232e"), "NL", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "173", null, null, "Hà Lan", 0 },
                    { new Guid("abdfeb5b-a4b8-4ab1-b6b8-83f7fb72ec23"), "EE", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "159", null, null, "Estonia", 0 },
                    { new Guid("ad4ef5f1-e823-4ed4-9ad5-cec4a2cae6af"), "UG", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "285", null, null, "Uganda", 0 },
                    { new Guid("af24512b-01ae-4420-96cb-62051ede96cc"), "UA", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "286", null, null, "Ukraina", 0 },
                    { new Guid("af3badc9-b6da-4eb0-8a42-ecf8dfd6ae19"), "AM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "112", null, null, "Armenia", 0 },
                    { new Guid("af9c2425-679e-4459-8c68-2d357f4f93e5"), "PY", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "238", null, null, "Paraguay", 0 },
                    { new Guid("affdf19e-5ed4-497a-97d0-0fc95a547785"), "LK", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "262", null, null, "Sri Lanka", 0 },
                    { new Guid("b16a509f-5c70-42b1-a05e-6d4426c721ca"), "IQ", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "182", null, null, "Iraq", 0 },
                    { new Guid("b171e933-4b7d-46f5-802a-14c5c9234ed7"), "ML", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "207", null, null, "Mali", 0 },
                    { new Guid("b1829e62-c3dd-4f65-8c41-fdbe26aedb93"), "MG", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "203", null, null, "Madagascar", 0 },
                    { new Guid("b4e019b1-042b-465c-baf9-60d525d9b85c"), "CK", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "CK", null, null, "Cook islands", 0 },
                    { new Guid("b6169a90-920f-425d-a275-82601862a220"), "SK", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "258", null, null, "Slovakia", 0 },
                    { new Guid("b83926c4-6963-4f82-97f7-dffa6e87ea7d"), "MK", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "202", null, null, "Macedonia", 0 },
                    { new Guid("b83be42b-cde9-4dc3-a838-d8197d2c678f"), "FO", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "FO", null, null, "Faroe islands", 0 },
                    { new Guid("ba7304bd-7e25-4731-a60f-10c13589c71a"), "ET", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "160", null, null, "Ethiopia", 0 },
                    { new Guid("ba947c48-36fb-420b-b2d9-663fe308b18c"), "TG", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "275", null, null, "Togo", 0 },
                    { new Guid("bcb96598-0e05-4316-86d3-80413326555a"), "MH", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "210", null, null, "Quần đảo Marshall", 0 },
                    { new Guid("be946a16-a1af-499c-9bd8-ca12a22fb69c"), "CU", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "149", null, null, "Cuba", 0 },
                    { new Guid("bf1bf333-4604-4974-838f-886100c006f3"), "TW", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "TW", null, null, "Đài Loan", 0 },
                    { new Guid("c4065df0-2539-4046-bb77-7d699a072734"), "FM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "214", null, null, "Micronesia", 0 },
                    { new Guid("c5c14db2-753f-4e28-88b5-3b9e502fa0c6"), "BN", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "132", null, null, "Brunei", 0 },
                    { new Guid("c6f6287f-39f6-4470-ad46-ac539eef3052"), "EC", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "156", null, null, "Ecuador", 0 },
                    { new Guid("c7f500b0-be15-4ab8-ae5c-1db430d19b8c"), "YT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "YT", null, null, "Mayotte", 0 },
                    { new Guid("c831fb16-910b-4939-804a-1052b8f8adc1"), "HT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "172", null, null, "Haiti", 0 },
                    { new Guid("c8766416-ed13-4631-a9c4-e89e782055c9"), "Z7", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Z7", null, null, "Wales", 0 },
                    { new Guid("cba207c9-9ee4-4a20-876b-ecb1160d0845"), "SN", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "253", null, null, "Sénégal", 0 },
                    { new Guid("cbf1c521-494b-4981-9dc9-b6a1b229c01d"), "JM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "185", null, null, "Jamaica", 0 },
                    { new Guid("cc2a4d3b-bae2-4602-9d23-4d4d2d918699"), "MD", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "215", null, null, "Moldova", 0 },
                    { new Guid("cdd52492-d981-4972-9f41-4b1774c002ee"), "GI", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "GI", null, null, "Gibraltar", 0 },
                    { new Guid("cf8c2ebc-2ed1-404c-875c-d2151d54ab9e"), "MM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "220", null, null, "Myanma", 0 },
                    { new Guid("d0357290-582a-47cd-984c-8815d38454be"), "Z5", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Z5", null, null, "Northern Ireland", 0 },
                    { new Guid("d1fef153-87bc-403a-9590-0ec4cc8d676e"), "PL", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "118", null, null, "Ba Lan", 0 },
                    { new Guid("d200b4b5-7435-41a9-be8b-b6a80e14120b"), "IO", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "IO", null, null, "British indian ocean territory", 0 },
                    { new Guid("d2ebac27-3463-40cb-9eb2-86e1da12a3ba"), "MS", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "MS", null, null, "Montserrat", 0 },
                    { new Guid("d34d65e5-253f-4324-9aee-f74045802e47"), "GG", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "GG", null, null, "Guernsey", 0 },
                    { new Guid("d3c10501-b94f-4a0e-b871-80d4b3d7bbbb"), "HK", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "HK", null, null, "Hong kong", 0 },
                    { new Guid("d50a063a-82ef-4b56-858e-1a8794b32878"), "HN", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "176", null, null, "Honduras", 0 },
                    { new Guid("d576474f-de6a-45fc-bd19-e18a2915f1a4"), "CR", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "146", null, null, "Costa Rica", 0 },
                    { new Guid("d892c6c0-bf86-4487-ab8b-5af35cc32a0c"), "GV", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "171", null, null, "Guyana", 0 },
                    { new Guid("d94b5935-e6d2-4aa7-b9f7-d332badacd8d"), "BT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "124", null, null, "Bhutan", 0 },
                    { new Guid("da333d92-e16c-4b49-b9d8-669df9032f82"), "FJ", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "161", null, null, "Fiji", 0 },
                    { new Guid("dd79ead4-6e12-4cb8-aff5-8f00d8bf9e99"), "SD", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "222", null, null, "Nam Sudan", 0 },
                    { new Guid("dd951a03-c803-4351-aac5-ed4ec9922bab"), "QA", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "243", null, null, "Qatar", 0 },
                    { new Guid("ddf4ecad-6f97-4bde-84fe-2b9dc51f0ffd"), "BW", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "128", null, null, "Botswana", 0 },
                    { new Guid("de0d7be8-8a87-4358-b93e-e809ab17f238"), "RO", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "244", null, null, "Romania", 0 },
                    { new Guid("e180ff8a-4e49-4edd-9168-21b372b8d9b7"), "BG", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "133", null, null, "Bulgaria", 0 },
                    { new Guid("e1fc9395-73b5-4fd6-8c31-37fef3a3e866"), "ZM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "294", null, null, "Zambia", 0 },
                    { new Guid("e369137c-1730-4809-88e4-e43031327233"), "BF", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "134", null, null, "Burkina Faso", 0 },
                    { new Guid("e3a2237c-9d57-462f-bad8-7a78856303c8"), "Id", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "180", null, null, "Indonesia", 0 },
                    { new Guid("e43c3f5c-e8d7-430a-9869-e61337bd4188"), "Z2", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Z2", null, null, "British Southern and Antarctic Territories", 0 },
                    { new Guid("e4acc3fd-7e2d-4927-b7e8-797cb8a29a86"), "GU", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "GU", null, null, "Guam", 0 },
                    { new Guid("e4c05566-0c8d-42a4-a2e9-ad4d6d33b35f"), "AI", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "AI", null, null, "Anguilla", 0 },
                    { new Guid("e5439053-279d-4094-852d-0c2edc6992ed"), "SV", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "157", null, null, "El Salvador", 0 },
                    { new Guid("e5837adb-d926-41f1-8434-73fed9db7504"), "AW", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "AW", null, null, "Aruba việt nam", 0 },
                    { new Guid("e6e7518f-73eb-4010-b0cf-6dcc5c8f8e01"), "DZ", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "104", null, null, "Algérie", 0 },
                    { new Guid("e9455b51-bd57-482f-a979-5ecf6c8c4afd"), "GB", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "107", null, null, "Vương quốc Liên hiệp Anh và Bắc Ireland", 0 },
                    { new Guid("edb5a6e1-b084-4e46-87ab-22d38da9cf0a"), "UY", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "287", null, null, "Uruguay", 0 },
                    { new Guid("edcecb3c-ffcb-451f-8e24-02a0bf6499ae"), "IN", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "115", null, null, "Cộng hòa Ấn Độ", 0 },
                    { new Guid("ee02aa87-f8dc-44ac-9ac9-830120f05656"), "TR", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "272", null, null, "Thổ Nhĩ Kỳ", 0 },
                    { new Guid("ee707e39-4195-426c-abf9-1ce21a771350"), "NA", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "221", null, null, "Namibia", 0 },
                    { new Guid("f034e368-335c-4a9f-a039-b7ea83f8a315"), "LU", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "201", null, null, "Luxembourg", 0 },
                    { new Guid("f07d3dde-aea1-4f0a-ba9d-310cda4fa6e9"), "TH", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "271", null, null, "Thái Lan", 0 },
                    { new Guid("f1218849-b5cf-43c8-b3c4-b1ff145f27fc"), "MU", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "212", null, null, "Mauritius", 0 },
                    { new Guid("f1c02c7d-3154-4e55-817c-1e24f6eef729"), "GA", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "162", null, null, "Gabon", 0 },
                    { new Guid("f21a86da-a1de-4023-93c9-3a23d315a8cd"), "RW", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "245", null, null, "Rwanda", 0 },
                    { new Guid("f36eb030-510e-4ca0-b7c4-a1c1ef656dd6"), "FK", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "FK", null, null, "Falkland islands (malvinas)", 0 },
                    { new Guid("f468cb27-57fb-4b75-b3b7-70bb33ca2705"), "KH", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "139", null, null, "Campuchia", 0 },
                    { new Guid("f5874f17-6c1e-4c07-b8bf-41b76546f6f0"), "CM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "138", null, null, "Cameroon", 0 },
                    { new Guid("f5f9c1ed-f4fb-4cff-aee3-2bcb0d8eed3e"), "NC", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "NC", null, null, "New Caledonia", 0 },
                    { new Guid("f5fdcb6c-e0c5-4a57-adca-e743ba60ccee"), "LY", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "198", null, null, "Libya", 0 },
                    { new Guid("f79baaf7-6191-4ba9-b38a-2f1b50d05598"), "TV", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "283", null, null, "Tuvalu", 0 },
                    { new Guid("f9375017-9897-4487-8916-c98d22fd05b9"), "GL", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "GL", null, null, "Greenland", 0 },
                    { new Guid("fb10ce71-e68a-4a70-bf7e-5edee9388d48"), "AE", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "137", null, null, "Các Tiểu Vương quốc Ả Rập Thống nhất", 0 },
                    { new Guid("fb67b422-6903-494e-945d-fa09f031b4f1"), "VI", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "VI", null, null, "Virgin Islands (U.S.)", 0 },
                    { new Guid("fc5a0c05-ebac-4906-8a9f-dddcdbcc0a9d"), "AU", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "284", null, null, "Úc", 0 },
                    { new Guid("fd0ac376-bf65-4bf8-9067-245691aa1827"), "HR", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "147", null, null, "Croatia", 0 },
                    { new Guid("fd21963c-7b5e-44a8-8d70-2edbda437946"), "MN", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "217", null, null, "Mông Cổ", 0 },
                    { new Guid("fd235817-1607-4f4c-83c7-ff5bd0012896"), "BJ", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "123", null, null, "Benin", 0 },
                    { new Guid("fd32d265-24dd-4073-a4b8-59e6358b59ed"), "AR", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "111", null, null, "Argentina", 0 },
                    { new Guid("fe657d37-7960-4bb3-8f15-81666fca928d"), "EH", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "EH", null, null, "Western sahara", 0 },
                    { new Guid("ff78779a-45cd-4076-8c61-442a9a3873f2"), "TZ", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "268", null, null, "Tanzania", 0 },
                    { new Guid("ffd3fabd-a5f1-4442-837b-d53b5d89272e"), "WF", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "WF", null, null, "Wallis and Futuna Islands", 0 }
                });

            migrationBuilder.InsertData(
                table: "SDeathCauses",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("4333ca55-4d7c-4be0-b9a2-2125624f0229"), "02", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Do tai biến điều trị", 2 },
                    { new Guid("4d5b5c50-6be0-434e-8baa-a528af4a58b5"), "09", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Khác", 9 },
                    { new Guid("c0a4d767-7ba9-4006-a0a9-020b6322c2ef"), "01", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Do bệnh", 1 }
                });

            migrationBuilder.InsertData(
                table: "SDeathWithins",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("66c3a43b-f9d0-4876-81e2-b13c5f188589"), "24H", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Trong 24h vào", 1 },
                    { new Guid("7693d6ec-cf0f-44c1-a9d7-fb997335ae10"), "72H", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Trong 72h vào", 3 },
                    { new Guid("8f2b1eeb-a4bd-4f84-b59c-98145c58b1ab"), "OTH", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Khác", 9 },
                    { new Guid("f91d8342-619c-435b-b51c-8b3d7f541222"), "48H", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Trong 48h vào", 2 }
                });

            migrationBuilder.InsertData(
                table: "SDepartmentTypes",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "LS", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Khoa lâm sàng", 1 },
                    { 2, "CLS", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Khoa cận lâm sàng", 2 },
                    { 3, "DUOC", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Khoa dược", 3 },
                    { 4, "KHTH", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Kế hoạch tổng hợp", 4 }
                });

            migrationBuilder.InsertData(
                table: "SEthnicities",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "MediCode", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170901"), "01", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "13", null, null, "Ba na", 1 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170902"), "02", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "49", null, null, "Bố y", 2 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170903"), "03", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "52", null, null, "Brâu", 3 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170904"), "04", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "17", null, null, "Chăm", 4 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170905"), "05", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "32", null, null, "Chơ ro", 5 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170906"), "06", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "36", null, null, "Chu ru", 6 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170907"), "07", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "44", null, null, "Chứt", 7 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170908"), "08", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "30", null, null, "Co", 8 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170909"), "09", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "48", null, null, "Cống", 9 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170910"), "10", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "16", null, null, "Cơ ho", 10 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170911"), "11", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "47", null, null, "Cờ lao", 11 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170912"), "12", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "9", null, null, "Dao", 12 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170913"), "13", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "12", null, null, "Ê đê", 13 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170914"), "14", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "10", null, null, "Gia rai", 14 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170915"), "15", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "25", null, null, "Giấy", 15 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170916"), "16", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "27", null, null, "Gié triêng", 16 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170917"), "17", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "8", null, null, "H mông", 17 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170918"), "18", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "19", null, null, "H rê", 18 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170919"), "19", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "35", null, null, "Hà nhì", 19 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170920"), "20", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "4", null, null, "Hoa", 20 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170921"), "21", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "26", null, null, "K tu", 21 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170922"), "22", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "33", null, null, "Kháng", 22 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170923"), "23", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "5", null, null, "Khơ me", 23 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170924"), "24", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "29", null, null, "Khơ mú", 24 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170925"), "25", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "1", null, null, "Kinh", 25 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170926"), "26", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "38", null, null, "La chí", 26 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170927"), "27", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "39", null, null, "La ha", 27 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170928"), "28", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "41", null, null, "La hù", 28 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170929"), "29", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "37", null, null, "Lào", 29 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170930"), "30", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "43", null, null, "Lô lô", 30 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170931"), "31", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "42", null, null, "Lự", 31 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170932"), "32", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "20", null, null, "M nông", 32 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170933"), "33", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "28", null, null, "Mạ", 33 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170934"), "34", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "45", null, null, "Mảng", 34 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170935"), "35", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "6", null, null, "Mường", 35 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170936"), "36", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "11", null, null, "Ngái", 36 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170937"), "37", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "7", null, null, "Nùng", 37 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170938"), "38", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "53", null, null, "Ơ đu", 38 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170939"), "39", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "46", null, null, "Pà thén", 39 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170940"), "40", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "40", null, null, "Phù lá", 40 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170941"), "41", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "51", null, null, "Pu péo", 41 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170942"), "42", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "21", null, null, "Rag lai", 42 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170943"), "43", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "54", null, null, "Rơ man", 43 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170944"), "44", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "15", null, null, "Sán chay", 44 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170945"), "45", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "18", null, null, "Sán dìu", 45 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170946"), "46", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "50", null, null, "Si la", 46 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170947"), "47", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "31", null, null, "Tà ôi", 47 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170948"), "48", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "2", null, null, "Tày", 48 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170949"), "49", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "3", null, null, "Thái", 49 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170950"), "50", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "24", null, null, "Thố", 50 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170951"), "51", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "23", null, null, "Vân kiều", 51 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170952"), "52", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "22", null, null, "X tiêng", 52 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170953"), "53", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "34", null, null, "Xinh mun", 53 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170954"), "54", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "14", null, null, "Xơ đăng", 54 },
                    { new Guid("9c01ca1a-fb5b-4620-a217-0046c3170999"), "99", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "55", null, null, "Nước ngoài", 99 }
                });

            migrationBuilder.InsertData(
                table: "SGenders",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("97ac7fd8-edfa-4243-97fc-98468f492df1"), "KXD", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Chưa xác định", 0 },
                    { new Guid("e9497984-d355-41af-b917-091500956be9"), "NU", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Nữ", 2 },
                    { new Guid("fc153433-bf89-4e95-8523-df3d8cec8676"), "NAM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "SHospitalLevels",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "HospitalLevelCode", "HospitalLevelName", "Inactive", "ModifiedBy", "ModifiedDate", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("45e9dce3-493f-47f0-96fe-752ff14a801b"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "HANG_2", "BV Hạng 2", false, null, null, 3 },
                    { new Guid("8b85b2a9-6831-4eb8-8524-58f2541244b8"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "HANG_3", "BV Hạng 3", false, null, null, 4 },
                    { new Guid("8f369537-85cf-493c-b525-dc84cdca4b85"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "DAC_BIET", "BV Hạng Đặc Biệt", false, null, null, 1 },
                    { new Guid("ae68eb6c-2e65-4561-80be-74fc4e1b7be2"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "HANG_4", "BV Hạng 4", false, null, null, 5 },
                    { new Guid("d8bdec49-23de-49f1-a7d6-4b29af7aa81c"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "HANG_1", "BV Hạng 1", false, null, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "SHospitalLines",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "HospitalLineCode", "HospitalLineName", "Inactive", "ModifiedBy", "ModifiedDate", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("07ea16b0-1b0b-4c5f-ae49-53a6be1a0e62"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "XA", "Tuyến xã", false, null, null, 4 },
                    { new Guid("38792889-79c3-4f8e-8ec5-cdd2648bdba3"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "PHONGKHAM", "Phòng khám", false, null, null, 5 },
                    { new Guid("684cd126-d475-4994-aaa6-858d45db2dd3"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "HUYEN", "Tuyến huyện", false, null, null, 3 },
                    { new Guid("690e1bfc-182a-4c34-be21-11e31f49dd9a"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TINH", "Tuyến tỉnh", false, null, null, 2 },
                    { new Guid("fbc4742b-ae6b-4a97-baff-769e89d14928"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TRUNG_UONG", "Tuyến trung ương", false, null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "SHospitalSpecialities",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "HospitalSpecialityCode", "HospitalSpecialityName", "Inactive", "ModifiedBy", "ModifiedDate", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("283089d3-57b6-40d6-9f86-e9221827850c"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "DA_LIEU", "Chuyên khoa da liễu", false, null, null, 10 },
                    { new Guid("2a5cb6d0-17ee-48b4-8875-3ea49c6f576d"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "UNG_BUOU", "Chuyên khoa ung bướu", false, null, null, 8 },
                    { new Guid("3ce1c62f-07ef-4818-b9c4-6e31f3d2141f"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BENHAN_BAN_CHAN", "Chuyên khoa đái tháo đường", false, null, null, 11 },
                    { new Guid("5460ecf9-2c35-496b-81cc-5f6e633027be"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TMH", "Chuyên khoa tai-mũi-họng", false, null, null, 7 },
                    { new Guid("566bcb28-6b75-4b90-b411-6f8ef2929329"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TIEM_CHUNG", "Tiêm chủng", false, null, null, 14 },
                    { new Guid("681eaa40-0fb5-41a2-b846-6f48a6954ab2"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "NHI", "Chuyên khoa nhi", false, null, null, 5 },
                    { new Guid("84ed0b08-fea7-4cd2-b4fc-d7e9c4079ab1"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "PK_NHO", "Phòng khám nhỏ", false, null, null, 12 },
                    { new Guid("8ba05025-994d-4b5e-8715-964b1f3a13a5"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SAN", "Chuyên khoa sản - phụ khoa", false, null, null, 3 },
                    { new Guid("abff0bdc-8bd4-4aa3-a391-c145cd042408"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "YHCT", "Y học cổ truyền", false, null, null, 15 },
                    { new Guid("b9d76b56-0eb7-4109-bbc4-c939f82229c7"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "RANG", "Chuyên khoa răng-hàm-mặt", false, null, null, 6 },
                    { new Guid("c3125b12-98d4-4e29-a3c5-35be114c726a"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LAM_DICH_VU", "Làm dịch vụ", false, null, null, 13 },
                    { new Guid("d7311f7a-6da4-471b-bd65-7734b246b49b"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "NGOAI_KHOA", "Chuyên khoa ngoai", false, null, null, 2 },
                    { new Guid("e54079cf-8c27-4869-8509-ee2fa37dd612"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "NOI_KHOA", "Chuyên khoa nội", false, null, null, 1 },
                    { new Guid("f46ab449-8cbc-4c26-a4e8-e342df9b8b8f"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "DONGY", "Chuyên khoa đông y", false, null, null, 9 },
                    { new Guid("fe219f91-5704-49e5-bfc7-f01e26f842bb"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MAT", "Chuyên khoa mắt", false, null, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "SInvoiceTypes",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "TT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Thu tiền", 1 },
                    { 2, "HT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Hoàn tiền", 2 },
                    { 3, "TU", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Tạm ứng", 3 },
                    { 4, "HU", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Hoàn ứng", 4 }
                });

            migrationBuilder.InsertData(
                table: "SItemGroups",
                columns: new[] { "Id", "Code", "CommodityType", "CreatedBy", "CreatedDate", "Inactive", "IsSystem", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("00be783e-d679-4f1c-9ae2-a4f4c79de0ef"), "TKSV", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Thuốc kháng sinh viên", 4 },
                    { new Guid("05a24915-0bed-4f61-b53d-b5e52482e44c"), "TK", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Thuốc khác", 21 },
                    { new Guid("077fe8b3-03d1-4c4c-b7be-5f7fb2015957"), "VTAC", 1, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Vật tư ấn chỉ", 27 },
                    { new Guid("18b82fb4-2ba8-4713-871f-3ba51c031b42"), "VTTH", 1, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Vật tư tiêu hoa", 23 },
                    { new Guid("25454ce7-bff0-4fd5-a47a-069554c1535a"), "VC", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Vaccine", 19 },
                    { new Guid("27988a81-eeab-41f0-a279-c774259ecdcf"), "VTCC", 1, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Vật tư công cụ - dụng cụ", 30 },
                    { new Guid("2a8c130b-8170-4776-b3bc-51eb9da01d35"), "VTNV", 1, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Vật tư nẹp vít", 26 },
                    { new Guid("2f5148cb-8adf-45ec-88ee-f84530cfa164"), "THTT", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Thuốc hướng tâm thần", 10 },
                    { new Guid("2fd41f93-ddb9-47dd-9833-4507ce71128c"), "TV", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Thuốc viên", 1 },
                    { new Guid("3144745c-477c-4ce2-9c33-a38eb2153057"), "SP", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Sinh phẩm", 18 },
                    { new Guid("31d26ca7-2b5f-4dfd-b961-f3609e6a0b69"), "TCO", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Nhóm thuốc corticoid", 12 },
                    { new Guid("35df3868-8db6-440d-809f-f4c345d804a7"), "TS", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Thuốc siro", 6 },
                    { new Guid("54eed868-2c02-46b3-acdf-e064a4ddb893"), "VTXH", 1, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Vật tư xã hội hóa", 31 },
                    { new Guid("58215bd0-ff85-45b4-90bb-4550f7e97838"), "VTHC", 1, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Vật tư hóa chất", 25 },
                    { new Guid("58291959-c2ca-45d6-b68d-ef81568fc163"), "VTXH", 1, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Vật tư khác", 32 },
                    { new Guid("6375b8a1-b6e7-4724-a1b4-8cc3acc98e43"), "KCVI", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Khoáng chất và Vitamin", 5 },
                    { new Guid("8590ae3d-351c-4438-bfe5-3f69dcf97349"), "TB", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Thuốc bột", 8 },
                    { new Guid("891ad741-f6dc-48ee-be99-3e678b5e8f6c"), "VTTT", 1, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Vật tư thay thế", 24 },
                    { new Guid("914ca65d-6579-4590-b963-fee8a743bae1"), "DC", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Dịch truyền", 3 },
                    { new Guid("9e144dff-29f6-47da-b7ed-b55abd1a2cd3"), "VTNT", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Vật tư nhà thuốc", 20 },
                    { new Guid("a15b74b8-1a38-42de-b958-a62bbd5d8a02"), "VTTB", 1, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Vật tư thiết bị y tế", 28 },
                    { new Guid("a28fb46e-e9b9-410e-9c31-d8ebfd22015c"), "TKTT", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Thuốc kê tự túc", 16 },
                    { new Guid("ae04abd7-d012-470d-9b8a-f38d9c5c94a8"), "TG", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Thuốc gói", 14 },
                    { new Guid("b5f03233-d733-4349-93df-db562b7d4376"), "THD", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Thuốc hỗn dịch", 6 },
                    { new Guid("c987b9d2-e599-49cc-99f3-d075d27cee7c"), "TDY", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Thuốc đông y", 5 },
                    { new Guid("c9c64187-bf8c-49f4-8b5b-2a04c9aafb5b"), "VTYT", 1, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Vật tư y tế", 22 },
                    { new Guid("cc48bb40-fbf0-4054-818c-eb49545aaeea"), "TDN", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Thuốc dùng ngoài", 7 },
                    { new Guid("cd5d7538-b1d2-448d-b6ff-c139c35f9dc7"), "TGTM", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Thuốc gây tê, mê", 13 },
                    { new Guid("d3ee2c41-ac9f-4356-8b76-a9b319929970"), "VTDC", 1, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Vật tư dụng cụ", 29 },
                    { new Guid("ddf105e8-6534-46e4-832b-598daa84c4d5"), "TGN", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Thuốc gây nghiện", 9 },
                    { new Guid("e47ab5de-9ea5-4075-8da5-7ae9f36538e2"), "TUT", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Thuốc ung thư", 15 },
                    { new Guid("e482e866-9243-49d8-8676-403377de353c"), "TKSO", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Thuốc kháng sinh ống", 11 },
                    { new Guid("ea57a262-6647-4e88-880c-82bc4227e916"), "TNM", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Thuốc nhỏ mắt", 17 },
                    { new Guid("ff9be71e-a958-4244-9df1-1582229c67d5"), "TU", 0, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, null, null, "Thuốc uống", 2 }
                });

            migrationBuilder.InsertData(
                table: "SItemLines",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("03bd1fdc-d2b8-4969-a029-5022ca68f31e"), "1.02", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Ngậm", 2 },
                    { new Guid("05a24915-0bed-4f61-b53d-b5e52482e44c"), "1.01", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Uống", 1 },
                    { new Guid("08f7b3c2-09da-4b4a-9c98-75c8562807ee"), "6.09", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Dung dịch", 44 },
                    { new Guid("0c8ba522-0e4b-40a0-9d93-936f5350853e"), "5.08", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Xịt họng", 38 },
                    { new Guid("0df82239-15dd-41ee-afc8-67cb51d5f3f6"), "5.03", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Bột hít", 33 },
                    { new Guid("13165217-8025-44e0-a92b-1f8318d56282"), "2.13", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Tiêm vào khối u", 18 },
                    { new Guid("1ef26d8f-57d7-423c-a8c6-e3a20a249b37"), "6.01", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Nhỏ mũi", 40 },
                    { new Guid("229172a9-7464-4216-8b11-4e587e4c280c"), "5.01", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Phun mù", 31 },
                    { new Guid("2bd555b2-74ae-4b3f-9d27-de30e10bf16f"), "3.01", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Bôi", 21 },
                    { new Guid("2f6e29a1-9a1f-44b0-8f9e-ea1c8716c23b"), "2.10", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Tiêm", 15 },
                    { new Guid("379c8a46-145d-4956-af5d-2d48d9d55087"), "6.03", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Tra mắt", 42 },
                    { new Guid("3df25942-afc9-4ed5-88b3-a0ff7b0ad968"), "4.02", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Đặt hậu môn", 26 },
                    { new Guid("41c24ffd-81f8-44f4-92f7-b3e5d418c8c7"), "2.15", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Tiêm truyền", 20 },
                    { new Guid("49783593-80ca-4a9f-8ff9-5d359307498c"), "4.03", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Thụt hậu môn - trực tràng", 27 },
                    { new Guid("5a807206-9aef-481d-87b6-88f464e6fd46"), "3.04", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Xịt ngoài da", 24 },
                    { new Guid("5d6b6689-0dc3-4f11-94ef-02d288cce18a"), "2.03", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Tiêm trong da", 8 },
                    { new Guid("5eada7db-843c-453b-8a44-3de2dacaa27b"), "1.05", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Ngậm dưới lưỡi", 5 },
                    { new Guid("5ef14843-323d-4fe9-a424-46ca3120fca9"), "2.02", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Tiêm dưới da", 7 },
                    { new Guid("60f3158e-73f2-453f-af90-072b6b25c644"), "3.05", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Dùng ngoài", 1 },
                    { new Guid("65ca8fd8-fb9b-4dea-9c0e-c9a3b6b8fbd8"), "2.11", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Tiêm động mạch khối u", 16 },
                    { new Guid("6cdf2301-9621-4f73-9c62-f48ab80245c8"), "5.02", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Dạng hít", 32 },
                    { new Guid("6edba7a9-20fe-49c0-9925-ba3b32ed32a0"), "2.14", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Tiêm truyền tĩnh mạch", 19 },
                    { new Guid("6f90ecfe-4ede-4241-918b-b18245208f56"), "2.01", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Tiêm bặp", 6 },
                    { new Guid("71edc6f8-3db6-4375-9005-c5328627fa28"), "3.03", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Dán trên da", 23 },
                    { new Guid("75017c25-2ad7-4cce-b206-38735fd3584d"), "3.02", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Xoa ngoài", 22 },
                    { new Guid("7990c54f-dc34-4a62-a8da-201d22c1069d"), "4.05", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Đặt tử cung", 29 },
                    { new Guid("7b3a86dc-9b0c-43f8-94a9-e4eec9916e30"), "5.09", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Thuốc mũi", 39 },
                    { new Guid("7d92b632-0ccf-4be5-a044-c3ee549fdb9f"), "6.04", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Nhỏ tai", 43 },
                    { new Guid("8d9cd0b1-2407-4cc3-9d94-314602e26508"), "5.07", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Xịt mũi", 37 },
                    { new Guid("8f65d7cf-bbd9-44f4-b556-20472aa4a5f0"), "4.06", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Thụt", 30 },
                    { new Guid("a26814e4-da59-4317-a297-5ca089ef2dad"), "1.04", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Đặt dưới lưỡi", 4 },
                    { new Guid("a29889f5-4943-4520-85fa-441c3ea9e979"), "1.03", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Nhai", 3 },
                    { new Guid("b12f310c-c12a-4f8f-a9bd-ddd38b4eebcf"), "5.06", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Đường hô hấp", 36 },
                    { new Guid("c0097373-f633-4bee-b670-2d2c35b5d172"), "2.12", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Tiêm vào khoang tự nhiên", 17 },
                    { new Guid("c6ffa735-8813-41ea-8984-5700dbee1ea7"), "2.09", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Tiêm vào các khoang của cơ thế", 14 },
                    { new Guid("ca37423b-25c7-4a84-a32d-8767bf14352b"), "5.04", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Xịt", 34 },
                    { new Guid("cae9f723-e795-48d5-9730-f19edceaa5b6"), "2.04", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Tiêm tĩnh mạch", 9 },
                    { new Guid("cb51640d-bd7e-4cba-b64d-191d4162efa4"), "4.01", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Đặt âm đạo", 25 },
                    { new Guid("d075055e-4ed2-4d37-82ae-c9c20cb4f08f"), "2.06", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Tiêm vào ổ khớp", 11 },
                    { new Guid("d36d932c-00db-451d-9a02-a401dbd89408"), "2.07", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Tiêm nội nhãn cầu", 12 },
                    { new Guid("d558492b-6628-40ca-aadf-5dda7701681a"), "4.04", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Đặt", 28 },
                    { new Guid("d81efde6-f750-4a66-adf3-a9092bb8ea9b"), "5.05", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Khí dung", 35 },
                    { new Guid("e485d3cc-5a96-48c9-9ed3-8725bb0136ef"), "6.02", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Nhỏ mắt", 41 },
                    { new Guid("e578f37b-9f1b-4098-8659-ac510ced491a"), "2.08", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Tiêm trong dịch kích của mắt", 13 },
                    { new Guid("febb52a6-15bc-4e28-bc84-e928b43b126b"), "2.05", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Tiêm truyền tĩnh mạch", 10 }
                });

            migrationBuilder.InsertData(
                table: "SLiveAreas",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "MediCode", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("0a14bae0-eeb9-48b3-b49e-b3bb5b1492b1"), "K3", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "K3", null, null, "K3", 3 },
                    { new Guid("b3eb4635-31ff-4e3f-b55f-a02150017bd7"), "K1", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "K1", null, null, "K1", 1 },
                    { new Guid("ddb7f2cd-be11-495b-80c0-51295e2066b9"), "K2", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "K2", null, null, "K2", 2 }
                });

            migrationBuilder.InsertData(
                table: "SMedicalRecordTypeGroups",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Inactive", "MedicalRecordTypeGroupCode", "MedicalRecordTypeGroupName", "ModifiedBy", "ModifiedDate", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "1", "Khám bệnh", null, null, 3 },
                    { 2, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "2", "Ngoại trú", null, null, 2 },
                    { 3, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "3", "Nội trú", null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "SOptionCategorys",
                columns: new[] { "Id", "Description", "Name", "SortOrder" },
                values: new object[] { 1, "", "Tùy chọn chung", 1 });

            migrationBuilder.InsertData(
                table: "SOrderTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "OrderTypeCode", "OrderTypeName", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "KB", "Phiếu Khám Bệnh", 0 },
                    { 2, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "KBKH", "Phiếu Khám Bệnh Kết Hợp", 0 },
                    { 3, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "DTKH", "Phiếu Điều Trị Kết Hợp", 0 },
                    { 4, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "XN", "Phiếu Xét Nghiệm", 0 },
                    { 5, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "HA", "Phiếu Chẩn Đoán Hình Ảnh", 0 },
                    { 6, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "PT", "Phẫu thuật", 0 },
                    { 7, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "CK", "Phiếu Chuyên khoa", 0 },
                    { 8, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "DV", "Dịch vụ khác", 0 },
                    { 9, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "TH", "Đơn Thuốc", 0 },
                    { 10, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "VT", "Phiếu Vật tư", 0 },
                    { 11, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "MAU", "Máu", 0 },
                    { 12, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "AV", "Áo vàng", 0 },
                    { 13, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "SA", "Suất ăn", 0 },
                    { 14, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "NC", "Nợ cũ", 0 },
                    { 15, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "TIEM_CHUNG", "Phiếu Tiêm Chủng", 0 },
                    { 16, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "HH", "Hàng hóa", 0 },
                    { 1004, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "TH_XN", "Thực hiện xét nghiệm", 0 },
                    { 1005, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "TH_HA", "Thực hiện chẩn đoán hình ảnh", 0 },
                    { 1006, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "TH_PT", "Thực hiện phẫu thuật", 0 },
                    { 1007, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "TH_CK", "Thực hiện chuyên khoa", 0 },
                    { 1012, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "TH_SA", "Tổng hợp suất ăn", 0 }
                });

            migrationBuilder.InsertData(
                table: "SPatientObjectTypes",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "BHYT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Bảo hiểm y tế", 1 },
                    { 2, "VP", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Viện phí", 2 },
                    { 3, "DV", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Dịch vụ", 3 },
                    { 4, "NG", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Người nước ngoài", 4 },
                    { 5, "MP", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Miễn phí", 5 }
                });

            migrationBuilder.InsertData(
                table: "SPaymentMethods",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("0b348363-c888-4c9a-b145-c3389fdcca37"), "TM/CK", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Tiền mặt hoặc chuyển khoản", 3 },
                    { new Guid("8bff9824-1df2-419e-88ab-e098a6fc4e7e"), "TM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Tiền mặt", 1 },
                    { new Guid("dd39afc0-1de0-4287-a126-4dada6788508"), "CK", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Chuyển khoản", 2 }
                });

            migrationBuilder.InsertData(
                table: "SProvinces",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "ProvinceCode", "ProvinceName" },
                values: new object[,]
                {
                    { new Guid("003360aa-6adc-4e1c-8da9-fd1d1665729d"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "17", "Tỉnh Hoà Bình" },
                    { new Guid("0729fb2e-ae19-41f3-b948-b0f0c51fbf99"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "46", "Tỉnh Thừa Thiên Huế" },
                    { new Guid("0b13943c-ead8-4e76-80b8-33b31828dd7a"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "77", "Tỉnh Bà Rịa - Vũng Tàu" },
                    { new Guid("0fdfd770-bee4-4dc4-9eb5-d86816bfc2bf"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "35", "Tỉnh Hà Nam" },
                    { new Guid("198417f7-e503-4435-bde2-7547487c943a"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "33", "Tỉnh Hưng Yên" },
                    { new Guid("1d8b3ff0-1bbd-4fa4-a4c8-1a4e2c394a55"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "34", "Tỉnh Thái Bình" },
                    { new Guid("2c03541e-db56-4bcb-8012-52b0f130ca09"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "67", "Tỉnh Đắk Nông" },
                    { new Guid("2d80dbcf-c7d5-4450-9847-e7e6f737f567"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "27", "Tỉnh Bắc Ninh" },
                    { new Guid("3035b967-95aa-46a5-be3f-b1f7bec1fd51"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "44", "Tỉnh Quảng Bình" },
                    { new Guid("3109e53a-812d-455e-a968-e86ff499d74d"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "49", "Tỉnh Quảng Nam" },
                    { new Guid("33d6ec24-75ee-402e-b8d2-3296e90ea336"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "60", "Tỉnh Bình Thuận" },
                    { new Guid("37d13fe4-1fd2-4268-bbae-4ab301f634c5"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "22", "Tỉnh Quảng Ninh" },
                    { new Guid("38e1ffeb-7572-40c7-a716-cd880eb8d1ce"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "08", "Tỉnh Tuyên Quang" },
                    { new Guid("395f3325-851f-41ee-b652-5002ce7cf547"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "68", "Tỉnh Lâm Đồng" },
                    { new Guid("3baaffd5-90a2-471f-8581-b5969184fcbe"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "62", "Tỉnh Kon Tum" },
                    { new Guid("3fd18cc5-7204-42a9-a940-c5cf3128518f"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "94", "Tỉnh Sóc Trăng" },
                    { new Guid("40064e04-52c1-460d-b3d3-04f4e991f82c"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "48", "Thành phố Đà Nẵng" },
                    { new Guid("46ddf496-df97-40b4-9b23-bfd17357abbe"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "31", "Thành phố Hải Phòng" },
                    { new Guid("4e6a7717-9e60-4bae-a2d4-d29dacd8af47"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "12", "Tỉnh Lai Châu" },
                    { new Guid("528fe36b-ac63-4f15-96f5-104ac221a155"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "10", "Tỉnh Lào Cai" },
                    { new Guid("52b17f24-a4a1-4cc6-88a0-c526ee8256c6"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "11", "Tỉnh Điện Biên" },
                    { new Guid("5329306e-8290-4ca4-b110-0678c20752e0"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "56", "Tỉnh Khánh Hòa" },
                    { new Guid("619d7aee-4e6a-4993-9d7a-c6e32958851f"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "92", "Thành phố Cần Thơ" },
                    { new Guid("64a15171-a037-45b4-a55d-08ee58ce687d"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "66", "Tỉnh Đắk Lắk" },
                    { new Guid("68d199cc-b739-4d61-b412-40d2242f374d"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "58", "Tỉnh Ninh Thuận" },
                    { new Guid("6f51a702-3c62-4a43-8042-9cf6e8bf3186"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "72", "Tỉnh Tây Ninh" },
                    { new Guid("702c3cf1-d0b3-4647-8d39-7549dd42f610"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "84", "Tỉnh Trà Vinh" },
                    { new Guid("7184c251-1c62-4b69-a63f-de49e85633f0"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "79", "Thành phố Hồ Chí Minh" },
                    { new Guid("72478add-ca26-4a9b-92bd-2b075006f36a"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "89", "Tỉnh An Giang" },
                    { new Guid("77e4b05d-6245-43ee-ba94-84faaece9018"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "15", "Tỉnh Yên Bái" },
                    { new Guid("7a3c3be6-fe62-42ab-9764-f8e62d7f5916"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "52", "Tỉnh Bình Định" },
                    { new Guid("7acbf3ec-7068-4007-a871-e0fee1ef28c5"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "26", "Tỉnh Vĩnh Phúc" },
                    { new Guid("839f0efb-168d-4110-a041-60b463ae48a1"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "70", "Tỉnh Bình Phước" },
                    { new Guid("889693ed-0453-4387-941b-d70dd4870dc5"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "01", "Thành phố Hà Nội" },
                    { new Guid("8eb57a8e-8281-41bb-a5ab-637dcac67177"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "14", "Tỉnh Sơn La" },
                    { new Guid("8ed43986-0586-4742-8f89-a673c9f63756"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "06", "Tỉnh Bắc Kạn" },
                    { new Guid("8f0f2a47-34e4-4af3-811a-4d9c1fbf1cae"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "45", "Tỉnh Quảng Trị" },
                    { new Guid("927f685b-f766-4bf8-93ed-ae7aabc4071c"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "19", "Tỉnh Thái Nguyên" },
                    { new Guid("94dab20e-c05d-4aa9-93e9-82e972792756"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "36", "Tỉnh Nam Định" },
                    { new Guid("952aa342-c05d-46d3-8ffe-6a22d7512dc2"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "83", "Tỉnh Bến Tre" },
                    { new Guid("9c2a8569-d860-459d-8c3a-49966ea0038d"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "24", "Tỉnh Bắc Giang" },
                    { new Guid("9d49b503-ac5f-47f3-aaa2-8d18853bfba6"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "80", "Tỉnh Long An" },
                    { new Guid("a1f48dda-f1a3-473a-b4f7-6843312303f4"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "25", "Tỉnh Phú Thọ" },
                    { new Guid("aee0f859-e3bd-41ae-be15-17060d5ad617"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "37", "Tỉnh Ninh Bình" },
                    { new Guid("af97b966-5b74-4580-a948-c8a9df0a5fba"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "51", "Tỉnh Quảng Ngãi" },
                    { new Guid("b2035ac5-5e24-4a18-8587-62e65fd64697"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "42", "Tỉnh Hà Tĩnh" },
                    { new Guid("b2cace92-0d42-4789-97c7-83ea3c3667c5"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "38", "Tỉnh Thanh Hóa" },
                    { new Guid("b42cba39-912a-4400-84a5-fe15eb71766e"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "64", "Tỉnh Gia Lai" },
                    { new Guid("b6bdda7d-b047-45a0-9d73-ffcb4e938e38"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "95", "Tỉnh Bạc Liêu" },
                    { new Guid("b6cf7563-f2be-4273-bcc7-58bb3cd4edec"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "75", "Tỉnh Đồng Nai" },
                    { new Guid("c16dbbe1-bea2-413b-9216-5b547deac9f5"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "20", "Tỉnh Lạng Sơn" },
                    { new Guid("c30f4992-257a-4abf-abb0-2ea4b36f247f"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "54", "Tỉnh Phú Yên" },
                    { new Guid("cd4eab40-92a3-4898-8a65-c67ccde721c0"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "93", "Tỉnh Hậu Giang" },
                    { new Guid("da06856d-9e6c-49f7-bbed-ca2a06ca81c1"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "91", "Tỉnh Kiên Giang" },
                    { new Guid("e5a4e82b-b29d-4b47-a563-82977ea93346"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "86", "Tỉnh Vĩnh Long" },
                    { new Guid("e7fe23cb-4304-4fb0-90a5-9ff4da5048aa"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "02", "Tỉnh Hà Giang" },
                    { new Guid("ec0b077d-3957-4089-85f8-c1d6742aab19"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "40", "Tỉnh Nghệ An" },
                    { new Guid("ed0a3763-3a96-46c5-8094-c47a4708e3cb"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "30", "Tỉnh Hải Dương" },
                    { new Guid("ef981a1e-0af1-4b7f-9fd7-42de078e7d97"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "74", "Tỉnh Bình Dương" },
                    { new Guid("f06e27bf-1470-4f7a-873f-f0dc77e405e4"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "82", "Tỉnh Tiền Giang" },
                    { new Guid("f2aac7ae-5a85-48fc-9166-d9ab6efb79ab"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "96", "Tỉnh Cà Mau" },
                    { new Guid("f5d76f98-2024-4c60-81ad-577359cb69d1"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "04", "Tỉnh Cao Bằng" },
                    { new Guid("fa11ad72-29b7-49f4-986d-fea0d53de210"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "87", "Tỉnh Đồng Tháp" }
                });

            migrationBuilder.InsertData(
                table: "SReceptionObjectTypes",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "01", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Khám bệnh", 1 },
                    { 2, "02", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Cấp cứu", 2 }
                });

            migrationBuilder.InsertData(
                table: "SRelationships",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "RelationshipCode", "RelationshipName", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f01"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "01", "Bố đẻ", 1 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f02"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "02", "Mẹ đẻ", 2 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f03"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "03", "Bố nuôi", 3 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f04"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "04", "Mẹ nuôi", 4 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f05"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "05", "Anh ruột", 5 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f06"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "06", "Chị ruột", 6 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f07"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "07", "Em ruột", 7 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f08"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "08", "Ông", 8 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f09"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "09", "Bà", 9 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f10"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "10", "Vợ", 10 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f11"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "11", "Chồng", 11 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f12"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "12", "Con", 12 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f13"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "13", "Cháu", 13 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f14"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "14", "Bác, chú, cậu", 14 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f15"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "15", "Bác, cô, dì", 15 },
                    { new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f99"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "99", "Khác", 99 }
                });

            migrationBuilder.InsertData(
                table: "SRightRouteTypes",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "01", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Đúng tuyến", 1 },
                    { 2, "02", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Đúng tuyến (giới thiệu)", 2 },
                    { 3, "03", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Đúng tuyến (giấy hẹn)", 3 },
                    { 4, "04", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Đúng tuyến (cấp cứu)", 4 },
                    { 5, "05", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Thông tuyến huyện", 5 },
                    { 6, "06", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Trái tuyến", 6 },
                    { 7, "07", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Trái tuyến (thông tuyến tỉnh)", 7 }
                });

            migrationBuilder.InsertData(
                table: "SRoomTypes",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "TD", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Tiếp đón", 1 },
                    { 2, "HC", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Hành chính", 2 },
                    { 3, "KHAM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Khám bệnh", 3 },
                    { 4, "NT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Nội trú", 4 },
                    { 5, "NgT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Ngoại trú", 5 },
                    { 6, "XN", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Xét nghiệm", 6 },
                    { 7, "CDHA", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Chẩn đoán hình ảnh", 7 },
                    { 8, "KHO-TONG", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Kho tổng", 8 },
                    { 9, "KHO-NgT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Kho thuốc ngoại trú", 9 },
                    { 10, "KHO-NT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Kho thuốc nội trú", 10 },
                    { 11, "TT-TH", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Tủ trực thuốc", 11 },
                    { 12, "KHO-VTYT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Kho vật tự y tế", 12 },
                    { 13, "KHO-MAU", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Kho máu", 13 },
                    { 14, "TT-VT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Tủ trực VTYT", 14 },
                    { 15, "QLT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Quản lý thuốc", 15 },
                    { 16, "QLVT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Quản lý vật tư", 16 }
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
                table: "STransferForms",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("32848bde-d01c-4d6b-b3a0-2104df2d801c"), "3", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "3. Chuyển người bệnh giữa các cơ sở khám bệnh, chữa bệnh trong cùng tuyến", 4 },
                    { new Guid("48cac582-b5f8-4f12-bb5b-5f35ca4fcac1"), "2", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "2. Chuyển người bệnh từ tuyến trên về tuyến dưới", 3 },
                    { new Guid("b882e676-a760-4468-a687-600770326aac"), "1b", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "1b: Chuyển người bệnh từ tuyến dưới lên tuyến trên không qua tuyến liền kề", 2 },
                    { new Guid("faf04fde-6dc1-4d6a-b5d8-b9000bb4f6bd"), "1a", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "1a: Chuyển người bệnh từ tuyến dưới lên tuyến trên liền kề", 1 }
                });

            migrationBuilder.InsertData(
                table: "STransferReasons",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("14f21e7e-54d2-40af-ab18-417468e1cadb"), "5", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Chuyển theo yêu cầu của người bệnh hoặc đại diện hợp pháp của người bệnh", 2 },
                    { new Guid("d6fa811f-0ea0-4303-bb6c-6bdcb7d18970"), "4", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Chuyển người bệnh đi các tuyến khi đủ điều kiện", 1 }
                });

            migrationBuilder.InsertData(
                table: "STreatmentEndTypes",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "IsForInPatient", "IsForOutPatient", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "CAPTOACHOVE", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, true, null, null, "Cấp toa cho về", 1 },
                    { 2, "HEN", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, true, null, null, "Hẹn", 2 },
                    { 3, "CHUYEN_PHONGKHAM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, true, null, null, "Chuyển phòng khám", 3 },
                    { 4, "DTRI_NGOAITRU", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, true, null, null, "Điều trị ngoại trú", 4 },
                    { 5, "NHAPVIEN", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, true, null, null, "Nhập viện", 5 },
                    { 6, "BOKHAM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, true, null, null, "Bỏ khám", 6 },
                    { 7, "CHUYEN_KHOA", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, true, null, null, "Chuyển khoa", 7 },
                    { 8, "RAVIEN", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, false, null, null, "Ra viện", 8 },
                    { 9, "XINVE", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, true, null, null, "Xin về", 9 },
                    { 10, "DUAVE", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, true, null, null, "Đưa về", 10 },
                    { 11, "TRONVIEN", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, false, null, null, "Trốn viện", 11 },
                    { 12, "CHUYEN_TUYEN", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, true, null, null, "Chuyển tuyến", 12 },
                    { 13, "TUVONG", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, true, null, null, "Tử vong", 13 },
                    { 99, "KHAC", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null, null, "Khác", 99 }
                });

            migrationBuilder.InsertData(
                table: "STreatmentResults",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "KHOI", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Khỏi", 1 },
                    { 2, "DO_GIAM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Đỡ, giảm", 2 },
                    { 3, "KHONGTHAYDOI", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Không thay đổi", 3 },
                    { 4, "NANGHON", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Nặng hơn", 4 },
                    { 5, "TUVONG", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Tử vong", 5 },
                    { 99, "KHAC", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "Khác", 6 }
                });

            migrationBuilder.InsertData(
                table: "SUnits",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Inactive", "ModifiedBy", "ModifiedDate", "Name", "SortOrder", "UnitType" },
                values: new object[,]
                {
                    { new Guid("0762aebf-cbb8-4102-b923-a30df490f75d"), "6", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Hộp", 6, 0 },
                    { new Guid("2198d1c0-57fa-453f-b605-9cef55929067"), "CUON", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Cuộn", 9, 0 },
                    { new Guid("3be8bc27-3940-451c-87f5-c062df716872"), "GAM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Gam", 12, 0 },
                    { new Guid("44ab6ffc-f1a9-47d0-90ab-9f09d767c286"), "ONG", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Ống", 5, 0 },
                    { new Guid("46ea45ff-ba5e-4f6f-bbc6-ebe65446efe8"), "GAM", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Gam", 20, 0 },
                    { new Guid("49793db4-c0ce-43c1-b439-eacd554fa06e"), "MET", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Met", 14, 0 },
                    { new Guid("6cc9258a-5f48-4c22-8cd6-61c0795f5405"), "LAN", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Lần", 2, 0 },
                    { new Guid("7a0fed4a-e62a-4e9f-8e92-7332127ca248"), "TUB", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Tub", 7, 0 },
                    { new Guid("8d7a7b33-f2ed-4b4b-a869-3ad32fd9d192"), "TUI", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Túi", 17, 0 },
                    { new Guid("9e12370e-b3ce-4862-8e7d-83d8f7ec56d1"), "LIT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Lít", 11, 0 },
                    { new Guid("9ff4f404-68bd-4780-99bc-1033227cbe3d"), "GOI", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Gói", 8, 0 },
                    { new Guid("a7e37e54-47b8-4716-b493-b657d4981e35"), "MINI", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Minimet", 15, 0 },
                    { new Guid("ae0ece26-bb4c-4b23-95cb-1a5d66114634"), "LO", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Lọ", 3, 0 },
                    { new Guid("bf42cbf7-b5ac-4503-b73d-d91f4051fa8f"), "ML", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "ml", 10, 0 },
                    { new Guid("c587599c-a6a6-454f-8e30-2a92dac6f588"), "VIEN", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Viên", 1, 0 },
                    { new Guid("cc8713c1-536a-4835-bd7e-187603566f95"), "KG", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Kg", 13, 0 },
                    { new Guid("da514a31-4dfc-4445-99bd-4ae29359ad48"), "TUYT", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Tuýt", 4, 0 },
                    { new Guid("e04b1f07-6f05-403e-ac09-b999cac0df3e"), "CAI", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Cái", 18, 0 },
                    { new Guid("e46826b4-76f9-4b32-84b3-b9730e732839"), "CHIEC", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Chiếc", 19, 0 },
                    { new Guid("fc7acf3a-2c10-4200-9448-c3180c0a4400"), "MIENG", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Miếng", 21, 0 },
                    { new Guid("fd96bad9-b254-4b37-8eb9-ada68fe7dada"), "CHAI", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Chai", 16, 0 }
                });

            migrationBuilder.InsertData(
                table: "SUsers",
                columns: new[] { "Id", "AccessFailedCount", "BranchId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Description", "Email", "FirstName", "FullName", "Inactive", "IsDeleted", "LastName", "LastWorkingBranchId", "Mobile", "ModifiedBy", "ModifiedDate", "Password", "Tel", "Username" },
                values: new object[,]
                {
                    { new Guid("3382be1c-2836-4246-99db-c4e1c781e868"), 0, null, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "administrator@gmail.com", null, "Admin", false, false, null, null, null, null, null, "79956B61E1B250869A6716CE37EFD6E6", null, "Administrator" },
                    { new Guid("49ba7fd4-2edb-4482-a419-00c81f023f5c"), 0, null, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "administrator@gmail.com", null, "ADMIN", false, false, null, null, null, null, null, "46F94C8DE14FB36680850768FF1B7F2A", null, "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "SDistricts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "DistrictCode", "DistrictName", "Inactive", "ModifiedBy", "ModifiedDate", "ProvinceId" },
                values: new object[,]
                {
                    { new Guid("010bc204-87e6-4e5f-9e82-79f5a0fc4d04"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "281", "Huyện Ứng Hòa", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("12518ef2-bc95-4a4d-8991-727782426ba8"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "275", "Huyện Quốc Oai", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("33a82ea4-7aeb-4d08-9ca9-2cb5f06adefb"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "002", "Quận Hoàn Kiếm", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("4d28238a-1d66-4dca-ae09-5104b16c5eef"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "278", "Huyện Thanh Oai", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("506d29ff-5cba-4d14-a341-375ed320e229"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "282", "Huyện Mỹ Đức", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d501"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "009", "Quận Thanh Xuân", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d502"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "016", "Huyện Sóc Sơn", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d503"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "017", "Huyện Đông Anh", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d504"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "018", "Huyện Gia Lâm", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d505"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "019", "Quận Nam Từ Liêm", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d506"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "020", "Huyện Thanh Trì", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d507"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "021", "Quận Bắc Từ Liêm", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d508"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "250", "Huyện Mê Linh", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d509"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "268", "Quận Hà Đông", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("5cf104df-c5e5-43bf-9aad-89eb8236092b"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "276", "Huyện Thạch Thất", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("7a19295e-ddfc-4aaa-bee3-edb7c6aeddf6"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "280", "Huyện Phú Xuyên", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("9f693f27-fe31-435b-be4e-0bb17dbaf8b7"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "277", "Huyện Chương Mỹ", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("a1f6effe-c174-4fc0-ad02-32b32ca51a20"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "279", "Huyện Thường Tín", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("c68ed451-7361-48a9-9f1e-9ad4c1b1bb58"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "008", "Quận Hoàng Mai", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("ecdeb90d-8bc9-43ee-a233-d1fdc543b11b"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "274", "Huyện Hoài Đức", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("ef1439e7-3dfa-40d3-a8de-a0da87140b45"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "269", "Thị xã Sơn Tây", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("ef1439e7-3dfa-40d3-a8de-a0da87140b46"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "271", "Huyện Ba Vì", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("ef1439e7-3dfa-40d3-a8de-a0da87140b47"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "272", "Huyện Phúc Thọ", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("ef1439e7-3dfa-40d3-a8de-a0da87140b48"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "273", "Huyện Đan Phượng", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("f3a6bcbb-8f93-49da-85e7-e9b07ed72980"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "007", "Quận Hai Bà Trưng", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("f3a6bcbb-8f93-49da-85e7-e9b07ed72986"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "003", "Quận Tây Hồ", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("f3a6bcbb-8f93-49da-85e7-e9b07ed72987"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "004", "Quận Long Biên", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("f3a6bcbb-8f93-49da-85e7-e9b07ed72988"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "005", "Quận Cầu Giấy", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("f3a6bcbb-8f93-49da-85e7-e9b07ed72989"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "006", "Quận Đống Đa", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") },
                    { new Guid("fdbacab7-ca1b-4765-b95d-84fac353a648"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "001", "Quận Ba Đình", false, null, null, new Guid("889693ed-0453-4387-941b-d70dd4870dc5") }
                });

            migrationBuilder.InsertData(
                table: "SMedicalRecordTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Inactive", "MedicalRecordTypeCode", "MedicalRecordTypeGroupId", "MedicalRecordTypeName", "ModifiedBy", "ModifiedDate", "SortOrder" },
                values: new object[,]
                {
                    { 100, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "100", 1, "Khám Bệnh", null, null, 1 },
                    { 200, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "200", 2, "Bệnh Án Ngoại Trú (Chung)", null, null, 1 },
                    { 201, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "201", 2, "Bệnh Án Ngoại Trú (Răng - Hàm - Mặt)", null, null, 2 },
                    { 202, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "202", 2, "Bệnh Án Ngoại Trú (Tai - Mũi - Họng)", null, null, 3 },
                    { 203, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "203", 2, "Bệnh Án Ngoại Trú (Y Học Cổ Truyền)", null, null, 4 },
                    { 204, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "204", 2, "Bệnh Án Ngoại Trú (Mắt)", null, null, 5 },
                    { 301, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "301", 3, "Bệnh Án Nội Khoa", null, null, 2 },
                    { 302, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "302", 3, "Bệnh Án Nhi Khoa", null, null, 3 },
                    { 303, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "303", 3, "Bệnh Án Truyền Nhiễm", null, null, 4 },
                    { 304, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "304", 3, "Bệnh Án Phụ Khoa", null, null, 5 },
                    { 305, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "305", 3, "Bệnh Án Sản Khoa", null, null, 6 },
                    { 306, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "306", 3, "Bệnh Án Sơ Sinh", null, null, 7 },
                    { 307, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "307", 3, "Bệnh Án Tâm Thần", null, null, 8 },
                    { 308, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "308", 3, "Bệnh Án Da Liễu", null, null, 9 },
                    { 309, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "309", 3, "Bệnh Án Điều Dưỡng - Phục Hồi Chức Năng", null, null, 10 },
                    { 310, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "310", 3, "Bệnh Án Huyết Học - Truyền Máu", null, null, 11 },
                    { 311, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "311", 3, "Bệnh Án Ngoại Khoa", null, null, 12 },
                    { 312, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "312", 3, "Bệnh Án Bỏng", null, null, 13 },
                    { 313, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "313", 3, "Bệnh Án Ung Bướu", null, null, 14 },
                    { 314, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "314", 3, "Bệnh Án Răng-Hàm-Mặt", null, null, 15 },
                    { 315, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "315", 3, "Bệnh Án Tai-Mũi-Họng", null, null, 16 },
                    { 316, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "316", 3, "Bệnh Án Mắt", null, null, 17 }
                });

            migrationBuilder.InsertData(
                table: "SWards",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "DistrictId", "Inactive", "ModifiedBy", "ModifiedDate", "SearchCode", "WardCode", "WardName" },
                values: new object[,]
                {
                    { new Guid("1594388c-53a1-4d34-81ab-40af3225936f"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("33a82ea4-7aeb-4d08-9ca9-2cb5f06adefb"), false, null, null, "HNHKTT", "00079", "Phường Tràng Tiền" },
                    { new Guid("18f45f82-55c4-4809-97cf-65f779b926d1"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("33a82ea4-7aeb-4d08-9ca9-2cb5f06adefb"), false, null, null, "HNHKHB", "00046", "Phường Hàng Buồm" },
                    { new Guid("18f45f82-55c4-4809-97cf-65f779b926d2"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("33a82ea4-7aeb-4d08-9ca9-2cb5f06adefb"), false, null, null, "HNHKHD", "00049", "Phường Hàng Đào" },
                    { new Guid("18f45f82-55c4-4809-97cf-65f779b926d3"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("33a82ea4-7aeb-4d08-9ca9-2cb5f06adefb"), false, null, null, "HNHKHB", "00052", "Phường Hàng Bồ" },
                    { new Guid("18f45f82-55c4-4809-97cf-65f779b926d4"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("33a82ea4-7aeb-4d08-9ca9-2cb5f06adefb"), false, null, null, "HNHKCD", "00055", "Phường Cửa Đông" },
                    { new Guid("18f45f82-55c4-4809-97cf-65f779b926d5"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("33a82ea4-7aeb-4d08-9ca9-2cb5f06adefb"), false, null, null, "HNHKLTT", "00058", "Phường Lý Thái Tổ" },
                    { new Guid("26cd9859-9e70-4a42-9979-b7d9027c96fd"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("33a82ea4-7aeb-4d08-9ca9-2cb5f06adefb"), false, null, null, "HNHKHB", "00076", "Phường Hàng Bông" },
                    { new Guid("4dd47dfb-9ca8-4ae6-b958-13edf873dc28"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("33a82ea4-7aeb-4d08-9ca9-2cb5f06adefb"), false, null, null, "HNHKDX", "00040", "Phường Đồng Xuân" },
                    { new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a51d"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("fdbacab7-ca1b-4765-b95d-84fac353a648"), false, null, null, "HNBDPX", "00001", "Phường Phúc Xá" },
                    { new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a52d"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("fdbacab7-ca1b-4765-b95d-84fac353a648"), false, null, null, "HNBDTB", "00004", "Phường Trúc Bạch" },
                    { new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a53d"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("fdbacab7-ca1b-4765-b95d-84fac353a648"), false, null, null, "HNBDVP", "00006", "Phường Vĩnh Phúc" },
                    { new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a54d"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("fdbacab7-ca1b-4765-b95d-84fac353a648"), false, null, null, "HNBDCV", "00007", "Phường Cống Vị" },
                    { new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a55d"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("fdbacab7-ca1b-4765-b95d-84fac353a648"), false, null, null, "HNBDLG", "00008", "Phường Liễu Giai" },
                    { new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a56d"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("fdbacab7-ca1b-4765-b95d-84fac353a648"), false, null, null, "HNBDNTT", "00010", "Phường Nguyễn Trung Trực" },
                    { new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a57d"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("fdbacab7-ca1b-4765-b95d-84fac353a648"), false, null, null, "HNBDQT", "00013", "Phường Quán Thánh" },
                    { new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a58d"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("fdbacab7-ca1b-4765-b95d-84fac353a648"), false, null, null, "HNBDNH", "00016", "Phường Ngọc Hà" },
                    { new Guid("622ff091-9851-46e8-9716-c355c21d4369"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("33a82ea4-7aeb-4d08-9ca9-2cb5f06adefb"), false, null, null, "HNHKHB", "00061", "Phường Hàng Bạc" },
                    { new Guid("7d55b7a9-b5ef-46e4-9a58-9b31e77108d8"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("33a82ea4-7aeb-4d08-9ca9-2cb5f06adefb"), false, null, null, "HNHKHG", "00064", "Phường Hàng Gai" },
                    { new Guid("803d0bc0-278b-42e1-b1bc-623e09920f17"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("33a82ea4-7aeb-4d08-9ca9-2cb5f06adefb"), false, null, null, "HNHKTHD", "00082", "Phường Trần Hưng Đạo" },
                    { new Guid("8a736b6f-0697-4486-9516-e30cc5c56b98"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("33a82ea4-7aeb-4d08-9ca9-2cb5f06adefb"), false, null, null, "HNHKHM", "00043", "Phường Hàng Mã" },
                    { new Guid("8b10a136-54e8-464b-b6a8-3fb6028bee0e"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("33a82ea4-7aeb-4d08-9ca9-2cb5f06adefb"), false, null, null, "HNHKPT", "00037", "Phường Phúc Tân" },
                    { new Guid("8d55eb0d-5c0a-40d1-9684-409868c6f393"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("33a82ea4-7aeb-4d08-9ca9-2cb5f06adefb"), false, null, null, "HNHKHT", "00070", "Phường Hàng Trống" },
                    { new Guid("8dbd4edd-06ce-40a6-a791-16cf3922523a"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("33a82ea4-7aeb-4d08-9ca9-2cb5f06adefb"), false, null, null, "HNHKHB", "00088", "Phường Hàng Bài" },
                    { new Guid("910fa544-1584-4dfc-b450-4d230f0847a9"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("fdbacab7-ca1b-4765-b95d-84fac353a648"), false, null, null, "HNBDGV", "00031", "Phường Giảng Võ" },
                    { new Guid("94ba5688-cf4d-454a-acc1-8fee10552375"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("33a82ea4-7aeb-4d08-9ca9-2cb5f06adefb"), false, null, null, "HNHKCN", "00073", "Phường Cửa Nam" },
                    { new Guid("b15d7c09-6930-43ce-bb4b-347740ed7096"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("33a82ea4-7aeb-4d08-9ca9-2cb5f06adefb"), false, null, null, "HNHKCG", "00067", "Phường Chương Dương" },
                    { new Guid("c95d5e0e-7244-4f7f-bc1b-640eba36c54e"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("fdbacab7-ca1b-4765-b95d-84fac353a648"), false, null, null, "HNBDDB", "00019", "Phường Điện Biên" },
                    { new Guid("d0a93335-cd08-46e6-8cef-8de70d076ed0"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("fdbacab7-ca1b-4765-b95d-84fac353a648"), false, null, null, "HNBDTC", "00034", "Phường Thành Công" },
                    { new Guid("d77c97d4-1e36-4c41-bd8f-f8e6209aeb0c"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("fdbacab7-ca1b-4765-b95d-84fac353a648"), false, null, null, "HNBDDC", "00022", "Phường Đội Cấn" },
                    { new Guid("e6b212d7-d687-4d63-82a5-18920238da18"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("fdbacab7-ca1b-4765-b95d-84fac353a648"), false, null, null, "HNBDNK", "00025", "Phường Ngọc Khánh" },
                    { new Guid("eb2e1424-b66c-41ae-9c5c-57757eb1224b"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("33a82ea4-7aeb-4d08-9ca9-2cb5f06adefb"), false, null, null, "HNHKPCT", "00085", "Phường Phan Chu Trinh" },
                    { new Guid("f44abb45-6010-4b0e-a442-5dafbeb4f40c"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("fdbacab7-ca1b-4765-b95d-84fac353a648"), false, null, null, "HNBDKM", "00028", "Phường Kim Mã" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DInOutStockItems_InOutStockId",
                table: "DInOutStockItems",
                column: "InOutStockId");

            migrationBuilder.CreateIndex(
                name: "IX_DInOutStockItems_ItemId",
                table: "DInOutStockItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_DInOutStockItems_ItemTypeId",
                table: "DInOutStockItems",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DInOutStocks_ApproverUserId",
                table: "DInOutStocks",
                column: "ApproverUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DInOutStocks_CreationUserId",
                table: "DInOutStocks",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DInOutStocks_ExpStockId",
                table: "DInOutStocks",
                column: "ExpStockId");

            migrationBuilder.CreateIndex(
                name: "IX_DInOutStocks_ImpStockId",
                table: "DInOutStocks",
                column: "ImpStockId");

            migrationBuilder.CreateIndex(
                name: "IX_DInOutStocks_InOutStockTypeId",
                table: "DInOutStocks",
                column: "InOutStockTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DInOutStocks_IsDeleted",
                table: "DInOutStocks",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_DInOutStocks_PatientId",
                table: "DInOutStocks",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_DInOutStocks_PatientRecordId",
                table: "DInOutStocks",
                column: "PatientRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_DInOutStocks_ReceiverUserId",
                table: "DInOutStocks",
                column: "ReceiverUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DInOutStocks_ReqDepartmentId",
                table: "DInOutStocks",
                column: "ReqDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DInOutStocks_ReqRoomId",
                table: "DInOutStocks",
                column: "ReqRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_DInOutStocks_StockExpUserId",
                table: "DInOutStocks",
                column: "StockExpUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DInOutStocks_StockImpUserId",
                table: "DInOutStocks",
                column: "StockImpUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DInOutStocks_SupplierId",
                table: "DInOutStocks",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_DItemStocks_IsDeleted",
                table: "DItemStocks",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_DItemStocks_ItemId",
                table: "DItemStocks",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_DItemStocks_StockId",
                table: "DItemStocks",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_DMedicalRecords_IsDeleted",
                table: "DMedicalRecords",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_DMedicalRecords_PatientId",
                table: "DMedicalRecords",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_DOrders_OrderTypeID",
                table: "DOrders",
                column: "OrderTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_DPatientRecords_BloodTypeId",
                table: "DPatientRecords",
                column: "BloodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DPatientRecords_BloodTypeRhId",
                table: "DPatientRecords",
                column: "BloodTypeRhId");

            migrationBuilder.CreateIndex(
                name: "IX_DPatientRecords_CareerId",
                table: "DPatientRecords",
                column: "CareerId");

            migrationBuilder.CreateIndex(
                name: "IX_DPatientRecords_CountryId",
                table: "DPatientRecords",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_DPatientRecords_DistrictId",
                table: "DPatientRecords",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_DPatientRecords_EthnicId",
                table: "DPatientRecords",
                column: "EthnicId");

            migrationBuilder.CreateIndex(
                name: "IX_DPatientRecords_GenderId",
                table: "DPatientRecords",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_DPatientRecords_IsDeleted",
                table: "DPatientRecords",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_DPatientRecords_ProvinceId",
                table: "DPatientRecords",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_DPatientRecords_ReligionId",
                table: "DPatientRecords",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_DPatientRecords_WardId",
                table: "DPatientRecords",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_DPatients_BloodRhTypeId",
                table: "DPatients",
                column: "BloodRhTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DPatients_BloodTypeId",
                table: "DPatients",
                column: "BloodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DPatients_CareerId",
                table: "DPatients",
                column: "CareerId");

            migrationBuilder.CreateIndex(
                name: "IX_DPatients_CountryId",
                table: "DPatients",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_DPatients_EthnicityId",
                table: "DPatients",
                column: "EthnicityId");

            migrationBuilder.CreateIndex(
                name: "IX_DPatients_GenderId",
                table: "DPatients",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_DPatients_IsDeleted",
                table: "DPatients",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_DPatients_PatientNumberId",
                table: "DPatients",
                column: "PatientNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_DPatients_ProvinceId",
                table: "DPatients",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_DPatients_ReligionId",
                table: "DPatients",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_DPatients_WardId",
                table: "DPatients",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_DServiceRequestDetailResults_ServiceId",
                table: "DServiceRequestDetailResults",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_DServiceRequestDetailResults_ServiceRequestDataId",
                table: "DServiceRequestDetailResults",
                column: "ServiceRequestDataId");

            migrationBuilder.CreateIndex(
                name: "IX_DServiceRequestDetailResults_ServiceRequestId",
                table: "DServiceRequestDetailResults",
                column: "ServiceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_DServiceRequestDetailResults_ServiceResultIndiceId",
                table: "DServiceRequestDetailResults",
                column: "ServiceResultIndiceId");

            migrationBuilder.CreateIndex(
                name: "IX_DServiceRequestDetails_IsDeleted",
                table: "DServiceRequestDetails",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_DServiceRequestDetails_ServiceId",
                table: "DServiceRequestDetails",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_DServiceRequestDetails_ServiceRequestId",
                table: "DServiceRequestDetails",
                column: "ServiceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_DServiceRequests_IsDeleted",
                table: "DServiceRequests",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_DepartmentId",
                table: "Machines",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_RoomId",
                table: "Machines",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_SBirthCertBooks_BranchId",
                table: "SBirthCertBooks",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_SBranchs_DirectorID",
                table: "SBranchs",
                column: "DirectorID",
                unique: true,
                filter: "[DirectorID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SBranchs_DistrictID",
                table: "SBranchs",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_SBranchs_HospitalLevelID",
                table: "SBranchs",
                column: "HospitalLevelID");

            migrationBuilder.CreateIndex(
                name: "IX_SBranchs_HospitalLineID",
                table: "SBranchs",
                column: "HospitalLineID");

            migrationBuilder.CreateIndex(
                name: "IX_SBranchs_HospitalSpecialityID",
                table: "SBranchs",
                column: "HospitalSpecialityID");

            migrationBuilder.CreateIndex(
                name: "IX_SBranchs_ProvinceID",
                table: "SBranchs",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_SBranchs_WardID",
                table: "SBranchs",
                column: "WardID");

            migrationBuilder.CreateIndex(
                name: "IX_SDeathCertBooks_BranchId",
                table: "SDeathCertBooks",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_SDepartments_BranchId",
                table: "SDepartments",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_SDepartments_ChiefId",
                table: "SDepartments",
                column: "ChiefId");

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
                name: "IX_SIcds_ChapterIcdId",
                table: "SIcds",
                column: "ChapterIcdId");

            migrationBuilder.CreateIndex(
                name: "IX_SItemPricePolicies_IsDeleted",
                table: "SItemPricePolicies",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_SItemPricePolicies_ItemId",
                table: "SItemPricePolicies",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SItemPricePolicies_PatientTypeId",
                table: "SItemPricePolicies",
                column: "PatientTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SItems_CountryId",
                table: "SItems",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_SItems_IsDeleted",
                table: "SItems",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_SItems_ItemLineId",
                table: "SItems",
                column: "ItemLineId");

            migrationBuilder.CreateIndex(
                name: "IX_SItems_ItemTypeId",
                table: "SItems",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SItems_UnitId",
                table: "SItems",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SItemTypes_CountryId",
                table: "SItemTypes",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_SItemTypes_IsDeleted",
                table: "SItemTypes",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_SItemTypes_ItemGroupId",
                table: "SItemTypes",
                column: "ItemGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_SItemTypes_ItemLineId",
                table: "SItemTypes",
                column: "ItemLineId");

            migrationBuilder.CreateIndex(
                name: "IX_SItemTypes_UnitId",
                table: "SItemTypes",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SMedicalRecordTypes_MedicalRecordTypeGroupId",
                table: "SMedicalRecordTypes",
                column: "MedicalRecordTypeGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_SOptions_BranchId",
                table: "SOptions",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_SOptions_OptionCategoryId",
                table: "SOptions",
                column: "OptionCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SOptions_UserId",
                table: "SOptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SReports_ReportCategoryId",
                table: "SReports",
                column: "ReportCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SRolePermissionMappings_PermissionId",
                table: "SRolePermissionMappings",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SRolePermissionMappings_RoleId",
                table: "SRolePermissionMappings",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SRooms_DepartmentId",
                table: "SRooms",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SRooms_RoomTypeId",
                table: "SRooms",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SServicePricePolicies_IsDeleted",
                table: "SServicePricePolicies",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_SServicePricePolicies_PatientTypeId",
                table: "SServicePricePolicies",
                column: "PatientTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SServicePricePolicies_ServiceId",
                table: "SServicePricePolicies",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SServiceResultIndices_ServiceId",
                table: "SServiceResultIndices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SServices_IsDeleted",
                table: "SServices",
                column: "IsDeleted");

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
                name: "IX_SSuppliers_IsDeleted",
                table: "SSuppliers",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_SUserRoleMappings_RoleId",
                table: "SUserRoleMappings",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SUserRoleMappings_UserId",
                table: "SUserRoleMappings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SUserRoomMappings_RoomId",
                table: "SUserRoomMappings",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_SUserRoomMappings_UserId",
                table: "SUserRoomMappings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SUsers_BranchId",
                table: "SUsers",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_SUsers_IsDeleted",
                table: "SUsers",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_SWards_DistrictId",
                table: "SWards",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_SYSTokens_UserId",
                table: "SYSTokens",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DInOutStockItems_DInOutStocks_InOutStockId",
                table: "DInOutStockItems",
                column: "InOutStockId",
                principalTable: "DInOutStocks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DInOutStocks_SDepartments_ReqDepartmentId",
                table: "DInOutStocks",
                column: "ReqDepartmentId",
                principalTable: "SDepartments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DInOutStocks_SRooms_ExpStockId",
                table: "DInOutStocks",
                column: "ExpStockId",
                principalTable: "SRooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DInOutStocks_SRooms_ImpStockId",
                table: "DInOutStocks",
                column: "ImpStockId",
                principalTable: "SRooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DInOutStocks_SRooms_ReqRoomId",
                table: "DInOutStocks",
                column: "ReqRoomId",
                principalTable: "SRooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DInOutStocks_SUsers_ApproverUserId",
                table: "DInOutStocks",
                column: "ApproverUserId",
                principalTable: "SUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DInOutStocks_SUsers_CreationUserId",
                table: "DInOutStocks",
                column: "CreationUserId",
                principalTable: "SUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DInOutStocks_SUsers_ReceiverUserId",
                table: "DInOutStocks",
                column: "ReceiverUserId",
                principalTable: "SUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DInOutStocks_SUsers_StockExpUserId",
                table: "DInOutStocks",
                column: "StockExpUserId",
                principalTable: "SUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DInOutStocks_SUsers_StockImpUserId",
                table: "DInOutStocks",
                column: "StockImpUserId",
                principalTable: "SUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DItemStocks_SRooms_StockId",
                table: "DItemStocks",
                column: "StockId",
                principalTable: "SRooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_SDepartments_DepartmentId",
                table: "Machines",
                column: "DepartmentId",
                principalTable: "SDepartments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_SRooms_RoomId",
                table: "Machines",
                column: "RoomId",
                principalTable: "SRooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SBirthCertBooks_SBranchs_BranchId",
                table: "SBirthCertBooks",
                column: "BranchId",
                principalTable: "SBranchs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SBranchs_SUsers_DirectorID",
                table: "SBranchs",
                column: "DirectorID",
                principalTable: "SUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SBranchs_SUsers_DirectorID",
                table: "SBranchs");

            migrationBuilder.DropTable(
                name: "DExaminations");

            migrationBuilder.DropTable(
                name: "DInOutStockItems");

            migrationBuilder.DropTable(
                name: "DInsurances");

            migrationBuilder.DropTable(
                name: "DInvoices");

            migrationBuilder.DropTable(
                name: "DItemStocks");

            migrationBuilder.DropTable(
                name: "DOrders");

            migrationBuilder.DropTable(
                name: "DPatientRecords");

            migrationBuilder.DropTable(
                name: "DServiceRequestDetailResults");

            migrationBuilder.DropTable(
                name: "Machines");

            migrationBuilder.DropTable(
                name: "SBirthCertBooks");

            migrationBuilder.DropTable(
                name: "SDbOptions");

            migrationBuilder.DropTable(
                name: "SDeathCauses");

            migrationBuilder.DropTable(
                name: "SDeathCertBooks");

            migrationBuilder.DropTable(
                name: "SDeathWithins");

            migrationBuilder.DropTable(
                name: "SExecutionRooms");

            migrationBuilder.DropTable(
                name: "SHospitals");

            migrationBuilder.DropTable(
                name: "SIcds");

            migrationBuilder.DropTable(
                name: "SInvoiceGroupBelongToUsers");

            migrationBuilder.DropTable(
                name: "SInvoiceGroups");

            migrationBuilder.DropTable(
                name: "SInvoiceTypes");

            migrationBuilder.DropTable(
                name: "SItemPricePolicies");

            migrationBuilder.DropTable(
                name: "SLiveAreas");

            migrationBuilder.DropTable(
                name: "SMedicalRecordTypes");

            migrationBuilder.DropTable(
                name: "SOptions");

            migrationBuilder.DropTable(
                name: "SPaymentMethods");

            migrationBuilder.DropTable(
                name: "SReceptionObjectTypes");

            migrationBuilder.DropTable(
                name: "SRelationships");

            migrationBuilder.DropTable(
                name: "SReports");

            migrationBuilder.DropTable(
                name: "SRightRouteTypes");

            migrationBuilder.DropTable(
                name: "SRolePermissionMappings");

            migrationBuilder.DropTable(
                name: "SServicePricePolicies");

            migrationBuilder.DropTable(
                name: "STransferForms");

            migrationBuilder.DropTable(
                name: "STransferReasons");

            migrationBuilder.DropTable(
                name: "STreatmentEndTypes");

            migrationBuilder.DropTable(
                name: "STreatmentResults");

            migrationBuilder.DropTable(
                name: "SUserRoleMappings");

            migrationBuilder.DropTable(
                name: "SUserRoomMappings");

            migrationBuilder.DropTable(
                name: "SYSTokens");

            migrationBuilder.DropTable(
                name: "DInOutStocks");

            migrationBuilder.DropTable(
                name: "SOrderTypes");

            migrationBuilder.DropTable(
                name: "DServiceRequestDetails");

            migrationBuilder.DropTable(
                name: "SServiceResultIndices");

            migrationBuilder.DropTable(
                name: "SChapterIcds");

            migrationBuilder.DropTable(
                name: "SItems");

            migrationBuilder.DropTable(
                name: "SMedicalRecordTypeGroups");

            migrationBuilder.DropTable(
                name: "SOptionCategorys");

            migrationBuilder.DropTable(
                name: "SReportCategories");

            migrationBuilder.DropTable(
                name: "SPermissions");

            migrationBuilder.DropTable(
                name: "SPatientObjectTypes");

            migrationBuilder.DropTable(
                name: "SRoles");

            migrationBuilder.DropTable(
                name: "DInOutStockTypes");

            migrationBuilder.DropTable(
                name: "DMedicalRecords");

            migrationBuilder.DropTable(
                name: "SRooms");

            migrationBuilder.DropTable(
                name: "SSuppliers");

            migrationBuilder.DropTable(
                name: "DServiceRequests");

            migrationBuilder.DropTable(
                name: "SServices");

            migrationBuilder.DropTable(
                name: "SItemTypes");

            migrationBuilder.DropTable(
                name: "DPatients");

            migrationBuilder.DropTable(
                name: "SDepartments");

            migrationBuilder.DropTable(
                name: "SRoomTypes");

            migrationBuilder.DropTable(
                name: "SServiceGroupHeIns");

            migrationBuilder.DropTable(
                name: "SServiceGroups");

            migrationBuilder.DropTable(
                name: "SSurgicalProcedureTypes");

            migrationBuilder.DropTable(
                name: "SItemGroups");

            migrationBuilder.DropTable(
                name: "SItemLines");

            migrationBuilder.DropTable(
                name: "SUnits");

            migrationBuilder.DropTable(
                name: "DPatientNumbers");

            migrationBuilder.DropTable(
                name: "SBloodRhTypes");

            migrationBuilder.DropTable(
                name: "SBloodTypes");

            migrationBuilder.DropTable(
                name: "SCareers");

            migrationBuilder.DropTable(
                name: "SCountries");

            migrationBuilder.DropTable(
                name: "SEthnicities");

            migrationBuilder.DropTable(
                name: "SGenders");

            migrationBuilder.DropTable(
                name: "SReligions");

            migrationBuilder.DropTable(
                name: "SDepartmentTypes");

            migrationBuilder.DropTable(
                name: "SUsers");

            migrationBuilder.DropTable(
                name: "SBranchs");

            migrationBuilder.DropTable(
                name: "SHospitalLevels");

            migrationBuilder.DropTable(
                name: "SHospitalLines");

            migrationBuilder.DropTable(
                name: "SHospitalSpecialities");

            migrationBuilder.DropTable(
                name: "SWards");

            migrationBuilder.DropTable(
                name: "SDistricts");

            migrationBuilder.DropTable(
                name: "SProvinces");
        }
    }
}
