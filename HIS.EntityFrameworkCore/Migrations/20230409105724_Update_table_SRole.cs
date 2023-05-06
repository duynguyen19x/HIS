using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Update_table_SRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WardsId",
                table: "SUsers",
                newName: "WardId");

            migrationBuilder.RenameColumn(
                name: "District",
                table: "SUsers",
                newName: "DistrictId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SRoles",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "SRoles",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Inactive",
                table: "SRoles",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "SRoles");

            migrationBuilder.DropColumn(
                name: "Inactive",
                table: "SRoles");

            migrationBuilder.RenameColumn(
                name: "WardId",
                table: "SUsers",
                newName: "WardsId");

            migrationBuilder.RenameColumn(
                name: "DistrictId",
                table: "SUsers",
                newName: "District");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SRoles",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);
        }
    }
}
