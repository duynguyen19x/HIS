using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Alter_table_SGender : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SUsers_SGenders_GenderId",
                table: "SUsers");

            migrationBuilder.DropIndex(
                name: "IX_SUsers_GenderId",
                table: "SUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SGenders",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "SGenders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "SGenders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "SGenders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SGenders",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Inactive",
                table: "SGenders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedBy",
                table: "SGenders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "SGenders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "SGenders",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SGenders");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "SGenders");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "SGenders");

            migrationBuilder.DropColumn(
                name: "Inactive",
                table: "SGenders");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "SGenders");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "SGenders");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "SGenders");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SGenders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<int>(
                name: "Code",
                table: "SGenders",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateIndex(
                name: "IX_SUsers_GenderId",
                table: "SUsers",
                column: "GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_SUsers_SGenders_GenderId",
                table: "SUsers",
                column: "GenderId",
                principalTable: "SGenders",
                principalColumn: "Id");
        }
    }
}
