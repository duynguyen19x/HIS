using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class AddUnit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SMaterials_SServiceUnits_UnitId",
                table: "SMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_SMaterialTypes_SServiceUnits_ServiceUnitId",
                table: "SMaterialTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_SMedicines_SServiceUnits_UnitId",
                table: "SMedicines");

            migrationBuilder.DropForeignKey(
                name: "FK_SMedicineTypes_SServiceUnits_UnitId",
                table: "SMedicineTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_SServices_SServiceUnits_UnitId",
                table: "SServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SServiceUnits",
                table: "SServiceUnits");

            migrationBuilder.RenameTable(
                name: "SServiceUnits",
                newName: "SUnits");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SUnits",
                table: "SUnits",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SMaterials_SUnits_UnitId",
                table: "SMaterials",
                column: "UnitId",
                principalTable: "SUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SMaterialTypes_SUnits_ServiceUnitId",
                table: "SMaterialTypes",
                column: "ServiceUnitId",
                principalTable: "SUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SMedicines_SUnits_UnitId",
                table: "SMedicines",
                column: "UnitId",
                principalTable: "SUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SMedicineTypes_SUnits_UnitId",
                table: "SMedicineTypes",
                column: "UnitId",
                principalTable: "SUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SServices_SUnits_UnitId",
                table: "SServices",
                column: "UnitId",
                principalTable: "SUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SMaterials_SUnits_UnitId",
                table: "SMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_SMaterialTypes_SUnits_ServiceUnitId",
                table: "SMaterialTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_SMedicines_SUnits_UnitId",
                table: "SMedicines");

            migrationBuilder.DropForeignKey(
                name: "FK_SMedicineTypes_SUnits_UnitId",
                table: "SMedicineTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_SServices_SUnits_UnitId",
                table: "SServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SUnits",
                table: "SUnits");

            migrationBuilder.RenameTable(
                name: "SUnits",
                newName: "SServiceUnits");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SServiceUnits",
                table: "SServiceUnits",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SMaterials_SServiceUnits_UnitId",
                table: "SMaterials",
                column: "UnitId",
                principalTable: "SServiceUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SMaterialTypes_SServiceUnits_ServiceUnitId",
                table: "SMaterialTypes",
                column: "ServiceUnitId",
                principalTable: "SServiceUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SMedicines_SServiceUnits_UnitId",
                table: "SMedicines",
                column: "UnitId",
                principalTable: "SServiceUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SMedicineTypes_SServiceUnits_UnitId",
                table: "SMedicineTypes",
                column: "UnitId",
                principalTable: "SServiceUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SServices_SServiceUnits_UnitId",
                table: "SServices",
                column: "UnitId",
                principalTable: "SServiceUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
