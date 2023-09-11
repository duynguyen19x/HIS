using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommodityType",
                table: "ItemGroups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("00be783e-d679-4f1c-9ae2-a4f4c79de0ef"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("05a24915-0bed-4f61-b53d-b5e52482e44c"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("25454ce7-bff0-4fd5-a47a-069554c1535a"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("2f5148cb-8adf-45ec-88ee-f84530cfa164"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("2fd41f93-ddb9-47dd-9833-4507ce71128c"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("3144745c-477c-4ce2-9c33-a38eb2153057"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("31d26ca7-2b5f-4dfd-b961-f3609e6a0b69"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("35df3868-8db6-440d-809f-f4c345d804a7"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("6375b8a1-b6e7-4724-a1b4-8cc3acc98e43"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("8590ae3d-351c-4438-bfe5-3f69dcf97349"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("914ca65d-6579-4590-b963-fee8a743bae1"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("9e144dff-29f6-47da-b7ed-b55abd1a2cd3"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("a28fb46e-e9b9-410e-9c31-d8ebfd22015c"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("ae04abd7-d012-470d-9b8a-f38d9c5c94a8"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("b5f03233-d733-4349-93df-db562b7d4376"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("c987b9d2-e599-49cc-99f3-d075d27cee7c"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("cc48bb40-fbf0-4054-818c-eb49545aaeea"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("cd5d7538-b1d2-448d-b6ff-c139c35f9dc7"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("ddf105e8-6534-46e4-832b-598daa84c4d5"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("e47ab5de-9ea5-4075-8da5-7ae9f36538e2"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("e482e866-9243-49d8-8676-403377de353c"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("ea57a262-6647-4e88-880c-82bc4227e916"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("ff9be71e-a958-4244-9df1-1582229c67d5"),
                column: "CommodityType",
                value: 0);

            migrationBuilder.InsertData(
                table: "ItemGroups",
                columns: new[] { "Id", "Code", "CommodityType", "Inactive", "IsSystem", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("077fe8b3-03d1-4c4c-b7be-5f7fb2015957"), "VTAC", 1, false, true, "Vật tư ấn chỉ", 27 },
                    { new Guid("18b82fb4-2ba8-4713-871f-3ba51c031b42"), "VTTH", 1, false, true, "Vật tư tiêu hoa", 23 },
                    { new Guid("27988a81-eeab-41f0-a279-c774259ecdcf"), "VTCC", 1, false, true, "Vật tư công cụ - dụng cụ", 30 },
                    { new Guid("2a8c130b-8170-4776-b3bc-51eb9da01d35"), "VTNV", 1, false, true, "Vật tư nẹp vít", 26 },
                    { new Guid("54eed868-2c02-46b3-acdf-e064a4ddb893"), "VTXH", 1, false, true, "Vật tư xã hội hóa", 31 },
                    { new Guid("58215bd0-ff85-45b4-90bb-4550f7e97838"), "VTHC", 1, false, true, "Vật tư hóa chất", 25 },
                    { new Guid("58291959-c2ca-45d6-b68d-ef81568fc163"), "VTXH", 1, false, true, "Vật tư khác", 32 },
                    { new Guid("891ad741-f6dc-48ee-be99-3e678b5e8f6c"), "VTTT", 1, false, true, "Vật tư thay thế", 24 },
                    { new Guid("a15b74b8-1a38-42de-b958-a62bbd5d8a02"), "VTTB", 1, false, true, "Vật tư thiết bị y tế", 28 },
                    { new Guid("c9c64187-bf8c-49f4-8b5b-2a04c9aafb5b"), "VTYT", 1, false, true, "Vật tư y tế", 22 },
                    { new Guid("d3ee2c41-ac9f-4356-8b76-a9b319929970"), "VTDC", 1, false, true, "Vật tư dụng cụ", 29 }
                });

            migrationBuilder.UpdateData(
                table: "ServiceGroupHeIns",
                keyColumn: "Id",
                keyValue: new Guid("675d16db-cd35-4229-b042-82aef4718aff"),
                column: "Code",
                value: "GI-NgT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("077fe8b3-03d1-4c4c-b7be-5f7fb2015957"));

            migrationBuilder.DeleteData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("18b82fb4-2ba8-4713-871f-3ba51c031b42"));

            migrationBuilder.DeleteData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("27988a81-eeab-41f0-a279-c774259ecdcf"));

            migrationBuilder.DeleteData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("2a8c130b-8170-4776-b3bc-51eb9da01d35"));

            migrationBuilder.DeleteData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("54eed868-2c02-46b3-acdf-e064a4ddb893"));

            migrationBuilder.DeleteData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("58215bd0-ff85-45b4-90bb-4550f7e97838"));

            migrationBuilder.DeleteData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("58291959-c2ca-45d6-b68d-ef81568fc163"));

            migrationBuilder.DeleteData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("891ad741-f6dc-48ee-be99-3e678b5e8f6c"));

            migrationBuilder.DeleteData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("a15b74b8-1a38-42de-b958-a62bbd5d8a02"));

            migrationBuilder.DeleteData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("c9c64187-bf8c-49f4-8b5b-2a04c9aafb5b"));

            migrationBuilder.DeleteData(
                table: "ItemGroups",
                keyColumn: "Id",
                keyValue: new Guid("d3ee2c41-ac9f-4356-8b76-a9b319929970"));

            migrationBuilder.DropColumn(
                name: "CommodityType",
                table: "ItemGroups");

            migrationBuilder.UpdateData(
                table: "ServiceGroupHeIns",
                keyColumn: "Id",
                keyValue: new Guid("675d16db-cd35-4229-b042-82aef4718aff"),
                column: "Code",
                value: "14");
        }
    }
}
