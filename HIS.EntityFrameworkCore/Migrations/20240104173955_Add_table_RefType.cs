using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Add_table_RefType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BUS_Patient_DIC_National_NationalId",
                table: "BUS_Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_BUS_PatientRecord_DIC_National_NationalId",
                table: "BUS_PatientRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DIC_Item_DIC_National_CountryId",
                table: "DIC_Item");

            migrationBuilder.DropForeignKey(
                name: "FK_DIC_ItemType_DIC_National_CountryId",
                table: "DIC_ItemType");

            migrationBuilder.DropTable(
                name: "DIC_National");

            migrationBuilder.CreateTable(
                name: "DIC_Country",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HeInCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SYSRefTypeCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefTypeCategoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYSRefTypeCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SYSRefType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefTypeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RefTypeCategoryID = table.Column<int>(type: "int", nullable: true),
                    ParentID = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    SYSRefTypeCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYSRefType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SYSRefType_SYSRefTypeCategory_SYSRefTypeCategoryId",
                        column: x => x.SYSRefTypeCategoryId,
                        principalTable: "SYSRefTypeCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "DIC_Country",
                columns: new[] { "Id", "Code", "Description", "HeInCode", "Inactive", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), "VN", null, "000", false, "Việt Nam", 0 },
                    { new Guid("0105cfd9-5265-4dcc-b2d8-790abecd5577"), "PS", null, "PS", false, "Palestinian Authority", 0 },
                    { new Guid("02cd862f-7bf2-4dee-9d8d-869f67659eac"), "CX", null, "CX", false, "Christmas island", 0 },
                    { new Guid("05600686-62bc-4be9-b009-58ae6fac5dc2"), "UM", null, "UM", false, "United States Minor Outlying Islands", 0 },
                    { new Guid("05f8a24e-3764-41af-b79b-3e05da6964ad"), "TO", null, "276", false, "Tonga", 0 },
                    { new Guid("060539cd-d169-45c2-bec2-28a91e41bcb3"), "IL", null, "184", false, "Israel", 0 },
                    { new Guid("067dbcfb-9729-4016-aa0f-526f43657542"), "CL", null, "141", false, "Chile", 0 },
                    { new Guid("07c04d8d-4e1c-4896-ba8a-7d8172562b37"), "KP", null, "277", false, "Triều Tiên", 0 },
                    { new Guid("09127bf0-ff5d-4660-8fef-18b3107bf295"), "BI", null, "135", false, "Burundi", 0 },
                    { new Guid("0d9bf5f6-20bb-4b4f-8c3e-0b7205eabe19"), "PR", null, "PR", false, "Puerto Rico", 0 },
                    { new Guid("0f42743d-f2ae-4d4d-9e9c-6dcd785204ff"), "SE", null, "273", false, "Thụy Điển", 0 },
                    { new Guid("10a98338-7167-4e5b-b3e4-9515f63bb43d"), "FI", null, "241", false, "Phần Lan", 0 },
                    { new Guid("10f310c4-857b-431b-934c-19ebc560571c"), "IS", null, "179", false, "Iceland", 0 },
                    { new Guid("1137907c-6292-4973-8a6a-5a8a55216701"), "OM", null, "233", false, "Oman", 0 },
                    { new Guid("16bfb332-7ffe-4d31-a2a2-05e7cc250969"), "Z1", null, "Z1", false, "Sovereign Military Order of Malta (SMOM)", 0 },
                    { new Guid("1760cdb2-5d9e-4a4d-a422-9d2d54333b72"), "VA", null, "290", false, "Thành Vatican", 0 },
                    { new Guid("18be6a2d-0cc9-4e57-9b95-0fd5e0999094"), "LA", null, "193", false, "Lào", 0 },
                    { new Guid("19b9d4e2-dd04-4d66-ba70-e71a800b8563"), "CO", null, "142", false, "Colombia", 0 },
                    { new Guid("1a52542a-e4e8-4514-b84f-d8f7a0ce8bf5"), "HU", null, "177", false, "Hungary", 0 },
                    { new Guid("1bb67a2c-65b1-4437-b7db-61bb5c5c945a"), "NZ", null, "227", false, "New Zealand", 0 },
                    { new Guid("1bd96043-4837-4ab4-8812-0230d7cdc37c"), "BH", null, "117", false, "Bahrain", 0 },
                    { new Guid("1c1e8f0d-fa36-4dd5-a349-51f8f8cf1e11"), "RU", null, "231", false, "Nga", 0 },
                    { new Guid("1c3907c5-3cd4-4530-a28c-6d4acceec175"), "AZ", null, "113", false, "Azerbaijan", 0 },
                    { new Guid("1cb83a16-11a1-438b-8fd9-22e661c5904a"), "TN", null, "281", false, "Tunisia", 0 },
                    { new Guid("1cc02fda-f061-49ad-a4f1-ecb564a28c88"), "KZ", null, "187", false, "Kazakhstan", 0 },
                    { new Guid("1d374c8c-88c5-49ae-9c9c-0b2b362b1198"), "BR", null, "131", false, "Brasil", 0 },
                    { new Guid("1d41f179-ba78-41d6-8ecf-595c7d6de65a"), "MA", null, "209", false, "Maroc", 0 },
                    { new Guid("1df44627-4127-48c0-bbc7-2afc64cb75d2"), "CH", null, "274", false, "Thụy Sĩ", 0 },
                    { new Guid("1f0c0c80-dceb-47c4-9bfb-d9e2b29e8010"), "NR", null, "224", false, "Nauru", 0 },
                    { new Guid("20aa6e3b-0838-45fc-9769-161b291e5e24"), "Z4", null, "Z4", false, "Scotland", 0 },
                    { new Guid("212573b7-ec34-4844-b150-74f567de2c5d"), "GF", null, "GF", false, "French guiana", 0 },
                    { new Guid("21668f2b-b3d0-4927-9d67-3f9eee4736d6"), "AS", null, "AS", false, "Samoa thuộc Hoa Kỳ", 0 },
                    { new Guid("22174cd0-7b2d-4c6b-bb6c-5273e63d28f0"), "MY", null, "205", false, "Malaysia", 0 },
                    { new Guid("226d663e-46ee-4ab2-b385-b062345debd9"), "FR", null, "240", false, "Pháp", 0 },
                    { new Guid("23063395-5d36-41c9-9711-66722ab8849f"), "CZ", null, "252", false, "Séc", 0 },
                    { new Guid("24c5f9fa-e493-43a1-9d2a-c6d25dc2ea89"), "FY", null, "254", false, "Serbia", 0 },
                    { new Guid("25b7ed9b-8bfd-4601-a4c5-a59dfe5a3fab"), "AN", null, "AN", false, "Netherlands antilles", 0 },
                    { new Guid("25df127f-9fb7-4f1d-8a4f-484364e15f91"), "GN", null, "170", false, "Guinea", 0 },
                    { new Guid("264432ff-ba3d-4402-ae05-d3cbbdf7eef4"), "NE", null, "229", false, "Niger", 0 },
                    { new Guid("26d0e10a-43ea-4654-93be-00a21f60b760"), "PG", null, "237", false, "Papua New Guinea", 0 },
                    { new Guid("298cf3d9-cf13-401f-86b5-368d1c71ec77"), "GQ", null, "169", false, "Guinea Xích Đạo", 0 },
                    { new Guid("2e24284d-fe7b-477b-a3e9-23505ccbe379"), "Z6", null, "Z6", false, "Great Britain (See United Kingdom)", 0 },
                    { new Guid("2eab2085-d20b-4cc4-a85b-7567c9ce6ea9"), "LC", null, "247", false, "Saint Lucia", 0 },
                    { new Guid("2eb9de76-3d99-43a5-b17d-ba2f0e08c64a"), "NI", null, "228", false, "Nicaragua", 0 },
                    { new Guid("2eead3fb-8c57-4699-a48d-b9eb2a781d23"), "TF", null, "TF", false, "French Southern Territories", 0 },
                    { new Guid("2f4455d6-efee-4959-8dfd-6f7db81faadd"), "NP", null, "226", false, "Nepal", 0 },
                    { new Guid("2facb682-01d5-4798-bf0a-928bd471ecb3"), "CC", null, "CC", false, "Cocos (keeling) islands", 0 },
                    { new Guid("332e0e9e-0182-47a0-b894-ade71da83708"), "BB", null, "120", false, "Barbados", 0 },
                    { new Guid("33aeb885-ea5c-4343-8011-b1dccebdd65f"), "SA", null, "110", false, "Ả Rập Saudi", 0 },
                    { new Guid("347a0e24-276d-4a54-b92b-4b88b60179af"), "GM", null, "163", false, "Gambia", 0 },
                    { new Guid("36299397-b100-420b-bd1b-3f18eda310fa"), "TD", null, "270", false, "Tchad", 0 },
                    { new Guid("3671801a-1c88-4dc6-9e75-d766644c2af9"), "SR", null, "264", false, "Suriname", 0 },
                    { new Guid("36ddc306-adf0-4897-a200-6377ff0d9042"), "TT", null, "278", false, "Trinidad và Tobago", 0 },
                    { new Guid("39351753-1af5-4797-89e2-b97589db8d2e"), "AZ", null, "114", false, "Cộng hòa Azerbaijan", 0 },
                    { new Guid("39ef7fcd-b539-46be-90a6-bc3f6d1524d8"), "KR", null, "174", false, "Hàn Quốc", 0 },
                    { new Guid("3adb70b0-ae40-4ac0-8a27-15398cc79d49"), "GS", null, "GS", false, "South georgia and the south sandwich islands", 0 },
                    { new Guid("3af1daa8-65e1-4502-823d-3c8530608104"), "MP", null, "MP", false, "Northern mariana islands", 0 },
                    { new Guid("3d9d9ca5-3356-48b3-b518-eb806a6128ee"), "VU", null, "289", false, "Vanuatu", 0 },
                    { new Guid("3dac050e-a2a6-469b-b0bb-def2e17544a5"), "GW", null, "168", false, "Guinea-Bissau", 0 },
                    { new Guid("3de67d92-a46e-4113-bd12-2e89a48aa1f0"), "CN", null, "279", false, "Trung Quốc", 0 },
                    { new Guid("3edffd99-5e14-4466-9f3e-a72ab48711d7"), "HM", null, "HM", false, "Heard and mc donald islands", 0 },
                    { new Guid("3f3e1d5e-ca7b-45ef-9e1e-f3c471e8894f"), "ST", null, "251", false, "São Tomé và Príncipe", 0 },
                    { new Guid("426516a2-46e9-4103-8b44-22b4a30b21ae"), "LS", null, "195", false, "Lesotho", 0 },
                    { new Guid("4452efd3-9727-4c5c-9cc9-76f7270c673d"), "CI", null, "130", false, "Bờ Biển Ngà", 0 },
                    { new Guid("44ff82d4-3356-4f71-9aa2-dc5f161537f0"), "SY", null, "266", false, "Syria", 0 },
                    { new Guid("45696681-b325-4d55-b4ea-56a920227907"), "SL", null, "256", false, "Sierra Leone", 0 },
                    { new Guid("4589f414-2018-4196-a42a-68fa60b41dae"), "MZ", null, "219", false, "Mozambique", 0 },
                    { new Guid("45a0ebe0-51be-423b-8885-7a7bf06e6f95"), "BA", null, "127", false, "Bosna và Hercegovina", 0 },
                    { new Guid("46651a82-3d63-4a24-baff-9bb1ee8ac492"), "CF", null, "280", false, "Trung Phi", 0 },
                    { new Guid("484be820-41ff-4911-94c6-2d2969764ac4"), "CD", null, "145", false, "Cộng hòa Dân chủ Congo", 0 },
                    { new Guid("4b12f61e-5980-415f-a62b-b296753fd70d"), "PT", null, "129", false, "Bồ Đào Nha", 0 },
                    { new Guid("4b7309a1-de33-4f43-a2ff-3f11e0e5869b"), "SM", null, "250", false, "San Marino", 0 },
                    { new Guid("4bab2495-c861-47e7-82e6-1806fd87b767"), "IM", null, "IM", false, "Isle of man", 0 },
                    { new Guid("4dbc51c5-3faa-4e76-b0d5-a28df95c5c01"), "GT", null, "167", false, "Guatemala", 0 },
                    { new Guid("4dcd4bda-0da9-415d-8f7e-ecd5841ad250"), "ER", null, "158", false, "Eritrea", 0 },
                    { new Guid("4e6e77af-56d6-4314-ac68-c39713511d70"), "IE", null, "183", false, "Ireland", 0 },
                    { new Guid("50202b21-f7c0-42eb-89bd-4470e82f3943"), "JE", null, "JE", false, "Jersey", 0 },
                    { new Guid("502c14cb-18ea-461f-9bc0-9591b056284c"), "DK", null, "153", false, "Đan Mạch", 0 },
                    { new Guid("506ddd2c-4f81-4d6d-806c-4c9e605bab3f"), "KN", null, "246", false, "Saint Kitts và Nevis", 0 },
                    { new Guid("509f7d40-e740-472f-8a7a-84b5a527eb96"), "KG", null, "192", false, "Kyrgyzstan", 0 },
                    { new Guid("50c044c3-6cd1-46ad-b10a-e879291806f2"), "NU", null, "NU", false, "Niue", 0 },
                    { new Guid("52595376-4b2b-4746-bb17-16f7ba234a33"), "MW", null, "204", false, "Malawi", 0 },
                    { new Guid("5300fbb8-1d3b-48c2-b251-c9daab165b94"), "SH", null, "SH", false, "St. Helena", 0 },
                    { new Guid("5351587c-9713-44c9-9088-9626d01300c8"), "TK", null, "TK", false, "Tokelau", 0 },
                    { new Guid("539247ef-f9a9-4893-b250-2aa204a87640"), "VG", null, "VG", false, "Virgin Islands (British)", 0 },
                    { new Guid("53b7d739-4b49-4a35-9d04-93520d79d105"), "TJ", null, "267", false, "Tajikistan", 0 },
                    { new Guid("53fdbb96-c808-4474-83bc-084e422a8b95"), "BY", null, "121", false, "Belarus", 0 },
                    { new Guid("54ca17f4-f6f7-4bcf-9809-8d45153c2271"), "LR", null, "197", false, "Liberia", 0 },
                    { new Guid("561d896e-c3c5-4dfc-b13c-790aa25fbd5d"), "PA", null, "236", false, "Panama", 0 },
                    { new Guid("5701a860-793e-4660-9302-005b27d4348e"), "AO", null, "106", false, "Angola", 0 },
                    { new Guid("573dec77-5908-42b2-b1a5-8a5ee8407dee"), "GD", null, "165", false, "Grenada", 0 },
                    { new Guid("57c01cf1-7f20-4a6c-bec9-bcc9a3a039fe"), "SG", null, "257", false, "Singapore", 0 },
                    { new Guid("58357a87-d3a9-4ea4-82ea-eb7775f1c568"), "IR", null, "181", false, "Iran", 0 },
                    { new Guid("58486abc-86a6-4bb8-a610-eb0e4bdf0b73"), "LT", null, "200", false, "Litva", 0 },
                    { new Guid("58776bc3-ee4b-44ae-ac9e-a501437bde2f"), "PF", null, "PF", false, "French Polynesia", 0 },
                    { new Guid("58d12ab1-4946-45f9-bef5-354e5803f357"), "DO", null, "152", false, "Cộng hòa Dominicana", 0 },
                    { new Guid("59e93599-98e9-44de-b9d1-bbbf17c599bf"), "ZA", null, "223", false, "Nam Phi", 0 },
                    { new Guid("5a68453d-81d4-4417-a579-33d6a1c27ea6"), "PE", null, "239", false, "Peru", 0 },
                    { new Guid("5b526a49-1694-4eb8-b602-4e150d12184d"), "MC", null, "216", false, "Monaco", 0 },
                    { new Guid("5bd03273-5b23-4181-892c-397126e8da56"), "PK", null, "234", false, "Pakistan", 0 },
                    { new Guid("5d60e969-8387-42e4-b866-31dfb209f433"), "Z3", null, "Z3", false, "England", 0 },
                    { new Guid("5dc567de-1249-4aaa-9d49-04dcd3501220"), "ES", null, "269", false, "Tây Ban Nha", 0 },
                    { new Guid("5f4a7dfd-c3ed-4796-bde2-94199e595ef0"), "BV", null, "BV", false, "Bouvet island", 0 },
                    { new Guid("62947f31-4a3e-441b-a9d2-9642ce61de2f"), "KI", null, "189", false, "Kiribati", 0 },
                    { new Guid("62b0c6c0-4a45-4f33-b35e-d184d815518e"), "GH", null, "164", false, "Ghana", 0 },
                    { new Guid("63c8621a-fc44-4abe-ba08-8d80520280cf"), "SC", null, "255", false, "Seychelles", 0 },
                    { new Guid("6477d7a3-465e-4277-a4eb-ef09b13f5eca"), "MO", null, "MO", false, "Macau", 0 },
                    { new Guid("66169c75-2aa7-409a-a7b9-d8cfe6ac80c0"), "LB", null, "196", false, "Li ban", 0 },
                    { new Guid("66400b32-893a-489c-a5e1-180d55fb20d4"), "KE", null, "188", false, "Kenya", 0 },
                    { new Guid("66533605-d826-4aec-9536-e4d30effefda"), "AL", null, "103", false, "Albania", 0 },
                    { new Guid("665d03c6-346e-43d8-ad21-31492b4382aa"), "JO", null, "186", false, "Jordan", 0 },
                    { new Guid("686b79de-db2f-4ccd-946c-1bef80cd503e"), "CA", null, "140", false, "Canada", 0 },
                    { new Guid("6b24b562-1294-4537-a69a-26ac34c41521"), "AD", null, "105", false, "Andorra", 0 },
                    { new Guid("6b8836aa-2476-4d82-98f1-0b7f56e66f7a"), "TL", null, "TL", false, "Timor Leste", 0 },
                    { new Guid("6c408b50-b4be-4eca-a710-11a6d914cf4f"), "AT", null, "109", false, "Áo", 0 },
                    { new Guid("6d2d2371-8785-4a7b-94ba-84c804b2b0a2"), "RE", null, "RE", false, "Reunion", 0 },
                    { new Guid("6d5a6761-432b-4bd2-9b04-5e01c421de23"), "NF", null, "NF", false, "Norfolk Island", 0 },
                    { new Guid("716a0688-0378-4941-af8f-c11dc4c45ac2"), "TC", null, "TC", false, "Turks and Caicos Islands", 0 },
                    { new Guid("720aaa71-3cc0-470f-b56c-472ac37a6574"), "BE", null, "125", false, "Bỉ", 0 },
                    { new Guid("72d527d4-00df-4f9a-b0e1-e1fa84a4ba6d"), "SO", null, "261", false, "Somalia", 0 },
                    { new Guid("74c266fd-7287-4525-aca3-6bb66ddcf61f"), "WS", null, "249", false, "Samoa", 0 },
                    { new Guid("75de9dea-ef0f-4492-890a-f5af36cce7aa"), "CG", null, "144", false, "Cộng hòa Congo", 0 },
                    { new Guid("76c42f0f-bfb2-4a11-b5a4-e854f74e72cd"), "BZ", null, "122", false, "Belize", 0 },
                    { new Guid("77365013-80d7-44d5-bd8d-472542cac431"), "MQ", null, "MQ", false, "Martinique", 0 },
                    { new Guid("788693d2-4ac9-4f85-94bf-13d021bc000d"), "PM", null, "PM", false, "St. Pierre and Miquelon", 0 },
                    { new Guid("78dcfd52-de7b-4c1d-9ded-0e5d3f7a8a35"), "MT", null, "208", false, "Malta", 0 },
                    { new Guid("79bc1ba0-a0f6-4065-9783-9e01ade32cde"), "PN", null, "PN", false, "Pitcairn", 0 },
                    { new Guid("7a384197-d55e-44b8-b389-a65f17e74e1f"), "PH", null, "242", false, "Philippines", 0 },
                    { new Guid("7af80a81-41e5-47de-abd3-7ce25f9c39b4"), "TM", null, "282", false, "Turkmenistan", 0 },
                    { new Guid("7afaefc0-9aa8-4ba7-98ae-618682a5be7f"), "KM", null, "143", false, "Comoros", 0 },
                    { new Guid("7b0c9a9c-e730-4b96-9372-e9ef8ab5339b"), "BM", null, "BM", false, "Bermuda", 0 },
                    { new Guid("7bea406c-221d-45dd-aca6-a2ceb90741aa"), "DM", null, "151", false, "Dominica", 0 },
                    { new Guid("7e27cb42-41fb-4b20-b26b-3c1ea9b4ff5c"), "SB", null, "260", false, "Solomon", 0 },
                    { new Guid("7ef68b6d-2d6b-4688-95bc-d0fd79ffb6c5"), "CY", null, "191", false, "Síp", 0 },
                    { new Guid("7f233816-fe94-4941-8125-b62c88410fa9"), "BD", null, "119", false, "Bangladesh", 0 },
                    { new Guid("8562fd7f-49aa-46cf-bbc9-71f7460c6ba7"), "SZ", null, "265", false, "Swaziland", 0 },
                    { new Guid("8592d87f-720b-48e7-82ee-e82d64cbf984"), "AG", null, "108", false, "Antigua và Barbuda", 0 },
                    { new Guid("8764ee96-c950-44cf-a1f4-7636126c671b"), "BS", null, "116", false, "Bahamas", 0 },
                    { new Guid("882c80ef-806d-4370-9fb1-f00a13a7a5c1"), "LV", null, "194", false, "Latvia", 0 },
                    { new Guid("8a003437-323c-451c-b211-1886f79c25f1"), "MV", null, "206", false, "Maldives", 0 },
                    { new Guid("8a6a8442-1533-4bba-9a05-ed707122573e"), "GR", null, "178", false, "Hy Lạp", 0 },
                    { new Guid("8f800608-e254-418d-8163-78f71be4873f"), "EG", null, "102", false, "Ai Cập", 0 },
                    { new Guid("8ff51ea0-476b-4dec-8736-70cc36ea1d2c"), "NO", null, "225", false, "Na Uy", 0 },
                    { new Guid("90b2a6a0-bacd-4175-80e9-b8fde9233786"), "KW", null, "190", false, "Kuwait", 0 },
                    { new Guid("90ef0553-8520-4d57-ae3b-112ebf28b313"), "ZW", null, "295", false, "Zimbabwe", 0 },
                    { new Guid("92aea1da-5cf2-40fa-92a2-cce297949451"), "SI", null, "259", false, "Slovenia", 0 },
                    { new Guid("92b69f82-f3e2-4ea9-9d4b-1763b1a75dec"), "MX", null, "213", false, "Mexico", 0 },
                    { new Guid("93fc49be-bd23-41c3-8538-4b424a7806da"), "CV", null, "CV", false, "Cape verde", 0 },
                    { new Guid("9412c9e0-c4fe-442f-8b13-ea064bf48703"), "LI", null, "199", false, "Liechtenstein", 0 },
                    { new Guid("9601fc62-41b1-44af-af8e-8a03c91c96b8"), "JP", null, "232", false, "Nhật Bản", 0 },
                    { new Guid("97bc234b-7d4c-4870-801b-74f1998741be"), "US", null, "175", false, "Hoa Kỳ", 0 },
                    { new Guid("98062645-5015-4d8c-886e-3fb70c247ada"), "GP", null, "GP", false, "Guadeloupe", 0 },
                    { new Guid("994cf06f-b833-4415-84e0-94f3847b6dd8"), "KY", null, "KY", false, "Cayman islands", 0 },
                    { new Guid("99cfce62-6540-4525-97b8-9a2e62618e05"), "SJ", null, "SJ", false, "Svalbard and Jan Mayen Islands", 0 },
                    { new Guid("9acb769e-d2de-479c-b66a-424ce710a036"), "NG", null, "230", false, "Nigeria", 0 },
                    { new Guid("9d5769fe-b3ae-4697-9150-44674e8008ba"), "DE", null, "155", false, "Đức", 0 },
                    { new Guid("9ded845f-06a1-4651-8903-bc46f7978c84"), "GE", null, "GE", false, "Georgia", 0 },
                    { new Guid("9eb57842-f592-4080-affd-71b43f7d0517"), "AQ", null, "AQ", false, "Antarctica", 0 },
                    { new Guid("9ee7b166-4c6f-4136-8928-c6246c3e76d5"), "UZ", null, "288", false, "Uzbekistan", 0 },
                    { new Guid("a1080c01-e5bb-4e3f-8784-f0678f1eff58"), "DJ", null, "150", false, "Djibouti", 0 },
                    { new Guid("a1ba5be8-fef9-470a-a5f7-efcf7fc900a4"), "ME", null, "218", false, "Montenegro", 0 },
                    { new Guid("a1f120ed-4785-486e-b796-dd8cd569a415"), "VC", null, "248", false, "Saint Vincent và Grenadines", 0 },
                    { new Guid("a30f588b-166d-4118-9d33-b8294e15ad44"), "SD", null, "263", false, "Sudan", 0 },
                    { new Guid("a3597652-cc84-40ff-b143-208ee8473e93"), "EA", null, "154", false, "Đông Timor", 0 },
                    { new Guid("a3c5c224-a013-4e23-8655-641a0a76b38a"), "PW", null, "235", false, "Palau", 0 },
                    { new Guid("a695b824-cfc2-40a3-b5a1-35243a6e2116"), "YE", null, "293", false, "Yemen", 0 },
                    { new Guid("a7a696de-3fd8-48c2-b87a-6464b222af87"), "VE", null, "291", false, "Venezuela", 0 },
                    { new Guid("a8b38e56-d3ea-435f-907a-615ed7ced805"), "AF", null, "101", false, "Afghanistan", 0 },
                    { new Guid("aa3d56b9-f398-4be1-b8ae-9f8563101b6e"), "IT", null, "292", false, "Ý", 0 },
                    { new Guid("aa4399ec-1ff3-4837-a68e-0df0720162cb"), "MR", null, "211", false, "Mauritanie", 0 },
                    { new Guid("aa745539-b444-49d2-ad13-14149f8a1645"), "BO", null, "126", false, "Bolivia", 0 },
                    { new Guid("ab16a3ed-00cd-4445-8e7c-770b1965232e"), "NL", null, "173", false, "Hà Lan", 0 },
                    { new Guid("abdfeb5b-a4b8-4ab1-b6b8-83f7fb72ec23"), "EE", null, "159", false, "Estonia", 0 },
                    { new Guid("ad4ef5f1-e823-4ed4-9ad5-cec4a2cae6af"), "UG", null, "285", false, "Uganda", 0 },
                    { new Guid("af24512b-01ae-4420-96cb-62051ede96cc"), "UA", null, "286", false, "Ukraina", 0 },
                    { new Guid("af3badc9-b6da-4eb0-8a42-ecf8dfd6ae19"), "AM", null, "112", false, "Armenia", 0 },
                    { new Guid("af9c2425-679e-4459-8c68-2d357f4f93e5"), "PY", null, "238", false, "Paraguay", 0 },
                    { new Guid("affdf19e-5ed4-497a-97d0-0fc95a547785"), "LK", null, "262", false, "Sri Lanka", 0 },
                    { new Guid("b16a509f-5c70-42b1-a05e-6d4426c721ca"), "IQ", null, "182", false, "Iraq", 0 },
                    { new Guid("b171e933-4b7d-46f5-802a-14c5c9234ed7"), "ML", null, "207", false, "Mali", 0 },
                    { new Guid("b1829e62-c3dd-4f65-8c41-fdbe26aedb93"), "MG", null, "203", false, "Madagascar", 0 },
                    { new Guid("b4e019b1-042b-465c-baf9-60d525d9b85c"), "CK", null, "CK", false, "Cook islands", 0 },
                    { new Guid("b6169a90-920f-425d-a275-82601862a220"), "SK", null, "258", false, "Slovakia", 0 },
                    { new Guid("b83926c4-6963-4f82-97f7-dffa6e87ea7d"), "MK", null, "202", false, "Macedonia", 0 },
                    { new Guid("b83be42b-cde9-4dc3-a838-d8197d2c678f"), "FO", null, "FO", false, "Faroe islands", 0 },
                    { new Guid("ba7304bd-7e25-4731-a60f-10c13589c71a"), "ET", null, "160", false, "Ethiopia", 0 },
                    { new Guid("ba947c48-36fb-420b-b2d9-663fe308b18c"), "TG", null, "275", false, "Togo", 0 },
                    { new Guid("bcb96598-0e05-4316-86d3-80413326555a"), "MH", null, "210", false, "Quần đảo Marshall", 0 },
                    { new Guid("be946a16-a1af-499c-9bd8-ca12a22fb69c"), "CU", null, "149", false, "Cuba", 0 },
                    { new Guid("bf1bf333-4604-4974-838f-886100c006f3"), "TW", null, "TW", false, "Đài Loan", 0 },
                    { new Guid("c4065df0-2539-4046-bb77-7d699a072734"), "FM", null, "214", false, "Micronesia", 0 },
                    { new Guid("c5c14db2-753f-4e28-88b5-3b9e502fa0c6"), "BN", null, "132", false, "Brunei", 0 },
                    { new Guid("c6f6287f-39f6-4470-ad46-ac539eef3052"), "EC", null, "156", false, "Ecuador", 0 },
                    { new Guid("c7f500b0-be15-4ab8-ae5c-1db430d19b8c"), "YT", null, "YT", false, "Mayotte", 0 },
                    { new Guid("c831fb16-910b-4939-804a-1052b8f8adc1"), "HT", null, "172", false, "Haiti", 0 },
                    { new Guid("c8766416-ed13-4631-a9c4-e89e782055c9"), "Z7", null, "Z7", false, "Wales", 0 },
                    { new Guid("cba207c9-9ee4-4a20-876b-ecb1160d0845"), "SN", null, "253", false, "Sénégal", 0 },
                    { new Guid("cbf1c521-494b-4981-9dc9-b6a1b229c01d"), "JM", null, "185", false, "Jamaica", 0 },
                    { new Guid("cc2a4d3b-bae2-4602-9d23-4d4d2d918699"), "MD", null, "215", false, "Moldova", 0 },
                    { new Guid("cdd52492-d981-4972-9f41-4b1774c002ee"), "GI", null, "GI", false, "Gibraltar", 0 },
                    { new Guid("cf8c2ebc-2ed1-404c-875c-d2151d54ab9e"), "MM", null, "220", false, "Myanma", 0 },
                    { new Guid("d0357290-582a-47cd-984c-8815d38454be"), "Z5", null, "Z5", false, "Northern Ireland", 0 },
                    { new Guid("d1fef153-87bc-403a-9590-0ec4cc8d676e"), "PL", null, "118", false, "Ba Lan", 0 },
                    { new Guid("d200b4b5-7435-41a9-be8b-b6a80e14120b"), "IO", null, "IO", false, "British indian ocean territory", 0 },
                    { new Guid("d2ebac27-3463-40cb-9eb2-86e1da12a3ba"), "MS", null, "MS", false, "Montserrat", 0 },
                    { new Guid("d34d65e5-253f-4324-9aee-f74045802e47"), "GG", null, "GG", false, "Guernsey", 0 },
                    { new Guid("d3c10501-b94f-4a0e-b871-80d4b3d7bbbb"), "HK", null, "HK", false, "Hong kong", 0 },
                    { new Guid("d50a063a-82ef-4b56-858e-1a8794b32878"), "HN", null, "176", false, "Honduras", 0 },
                    { new Guid("d576474f-de6a-45fc-bd19-e18a2915f1a4"), "CR", null, "146", false, "Costa Rica", 0 },
                    { new Guid("d892c6c0-bf86-4487-ab8b-5af35cc32a0c"), "GV", null, "171", false, "Guyana", 0 },
                    { new Guid("d94b5935-e6d2-4aa7-b9f7-d332badacd8d"), "BT", null, "124", false, "Bhutan", 0 },
                    { new Guid("da333d92-e16c-4b49-b9d8-669df9032f82"), "FJ", null, "161", false, "Fiji", 0 },
                    { new Guid("dd79ead4-6e12-4cb8-aff5-8f00d8bf9e99"), "SD", null, "222", false, "Nam Sudan", 0 },
                    { new Guid("dd951a03-c803-4351-aac5-ed4ec9922bab"), "QA", null, "243", false, "Qatar", 0 },
                    { new Guid("ddf4ecad-6f97-4bde-84fe-2b9dc51f0ffd"), "BW", null, "128", false, "Botswana", 0 },
                    { new Guid("de0d7be8-8a87-4358-b93e-e809ab17f238"), "RO", null, "244", false, "Romania", 0 },
                    { new Guid("e180ff8a-4e49-4edd-9168-21b372b8d9b7"), "BG", null, "133", false, "Bulgaria", 0 },
                    { new Guid("e1fc9395-73b5-4fd6-8c31-37fef3a3e866"), "ZM", null, "294", false, "Zambia", 0 },
                    { new Guid("e369137c-1730-4809-88e4-e43031327233"), "BF", null, "134", false, "Burkina Faso", 0 },
                    { new Guid("e3a2237c-9d57-462f-bad8-7a78856303c8"), "ID", null, "180", false, "Indonesia", 0 },
                    { new Guid("e43c3f5c-e8d7-430a-9869-e61337bd4188"), "Z2", null, "Z2", false, "British Southern and Antarctic Territories", 0 },
                    { new Guid("e4acc3fd-7e2d-4927-b7e8-797cb8a29a86"), "GU", null, "GU", false, "Guam", 0 },
                    { new Guid("e4c05566-0c8d-42a4-a2e9-ad4d6d33b35f"), "AI", null, "AI", false, "Anguilla", 0 },
                    { new Guid("e5439053-279d-4094-852d-0c2edc6992ed"), "SV", null, "157", false, "El Salvador", 0 },
                    { new Guid("e5837adb-d926-41f1-8434-73fed9db7504"), "AW", null, "AW", false, "Aruba việt nam", 0 },
                    { new Guid("e6e7518f-73eb-4010-b0cf-6dcc5c8f8e01"), "DZ", null, "104", false, "Algérie", 0 },
                    { new Guid("e9455b51-bd57-482f-a979-5ecf6c8c4afd"), "GB", null, "107", false, "Vương quốc Liên hiệp Anh và Bắc Ireland", 0 },
                    { new Guid("edb5a6e1-b084-4e46-87ab-22d38da9cf0a"), "UY", null, "287", false, "Uruguay", 0 },
                    { new Guid("edcecb3c-ffcb-451f-8e24-02a0bf6499ae"), "IN", null, "115", false, "Cộng hòa Ấn Độ", 0 },
                    { new Guid("ee02aa87-f8dc-44ac-9ac9-830120f05656"), "TR", null, "272", false, "Thổ Nhĩ Kỳ", 0 },
                    { new Guid("ee707e39-4195-426c-abf9-1ce21a771350"), "NA", null, "221", false, "Namibia", 0 },
                    { new Guid("f034e368-335c-4a9f-a039-b7ea83f8a315"), "LU", null, "201", false, "Luxembourg", 0 },
                    { new Guid("f07d3dde-aea1-4f0a-ba9d-310cda4fa6e9"), "TH", null, "271", false, "Thái Lan", 0 },
                    { new Guid("f1218849-b5cf-43c8-b3c4-b1ff145f27fc"), "MU", null, "212", false, "Mauritius", 0 },
                    { new Guid("f1c02c7d-3154-4e55-817c-1e24f6eef729"), "GA", null, "162", false, "Gabon", 0 },
                    { new Guid("f21a86da-a1de-4023-93c9-3a23d315a8cd"), "RW", null, "245", false, "Rwanda", 0 },
                    { new Guid("f36eb030-510e-4ca0-b7c4-a1c1ef656dd6"), "FK", null, "FK", false, "Falkland islands (malvinas)", 0 },
                    { new Guid("f468cb27-57fb-4b75-b3b7-70bb33ca2705"), "KH", null, "139", false, "Campuchia", 0 },
                    { new Guid("f5874f17-6c1e-4c07-b8bf-41b76546f6f0"), "CM", null, "138", false, "Cameroon", 0 },
                    { new Guid("f5f9c1ed-f4fb-4cff-aee3-2bcb0d8eed3e"), "NC", null, "NC", false, "New Caledonia", 0 },
                    { new Guid("f5fdcb6c-e0c5-4a57-adca-e743ba60ccee"), "LY", null, "198", false, "Libya", 0 },
                    { new Guid("f79baaf7-6191-4ba9-b38a-2f1b50d05598"), "TV", null, "283", false, "Tuvalu", 0 },
                    { new Guid("f9375017-9897-4487-8916-c98d22fd05b9"), "GL", null, "GL", false, "Greenland", 0 },
                    { new Guid("fb10ce71-e68a-4a70-bf7e-5edee9388d48"), "AE", null, "137", false, "Các Tiểu Vương quốc Ả Rập Thống nhất", 0 },
                    { new Guid("fb67b422-6903-494e-945d-fa09f031b4f1"), "VI", null, "VI", false, "Virgin Islands (U.S.)", 0 },
                    { new Guid("fc5a0c05-ebac-4906-8a9f-dddcdbcc0a9d"), "AU", null, "284", false, "Úc", 0 },
                    { new Guid("fd0ac376-bf65-4bf8-9067-245691aa1827"), "HR", null, "147", false, "Croatia", 0 },
                    { new Guid("fd21963c-7b5e-44a8-8d70-2edbda437946"), "MN", null, "217", false, "Mông Cổ", 0 },
                    { new Guid("fd235817-1607-4f4c-83c7-ff5bd0012896"), "BJ", null, "123", false, "Benin", 0 },
                    { new Guid("fd32d265-24dd-4073-a4b8-59e6358b59ed"), "AR", null, "111", false, "Argentina", 0 },
                    { new Guid("fe657d37-7960-4bb3-8f15-81666fca928d"), "EH", null, "EH", false, "Western sahara", 0 },
                    { new Guid("ff78779a-45cd-4076-8c61-442a9a3873f2"), "TZ", null, "268", false, "Tanzania", 0 },
                    { new Guid("ffd3fabd-a5f1-4442-837b-d53b5d89272e"), "WF", null, "WF", false, "Wallis and Futuna Islands", 0 }
                });

            migrationBuilder.UpdateData(
                table: "DIC_DeathCause",
                keyColumn: "Id",
                keyValue: new Guid("4333ca55-4d7c-4be0-b9a2-2125624f0229"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 843, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "DIC_DeathCause",
                keyColumn: "Id",
                keyValue: new Guid("4d5b5c50-6be0-434e-8baa-a528af4a58b5"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 843, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "DIC_DeathCause",
                keyColumn: "Id",
                keyValue: new Guid("c0a4d767-7ba9-4006-a0a9-020b6322c2ef"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 843, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "DIC_DeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("66c3a43b-f9d0-4876-81e2-b13c5f188589"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 844, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "DIC_DeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("7693d6ec-cf0f-44c1-a9d7-fb997335ae10"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 844, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "DIC_DeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("8f2b1eeb-a4bd-4f84-b59c-98145c58b1ab"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 844, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "DIC_DeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("f91d8342-619c-435b-b51c-8b3d7f541222"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 844, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordTypeGroup",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordTypeGroup",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordTypeGroup",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 847, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "DIC_PatientRecordType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 848, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "DIC_PatientRecordType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 848, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "DIC_PatientRecordType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 848, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "DIC_PatientType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 848, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "DIC_PatientType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 848, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "DIC_PatientType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 848, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "DIC_PatientType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 848, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "DIC_PatientType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 848, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "DIC_PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("0b348363-c888-4c9a-b145-c3389fdcca37"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 848, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "DIC_PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("8bff9824-1df2-419e-88ab-e098a6fc4e7e"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 848, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "DIC_PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("dd39afc0-1de0-4287-a126-4dada6788508"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 848, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "DIC_ReceptionObjectType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 849, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "DIC_ReceptionObjectType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 0, 39, 54, 849, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.InsertData(
                table: "SYSRefType",
                columns: new[] { "Id", "Description", "ParentID", "RefTypeCategoryID", "RefTypeName", "SYSRefTypeCategoryId", "SortOrder" },
                values: new object[,]
                {
                    { 101, null, null, 1, "Quản lý người dùng", null, 2 },
                    { 102, null, null, 1, "Loại đối tượng bệnh nhân", null, 3 },
                    { 103, null, null, 1, "Loại đối tượng đăng ký khám", null, 4 },
                    { 104, null, null, 1, "Loại bệnh án", null, 5 },
                    { 199, null, null, 1, "Tùy chọn", null, 9 },
                    { 201, null, null, 2, "Chi nhánh", null, 1 },
                    { 202, null, null, 2, "Khoa", null, 2 },
                    { 203, null, null, 2, "Phòng", null, 3 },
                    { 204, null, null, 2, "Quốc tịch", null, 4 },
                    { 205, null, null, 2, "Tỉnh, thành phố", null, 5 },
                    { 206, null, null, 2, "Quận, huyện", null, 6 },
                    { 207, null, null, 2, "Xã, phường", null, 7 },
                    { 208, null, null, 2, "Dân tộc", null, 8 },
                    { 209, null, null, 2, "Giới tính", null, 9 },
                    { 210, null, null, 2, "Nghề nghiệp", null, 10 },
                    { 211, null, null, 2, "Tôn giáo", null, 11 },
                    { 212, null, null, 2, "Nơi sống", null, 12 },
                    { 301, null, null, 3, "Đón tiếp", null, 1 },
                    { 401, null, null, 4, "Khám bệnh", null, 3 }
                });

            migrationBuilder.InsertData(
                table: "SYSRefTypeCategory",
                columns: new[] { "Id", "Description", "RefTypeCategoryName", "SortOrder" },
                values: new object[,]
                {
                    { 1, "Các chức năng quản lý và xử lý hệ thống", "Hệ thống", 1 },
                    { 2, "Các chức năng người dùng khai báo", "Danh mục", 2 },
                    { 3, "Các chức năng tiếp đón", "Đón tiếp", 3 },
                    { 4, "Các chức năng khám bệnh", "Khám bệnh", 4 },
                    { 99, "Khác", "Khác", 99 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SYSRefType_SYSRefTypeCategoryId",
                table: "SYSRefType",
                column: "SYSRefTypeCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BUS_Patient_DIC_Country_NationalId",
                table: "BUS_Patient",
                column: "NationalId",
                principalTable: "DIC_Country",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BUS_PatientRecord_DIC_Country_NationalId",
                table: "BUS_PatientRecord",
                column: "NationalId",
                principalTable: "DIC_Country",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DIC_Item_DIC_Country_CountryId",
                table: "DIC_Item",
                column: "CountryId",
                principalTable: "DIC_Country",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DIC_ItemType_DIC_Country_CountryId",
                table: "DIC_ItemType",
                column: "CountryId",
                principalTable: "DIC_Country",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BUS_Patient_DIC_Country_NationalId",
                table: "BUS_Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_BUS_PatientRecord_DIC_Country_NationalId",
                table: "BUS_PatientRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DIC_Item_DIC_Country_CountryId",
                table: "DIC_Item");

            migrationBuilder.DropForeignKey(
                name: "FK_DIC_ItemType_DIC_Country_CountryId",
                table: "DIC_ItemType");

            migrationBuilder.DropTable(
                name: "DIC_Country");

            migrationBuilder.DropTable(
                name: "SYSRefType");

            migrationBuilder.DropTable(
                name: "SYSRefTypeCategory");

            migrationBuilder.CreateTable(
                name: "DIC_National",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    HeInCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIC_National", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "DIC_DeathCause",
                keyColumn: "Id",
                keyValue: new Guid("4333ca55-4d7c-4be0-b9a2-2125624f0229"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 882, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "DIC_DeathCause",
                keyColumn: "Id",
                keyValue: new Guid("4d5b5c50-6be0-434e-8baa-a528af4a58b5"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 882, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "DIC_DeathCause",
                keyColumn: "Id",
                keyValue: new Guid("c0a4d767-7ba9-4006-a0a9-020b6322c2ef"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 882, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "DIC_DeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("66c3a43b-f9d0-4876-81e2-b13c5f188589"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 883, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "DIC_DeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("7693d6ec-cf0f-44c1-a9d7-fb997335ae10"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 883, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "DIC_DeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("8f2b1eeb-a4bd-4f84-b59c-98145c58b1ab"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 883, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "DIC_DeathWithin",
                keyColumn: "Id",
                keyValue: new Guid("f91d8342-619c-435b-b51c-8b3d7f541222"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 883, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordType",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordTypeGroup",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordTypeGroup",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "DIC_MedicalRecordTypeGroup",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 886, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.InsertData(
                table: "DIC_National",
                columns: new[] { "Id", "Code", "Description", "HeInCode", "Inactive", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("0103bc86-7105-49c2-905a-cb83d3ee87c2"), "VN", null, "000", false, "Việt Nam", 0 },
                    { new Guid("0105cfd9-5265-4dcc-b2d8-790abecd5577"), "PS", null, "PS", false, "Palestinian Authority", 0 },
                    { new Guid("02cd862f-7bf2-4dee-9d8d-869f67659eac"), "CX", null, "CX", false, "Christmas island", 0 },
                    { new Guid("05600686-62bc-4be9-b009-58ae6fac5dc2"), "UM", null, "UM", false, "United States Minor Outlying Islands", 0 },
                    { new Guid("05f8a24e-3764-41af-b79b-3e05da6964ad"), "TO", null, "276", false, "Tonga", 0 },
                    { new Guid("060539cd-d169-45c2-bec2-28a91e41bcb3"), "IL", null, "184", false, "Israel", 0 },
                    { new Guid("067dbcfb-9729-4016-aa0f-526f43657542"), "CL", null, "141", false, "Chile", 0 },
                    { new Guid("07c04d8d-4e1c-4896-ba8a-7d8172562b37"), "KP", null, "277", false, "Triều Tiên", 0 },
                    { new Guid("09127bf0-ff5d-4660-8fef-18b3107bf295"), "BI", null, "135", false, "Burundi", 0 },
                    { new Guid("0d9bf5f6-20bb-4b4f-8c3e-0b7205eabe19"), "PR", null, "PR", false, "Puerto Rico", 0 },
                    { new Guid("0f42743d-f2ae-4d4d-9e9c-6dcd785204ff"), "SE", null, "273", false, "Thụy Điển", 0 },
                    { new Guid("10a98338-7167-4e5b-b3e4-9515f63bb43d"), "FI", null, "241", false, "Phần Lan", 0 },
                    { new Guid("10f310c4-857b-431b-934c-19ebc560571c"), "IS", null, "179", false, "Iceland", 0 },
                    { new Guid("1137907c-6292-4973-8a6a-5a8a55216701"), "OM", null, "233", false, "Oman", 0 },
                    { new Guid("16bfb332-7ffe-4d31-a2a2-05e7cc250969"), "Z1", null, "Z1", false, "Sovereign Military Order of Malta (SMOM)", 0 },
                    { new Guid("1760cdb2-5d9e-4a4d-a422-9d2d54333b72"), "VA", null, "290", false, "Thành Vatican", 0 },
                    { new Guid("18be6a2d-0cc9-4e57-9b95-0fd5e0999094"), "LA", null, "193", false, "Lào", 0 },
                    { new Guid("19b9d4e2-dd04-4d66-ba70-e71a800b8563"), "CO", null, "142", false, "Colombia", 0 },
                    { new Guid("1a52542a-e4e8-4514-b84f-d8f7a0ce8bf5"), "HU", null, "177", false, "Hungary", 0 },
                    { new Guid("1bb67a2c-65b1-4437-b7db-61bb5c5c945a"), "NZ", null, "227", false, "New Zealand", 0 },
                    { new Guid("1bd96043-4837-4ab4-8812-0230d7cdc37c"), "BH", null, "117", false, "Bahrain", 0 },
                    { new Guid("1c1e8f0d-fa36-4dd5-a349-51f8f8cf1e11"), "RU", null, "231", false, "Nga", 0 },
                    { new Guid("1c3907c5-3cd4-4530-a28c-6d4acceec175"), "AZ", null, "113", false, "Azerbaijan", 0 },
                    { new Guid("1cb83a16-11a1-438b-8fd9-22e661c5904a"), "TN", null, "281", false, "Tunisia", 0 },
                    { new Guid("1cc02fda-f061-49ad-a4f1-ecb564a28c88"), "KZ", null, "187", false, "Kazakhstan", 0 },
                    { new Guid("1d374c8c-88c5-49ae-9c9c-0b2b362b1198"), "BR", null, "131", false, "Brasil", 0 },
                    { new Guid("1d41f179-ba78-41d6-8ecf-595c7d6de65a"), "MA", null, "209", false, "Maroc", 0 },
                    { new Guid("1df44627-4127-48c0-bbc7-2afc64cb75d2"), "CH", null, "274", false, "Thụy Sĩ", 0 },
                    { new Guid("1f0c0c80-dceb-47c4-9bfb-d9e2b29e8010"), "NR", null, "224", false, "Nauru", 0 },
                    { new Guid("20aa6e3b-0838-45fc-9769-161b291e5e24"), "Z4", null, "Z4", false, "Scotland", 0 },
                    { new Guid("212573b7-ec34-4844-b150-74f567de2c5d"), "GF", null, "GF", false, "French guiana", 0 },
                    { new Guid("21668f2b-b3d0-4927-9d67-3f9eee4736d6"), "AS", null, "AS", false, "Samoa thuộc Hoa Kỳ", 0 },
                    { new Guid("22174cd0-7b2d-4c6b-bb6c-5273e63d28f0"), "MY", null, "205", false, "Malaysia", 0 },
                    { new Guid("226d663e-46ee-4ab2-b385-b062345debd9"), "FR", null, "240", false, "Pháp", 0 },
                    { new Guid("23063395-5d36-41c9-9711-66722ab8849f"), "CZ", null, "252", false, "Séc", 0 },
                    { new Guid("24c5f9fa-e493-43a1-9d2a-c6d25dc2ea89"), "FY", null, "254", false, "Serbia", 0 },
                    { new Guid("25b7ed9b-8bfd-4601-a4c5-a59dfe5a3fab"), "AN", null, "AN", false, "Netherlands antilles", 0 },
                    { new Guid("25df127f-9fb7-4f1d-8a4f-484364e15f91"), "GN", null, "170", false, "Guinea", 0 },
                    { new Guid("264432ff-ba3d-4402-ae05-d3cbbdf7eef4"), "NE", null, "229", false, "Niger", 0 },
                    { new Guid("26d0e10a-43ea-4654-93be-00a21f60b760"), "PG", null, "237", false, "Papua New Guinea", 0 },
                    { new Guid("298cf3d9-cf13-401f-86b5-368d1c71ec77"), "GQ", null, "169", false, "Guinea Xích Đạo", 0 },
                    { new Guid("2e24284d-fe7b-477b-a3e9-23505ccbe379"), "Z6", null, "Z6", false, "Great Britain (See United Kingdom)", 0 },
                    { new Guid("2eab2085-d20b-4cc4-a85b-7567c9ce6ea9"), "LC", null, "247", false, "Saint Lucia", 0 },
                    { new Guid("2eb9de76-3d99-43a5-b17d-ba2f0e08c64a"), "NI", null, "228", false, "Nicaragua", 0 },
                    { new Guid("2eead3fb-8c57-4699-a48d-b9eb2a781d23"), "TF", null, "TF", false, "French Southern Territories", 0 },
                    { new Guid("2f4455d6-efee-4959-8dfd-6f7db81faadd"), "NP", null, "226", false, "Nepal", 0 },
                    { new Guid("2facb682-01d5-4798-bf0a-928bd471ecb3"), "CC", null, "CC", false, "Cocos (keeling) islands", 0 },
                    { new Guid("332e0e9e-0182-47a0-b894-ade71da83708"), "BB", null, "120", false, "Barbados", 0 },
                    { new Guid("33aeb885-ea5c-4343-8011-b1dccebdd65f"), "SA", null, "110", false, "Ả Rập Saudi", 0 },
                    { new Guid("347a0e24-276d-4a54-b92b-4b88b60179af"), "GM", null, "163", false, "Gambia", 0 },
                    { new Guid("36299397-b100-420b-bd1b-3f18eda310fa"), "TD", null, "270", false, "Tchad", 0 },
                    { new Guid("3671801a-1c88-4dc6-9e75-d766644c2af9"), "SR", null, "264", false, "Suriname", 0 },
                    { new Guid("36ddc306-adf0-4897-a200-6377ff0d9042"), "TT", null, "278", false, "Trinidad và Tobago", 0 },
                    { new Guid("39351753-1af5-4797-89e2-b97589db8d2e"), "AZ", null, "114", false, "Cộng hòa Azerbaijan", 0 },
                    { new Guid("39ef7fcd-b539-46be-90a6-bc3f6d1524d8"), "KR", null, "174", false, "Hàn Quốc", 0 },
                    { new Guid("3adb70b0-ae40-4ac0-8a27-15398cc79d49"), "GS", null, "GS", false, "South georgia and the south sandwich islands", 0 },
                    { new Guid("3af1daa8-65e1-4502-823d-3c8530608104"), "MP", null, "MP", false, "Northern mariana islands", 0 },
                    { new Guid("3d9d9ca5-3356-48b3-b518-eb806a6128ee"), "VU", null, "289", false, "Vanuatu", 0 },
                    { new Guid("3dac050e-a2a6-469b-b0bb-def2e17544a5"), "GW", null, "168", false, "Guinea-Bissau", 0 },
                    { new Guid("3de67d92-a46e-4113-bd12-2e89a48aa1f0"), "CN", null, "279", false, "Trung Quốc", 0 },
                    { new Guid("3edffd99-5e14-4466-9f3e-a72ab48711d7"), "HM", null, "HM", false, "Heard and mc donald islands", 0 },
                    { new Guid("3f3e1d5e-ca7b-45ef-9e1e-f3c471e8894f"), "ST", null, "251", false, "São Tomé và Príncipe", 0 },
                    { new Guid("426516a2-46e9-4103-8b44-22b4a30b21ae"), "LS", null, "195", false, "Lesotho", 0 },
                    { new Guid("4452efd3-9727-4c5c-9cc9-76f7270c673d"), "CI", null, "130", false, "Bờ Biển Ngà", 0 },
                    { new Guid("44ff82d4-3356-4f71-9aa2-dc5f161537f0"), "SY", null, "266", false, "Syria", 0 },
                    { new Guid("45696681-b325-4d55-b4ea-56a920227907"), "SL", null, "256", false, "Sierra Leone", 0 },
                    { new Guid("4589f414-2018-4196-a42a-68fa60b41dae"), "MZ", null, "219", false, "Mozambique", 0 },
                    { new Guid("45a0ebe0-51be-423b-8885-7a7bf06e6f95"), "BA", null, "127", false, "Bosna và Hercegovina", 0 },
                    { new Guid("46651a82-3d63-4a24-baff-9bb1ee8ac492"), "CF", null, "280", false, "Trung Phi", 0 },
                    { new Guid("484be820-41ff-4911-94c6-2d2969764ac4"), "CD", null, "145", false, "Cộng hòa Dân chủ Congo", 0 },
                    { new Guid("4b12f61e-5980-415f-a62b-b296753fd70d"), "PT", null, "129", false, "Bồ Đào Nha", 0 },
                    { new Guid("4b7309a1-de33-4f43-a2ff-3f11e0e5869b"), "SM", null, "250", false, "San Marino", 0 },
                    { new Guid("4bab2495-c861-47e7-82e6-1806fd87b767"), "IM", null, "IM", false, "Isle of man", 0 },
                    { new Guid("4dbc51c5-3faa-4e76-b0d5-a28df95c5c01"), "GT", null, "167", false, "Guatemala", 0 },
                    { new Guid("4dcd4bda-0da9-415d-8f7e-ecd5841ad250"), "ER", null, "158", false, "Eritrea", 0 },
                    { new Guid("4e6e77af-56d6-4314-ac68-c39713511d70"), "IE", null, "183", false, "Ireland", 0 },
                    { new Guid("50202b21-f7c0-42eb-89bd-4470e82f3943"), "JE", null, "JE", false, "Jersey", 0 },
                    { new Guid("502c14cb-18ea-461f-9bc0-9591b056284c"), "DK", null, "153", false, "Đan Mạch", 0 },
                    { new Guid("506ddd2c-4f81-4d6d-806c-4c9e605bab3f"), "KN", null, "246", false, "Saint Kitts và Nevis", 0 },
                    { new Guid("509f7d40-e740-472f-8a7a-84b5a527eb96"), "KG", null, "192", false, "Kyrgyzstan", 0 },
                    { new Guid("50c044c3-6cd1-46ad-b10a-e879291806f2"), "NU", null, "NU", false, "Niue", 0 },
                    { new Guid("52595376-4b2b-4746-bb17-16f7ba234a33"), "MW", null, "204", false, "Malawi", 0 },
                    { new Guid("5300fbb8-1d3b-48c2-b251-c9daab165b94"), "SH", null, "SH", false, "St. Helena", 0 },
                    { new Guid("5351587c-9713-44c9-9088-9626d01300c8"), "TK", null, "TK", false, "Tokelau", 0 },
                    { new Guid("539247ef-f9a9-4893-b250-2aa204a87640"), "VG", null, "VG", false, "Virgin Islands (British)", 0 },
                    { new Guid("53b7d739-4b49-4a35-9d04-93520d79d105"), "TJ", null, "267", false, "Tajikistan", 0 },
                    { new Guid("53fdbb96-c808-4474-83bc-084e422a8b95"), "BY", null, "121", false, "Belarus", 0 },
                    { new Guid("54ca17f4-f6f7-4bcf-9809-8d45153c2271"), "LR", null, "197", false, "Liberia", 0 },
                    { new Guid("561d896e-c3c5-4dfc-b13c-790aa25fbd5d"), "PA", null, "236", false, "Panama", 0 },
                    { new Guid("5701a860-793e-4660-9302-005b27d4348e"), "AO", null, "106", false, "Angola", 0 },
                    { new Guid("573dec77-5908-42b2-b1a5-8a5ee8407dee"), "GD", null, "165", false, "Grenada", 0 },
                    { new Guid("57c01cf1-7f20-4a6c-bec9-bcc9a3a039fe"), "SG", null, "257", false, "Singapore", 0 },
                    { new Guid("58357a87-d3a9-4ea4-82ea-eb7775f1c568"), "IR", null, "181", false, "Iran", 0 },
                    { new Guid("58486abc-86a6-4bb8-a610-eb0e4bdf0b73"), "LT", null, "200", false, "Litva", 0 },
                    { new Guid("58776bc3-ee4b-44ae-ac9e-a501437bde2f"), "PF", null, "PF", false, "French Polynesia", 0 },
                    { new Guid("58d12ab1-4946-45f9-bef5-354e5803f357"), "DO", null, "152", false, "Cộng hòa Dominicana", 0 },
                    { new Guid("59e93599-98e9-44de-b9d1-bbbf17c599bf"), "ZA", null, "223", false, "Nam Phi", 0 },
                    { new Guid("5a68453d-81d4-4417-a579-33d6a1c27ea6"), "PE", null, "239", false, "Peru", 0 },
                    { new Guid("5b526a49-1694-4eb8-b602-4e150d12184d"), "MC", null, "216", false, "Monaco", 0 },
                    { new Guid("5bd03273-5b23-4181-892c-397126e8da56"), "PK", null, "234", false, "Pakistan", 0 },
                    { new Guid("5d60e969-8387-42e4-b866-31dfb209f433"), "Z3", null, "Z3", false, "England", 0 },
                    { new Guid("5dc567de-1249-4aaa-9d49-04dcd3501220"), "ES", null, "269", false, "Tây Ban Nha", 0 },
                    { new Guid("5f4a7dfd-c3ed-4796-bde2-94199e595ef0"), "BV", null, "BV", false, "Bouvet island", 0 },
                    { new Guid("62947f31-4a3e-441b-a9d2-9642ce61de2f"), "KI", null, "189", false, "Kiribati", 0 },
                    { new Guid("62b0c6c0-4a45-4f33-b35e-d184d815518e"), "GH", null, "164", false, "Ghana", 0 },
                    { new Guid("63c8621a-fc44-4abe-ba08-8d80520280cf"), "SC", null, "255", false, "Seychelles", 0 },
                    { new Guid("6477d7a3-465e-4277-a4eb-ef09b13f5eca"), "MO", null, "MO", false, "Macau", 0 },
                    { new Guid("66169c75-2aa7-409a-a7b9-d8cfe6ac80c0"), "LB", null, "196", false, "Li ban", 0 },
                    { new Guid("66400b32-893a-489c-a5e1-180d55fb20d4"), "KE", null, "188", false, "Kenya", 0 },
                    { new Guid("66533605-d826-4aec-9536-e4d30effefda"), "AL", null, "103", false, "Albania", 0 },
                    { new Guid("665d03c6-346e-43d8-ad21-31492b4382aa"), "JO", null, "186", false, "Jordan", 0 },
                    { new Guid("686b79de-db2f-4ccd-946c-1bef80cd503e"), "CA", null, "140", false, "Canada", 0 },
                    { new Guid("6b24b562-1294-4537-a69a-26ac34c41521"), "AD", null, "105", false, "Andorra", 0 },
                    { new Guid("6b8836aa-2476-4d82-98f1-0b7f56e66f7a"), "TL", null, "TL", false, "Timor Leste", 0 },
                    { new Guid("6c408b50-b4be-4eca-a710-11a6d914cf4f"), "AT", null, "109", false, "Áo", 0 },
                    { new Guid("6d2d2371-8785-4a7b-94ba-84c804b2b0a2"), "RE", null, "RE", false, "Reunion", 0 },
                    { new Guid("6d5a6761-432b-4bd2-9b04-5e01c421de23"), "NF", null, "NF", false, "Norfolk Island", 0 },
                    { new Guid("716a0688-0378-4941-af8f-c11dc4c45ac2"), "TC", null, "TC", false, "Turks and Caicos Islands", 0 },
                    { new Guid("720aaa71-3cc0-470f-b56c-472ac37a6574"), "BE", null, "125", false, "Bỉ", 0 },
                    { new Guid("72d527d4-00df-4f9a-b0e1-e1fa84a4ba6d"), "SO", null, "261", false, "Somalia", 0 },
                    { new Guid("74c266fd-7287-4525-aca3-6bb66ddcf61f"), "WS", null, "249", false, "Samoa", 0 },
                    { new Guid("75de9dea-ef0f-4492-890a-f5af36cce7aa"), "CG", null, "144", false, "Cộng hòa Congo", 0 },
                    { new Guid("76c42f0f-bfb2-4a11-b5a4-e854f74e72cd"), "BZ", null, "122", false, "Belize", 0 },
                    { new Guid("77365013-80d7-44d5-bd8d-472542cac431"), "MQ", null, "MQ", false, "Martinique", 0 },
                    { new Guid("788693d2-4ac9-4f85-94bf-13d021bc000d"), "PM", null, "PM", false, "St. Pierre and Miquelon", 0 },
                    { new Guid("78dcfd52-de7b-4c1d-9ded-0e5d3f7a8a35"), "MT", null, "208", false, "Malta", 0 },
                    { new Guid("79bc1ba0-a0f6-4065-9783-9e01ade32cde"), "PN", null, "PN", false, "Pitcairn", 0 },
                    { new Guid("7a384197-d55e-44b8-b389-a65f17e74e1f"), "PH", null, "242", false, "Philippines", 0 },
                    { new Guid("7af80a81-41e5-47de-abd3-7ce25f9c39b4"), "TM", null, "282", false, "Turkmenistan", 0 },
                    { new Guid("7afaefc0-9aa8-4ba7-98ae-618682a5be7f"), "KM", null, "143", false, "Comoros", 0 },
                    { new Guid("7b0c9a9c-e730-4b96-9372-e9ef8ab5339b"), "BM", null, "BM", false, "Bermuda", 0 },
                    { new Guid("7bea406c-221d-45dd-aca6-a2ceb90741aa"), "DM", null, "151", false, "Dominica", 0 },
                    { new Guid("7e27cb42-41fb-4b20-b26b-3c1ea9b4ff5c"), "SB", null, "260", false, "Solomon", 0 },
                    { new Guid("7ef68b6d-2d6b-4688-95bc-d0fd79ffb6c5"), "CY", null, "191", false, "Síp", 0 },
                    { new Guid("7f233816-fe94-4941-8125-b62c88410fa9"), "BD", null, "119", false, "Bangladesh", 0 },
                    { new Guid("8562fd7f-49aa-46cf-bbc9-71f7460c6ba7"), "SZ", null, "265", false, "Swaziland", 0 },
                    { new Guid("8592d87f-720b-48e7-82ee-e82d64cbf984"), "AG", null, "108", false, "Antigua và Barbuda", 0 },
                    { new Guid("8764ee96-c950-44cf-a1f4-7636126c671b"), "BS", null, "116", false, "Bahamas", 0 },
                    { new Guid("882c80ef-806d-4370-9fb1-f00a13a7a5c1"), "LV", null, "194", false, "Latvia", 0 },
                    { new Guid("8a003437-323c-451c-b211-1886f79c25f1"), "MV", null, "206", false, "Maldives", 0 },
                    { new Guid("8a6a8442-1533-4bba-9a05-ed707122573e"), "GR", null, "178", false, "Hy Lạp", 0 },
                    { new Guid("8f800608-e254-418d-8163-78f71be4873f"), "EG", null, "102", false, "Ai Cập", 0 },
                    { new Guid("8ff51ea0-476b-4dec-8736-70cc36ea1d2c"), "NO", null, "225", false, "Na Uy", 0 },
                    { new Guid("90b2a6a0-bacd-4175-80e9-b8fde9233786"), "KW", null, "190", false, "Kuwait", 0 },
                    { new Guid("90ef0553-8520-4d57-ae3b-112ebf28b313"), "ZW", null, "295", false, "Zimbabwe", 0 },
                    { new Guid("92aea1da-5cf2-40fa-92a2-cce297949451"), "SI", null, "259", false, "Slovenia", 0 },
                    { new Guid("92b69f82-f3e2-4ea9-9d4b-1763b1a75dec"), "MX", null, "213", false, "Mexico", 0 },
                    { new Guid("93fc49be-bd23-41c3-8538-4b424a7806da"), "CV", null, "CV", false, "Cape verde", 0 },
                    { new Guid("9412c9e0-c4fe-442f-8b13-ea064bf48703"), "LI", null, "199", false, "Liechtenstein", 0 },
                    { new Guid("9601fc62-41b1-44af-af8e-8a03c91c96b8"), "JP", null, "232", false, "Nhật Bản", 0 },
                    { new Guid("97bc234b-7d4c-4870-801b-74f1998741be"), "US", null, "175", false, "Hoa Kỳ", 0 },
                    { new Guid("98062645-5015-4d8c-886e-3fb70c247ada"), "GP", null, "GP", false, "Guadeloupe", 0 },
                    { new Guid("994cf06f-b833-4415-84e0-94f3847b6dd8"), "KY", null, "KY", false, "Cayman islands", 0 },
                    { new Guid("99cfce62-6540-4525-97b8-9a2e62618e05"), "SJ", null, "SJ", false, "Svalbard and Jan Mayen Islands", 0 },
                    { new Guid("9acb769e-d2de-479c-b66a-424ce710a036"), "NG", null, "230", false, "Nigeria", 0 },
                    { new Guid("9d5769fe-b3ae-4697-9150-44674e8008ba"), "DE", null, "155", false, "Đức", 0 },
                    { new Guid("9ded845f-06a1-4651-8903-bc46f7978c84"), "GE", null, "GE", false, "Georgia", 0 },
                    { new Guid("9eb57842-f592-4080-affd-71b43f7d0517"), "AQ", null, "AQ", false, "Antarctica", 0 },
                    { new Guid("9ee7b166-4c6f-4136-8928-c6246c3e76d5"), "UZ", null, "288", false, "Uzbekistan", 0 },
                    { new Guid("a1080c01-e5bb-4e3f-8784-f0678f1eff58"), "DJ", null, "150", false, "Djibouti", 0 },
                    { new Guid("a1ba5be8-fef9-470a-a5f7-efcf7fc900a4"), "ME", null, "218", false, "Montenegro", 0 },
                    { new Guid("a1f120ed-4785-486e-b796-dd8cd569a415"), "VC", null, "248", false, "Saint Vincent và Grenadines", 0 },
                    { new Guid("a30f588b-166d-4118-9d33-b8294e15ad44"), "SD", null, "263", false, "Sudan", 0 },
                    { new Guid("a3597652-cc84-40ff-b143-208ee8473e93"), "EA", null, "154", false, "Đông Timor", 0 },
                    { new Guid("a3c5c224-a013-4e23-8655-641a0a76b38a"), "PW", null, "235", false, "Palau", 0 },
                    { new Guid("a695b824-cfc2-40a3-b5a1-35243a6e2116"), "YE", null, "293", false, "Yemen", 0 },
                    { new Guid("a7a696de-3fd8-48c2-b87a-6464b222af87"), "VE", null, "291", false, "Venezuela", 0 },
                    { new Guid("a8b38e56-d3ea-435f-907a-615ed7ced805"), "AF", null, "101", false, "Afghanistan", 0 },
                    { new Guid("aa3d56b9-f398-4be1-b8ae-9f8563101b6e"), "IT", null, "292", false, "Ý", 0 },
                    { new Guid("aa4399ec-1ff3-4837-a68e-0df0720162cb"), "MR", null, "211", false, "Mauritanie", 0 },
                    { new Guid("aa745539-b444-49d2-ad13-14149f8a1645"), "BO", null, "126", false, "Bolivia", 0 },
                    { new Guid("ab16a3ed-00cd-4445-8e7c-770b1965232e"), "NL", null, "173", false, "Hà Lan", 0 },
                    { new Guid("abdfeb5b-a4b8-4ab1-b6b8-83f7fb72ec23"), "EE", null, "159", false, "Estonia", 0 },
                    { new Guid("ad4ef5f1-e823-4ed4-9ad5-cec4a2cae6af"), "UG", null, "285", false, "Uganda", 0 },
                    { new Guid("af24512b-01ae-4420-96cb-62051ede96cc"), "UA", null, "286", false, "Ukraina", 0 },
                    { new Guid("af3badc9-b6da-4eb0-8a42-ecf8dfd6ae19"), "AM", null, "112", false, "Armenia", 0 },
                    { new Guid("af9c2425-679e-4459-8c68-2d357f4f93e5"), "PY", null, "238", false, "Paraguay", 0 },
                    { new Guid("affdf19e-5ed4-497a-97d0-0fc95a547785"), "LK", null, "262", false, "Sri Lanka", 0 },
                    { new Guid("b16a509f-5c70-42b1-a05e-6d4426c721ca"), "IQ", null, "182", false, "Iraq", 0 },
                    { new Guid("b171e933-4b7d-46f5-802a-14c5c9234ed7"), "ML", null, "207", false, "Mali", 0 },
                    { new Guid("b1829e62-c3dd-4f65-8c41-fdbe26aedb93"), "MG", null, "203", false, "Madagascar", 0 },
                    { new Guid("b4e019b1-042b-465c-baf9-60d525d9b85c"), "CK", null, "CK", false, "Cook islands", 0 },
                    { new Guid("b6169a90-920f-425d-a275-82601862a220"), "SK", null, "258", false, "Slovakia", 0 },
                    { new Guid("b83926c4-6963-4f82-97f7-dffa6e87ea7d"), "MK", null, "202", false, "Macedonia", 0 },
                    { new Guid("b83be42b-cde9-4dc3-a838-d8197d2c678f"), "FO", null, "FO", false, "Faroe islands", 0 },
                    { new Guid("ba7304bd-7e25-4731-a60f-10c13589c71a"), "ET", null, "160", false, "Ethiopia", 0 },
                    { new Guid("ba947c48-36fb-420b-b2d9-663fe308b18c"), "TG", null, "275", false, "Togo", 0 },
                    { new Guid("bcb96598-0e05-4316-86d3-80413326555a"), "MH", null, "210", false, "Quần đảo Marshall", 0 },
                    { new Guid("be946a16-a1af-499c-9bd8-ca12a22fb69c"), "CU", null, "149", false, "Cuba", 0 },
                    { new Guid("bf1bf333-4604-4974-838f-886100c006f3"), "TW", null, "TW", false, "Đài Loan", 0 },
                    { new Guid("c4065df0-2539-4046-bb77-7d699a072734"), "FM", null, "214", false, "Micronesia", 0 },
                    { new Guid("c5c14db2-753f-4e28-88b5-3b9e502fa0c6"), "BN", null, "132", false, "Brunei", 0 },
                    { new Guid("c6f6287f-39f6-4470-ad46-ac539eef3052"), "EC", null, "156", false, "Ecuador", 0 },
                    { new Guid("c7f500b0-be15-4ab8-ae5c-1db430d19b8c"), "YT", null, "YT", false, "Mayotte", 0 },
                    { new Guid("c831fb16-910b-4939-804a-1052b8f8adc1"), "HT", null, "172", false, "Haiti", 0 },
                    { new Guid("c8766416-ed13-4631-a9c4-e89e782055c9"), "Z7", null, "Z7", false, "Wales", 0 },
                    { new Guid("cba207c9-9ee4-4a20-876b-ecb1160d0845"), "SN", null, "253", false, "Sénégal", 0 },
                    { new Guid("cbf1c521-494b-4981-9dc9-b6a1b229c01d"), "JM", null, "185", false, "Jamaica", 0 },
                    { new Guid("cc2a4d3b-bae2-4602-9d23-4d4d2d918699"), "MD", null, "215", false, "Moldova", 0 },
                    { new Guid("cdd52492-d981-4972-9f41-4b1774c002ee"), "GI", null, "GI", false, "Gibraltar", 0 },
                    { new Guid("cf8c2ebc-2ed1-404c-875c-d2151d54ab9e"), "MM", null, "220", false, "Myanma", 0 },
                    { new Guid("d0357290-582a-47cd-984c-8815d38454be"), "Z5", null, "Z5", false, "Northern Ireland", 0 },
                    { new Guid("d1fef153-87bc-403a-9590-0ec4cc8d676e"), "PL", null, "118", false, "Ba Lan", 0 },
                    { new Guid("d200b4b5-7435-41a9-be8b-b6a80e14120b"), "IO", null, "IO", false, "British indian ocean territory", 0 },
                    { new Guid("d2ebac27-3463-40cb-9eb2-86e1da12a3ba"), "MS", null, "MS", false, "Montserrat", 0 },
                    { new Guid("d34d65e5-253f-4324-9aee-f74045802e47"), "GG", null, "GG", false, "Guernsey", 0 },
                    { new Guid("d3c10501-b94f-4a0e-b871-80d4b3d7bbbb"), "HK", null, "HK", false, "Hong kong", 0 },
                    { new Guid("d50a063a-82ef-4b56-858e-1a8794b32878"), "HN", null, "176", false, "Honduras", 0 },
                    { new Guid("d576474f-de6a-45fc-bd19-e18a2915f1a4"), "CR", null, "146", false, "Costa Rica", 0 },
                    { new Guid("d892c6c0-bf86-4487-ab8b-5af35cc32a0c"), "GV", null, "171", false, "Guyana", 0 },
                    { new Guid("d94b5935-e6d2-4aa7-b9f7-d332badacd8d"), "BT", null, "124", false, "Bhutan", 0 },
                    { new Guid("da333d92-e16c-4b49-b9d8-669df9032f82"), "FJ", null, "161", false, "Fiji", 0 },
                    { new Guid("dd79ead4-6e12-4cb8-aff5-8f00d8bf9e99"), "SD", null, "222", false, "Nam Sudan", 0 },
                    { new Guid("dd951a03-c803-4351-aac5-ed4ec9922bab"), "QA", null, "243", false, "Qatar", 0 },
                    { new Guid("ddf4ecad-6f97-4bde-84fe-2b9dc51f0ffd"), "BW", null, "128", false, "Botswana", 0 },
                    { new Guid("de0d7be8-8a87-4358-b93e-e809ab17f238"), "RO", null, "244", false, "Romania", 0 },
                    { new Guid("e180ff8a-4e49-4edd-9168-21b372b8d9b7"), "BG", null, "133", false, "Bulgaria", 0 },
                    { new Guid("e1fc9395-73b5-4fd6-8c31-37fef3a3e866"), "ZM", null, "294", false, "Zambia", 0 },
                    { new Guid("e369137c-1730-4809-88e4-e43031327233"), "BF", null, "134", false, "Burkina Faso", 0 },
                    { new Guid("e3a2237c-9d57-462f-bad8-7a78856303c8"), "ID", null, "180", false, "Indonesia", 0 },
                    { new Guid("e43c3f5c-e8d7-430a-9869-e61337bd4188"), "Z2", null, "Z2", false, "British Southern and Antarctic Territories", 0 },
                    { new Guid("e4acc3fd-7e2d-4927-b7e8-797cb8a29a86"), "GU", null, "GU", false, "Guam", 0 },
                    { new Guid("e4c05566-0c8d-42a4-a2e9-ad4d6d33b35f"), "AI", null, "AI", false, "Anguilla", 0 },
                    { new Guid("e5439053-279d-4094-852d-0c2edc6992ed"), "SV", null, "157", false, "El Salvador", 0 },
                    { new Guid("e5837adb-d926-41f1-8434-73fed9db7504"), "AW", null, "AW", false, "Aruba việt nam", 0 },
                    { new Guid("e6e7518f-73eb-4010-b0cf-6dcc5c8f8e01"), "DZ", null, "104", false, "Algérie", 0 },
                    { new Guid("e9455b51-bd57-482f-a979-5ecf6c8c4afd"), "GB", null, "107", false, "Vương quốc Liên hiệp Anh và Bắc Ireland", 0 },
                    { new Guid("edb5a6e1-b084-4e46-87ab-22d38da9cf0a"), "UY", null, "287", false, "Uruguay", 0 },
                    { new Guid("edcecb3c-ffcb-451f-8e24-02a0bf6499ae"), "IN", null, "115", false, "Cộng hòa Ấn Độ", 0 },
                    { new Guid("ee02aa87-f8dc-44ac-9ac9-830120f05656"), "TR", null, "272", false, "Thổ Nhĩ Kỳ", 0 },
                    { new Guid("ee707e39-4195-426c-abf9-1ce21a771350"), "NA", null, "221", false, "Namibia", 0 },
                    { new Guid("f034e368-335c-4a9f-a039-b7ea83f8a315"), "LU", null, "201", false, "Luxembourg", 0 },
                    { new Guid("f07d3dde-aea1-4f0a-ba9d-310cda4fa6e9"), "TH", null, "271", false, "Thái Lan", 0 },
                    { new Guid("f1218849-b5cf-43c8-b3c4-b1ff145f27fc"), "MU", null, "212", false, "Mauritius", 0 },
                    { new Guid("f1c02c7d-3154-4e55-817c-1e24f6eef729"), "GA", null, "162", false, "Gabon", 0 },
                    { new Guid("f21a86da-a1de-4023-93c9-3a23d315a8cd"), "RW", null, "245", false, "Rwanda", 0 },
                    { new Guid("f36eb030-510e-4ca0-b7c4-a1c1ef656dd6"), "FK", null, "FK", false, "Falkland islands (malvinas)", 0 },
                    { new Guid("f468cb27-57fb-4b75-b3b7-70bb33ca2705"), "KH", null, "139", false, "Campuchia", 0 },
                    { new Guid("f5874f17-6c1e-4c07-b8bf-41b76546f6f0"), "CM", null, "138", false, "Cameroon", 0 },
                    { new Guid("f5f9c1ed-f4fb-4cff-aee3-2bcb0d8eed3e"), "NC", null, "NC", false, "New Caledonia", 0 },
                    { new Guid("f5fdcb6c-e0c5-4a57-adca-e743ba60ccee"), "LY", null, "198", false, "Libya", 0 },
                    { new Guid("f79baaf7-6191-4ba9-b38a-2f1b50d05598"), "TV", null, "283", false, "Tuvalu", 0 },
                    { new Guid("f9375017-9897-4487-8916-c98d22fd05b9"), "GL", null, "GL", false, "Greenland", 0 },
                    { new Guid("fb10ce71-e68a-4a70-bf7e-5edee9388d48"), "AE", null, "137", false, "Các Tiểu Vương quốc Ả Rập Thống nhất", 0 },
                    { new Guid("fb67b422-6903-494e-945d-fa09f031b4f1"), "VI", null, "VI", false, "Virgin Islands (U.S.)", 0 },
                    { new Guid("fc5a0c05-ebac-4906-8a9f-dddcdbcc0a9d"), "AU", null, "284", false, "Úc", 0 },
                    { new Guid("fd0ac376-bf65-4bf8-9067-245691aa1827"), "HR", null, "147", false, "Croatia", 0 },
                    { new Guid("fd21963c-7b5e-44a8-8d70-2edbda437946"), "MN", null, "217", false, "Mông Cổ", 0 },
                    { new Guid("fd235817-1607-4f4c-83c7-ff5bd0012896"), "BJ", null, "123", false, "Benin", 0 },
                    { new Guid("fd32d265-24dd-4073-a4b8-59e6358b59ed"), "AR", null, "111", false, "Argentina", 0 },
                    { new Guid("fe657d37-7960-4bb3-8f15-81666fca928d"), "EH", null, "EH", false, "Western sahara", 0 },
                    { new Guid("ff78779a-45cd-4076-8c61-442a9a3873f2"), "TZ", null, "268", false, "Tanzania", 0 },
                    { new Guid("ffd3fabd-a5f1-4442-837b-d53b5d89272e"), "WF", null, "WF", false, "Wallis and Futuna Islands", 0 }
                });

            migrationBuilder.UpdateData(
                table: "DIC_PatientRecordType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 888, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "DIC_PatientRecordType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 888, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "DIC_PatientRecordType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 888, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "DIC_PatientType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 888, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "DIC_PatientType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 888, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "DIC_PatientType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 888, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "DIC_PatientType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 888, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "DIC_PatientType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 888, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "DIC_PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("0b348363-c888-4c9a-b145-c3389fdcca37"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 888, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "DIC_PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("8bff9824-1df2-419e-88ab-e098a6fc4e7e"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 888, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "DIC_PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("dd39afc0-1de0-4287-a126-4dada6788508"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 888, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "DIC_ReceptionObjectType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 888, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "DIC_ReceptionObjectType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 20, 38, 24, 888, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.AddForeignKey(
                name: "FK_BUS_Patient_DIC_National_NationalId",
                table: "BUS_Patient",
                column: "NationalId",
                principalTable: "DIC_National",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BUS_PatientRecord_DIC_National_NationalId",
                table: "BUS_PatientRecord",
                column: "NationalId",
                principalTable: "DIC_National",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DIC_Item_DIC_National_CountryId",
                table: "DIC_Item",
                column: "CountryId",
                principalTable: "DIC_National",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DIC_ItemType_DIC_National_CountryId",
                table: "DIC_ItemType",
                column: "CountryId",
                principalTable: "DIC_National",
                principalColumn: "Id");
        }
    }
}
