using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateServiceRequests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceRequestStatusId",
                table: "BUS_ServiceRequest");

            migrationBuilder.RenameColumn(
                name: "ServiceRequestUseDate",
                table: "BUS_ServiceRequest",
                newName: "UseTime");

            migrationBuilder.RenameColumn(
                name: "ServiceRequestDate",
                table: "BUS_ServiceRequest",
                newName: "RequestTime");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UseTime",
                table: "BUS_ServiceRequest",
                newName: "ServiceRequestUseDate");

            migrationBuilder.RenameColumn(
                name: "RequestTime",
                table: "BUS_ServiceRequest",
                newName: "ServiceRequestDate");

            migrationBuilder.AddColumn<int>(
                name: "ServiceRequestStatusId",
                table: "BUS_ServiceRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
