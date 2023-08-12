using System;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class AddTable_SChapterICD10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SChapterICD10",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SChapterICD10", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SChapterICD10",
                columns: new[] { "Id", "Code", "Name", "SortOrder", "Inactive" },
                values: new object[,]
                {
                    { new Guid("FFA69C02-696F-4645-B72E-0F371B8CACFA"), "0", "Khác", 1 , false},
                    { new Guid("DD087168-FB8B-451F-BDDD-56ADFF7A91B3"), "1", "1.Bệnh nhiễm trùng và ký sinh trùng", 2  , false},
                    { new Guid("C81585C5-E57D-468F-99F2-1B403317FFD9"), "2", "2.Bướu tân sinh", 3  , false},
                    { new Guid("C1747EC7-094E-4516-BD96-3E41327A317D"), "3", "3.Bệnh của máu, cơ quan tạo máu và các rối loạn liên quan đến cơ chế miễn dịch", 4  , false},
                    { new Guid("0D2992CF-6FBA-4871-97B3-A8A1229E86FD"), "4", "4.Bệnh nội tiết, dinh dưỡng và chuyển hóa", 5  , false},
                    { new Guid("E06C956C-1795-46A0-BA63-CB75F74AC431"), "5", "5.Rối loạn tâm thần và hành vi",6  , false},
                    { new Guid("4C8535F7-5852-435D-8B4D-66C198537FC4"), "6", "6.Bệnh hệ thần kinh",7  , false},
                    { new Guid("11BAF250-7AED-4F3F-949B-82D8929D55FF"), "7", "7.Bệnh mắt và phần phụ",8  , false},
                    { new Guid("F3685B6E-8B27-4E8E-8A7D-B07AE695805F"), "8", "8.Bệnh tai và xương chũm",9 , false},
                    { new Guid("5A91F9A2-5A73-4DCE-9A99-532C3B75518E"), "9", "9.Bệnh tuần hoàn",10  , false},
                    { new Guid("5EC5C91B-DB70-491B-B1B5-A617D9A82549"), "10", "10.Bệnh hô hấp",11 , false },
                    { new Guid("6CD03DBD-DCBF-44D1-AB7A-3B32E71B3CB7"), "11", "11.Bệnh tiêu hóa",12  , false},
                    { new Guid("3A6DE8C5-5BFD-4648-8225-42C79A224793"), "12", "12.Bệnh da và mô dưới da",13  , false},
                    { new Guid("F98E5EE7-4651-43FD-85FD-7E077785AD53"), "13", "13.Bệnh của hệ xương khớp và mô liên kết",14  , false},
                    { new Guid("93672F0E-4D83-4214-9576-D29113ACEA27"), "14", "14.Bệnh hệ sinh dục - tiết niệu",15  , false},
                    { new Guid("CB433C30-519A-40AD-AAB8-479DFAD013C3"), "15", "15.Thai nghén, sinh đẻ và hậu sản",16  , false},
                    { new Guid("BB4DD54D-2566-41BE-A293-ED9398EFEAA0"), "16", "16.Bệnh lý xuất phát trong thời ký chu kỳ",17  , false},
                    { new Guid("91C637C5-272C-488C-8489-98BE3297D88E"), "17", "17.Dị tật bẩm sinh, biến dạng và bất thường về nhiễm sắc thể",18  , false},
                    { new Guid("5D500BFF-32F6-46EE-BA7A-F89A43FDD5B1"), "18", "18.Các triệu chứng, dấu hiệu và những biểu hiện lâm sàng bất thường, không phân loại ở phần khác",19  , false},
                    { new Guid("DD240E2F-1434-4091-A691-12DA1214424E"), "19", "19.Vết thương, ngộ độc và hậu quả của một số nguyên nhân bên ngoài",20  , false},
                    { new Guid("613E5901-9552-40F8-B865-F9FD6E91D7E8"), "20", "20.Các nguyên nhân ngoại sinh của bệnh và tử vong",21  , false},
                    { new Guid("08F6A2B3-D5E6-4FAD-A022-5F29D0117801"), "21", "21.Các yếu tố ảnh hưởng đến tình trạng sức khỏe và tiếp xúc dịch vụ y tế",22  , false},
                    { new Guid("AAF07983-F9ED-43A5-8D9E-BE42CDAA4044"), "22", "22.Kháng các thuốc kháng sinh và chống ung thư",23  , false},
                    { new Guid("134969E1-21E0-496C-8A7E-B40D5E52B4F4"), "23", "Chương I. Bệnh nhiễm trùng và ký sinh trùng U50",24  , false},
                    { new Guid("C27DBAEB-B11F-448B-BB63-BE2F06D3E795"), "24", "Chương II. Bướu tân sinh - U51",25  , false},
                    { new Guid("F8811C3E-61E4-4344-B139-B583DC0D94A3"), "25", "Chương III. Bệnh về máu, cơ quan tạo máu và các rối loạn liên quan đến cơ chế miễn dịch - U52",26  , false},
                    { new Guid("30E5CAB2-63D3-4B93-B430-042B04276E20"), "26", "Chương IV. Bệnh nội tiết, dinh dưỡng và rối loạn chuyển hóa - U53",27  , false},
                    { new Guid("E71C20E6-9F6C-4998-8867-C29B3F0DA643"), "27", "Chương V. Bệnh rối loạn tâm thần và hành vi - U54",28  , false},
                    { new Guid("F2B02143-9C76-4717-A9A5-711CE23BF81C"), "28", "Chương VI. Bệnh hệ thần kinh - U55",29  , false},
                    { new Guid("F21CF99C-F691-43EB-92C7-D9CD595FC1B2"), "29", "Chương VII. Bệnh về mắt và phần phụ - U56",30  , false},
                    { new Guid("B4D1C297-0F9C-41D4-9AA9-B211ECF0CBEE"), "30", "Chương VIII. Bệnh của tai xương chũm - U57",31  , false},
                    { new Guid("A0570373-F0CE-4051-93E7-3285476367CB"), "31", "Chương IX. Bệnh hệ tuần hoàn - U58",32  , false},
                    { new Guid("08B63907-E7B9-4E6A-B075-706CCA99F29C"), "32", "Chương X. Bệnh hệ hô hấp U59",33  , false},
                    { new Guid("E96358F3-2F7C-4D6F-A4FA-0268039DF244"), "33", "Chương XI. Bệnh tiêu hóa - U60",34  , false},
                    { new Guid("4104F31A-D1AD-4025-8756-4FADDF40D453"), "34", "Chương XII. Bệnh của da và mô dưới da - U61",35  , false},
                    { new Guid("F9E407F1-0417-4067-9D25-DAE91D19E1BF"), "35", "Chương XIII. Bệnh của hệ xương khớp và mô liên kết - U62",36  , false},
                    { new Guid("CD456287-B5AA-4D8C-B23D-7027C7676CE7"), "36", "Chương XIV. Bệnh hệ sinh dục - Tiết niệu - U63",37  , false},
                    { new Guid("A67315A8-8874-4A76-9D56-BB5103740E66"), "37", "Chương XV. Thai nghén, sinh đẻ và hậu sản - U64",38  , false},
                    { new Guid("0377427B-D6BD-4B58-99A9-D71789475BB2"), "38", "Chương XVI. Dị tật bẩm, biến dạng và bất thường về nhiễm sắc thể - U65",39  , false},
                    { new Guid("723B5A32-B7A2-4D46-9E19-C42D096839E2"), "39", "Chương XVII. Các triệu chứng dấu hiệu và những biểu hiện lâm sàng bất thường, chưa được phân loại ở nơi khác - U66",40 , false },
                    { new Guid("C3C34FE9-3D68-4F4C-98AB-ABC10EC96CCC"), "40", "Chương XVIII. Vết thương ngộ độc và hậu quả của một số nguyên nhân bên ngoài - U67",41  , false}

                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SChapterICD10");
        }
    }
}
