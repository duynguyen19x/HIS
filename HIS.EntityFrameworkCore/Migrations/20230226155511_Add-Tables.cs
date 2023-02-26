using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class AddTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SBranchs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SBranchs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SGenders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SGenders", x => x.Id);
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
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SServiceUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceUnitCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ServiceUnitName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SoftOrder = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SServiceUnits", x => x.Id);
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
                    District = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WardsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SUsers_SGenders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "SGenders",
                        principalColumn: "Id");
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
                    ServiceTypeCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ServiceTypeName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SoftOrder = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ServiceUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                name: "SServices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ServiceName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SoftOrder = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ServiceTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SServices_SServiceTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "SServiceTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SServices_SServiceUnits_ServiceUnitId",
                        column: x => x.ServiceUnitId,
                        principalTable: "SServiceUnits",
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
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    SMedicineGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("0fb94c3b-e780-4e2f-853f-878acf24f90d"), 1, "Nam" },
                    { new Guid("1a0c6582-97ba-4e60-9edd-368c77805439"), 0, "Chưa xác định" },
                    { new Guid("de234cd4-f0b9-43c4-bd04-4e79cd0f71e5"), 2, "Nữ" }
                });

            migrationBuilder.InsertData(
                table: "SUsers",
                columns: new[] { "Id", "Address", "District", "Dob", "Email", "FirstName", "GenderId", "LastName", "Password", "PhoneNumber", "ProvinceId", "Status", "UseType", "UserName", "WardsId" },
                values: new object[] { new Guid("6f179bc3-8f0e-4515-8c75-4dab88cb3e00"), null, null, null, "administrator@gmail.com", "Admin", null, "Administrator", "79956B61E1B250869A6716CE37EFD6E6", null, null, 1, 0, "Administrator", null });

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
                name: "IX_SRolePermissionBranchs_BranchId",
                table: "SRolePermissionBranchs",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_SRolePermissionBranchs_PermissionId",
                table: "SRolePermissionBranchs",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SServices_ServiceTypeId",
                table: "SServices",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SServices_ServiceUnitId",
                table: "SServices",
                column: "ServiceUnitId");

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
                name: "IX_SUsers_GenderId",
                table: "SUsers",
                column: "GenderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SMaterials");

            migrationBuilder.DropTable(
                name: "SMedicines");

            migrationBuilder.DropTable(
                name: "SRolePermissionBranchs");

            migrationBuilder.DropTable(
                name: "STokens");

            migrationBuilder.DropTable(
                name: "SUserRoles");

            migrationBuilder.DropTable(
                name: "SMaterialTypes");

            migrationBuilder.DropTable(
                name: "SMedicineTypes");

            migrationBuilder.DropTable(
                name: "SBranchs");

            migrationBuilder.DropTable(
                name: "SPermissions");

            migrationBuilder.DropTable(
                name: "SRoles");

            migrationBuilder.DropTable(
                name: "SUsers");

            migrationBuilder.DropTable(
                name: "SMedicineGroups");

            migrationBuilder.DropTable(
                name: "SMedicineLines");

            migrationBuilder.DropTable(
                name: "SServices");

            migrationBuilder.DropTable(
                name: "SGenders");

            migrationBuilder.DropTable(
                name: "SServiceTypes");

            migrationBuilder.DropTable(
                name: "SServiceUnits");
        }
    }
}
