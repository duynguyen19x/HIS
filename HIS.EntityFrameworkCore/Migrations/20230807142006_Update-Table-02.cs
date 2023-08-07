using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTable02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ImpUserId",
                table: "DImpMests",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StockReceiptTime",
                table: "DImpMests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StockReceiptUserId",
                table: "DImpMests",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DImpMests_StockReceiptUserId",
                table: "DImpMests",
                column: "StockReceiptUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DImpMests_SUsers_StockReceiptUserId",
                table: "DImpMests",
                column: "StockReceiptUserId",
                principalTable: "SUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DImpMests_SUsers_StockReceiptUserId",
                table: "DImpMests");

            migrationBuilder.DropIndex(
                name: "IX_DImpMests_StockReceiptUserId",
                table: "DImpMests");

            migrationBuilder.DropColumn(
                name: "ImpUserId",
                table: "DImpMests");

            migrationBuilder.DropColumn(
                name: "StockReceiptTime",
                table: "DImpMests");

            migrationBuilder.DropColumn(
                name: "StockReceiptUserId",
                table: "DImpMests");
        }
    }
}
