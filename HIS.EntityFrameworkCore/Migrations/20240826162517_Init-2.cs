using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BranchName",
                table: "SBranchs",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "BranchCode",
                table: "SBranchs",
                newName: "Code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "SBranchs",
                newName: "BranchName");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "SBranchs",
                newName: "BranchCode");
        }
    }
}
