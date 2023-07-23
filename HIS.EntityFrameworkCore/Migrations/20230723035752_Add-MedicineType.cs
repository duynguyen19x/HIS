using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class AddMedicineType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InternalPrice",
                table: "SMedicines");

            migrationBuilder.RenameColumn(
                name: "SoftOrder",
                table: "SMedicineTypes",
                newName: "SortOrder");

            migrationBuilder.RenameColumn(
                name: "SoftOrder",
                table: "SMedicines",
                newName: "SortOrder");

            migrationBuilder.AddColumn<string>(
                name: "HeInCode",
                table: "SMedicineTypes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ImpPrice",
                table: "SMedicineTypes",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ImpVatRate",
                table: "SMedicineTypes",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TaxRate",
                table: "SMedicineTypes",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeInCode",
                table: "SMedicines",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSystem",
                table: "SMedicineGroups",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "SMedicineGroups",
                columns: new[] { "Id", "Code", "Inactive", "IsSystem", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("00be783e-d679-4f1c-9ae2-a4f4c79de0ef"), "TH-DY", false, true, "Thuốc đông y", 4 },
                    { new Guid("2fd41f93-ddb9-47dd-9833-4507ce71128c"), "TH-TD", false, true, "Thuốc tân dược", 1 },
                    { new Guid("35df3868-8db6-440d-809f-f4c345d804a7"), "TH-MA", false, true, "Máu và chế phẩm máu", 6 },
                    { new Guid("914ca65d-6579-4590-b963-fee8a743bae1"), "TH-HT", false, true, "Thuốc hướng thần", 3 },
                    { new Guid("c987b9d2-e599-49cc-99f3-d075d27cee7c"), "TH-DT", false, true, "Dịch truyền", 5 },
                    { new Guid("ff9be71e-a958-4244-9df1-1582229c67d5"), "TH-NG", false, true, "Thuốc gây nghiện", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("00be783e-d679-4f1c-9ae2-a4f4c79de0ef"));

            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("2fd41f93-ddb9-47dd-9833-4507ce71128c"));

            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("35df3868-8db6-440d-809f-f4c345d804a7"));

            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("914ca65d-6579-4590-b963-fee8a743bae1"));

            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("c987b9d2-e599-49cc-99f3-d075d27cee7c"));

            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("ff9be71e-a958-4244-9df1-1582229c67d5"));

            migrationBuilder.DropColumn(
                name: "HeInCode",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "ImpPrice",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "ImpVatRate",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "TaxRate",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "HeInCode",
                table: "SMedicines");

            migrationBuilder.DropColumn(
                name: "IsSystem",
                table: "SMedicineGroups");

            migrationBuilder.RenameColumn(
                name: "SortOrder",
                table: "SMedicineTypes",
                newName: "SoftOrder");

            migrationBuilder.RenameColumn(
                name: "SortOrder",
                table: "SMedicines",
                newName: "SoftOrder");

            migrationBuilder.AddColumn<decimal>(
                name: "InternalPrice",
                table: "SMedicines",
                type: "decimal(18,2)",
                nullable: true);
        }
    }
}
