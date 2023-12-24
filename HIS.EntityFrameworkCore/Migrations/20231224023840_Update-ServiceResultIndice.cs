using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateServiceResultIndice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ServiceRequestDataId",
                table: "BUS_ServiceResultData",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DIC_DeathCause",
                keyColumn: "Id",
                keyValue: new Guid("4333ca55-4d7c-4be0-b9a2-2125624f0229"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 24, 9, 38, 38, 827, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.CreateIndex(
                name: "IX_BUS_ServiceResultData_ServiceRequestDataId",
                table: "BUS_ServiceResultData",
                column: "ServiceRequestDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_BUS_ServiceResultData_BUS_ServiceRequestData_ServiceRequestDataId",
                table: "BUS_ServiceResultData",
                column: "ServiceRequestDataId",
                principalTable: "BUS_ServiceRequestData",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BUS_ServiceResultData_BUS_ServiceRequestData_ServiceRequestDataId",
                table: "BUS_ServiceResultData");

            migrationBuilder.DropIndex(
                name: "IX_BUS_ServiceResultData_ServiceRequestDataId",
                table: "BUS_ServiceResultData");

            migrationBuilder.DropColumn(
                name: "ServiceRequestDataId",
                table: "BUS_ServiceResultData");
        }
    }
}
