using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class AddSPricePoliciesSServicePricePolicies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SPricePolicies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPricePolicies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SServicePricePolicies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PricePolicyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OldUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NewUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CeilingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ExecutionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SServicePricePolicies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SServicePricePolicies_SPricePolicies_PricePolicyId",
                        column: x => x.PricePolicyId,
                        principalTable: "SPricePolicies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SServicePricePolicies_SServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SServicePricePolicies_PricePolicyId",
                table: "SServicePricePolicies",
                column: "PricePolicyId");

            migrationBuilder.CreateIndex(
                name: "IX_SServicePricePolicies_ServiceId",
                table: "SServicePricePolicies",
                column: "ServiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SServicePricePolicies");

            migrationBuilder.DropTable(
                name: "SPricePolicies");
        }
    }
}
