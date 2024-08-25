using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "SampleReceivingTime",
                table: "DServiceRequests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SampleReceivingUserId",
                table: "DServiceRequests",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SampleTime",
                table: "DServiceRequests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SampleUserId",
                table: "DServiceRequests",
                type: "uniqueidentifier",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SampleReceivingTime",
                table: "DServiceRequests");

            migrationBuilder.DropColumn(
                name: "SampleReceivingUserId",
                table: "DServiceRequests");

            migrationBuilder.DropColumn(
                name: "SampleTime",
                table: "DServiceRequests");

            migrationBuilder.DropColumn(
                name: "SampleUserId",
                table: "DServiceRequests");
        }
    }
}
