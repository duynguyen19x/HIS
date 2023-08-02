using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTable04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProprietaryDrug",
                table: "SMedicineTypes",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegistrationNumber",
                table: "SMedicineTypes",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tutorial",
                table: "SMedicines",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PackagingSpecifications",
                table: "SMedicines",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SMedicines",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Manufacturer",
                table: "SMedicines",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Dosage",
                table: "SMedicines",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SMedicines",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "SMedicines",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lot",
                table: "SMedicines",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenderDecision",
                table: "SMedicines",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenderGroup",
                table: "SMedicines",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenderPackage",
                table: "SMedicines",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TenderYear",
                table: "SMedicines",
                type: "int",
                nullable: true);

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
                name: "SSuppliers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSupplier", x => x.Id);
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "SRoomTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "Name" },
                values: new object[] { "KHO-VTYT", "Kho vật tự y tế" });

            migrationBuilder.UpdateData(
                table: "SRoomTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "Name" },
                values: new object[] { "KHO-MAU", "Kho máu" });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DImMests");

            migrationBuilder.DropTable(
                name: "DImExMestTypes");

            migrationBuilder.DropTable(
                name: "SSupplier");

            migrationBuilder.DropColumn(
                name: "ProprietaryDrug",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "RegistrationNumber",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "SMedicines");

            migrationBuilder.DropColumn(
                name: "Lot",
                table: "SMedicines");

            migrationBuilder.DropColumn(
                name: "TenderDecision",
                table: "SMedicines");

            migrationBuilder.DropColumn(
                name: "TenderGroup",
                table: "SMedicines");

            migrationBuilder.DropColumn(
                name: "TenderPackage",
                table: "SMedicines");

            migrationBuilder.DropColumn(
                name: "TenderYear",
                table: "SMedicines");

            migrationBuilder.AlterColumn<string>(
                name: "Tutorial",
                table: "SMedicines",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PackagingSpecifications",
                table: "SMedicines",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SMedicines",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Manufacturer",
                table: "SMedicines",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Dosage",
                table: "SMedicines",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SMedicines",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "SRoomTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "Name" },
                values: new object[] { "KHO-VT-NgT", "Kho VTYT ngoại trú" });

            migrationBuilder.UpdateData(
                table: "SRoomTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "Name" },
                values: new object[] { "KHO-VT-NT", "Kho VTYT nội trú" });
        }
    }
}
