using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTable01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SProvinces");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "SProvinces");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "SProvinces");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "SProvinces");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "SProvinces");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "SProvinces");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "SProvinces");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "SProvinces");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SCountries");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "SCountries");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "SCountries");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "SCountries");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "SCountries");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "SCountries");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "SCountries");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "SCountries");

            migrationBuilder.RenameColumn(
                name: "SoftOrder",
                table: "SMedicineLines",
                newName: "SortOrder");

            migrationBuilder.AddColumn<string>(
                name: "DugStatus",
                table: "SMedicineTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAllowZeroQuantity",
                table: "SMedicineTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAntibiotics",
                table: "SMedicineTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDrugContainerReturnRequest",
                table: "SMedicineTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInhalantDrug",
                table: "SMedicineTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsNewDrug",
                table: "SMedicineTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsNutraceutical",
                table: "SMedicineTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPrescriptionDrug",
                table: "SMedicineTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPrescriptionDrugForChildren",
                table: "SMedicineTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsRadiolabeledDrug",
                table: "SMedicineTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSponsoredDrug",
                table: "SMedicineTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsTraditionalDrugFormulation",
                table: "SMedicineTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsTraditionalHerbalDrug",
                table: "SMedicineTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Origin",
                table: "SMedicineTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherExpenses",
                table: "SMedicineTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PharmaceuticalDivision",
                table: "SMedicineTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PharmaceuticalFormulation",
                table: "SMedicineTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreparationMethod",
                table: "SMedicineTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProcessingLossRate",
                table: "SMedicineTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QualityStandards",
                table: "SMedicineTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequirementUseDug",
                table: "SMedicineTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ScientificName",
                table: "SMedicineTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ScientificNameChildren",
                table: "SMedicineTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Inactive",
                table: "SMedicineLines",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "HeInCode",
                table: "SCountries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "SCountries",
                columns: new[] { "Id", "Code", "HeInCode", "Inactive", "Name" },
                values: new object[,]
                {
                    { new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), "VN", "000", false, "Việt Nam" },
                    { new Guid("0105cfd9-5265-4dcc-b2d8-790abecd5577"), "PS", "PS", false, "Palestinian Authority" },
                    { new Guid("02cd862f-7bf2-4dee-9d8d-869f67659eac"), "CX", "CX", false, "Christmas island" },
                    { new Guid("05600686-62bc-4be9-b009-58ae6fac5dc2"), "UM", "UM", false, "United States Minor Outlying Islands" },
                    { new Guid("05f8a24e-3764-41af-b79b-3e05da6964ad"), "TO", "276", false, "Tonga" },
                    { new Guid("060539cd-d169-45c2-bec2-28a91e41bcb3"), "IL", "184", false, "Israel" },
                    { new Guid("067dbcfb-9729-4016-aa0f-526f43657542"), "CL", "141", false, "Chile" },
                    { new Guid("07c04d8d-4e1c-4896-ba8a-7d8172562b37"), "KP", "277", false, "Triều Tiên" },
                    { new Guid("09127bf0-ff5d-4660-8fef-18b3107bf295"), "BI", "135", false, "Burundi" },
                    { new Guid("0d9bf5f6-20bb-4b4f-8c3e-0b7205eabe19"), "PR", "PR", false, "Puerto Rico" },
                    { new Guid("0f42743d-f2ae-4d4d-9e9c-6dcd785204ff"), "SE", "273", false, "Thụy Điển" },
                    { new Guid("10a98338-7167-4e5b-b3e4-9515f63bb43d"), "FI", "241", false, "Phần Lan" },
                    { new Guid("10f310c4-857b-431b-934c-19ebc560571c"), "IS", "179", false, "Iceland" },
                    { new Guid("1137907c-6292-4973-8a6a-5a8a55216701"), "OM", "233", false, "Oman" },
                    { new Guid("16bfb332-7ffe-4d31-a2a2-05e7cc250969"), "Z1", "Z1", false, "Sovereign Military Order of Malta (SMOM)" },
                    { new Guid("1760cdb2-5d9e-4a4d-a422-9d2d54333b72"), "VA", "290", false, "Thành Vatican" },
                    { new Guid("18be6a2d-0cc9-4e57-9b95-0fd5e0999094"), "LA", "193", false, "Lào" },
                    { new Guid("19b9d4e2-dd04-4d66-ba70-e71a800b8563"), "CO", "142", false, "Colombia" },
                    { new Guid("1a52542a-e4e8-4514-b84f-d8f7a0ce8bf5"), "HU", "177", false, "Hungary" },
                    { new Guid("1bb67a2c-65b1-4437-b7db-61bb5c5c945a"), "NZ", "227", false, "New Zealand" },
                    { new Guid("1bd96043-4837-4ab4-8812-0230d7cdc37c"), "BH", "117", false, "Bahrain" },
                    { new Guid("1c1e8f0d-fa36-4dd5-a349-51f8f8cf1e11"), "RU", "231", false, "Nga" },
                    { new Guid("1c3907c5-3cd4-4530-a28c-6d4acceec175"), "AZ", "113", false, "Azerbaijan" },
                    { new Guid("1cb83a16-11a1-438b-8fd9-22e661c5904a"), "TN", "281", false, "Tunisia" },
                    { new Guid("1cc02fda-f061-49ad-a4f1-ecb564a28c88"), "KZ", "187", false, "Kazakhstan" },
                    { new Guid("1d374c8c-88c5-49ae-9c9c-0b2b362b1198"), "BR", "131", false, "Brasil" },
                    { new Guid("1d41f179-ba78-41d6-8ecf-595c7d6de65a"), "MA", "209", false, "Maroc" },
                    { new Guid("1df44627-4127-48c0-bbc7-2afc64cb75d2"), "CH", "274", false, "Thụy Sĩ" },
                    { new Guid("1f0c0c80-dceb-47c4-9bfb-d9e2b29e8010"), "NR", "224", false, "Nauru" },
                    { new Guid("20aa6e3b-0838-45fc-9769-161b291e5e24"), "Z4", "Z4", false, "Scotland" },
                    { new Guid("212573b7-ec34-4844-b150-74f567de2c5d"), "GF", "GF", false, "French guiana" },
                    { new Guid("21668f2b-b3d0-4927-9d67-3f9eee4736d6"), "AS", "AS", false, "Samoa thuộc Hoa Kỳ" },
                    { new Guid("22174cd0-7b2d-4c6b-bb6c-5273e63d28f0"), "MY", "205", false, "Malaysia" },
                    { new Guid("226d663e-46ee-4ab2-b385-b062345debd9"), "FR", "240", false, "Pháp" },
                    { new Guid("23063395-5d36-41c9-9711-66722ab8849f"), "CZ", "252", false, "Séc" },
                    { new Guid("24c5f9fa-e493-43a1-9d2a-c6d25dc2ea89"), "FY", "254", false, "Serbia" },
                    { new Guid("25b7ed9b-8bfd-4601-a4c5-a59dfe5a3fab"), "AN", "AN", false, "Netherlands antilles" },
                    { new Guid("25df127f-9fb7-4f1d-8a4f-484364e15f91"), "GN", "170", false, "Guinea" },
                    { new Guid("264432ff-ba3d-4402-ae05-d3cbbdf7eef4"), "NE", "229", false, "Niger" },
                    { new Guid("26d0e10a-43ea-4654-93be-00a21f60b760"), "PG", "237", false, "Papua New Guinea" },
                    { new Guid("298cf3d9-cf13-401f-86b5-368d1c71ec77"), "GQ", "169", false, "Guinea Xích Đạo" },
                    { new Guid("2e24284d-fe7b-477b-a3e9-23505ccbe379"), "Z6", "Z6", false, "Great Britain (See United Kingdom)" },
                    { new Guid("2eab2085-d20b-4cc4-a85b-7567c9ce6ea9"), "LC", "247", false, "Saint Lucia" },
                    { new Guid("2eb9de76-3d99-43a5-b17d-ba2f0e08c64a"), "NI", "228", false, "Nicaragua" },
                    { new Guid("2eead3fb-8c57-4699-a48d-b9eb2a781d23"), "TF", "TF", false, "French Southern Territories" },
                    { new Guid("2f4455d6-efee-4959-8dfd-6f7db81faadd"), "NP", "226", false, "Nepal" },
                    { new Guid("2facb682-01d5-4798-bf0a-928bd471ecb3"), "CC", "CC", false, "Cocos (keeling) islands" },
                    { new Guid("332e0e9e-0182-47a0-b894-ade71da83708"), "BB", "120", false, "Barbados" },
                    { new Guid("33aeb885-ea5c-4343-8011-b1dccebdd65f"), "SA", "110", false, "Ả Rập Saudi" },
                    { new Guid("347a0e24-276d-4a54-b92b-4b88b60179af"), "GM", "163", false, "Gambia" },
                    { new Guid("36299397-b100-420b-bd1b-3f18eda310fa"), "TD", "270", false, "Tchad" },
                    { new Guid("3671801a-1c88-4dc6-9e75-d766644c2af9"), "SR", "264", false, "Suriname" },
                    { new Guid("36ddc306-adf0-4897-a200-6377ff0d9042"), "TT", "278", false, "Trinidad và Tobago" },
                    { new Guid("39351753-1af5-4797-89e2-b97589db8d2e"), "AZ", "114", false, "Cộng hòa Azerbaijan" },
                    { new Guid("39ef7fcd-b539-46be-90a6-bc3f6d1524d8"), "KR", "174", false, "Hàn Quốc" },
                    { new Guid("3adb70b0-ae40-4ac0-8a27-15398cc79d49"), "GS", "GS", false, "South georgia and the south sandwich islands" },
                    { new Guid("3af1daa8-65e1-4502-823d-3c8530608104"), "MP", "MP", false, "Northern mariana islands" },
                    { new Guid("3d9d9ca5-3356-48b3-b518-eb806a6128ee"), "VU", "289", false, "Vanuatu" },
                    { new Guid("3dac050e-a2a6-469b-b0bb-def2e17544a5"), "GW", "168", false, "Guinea-Bissau" },
                    { new Guid("3de67d92-a46e-4113-bd12-2e89a48aa1f0"), "CN", "279", false, "Trung Quốc" },
                    { new Guid("3edffd99-5e14-4466-9f3e-a72ab48711d7"), "HM", "HM", false, "Heard and mc donald islands" },
                    { new Guid("3f3e1d5e-ca7b-45ef-9e1e-f3c471e8894f"), "ST", "251", false, "São Tomé và Príncipe" },
                    { new Guid("426516a2-46e9-4103-8b44-22b4a30b21ae"), "LS", "195", false, "Lesotho" },
                    { new Guid("4452efd3-9727-4c5c-9cc9-76f7270c673d"), "CI", "130", false, "Bờ Biển Ngà" },
                    { new Guid("44ff82d4-3356-4f71-9aa2-dc5f161537f0"), "SY", "266", false, "Syria" },
                    { new Guid("45696681-b325-4d55-b4ea-56a920227907"), "SL", "256", false, "Sierra Leone" },
                    { new Guid("4589f414-2018-4196-a42a-68fa60b41dae"), "MZ", "219", false, "Mozambique" },
                    { new Guid("45a0ebe0-51be-423b-8885-7a7bf06e6f95"), "BA", "127", false, "Bosna và Hercegovina" },
                    { new Guid("46651a82-3d63-4a24-baff-9bb1ee8ac492"), "CF", "280", false, "Trung Phi" },
                    { new Guid("484be820-41ff-4911-94c6-2d2969764ac4"), "CD", "145", false, "Cộng hòa Dân chủ Congo" },
                    { new Guid("4b12f61e-5980-415f-a62b-b296753fd70d"), "PT", "129", false, "Bồ Đào Nha" },
                    { new Guid("4b7309a1-de33-4f43-a2ff-3f11e0e5869b"), "SM", "250", false, "San Marino" },
                    { new Guid("4bab2495-c861-47e7-82e6-1806fd87b767"), "IM", "IM", false, "Isle of man" },
                    { new Guid("4dbc51c5-3faa-4e76-b0d5-a28df95c5c01"), "GT", "167", false, "Guatemala" },
                    { new Guid("4dcd4bda-0da9-415d-8f7e-ecd5841ad250"), "ER", "158", false, "Eritrea" },
                    { new Guid("4e6e77af-56d6-4314-ac68-c39713511d70"), "IE", "183", false, "Ireland" },
                    { new Guid("50202b21-f7c0-42eb-89bd-4470e82f3943"), "JE", "JE", false, "Jersey" },
                    { new Guid("502c14cb-18ea-461f-9bc0-9591b056284c"), "DK", "153", false, "Đan Mạch" },
                    { new Guid("506ddd2c-4f81-4d6d-806c-4c9e605bab3f"), "KN", "246", false, "Saint Kitts và Nevis" },
                    { new Guid("509f7d40-e740-472f-8a7a-84b5a527eb96"), "KG", "192", false, "Kyrgyzstan" },
                    { new Guid("50c044c3-6cd1-46ad-b10a-e879291806f2"), "NU", "NU", false, "Niue" },
                    { new Guid("52595376-4b2b-4746-bb17-16f7ba234a33"), "MW", "204", false, "Malawi" },
                    { new Guid("5300fbb8-1d3b-48c2-b251-c9daab165b94"), "SH", "SH", false, "St. Helena" },
                    { new Guid("5351587c-9713-44c9-9088-9626d01300c8"), "TK", "TK", false, "Tokelau" },
                    { new Guid("539247ef-f9a9-4893-b250-2aa204a87640"), "VG", "VG", false, "Virgin Islands (British)" },
                    { new Guid("53b7d739-4b49-4a35-9d04-93520d79d105"), "TJ", "267", false, "Tajikistan" },
                    { new Guid("53fdbb96-c808-4474-83bc-084e422a8b95"), "BY", "121", false, "Belarus" },
                    { new Guid("54ca17f4-f6f7-4bcf-9809-8d45153c2271"), "LR", "197", false, "Liberia" },
                    { new Guid("561d896e-c3c5-4dfc-b13c-790aa25fbd5d"), "PA", "236", false, "Panama" },
                    { new Guid("5701a860-793e-4660-9302-005b27d4348e"), "AO", "106", false, "Angola" },
                    { new Guid("573dec77-5908-42b2-b1a5-8a5ee8407dee"), "GD", "165", false, "Grenada" },
                    { new Guid("57c01cf1-7f20-4a6c-bec9-bcc9a3a039fe"), "SG", "257", false, "Singapore" },
                    { new Guid("58357a87-d3a9-4ea4-82ea-eb7775f1c568"), "IR", "181", false, "Iran" },
                    { new Guid("58486abc-86a6-4bb8-a610-eb0e4bdf0b73"), "LT", "200", false, "Litva" },
                    { new Guid("58776bc3-ee4b-44ae-ac9e-a501437bde2f"), "PF", "PF", false, "French Polynesia" },
                    { new Guid("58d12ab1-4946-45f9-bef5-354e5803f357"), "DO", "152", false, "Cộng hòa Dominicana" },
                    { new Guid("59e93599-98e9-44de-b9d1-bbbf17c599bf"), "ZA", "223", false, "Nam Phi" },
                    { new Guid("5a68453d-81d4-4417-a579-33d6a1c27ea6"), "PE", "239", false, "Peru" },
                    { new Guid("5b526a49-1694-4eb8-b602-4e150d12184d"), "MC", "216", false, "Monaco" },
                    { new Guid("5bd03273-5b23-4181-892c-397126e8da56"), "PK", "234", false, "Pakistan" },
                    { new Guid("5d60e969-8387-42e4-b866-31dfb209f433"), "Z3", "Z3", false, "England" },
                    { new Guid("5dc567de-1249-4aaa-9d49-04dcd3501220"), "ES", "269", false, "Tây Ban Nha" },
                    { new Guid("5f4a7dfd-c3ed-4796-bde2-94199e595ef0"), "BV", "BV", false, "Bouvet island" },
                    { new Guid("62947f31-4a3e-441b-a9d2-9642ce61de2f"), "KI", "189", false, "Kiribati" },
                    { new Guid("62b0c6c0-4a45-4f33-b35e-d184d815518e"), "GH", "164", false, "Ghana" },
                    { new Guid("63c8621a-fc44-4abe-ba08-8d80520280cf"), "SC", "255", false, "Seychelles" },
                    { new Guid("6477d7a3-465e-4277-a4eb-ef09b13f5eca"), "MO", "MO", false, "Macau" },
                    { new Guid("66169c75-2aa7-409a-a7b9-d8cfe6ac80c0"), "LB", "196", false, "Li ban" },
                    { new Guid("66400b32-893a-489c-a5e1-180d55fb20d4"), "KE", "188", false, "Kenya" },
                    { new Guid("66533605-d826-4aec-9536-e4d30effefda"), "AL", "103", false, "Albania" },
                    { new Guid("665d03c6-346e-43d8-ad21-31492b4382aa"), "JO", "186", false, "Jordan" },
                    { new Guid("686b79de-db2f-4ccd-946c-1bef80cd503e"), "CA", "140", false, "Canada" },
                    { new Guid("6b24b562-1294-4537-a69a-26ac34c41521"), "AD", "105", false, "Andorra" },
                    { new Guid("6b8836aa-2476-4d82-98f1-0b7f56e66f7a"), "TL", "TL", false, "Timor Leste" },
                    { new Guid("6c408b50-b4be-4eca-a710-11a6d914cf4f"), "AT", "109", false, "Áo" },
                    { new Guid("6d2d2371-8785-4a7b-94ba-84c804b2b0a2"), "RE", "RE", false, "Reunion" },
                    { new Guid("6d5a6761-432b-4bd2-9b04-5e01c421de23"), "NF", "NF", false, "Norfolk Island" },
                    { new Guid("716a0688-0378-4941-af8f-c11dc4c45ac2"), "TC", "TC", false, "Turks and Caicos Islands" },
                    { new Guid("720aaa71-3cc0-470f-b56c-472ac37a6574"), "BE", "125", false, "Bỉ" },
                    { new Guid("72d527d4-00df-4f9a-b0e1-e1fa84a4ba6d"), "SO", "261", false, "Somalia" },
                    { new Guid("74c266fd-7287-4525-aca3-6bb66ddcf61f"), "WS", "249", false, "Samoa" },
                    { new Guid("75de9dea-ef0f-4492-890a-f5af36cce7aa"), "CG", "144", false, "Cộng hòa Congo" },
                    { new Guid("76c42f0f-bfb2-4a11-b5a4-e854f74e72cd"), "BZ", "122", false, "Belize" },
                    { new Guid("77365013-80d7-44d5-bd8d-472542cac431"), "MQ", "MQ", false, "Martinique" },
                    { new Guid("788693d2-4ac9-4f85-94bf-13d021bc000d"), "PM", "PM", false, "St. Pierre and Miquelon" },
                    { new Guid("78dcfd52-de7b-4c1d-9ded-0e5d3f7a8a35"), "MT", "208", false, "Malta" },
                    { new Guid("79bc1ba0-a0f6-4065-9783-9e01ade32cde"), "PN", "PN", false, "Pitcairn" },
                    { new Guid("7a384197-d55e-44b8-b389-a65f17e74e1f"), "PH", "242", false, "Philippines" },
                    { new Guid("7af80a81-41e5-47de-abd3-7ce25f9c39b4"), "TM", "282", false, "Turkmenistan" },
                    { new Guid("7afaefc0-9aa8-4ba7-98ae-618682a5be7f"), "KM", "143", false, "Comoros" },
                    { new Guid("7b0c9a9c-e730-4b96-9372-e9ef8ab5339b"), "BM", "BM", false, "Bermuda" },
                    { new Guid("7bea406c-221d-45dd-aca6-a2ceb90741aa"), "DM", "151", false, "Dominica" },
                    { new Guid("7e27cb42-41fb-4b20-b26b-3c1ea9b4ff5c"), "SB", "260", false, "Solomon" },
                    { new Guid("7ef68b6d-2d6b-4688-95bc-d0fd79ffb6c5"), "CY", "191", false, "Síp" },
                    { new Guid("7f233816-fe94-4941-8125-b62c88410fa9"), "BD", "119", false, "Bangladesh" },
                    { new Guid("8562fd7f-49aa-46cf-bbc9-71f7460c6ba7"), "SZ", "265", false, "Swaziland" },
                    { new Guid("8592d87f-720b-48e7-82ee-e82d64cbf984"), "AG", "108", false, "Antigua và Barbuda" },
                    { new Guid("8764ee96-c950-44cf-a1f4-7636126c671b"), "BS", "116", false, "Bahamas" },
                    { new Guid("882c80ef-806d-4370-9fb1-f00a13a7a5c1"), "LV", "194", false, "Latvia" },
                    { new Guid("8a003437-323c-451c-b211-1886f79c25f1"), "MV", "206", false, "Maldives" },
                    { new Guid("8a6a8442-1533-4bba-9a05-ed707122573e"), "GR", "178", false, "Hy Lạp" },
                    { new Guid("8f800608-e254-418d-8163-78f71be4873f"), "EG", "102", false, "Ai Cập" },
                    { new Guid("8ff51ea0-476b-4dec-8736-70cc36ea1d2c"), "NO", "225", false, "Na Uy" },
                    { new Guid("90b2a6a0-bacd-4175-80e9-b8fde9233786"), "KW", "190", false, "Kuwait" },
                    { new Guid("90ef0553-8520-4d57-ae3b-112ebf28b313"), "ZW", "295", false, "Zimbabwe" },
                    { new Guid("92aea1da-5cf2-40fa-92a2-cce297949451"), "SI", "259", false, "Slovenia" },
                    { new Guid("92b69f82-f3e2-4ea9-9d4b-1763b1a75dec"), "MX", "213", false, "Mexico" },
                    { new Guid("93fc49be-bd23-41c3-8538-4b424a7806da"), "CV", "CV", false, "Cape verde" },
                    { new Guid("9412c9e0-c4fe-442f-8b13-ea064bf48703"), "LI", "199", false, "Liechtenstein" },
                    { new Guid("9601fc62-41b1-44af-af8e-8a03c91c96b8"), "JP", "232", false, "Nhật Bản" },
                    { new Guid("97bc234b-7d4c-4870-801b-74f1998741be"), "US", "175", false, "Hoa Kỳ" },
                    { new Guid("98062645-5015-4d8c-886e-3fb70c247ada"), "GP", "GP", false, "Guadeloupe" },
                    { new Guid("994cf06f-b833-4415-84e0-94f3847b6dd8"), "KY", "KY", false, "Cayman islands" },
                    { new Guid("99cfce62-6540-4525-97b8-9a2e62618e05"), "SJ", "SJ", false, "Svalbard and Jan Mayen Islands" },
                    { new Guid("9acb769e-d2de-479c-b66a-424ce710a036"), "NG", "230", false, "Nigeria" },
                    { new Guid("9d5769fe-b3ae-4697-9150-44674e8008ba"), "DE", "155", false, "Đức" },
                    { new Guid("9ded845f-06a1-4651-8903-bc46f7978c84"), "GE", "GE", false, "Georgia" },
                    { new Guid("9eb57842-f592-4080-affd-71b43f7d0517"), "AQ", "AQ", false, "Antarctica" },
                    { new Guid("9ee7b166-4c6f-4136-8928-c6246c3e76d5"), "UZ", "288", false, "Uzbekistan" },
                    { new Guid("a1080c01-e5bb-4e3f-8784-f0678f1eff58"), "DJ", "150", false, "Djibouti" },
                    { new Guid("a1ba5be8-fef9-470a-a5f7-efcf7fc900a4"), "ME", "218", false, "Montenegro" },
                    { new Guid("a1f120ed-4785-486e-b796-dd8cd569a415"), "VC", "248", false, "Saint Vincent và Grenadines" },
                    { new Guid("a30f588b-166d-4118-9d33-b8294e15ad44"), "SD", "263", false, "Sudan" },
                    { new Guid("a3597652-cc84-40ff-b143-208ee8473e93"), "EA", "154", false, "Đông Timor" },
                    { new Guid("a3c5c224-a013-4e23-8655-641a0a76b38a"), "PW", "235", false, "Palau" },
                    { new Guid("a695b824-cfc2-40a3-b5a1-35243a6e2116"), "YE", "293", false, "Yemen" },
                    { new Guid("a7a696de-3fd8-48c2-b87a-6464b222af87"), "VE", "291", false, "Venezuela" },
                    { new Guid("a8b38e56-d3ea-435f-907a-615ed7ced805"), "AF", "101", false, "Afghanistan" },
                    { new Guid("aa3d56b9-f398-4be1-b8ae-9f8563101b6e"), "IT", "292", false, "Ý" },
                    { new Guid("aa4399ec-1ff3-4837-a68e-0df0720162cb"), "MR", "211", false, "Mauritanie" },
                    { new Guid("aa745539-b444-49d2-ad13-14149f8a1645"), "BO", "126", false, "Bolivia" },
                    { new Guid("ab16a3ed-00cd-4445-8e7c-770b1965232e"), "NL", "173", false, "Hà Lan" },
                    { new Guid("abdfeb5b-a4b8-4ab1-b6b8-83f7fb72ec23"), "EE", "159", false, "Estonia" },
                    { new Guid("ad4ef5f1-e823-4ed4-9ad5-cec4a2cae6af"), "UG", "285", false, "Uganda" },
                    { new Guid("af24512b-01ae-4420-96cb-62051ede96cc"), "UA", "286", false, "Ukraina" },
                    { new Guid("af3badc9-b6da-4eb0-8a42-ecf8dfd6ae19"), "AM", "112", false, "Armenia" },
                    { new Guid("af9c2425-679e-4459-8c68-2d357f4f93e5"), "PY", "238", false, "Paraguay" },
                    { new Guid("affdf19e-5ed4-497a-97d0-0fc95a547785"), "LK", "262", false, "Sri Lanka" },
                    { new Guid("b16a509f-5c70-42b1-a05e-6d4426c721ca"), "IQ", "182", false, "Iraq" },
                    { new Guid("b171e933-4b7d-46f5-802a-14c5c9234ed7"), "ML", "207", false, "Mali" },
                    { new Guid("b1829e62-c3dd-4f65-8c41-fdbe26aedb93"), "MG", "203", false, "Madagascar" },
                    { new Guid("b4e019b1-042b-465c-baf9-60d525d9b85c"), "CK", "CK", false, "Cook islands" },
                    { new Guid("b6169a90-920f-425d-a275-82601862a220"), "SK", "258", false, "Slovakia" },
                    { new Guid("b83926c4-6963-4f82-97f7-dffa6e87ea7d"), "MK", "202", false, "Macedonia" },
                    { new Guid("b83be42b-cde9-4dc3-a838-d8197d2c678f"), "FO", "FO", false, "Faroe islands" },
                    { new Guid("ba7304bd-7e25-4731-a60f-10c13589c71a"), "ET", "160", false, "Ethiopia" },
                    { new Guid("ba947c48-36fb-420b-b2d9-663fe308b18c"), "TG", "275", false, "Togo" },
                    { new Guid("bcb96598-0e05-4316-86d3-80413326555a"), "MH", "210", false, "Quần đảo Marshall" },
                    { new Guid("be946a16-a1af-499c-9bd8-ca12a22fb69c"), "CU", "149", false, "Cuba" },
                    { new Guid("bf1bf333-4604-4974-838f-886100c006f3"), "TW", "TW", false, "Đài Loan" },
                    { new Guid("c4065df0-2539-4046-bb77-7d699a072734"), "FM", "214", false, "Micronesia" },
                    { new Guid("c5c14db2-753f-4e28-88b5-3b9e502fa0c6"), "BN", "132", false, "Brunei" },
                    { new Guid("c6f6287f-39f6-4470-ad46-ac539eef3052"), "EC", "156", false, "Ecuador" },
                    { new Guid("c7f500b0-be15-4ab8-ae5c-1db430d19b8c"), "YT", "YT", false, "Mayotte" },
                    { new Guid("c831fb16-910b-4939-804a-1052b8f8adc1"), "HT", "172", false, "Haiti" },
                    { new Guid("c8766416-ed13-4631-a9c4-e89e782055c9"), "Z7", "Z7", false, "Wales" },
                    { new Guid("cba207c9-9ee4-4a20-876b-ecb1160d0845"), "SN", "253", false, "Sénégal" },
                    { new Guid("cbf1c521-494b-4981-9dc9-b6a1b229c01d"), "JM", "185", false, "Jamaica" },
                    { new Guid("cc2a4d3b-bae2-4602-9d23-4d4d2d918699"), "MD", "215", false, "Moldova" },
                    { new Guid("cdd52492-d981-4972-9f41-4b1774c002ee"), "GI", "GI", false, "Gibraltar" },
                    { new Guid("cf8c2ebc-2ed1-404c-875c-d2151d54ab9e"), "MM", "220", false, "Myanma" },
                    { new Guid("d0357290-582a-47cd-984c-8815d38454be"), "Z5", "Z5", false, "Northern Ireland" },
                    { new Guid("d1fef153-87bc-403a-9590-0ec4cc8d676e"), "PL", "118", false, "Ba Lan" },
                    { new Guid("d200b4b5-7435-41a9-be8b-b6a80e14120b"), "IO", "IO", false, "British indian ocean territory" },
                    { new Guid("d2ebac27-3463-40cb-9eb2-86e1da12a3ba"), "MS", "MS", false, "Montserrat" },
                    { new Guid("d34d65e5-253f-4324-9aee-f74045802e47"), "GG", "GG", false, "Guernsey" },
                    { new Guid("d3c10501-b94f-4a0e-b871-80d4b3d7bbbb"), "HK", "HK", false, "Hong kong" },
                    { new Guid("d50a063a-82ef-4b56-858e-1a8794b32878"), "HN", "176", false, "Honduras" },
                    { new Guid("d576474f-de6a-45fc-bd19-e18a2915f1a4"), "CR", "146", false, "Costa Rica" },
                    { new Guid("d892c6c0-bf86-4487-ab8b-5af35cc32a0c"), "GV", "171", false, "Guyana" },
                    { new Guid("d94b5935-e6d2-4aa7-b9f7-d332badacd8d"), "BT", "124", false, "Bhutan" },
                    { new Guid("da333d92-e16c-4b49-b9d8-669df9032f82"), "FJ", "161", false, "Fiji" },
                    { new Guid("dd79ead4-6e12-4cb8-aff5-8f00d8bf9e99"), "SD", "222", false, "Nam Sudan" },
                    { new Guid("dd951a03-c803-4351-aac5-ed4ec9922bab"), "QA", "243", false, "Qatar" },
                    { new Guid("ddf4ecad-6f97-4bde-84fe-2b9dc51f0ffd"), "BW", "128", false, "Botswana" },
                    { new Guid("de0d7be8-8a87-4358-b93e-e809ab17f238"), "RO", "244", false, "Romania" },
                    { new Guid("e180ff8a-4e49-4edd-9168-21b372b8d9b7"), "BG", "133", false, "Bulgaria" },
                    { new Guid("e1fc9395-73b5-4fd6-8c31-37fef3a3e866"), "ZM", "294", false, "Zambia" },
                    { new Guid("e369137c-1730-4809-88e4-e43031327233"), "BF", "134", false, "Burkina Faso" },
                    { new Guid("e3a2237c-9d57-462f-bad8-7a78856303c8"), "ID", "180", false, "Indonesia" },
                    { new Guid("e43c3f5c-e8d7-430a-9869-e61337bd4188"), "Z2", "Z2", false, "British Southern and Antarctic Territories" },
                    { new Guid("e4acc3fd-7e2d-4927-b7e8-797cb8a29a86"), "GU", "GU", false, "Guam" },
                    { new Guid("e4c05566-0c8d-42a4-a2e9-ad4d6d33b35f"), "AI", "AI", false, "Anguilla" },
                    { new Guid("e5439053-279d-4094-852d-0c2edc6992ed"), "SV", "157", false, "El Salvador" },
                    { new Guid("e5837adb-d926-41f1-8434-73fed9db7504"), "AW", "AW", false, "Aruba việt nam" },
                    { new Guid("e6e7518f-73eb-4010-b0cf-6dcc5c8f8e01"), "DZ", "104", false, "Algérie" },
                    { new Guid("e9455b51-bd57-482f-a979-5ecf6c8c4afd"), "GB", "107", false, "Vương quốc Liên hiệp Anh và Bắc Ireland" },
                    { new Guid("edb5a6e1-b084-4e46-87ab-22d38da9cf0a"), "UY", "287", false, "Uruguay" },
                    { new Guid("edcecb3c-ffcb-451f-8e24-02a0bf6499ae"), "IN", "115", false, "Cộng hòa Ấn Độ" },
                    { new Guid("ee02aa87-f8dc-44ac-9ac9-830120f05656"), "TR", "272", false, "Thổ Nhĩ Kỳ" },
                    { new Guid("ee707e39-4195-426c-abf9-1ce21a771350"), "NA", "221", false, "Namibia" },
                    { new Guid("f034e368-335c-4a9f-a039-b7ea83f8a315"), "LU", "201", false, "Luxembourg" },
                    { new Guid("f07d3dde-aea1-4f0a-ba9d-310cda4fa6e9"), "TH", "271", false, "Thái Lan" },
                    { new Guid("f1218849-b5cf-43c8-b3c4-b1ff145f27fc"), "MU", "212", false, "Mauritius" },
                    { new Guid("f1c02c7d-3154-4e55-817c-1e24f6eef729"), "GA", "162", false, "Gabon" },
                    { new Guid("f21a86da-a1de-4023-93c9-3a23d315a8cd"), "RW", "245", false, "Rwanda" },
                    { new Guid("f36eb030-510e-4ca0-b7c4-a1c1ef656dd6"), "FK", "FK", false, "Falkland islands (malvinas)" },
                    { new Guid("f468cb27-57fb-4b75-b3b7-70bb33ca2705"), "KH", "139", false, "Campuchia" },
                    { new Guid("f5874f17-6c1e-4c07-b8bf-41b76546f6f0"), "CM", "138", false, "Cameroon" },
                    { new Guid("f5f9c1ed-f4fb-4cff-aee3-2bcb0d8eed3e"), "NC", "NC", false, "New Caledonia" },
                    { new Guid("f5fdcb6c-e0c5-4a57-adca-e743ba60ccee"), "LY", "198", false, "Libya" },
                    { new Guid("f79baaf7-6191-4ba9-b38a-2f1b50d05598"), "TV", "283", false, "Tuvalu" },
                    { new Guid("f9375017-9897-4487-8916-c98d22fd05b9"), "GL", "GL", false, "Greenland" },
                    { new Guid("fb10ce71-e68a-4a70-bf7e-5edee9388d48"), "AE", "137", false, "Các Tiểu Vương quốc Ả Rập Thống nhất" },
                    { new Guid("fb67b422-6903-494e-945d-fa09f031b4f1"), "VI", "VI", false, "Virgin Islands (U.S.)" },
                    { new Guid("fc5a0c05-ebac-4906-8a9f-dddcdbcc0a9d"), "AU", "284", false, "Úc" },
                    { new Guid("fd0ac376-bf65-4bf8-9067-245691aa1827"), "HR", "147", false, "Croatia" },
                    { new Guid("fd21963c-7b5e-44a8-8d70-2edbda437946"), "MN", "217", false, "Mông Cổ" },
                    { new Guid("fd235817-1607-4f4c-83c7-ff5bd0012896"), "BJ", "123", false, "Benin" },
                    { new Guid("fd32d265-24dd-4073-a4b8-59e6358b59ed"), "AR", "111", false, "Argentina" },
                    { new Guid("fe657d37-7960-4bb3-8f15-81666fca928d"), "EH", "EH", false, "Western sahara" },
                    { new Guid("ff78779a-45cd-4076-8c61-442a9a3873f2"), "TZ", "268", false, "Tanzania" },
                    { new Guid("ffd3fabd-a5f1-4442-837b-d53b5d89272e"), "WF", "WF", false, "Wallis and Futuna Islands" }
                });

            migrationBuilder.UpdateData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("00be783e-d679-4f1c-9ae2-a4f4c79de0ef"),
                columns: new[] { "Code", "Name" },
                values: new object[] { "TKSV", "Thuốc kháng sinh viên" });

            migrationBuilder.UpdateData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("2fd41f93-ddb9-47dd-9833-4507ce71128c"),
                columns: new[] { "Code", "Name" },
                values: new object[] { "TV", "Thuốc viên" });

            migrationBuilder.UpdateData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("35df3868-8db6-440d-809f-f4c345d804a7"),
                columns: new[] { "Code", "Name" },
                values: new object[] { "TS", "Thuốc siro" });

            migrationBuilder.UpdateData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("914ca65d-6579-4590-b963-fee8a743bae1"),
                columns: new[] { "Code", "Name" },
                values: new object[] { "DC", "Dịch truyền" });

            migrationBuilder.UpdateData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("c987b9d2-e599-49cc-99f3-d075d27cee7c"),
                columns: new[] { "Code", "Name" },
                values: new object[] { "TDY", "Thuốc đông y" });

            migrationBuilder.UpdateData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("ff9be71e-a958-4244-9df1-1582229c67d5"),
                columns: new[] { "Code", "Name" },
                values: new object[] { "TU", "Thuốc uống" });

            migrationBuilder.InsertData(
                table: "SMedicineGroups",
                columns: new[] { "Id", "Code", "Inactive", "IsSystem", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("05a24915-0bed-4f61-b53d-b5e52482e44c"), "TK", false, true, "Thuốc khác", 21 },
                    { new Guid("25454ce7-bff0-4fd5-a47a-069554c1535a"), "VC", false, true, "Vaccine", 19 },
                    { new Guid("2f5148cb-8adf-45ec-88ee-f84530cfa164"), "THTT", false, true, "Thuốc hướng tâm thần", 10 },
                    { new Guid("3144745c-477c-4ce2-9c33-a38eb2153057"), "SP", false, true, "Sinh phẩm", 18 },
                    { new Guid("31d26ca7-2b5f-4dfd-b961-f3609e6a0b69"), "TCO", false, true, "Nhóm thuốc corticoid", 12 },
                    { new Guid("6375b8a1-b6e7-4724-a1b4-8cc3acc98e43"), "KCVI", false, true, "Khoáng chất và Vitamin", 5 },
                    { new Guid("8590ae3d-351c-4438-bfe5-3f69dcf97349"), "TB", false, true, "Thuốc bột", 8 },
                    { new Guid("9e144dff-29f6-47da-b7ed-b55abd1a2cd3"), "VTNT", false, true, "Vật tư nhà thuốc", 20 },
                    { new Guid("a28fb46e-e9b9-410e-9c31-d8ebfd22015c"), "TKTT", false, true, "Thuốc kê tự túc", 16 },
                    { new Guid("ae04abd7-d012-470d-9b8a-f38d9c5c94a8"), "TG", false, true, "Thuốc gói", 14 },
                    { new Guid("b5f03233-d733-4349-93df-db562b7d4376"), "THD", false, true, "Thuốc hỗn dịch", 6 },
                    { new Guid("cc48bb40-fbf0-4054-818c-eb49545aaeea"), "TDN", false, true, "Thuốc dùng ngoài", 7 },
                    { new Guid("cd5d7538-b1d2-448d-b6ff-c139c35f9dc7"), "TGTM", false, true, "Thuốc gây tê, mê", 13 },
                    { new Guid("ddf105e8-6534-46e4-832b-598daa84c4d5"), "TGN", false, true, "Thuốc gây nghiện", 9 },
                    { new Guid("e47ab5de-9ea5-4075-8da5-7ae9f36538e2"), "TUT", false, true, "Thuốc ung thư", 15 },
                    { new Guid("e482e866-9243-49d8-8676-403377de353c"), "TKSO", false, true, "Thuốc kháng sinh ống", 11 },
                    { new Guid("ea57a262-6647-4e88-880c-82bc4227e916"), "TNM", false, true, "Thuốc nhỏ mắt", 17 }
                });

            migrationBuilder.InsertData(
                table: "SUnits",
                columns: new[] { "Id", "Code", "Inactive", "Name", "SortOrder", "UnitType" },
                values: new object[,]
                {
                    { new Guid("46ea45ff-ba5e-4f6f-bbc6-ebe65446efe8"), "GAM", false, "Gam", 20, 0 },
                    { new Guid("8d7a7b33-f2ed-4b4b-a869-3ad32fd9d192"), "TUI", false, "Túi", 17, 0 },
                    { new Guid("e04b1f07-6f05-403e-ac09-b999cac0df3e"), "CAI", false, "Cái", 18, 0 },
                    { new Guid("e46826b4-76f9-4b32-84b3-b9730e732839"), "CHIEC", false, "Chiếc", 19, 0 },
                    { new Guid("fc7acf3a-2c10-4200-9448-c3180c0a4400"), "MIENG", false, "Miếng", 21, 0 },
                    { new Guid("fd96bad9-b254-4b37-8eb9-ada68fe7dada"), "CHAI", false, "Chai", 16, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("0105cfd9-5265-4dcc-b2d8-790abecd5577"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("02cd862f-7bf2-4dee-9d8d-869f67659eac"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("05600686-62bc-4be9-b009-58ae6fac5dc2"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("05f8a24e-3764-41af-b79b-3e05da6964ad"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("060539cd-d169-45c2-bec2-28a91e41bcb3"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("067dbcfb-9729-4016-aa0f-526f43657542"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("07c04d8d-4e1c-4896-ba8a-7d8172562b37"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("09127bf0-ff5d-4660-8fef-18b3107bf295"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("0d9bf5f6-20bb-4b4f-8c3e-0b7205eabe19"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("0f42743d-f2ae-4d4d-9e9c-6dcd785204ff"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("10a98338-7167-4e5b-b3e4-9515f63bb43d"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("10f310c4-857b-431b-934c-19ebc560571c"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("1137907c-6292-4973-8a6a-5a8a55216701"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("16bfb332-7ffe-4d31-a2a2-05e7cc250969"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("1760cdb2-5d9e-4a4d-a422-9d2d54333b72"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("18be6a2d-0cc9-4e57-9b95-0fd5e0999094"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("19b9d4e2-dd04-4d66-ba70-e71a800b8563"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("1a52542a-e4e8-4514-b84f-d8f7a0ce8bf5"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("1bb67a2c-65b1-4437-b7db-61bb5c5c945a"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("1bd96043-4837-4ab4-8812-0230d7cdc37c"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("1c1e8f0d-fa36-4dd5-a349-51f8f8cf1e11"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("1c3907c5-3cd4-4530-a28c-6d4acceec175"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("1cb83a16-11a1-438b-8fd9-22e661c5904a"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("1cc02fda-f061-49ad-a4f1-ecb564a28c88"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("1d374c8c-88c5-49ae-9c9c-0b2b362b1198"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("1d41f179-ba78-41d6-8ecf-595c7d6de65a"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("1df44627-4127-48c0-bbc7-2afc64cb75d2"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("1f0c0c80-dceb-47c4-9bfb-d9e2b29e8010"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("20aa6e3b-0838-45fc-9769-161b291e5e24"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("212573b7-ec34-4844-b150-74f567de2c5d"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("21668f2b-b3d0-4927-9d67-3f9eee4736d6"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("22174cd0-7b2d-4c6b-bb6c-5273e63d28f0"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("226d663e-46ee-4ab2-b385-b062345debd9"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("23063395-5d36-41c9-9711-66722ab8849f"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("24c5f9fa-e493-43a1-9d2a-c6d25dc2ea89"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("25b7ed9b-8bfd-4601-a4c5-a59dfe5a3fab"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("25df127f-9fb7-4f1d-8a4f-484364e15f91"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("264432ff-ba3d-4402-ae05-d3cbbdf7eef4"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("26d0e10a-43ea-4654-93be-00a21f60b760"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("298cf3d9-cf13-401f-86b5-368d1c71ec77"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("2e24284d-fe7b-477b-a3e9-23505ccbe379"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("2eab2085-d20b-4cc4-a85b-7567c9ce6ea9"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("2eb9de76-3d99-43a5-b17d-ba2f0e08c64a"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("2eead3fb-8c57-4699-a48d-b9eb2a781d23"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("2f4455d6-efee-4959-8dfd-6f7db81faadd"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("2facb682-01d5-4798-bf0a-928bd471ecb3"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("332e0e9e-0182-47a0-b894-ade71da83708"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("33aeb885-ea5c-4343-8011-b1dccebdd65f"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("347a0e24-276d-4a54-b92b-4b88b60179af"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("36299397-b100-420b-bd1b-3f18eda310fa"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("3671801a-1c88-4dc6-9e75-d766644c2af9"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("36ddc306-adf0-4897-a200-6377ff0d9042"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("39351753-1af5-4797-89e2-b97589db8d2e"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("39ef7fcd-b539-46be-90a6-bc3f6d1524d8"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("3adb70b0-ae40-4ac0-8a27-15398cc79d49"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("3af1daa8-65e1-4502-823d-3c8530608104"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("3d9d9ca5-3356-48b3-b518-eb806a6128ee"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("3dac050e-a2a6-469b-b0bb-def2e17544a5"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("3de67d92-a46e-4113-bd12-2e89a48aa1f0"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("3edffd99-5e14-4466-9f3e-a72ab48711d7"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("3f3e1d5e-ca7b-45ef-9e1e-f3c471e8894f"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("426516a2-46e9-4103-8b44-22b4a30b21ae"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("4452efd3-9727-4c5c-9cc9-76f7270c673d"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("44ff82d4-3356-4f71-9aa2-dc5f161537f0"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("45696681-b325-4d55-b4ea-56a920227907"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("4589f414-2018-4196-a42a-68fa60b41dae"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("45a0ebe0-51be-423b-8885-7a7bf06e6f95"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("46651a82-3d63-4a24-baff-9bb1ee8ac492"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("484be820-41ff-4911-94c6-2d2969764ac4"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("4b12f61e-5980-415f-a62b-b296753fd70d"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("4b7309a1-de33-4f43-a2ff-3f11e0e5869b"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("4bab2495-c861-47e7-82e6-1806fd87b767"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("4dbc51c5-3faa-4e76-b0d5-a28df95c5c01"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("4dcd4bda-0da9-415d-8f7e-ecd5841ad250"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("4e6e77af-56d6-4314-ac68-c39713511d70"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("50202b21-f7c0-42eb-89bd-4470e82f3943"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("502c14cb-18ea-461f-9bc0-9591b056284c"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("506ddd2c-4f81-4d6d-806c-4c9e605bab3f"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("509f7d40-e740-472f-8a7a-84b5a527eb96"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("50c044c3-6cd1-46ad-b10a-e879291806f2"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("52595376-4b2b-4746-bb17-16f7ba234a33"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("5300fbb8-1d3b-48c2-b251-c9daab165b94"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("5351587c-9713-44c9-9088-9626d01300c8"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("539247ef-f9a9-4893-b250-2aa204a87640"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("53b7d739-4b49-4a35-9d04-93520d79d105"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("53fdbb96-c808-4474-83bc-084e422a8b95"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("54ca17f4-f6f7-4bcf-9809-8d45153c2271"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("561d896e-c3c5-4dfc-b13c-790aa25fbd5d"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("5701a860-793e-4660-9302-005b27d4348e"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("573dec77-5908-42b2-b1a5-8a5ee8407dee"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("57c01cf1-7f20-4a6c-bec9-bcc9a3a039fe"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("58357a87-d3a9-4ea4-82ea-eb7775f1c568"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("58486abc-86a6-4bb8-a610-eb0e4bdf0b73"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("58776bc3-ee4b-44ae-ac9e-a501437bde2f"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("58d12ab1-4946-45f9-bef5-354e5803f357"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("59e93599-98e9-44de-b9d1-bbbf17c599bf"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("5a68453d-81d4-4417-a579-33d6a1c27ea6"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("5b526a49-1694-4eb8-b602-4e150d12184d"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("5bd03273-5b23-4181-892c-397126e8da56"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("5d60e969-8387-42e4-b866-31dfb209f433"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("5dc567de-1249-4aaa-9d49-04dcd3501220"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("5f4a7dfd-c3ed-4796-bde2-94199e595ef0"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("62947f31-4a3e-441b-a9d2-9642ce61de2f"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("62b0c6c0-4a45-4f33-b35e-d184d815518e"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("63c8621a-fc44-4abe-ba08-8d80520280cf"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("6477d7a3-465e-4277-a4eb-ef09b13f5eca"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("66169c75-2aa7-409a-a7b9-d8cfe6ac80c0"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("66400b32-893a-489c-a5e1-180d55fb20d4"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("66533605-d826-4aec-9536-e4d30effefda"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("665d03c6-346e-43d8-ad21-31492b4382aa"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("686b79de-db2f-4ccd-946c-1bef80cd503e"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("6b24b562-1294-4537-a69a-26ac34c41521"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("6b8836aa-2476-4d82-98f1-0b7f56e66f7a"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("6c408b50-b4be-4eca-a710-11a6d914cf4f"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("6d2d2371-8785-4a7b-94ba-84c804b2b0a2"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("6d5a6761-432b-4bd2-9b04-5e01c421de23"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("716a0688-0378-4941-af8f-c11dc4c45ac2"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("720aaa71-3cc0-470f-b56c-472ac37a6574"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("72d527d4-00df-4f9a-b0e1-e1fa84a4ba6d"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("74c266fd-7287-4525-aca3-6bb66ddcf61f"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("75de9dea-ef0f-4492-890a-f5af36cce7aa"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("76c42f0f-bfb2-4a11-b5a4-e854f74e72cd"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("77365013-80d7-44d5-bd8d-472542cac431"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("788693d2-4ac9-4f85-94bf-13d021bc000d"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("78dcfd52-de7b-4c1d-9ded-0e5d3f7a8a35"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("79bc1ba0-a0f6-4065-9783-9e01ade32cde"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("7a384197-d55e-44b8-b389-a65f17e74e1f"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("7af80a81-41e5-47de-abd3-7ce25f9c39b4"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("7afaefc0-9aa8-4ba7-98ae-618682a5be7f"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("7b0c9a9c-e730-4b96-9372-e9ef8ab5339b"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("7bea406c-221d-45dd-aca6-a2ceb90741aa"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("7e27cb42-41fb-4b20-b26b-3c1ea9b4ff5c"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("7ef68b6d-2d6b-4688-95bc-d0fd79ffb6c5"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("7f233816-fe94-4941-8125-b62c88410fa9"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("8562fd7f-49aa-46cf-bbc9-71f7460c6ba7"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("8592d87f-720b-48e7-82ee-e82d64cbf984"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("8764ee96-c950-44cf-a1f4-7636126c671b"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("882c80ef-806d-4370-9fb1-f00a13a7a5c1"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("8a003437-323c-451c-b211-1886f79c25f1"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("8a6a8442-1533-4bba-9a05-ed707122573e"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("8f800608-e254-418d-8163-78f71be4873f"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("8ff51ea0-476b-4dec-8736-70cc36ea1d2c"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("90b2a6a0-bacd-4175-80e9-b8fde9233786"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("90ef0553-8520-4d57-ae3b-112ebf28b313"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("92aea1da-5cf2-40fa-92a2-cce297949451"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("92b69f82-f3e2-4ea9-9d4b-1763b1a75dec"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("93fc49be-bd23-41c3-8538-4b424a7806da"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("9412c9e0-c4fe-442f-8b13-ea064bf48703"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("9601fc62-41b1-44af-af8e-8a03c91c96b8"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("97bc234b-7d4c-4870-801b-74f1998741be"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("98062645-5015-4d8c-886e-3fb70c247ada"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("994cf06f-b833-4415-84e0-94f3847b6dd8"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("99cfce62-6540-4525-97b8-9a2e62618e05"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("9acb769e-d2de-479c-b66a-424ce710a036"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("9d5769fe-b3ae-4697-9150-44674e8008ba"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("9ded845f-06a1-4651-8903-bc46f7978c84"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("9eb57842-f592-4080-affd-71b43f7d0517"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("9ee7b166-4c6f-4136-8928-c6246c3e76d5"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("a1080c01-e5bb-4e3f-8784-f0678f1eff58"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("a1ba5be8-fef9-470a-a5f7-efcf7fc900a4"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("a1f120ed-4785-486e-b796-dd8cd569a415"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("a30f588b-166d-4118-9d33-b8294e15ad44"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("a3597652-cc84-40ff-b143-208ee8473e93"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("a3c5c224-a013-4e23-8655-641a0a76b38a"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("a695b824-cfc2-40a3-b5a1-35243a6e2116"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("a7a696de-3fd8-48c2-b87a-6464b222af87"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("a8b38e56-d3ea-435f-907a-615ed7ced805"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("aa3d56b9-f398-4be1-b8ae-9f8563101b6e"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("aa4399ec-1ff3-4837-a68e-0df0720162cb"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("aa745539-b444-49d2-ad13-14149f8a1645"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("ab16a3ed-00cd-4445-8e7c-770b1965232e"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("abdfeb5b-a4b8-4ab1-b6b8-83f7fb72ec23"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("ad4ef5f1-e823-4ed4-9ad5-cec4a2cae6af"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("af24512b-01ae-4420-96cb-62051ede96cc"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("af3badc9-b6da-4eb0-8a42-ecf8dfd6ae19"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("af9c2425-679e-4459-8c68-2d357f4f93e5"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("affdf19e-5ed4-497a-97d0-0fc95a547785"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("b16a509f-5c70-42b1-a05e-6d4426c721ca"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("b171e933-4b7d-46f5-802a-14c5c9234ed7"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("b1829e62-c3dd-4f65-8c41-fdbe26aedb93"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("b4e019b1-042b-465c-baf9-60d525d9b85c"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("b6169a90-920f-425d-a275-82601862a220"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("b83926c4-6963-4f82-97f7-dffa6e87ea7d"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("b83be42b-cde9-4dc3-a838-d8197d2c678f"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("ba7304bd-7e25-4731-a60f-10c13589c71a"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("ba947c48-36fb-420b-b2d9-663fe308b18c"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("bcb96598-0e05-4316-86d3-80413326555a"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("be946a16-a1af-499c-9bd8-ca12a22fb69c"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("bf1bf333-4604-4974-838f-886100c006f3"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("c4065df0-2539-4046-bb77-7d699a072734"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("c5c14db2-753f-4e28-88b5-3b9e502fa0c6"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("c6f6287f-39f6-4470-ad46-ac539eef3052"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("c7f500b0-be15-4ab8-ae5c-1db430d19b8c"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("c831fb16-910b-4939-804a-1052b8f8adc1"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("c8766416-ed13-4631-a9c4-e89e782055c9"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("cba207c9-9ee4-4a20-876b-ecb1160d0845"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("cbf1c521-494b-4981-9dc9-b6a1b229c01d"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("cc2a4d3b-bae2-4602-9d23-4d4d2d918699"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("cdd52492-d981-4972-9f41-4b1774c002ee"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("cf8c2ebc-2ed1-404c-875c-d2151d54ab9e"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("d0357290-582a-47cd-984c-8815d38454be"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("d1fef153-87bc-403a-9590-0ec4cc8d676e"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("d200b4b5-7435-41a9-be8b-b6a80e14120b"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("d2ebac27-3463-40cb-9eb2-86e1da12a3ba"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("d34d65e5-253f-4324-9aee-f74045802e47"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("d3c10501-b94f-4a0e-b871-80d4b3d7bbbb"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("d50a063a-82ef-4b56-858e-1a8794b32878"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("d576474f-de6a-45fc-bd19-e18a2915f1a4"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("d892c6c0-bf86-4487-ab8b-5af35cc32a0c"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("d94b5935-e6d2-4aa7-b9f7-d332badacd8d"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("da333d92-e16c-4b49-b9d8-669df9032f82"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("dd79ead4-6e12-4cb8-aff5-8f00d8bf9e99"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("dd951a03-c803-4351-aac5-ed4ec9922bab"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("ddf4ecad-6f97-4bde-84fe-2b9dc51f0ffd"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("de0d7be8-8a87-4358-b93e-e809ab17f238"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("e180ff8a-4e49-4edd-9168-21b372b8d9b7"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("e1fc9395-73b5-4fd6-8c31-37fef3a3e866"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("e369137c-1730-4809-88e4-e43031327233"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("e3a2237c-9d57-462f-bad8-7a78856303c8"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("e43c3f5c-e8d7-430a-9869-e61337bd4188"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("e4acc3fd-7e2d-4927-b7e8-797cb8a29a86"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("e4c05566-0c8d-42a4-a2e9-ad4d6d33b35f"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("e5439053-279d-4094-852d-0c2edc6992ed"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("e5837adb-d926-41f1-8434-73fed9db7504"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("e6e7518f-73eb-4010-b0cf-6dcc5c8f8e01"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("e9455b51-bd57-482f-a979-5ecf6c8c4afd"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("edb5a6e1-b084-4e46-87ab-22d38da9cf0a"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("edcecb3c-ffcb-451f-8e24-02a0bf6499ae"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("ee02aa87-f8dc-44ac-9ac9-830120f05656"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("ee707e39-4195-426c-abf9-1ce21a771350"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("f034e368-335c-4a9f-a039-b7ea83f8a315"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("f07d3dde-aea1-4f0a-ba9d-310cda4fa6e9"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("f1218849-b5cf-43c8-b3c4-b1ff145f27fc"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("f1c02c7d-3154-4e55-817c-1e24f6eef729"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("f21a86da-a1de-4023-93c9-3a23d315a8cd"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("f36eb030-510e-4ca0-b7c4-a1c1ef656dd6"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("f468cb27-57fb-4b75-b3b7-70bb33ca2705"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("f5874f17-6c1e-4c07-b8bf-41b76546f6f0"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("f5f9c1ed-f4fb-4cff-aee3-2bcb0d8eed3e"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("f5fdcb6c-e0c5-4a57-adca-e743ba60ccee"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("f79baaf7-6191-4ba9-b38a-2f1b50d05598"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("f9375017-9897-4487-8916-c98d22fd05b9"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("fb10ce71-e68a-4a70-bf7e-5edee9388d48"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("fb67b422-6903-494e-945d-fa09f031b4f1"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("fc5a0c05-ebac-4906-8a9f-dddcdbcc0a9d"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("fd0ac376-bf65-4bf8-9067-245691aa1827"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("fd21963c-7b5e-44a8-8d70-2edbda437946"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("fd235817-1607-4f4c-83c7-ff5bd0012896"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("fd32d265-24dd-4073-a4b8-59e6358b59ed"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("fe657d37-7960-4bb3-8f15-81666fca928d"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("ff78779a-45cd-4076-8c61-442a9a3873f2"));

            migrationBuilder.DeleteData(
                table: "SCountries",
                keyColumn: "Id",
                keyValue: new Guid("ffd3fabd-a5f1-4442-837b-d53b5d89272e"));

            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("05a24915-0bed-4f61-b53d-b5e52482e44c"));

            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("25454ce7-bff0-4fd5-a47a-069554c1535a"));

            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("2f5148cb-8adf-45ec-88ee-f84530cfa164"));

            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("3144745c-477c-4ce2-9c33-a38eb2153057"));

            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("31d26ca7-2b5f-4dfd-b961-f3609e6a0b69"));

            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("6375b8a1-b6e7-4724-a1b4-8cc3acc98e43"));

            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("8590ae3d-351c-4438-bfe5-3f69dcf97349"));

            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("9e144dff-29f6-47da-b7ed-b55abd1a2cd3"));

            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("a28fb46e-e9b9-410e-9c31-d8ebfd22015c"));

            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("ae04abd7-d012-470d-9b8a-f38d9c5c94a8"));

            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("b5f03233-d733-4349-93df-db562b7d4376"));

            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("cc48bb40-fbf0-4054-818c-eb49545aaeea"));

            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("cd5d7538-b1d2-448d-b6ff-c139c35f9dc7"));

            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("ddf105e8-6534-46e4-832b-598daa84c4d5"));

            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("e47ab5de-9ea5-4075-8da5-7ae9f36538e2"));

            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("e482e866-9243-49d8-8676-403377de353c"));

            migrationBuilder.DeleteData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("ea57a262-6647-4e88-880c-82bc4227e916"));

            migrationBuilder.DeleteData(
                table: "SUnits",
                keyColumn: "Id",
                keyValue: new Guid("46ea45ff-ba5e-4f6f-bbc6-ebe65446efe8"));

            migrationBuilder.DeleteData(
                table: "SUnits",
                keyColumn: "Id",
                keyValue: new Guid("8d7a7b33-f2ed-4b4b-a869-3ad32fd9d192"));

            migrationBuilder.DeleteData(
                table: "SUnits",
                keyColumn: "Id",
                keyValue: new Guid("e04b1f07-6f05-403e-ac09-b999cac0df3e"));

            migrationBuilder.DeleteData(
                table: "SUnits",
                keyColumn: "Id",
                keyValue: new Guid("e46826b4-76f9-4b32-84b3-b9730e732839"));

            migrationBuilder.DeleteData(
                table: "SUnits",
                keyColumn: "Id",
                keyValue: new Guid("fc7acf3a-2c10-4200-9448-c3180c0a4400"));

            migrationBuilder.DeleteData(
                table: "SUnits",
                keyColumn: "Id",
                keyValue: new Guid("fd96bad9-b254-4b37-8eb9-ada68fe7dada"));

            migrationBuilder.DropColumn(
                name: "DugStatus",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "IsAllowZeroQuantity",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "IsAntibiotics",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "IsDrugContainerReturnRequest",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "IsInhalantDrug",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "IsNewDrug",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "IsNutraceutical",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "IsPrescriptionDrug",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "IsPrescriptionDrugForChildren",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "IsRadiolabeledDrug",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "IsSponsoredDrug",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "IsTraditionalDrugFormulation",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "IsTraditionalHerbalDrug",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "Origin",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "OtherExpenses",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "PharmaceuticalDivision",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "PharmaceuticalFormulation",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "PreparationMethod",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "ProcessingLossRate",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "QualityStandards",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "RequirementUseDug",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "ScientificName",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "ScientificNameChildren",
                table: "SMedicineTypes");

            migrationBuilder.DropColumn(
                name: "Inactive",
                table: "SMedicineLines");

            migrationBuilder.DropColumn(
                name: "HeInCode",
                table: "SCountries");

            migrationBuilder.RenameColumn(
                name: "SortOrder",
                table: "SMedicineLines",
                newName: "SoftOrder");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "SProvinces",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "SProvinces",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "SProvinces",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "SProvinces",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SProvinces",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "SProvinces",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedBy",
                table: "SProvinces",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "SProvinces",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "SCountries",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "SCountries",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "SCountries",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "SCountries",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SCountries",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "SCountries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedBy",
                table: "SCountries",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "SCountries",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("00be783e-d679-4f1c-9ae2-a4f4c79de0ef"),
                columns: new[] { "Code", "Name" },
                values: new object[] { "TH-DY", "Thuốc đông y" });

            migrationBuilder.UpdateData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("2fd41f93-ddb9-47dd-9833-4507ce71128c"),
                columns: new[] { "Code", "Name" },
                values: new object[] { "TH-TD", "Thuốc tân dược" });

            migrationBuilder.UpdateData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("35df3868-8db6-440d-809f-f4c345d804a7"),
                columns: new[] { "Code", "Name" },
                values: new object[] { "TH-MA", "Máu và chế phẩm máu" });

            migrationBuilder.UpdateData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("914ca65d-6579-4590-b963-fee8a743bae1"),
                columns: new[] { "Code", "Name" },
                values: new object[] { "TH-HT", "Thuốc hướng thần" });

            migrationBuilder.UpdateData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("c987b9d2-e599-49cc-99f3-d075d27cee7c"),
                columns: new[] { "Code", "Name" },
                values: new object[] { "TH-DT", "Dịch truyền" });

            migrationBuilder.UpdateData(
                table: "SMedicineGroups",
                keyColumn: "Id",
                keyValue: new Guid("ff9be71e-a958-4244-9df1-1582229c67d5"),
                columns: new[] { "Code", "Name" },
                values: new object[] { "TH-NG", "Thuốc gây nghiện" });
        }
    }
}
