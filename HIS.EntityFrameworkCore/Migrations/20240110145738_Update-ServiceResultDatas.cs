using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateServiceResultDatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ServiceRequestId",
                table: "BUS_ServiceResultData",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TestingMachine",
                table: "BUS_ServiceResultData",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BUS_ServiceResultData_ServiceRequestId",
                table: "BUS_ServiceResultData",
                column: "ServiceRequestId");

            migrationBuilder.AddForeignKey(
                name: "FK_BUS_ServiceResultData_BUS_ServiceRequest_ServiceRequestId",
                table: "BUS_ServiceResultData",
                column: "ServiceRequestId",
                principalTable: "BUS_ServiceRequest",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BUS_ServiceResultData_BUS_ServiceRequest_ServiceRequestId",
                table: "BUS_ServiceResultData");

            migrationBuilder.DropIndex(
                name: "IX_BUS_ServiceResultData_ServiceRequestId",
                table: "BUS_ServiceResultData");

            migrationBuilder.DropColumn(
                name: "ServiceRequestId",
                table: "BUS_ServiceResultData");

            migrationBuilder.DropColumn(
                name: "TestingMachine",
                table: "BUS_ServiceResultData");
        }
    }
}
