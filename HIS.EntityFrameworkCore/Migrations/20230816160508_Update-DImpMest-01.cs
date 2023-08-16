using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDImpMest01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DImpMests_SRooms_ExStockId",
                table: "DImpMests");

            migrationBuilder.DropForeignKey(
                name: "FK_DImpMests_SRooms_ImStockId",
                table: "DImpMests");

            migrationBuilder.RenameColumn(
                name: "ImStockId",
                table: "DImpMests",
                newName: "ImpStockId");

            migrationBuilder.RenameColumn(
                name: "ExStockId",
                table: "DImpMests",
                newName: "ExpStockId");

            migrationBuilder.RenameIndex(
                name: "IX_DImpMests_ImStockId",
                table: "DImpMests",
                newName: "IX_DImpMests_ImpStockId");

            migrationBuilder.RenameIndex(
                name: "IX_DImpMests_ExStockId",
                table: "DImpMests",
                newName: "IX_DImpMests_ExpStockId");

            migrationBuilder.AddForeignKey(
                name: "FK_DImpMests_SRooms_ExpStockId",
                table: "DImpMests",
                column: "ExpStockId",
                principalTable: "SRooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DImpMests_SRooms_ImpStockId",
                table: "DImpMests",
                column: "ImpStockId",
                principalTable: "SRooms",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DImpMests_SRooms_ExpStockId",
                table: "DImpMests");

            migrationBuilder.DropForeignKey(
                name: "FK_DImpMests_SRooms_ImpStockId",
                table: "DImpMests");

            migrationBuilder.RenameColumn(
                name: "ImpStockId",
                table: "DImpMests",
                newName: "ImStockId");

            migrationBuilder.RenameColumn(
                name: "ExpStockId",
                table: "DImpMests",
                newName: "ExStockId");

            migrationBuilder.RenameIndex(
                name: "IX_DImpMests_ImpStockId",
                table: "DImpMests",
                newName: "IX_DImpMests_ImStockId");

            migrationBuilder.RenameIndex(
                name: "IX_DImpMests_ExpStockId",
                table: "DImpMests",
                newName: "IX_DImpMests_ExStockId");

            migrationBuilder.AddForeignKey(
                name: "FK_DImpMests_SRooms_ExStockId",
                table: "DImpMests",
                column: "ExStockId",
                principalTable: "SRooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DImpMests_SRooms_ImStockId",
                table: "DImpMests",
                column: "ImStockId",
                principalTable: "SRooms",
                principalColumn: "Id");
        }
    }
}
