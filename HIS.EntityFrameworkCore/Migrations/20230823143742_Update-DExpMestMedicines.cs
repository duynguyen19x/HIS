using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDExpMestMedicines : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DExpMestMedicines_DImpMests_ExpMestId",
                table: "DExpMestMedicines");

            migrationBuilder.AddForeignKey(
                name: "FK_DExpMestMedicines_DExpMests_ExpMestId",
                table: "DExpMestMedicines",
                column: "ExpMestId",
                principalTable: "DExpMests",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DExpMestMedicines_DExpMests_ExpMestId",
                table: "DExpMestMedicines");

            migrationBuilder.AddForeignKey(
                name: "FK_DExpMestMedicines_DImpMests_ExpMestId",
                table: "DExpMestMedicines",
                column: "ExpMestId",
                principalTable: "DImpMests",
                principalColumn: "Id");
        }
    }
}
