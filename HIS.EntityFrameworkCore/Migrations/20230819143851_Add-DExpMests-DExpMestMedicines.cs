using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class AddDExpMestsDExpMestMedicines : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DImpMests_SUsers_StockReceiptUserId",
                table: "DImpMests");

            migrationBuilder.RenameColumn(
                name: "StockReceiptUserId",
                table: "DImpMests",
                newName: "StockImpUserId");

            migrationBuilder.RenameColumn(
                name: "StockReceiptTime",
                table: "DImpMests",
                newName: "StockImpTime");

            migrationBuilder.RenameIndex(
                name: "IX_DImpMests_StockReceiptUserId",
                table: "DImpMests",
                newName: "IX_DImpMests_StockImpUserId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "DImpMests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ExpMestId",
                table: "DImpMests",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExpMestStatus",
                table: "DImpMests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DExpMest",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImpMestStatus = table.Column<int>(type: "int", nullable: false),
                    ExpMestStatus = table.Column<int>(type: "int", nullable: false),
                    ImpStockId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExpStockId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImpExpMestTypeId = table.Column<int>(type: "int", nullable: true),
                    ApproverUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApproverTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StockExpTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StockExpUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReqRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReqDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TreatmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImpMestId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DImpMestId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DImpExpMestTypeId = table.Column<int>(type: "int", nullable: true),
                    ReceiverUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    STreatmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SPatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SSupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_DExpMest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DExpMest_DImpExpMestTypes_DImpExpMestTypeId",
                        column: x => x.DImpExpMestTypeId,
                        principalTable: "DImpExpMestTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DExpMest_DImpMests_DImpMestId",
                        column: x => x.DImpMestId,
                        principalTable: "DImpMests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DExpMest_SDepartments_ReqDepartmentId",
                        column: x => x.ReqDepartmentId,
                        principalTable: "SDepartments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DExpMest_SPatients_SPatientId",
                        column: x => x.SPatientId,
                        principalTable: "SPatients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DExpMest_SRooms_ExpStockId",
                        column: x => x.ExpStockId,
                        principalTable: "SRooms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DExpMest_SRooms_ImpStockId",
                        column: x => x.ImpStockId,
                        principalTable: "SRooms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DExpMest_SRooms_ReqRoomId",
                        column: x => x.ReqRoomId,
                        principalTable: "SRooms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DExpMest_SSuppliers_SSupplierId",
                        column: x => x.SSupplierId,
                        principalTable: "SSuppliers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DExpMest_STreatments_STreatmentId",
                        column: x => x.STreatmentId,
                        principalTable: "STreatments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DExpMest_SUsers_ApproverUserId",
                        column: x => x.ApproverUserId,
                        principalTable: "SUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DExpMest_SUsers_ReceiverUserId",
                        column: x => x.ReceiverUserId,
                        principalTable: "SUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DExpMest_SUsers_StockExpUserId",
                        column: x => x.StockExpUserId,
                        principalTable: "SUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DImpMests_ExpMestId",
                table: "DImpMests",
                column: "ExpMestId");

            migrationBuilder.CreateIndex(
                name: "IX_DExpMest_ApproverUserId",
                table: "DExpMest",
                column: "ApproverUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DExpMest_DImpExpMestTypeId",
                table: "DExpMest",
                column: "DImpExpMestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DExpMest_DImpMestId",
                table: "DExpMest",
                column: "DImpMestId");

            migrationBuilder.CreateIndex(
                name: "IX_DExpMest_ExpStockId",
                table: "DExpMest",
                column: "ExpStockId");

            migrationBuilder.CreateIndex(
                name: "IX_DExpMest_ImpStockId",
                table: "DExpMest",
                column: "ImpStockId");

            migrationBuilder.CreateIndex(
                name: "IX_DExpMest_ReceiverUserId",
                table: "DExpMest",
                column: "ReceiverUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DExpMest_ReqDepartmentId",
                table: "DExpMest",
                column: "ReqDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DExpMest_ReqRoomId",
                table: "DExpMest",
                column: "ReqRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_DExpMest_SPatientId",
                table: "DExpMest",
                column: "SPatientId");

            migrationBuilder.CreateIndex(
                name: "IX_DExpMest_SSupplierId",
                table: "DExpMest",
                column: "SSupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_DExpMest_StockExpUserId",
                table: "DExpMest",
                column: "StockExpUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DExpMest_STreatmentId",
                table: "DExpMest",
                column: "STreatmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_DImpMests_DExpMest_ExpMestId",
                table: "DImpMests",
                column: "ExpMestId",
                principalTable: "DExpMest",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DImpMests_SUsers_StockImpUserId",
                table: "DImpMests",
                column: "StockImpUserId",
                principalTable: "SUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DImpMests_DExpMest_ExpMestId",
                table: "DImpMests");

            migrationBuilder.DropForeignKey(
                name: "FK_DImpMests_SUsers_StockImpUserId",
                table: "DImpMests");

            migrationBuilder.DropTable(
                name: "DExpMest");

            migrationBuilder.DropIndex(
                name: "IX_DImpMests_ExpMestId",
                table: "DImpMests");

            migrationBuilder.DropColumn(
                name: "ExpMestId",
                table: "DImpMests");

            migrationBuilder.DropColumn(
                name: "ExpMestStatus",
                table: "DImpMests");

            migrationBuilder.RenameColumn(
                name: "StockImpUserId",
                table: "DImpMests",
                newName: "StockReceiptUserId");

            migrationBuilder.RenameColumn(
                name: "StockImpTime",
                table: "DImpMests",
                newName: "StockReceiptTime");

            migrationBuilder.RenameIndex(
                name: "IX_DImpMests_StockImpUserId",
                table: "DImpMests",
                newName: "IX_DImpMests_StockReceiptUserId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "DImpMests",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DImpMests_SUsers_StockReceiptUserId",
                table: "DImpMests",
                column: "StockReceiptUserId",
                principalTable: "SUsers",
                principalColumn: "Id");
        }
    }
}
