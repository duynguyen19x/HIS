using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoomName",
                table: "DIC_Room",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "RoomCode",
                table: "DIC_Room",
                newName: "Code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "DIC_Room",
                newName: "RoomName");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "DIC_Room",
                newName: "RoomCode");
        }
    }
}
