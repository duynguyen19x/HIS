using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DServiceRequestDetailResults_DServiceRequestDetails_ServiceRequestDataId",
                table: "DServiceRequestDetailResults");

            migrationBuilder.RenameColumn(
                name: "ServiceRequestDataId",
                table: "DServiceRequestDetailResults",
                newName: "ServiceRequestDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_DServiceRequestDetailResults_ServiceRequestDataId",
                table: "DServiceRequestDetailResults",
                newName: "IX_DServiceRequestDetailResults_ServiceRequestDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_DServiceRequestDetailResults_DServiceRequestDetails_ServiceRequestDetailId",
                table: "DServiceRequestDetailResults",
                column: "ServiceRequestDetailId",
                principalTable: "DServiceRequestDetails",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DServiceRequestDetailResults_DServiceRequestDetails_ServiceRequestDetailId",
                table: "DServiceRequestDetailResults");

            migrationBuilder.RenameColumn(
                name: "ServiceRequestDetailId",
                table: "DServiceRequestDetailResults",
                newName: "ServiceRequestDataId");

            migrationBuilder.RenameIndex(
                name: "IX_DServiceRequestDetailResults_ServiceRequestDetailId",
                table: "DServiceRequestDetailResults",
                newName: "IX_DServiceRequestDetailResults_ServiceRequestDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_DServiceRequestDetailResults_DServiceRequestDetails_ServiceRequestDataId",
                table: "DServiceRequestDetailResults",
                column: "ServiceRequestDataId",
                principalTable: "DServiceRequestDetails",
                principalColumn: "Id");
        }
    }
}
