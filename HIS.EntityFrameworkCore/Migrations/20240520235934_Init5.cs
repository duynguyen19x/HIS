using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPriority",
                table: "DOrder",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "TraditionalIcdCode",
                table: "DOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TraditionalIcdName",
                table: "DOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TraditionalIcdSubCode",
                table: "DOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TraditionalIcdText",
                table: "DOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReceptionID",
                table: "DExamination",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderID",
                table: "DExamination",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "AllergyHistory",
                table: "DExamination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BloodPressureHight",
                table: "DExamination",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BloodPressureLow",
                table: "DExamination",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChiefComplaint",
                table: "DExamination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Desciption",
                table: "DExamination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GeneralExam",
                table: "DExamination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Height",
                table: "DExamination",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IcdCode",
                table: "DExamination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IcdName",
                table: "DExamination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IcdSubCode",
                table: "DExamination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IcdText",
                table: "DExamination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAllergy",
                table: "DExamination",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PartExam",
                table: "DExamination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PathologicalProcess",
                table: "DExamination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Pulse",
                table: "DExamination",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "RespiratoryRate",
                table: "DExamination",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SpO2",
                table: "DExamination",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Temperature",
                table: "DExamination",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TraditionalIcdCode",
                table: "DExamination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TraditionalIcdName",
                table: "DExamination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TraditionalIcdSubCode",
                table: "DExamination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TraditionalIcdText",
                table: "DExamination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Weight",
                table: "DExamination",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SBloodRhType",
                keyColumn: "Id",
                keyValue: new Guid("0569461c-35a7-46b5-b285-d158b6729dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SBloodRhType",
                keyColumn: "Id",
                keyValue: new Guid("c8444f53-6712-4726-9b86-714b789648bb"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SBloodType",
                keyColumn: "Id",
                keyValue: new Guid("29a04857-f834-4f4a-896b-db0a829125c4"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SBloodType",
                keyColumn: "Id",
                keyValue: new Guid("96fc1f86-2e95-4aac-bb4b-bd5eb2ef09fe"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SBloodType",
                keyColumn: "Id",
                keyValue: new Guid("b5ce25e2-95a5-4a2f-ac25-b886ee18e56e"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SBloodType",
                keyColumn: "Id",
                keyValue: new Guid("be2cd126-228c-4fbf-9470-c5cb8195465b"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("27f97033-2472-46b2-ad8a-763039cac120"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("2bebf89a-f496-4da5-aabb-787c4dca82a7"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("343e6492-50e0-4f84-b323-a9411196e694"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("343e6492-50e0-4f84-b323-a9411196e695"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("343e6492-50e0-4f84-b323-a9411196e696"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("343e6492-50e0-4f84-b323-a9411196e697"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("43d31da7-5889-4fbd-94cb-4800507ac9d8"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("508ab49b-78a7-47fe-b5c9-e06589fb8126"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("824af7e8-3526-4b6f-9005-bf0fde1974a8"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("855ded87-0521-4322-93f5-69e36e3a89d8"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("89bc4bca-f38b-4808-a64d-325b03dc240c"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("9f21b51a-dd3b-4f22-b3b5-e3d6b59107ae"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("a373a40c-5097-4716-b683-4a5c3b69fe6e"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("a373a40c-5097-4716-b683-4a5c3b69fe7e"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("e17526d6-1ae3-4649-86be-e143474d3a89"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("0105cfd9-5265-4dcc-b2d8-790abecd5577"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("02cd862f-7bf2-4dee-9d8d-869f67659eac"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("05600686-62bc-4be9-b009-58ae6fac5dc2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("05f8a24e-3764-41af-b79b-3e05da6964ad"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("060539cd-d169-45c2-bec2-28a91e41bcb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("067dbcfb-9729-4016-aa0f-526f43657542"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("07c04d8d-4e1c-4896-ba8a-7d8172562b37"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("09127bf0-ff5d-4660-8fef-18b3107bf295"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("0d9bf5f6-20bb-4b4f-8c3e-0b7205eabe19"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("0f42743d-f2ae-4d4d-9e9c-6dcd785204ff"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("10a98338-7167-4e5b-b3e4-9515f63bb43d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("10f310c4-857b-431b-934c-19ebc560571c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1137907c-6292-4973-8a6a-5a8a55216701"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("16bfb332-7ffe-4d31-a2a2-05e7cc250969"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1760cdb2-5d9e-4a4d-a422-9d2d54333b72"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("18be6a2d-0cc9-4e57-9b95-0fd5e0999094"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("19b9d4e2-dd04-4d66-ba70-e71a800b8563"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1a52542a-e4e8-4514-b84f-d8f7a0ce8bf5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1bb67a2c-65b1-4437-b7db-61bb5c5c945a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1bd96043-4837-4ab4-8812-0230d7cdc37c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1c1e8f0d-fa36-4dd5-a349-51f8f8cf1e11"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1c3907c5-3cd4-4530-a28c-6d4acceec175"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1cb83a16-11a1-438b-8fd9-22e661c5904a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1cc02fda-f061-49ad-a4f1-ecb564a28c88"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1d374c8c-88c5-49ae-9c9c-0b2b362b1198"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1d41f179-ba78-41d6-8ecf-595c7d6de65a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1df44627-4127-48c0-bbc7-2afc64cb75d2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1f0c0c80-dceb-47c4-9bfb-d9e2b29e8010"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("20aa6e3b-0838-45fc-9769-161b291e5e24"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("212573b7-ec34-4844-b150-74f567de2c5d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("21668f2b-b3d0-4927-9d67-3f9eee4736d6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("22174cd0-7b2d-4c6b-bb6c-5273e63d28f0"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("226d663e-46ee-4ab2-b385-b062345debd9"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("23063395-5d36-41c9-9711-66722ab8849f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("24c5f9fa-e493-43a1-9d2a-c6d25dc2ea89"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("25b7ed9b-8bfd-4601-a4c5-a59dfe5a3fab"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("25df127f-9fb7-4f1d-8a4f-484364e15f91"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("264432ff-ba3d-4402-ae05-d3cbbdf7eef4"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("26d0e10a-43ea-4654-93be-00a21f60b760"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("298cf3d9-cf13-401f-86b5-368d1c71ec77"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("2e24284d-fe7b-477b-a3e9-23505ccbe379"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("2eab2085-d20b-4cc4-a85b-7567c9ce6ea9"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("2eb9de76-3d99-43a5-b17d-ba2f0e08c64a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("2eead3fb-8c57-4699-a48d-b9eb2a781d23"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("2f4455d6-efee-4959-8dfd-6f7db81faadd"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("2facb682-01d5-4798-bf0a-928bd471ecb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("332e0e9e-0182-47a0-b894-ade71da83708"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("33aeb885-ea5c-4343-8011-b1dccebdd65f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("347a0e24-276d-4a54-b92b-4b88b60179af"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("36299397-b100-420b-bd1b-3f18eda310fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("3671801a-1c88-4dc6-9e75-d766644c2af9"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("36ddc306-adf0-4897-a200-6377ff0d9042"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("39351753-1af5-4797-89e2-b97589db8d2e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("39ef7fcd-b539-46be-90a6-bc3f6d1524d8"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("3adb70b0-ae40-4ac0-8a27-15398cc79d49"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("3af1daa8-65e1-4502-823d-3c8530608104"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("3d9d9ca5-3356-48b3-b518-eb806a6128ee"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("3dac050e-a2a6-469b-b0bb-def2e17544a5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("3de67d92-a46e-4113-bd12-2e89a48aa1f0"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("3edffd99-5e14-4466-9f3e-a72ab48711d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("3f3e1d5e-ca7b-45ef-9e1e-f3c471e8894f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("426516a2-46e9-4103-8b44-22b4a30b21ae"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("4452efd3-9727-4c5c-9cc9-76f7270c673d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("44ff82d4-3356-4f71-9aa2-dc5f161537f0"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("45696681-b325-4d55-b4ea-56a920227907"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("4589f414-2018-4196-a42a-68fa60b41dae"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("45a0ebe0-51be-423b-8885-7a7bf06e6f95"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("46651a82-3d63-4a24-baff-9bb1ee8ac492"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("484be820-41ff-4911-94c6-2d2969764ac4"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("4b12f61e-5980-415f-a62b-b296753fd70d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("4b7309a1-de33-4f43-a2ff-3f11e0e5869b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("4bab2495-c861-47e7-82e6-1806fd87b767"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("4dbc51c5-3faa-4e76-b0d5-a28df95c5c01"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("4dcd4bda-0da9-415d-8f7e-ecd5841ad250"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("4e6e77af-56d6-4314-ac68-c39713511d70"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("50202b21-f7c0-42eb-89bd-4470e82f3943"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("502c14cb-18ea-461f-9bc0-9591b056284c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("506ddd2c-4f81-4d6d-806c-4c9e605bab3f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("509f7d40-e740-472f-8a7a-84b5a527eb96"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("50c044c3-6cd1-46ad-b10a-e879291806f2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("52595376-4b2b-4746-bb17-16f7ba234a33"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("5300fbb8-1d3b-48c2-b251-c9daab165b94"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("5351587c-9713-44c9-9088-9626d01300c8"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("539247ef-f9a9-4893-b250-2aa204a87640"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("53b7d739-4b49-4a35-9d04-93520d79d105"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("53fdbb96-c808-4474-83bc-084e422a8b95"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("54ca17f4-f6f7-4bcf-9809-8d45153c2271"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("561d896e-c3c5-4dfc-b13c-790aa25fbd5d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("5701a860-793e-4660-9302-005b27d4348e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("573dec77-5908-42b2-b1a5-8a5ee8407dee"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("57c01cf1-7f20-4a6c-bec9-bcc9a3a039fe"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("58357a87-d3a9-4ea4-82ea-eb7775f1c568"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("58486abc-86a6-4bb8-a610-eb0e4bdf0b73"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("58776bc3-ee4b-44ae-ac9e-a501437bde2f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("58d12ab1-4946-45f9-bef5-354e5803f357"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("59e93599-98e9-44de-b9d1-bbbf17c599bf"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("5a68453d-81d4-4417-a579-33d6a1c27ea6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("5b526a49-1694-4eb8-b602-4e150d12184d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("5bd03273-5b23-4181-892c-397126e8da56"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("5d60e969-8387-42e4-b866-31dfb209f433"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("5dc567de-1249-4aaa-9d49-04dcd3501220"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("5f4a7dfd-c3ed-4796-bde2-94199e595ef0"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("62947f31-4a3e-441b-a9d2-9642ce61de2f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("62b0c6c0-4a45-4f33-b35e-d184d815518e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("63c8621a-fc44-4abe-ba08-8d80520280cf"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("6477d7a3-465e-4277-a4eb-ef09b13f5eca"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("66169c75-2aa7-409a-a7b9-d8cfe6ac80c0"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("66400b32-893a-489c-a5e1-180d55fb20d4"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("66533605-d826-4aec-9536-e4d30effefda"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("665d03c6-346e-43d8-ad21-31492b4382aa"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("686b79de-db2f-4ccd-946c-1bef80cd503e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("6b24b562-1294-4537-a69a-26ac34c41521"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("6b8836aa-2476-4d82-98f1-0b7f56e66f7a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("6c408b50-b4be-4eca-a710-11a6d914cf4f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("6d2d2371-8785-4a7b-94ba-84c804b2b0a2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("6d5a6761-432b-4bd2-9b04-5e01c421de23"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("716a0688-0378-4941-af8f-c11dc4c45ac2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("720aaa71-3cc0-470f-b56c-472ac37a6574"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("72d527d4-00df-4f9a-b0e1-e1fa84a4ba6d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("74c266fd-7287-4525-aca3-6bb66ddcf61f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("75de9dea-ef0f-4492-890a-f5af36cce7aa"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("76c42f0f-bfb2-4a11-b5a4-e854f74e72cd"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("77365013-80d7-44d5-bd8d-472542cac431"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("788693d2-4ac9-4f85-94bf-13d021bc000d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("78dcfd52-de7b-4c1d-9ded-0e5d3f7a8a35"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("79bc1ba0-a0f6-4065-9783-9e01ade32cde"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("7a384197-d55e-44b8-b389-a65f17e74e1f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("7af80a81-41e5-47de-abd3-7ce25f9c39b4"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("7afaefc0-9aa8-4ba7-98ae-618682a5be7f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("7b0c9a9c-e730-4b96-9372-e9ef8ab5339b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("7bea406c-221d-45dd-aca6-a2ceb90741aa"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("7e27cb42-41fb-4b20-b26b-3c1ea9b4ff5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("7ef68b6d-2d6b-4688-95bc-d0fd79ffb6c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("7f233816-fe94-4941-8125-b62c88410fa9"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("8562fd7f-49aa-46cf-bbc9-71f7460c6ba7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("8592d87f-720b-48e7-82ee-e82d64cbf984"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("8764ee96-c950-44cf-a1f4-7636126c671b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("882c80ef-806d-4370-9fb1-f00a13a7a5c1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("8a003437-323c-451c-b211-1886f79c25f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("8a6a8442-1533-4bba-9a05-ed707122573e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("8f800608-e254-418d-8163-78f71be4873f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("8ff51ea0-476b-4dec-8736-70cc36ea1d2c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("90b2a6a0-bacd-4175-80e9-b8fde9233786"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("90ef0553-8520-4d57-ae3b-112ebf28b313"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("92aea1da-5cf2-40fa-92a2-cce297949451"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("92b69f82-f3e2-4ea9-9d4b-1763b1a75dec"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("93fc49be-bd23-41c3-8538-4b424a7806da"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("9412c9e0-c4fe-442f-8b13-ea064bf48703"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("9601fc62-41b1-44af-af8e-8a03c91c96b8"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("97bc234b-7d4c-4870-801b-74f1998741be"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("98062645-5015-4d8c-886e-3fb70c247ada"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("994cf06f-b833-4415-84e0-94f3847b6dd8"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("99cfce62-6540-4525-97b8-9a2e62618e05"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("9acb769e-d2de-479c-b66a-424ce710a036"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("9d5769fe-b3ae-4697-9150-44674e8008ba"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("9ded845f-06a1-4651-8903-bc46f7978c84"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("9eb57842-f592-4080-affd-71b43f7d0517"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("9ee7b166-4c6f-4136-8928-c6246c3e76d5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("a1080c01-e5bb-4e3f-8784-f0678f1eff58"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("a1ba5be8-fef9-470a-a5f7-efcf7fc900a4"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("a1f120ed-4785-486e-b796-dd8cd569a415"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("a30f588b-166d-4118-9d33-b8294e15ad44"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("a3597652-cc84-40ff-b143-208ee8473e93"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("a3c5c224-a013-4e23-8655-641a0a76b38a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("a695b824-cfc2-40a3-b5a1-35243a6e2116"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("a7a696de-3fd8-48c2-b87a-6464b222af87"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("a8b38e56-d3ea-435f-907a-615ed7ced805"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("aa3d56b9-f398-4be1-b8ae-9f8563101b6e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("aa4399ec-1ff3-4837-a68e-0df0720162cb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("aa745539-b444-49d2-ad13-14149f8a1645"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("ab16a3ed-00cd-4445-8e7c-770b1965232e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("abdfeb5b-a4b8-4ab1-b6b8-83f7fb72ec23"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("ad4ef5f1-e823-4ed4-9ad5-cec4a2cae6af"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("af24512b-01ae-4420-96cb-62051ede96cc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("af3badc9-b6da-4eb0-8a42-ecf8dfd6ae19"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("af9c2425-679e-4459-8c68-2d357f4f93e5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("affdf19e-5ed4-497a-97d0-0fc95a547785"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("b16a509f-5c70-42b1-a05e-6d4426c721ca"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("b171e933-4b7d-46f5-802a-14c5c9234ed7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("b1829e62-c3dd-4f65-8c41-fdbe26aedb93"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("b4e019b1-042b-465c-baf9-60d525d9b85c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("b6169a90-920f-425d-a275-82601862a220"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("b83926c4-6963-4f82-97f7-dffa6e87ea7d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("b83be42b-cde9-4dc3-a838-d8197d2c678f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("ba7304bd-7e25-4731-a60f-10c13589c71a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("ba947c48-36fb-420b-b2d9-663fe308b18c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("bcb96598-0e05-4316-86d3-80413326555a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("be946a16-a1af-499c-9bd8-ca12a22fb69c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("bf1bf333-4604-4974-838f-886100c006f3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("c4065df0-2539-4046-bb77-7d699a072734"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("c5c14db2-753f-4e28-88b5-3b9e502fa0c6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("c6f6287f-39f6-4470-ad46-ac539eef3052"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("c7f500b0-be15-4ab8-ae5c-1db430d19b8c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("c831fb16-910b-4939-804a-1052b8f8adc1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("c8766416-ed13-4631-a9c4-e89e782055c9"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("cba207c9-9ee4-4a20-876b-ecb1160d0845"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("cbf1c521-494b-4981-9dc9-b6a1b229c01d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("cc2a4d3b-bae2-4602-9d23-4d4d2d918699"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("cdd52492-d981-4972-9f41-4b1774c002ee"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("cf8c2ebc-2ed1-404c-875c-d2151d54ab9e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("d0357290-582a-47cd-984c-8815d38454be"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("d1fef153-87bc-403a-9590-0ec4cc8d676e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("d200b4b5-7435-41a9-be8b-b6a80e14120b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("d2ebac27-3463-40cb-9eb2-86e1da12a3ba"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("d34d65e5-253f-4324-9aee-f74045802e47"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("d3c10501-b94f-4a0e-b871-80d4b3d7bbbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("d50a063a-82ef-4b56-858e-1a8794b32878"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("d576474f-de6a-45fc-bd19-e18a2915f1a4"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("d892c6c0-bf86-4487-ab8b-5af35cc32a0c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("d94b5935-e6d2-4aa7-b9f7-d332badacd8d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("da333d92-e16c-4b49-b9d8-669df9032f82"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("dd79ead4-6e12-4cb8-aff5-8f00d8bf9e99"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("dd951a03-c803-4351-aac5-ed4ec9922bab"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("ddf4ecad-6f97-4bde-84fe-2b9dc51f0ffd"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("de0d7be8-8a87-4358-b93e-e809ab17f238"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("e180ff8a-4e49-4edd-9168-21b372b8d9b7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("e1fc9395-73b5-4fd6-8c31-37fef3a3e866"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("e369137c-1730-4809-88e4-e43031327233"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("e3a2237c-9d57-462f-bad8-7a78856303c8"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("e43c3f5c-e8d7-430a-9869-e61337bd4188"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("e4acc3fd-7e2d-4927-b7e8-797cb8a29a86"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("e4c05566-0c8d-42a4-a2e9-ad4d6d33b35f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("e5439053-279d-4094-852d-0c2edc6992ed"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("e5837adb-d926-41f1-8434-73fed9db7504"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("e6e7518f-73eb-4010-b0cf-6dcc5c8f8e01"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("e9455b51-bd57-482f-a979-5ecf6c8c4afd"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("edb5a6e1-b084-4e46-87ab-22d38da9cf0a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("edcecb3c-ffcb-451f-8e24-02a0bf6499ae"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("ee02aa87-f8dc-44ac-9ac9-830120f05656"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("ee707e39-4195-426c-abf9-1ce21a771350"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f034e368-335c-4a9f-a039-b7ea83f8a315"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f07d3dde-aea1-4f0a-ba9d-310cda4fa6e9"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f1218849-b5cf-43c8-b3c4-b1ff145f27fc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f1c02c7d-3154-4e55-817c-1e24f6eef729"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f21a86da-a1de-4023-93c9-3a23d315a8cd"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f36eb030-510e-4ca0-b7c4-a1c1ef656dd6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f468cb27-57fb-4b75-b3b7-70bb33ca2705"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f5874f17-6c1e-4c07-b8bf-41b76546f6f0"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f5f9c1ed-f4fb-4cff-aee3-2bcb0d8eed3e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f5fdcb6c-e0c5-4a57-adca-e743ba60ccee"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f79baaf7-6191-4ba9-b38a-2f1b50d05598"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f9375017-9897-4487-8916-c98d22fd05b9"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("fb10ce71-e68a-4a70-bf7e-5edee9388d48"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("fb67b422-6903-494e-945d-fa09f031b4f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("fc5a0c05-ebac-4906-8a9f-dddcdbcc0a9d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("fd0ac376-bf65-4bf8-9067-245691aa1827"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("fd21963c-7b5e-44a8-8d70-2edbda437946"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("fd235817-1607-4f4c-83c7-ff5bd0012896"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("fd32d265-24dd-4073-a4b8-59e6358b59ed"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("fe657d37-7960-4bb3-8f15-81666fca928d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("ff78779a-45cd-4076-8c61-442a9a3873f2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("ffd3fabd-a5f1-4442-837b-d53b5d89272e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 813, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "SDeathCause",
                keyColumn: "Id",
                keyValue: new Guid("4333ca55-4d7c-4be0-b9a2-2125624f0229"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SDeathCause",
                keyColumn: "Id",
                keyValue: new Guid("4d5b5c50-6be0-434e-8baa-a528af4a58b5"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SDeathCause",
                keyColumn: "Id",
                keyValue: new Guid("c0a4d767-7ba9-4006-a0a9-020b6322c2ef"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SDeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("66c3a43b-f9d0-4876-81e2-b13c5f188589"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SDeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("7693d6ec-cf0f-44c1-a9d7-fb997335ae10"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SDeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("8f2b1eeb-a4bd-4f84-b59c-98145c58b1ab"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SDeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("f91d8342-619c-435b-b51c-8b3d7f541222"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SDepartmentType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 814, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "SDepartmentType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 814, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "SDepartmentType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 814, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "SDepartmentType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 814, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("010bc204-87e6-4e5f-9e82-79f5a0fc4d04"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("12518ef2-bc95-4a4d-8991-727782426ba8"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("33a82ea4-7aeb-4d08-9ca9-2cb5f06adefb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("4d28238a-1d66-4dca-ae09-5104b16c5eef"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("506d29ff-5cba-4d14-a341-375ed320e229"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d501"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d502"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d503"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d504"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d505"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d506"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d507"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d508"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d509"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("5cf104df-c5e5-43bf-9aad-89eb8236092b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("7a19295e-ddfc-4aaa-bee3-edb7c6aeddf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("9f693f27-fe31-435b-be4e-0bb17dbaf8b7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("a1f6effe-c174-4fc0-ad02-32b32ca51a20"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("c68ed451-7361-48a9-9f1e-9ad4c1b1bb58"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("ecdeb90d-8bc9-43ee-a233-d1fdc543b11b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("ef1439e7-3dfa-40d3-a8de-a0da87140b45"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("ef1439e7-3dfa-40d3-a8de-a0da87140b46"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("ef1439e7-3dfa-40d3-a8de-a0da87140b47"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("ef1439e7-3dfa-40d3-a8de-a0da87140b48"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("f3a6bcbb-8f93-49da-85e7-e9b07ed72980"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("f3a6bcbb-8f93-49da-85e7-e9b07ed72986"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("f3a6bcbb-8f93-49da-85e7-e9b07ed72987"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("f3a6bcbb-8f93-49da-85e7-e9b07ed72988"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("f3a6bcbb-8f93-49da-85e7-e9b07ed72989"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("fdbacab7-ca1b-4765-b95d-84fac353a648"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 815, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "SGender",
                keyColumn: "Id",
                keyValue: new Guid("97ac7fd8-edfa-4243-97fc-98468f492df1"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SGender",
                keyColumn: "Id",
                keyValue: new Guid("e9497984-d355-41af-b917-091500956be9"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SGender",
                keyColumn: "Id",
                keyValue: new Guid("fc153433-bf89-4e95-8523-df3d8cec8676"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SInvoiceType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "SInvoiceType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "SInvoiceType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "SInvoiceType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "SLiveArea",
                keyColumn: "Id",
                keyValue: new Guid("0a14bae0-eeb9-48b3-b49e-b3bb5b1492b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "SLiveArea",
                keyColumn: "Id",
                keyValue: new Guid("b3eb4635-31ff-4e3f-b55f-a02150017bd7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "SLiveArea",
                keyColumn: "Id",
                keyValue: new Guid("ddb7f2cd-be11-495b-80c0-51295e2066b9"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordTypeGroup",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordTypeGroup",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordTypeGroup",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 816, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "SPatientObjectType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 814, DateTimeKind.Local).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "SPatientObjectType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 814, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "SPatientObjectType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 814, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "SPatientObjectType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 814, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "SPatientObjectType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 814, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "SPaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("0b348363-c888-4c9a-b145-c3389fdcca37"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "SPaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("8bff9824-1df2-419e-88ab-e098a6fc4e7e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "SPaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("dd39afc0-1de0-4287-a126-4dada6788508"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("003360aa-6adc-4e1c-8da9-fd1d1665729d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("0729fb2e-ae19-41f3-b948-b0f0c51fbf99"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("0b13943c-ead8-4e76-80b8-33b31828dd7a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("0fdfd770-bee4-4dc4-9eb5-d86816bfc2bf"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("198417f7-e503-4435-bde2-7547487c943a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("1d8b3ff0-1bbd-4fa4-a4c8-1a4e2c394a55"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("2c03541e-db56-4bcb-8012-52b0f130ca09"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("2d80dbcf-c7d5-4450-9847-e7e6f737f567"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("3035b967-95aa-46a5-be3f-b1f7bec1fd51"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("3109e53a-812d-455e-a968-e86ff499d74d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("33d6ec24-75ee-402e-b8d2-3296e90ea336"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("37d13fe4-1fd2-4268-bbae-4ab301f634c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("38e1ffeb-7572-40c7-a716-cd880eb8d1ce"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("395f3325-851f-41ee-b652-5002ce7cf547"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("3baaffd5-90a2-471f-8581-b5969184fcbe"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("3fd18cc5-7204-42a9-a940-c5cf3128518f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("40064e04-52c1-460d-b3d3-04f4e991f82c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("46ddf496-df97-40b4-9b23-bfd17357abbe"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("4e6a7717-9e60-4bae-a2d4-d29dacd8af47"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("528fe36b-ac63-4f15-96f5-104ac221a155"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("52b17f24-a4a1-4cc6-88a0-c526ee8256c6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("5329306e-8290-4ca4-b110-0678c20752e0"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("619d7aee-4e6a-4993-9d7a-c6e32958851f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("64a15171-a037-45b4-a55d-08ee58ce687d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("68d199cc-b739-4d61-b412-40d2242f374d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("6f51a702-3c62-4a43-8042-9cf6e8bf3186"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("702c3cf1-d0b3-4647-8d39-7549dd42f610"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("7184c251-1c62-4b69-a63f-de49e85633f0"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("72478add-ca26-4a9b-92bd-2b075006f36a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("77e4b05d-6245-43ee-ba94-84faaece9018"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("7a3c3be6-fe62-42ab-9764-f8e62d7f5916"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("7acbf3ec-7068-4007-a871-e0fee1ef28c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("839f0efb-168d-4110-a041-60b463ae48a1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("889693ed-0453-4387-941b-d70dd4870dc5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("8eb57a8e-8281-41bb-a5ab-637dcac67177"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("8ed43986-0586-4742-8f89-a673c9f63756"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("8f0f2a47-34e4-4af3-811a-4d9c1fbf1cae"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("927f685b-f766-4bf8-93ed-ae7aabc4071c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("94dab20e-c05d-4aa9-93e9-82e972792756"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("952aa342-c05d-46d3-8ffe-6a22d7512dc2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("9c2a8569-d860-459d-8c3a-49966ea0038d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("9d49b503-ac5f-47f3-aaa2-8d18853bfba6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("a1f48dda-f1a3-473a-b4f7-6843312303f4"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("aee0f859-e3bd-41ae-be15-17060d5ad617"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("af97b966-5b74-4580-a948-c8a9df0a5fba"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("b2035ac5-5e24-4a18-8587-62e65fd64697"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("b2cace92-0d42-4789-97c7-83ea3c3667c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("b42cba39-912a-4400-84a5-fe15eb71766e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("b6bdda7d-b047-45a0-9d73-ffcb4e938e38"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("b6cf7563-f2be-4273-bcc7-58bb3cd4edec"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("c16dbbe1-bea2-413b-9216-5b547deac9f5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("c30f4992-257a-4abf-abb0-2ea4b36f247f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("cd4eab40-92a3-4898-8a65-c67ccde721c0"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("da06856d-9e6c-49f7-bbed-ca2a06ca81c1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("e5a4e82b-b29d-4b47-a563-82977ea93346"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("e7fe23cb-4304-4fb0-90a5-9ff4da5048aa"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("ec0b077d-3957-4089-85f8-c1d6742aab19"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("ed0a3763-3a96-46c5-8094-c47a4708e3cb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("ef981a1e-0af1-4b7f-9fd7-42de078e7d97"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("f06e27bf-1470-4f7a-873f-f0dc77e405e4"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("f2aac7ae-5a85-48fc-9166-d9ab6efb79ab"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("f5d76f98-2024-4c60-81ad-577359cb69d1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("fa11ad72-29b7-49f4-986d-fea0d53de210"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "SReceptionObjectType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "SReceptionObjectType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f01"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f02"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f03"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f04"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f05"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f06"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f07"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f08"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f09"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f10"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f11"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f12"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f13"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f14"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f15"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f99"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "SRightRouteType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "SRightRouteType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "SRightRouteType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "SRightRouteType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "SRightRouteType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "SRightRouteType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "SRightRouteType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 817, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "STransferForm",
                keyColumn: "Id",
                keyValue: new Guid("32848bde-d01c-4d6b-b3a0-2104df2d801c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 818, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "STransferForm",
                keyColumn: "Id",
                keyValue: new Guid("48cac582-b5f8-4f12-bb5b-5f35ca4fcac1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 818, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "STransferForm",
                keyColumn: "Id",
                keyValue: new Guid("b882e676-a760-4468-a687-600770326aac"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 818, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "STransferForm",
                keyColumn: "Id",
                keyValue: new Guid("faf04fde-6dc1-4d6a-b5d8-b9000bb4f6bd"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 818, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "STransferReason",
                keyColumn: "Id",
                keyValue: new Guid("14f21e7e-54d2-40af-ab18-417468e1cadb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 819, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "STransferReason",
                keyColumn: "Id",
                keyValue: new Guid("d6fa811f-0ea0-4303-bb6c-6bdcb7d18970"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 819, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 819, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 819, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 819, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 819, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 819, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 819, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 819, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 819, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 819, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 819, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 819, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 819, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 819, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 819, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "STreatmentResult",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 819, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "STreatmentResult",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 819, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "STreatmentResult",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 819, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "STreatmentResult",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 819, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "STreatmentResult",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 819, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "STreatmentResult",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 819, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "SUser",
                keyColumn: "Id",
                keyValue: new Guid("3382be1c-2836-4246-99db-c4e1c781e868"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 825, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "SUser",
                keyColumn: "Id",
                keyValue: new Guid("49ba7fd4-2edb-4482-a419-00c81f023f5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 825, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("1594388c-53a1-4d34-81ab-40af3225936f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("18f45f82-55c4-4809-97cf-65f779b926d1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("18f45f82-55c4-4809-97cf-65f779b926d2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("18f45f82-55c4-4809-97cf-65f779b926d3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("18f45f82-55c4-4809-97cf-65f779b926d4"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("18f45f82-55c4-4809-97cf-65f779b926d5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("26cd9859-9e70-4a42-9979-b7d9027c96fd"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("4dd47dfb-9ca8-4ae6-b958-13edf873dc28"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a51d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a52d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a53d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a54d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a55d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a56d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a57d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a58d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("622ff091-9851-46e8-9716-c355c21d4369"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("7d55b7a9-b5ef-46e4-9a58-9b31e77108d8"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("803d0bc0-278b-42e1-b1bc-623e09920f17"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("8a736b6f-0697-4486-9516-e30cc5c56b98"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("8b10a136-54e8-464b-b6a8-3fb6028bee0e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("8d55eb0d-5c0a-40d1-9684-409868c6f393"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("8dbd4edd-06ce-40a6-a791-16cf3922523a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("910fa544-1584-4dfc-b450-4d230f0847a9"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("94ba5688-cf4d-454a-acc1-8fee10552375"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("b15d7c09-6930-43ce-bb4b-347740ed7096"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("c95d5e0e-7244-4f7f-bc1b-640eba36c54e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("d0a93335-cd08-46e6-8cef-8de70d076ed0"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("d77c97d4-1e36-4c41-bd8f-f8e6209aeb0c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("e6b212d7-d687-4d63-82a5-18920238da18"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("eb2e1424-b66c-41ae-9c5c-57757eb1224b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("f44abb45-6010-4b0e-a442-5dafbeb4f40c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 6, 59, 32, 820, DateTimeKind.Local).AddTicks(2133));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPriority",
                table: "DOrder");

            migrationBuilder.DropColumn(
                name: "TraditionalIcdCode",
                table: "DOrder");

            migrationBuilder.DropColumn(
                name: "TraditionalIcdName",
                table: "DOrder");

            migrationBuilder.DropColumn(
                name: "TraditionalIcdSubCode",
                table: "DOrder");

            migrationBuilder.DropColumn(
                name: "TraditionalIcdText",
                table: "DOrder");

            migrationBuilder.DropColumn(
                name: "AllergyHistory",
                table: "DExamination");

            migrationBuilder.DropColumn(
                name: "BloodPressureHight",
                table: "DExamination");

            migrationBuilder.DropColumn(
                name: "BloodPressureLow",
                table: "DExamination");

            migrationBuilder.DropColumn(
                name: "ChiefComplaint",
                table: "DExamination");

            migrationBuilder.DropColumn(
                name: "Desciption",
                table: "DExamination");

            migrationBuilder.DropColumn(
                name: "GeneralExam",
                table: "DExamination");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "DExamination");

            migrationBuilder.DropColumn(
                name: "IcdCode",
                table: "DExamination");

            migrationBuilder.DropColumn(
                name: "IcdName",
                table: "DExamination");

            migrationBuilder.DropColumn(
                name: "IcdSubCode",
                table: "DExamination");

            migrationBuilder.DropColumn(
                name: "IcdText",
                table: "DExamination");

            migrationBuilder.DropColumn(
                name: "IsAllergy",
                table: "DExamination");

            migrationBuilder.DropColumn(
                name: "PartExam",
                table: "DExamination");

            migrationBuilder.DropColumn(
                name: "PathologicalProcess",
                table: "DExamination");

            migrationBuilder.DropColumn(
                name: "Pulse",
                table: "DExamination");

            migrationBuilder.DropColumn(
                name: "RespiratoryRate",
                table: "DExamination");

            migrationBuilder.DropColumn(
                name: "SpO2",
                table: "DExamination");

            migrationBuilder.DropColumn(
                name: "Temperature",
                table: "DExamination");

            migrationBuilder.DropColumn(
                name: "TraditionalIcdCode",
                table: "DExamination");

            migrationBuilder.DropColumn(
                name: "TraditionalIcdName",
                table: "DExamination");

            migrationBuilder.DropColumn(
                name: "TraditionalIcdSubCode",
                table: "DExamination");

            migrationBuilder.DropColumn(
                name: "TraditionalIcdText",
                table: "DExamination");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "DExamination");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReceptionID",
                table: "DExamination",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderID",
                table: "DExamination",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "SBloodRhType",
                keyColumn: "Id",
                keyValue: new Guid("0569461c-35a7-46b5-b285-d158b6729dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "SBloodRhType",
                keyColumn: "Id",
                keyValue: new Guid("c8444f53-6712-4726-9b86-714b789648bb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "SBloodType",
                keyColumn: "Id",
                keyValue: new Guid("29a04857-f834-4f4a-896b-db0a829125c4"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "SBloodType",
                keyColumn: "Id",
                keyValue: new Guid("96fc1f86-2e95-4aac-bb4b-bd5eb2ef09fe"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "SBloodType",
                keyColumn: "Id",
                keyValue: new Guid("b5ce25e2-95a5-4a2f-ac25-b886ee18e56e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "SBloodType",
                keyColumn: "Id",
                keyValue: new Guid("be2cd126-228c-4fbf-9470-c5cb8195465b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("27f97033-2472-46b2-ad8a-763039cac120"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("2bebf89a-f496-4da5-aabb-787c4dca82a7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("343e6492-50e0-4f84-b323-a9411196e694"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("343e6492-50e0-4f84-b323-a9411196e695"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("343e6492-50e0-4f84-b323-a9411196e696"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("343e6492-50e0-4f84-b323-a9411196e697"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("43d31da7-5889-4fbd-94cb-4800507ac9d8"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("508ab49b-78a7-47fe-b5c9-e06589fb8126"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("824af7e8-3526-4b6f-9005-bf0fde1974a8"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("855ded87-0521-4322-93f5-69e36e3a89d8"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("89bc4bca-f38b-4808-a64d-325b03dc240c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("9f21b51a-dd3b-4f22-b3b5-e3d6b59107ae"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("a373a40c-5097-4716-b683-4a5c3b69fe6e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("a373a40c-5097-4716-b683-4a5c3b69fe7e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "SCareer",
                keyColumn: "Id",
                keyValue: new Guid("e17526d6-1ae3-4649-86be-e143474d3a89"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("0105cfd9-5265-4dcc-b2d8-790abecd5577"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("02cd862f-7bf2-4dee-9d8d-869f67659eac"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("05600686-62bc-4be9-b009-58ae6fac5dc2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("05f8a24e-3764-41af-b79b-3e05da6964ad"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("060539cd-d169-45c2-bec2-28a91e41bcb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("067dbcfb-9729-4016-aa0f-526f43657542"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("07c04d8d-4e1c-4896-ba8a-7d8172562b37"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("09127bf0-ff5d-4660-8fef-18b3107bf295"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("0d9bf5f6-20bb-4b4f-8c3e-0b7205eabe19"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("0f42743d-f2ae-4d4d-9e9c-6dcd785204ff"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("10a98338-7167-4e5b-b3e4-9515f63bb43d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("10f310c4-857b-431b-934c-19ebc560571c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1137907c-6292-4973-8a6a-5a8a55216701"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("16bfb332-7ffe-4d31-a2a2-05e7cc250969"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1760cdb2-5d9e-4a4d-a422-9d2d54333b72"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("18be6a2d-0cc9-4e57-9b95-0fd5e0999094"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("19b9d4e2-dd04-4d66-ba70-e71a800b8563"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1a52542a-e4e8-4514-b84f-d8f7a0ce8bf5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1bb67a2c-65b1-4437-b7db-61bb5c5c945a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1bd96043-4837-4ab4-8812-0230d7cdc37c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1c1e8f0d-fa36-4dd5-a349-51f8f8cf1e11"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1c3907c5-3cd4-4530-a28c-6d4acceec175"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1cb83a16-11a1-438b-8fd9-22e661c5904a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1cc02fda-f061-49ad-a4f1-ecb564a28c88"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1d374c8c-88c5-49ae-9c9c-0b2b362b1198"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1d41f179-ba78-41d6-8ecf-595c7d6de65a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1df44627-4127-48c0-bbc7-2afc64cb75d2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("1f0c0c80-dceb-47c4-9bfb-d9e2b29e8010"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("20aa6e3b-0838-45fc-9769-161b291e5e24"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("212573b7-ec34-4844-b150-74f567de2c5d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("21668f2b-b3d0-4927-9d67-3f9eee4736d6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("22174cd0-7b2d-4c6b-bb6c-5273e63d28f0"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("226d663e-46ee-4ab2-b385-b062345debd9"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("23063395-5d36-41c9-9711-66722ab8849f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("24c5f9fa-e493-43a1-9d2a-c6d25dc2ea89"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("25b7ed9b-8bfd-4601-a4c5-a59dfe5a3fab"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("25df127f-9fb7-4f1d-8a4f-484364e15f91"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("264432ff-ba3d-4402-ae05-d3cbbdf7eef4"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("26d0e10a-43ea-4654-93be-00a21f60b760"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("298cf3d9-cf13-401f-86b5-368d1c71ec77"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("2e24284d-fe7b-477b-a3e9-23505ccbe379"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("2eab2085-d20b-4cc4-a85b-7567c9ce6ea9"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("2eb9de76-3d99-43a5-b17d-ba2f0e08c64a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("2eead3fb-8c57-4699-a48d-b9eb2a781d23"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("2f4455d6-efee-4959-8dfd-6f7db81faadd"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("2facb682-01d5-4798-bf0a-928bd471ecb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("332e0e9e-0182-47a0-b894-ade71da83708"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("33aeb885-ea5c-4343-8011-b1dccebdd65f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("347a0e24-276d-4a54-b92b-4b88b60179af"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("36299397-b100-420b-bd1b-3f18eda310fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("3671801a-1c88-4dc6-9e75-d766644c2af9"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("36ddc306-adf0-4897-a200-6377ff0d9042"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("39351753-1af5-4797-89e2-b97589db8d2e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("39ef7fcd-b539-46be-90a6-bc3f6d1524d8"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("3adb70b0-ae40-4ac0-8a27-15398cc79d49"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("3af1daa8-65e1-4502-823d-3c8530608104"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("3d9d9ca5-3356-48b3-b518-eb806a6128ee"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("3dac050e-a2a6-469b-b0bb-def2e17544a5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("3de67d92-a46e-4113-bd12-2e89a48aa1f0"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("3edffd99-5e14-4466-9f3e-a72ab48711d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("3f3e1d5e-ca7b-45ef-9e1e-f3c471e8894f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("426516a2-46e9-4103-8b44-22b4a30b21ae"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("4452efd3-9727-4c5c-9cc9-76f7270c673d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("44ff82d4-3356-4f71-9aa2-dc5f161537f0"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("45696681-b325-4d55-b4ea-56a920227907"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("4589f414-2018-4196-a42a-68fa60b41dae"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("45a0ebe0-51be-423b-8885-7a7bf06e6f95"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("46651a82-3d63-4a24-baff-9bb1ee8ac492"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("484be820-41ff-4911-94c6-2d2969764ac4"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("4b12f61e-5980-415f-a62b-b296753fd70d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("4b7309a1-de33-4f43-a2ff-3f11e0e5869b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("4bab2495-c861-47e7-82e6-1806fd87b767"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("4dbc51c5-3faa-4e76-b0d5-a28df95c5c01"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("4dcd4bda-0da9-415d-8f7e-ecd5841ad250"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("4e6e77af-56d6-4314-ac68-c39713511d70"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("50202b21-f7c0-42eb-89bd-4470e82f3943"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("502c14cb-18ea-461f-9bc0-9591b056284c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("506ddd2c-4f81-4d6d-806c-4c9e605bab3f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("509f7d40-e740-472f-8a7a-84b5a527eb96"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("50c044c3-6cd1-46ad-b10a-e879291806f2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("52595376-4b2b-4746-bb17-16f7ba234a33"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("5300fbb8-1d3b-48c2-b251-c9daab165b94"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("5351587c-9713-44c9-9088-9626d01300c8"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("539247ef-f9a9-4893-b250-2aa204a87640"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("53b7d739-4b49-4a35-9d04-93520d79d105"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("53fdbb96-c808-4474-83bc-084e422a8b95"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("54ca17f4-f6f7-4bcf-9809-8d45153c2271"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("561d896e-c3c5-4dfc-b13c-790aa25fbd5d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("5701a860-793e-4660-9302-005b27d4348e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("573dec77-5908-42b2-b1a5-8a5ee8407dee"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("57c01cf1-7f20-4a6c-bec9-bcc9a3a039fe"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("58357a87-d3a9-4ea4-82ea-eb7775f1c568"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("58486abc-86a6-4bb8-a610-eb0e4bdf0b73"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("58776bc3-ee4b-44ae-ac9e-a501437bde2f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("58d12ab1-4946-45f9-bef5-354e5803f357"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("59e93599-98e9-44de-b9d1-bbbf17c599bf"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("5a68453d-81d4-4417-a579-33d6a1c27ea6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("5b526a49-1694-4eb8-b602-4e150d12184d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("5bd03273-5b23-4181-892c-397126e8da56"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("5d60e969-8387-42e4-b866-31dfb209f433"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("5dc567de-1249-4aaa-9d49-04dcd3501220"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("5f4a7dfd-c3ed-4796-bde2-94199e595ef0"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("62947f31-4a3e-441b-a9d2-9642ce61de2f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("62b0c6c0-4a45-4f33-b35e-d184d815518e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("63c8621a-fc44-4abe-ba08-8d80520280cf"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("6477d7a3-465e-4277-a4eb-ef09b13f5eca"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("66169c75-2aa7-409a-a7b9-d8cfe6ac80c0"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("66400b32-893a-489c-a5e1-180d55fb20d4"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("66533605-d826-4aec-9536-e4d30effefda"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("665d03c6-346e-43d8-ad21-31492b4382aa"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("686b79de-db2f-4ccd-946c-1bef80cd503e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("6b24b562-1294-4537-a69a-26ac34c41521"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("6b8836aa-2476-4d82-98f1-0b7f56e66f7a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("6c408b50-b4be-4eca-a710-11a6d914cf4f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("6d2d2371-8785-4a7b-94ba-84c804b2b0a2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("6d5a6761-432b-4bd2-9b04-5e01c421de23"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("716a0688-0378-4941-af8f-c11dc4c45ac2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("720aaa71-3cc0-470f-b56c-472ac37a6574"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("72d527d4-00df-4f9a-b0e1-e1fa84a4ba6d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("74c266fd-7287-4525-aca3-6bb66ddcf61f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("75de9dea-ef0f-4492-890a-f5af36cce7aa"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("76c42f0f-bfb2-4a11-b5a4-e854f74e72cd"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("77365013-80d7-44d5-bd8d-472542cac431"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("788693d2-4ac9-4f85-94bf-13d021bc000d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("78dcfd52-de7b-4c1d-9ded-0e5d3f7a8a35"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("79bc1ba0-a0f6-4065-9783-9e01ade32cde"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("7a384197-d55e-44b8-b389-a65f17e74e1f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("7af80a81-41e5-47de-abd3-7ce25f9c39b4"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("7afaefc0-9aa8-4ba7-98ae-618682a5be7f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("7b0c9a9c-e730-4b96-9372-e9ef8ab5339b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("7bea406c-221d-45dd-aca6-a2ceb90741aa"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("7e27cb42-41fb-4b20-b26b-3c1ea9b4ff5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("7ef68b6d-2d6b-4688-95bc-d0fd79ffb6c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("7f233816-fe94-4941-8125-b62c88410fa9"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("8562fd7f-49aa-46cf-bbc9-71f7460c6ba7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("8592d87f-720b-48e7-82ee-e82d64cbf984"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("8764ee96-c950-44cf-a1f4-7636126c671b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("882c80ef-806d-4370-9fb1-f00a13a7a5c1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("8a003437-323c-451c-b211-1886f79c25f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("8a6a8442-1533-4bba-9a05-ed707122573e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("8f800608-e254-418d-8163-78f71be4873f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("8ff51ea0-476b-4dec-8736-70cc36ea1d2c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("90b2a6a0-bacd-4175-80e9-b8fde9233786"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("90ef0553-8520-4d57-ae3b-112ebf28b313"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("92aea1da-5cf2-40fa-92a2-cce297949451"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("92b69f82-f3e2-4ea9-9d4b-1763b1a75dec"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("93fc49be-bd23-41c3-8538-4b424a7806da"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("9412c9e0-c4fe-442f-8b13-ea064bf48703"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("9601fc62-41b1-44af-af8e-8a03c91c96b8"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("97bc234b-7d4c-4870-801b-74f1998741be"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("98062645-5015-4d8c-886e-3fb70c247ada"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("994cf06f-b833-4415-84e0-94f3847b6dd8"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("99cfce62-6540-4525-97b8-9a2e62618e05"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("9acb769e-d2de-479c-b66a-424ce710a036"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("9d5769fe-b3ae-4697-9150-44674e8008ba"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("9ded845f-06a1-4651-8903-bc46f7978c84"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("9eb57842-f592-4080-affd-71b43f7d0517"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("9ee7b166-4c6f-4136-8928-c6246c3e76d5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("a1080c01-e5bb-4e3f-8784-f0678f1eff58"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("a1ba5be8-fef9-470a-a5f7-efcf7fc900a4"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("a1f120ed-4785-486e-b796-dd8cd569a415"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("a30f588b-166d-4118-9d33-b8294e15ad44"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("a3597652-cc84-40ff-b143-208ee8473e93"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("a3c5c224-a013-4e23-8655-641a0a76b38a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("a695b824-cfc2-40a3-b5a1-35243a6e2116"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("a7a696de-3fd8-48c2-b87a-6464b222af87"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("a8b38e56-d3ea-435f-907a-615ed7ced805"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("aa3d56b9-f398-4be1-b8ae-9f8563101b6e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("aa4399ec-1ff3-4837-a68e-0df0720162cb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("aa745539-b444-49d2-ad13-14149f8a1645"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("ab16a3ed-00cd-4445-8e7c-770b1965232e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("abdfeb5b-a4b8-4ab1-b6b8-83f7fb72ec23"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("ad4ef5f1-e823-4ed4-9ad5-cec4a2cae6af"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("af24512b-01ae-4420-96cb-62051ede96cc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("af3badc9-b6da-4eb0-8a42-ecf8dfd6ae19"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("af9c2425-679e-4459-8c68-2d357f4f93e5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("affdf19e-5ed4-497a-97d0-0fc95a547785"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("b16a509f-5c70-42b1-a05e-6d4426c721ca"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("b171e933-4b7d-46f5-802a-14c5c9234ed7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("b1829e62-c3dd-4f65-8c41-fdbe26aedb93"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("b4e019b1-042b-465c-baf9-60d525d9b85c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("b6169a90-920f-425d-a275-82601862a220"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("b83926c4-6963-4f82-97f7-dffa6e87ea7d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("b83be42b-cde9-4dc3-a838-d8197d2c678f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("ba7304bd-7e25-4731-a60f-10c13589c71a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("ba947c48-36fb-420b-b2d9-663fe308b18c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("bcb96598-0e05-4316-86d3-80413326555a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("be946a16-a1af-499c-9bd8-ca12a22fb69c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("bf1bf333-4604-4974-838f-886100c006f3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("c4065df0-2539-4046-bb77-7d699a072734"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("c5c14db2-753f-4e28-88b5-3b9e502fa0c6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("c6f6287f-39f6-4470-ad46-ac539eef3052"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("c7f500b0-be15-4ab8-ae5c-1db430d19b8c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("c831fb16-910b-4939-804a-1052b8f8adc1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("c8766416-ed13-4631-a9c4-e89e782055c9"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("cba207c9-9ee4-4a20-876b-ecb1160d0845"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("cbf1c521-494b-4981-9dc9-b6a1b229c01d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("cc2a4d3b-bae2-4602-9d23-4d4d2d918699"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("cdd52492-d981-4972-9f41-4b1774c002ee"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("cf8c2ebc-2ed1-404c-875c-d2151d54ab9e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("d0357290-582a-47cd-984c-8815d38454be"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("d1fef153-87bc-403a-9590-0ec4cc8d676e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("d200b4b5-7435-41a9-be8b-b6a80e14120b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("d2ebac27-3463-40cb-9eb2-86e1da12a3ba"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("d34d65e5-253f-4324-9aee-f74045802e47"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("d3c10501-b94f-4a0e-b871-80d4b3d7bbbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("d50a063a-82ef-4b56-858e-1a8794b32878"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("d576474f-de6a-45fc-bd19-e18a2915f1a4"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("d892c6c0-bf86-4487-ab8b-5af35cc32a0c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("d94b5935-e6d2-4aa7-b9f7-d332badacd8d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("da333d92-e16c-4b49-b9d8-669df9032f82"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("dd79ead4-6e12-4cb8-aff5-8f00d8bf9e99"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("dd951a03-c803-4351-aac5-ed4ec9922bab"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("ddf4ecad-6f97-4bde-84fe-2b9dc51f0ffd"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("de0d7be8-8a87-4358-b93e-e809ab17f238"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("e180ff8a-4e49-4edd-9168-21b372b8d9b7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("e1fc9395-73b5-4fd6-8c31-37fef3a3e866"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("e369137c-1730-4809-88e4-e43031327233"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("e3a2237c-9d57-462f-bad8-7a78856303c8"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("e43c3f5c-e8d7-430a-9869-e61337bd4188"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("e4acc3fd-7e2d-4927-b7e8-797cb8a29a86"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("e4c05566-0c8d-42a4-a2e9-ad4d6d33b35f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("e5439053-279d-4094-852d-0c2edc6992ed"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("e5837adb-d926-41f1-8434-73fed9db7504"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("e6e7518f-73eb-4010-b0cf-6dcc5c8f8e01"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("e9455b51-bd57-482f-a979-5ecf6c8c4afd"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("edb5a6e1-b084-4e46-87ab-22d38da9cf0a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("edcecb3c-ffcb-451f-8e24-02a0bf6499ae"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("ee02aa87-f8dc-44ac-9ac9-830120f05656"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("ee707e39-4195-426c-abf9-1ce21a771350"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f034e368-335c-4a9f-a039-b7ea83f8a315"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f07d3dde-aea1-4f0a-ba9d-310cda4fa6e9"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f1218849-b5cf-43c8-b3c4-b1ff145f27fc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f1c02c7d-3154-4e55-817c-1e24f6eef729"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f21a86da-a1de-4023-93c9-3a23d315a8cd"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f36eb030-510e-4ca0-b7c4-a1c1ef656dd6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f468cb27-57fb-4b75-b3b7-70bb33ca2705"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f5874f17-6c1e-4c07-b8bf-41b76546f6f0"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f5f9c1ed-f4fb-4cff-aee3-2bcb0d8eed3e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f5fdcb6c-e0c5-4a57-adca-e743ba60ccee"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f79baaf7-6191-4ba9-b38a-2f1b50d05598"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("f9375017-9897-4487-8916-c98d22fd05b9"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("fb10ce71-e68a-4a70-bf7e-5edee9388d48"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("fb67b422-6903-494e-945d-fa09f031b4f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("fc5a0c05-ebac-4906-8a9f-dddcdbcc0a9d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("fd0ac376-bf65-4bf8-9067-245691aa1827"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("fd21963c-7b5e-44a8-8d70-2edbda437946"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("fd235817-1607-4f4c-83c7-ff5bd0012896"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("fd32d265-24dd-4073-a4b8-59e6358b59ed"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("fe657d37-7960-4bb3-8f15-81666fca928d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("ff78779a-45cd-4076-8c61-442a9a3873f2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "SCountry",
                keyColumn: "Id",
                keyValue: new Guid("ffd3fabd-a5f1-4442-837b-d53b5d89272e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "SDeathCause",
                keyColumn: "Id",
                keyValue: new Guid("4333ca55-4d7c-4be0-b9a2-2125624f0229"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "SDeathCause",
                keyColumn: "Id",
                keyValue: new Guid("4d5b5c50-6be0-434e-8baa-a528af4a58b5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "SDeathCause",
                keyColumn: "Id",
                keyValue: new Guid("c0a4d767-7ba9-4006-a0a9-020b6322c2ef"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "SDeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("66c3a43b-f9d0-4876-81e2-b13c5f188589"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "SDeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("7693d6ec-cf0f-44c1-a9d7-fb997335ae10"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "SDeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("8f2b1eeb-a4bd-4f84-b59c-98145c58b1ab"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "SDeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("f91d8342-619c-435b-b51c-8b3d7f541222"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "SDepartmentType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "SDepartmentType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "SDepartmentType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "SDepartmentType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 438, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("010bc204-87e6-4e5f-9e82-79f5a0fc4d04"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("12518ef2-bc95-4a4d-8991-727782426ba8"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("33a82ea4-7aeb-4d08-9ca9-2cb5f06adefb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("4d28238a-1d66-4dca-ae09-5104b16c5eef"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("506d29ff-5cba-4d14-a341-375ed320e229"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d501"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d502"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d503"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d504"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d505"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d506"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d507"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d508"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("5b59e188-c5c7-4beb-a7f1-03293b14d509"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("5cf104df-c5e5-43bf-9aad-89eb8236092b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("7a19295e-ddfc-4aaa-bee3-edb7c6aeddf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("9f693f27-fe31-435b-be4e-0bb17dbaf8b7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("a1f6effe-c174-4fc0-ad02-32b32ca51a20"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("c68ed451-7361-48a9-9f1e-9ad4c1b1bb58"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("ecdeb90d-8bc9-43ee-a233-d1fdc543b11b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("ef1439e7-3dfa-40d3-a8de-a0da87140b45"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("ef1439e7-3dfa-40d3-a8de-a0da87140b46"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("ef1439e7-3dfa-40d3-a8de-a0da87140b47"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("ef1439e7-3dfa-40d3-a8de-a0da87140b48"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("f3a6bcbb-8f93-49da-85e7-e9b07ed72980"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("f3a6bcbb-8f93-49da-85e7-e9b07ed72986"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("f3a6bcbb-8f93-49da-85e7-e9b07ed72987"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("f3a6bcbb-8f93-49da-85e7-e9b07ed72988"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("f3a6bcbb-8f93-49da-85e7-e9b07ed72989"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "SDistrict",
                keyColumn: "Id",
                keyValue: new Guid("fdbacab7-ca1b-4765-b95d-84fac353a648"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "SGender",
                keyColumn: "Id",
                keyValue: new Guid("97ac7fd8-edfa-4243-97fc-98468f492df1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "SGender",
                keyColumn: "Id",
                keyValue: new Guid("e9497984-d355-41af-b917-091500956be9"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "SGender",
                keyColumn: "Id",
                keyValue: new Guid("fc153433-bf89-4e95-8523-df3d8cec8676"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 440, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "SInvoiceType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "SInvoiceType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "SInvoiceType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "SInvoiceType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "SLiveArea",
                keyColumn: "Id",
                keyValue: new Guid("0a14bae0-eeb9-48b3-b49e-b3bb5b1492b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "SLiveArea",
                keyColumn: "Id",
                keyValue: new Guid("b3eb4635-31ff-4e3f-b55f-a02150017bd7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "SLiveArea",
                keyColumn: "Id",
                keyValue: new Guid("ddb7f2cd-be11-495b-80c0-51295e2066b9"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordType",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordTypeGroup",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordTypeGroup",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "SMedicalRecordTypeGroup",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "SPatientObjectType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 439, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "SPatientObjectType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 439, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "SPatientObjectType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 439, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "SPatientObjectType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 439, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "SPatientObjectType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 439, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "SPaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("0b348363-c888-4c9a-b145-c3389fdcca37"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "SPaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("8bff9824-1df2-419e-88ab-e098a6fc4e7e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "SPaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("dd39afc0-1de0-4287-a126-4dada6788508"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("003360aa-6adc-4e1c-8da9-fd1d1665729d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("0729fb2e-ae19-41f3-b948-b0f0c51fbf99"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("0b13943c-ead8-4e76-80b8-33b31828dd7a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("0fdfd770-bee4-4dc4-9eb5-d86816bfc2bf"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("198417f7-e503-4435-bde2-7547487c943a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("1d8b3ff0-1bbd-4fa4-a4c8-1a4e2c394a55"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("2c03541e-db56-4bcb-8012-52b0f130ca09"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("2d80dbcf-c7d5-4450-9847-e7e6f737f567"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("3035b967-95aa-46a5-be3f-b1f7bec1fd51"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("3109e53a-812d-455e-a968-e86ff499d74d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("33d6ec24-75ee-402e-b8d2-3296e90ea336"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("37d13fe4-1fd2-4268-bbae-4ab301f634c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("38e1ffeb-7572-40c7-a716-cd880eb8d1ce"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("395f3325-851f-41ee-b652-5002ce7cf547"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("3baaffd5-90a2-471f-8581-b5969184fcbe"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("3fd18cc5-7204-42a9-a940-c5cf3128518f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("40064e04-52c1-460d-b3d3-04f4e991f82c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("46ddf496-df97-40b4-9b23-bfd17357abbe"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("4e6a7717-9e60-4bae-a2d4-d29dacd8af47"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("528fe36b-ac63-4f15-96f5-104ac221a155"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("52b17f24-a4a1-4cc6-88a0-c526ee8256c6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("5329306e-8290-4ca4-b110-0678c20752e0"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("619d7aee-4e6a-4993-9d7a-c6e32958851f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("64a15171-a037-45b4-a55d-08ee58ce687d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("68d199cc-b739-4d61-b412-40d2242f374d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("6f51a702-3c62-4a43-8042-9cf6e8bf3186"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("702c3cf1-d0b3-4647-8d39-7549dd42f610"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("7184c251-1c62-4b69-a63f-de49e85633f0"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("72478add-ca26-4a9b-92bd-2b075006f36a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("77e4b05d-6245-43ee-ba94-84faaece9018"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("7a3c3be6-fe62-42ab-9764-f8e62d7f5916"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("7acbf3ec-7068-4007-a871-e0fee1ef28c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("839f0efb-168d-4110-a041-60b463ae48a1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("889693ed-0453-4387-941b-d70dd4870dc5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("8eb57a8e-8281-41bb-a5ab-637dcac67177"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("8ed43986-0586-4742-8f89-a673c9f63756"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("8f0f2a47-34e4-4af3-811a-4d9c1fbf1cae"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("927f685b-f766-4bf8-93ed-ae7aabc4071c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("94dab20e-c05d-4aa9-93e9-82e972792756"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("952aa342-c05d-46d3-8ffe-6a22d7512dc2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("9c2a8569-d860-459d-8c3a-49966ea0038d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("9d49b503-ac5f-47f3-aaa2-8d18853bfba6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("a1f48dda-f1a3-473a-b4f7-6843312303f4"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("aee0f859-e3bd-41ae-be15-17060d5ad617"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("af97b966-5b74-4580-a948-c8a9df0a5fba"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("b2035ac5-5e24-4a18-8587-62e65fd64697"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("b2cace92-0d42-4789-97c7-83ea3c3667c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("b42cba39-912a-4400-84a5-fe15eb71766e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("b6bdda7d-b047-45a0-9d73-ffcb4e938e38"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("b6cf7563-f2be-4273-bcc7-58bb3cd4edec"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("c16dbbe1-bea2-413b-9216-5b547deac9f5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("c30f4992-257a-4abf-abb0-2ea4b36f247f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("cd4eab40-92a3-4898-8a65-c67ccde721c0"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("da06856d-9e6c-49f7-bbed-ca2a06ca81c1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("e5a4e82b-b29d-4b47-a563-82977ea93346"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("e7fe23cb-4304-4fb0-90a5-9ff4da5048aa"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("ec0b077d-3957-4089-85f8-c1d6742aab19"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("ed0a3763-3a96-46c5-8094-c47a4708e3cb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("ef981a1e-0af1-4b7f-9fd7-42de078e7d97"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("f06e27bf-1470-4f7a-873f-f0dc77e405e4"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("f2aac7ae-5a85-48fc-9166-d9ab6efb79ab"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("f5d76f98-2024-4c60-81ad-577359cb69d1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "SProvince",
                keyColumn: "Id",
                keyValue: new Guid("fa11ad72-29b7-49f4-986d-fea0d53de210"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 441, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "SReceptionObjectType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "SReceptionObjectType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f01"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f02"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f03"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f04"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f05"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f06"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f07"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f08"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f09"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f10"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f11"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f12"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f13"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f14"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f15"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "SRelationship",
                keyColumn: "Id",
                keyValue: new Guid("dd0fb418-cd3f-40cd-8c12-7fda1cf56f99"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "SRightRouteType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "SRightRouteType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "SRightRouteType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "SRightRouteType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "SRightRouteType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "SRightRouteType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "SRightRouteType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "SRoomType",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 442, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "STransferForm",
                keyColumn: "Id",
                keyValue: new Guid("32848bde-d01c-4d6b-b3a0-2104df2d801c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 443, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "STransferForm",
                keyColumn: "Id",
                keyValue: new Guid("48cac582-b5f8-4f12-bb5b-5f35ca4fcac1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 443, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "STransferForm",
                keyColumn: "Id",
                keyValue: new Guid("b882e676-a760-4468-a687-600770326aac"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 443, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "STransferForm",
                keyColumn: "Id",
                keyValue: new Guid("faf04fde-6dc1-4d6a-b5d8-b9000bb4f6bd"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 443, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "STransferReason",
                keyColumn: "Id",
                keyValue: new Guid("14f21e7e-54d2-40af-ab18-417468e1cadb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 444, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "STransferReason",
                keyColumn: "Id",
                keyValue: new Guid("d6fa811f-0ea0-4303-bb6c-6bdcb7d18970"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 444, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 444, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 444, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 444, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 444, DateTimeKind.Local).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 444, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 444, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 444, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 444, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 444, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 444, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 444, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 444, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 444, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "STreatmentEndType",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 444, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "STreatmentResult",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 444, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "STreatmentResult",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 444, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "STreatmentResult",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 444, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "STreatmentResult",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 444, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "STreatmentResult",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 444, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "STreatmentResult",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 444, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "SUser",
                keyColumn: "Id",
                keyValue: new Guid("3382be1c-2836-4246-99db-c4e1c781e868"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 450, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "SUser",
                keyColumn: "Id",
                keyValue: new Guid("49ba7fd4-2edb-4482-a419-00c81f023f5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 450, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("1594388c-53a1-4d34-81ab-40af3225936f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("18f45f82-55c4-4809-97cf-65f779b926d1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("18f45f82-55c4-4809-97cf-65f779b926d2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("18f45f82-55c4-4809-97cf-65f779b926d3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("18f45f82-55c4-4809-97cf-65f779b926d4"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("18f45f82-55c4-4809-97cf-65f779b926d5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("26cd9859-9e70-4a42-9979-b7d9027c96fd"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("4dd47dfb-9ca8-4ae6-b958-13edf873dc28"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a51d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a52d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a53d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a54d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a55d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a56d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a57d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("56c401ac-d00e-4bdf-ae5a-d2ff12b6a58d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("622ff091-9851-46e8-9716-c355c21d4369"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("7d55b7a9-b5ef-46e4-9a58-9b31e77108d8"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("803d0bc0-278b-42e1-b1bc-623e09920f17"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("8a736b6f-0697-4486-9516-e30cc5c56b98"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("8b10a136-54e8-464b-b6a8-3fb6028bee0e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("8d55eb0d-5c0a-40d1-9684-409868c6f393"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("8dbd4edd-06ce-40a6-a791-16cf3922523a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("910fa544-1584-4dfc-b450-4d230f0847a9"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("94ba5688-cf4d-454a-acc1-8fee10552375"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("b15d7c09-6930-43ce-bb4b-347740ed7096"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("c95d5e0e-7244-4f7f-bc1b-640eba36c54e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("d0a93335-cd08-46e6-8cef-8de70d076ed0"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("d77c97d4-1e36-4c41-bd8f-f8e6209aeb0c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("e6b212d7-d687-4d63-82a5-18920238da18"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("eb2e1424-b66c-41ae-9c5c-57757eb1224b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "SWard",
                keyColumn: "Id",
                keyValue: new Guid("f44abb45-6010-4b0e-a442-5dafbeb4f40c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 0, 24, 28, 445, DateTimeKind.Local).AddTicks(1476));
        }
    }
}
