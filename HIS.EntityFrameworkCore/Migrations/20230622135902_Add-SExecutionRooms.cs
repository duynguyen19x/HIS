using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class AddSExecutionRooms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SExecutionRooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsMain = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SExecutionRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SExecutionRooms_SRooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "SRooms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SExecutionRooms_SServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "SServices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SExecutionRooms_RoomId",
                table: "SExecutionRooms",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_SExecutionRooms_ServiceId",
                table: "SExecutionRooms",
                column: "ServiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SExecutionRooms");
        }
    }
}
