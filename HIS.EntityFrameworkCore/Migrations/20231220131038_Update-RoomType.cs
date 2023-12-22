using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRoomType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoomTypeName",
                table: "DIC_RoomType",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "RoomTypeCode",
                table: "DIC_RoomType",
                newName: "Code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "DIC_RoomType",
                newName: "RoomTypeName");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "DIC_RoomType",
                newName: "RoomTypeCode");
        }
    }
}
