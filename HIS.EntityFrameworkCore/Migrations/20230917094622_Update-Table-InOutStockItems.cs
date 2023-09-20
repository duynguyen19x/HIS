using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableInOutStockItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ItemTypeId",
                table: "InOutStockItems",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InOutStockItems_ItemTypeId",
                table: "InOutStockItems",
                column: "ItemTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_InOutStockItems_ItemTypes_ItemTypeId",
                table: "InOutStockItems",
                column: "ItemTypeId",
                principalTable: "ItemTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InOutStockItems_ItemTypes_ItemTypeId",
                table: "InOutStockItems");

            migrationBuilder.DropIndex(
                name: "IX_InOutStockItems_ItemTypeId",
                table: "InOutStockItems");

            migrationBuilder.DropColumn(
                name: "ItemTypeId",
                table: "InOutStockItems");
        }
    }
}
