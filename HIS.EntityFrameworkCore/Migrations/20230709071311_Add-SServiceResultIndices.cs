using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class AddSServiceResultIndices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SServiceResultIndices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaleFrom = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MaleTo = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FemaleFrom = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FemaleTo = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    SServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SServiceResultIndices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SServiceResultIndices_SServices_SServiceId",
                        column: x => x.SServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SServiceResultIndices_SServiceId",
                table: "SServiceResultIndices",
                column: "SServiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SServiceResultIndices");
        }
    }
}
