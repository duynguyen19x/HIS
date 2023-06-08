using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class AddSSurgicalProcedureTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SServices_SServiceGroup_ServiceGroupId",
                table: "SServices");

            migrationBuilder.DropForeignKey(
                name: "FK_SServices_SServiceUnits_ServiceUnitId",
                table: "SServices");

            migrationBuilder.RenameColumn(
                name: "SoftOrder",
                table: "SServiceUnits",
                newName: "SortOrder");

            migrationBuilder.RenameColumn(
                name: "SoftOrder",
                table: "SServiceTypes",
                newName: "SortOrder");

            migrationBuilder.RenameColumn(
                name: "SoftOrder",
                table: "SServices",
                newName: "SortOrder");

            migrationBuilder.AlterColumn<Guid>(
                name: "ServiceUnitId",
                table: "SServices",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ServiceGroupId",
                table: "SServices",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "HeInCode",
                table: "SServices",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeInName",
                table: "SServices",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SurgicalProcedureTypeId",
                table: "SServices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SSurgicalProcedureType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSurgicalProcedureType", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SSurgicalProcedureType",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "DeleteBy", "DeleteDate", "ModifiedBy", "ModifiedDate", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("486a97f2-f805-42ec-a864-83d0b18b589d"), "TT-3", null, null, null, null, null, null, "Thủ thuật loại 3", null },
                    { new Guid("57d67fcf-ab35-4578-bca0-6f94f7d67e76"), "TT-1", null, null, null, null, null, null, "Thủ thuật loại 1", null },
                    { new Guid("67121e45-e265-44ea-8b0d-a80295d7bd32"), "PT-1", null, null, null, null, null, null, "Phẫu thuật loại 1", null },
                    { new Guid("68512581-84bf-40f0-8d41-805e18d390d7"), "PT-2", null, null, null, null, null, null, "Phẫu thuật loại 2", null },
                    { new Guid("77ee1c9e-d884-43ba-93fd-2f8f2c6acad5"), "PT-3", null, null, null, null, null, null, "Phẫu thuật loại 3", null },
                    { new Guid("817ab6cb-fabc-43a9-9320-75eb16a584d6"), "PT-DB", null, null, null, null, null, null, "Phẫu thuật đặc biệt", null },
                    { new Guid("a6669aa3-af69-4d6a-b571-68c80e442de8"), "TT-DB", null, null, null, null, null, null, "Thủ thuật đặc biệt", null },
                    { new Guid("e2e38620-0e93-41ab-a654-25914a79a82a"), "TT-2", null, null, null, null, null, null, "Thủ thuật loại 2", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SServices_SurgicalProcedureTypeId",
                table: "SServices",
                column: "SurgicalProcedureTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SServices_SServiceGroup_ServiceGroupId",
                table: "SServices",
                column: "ServiceGroupId",
                principalTable: "SServiceGroup",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SServices_SServiceUnits_ServiceUnitId",
                table: "SServices",
                column: "ServiceUnitId",
                principalTable: "SServiceUnits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SServices_SSurgicalProcedureType_SurgicalProcedureTypeId",
                table: "SServices",
                column: "SurgicalProcedureTypeId",
                principalTable: "SSurgicalProcedureType",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SServices_SServiceGroup_ServiceGroupId",
                table: "SServices");

            migrationBuilder.DropForeignKey(
                name: "FK_SServices_SServiceUnits_ServiceUnitId",
                table: "SServices");

            migrationBuilder.DropForeignKey(
                name: "FK_SServices_SSurgicalProcedureType_SurgicalProcedureTypeId",
                table: "SServices");

            migrationBuilder.DropTable(
                name: "SSurgicalProcedureType");

            migrationBuilder.DropIndex(
                name: "IX_SServices_SurgicalProcedureTypeId",
                table: "SServices");

            migrationBuilder.DropColumn(
                name: "HeInCode",
                table: "SServices");

            migrationBuilder.DropColumn(
                name: "HeInName",
                table: "SServices");

            migrationBuilder.DropColumn(
                name: "SurgicalProcedureTypeId",
                table: "SServices");

            migrationBuilder.RenameColumn(
                name: "SortOrder",
                table: "SServiceUnits",
                newName: "SoftOrder");

            migrationBuilder.RenameColumn(
                name: "SortOrder",
                table: "SServiceTypes",
                newName: "SoftOrder");

            migrationBuilder.RenameColumn(
                name: "SortOrder",
                table: "SServices",
                newName: "SoftOrder");

            migrationBuilder.AlterColumn<Guid>(
                name: "ServiceUnitId",
                table: "SServices",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ServiceGroupId",
                table: "SServices",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SServices_SServiceGroup_ServiceGroupId",
                table: "SServices",
                column: "ServiceGroupId",
                principalTable: "SServiceGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SServices_SServiceUnits_ServiceUnitId",
                table: "SServices",
                column: "ServiceUnitId",
                principalTable: "SServiceUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
