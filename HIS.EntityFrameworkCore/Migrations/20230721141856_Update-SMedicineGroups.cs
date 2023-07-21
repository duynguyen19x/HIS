using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSMedicineGroups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Inactive",
                table: "SMedicineGroups",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.RenameColumn(
               name: "SoftOrder",
               table: "SMedicineGroups",
               newName: "SortOrder");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Inactive",
                table: "SMedicineGroups");

            migrationBuilder.RenameColumn(
               name: "SortOrder",
               table: "SMedicineGroups",
               newName: "SoftOrder");
        }
    }
}
