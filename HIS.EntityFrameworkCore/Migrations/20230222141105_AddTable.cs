﻿using System;
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

            migrationBuilder.InsertData(
                table: "SGenders",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("2b7e4605-4b1a-4a04-9ac4-b31b3e114b96"), 0, "Chưa xác định" },
                    { new Guid("b8fd66fd-43b5-47e6-8a42-868b7a71374a"), 1, "Nam" },
                    { new Guid("d95360fe-5c42-4b2e-bfc3-f3b0a4b1ec3b"), 2, "Nữ" }
                });

            migrationBuilder.InsertData(
                table: "SUsers",
                columns: new[] { "Id", "Address", "District", "Dob", "Email", "FirstName", "GenderId", "LastName", "Password", "PhoneNumber", "ProvinceId", "Status", "UseType", "UserName", "WardsId" },
                values: new object[] { new Guid("9ad5bcc0-28d4-4adc-9829-e8504c8f742c"), null, null, null, "administrator@gmail.com", "Admin", null, "Administrator", "79956B61E1B250869A6716CE37EFD6E6", null, null, 1, 0, "Administrator", null });

            migrationBuilder.CreateIndex(
                name: "IX_SRolePermissionBranchs_BranchId",
                table: "SRolePermissionBranchs",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_SRolePermissionBranchs_PermissionId",
                table: "SRolePermissionBranchs",
                column: "PermissionId");

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
                name: "SRolePermissionBranchs");

            migrationBuilder.DropTable(
                name: "STokens");

            migrationBuilder.DropTable(
                name: "SUserRoles");

            migrationBuilder.DropTable(
                name: "SBranchs");

            migrationBuilder.DropTable(
                name: "SPermissions");

            migrationBuilder.DropTable(
                name: "SRoles");

            migrationBuilder.DropTable(
                name: "SUsers");

            migrationBuilder.DropTable(
                name: "SGenders");
        }
    }
}
