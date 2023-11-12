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
            migrationBuilder.AlterColumn<string>(
                name: "MohCode",
                table: "Hospital",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Hospital",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Hospital",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Hospital",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Gender",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Gender",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Gender",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Ethnic",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Ethnic",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Ethnic",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateTable(
                name: "AccountBookType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountBookType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountBook",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    TemplateCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SymbolCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total = table.Column<int>(type: "int", nullable: false),
                    FromNumberOrder = table.Column<int>(type: "int", nullable: false),
                    NumberOrder = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    AccountBookTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountBookTypeId1 = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountBook", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountBook_AccountBookType_AccountBookTypeId1",
                        column: x => x.AccountBookTypeId1,
                        principalTable: "AccountBookType",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("0377427b-d6bd-4b58-99a9-d71789475bb2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("08b63907-e7b9-4e6a-b075-706cca99f29c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("08f6a2b3-d5e6-4fad-a022-5f29d0117801"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("0d2992cf-6fba-4871-97b3-a8a1229e86fd"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("11baf250-7aed-4f3f-949b-82d8929d55ff"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("134969e1-21e0-496c-8a7e-b40d5e52b4f4"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("30e5cab2-63d3-4b93-b430-042b04276e20"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("3a6de8c5-5bfd-4648-8225-42c79a224793"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("4104f31a-d1ad-4025-8756-4faddf40d453"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("4c8535f7-5852-435d-8b4d-66c198537fc4"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("5a91f9a2-5a73-4dce-9a99-532c3b75518e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("5d500bff-32f6-46ee-ba7a-f89a43fdd5b1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("5ec5c91b-db70-491b-b1b5-a617d9a82549"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("613e5901-9552-40f8-b865-f9fd6e91d7e8"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("6cd03dbd-dcbf-44d1-ab7a-3b32e71b3cb7"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("723b5a32-b7a2-4d46-9e19-c42d096839e2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("91c637c5-272c-488c-8489-98be3297d88e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("93672f0e-4d83-4214-9576-d29113acea27"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("a0570373-f0ce-4051-93e7-3285476367cb"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("a67315a8-8874-4a76-9d56-bb5103740e66"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("aaf07983-f9ed-43a5-8d9e-be42cdaa4044"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("b4d1c297-0f9c-41d4-9aa9-b211ecf0cbee"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("bb4dd54d-2566-41be-a293-ed9398efeaa0"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("c1747ec7-094e-4516-bd96-3e41327a317d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("c27dbaeb-b11f-448b-bb63-be2f06d3e795"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("c3c34fe9-3d68-4f4c-98ab-abc10ec96ccc"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("c81585c5-e57d-468f-99f2-1b403317ffd9"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("cb433c30-519a-40ad-aab8-479dfad013c3"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("cd456287-b5aa-4d8c-b23d-7027c7676ce7"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("dd087168-fb8b-451f-bddd-56adff7a91b3"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("dd240e2f-1434-4091-a691-12da1214424e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("e06c956c-1795-46a0-ba63-cb75f74ac431"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("e71c20e6-9f6c-4998-8867-c29b3f0da643"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("e96358f3-2f7c-4d6f-a4fa-0268039df244"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("f21cf99c-f691-43eb-92c7-d9cd595fc1b2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("f2b02143-9c76-4717-a9a5-711ce23bf81c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("f3685b6e-8b27-4e8e-8a7d-b07ae695805f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("f8811c3e-61e4-4344-b139-b583dc0d94a3"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("f98e5ee7-4651-43fd-85fd-7e077785ad53"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("f9e407f1-0417-4067-9d25-dae91d19e1bf"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("ffa69c02-696f-4645-b72e-0f371b8cacfa"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("0105cfd9-5265-4dcc-b2d8-790abecd5577"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("02cd862f-7bf2-4dee-9d8d-869f67659eac"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("05600686-62bc-4be9-b009-58ae6fac5dc2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("05f8a24e-3764-41af-b79b-3e05da6964ad"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("060539cd-d169-45c2-bec2-28a91e41bcb3"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("067dbcfb-9729-4016-aa0f-526f43657542"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("07c04d8d-4e1c-4896-ba8a-7d8172562b37"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("09127bf0-ff5d-4660-8fef-18b3107bf295"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("0d9bf5f6-20bb-4b4f-8c3e-0b7205eabe19"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("0f42743d-f2ae-4d4d-9e9c-6dcd785204ff"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("10a98338-7167-4e5b-b3e4-9515f63bb43d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("10f310c4-857b-431b-934c-19ebc560571c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1137907c-6292-4973-8a6a-5a8a55216701"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("16bfb332-7ffe-4d31-a2a2-05e7cc250969"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1760cdb2-5d9e-4a4d-a422-9d2d54333b72"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("18be6a2d-0cc9-4e57-9b95-0fd5e0999094"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("19b9d4e2-dd04-4d66-ba70-e71a800b8563"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1a52542a-e4e8-4514-b84f-d8f7a0ce8bf5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1bb67a2c-65b1-4437-b7db-61bb5c5c945a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1bd96043-4837-4ab4-8812-0230d7cdc37c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1c1e8f0d-fa36-4dd5-a349-51f8f8cf1e11"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1c3907c5-3cd4-4530-a28c-6d4acceec175"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1cb83a16-11a1-438b-8fd9-22e661c5904a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1cc02fda-f061-49ad-a4f1-ecb564a28c88"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1d374c8c-88c5-49ae-9c9c-0b2b362b1198"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1d41f179-ba78-41d6-8ecf-595c7d6de65a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1df44627-4127-48c0-bbc7-2afc64cb75d2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1f0c0c80-dceb-47c4-9bfb-d9e2b29e8010"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("20aa6e3b-0838-45fc-9769-161b291e5e24"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("212573b7-ec34-4844-b150-74f567de2c5d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("21668f2b-b3d0-4927-9d67-3f9eee4736d6"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("22174cd0-7b2d-4c6b-bb6c-5273e63d28f0"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("226d663e-46ee-4ab2-b385-b062345debd9"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("23063395-5d36-41c9-9711-66722ab8849f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("24c5f9fa-e493-43a1-9d2a-c6d25dc2ea89"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("25b7ed9b-8bfd-4601-a4c5-a59dfe5a3fab"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("25df127f-9fb7-4f1d-8a4f-484364e15f91"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("264432ff-ba3d-4402-ae05-d3cbbdf7eef4"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("26d0e10a-43ea-4654-93be-00a21f60b760"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("298cf3d9-cf13-401f-86b5-368d1c71ec77"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("2e24284d-fe7b-477b-a3e9-23505ccbe379"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("2eab2085-d20b-4cc4-a85b-7567c9ce6ea9"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("2eb9de76-3d99-43a5-b17d-ba2f0e08c64a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("2eead3fb-8c57-4699-a48d-b9eb2a781d23"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("2f4455d6-efee-4959-8dfd-6f7db81faadd"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("2facb682-01d5-4798-bf0a-928bd471ecb3"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("332e0e9e-0182-47a0-b894-ade71da83708"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("33aeb885-ea5c-4343-8011-b1dccebdd65f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3466));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("347a0e24-276d-4a54-b92b-4b88b60179af"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("36299397-b100-420b-bd1b-3f18eda310fa"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("3671801a-1c88-4dc6-9e75-d766644c2af9"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("36ddc306-adf0-4897-a200-6377ff0d9042"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("39351753-1af5-4797-89e2-b97589db8d2e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("39ef7fcd-b539-46be-90a6-bc3f6d1524d8"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("3adb70b0-ae40-4ac0-8a27-15398cc79d49"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("3af1daa8-65e1-4502-823d-3c8530608104"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("3d9d9ca5-3356-48b3-b518-eb806a6128ee"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("3dac050e-a2a6-469b-b0bb-def2e17544a5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("3de67d92-a46e-4113-bd12-2e89a48aa1f0"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("3edffd99-5e14-4466-9f3e-a72ab48711d7"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("3f3e1d5e-ca7b-45ef-9e1e-f3c471e8894f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("426516a2-46e9-4103-8b44-22b4a30b21ae"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("4452efd3-9727-4c5c-9cc9-76f7270c673d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("44ff82d4-3356-4f71-9aa2-dc5f161537f0"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("45696681-b325-4d55-b4ea-56a920227907"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("4589f414-2018-4196-a42a-68fa60b41dae"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("45a0ebe0-51be-423b-8885-7a7bf06e6f95"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("46651a82-3d63-4a24-baff-9bb1ee8ac492"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("484be820-41ff-4911-94c6-2d2969764ac4"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("4b12f61e-5980-415f-a62b-b296753fd70d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("4b7309a1-de33-4f43-a2ff-3f11e0e5869b"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("4bab2495-c861-47e7-82e6-1806fd87b767"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("4dbc51c5-3faa-4e76-b0d5-a28df95c5c01"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("4dcd4bda-0da9-415d-8f7e-ecd5841ad250"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("4e6e77af-56d6-4314-ac68-c39713511d70"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("50202b21-f7c0-42eb-89bd-4470e82f3943"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("502c14cb-18ea-461f-9bc0-9591b056284c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("506ddd2c-4f81-4d6d-806c-4c9e605bab3f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("509f7d40-e740-472f-8a7a-84b5a527eb96"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("50c044c3-6cd1-46ad-b10a-e879291806f2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("52595376-4b2b-4746-bb17-16f7ba234a33"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("5300fbb8-1d3b-48c2-b251-c9daab165b94"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("5351587c-9713-44c9-9088-9626d01300c8"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("539247ef-f9a9-4893-b250-2aa204a87640"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("53b7d739-4b49-4a35-9d04-93520d79d105"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("53fdbb96-c808-4474-83bc-084e422a8b95"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("54ca17f4-f6f7-4bcf-9809-8d45153c2271"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("561d896e-c3c5-4dfc-b13c-790aa25fbd5d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("5701a860-793e-4660-9302-005b27d4348e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("573dec77-5908-42b2-b1a5-8a5ee8407dee"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("57c01cf1-7f20-4a6c-bec9-bcc9a3a039fe"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("58357a87-d3a9-4ea4-82ea-eb7775f1c568"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("58486abc-86a6-4bb8-a610-eb0e4bdf0b73"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("58776bc3-ee4b-44ae-ac9e-a501437bde2f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("58d12ab1-4946-45f9-bef5-354e5803f357"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("59e93599-98e9-44de-b9d1-bbbf17c599bf"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("5a68453d-81d4-4417-a579-33d6a1c27ea6"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("5b526a49-1694-4eb8-b602-4e150d12184d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("5bd03273-5b23-4181-892c-397126e8da56"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("5d60e969-8387-42e4-b866-31dfb209f433"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("5dc567de-1249-4aaa-9d49-04dcd3501220"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("5f4a7dfd-c3ed-4796-bde2-94199e595ef0"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("62947f31-4a3e-441b-a9d2-9642ce61de2f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("62b0c6c0-4a45-4f33-b35e-d184d815518e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("63c8621a-fc44-4abe-ba08-8d80520280cf"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("6477d7a3-465e-4277-a4eb-ef09b13f5eca"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("66169c75-2aa7-409a-a7b9-d8cfe6ac80c0"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("66400b32-893a-489c-a5e1-180d55fb20d4"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("66533605-d826-4aec-9536-e4d30effefda"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("665d03c6-346e-43d8-ad21-31492b4382aa"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("686b79de-db2f-4ccd-946c-1bef80cd503e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("6b24b562-1294-4537-a69a-26ac34c41521"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("6b8836aa-2476-4d82-98f1-0b7f56e66f7a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("6c408b50-b4be-4eca-a710-11a6d914cf4f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("6d2d2371-8785-4a7b-94ba-84c804b2b0a2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("6d5a6761-432b-4bd2-9b04-5e01c421de23"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("716a0688-0378-4941-af8f-c11dc4c45ac2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("720aaa71-3cc0-470f-b56c-472ac37a6574"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("72d527d4-00df-4f9a-b0e1-e1fa84a4ba6d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("74c266fd-7287-4525-aca3-6bb66ddcf61f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("75de9dea-ef0f-4492-890a-f5af36cce7aa"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("76c42f0f-bfb2-4a11-b5a4-e854f74e72cd"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("77365013-80d7-44d5-bd8d-472542cac431"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("788693d2-4ac9-4f85-94bf-13d021bc000d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("78dcfd52-de7b-4c1d-9ded-0e5d3f7a8a35"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("79bc1ba0-a0f6-4065-9783-9e01ade32cde"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("7a384197-d55e-44b8-b389-a65f17e74e1f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("7af80a81-41e5-47de-abd3-7ce25f9c39b4"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("7afaefc0-9aa8-4ba7-98ae-618682a5be7f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("7b0c9a9c-e730-4b96-9372-e9ef8ab5339b"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("7bea406c-221d-45dd-aca6-a2ceb90741aa"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("7e27cb42-41fb-4b20-b26b-3c1ea9b4ff5c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("7ef68b6d-2d6b-4688-95bc-d0fd79ffb6c5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("7f233816-fe94-4941-8125-b62c88410fa9"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("8562fd7f-49aa-46cf-bbc9-71f7460c6ba7"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("8592d87f-720b-48e7-82ee-e82d64cbf984"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("8764ee96-c950-44cf-a1f4-7636126c671b"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("882c80ef-806d-4370-9fb1-f00a13a7a5c1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("8a003437-323c-451c-b211-1886f79c25f1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("8a6a8442-1533-4bba-9a05-ed707122573e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("8f800608-e254-418d-8163-78f71be4873f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("8ff51ea0-476b-4dec-8736-70cc36ea1d2c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("90b2a6a0-bacd-4175-80e9-b8fde9233786"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("90ef0553-8520-4d57-ae3b-112ebf28b313"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("92aea1da-5cf2-40fa-92a2-cce297949451"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("92b69f82-f3e2-4ea9-9d4b-1763b1a75dec"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("93fc49be-bd23-41c3-8538-4b424a7806da"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("9412c9e0-c4fe-442f-8b13-ea064bf48703"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("9601fc62-41b1-44af-af8e-8a03c91c96b8"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("97bc234b-7d4c-4870-801b-74f1998741be"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("98062645-5015-4d8c-886e-3fb70c247ada"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("994cf06f-b833-4415-84e0-94f3847b6dd8"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("99cfce62-6540-4525-97b8-9a2e62618e05"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("9acb769e-d2de-479c-b66a-424ce710a036"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("9d5769fe-b3ae-4697-9150-44674e8008ba"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("9ded845f-06a1-4651-8903-bc46f7978c84"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("9eb57842-f592-4080-affd-71b43f7d0517"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("9ee7b166-4c6f-4136-8928-c6246c3e76d5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("a1080c01-e5bb-4e3f-8784-f0678f1eff58"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("a1ba5be8-fef9-470a-a5f7-efcf7fc900a4"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("a1f120ed-4785-486e-b796-dd8cd569a415"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("a30f588b-166d-4118-9d33-b8294e15ad44"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("a3597652-cc84-40ff-b143-208ee8473e93"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("a3c5c224-a013-4e23-8655-641a0a76b38a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("a695b824-cfc2-40a3-b5a1-35243a6e2116"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("a7a696de-3fd8-48c2-b87a-6464b222af87"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("a8b38e56-d3ea-435f-907a-615ed7ced805"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("aa3d56b9-f398-4be1-b8ae-9f8563101b6e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("aa4399ec-1ff3-4837-a68e-0df0720162cb"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("aa745539-b444-49d2-ad13-14149f8a1645"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("ab16a3ed-00cd-4445-8e7c-770b1965232e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("abdfeb5b-a4b8-4ab1-b6b8-83f7fb72ec23"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("ad4ef5f1-e823-4ed4-9ad5-cec4a2cae6af"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("af24512b-01ae-4420-96cb-62051ede96cc"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("af3badc9-b6da-4eb0-8a42-ecf8dfd6ae19"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("af9c2425-679e-4459-8c68-2d357f4f93e5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("affdf19e-5ed4-497a-97d0-0fc95a547785"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("b16a509f-5c70-42b1-a05e-6d4426c721ca"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("b171e933-4b7d-46f5-802a-14c5c9234ed7"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("b1829e62-c3dd-4f65-8c41-fdbe26aedb93"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("b4e019b1-042b-465c-baf9-60d525d9b85c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("b6169a90-920f-425d-a275-82601862a220"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("b83926c4-6963-4f82-97f7-dffa6e87ea7d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("b83be42b-cde9-4dc3-a838-d8197d2c678f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("ba7304bd-7e25-4731-a60f-10c13589c71a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("ba947c48-36fb-420b-b2d9-663fe308b18c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("bcb96598-0e05-4316-86d3-80413326555a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("be946a16-a1af-499c-9bd8-ca12a22fb69c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("bf1bf333-4604-4974-838f-886100c006f3"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("c4065df0-2539-4046-bb77-7d699a072734"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("c5c14db2-753f-4e28-88b5-3b9e502fa0c6"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("c6f6287f-39f6-4470-ad46-ac539eef3052"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("c7f500b0-be15-4ab8-ae5c-1db430d19b8c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("c831fb16-910b-4939-804a-1052b8f8adc1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("c8766416-ed13-4631-a9c4-e89e782055c9"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("cba207c9-9ee4-4a20-876b-ecb1160d0845"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("cbf1c521-494b-4981-9dc9-b6a1b229c01d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("cc2a4d3b-bae2-4602-9d23-4d4d2d918699"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("cdd52492-d981-4972-9f41-4b1774c002ee"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("cf8c2ebc-2ed1-404c-875c-d2151d54ab9e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("d0357290-582a-47cd-984c-8815d38454be"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("d1fef153-87bc-403a-9590-0ec4cc8d676e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("d200b4b5-7435-41a9-be8b-b6a80e14120b"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("d2ebac27-3463-40cb-9eb2-86e1da12a3ba"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("d34d65e5-253f-4324-9aee-f74045802e47"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("d3c10501-b94f-4a0e-b871-80d4b3d7bbbb"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("d50a063a-82ef-4b56-858e-1a8794b32878"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("d576474f-de6a-45fc-bd19-e18a2915f1a4"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("d892c6c0-bf86-4487-ab8b-5af35cc32a0c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("d94b5935-e6d2-4aa7-b9f7-d332badacd8d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("da333d92-e16c-4b49-b9d8-669df9032f82"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("dd79ead4-6e12-4cb8-aff5-8f00d8bf9e99"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("dd951a03-c803-4351-aac5-ed4ec9922bab"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("ddf4ecad-6f97-4bde-84fe-2b9dc51f0ffd"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("de0d7be8-8a87-4358-b93e-e809ab17f238"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("e180ff8a-4e49-4edd-9168-21b372b8d9b7"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("e1fc9395-73b5-4fd6-8c31-37fef3a3e866"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("e369137c-1730-4809-88e4-e43031327233"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("e3a2237c-9d57-462f-bad8-7a78856303c8"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("e43c3f5c-e8d7-430a-9869-e61337bd4188"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("e4acc3fd-7e2d-4927-b7e8-797cb8a29a86"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("e4c05566-0c8d-42a4-a2e9-ad4d6d33b35f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("e5439053-279d-4094-852d-0c2edc6992ed"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("e5837adb-d926-41f1-8434-73fed9db7504"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("e6e7518f-73eb-4010-b0cf-6dcc5c8f8e01"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("e9455b51-bd57-482f-a979-5ecf6c8c4afd"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("edb5a6e1-b084-4e46-87ab-22d38da9cf0a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("edcecb3c-ffcb-451f-8e24-02a0bf6499ae"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("ee02aa87-f8dc-44ac-9ac9-830120f05656"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("ee707e39-4195-426c-abf9-1ce21a771350"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f034e368-335c-4a9f-a039-b7ea83f8a315"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f07d3dde-aea1-4f0a-ba9d-310cda4fa6e9"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f1218849-b5cf-43c8-b3c4-b1ff145f27fc"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f1c02c7d-3154-4e55-817c-1e24f6eef729"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f21a86da-a1de-4023-93c9-3a23d315a8cd"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f36eb030-510e-4ca0-b7c4-a1c1ef656dd6"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f468cb27-57fb-4b75-b3b7-70bb33ca2705"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f5874f17-6c1e-4c07-b8bf-41b76546f6f0"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f5f9c1ed-f4fb-4cff-aee3-2bcb0d8eed3e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f5fdcb6c-e0c5-4a57-adca-e743ba60ccee"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f79baaf7-6191-4ba9-b38a-2f1b50d05598"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f9375017-9897-4487-8916-c98d22fd05b9"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("fb10ce71-e68a-4a70-bf7e-5edee9388d48"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("fb67b422-6903-494e-945d-fa09f031b4f1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("fc5a0c05-ebac-4906-8a9f-dddcdbcc0a9d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("fd0ac376-bf65-4bf8-9067-245691aa1827"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("fd21963c-7b5e-44a8-8d70-2edbda437946"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("fd235817-1607-4f4c-83c7-ff5bd0012896"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("fd32d265-24dd-4073-a4b8-59e6358b59ed"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("fe657d37-7960-4bb3-8f15-81666fca928d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("ff78779a-45cd-4076-8c61-442a9a3873f2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("ffd3fabd-a5f1-4442-837b-d53b5d89272e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "DepartmentType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "DepartmentType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "DepartmentType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "DepartmentType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170901"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170902"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170903"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170904"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170905"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170906"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170907"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170908"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170909"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170910"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170911"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170912"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170913"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170914"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170915"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170916"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170917"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170918"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170919"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170920"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170921"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170922"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170923"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170924"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170925"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170926"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170927"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170928"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170929"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170930"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170931"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170932"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170933"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170934"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170935"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170936"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170937"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170938"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170939"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170940"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170941"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170942"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170943"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170944"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170945"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170946"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170947"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170948"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170949"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170950"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170951"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170952"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170953"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170954"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170999"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: new Guid("97ac7fd8-edfa-4243-97fc-98468f492df1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: new Guid("e9497984-d355-41af-b917-091500956be9"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: new Guid("fc153433-bf89-4e95-8523-df3d8cec8676"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("003360aa-6adc-4e1c-8da9-fd1d1665729d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("0729fb2e-ae19-41f3-b948-b0f0c51fbf99"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("0b13943c-ead8-4e76-80b8-33b31828dd7a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("0fdfd770-bee4-4dc4-9eb5-d86816bfc2bf"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("198417f7-e503-4435-bde2-7547487c943a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("1d8b3ff0-1bbd-4fa4-a4c8-1a4e2c394a55"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("2c03541e-db56-4bcb-8012-52b0f130ca09"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("2d80dbcf-c7d5-4450-9847-e7e6f737f567"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("3035b967-95aa-46a5-be3f-b1f7bec1fd51"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("3109e53a-812d-455e-a968-e86ff499d74d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("33d6ec24-75ee-402e-b8d2-3296e90ea336"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("37d13fe4-1fd2-4268-bbae-4ab301f634c5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("38e1ffeb-7572-40c7-a716-cd880eb8d1ce"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("395f3325-851f-41ee-b652-5002ce7cf547"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("3baaffd5-90a2-471f-8581-b5969184fcbe"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("3fd18cc5-7204-42a9-a940-c5cf3128518f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("40064e04-52c1-460d-b3d3-04f4e991f82c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("46ddf496-df97-40b4-9b23-bfd17357abbe"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("4e6a7717-9e60-4bae-a2d4-d29dacd8af47"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("528fe36b-ac63-4f15-96f5-104ac221a155"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("52b17f24-a4a1-4cc6-88a0-c526ee8256c6"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("5329306e-8290-4ca4-b110-0678c20752e0"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("619d7aee-4e6a-4993-9d7a-c6e32958851f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("64a15171-a037-45b4-a55d-08ee58ce687d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("68d199cc-b739-4d61-b412-40d2242f374d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("6f51a702-3c62-4a43-8042-9cf6e8bf3186"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("702c3cf1-d0b3-4647-8d39-7549dd42f610"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("7184c251-1c62-4b69-a63f-de49e85633f0"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("72478add-ca26-4a9b-92bd-2b075006f36a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("77e4b05d-6245-43ee-ba94-84faaece9018"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("7a3c3be6-fe62-42ab-9764-f8e62d7f5916"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("7acbf3ec-7068-4007-a871-e0fee1ef28c5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("839f0efb-168d-4110-a041-60b463ae48a1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("889693ed-0453-4387-941b-d70dd4870dc5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("8eb57a8e-8281-41bb-a5ab-637dcac67177"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("8ed43986-0586-4742-8f89-a673c9f63756"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("8f0f2a47-34e4-4af3-811a-4d9c1fbf1cae"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("927f685b-f766-4bf8-93ed-ae7aabc4071c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("94dab20e-c05d-4aa9-93e9-82e972792756"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("952aa342-c05d-46d3-8ffe-6a22d7512dc2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("9c2a8569-d860-459d-8c3a-49966ea0038d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("9d49b503-ac5f-47f3-aaa2-8d18853bfba6"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("a1f48dda-f1a3-473a-b4f7-6843312303f4"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("aee0f859-e3bd-41ae-be15-17060d5ad617"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("af97b966-5b74-4580-a948-c8a9df0a5fba"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("b2035ac5-5e24-4a18-8587-62e65fd64697"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("b2cace92-0d42-4789-97c7-83ea3c3667c5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("b42cba39-912a-4400-84a5-fe15eb71766e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("b6bdda7d-b047-45a0-9d73-ffcb4e938e38"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("b6cf7563-f2be-4273-bcc7-58bb3cd4edec"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("c16dbbe1-bea2-413b-9216-5b547deac9f5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("c30f4992-257a-4abf-abb0-2ea4b36f247f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("cd4eab40-92a3-4898-8a65-c67ccde721c0"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("da06856d-9e6c-49f7-bbed-ca2a06ca81c1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("e5a4e82b-b29d-4b47-a563-82977ea93346"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("e7fe23cb-4304-4fb0-90a5-9ff4da5048aa"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("ec0b077d-3957-4089-85f8-c1d6742aab19"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("ed0a3763-3a96-46c5-8094-c47a4708e3cb"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("ef981a1e-0af1-4b7f-9fd7-42de078e7d97"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("f06e27bf-1470-4f7a-873f-f0dc77e405e4"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("f2aac7ae-5a85-48fc-9166-d9ab6efb79ab"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("f5d76f98-2024-4c60-81ad-577359cb69d1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("fa11ad72-29b7-49f4-986d-fea0d53de210"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("1376a459-2acd-42e2-a7a7-2591f74b21eb"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("1daedd7e-7ca2-4fdb-9956-4fa4c7718a79"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("3b8fbd78-7899-4b81-832a-da090f149077"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("4252af04-6cfe-4476-bb99-4a922b6bc0ad"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("694a319f-11d3-4e0e-bf68-c99aa89b8d95"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("6a46d932-03d2-477b-be50-1a5e791ecb94"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("826cfc0a-538b-4cb8-86cf-3f61b3c58a7f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("8e15b578-7302-4e88-97aa-0b956759eaee"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("9f3e6fc7-ef22-4ba4-9e59-8cca8b6cb195"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("a08c20c4-3e67-429f-a6c8-f32aeaeb3532"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("a734da32-8028-4210-bae5-98bda97961ff"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("bcabc031-806f-452a-84da-77d554e5a5b4"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("ccbee237-acf6-47f2-9c39-ed544222712e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 19, 5, 23, 391, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.CreateIndex(
                name: "IX_AccountBook_AccountBookTypeId1",
                table: "AccountBook",
                column: "AccountBookTypeId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountBook");

            migrationBuilder.DropTable(
                name: "AccountBookType");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Hospital");

            migrationBuilder.AlterColumn<string>(
                name: "MohCode",
                table: "Hospital",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Hospital",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Hospital",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Gender",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Gender",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Gender",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Ethnic",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Ethnic",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Ethnic",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("0377427b-d6bd-4b58-99a9-d71789475bb2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("08b63907-e7b9-4e6a-b075-706cca99f29c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("08f6a2b3-d5e6-4fad-a022-5f29d0117801"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("0d2992cf-6fba-4871-97b3-a8a1229e86fd"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("11baf250-7aed-4f3f-949b-82d8929d55ff"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("134969e1-21e0-496c-8a7e-b40d5e52b4f4"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("30e5cab2-63d3-4b93-b430-042b04276e20"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("3a6de8c5-5bfd-4648-8225-42c79a224793"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("4104f31a-d1ad-4025-8756-4faddf40d453"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("4c8535f7-5852-435d-8b4d-66c198537fc4"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("5a91f9a2-5a73-4dce-9a99-532c3b75518e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("5d500bff-32f6-46ee-ba7a-f89a43fdd5b1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("5ec5c91b-db70-491b-b1b5-a617d9a82549"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("613e5901-9552-40f8-b865-f9fd6e91d7e8"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("6cd03dbd-dcbf-44d1-ab7a-3b32e71b3cb7"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("723b5a32-b7a2-4d46-9e19-c42d096839e2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("91c637c5-272c-488c-8489-98be3297d88e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("93672f0e-4d83-4214-9576-d29113acea27"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("a0570373-f0ce-4051-93e7-3285476367cb"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("a67315a8-8874-4a76-9d56-bb5103740e66"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("aaf07983-f9ed-43a5-8d9e-be42cdaa4044"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("b4d1c297-0f9c-41d4-9aa9-b211ecf0cbee"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("bb4dd54d-2566-41be-a293-ed9398efeaa0"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("c1747ec7-094e-4516-bd96-3e41327a317d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("c27dbaeb-b11f-448b-bb63-be2f06d3e795"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("c3c34fe9-3d68-4f4c-98ab-abc10ec96ccc"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("c81585c5-e57d-468f-99f2-1b403317ffd9"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("cb433c30-519a-40ad-aab8-479dfad013c3"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("cd456287-b5aa-4d8c-b23d-7027c7676ce7"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("dd087168-fb8b-451f-bddd-56adff7a91b3"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("dd240e2f-1434-4091-a691-12da1214424e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("e06c956c-1795-46a0-ba63-cb75f74ac431"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("e71c20e6-9f6c-4998-8867-c29b3f0da643"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("e96358f3-2f7c-4d6f-a4fa-0268039df244"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("f21cf99c-f691-43eb-92c7-d9cd595fc1b2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("f2b02143-9c76-4717-a9a5-711ce23bf81c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("f3685b6e-8b27-4e8e-8a7d-b07ae695805f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("f8811c3e-61e4-4344-b139-b583dc0d94a3"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("f98e5ee7-4651-43fd-85fd-7e077785ad53"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("f9e407f1-0417-4067-9d25-dae91d19e1bf"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "ChapterIcds",
                keyColumn: "Id",
                keyValue: new Guid("ffa69c02-696f-4645-b72e-0f371b8cacfa"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("0105cfd9-5265-4dcc-b2d8-790abecd5577"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("02cd862f-7bf2-4dee-9d8d-869f67659eac"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("05600686-62bc-4be9-b009-58ae6fac5dc2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("05f8a24e-3764-41af-b79b-3e05da6964ad"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("060539cd-d169-45c2-bec2-28a91e41bcb3"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("067dbcfb-9729-4016-aa0f-526f43657542"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("07c04d8d-4e1c-4896-ba8a-7d8172562b37"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("09127bf0-ff5d-4660-8fef-18b3107bf295"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("0d9bf5f6-20bb-4b4f-8c3e-0b7205eabe19"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("0f42743d-f2ae-4d4d-9e9c-6dcd785204ff"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("10a98338-7167-4e5b-b3e4-9515f63bb43d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("10f310c4-857b-431b-934c-19ebc560571c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1137907c-6292-4973-8a6a-5a8a55216701"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("16bfb332-7ffe-4d31-a2a2-05e7cc250969"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1760cdb2-5d9e-4a4d-a422-9d2d54333b72"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("18be6a2d-0cc9-4e57-9b95-0fd5e0999094"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("19b9d4e2-dd04-4d66-ba70-e71a800b8563"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1a52542a-e4e8-4514-b84f-d8f7a0ce8bf5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1bb67a2c-65b1-4437-b7db-61bb5c5c945a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1bd96043-4837-4ab4-8812-0230d7cdc37c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1c1e8f0d-fa36-4dd5-a349-51f8f8cf1e11"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1c3907c5-3cd4-4530-a28c-6d4acceec175"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1cb83a16-11a1-438b-8fd9-22e661c5904a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1cc02fda-f061-49ad-a4f1-ecb564a28c88"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1d374c8c-88c5-49ae-9c9c-0b2b362b1198"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1d41f179-ba78-41d6-8ecf-595c7d6de65a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1df44627-4127-48c0-bbc7-2afc64cb75d2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("1f0c0c80-dceb-47c4-9bfb-d9e2b29e8010"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("20aa6e3b-0838-45fc-9769-161b291e5e24"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("212573b7-ec34-4844-b150-74f567de2c5d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("21668f2b-b3d0-4927-9d67-3f9eee4736d6"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("22174cd0-7b2d-4c6b-bb6c-5273e63d28f0"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("226d663e-46ee-4ab2-b385-b062345debd9"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("23063395-5d36-41c9-9711-66722ab8849f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("24c5f9fa-e493-43a1-9d2a-c6d25dc2ea89"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("25b7ed9b-8bfd-4601-a4c5-a59dfe5a3fab"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("25df127f-9fb7-4f1d-8a4f-484364e15f91"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("264432ff-ba3d-4402-ae05-d3cbbdf7eef4"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("26d0e10a-43ea-4654-93be-00a21f60b760"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("298cf3d9-cf13-401f-86b5-368d1c71ec77"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("2e24284d-fe7b-477b-a3e9-23505ccbe379"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("2eab2085-d20b-4cc4-a85b-7567c9ce6ea9"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("2eb9de76-3d99-43a5-b17d-ba2f0e08c64a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("2eead3fb-8c57-4699-a48d-b9eb2a781d23"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("2f4455d6-efee-4959-8dfd-6f7db81faadd"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("2facb682-01d5-4798-bf0a-928bd471ecb3"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("332e0e9e-0182-47a0-b894-ade71da83708"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("33aeb885-ea5c-4343-8011-b1dccebdd65f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("347a0e24-276d-4a54-b92b-4b88b60179af"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("36299397-b100-420b-bd1b-3f18eda310fa"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("3671801a-1c88-4dc6-9e75-d766644c2af9"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("36ddc306-adf0-4897-a200-6377ff0d9042"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("39351753-1af5-4797-89e2-b97589db8d2e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("39ef7fcd-b539-46be-90a6-bc3f6d1524d8"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("3adb70b0-ae40-4ac0-8a27-15398cc79d49"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("3af1daa8-65e1-4502-823d-3c8530608104"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("3d9d9ca5-3356-48b3-b518-eb806a6128ee"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("3dac050e-a2a6-469b-b0bb-def2e17544a5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("3de67d92-a46e-4113-bd12-2e89a48aa1f0"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("3edffd99-5e14-4466-9f3e-a72ab48711d7"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("3f3e1d5e-ca7b-45ef-9e1e-f3c471e8894f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("426516a2-46e9-4103-8b44-22b4a30b21ae"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("4452efd3-9727-4c5c-9cc9-76f7270c673d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("44ff82d4-3356-4f71-9aa2-dc5f161537f0"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("45696681-b325-4d55-b4ea-56a920227907"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("4589f414-2018-4196-a42a-68fa60b41dae"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("45a0ebe0-51be-423b-8885-7a7bf06e6f95"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("46651a82-3d63-4a24-baff-9bb1ee8ac492"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("484be820-41ff-4911-94c6-2d2969764ac4"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("4b12f61e-5980-415f-a62b-b296753fd70d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("4b7309a1-de33-4f43-a2ff-3f11e0e5869b"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("4bab2495-c861-47e7-82e6-1806fd87b767"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("4dbc51c5-3faa-4e76-b0d5-a28df95c5c01"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("4dcd4bda-0da9-415d-8f7e-ecd5841ad250"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("4e6e77af-56d6-4314-ac68-c39713511d70"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("50202b21-f7c0-42eb-89bd-4470e82f3943"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("502c14cb-18ea-461f-9bc0-9591b056284c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("506ddd2c-4f81-4d6d-806c-4c9e605bab3f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("509f7d40-e740-472f-8a7a-84b5a527eb96"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("50c044c3-6cd1-46ad-b10a-e879291806f2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("52595376-4b2b-4746-bb17-16f7ba234a33"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("5300fbb8-1d3b-48c2-b251-c9daab165b94"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("5351587c-9713-44c9-9088-9626d01300c8"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("539247ef-f9a9-4893-b250-2aa204a87640"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("53b7d739-4b49-4a35-9d04-93520d79d105"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("53fdbb96-c808-4474-83bc-084e422a8b95"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("54ca17f4-f6f7-4bcf-9809-8d45153c2271"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("561d896e-c3c5-4dfc-b13c-790aa25fbd5d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("5701a860-793e-4660-9302-005b27d4348e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("573dec77-5908-42b2-b1a5-8a5ee8407dee"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("57c01cf1-7f20-4a6c-bec9-bcc9a3a039fe"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("58357a87-d3a9-4ea4-82ea-eb7775f1c568"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("58486abc-86a6-4bb8-a610-eb0e4bdf0b73"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("58776bc3-ee4b-44ae-ac9e-a501437bde2f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("58d12ab1-4946-45f9-bef5-354e5803f357"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("59e93599-98e9-44de-b9d1-bbbf17c599bf"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("5a68453d-81d4-4417-a579-33d6a1c27ea6"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("5b526a49-1694-4eb8-b602-4e150d12184d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("5bd03273-5b23-4181-892c-397126e8da56"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("5d60e969-8387-42e4-b866-31dfb209f433"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("5dc567de-1249-4aaa-9d49-04dcd3501220"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("5f4a7dfd-c3ed-4796-bde2-94199e595ef0"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("62947f31-4a3e-441b-a9d2-9642ce61de2f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("62b0c6c0-4a45-4f33-b35e-d184d815518e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("63c8621a-fc44-4abe-ba08-8d80520280cf"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("6477d7a3-465e-4277-a4eb-ef09b13f5eca"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("66169c75-2aa7-409a-a7b9-d8cfe6ac80c0"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("66400b32-893a-489c-a5e1-180d55fb20d4"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("66533605-d826-4aec-9536-e4d30effefda"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("665d03c6-346e-43d8-ad21-31492b4382aa"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("686b79de-db2f-4ccd-946c-1bef80cd503e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("6b24b562-1294-4537-a69a-26ac34c41521"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("6b8836aa-2476-4d82-98f1-0b7f56e66f7a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("6c408b50-b4be-4eca-a710-11a6d914cf4f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("6d2d2371-8785-4a7b-94ba-84c804b2b0a2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("6d5a6761-432b-4bd2-9b04-5e01c421de23"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("716a0688-0378-4941-af8f-c11dc4c45ac2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("720aaa71-3cc0-470f-b56c-472ac37a6574"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("72d527d4-00df-4f9a-b0e1-e1fa84a4ba6d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("74c266fd-7287-4525-aca3-6bb66ddcf61f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("75de9dea-ef0f-4492-890a-f5af36cce7aa"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("76c42f0f-bfb2-4a11-b5a4-e854f74e72cd"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("77365013-80d7-44d5-bd8d-472542cac431"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("788693d2-4ac9-4f85-94bf-13d021bc000d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("78dcfd52-de7b-4c1d-9ded-0e5d3f7a8a35"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("79bc1ba0-a0f6-4065-9783-9e01ade32cde"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("7a384197-d55e-44b8-b389-a65f17e74e1f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("7af80a81-41e5-47de-abd3-7ce25f9c39b4"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("7afaefc0-9aa8-4ba7-98ae-618682a5be7f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("7b0c9a9c-e730-4b96-9372-e9ef8ab5339b"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("7bea406c-221d-45dd-aca6-a2ceb90741aa"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("7e27cb42-41fb-4b20-b26b-3c1ea9b4ff5c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("7ef68b6d-2d6b-4688-95bc-d0fd79ffb6c5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("7f233816-fe94-4941-8125-b62c88410fa9"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("8562fd7f-49aa-46cf-bbc9-71f7460c6ba7"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("8592d87f-720b-48e7-82ee-e82d64cbf984"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("8764ee96-c950-44cf-a1f4-7636126c671b"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("882c80ef-806d-4370-9fb1-f00a13a7a5c1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("8a003437-323c-451c-b211-1886f79c25f1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("8a6a8442-1533-4bba-9a05-ed707122573e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("8f800608-e254-418d-8163-78f71be4873f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("8ff51ea0-476b-4dec-8736-70cc36ea1d2c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("90b2a6a0-bacd-4175-80e9-b8fde9233786"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("90ef0553-8520-4d57-ae3b-112ebf28b313"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("92aea1da-5cf2-40fa-92a2-cce297949451"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("92b69f82-f3e2-4ea9-9d4b-1763b1a75dec"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("93fc49be-bd23-41c3-8538-4b424a7806da"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("9412c9e0-c4fe-442f-8b13-ea064bf48703"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("9601fc62-41b1-44af-af8e-8a03c91c96b8"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("97bc234b-7d4c-4870-801b-74f1998741be"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("98062645-5015-4d8c-886e-3fb70c247ada"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("994cf06f-b833-4415-84e0-94f3847b6dd8"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("99cfce62-6540-4525-97b8-9a2e62618e05"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("9acb769e-d2de-479c-b66a-424ce710a036"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("9d5769fe-b3ae-4697-9150-44674e8008ba"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("9ded845f-06a1-4651-8903-bc46f7978c84"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("9eb57842-f592-4080-affd-71b43f7d0517"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("9ee7b166-4c6f-4136-8928-c6246c3e76d5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("a1080c01-e5bb-4e3f-8784-f0678f1eff58"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("a1ba5be8-fef9-470a-a5f7-efcf7fc900a4"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("a1f120ed-4785-486e-b796-dd8cd569a415"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("a30f588b-166d-4118-9d33-b8294e15ad44"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("a3597652-cc84-40ff-b143-208ee8473e93"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("a3c5c224-a013-4e23-8655-641a0a76b38a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("a695b824-cfc2-40a3-b5a1-35243a6e2116"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("a7a696de-3fd8-48c2-b87a-6464b222af87"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("a8b38e56-d3ea-435f-907a-615ed7ced805"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("aa3d56b9-f398-4be1-b8ae-9f8563101b6e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("aa4399ec-1ff3-4837-a68e-0df0720162cb"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("aa745539-b444-49d2-ad13-14149f8a1645"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("ab16a3ed-00cd-4445-8e7c-770b1965232e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("abdfeb5b-a4b8-4ab1-b6b8-83f7fb72ec23"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("ad4ef5f1-e823-4ed4-9ad5-cec4a2cae6af"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("af24512b-01ae-4420-96cb-62051ede96cc"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("af3badc9-b6da-4eb0-8a42-ecf8dfd6ae19"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("af9c2425-679e-4459-8c68-2d357f4f93e5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("affdf19e-5ed4-497a-97d0-0fc95a547785"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("b16a509f-5c70-42b1-a05e-6d4426c721ca"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("b171e933-4b7d-46f5-802a-14c5c9234ed7"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("b1829e62-c3dd-4f65-8c41-fdbe26aedb93"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("b4e019b1-042b-465c-baf9-60d525d9b85c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("b6169a90-920f-425d-a275-82601862a220"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("b83926c4-6963-4f82-97f7-dffa6e87ea7d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("b83be42b-cde9-4dc3-a838-d8197d2c678f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("ba7304bd-7e25-4731-a60f-10c13589c71a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("ba947c48-36fb-420b-b2d9-663fe308b18c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("bcb96598-0e05-4316-86d3-80413326555a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("be946a16-a1af-499c-9bd8-ca12a22fb69c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("bf1bf333-4604-4974-838f-886100c006f3"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("c4065df0-2539-4046-bb77-7d699a072734"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("c5c14db2-753f-4e28-88b5-3b9e502fa0c6"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("c6f6287f-39f6-4470-ad46-ac539eef3052"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("c7f500b0-be15-4ab8-ae5c-1db430d19b8c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("c831fb16-910b-4939-804a-1052b8f8adc1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("c8766416-ed13-4631-a9c4-e89e782055c9"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("cba207c9-9ee4-4a20-876b-ecb1160d0845"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("cbf1c521-494b-4981-9dc9-b6a1b229c01d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("cc2a4d3b-bae2-4602-9d23-4d4d2d918699"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("cdd52492-d981-4972-9f41-4b1774c002ee"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("cf8c2ebc-2ed1-404c-875c-d2151d54ab9e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("d0357290-582a-47cd-984c-8815d38454be"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("d1fef153-87bc-403a-9590-0ec4cc8d676e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("d200b4b5-7435-41a9-be8b-b6a80e14120b"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("d2ebac27-3463-40cb-9eb2-86e1da12a3ba"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("d34d65e5-253f-4324-9aee-f74045802e47"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("d3c10501-b94f-4a0e-b871-80d4b3d7bbbb"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("d50a063a-82ef-4b56-858e-1a8794b32878"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("d576474f-de6a-45fc-bd19-e18a2915f1a4"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("d892c6c0-bf86-4487-ab8b-5af35cc32a0c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("d94b5935-e6d2-4aa7-b9f7-d332badacd8d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("da333d92-e16c-4b49-b9d8-669df9032f82"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("dd79ead4-6e12-4cb8-aff5-8f00d8bf9e99"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("dd951a03-c803-4351-aac5-ed4ec9922bab"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("ddf4ecad-6f97-4bde-84fe-2b9dc51f0ffd"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("de0d7be8-8a87-4358-b93e-e809ab17f238"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("e180ff8a-4e49-4edd-9168-21b372b8d9b7"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("e1fc9395-73b5-4fd6-8c31-37fef3a3e866"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("e369137c-1730-4809-88e4-e43031327233"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("e3a2237c-9d57-462f-bad8-7a78856303c8"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("e43c3f5c-e8d7-430a-9869-e61337bd4188"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("e4acc3fd-7e2d-4927-b7e8-797cb8a29a86"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("e4c05566-0c8d-42a4-a2e9-ad4d6d33b35f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("e5439053-279d-4094-852d-0c2edc6992ed"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("e5837adb-d926-41f1-8434-73fed9db7504"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("e6e7518f-73eb-4010-b0cf-6dcc5c8f8e01"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("e9455b51-bd57-482f-a979-5ecf6c8c4afd"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("edb5a6e1-b084-4e46-87ab-22d38da9cf0a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("edcecb3c-ffcb-451f-8e24-02a0bf6499ae"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("ee02aa87-f8dc-44ac-9ac9-830120f05656"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("ee707e39-4195-426c-abf9-1ce21a771350"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f034e368-335c-4a9f-a039-b7ea83f8a315"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f07d3dde-aea1-4f0a-ba9d-310cda4fa6e9"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f1218849-b5cf-43c8-b3c4-b1ff145f27fc"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f1c02c7d-3154-4e55-817c-1e24f6eef729"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f21a86da-a1de-4023-93c9-3a23d315a8cd"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f36eb030-510e-4ca0-b7c4-a1c1ef656dd6"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f468cb27-57fb-4b75-b3b7-70bb33ca2705"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f5874f17-6c1e-4c07-b8bf-41b76546f6f0"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f5f9c1ed-f4fb-4cff-aee3-2bcb0d8eed3e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f5fdcb6c-e0c5-4a57-adca-e743ba60ccee"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f79baaf7-6191-4ba9-b38a-2f1b50d05598"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("f9375017-9897-4487-8916-c98d22fd05b9"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("fb10ce71-e68a-4a70-bf7e-5edee9388d48"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("fb67b422-6903-494e-945d-fa09f031b4f1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("fc5a0c05-ebac-4906-8a9f-dddcdbcc0a9d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("fd0ac376-bf65-4bf8-9067-245691aa1827"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("fd21963c-7b5e-44a8-8d70-2edbda437946"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("fd235817-1607-4f4c-83c7-ff5bd0012896"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("fd32d265-24dd-4073-a4b8-59e6358b59ed"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("fe657d37-7960-4bb3-8f15-81666fca928d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("ff78779a-45cd-4076-8c61-442a9a3873f2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("ffd3fabd-a5f1-4442-837b-d53b5d89272e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "DepartmentType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "DepartmentType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "DepartmentType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "DepartmentType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170901"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170902"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170903"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170904"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170905"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170906"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170907"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170908"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170909"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170910"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170911"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170912"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170913"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170914"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170915"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170916"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170917"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170918"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170919"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170920"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170921"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170922"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170923"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170924"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170925"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170926"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170927"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170928"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170929"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170930"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170931"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170932"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170933"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170934"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170935"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170936"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170937"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170938"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170939"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170940"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170941"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170942"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170943"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170944"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170945"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170946"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170947"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170948"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170949"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170950"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170951"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170952"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170953"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170954"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Ethnic",
                keyColumn: "Id",
                keyValue: new Guid("9c01ca1a-fb5b-4620-a217-0046c3170999"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: new Guid("97ac7fd8-edfa-4243-97fc-98468f492df1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: new Guid("e9497984-d355-41af-b917-091500956be9"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: new Guid("fc153433-bf89-4e95-8523-df3d8cec8676"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("003360aa-6adc-4e1c-8da9-fd1d1665729d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("0729fb2e-ae19-41f3-b948-b0f0c51fbf99"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("0b13943c-ead8-4e76-80b8-33b31828dd7a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("0fdfd770-bee4-4dc4-9eb5-d86816bfc2bf"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("198417f7-e503-4435-bde2-7547487c943a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("1d8b3ff0-1bbd-4fa4-a4c8-1a4e2c394a55"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("2c03541e-db56-4bcb-8012-52b0f130ca09"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("2d80dbcf-c7d5-4450-9847-e7e6f737f567"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("3035b967-95aa-46a5-be3f-b1f7bec1fd51"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("3109e53a-812d-455e-a968-e86ff499d74d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("33d6ec24-75ee-402e-b8d2-3296e90ea336"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("37d13fe4-1fd2-4268-bbae-4ab301f634c5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("38e1ffeb-7572-40c7-a716-cd880eb8d1ce"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("395f3325-851f-41ee-b652-5002ce7cf547"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("3baaffd5-90a2-471f-8581-b5969184fcbe"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("3fd18cc5-7204-42a9-a940-c5cf3128518f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("40064e04-52c1-460d-b3d3-04f4e991f82c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("46ddf496-df97-40b4-9b23-bfd17357abbe"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("4e6a7717-9e60-4bae-a2d4-d29dacd8af47"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("528fe36b-ac63-4f15-96f5-104ac221a155"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("52b17f24-a4a1-4cc6-88a0-c526ee8256c6"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("5329306e-8290-4ca4-b110-0678c20752e0"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("619d7aee-4e6a-4993-9d7a-c6e32958851f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("64a15171-a037-45b4-a55d-08ee58ce687d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("68d199cc-b739-4d61-b412-40d2242f374d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("6f51a702-3c62-4a43-8042-9cf6e8bf3186"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("702c3cf1-d0b3-4647-8d39-7549dd42f610"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("7184c251-1c62-4b69-a63f-de49e85633f0"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("72478add-ca26-4a9b-92bd-2b075006f36a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("77e4b05d-6245-43ee-ba94-84faaece9018"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("7a3c3be6-fe62-42ab-9764-f8e62d7f5916"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("7acbf3ec-7068-4007-a871-e0fee1ef28c5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("839f0efb-168d-4110-a041-60b463ae48a1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("889693ed-0453-4387-941b-d70dd4870dc5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("8eb57a8e-8281-41bb-a5ab-637dcac67177"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("8ed43986-0586-4742-8f89-a673c9f63756"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("8f0f2a47-34e4-4af3-811a-4d9c1fbf1cae"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("927f685b-f766-4bf8-93ed-ae7aabc4071c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("94dab20e-c05d-4aa9-93e9-82e972792756"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("952aa342-c05d-46d3-8ffe-6a22d7512dc2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("9c2a8569-d860-459d-8c3a-49966ea0038d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("9d49b503-ac5f-47f3-aaa2-8d18853bfba6"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("a1f48dda-f1a3-473a-b4f7-6843312303f4"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("aee0f859-e3bd-41ae-be15-17060d5ad617"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("af97b966-5b74-4580-a948-c8a9df0a5fba"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("b2035ac5-5e24-4a18-8587-62e65fd64697"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("b2cace92-0d42-4789-97c7-83ea3c3667c5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("b42cba39-912a-4400-84a5-fe15eb71766e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("b6bdda7d-b047-45a0-9d73-ffcb4e938e38"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("b6cf7563-f2be-4273-bcc7-58bb3cd4edec"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("c16dbbe1-bea2-413b-9216-5b547deac9f5"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("c30f4992-257a-4abf-abb0-2ea4b36f247f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("cd4eab40-92a3-4898-8a65-c67ccde721c0"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("da06856d-9e6c-49f7-bbed-ca2a06ca81c1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("e5a4e82b-b29d-4b47-a563-82977ea93346"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("e7fe23cb-4304-4fb0-90a5-9ff4da5048aa"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("ec0b077d-3957-4089-85f8-c1d6742aab19"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("ed0a3763-3a96-46c5-8094-c47a4708e3cb"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("ef981a1e-0af1-4b7f-9fd7-42de078e7d97"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("f06e27bf-1470-4f7a-873f-f0dc77e405e4"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("f2aac7ae-5a85-48fc-9166-d9ab6efb79ab"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("f5d76f98-2024-4c60-81ad-577359cb69d1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "Id",
                keyValue: new Guid("fa11ad72-29b7-49f4-986d-fea0d53de210"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("1376a459-2acd-42e2-a7a7-2591f74b21eb"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("1daedd7e-7ca2-4fdb-9956-4fa4c7718a79"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("3b8fbd78-7899-4b81-832a-da090f149077"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("4252af04-6cfe-4476-bb99-4a922b6bc0ad"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("694a319f-11d3-4e0e-bf68-c99aa89b8d95"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("6a46d932-03d2-477b-be50-1a5e791ecb94"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("826cfc0a-538b-4cb8-86cf-3f61b3c58a7f"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("8e15b578-7302-4e88-97aa-0b956759eaee"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("9f3e6fc7-ef22-4ba4-9e59-8cca8b6cb195"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("a08c20c4-3e67-429f-a6c8-f32aeaeb3532"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("a734da32-8028-4210-bae5-98bda97961ff"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("bcabc031-806f-452a-84da-77d554e5a5b4"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "RelativeType",
                keyColumn: "Id",
                keyValue: new Guid("ccbee237-acf6-47f2-9c39-ed544222712e"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 0, 15, 21, 635, DateTimeKind.Local).AddTicks(9102));
        }
    }
}
