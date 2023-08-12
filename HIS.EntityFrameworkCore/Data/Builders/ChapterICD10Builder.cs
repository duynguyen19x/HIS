using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public static class ChapterICD10Builder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SChapterICD10>().HasData(
                new SChapterICD10() { Id = new Guid("FFA69C02-696F-4645-B72E-0F371B8CACFA"), Code = "0", Name = "Khác", SortOrder = 1 },
                new SChapterICD10() { Id = new Guid("DD087168-FB8B-451F-BDDD-56ADFF7A91B3"), Code = "1", Name = "1.Bệnh nhiễm trùng và ký sinh trùng", SortOrder = 2 },
                new SChapterICD10() { Id = new Guid("C81585C5-E57D-468F-99F2-1B403317FFD9"), Code = "2", Name = "2.Bướu tân sinh", SortOrder = 3 },
                new SChapterICD10() { Id = new Guid("C1747EC7-094E-4516-BD96-3E41327A317D"), Code = "3", Name = "3.Bệnh của máu, cơ quan tạo máu và các rối loạn liên quan đến cơ chế miễn dịch", SortOrder = 4 },
                new SChapterICD10() { Id = new Guid("0D2992CF-6FBA-4871-97B3-A8A1229E86FD"), Code = "4", Name = "4.Bệnh nội tiết, dinh dưỡng và chuyển hóa", SortOrder = 5 },
                new SChapterICD10() { Id = new Guid("E06C956C-1795-46A0-BA63-CB75F74AC431"), Code = "5", Name = "5.Rối loạn tâm thần và hành vi", SortOrder = 6 },
                new SChapterICD10() { Id = new Guid("4C8535F7-5852-435D-8B4D-66C198537FC4"), Code = "6", Name = "6.Bệnh hệ thần kinh", SortOrder = 7 },
                new SChapterICD10() { Id = new Guid("11BAF250-7AED-4F3F-949B-82D8929D55FF"), Code = "7", Name = "7.Bệnh mắt và phần phụ", SortOrder = 8 },
                new SChapterICD10() { Id = new Guid("F3685B6E-8B27-4E8E-8A7D-B07AE695805F"), Code = "8", Name = "8.Bệnh tai và xương chũm", SortOrder = 9 },
                new SChapterICD10() { Id = new Guid("5A91F9A2-5A73-4DCE-9A99-532C3B75518E"), Code = "9", Name = "9.Bệnh tuần hoàn", SortOrder = 10 },
                new SChapterICD10() { Id = new Guid("5EC5C91B-DB70-491B-B1B5-A617D9A82549"), Code = "10", Name = "10.Bệnh hô hấp", SortOrder = 11 },
                new SChapterICD10() { Id = new Guid("6CD03DBD-DCBF-44D1-AB7A-3B32E71B3CB7"), Code = "11", Name = "11.Bệnh tiêu hóa", SortOrder = 12 },
                new SChapterICD10() { Id = new Guid("3A6DE8C5-5BFD-4648-8225-42C79A224793"), Code = "12", Name = "12.Bệnh da và mô dưới da", SortOrder = 13 },
                new SChapterICD10() { Id = new Guid("F98E5EE7-4651-43FD-85FD-7E077785AD53"), Code = "13", Name = "13.Bệnh của hệ xương khớp và mô liên kết", SortOrder = 14 },
                new SChapterICD10() { Id = new Guid("93672F0E-4D83-4214-9576-D29113ACEA27"), Code = "14", Name = "14.Bệnh hệ sinh dục - tiết niệu", SortOrder = 15 },
                new SChapterICD10() { Id = new Guid("CB433C30-519A-40AD-AAB8-479DFAD013C3"), Code = "15", Name = "15.Thai nghén, sinh đẻ và hậu sản", SortOrder = 16 },
                new SChapterICD10() { Id = new Guid("BB4DD54D-2566-41BE-A293-ED9398EFEAA0"), Code = "16", Name = "16.Bệnh lý xuất phát trong thời ký chu kỳ", SortOrder = 17 },
                new SChapterICD10() { Id = new Guid("91C637C5-272C-488C-8489-98BE3297D88E"), Code = "17", Name = "17.Dị tật bẩm sinh, biến dạng và bất thường về nhiễm sắc thể", SortOrder = 18 },
                new SChapterICD10() { Id = new Guid("5D500BFF-32F6-46EE-BA7A-F89A43FDD5B1"), Code = "18", Name = "18.Các triệu chứng, dấu hiệu và những biểu hiện lâm sàng bất thường, không phân loại ở phần khác", SortOrder = 19 },
                new SChapterICD10() { Id = new Guid("DD240E2F-1434-4091-A691-12DA1214424E"), Code = "19", Name = "19.Vết thương, ngộ độc và hậu quả của một số nguyên nhân bên ngoài", SortOrder = 20 },
                new SChapterICD10() { Id = new Guid("613E5901-9552-40F8-B865-F9FD6E91D7E8"), Code = "20", Name = "20.Các nguyên nhân ngoại sinh của bệnh và tử vong", SortOrder = 21 },
                new SChapterICD10() { Id = new Guid("08F6A2B3-D5E6-4FAD-A022-5F29D0117801"), Code = "21", Name = "21.Các yếu tố ảnh hưởng đến tình trạng sức khỏe và tiếp xúc dịch vụ y tế", SortOrder = 22 },
                new SChapterICD10() { Id = new Guid("AAF07983-F9ED-43A5-8D9E-BE42CDAA4044"), Code = "22", Name = "22.Kháng các thuốc kháng sinh và chống ung thư", SortOrder = 23 },
                new SChapterICD10() { Id = new Guid("134969E1-21E0-496C-8A7E-B40D5E52B4F4"), Code = "23", Name = "Chương I. Bệnh nhiễm trùng và ký sinh trùng U50", SortOrder = 24 },
                new SChapterICD10() { Id = new Guid("C27DBAEB-B11F-448B-BB63-BE2F06D3E795"), Code = "24", Name = "Chương II. Bướu tân sinh - U51", SortOrder = 25 },
                new SChapterICD10() { Id = new Guid("F8811C3E-61E4-4344-B139-B583DC0D94A3"), Code = "25", Name = "Chương III. Bệnh về máu, cơ quan tạo máu và các rối loạn liên quan đến cơ chế miễn dịch - U52", SortOrder = 26 },
                new SChapterICD10() { Id = new Guid("30E5CAB2-63D3-4B93-B430-042B04276E20"), Code = "26", Name = "Chương IV. Bệnh nội tiết, dinh dưỡng và rối loạn chuyển hóa - U53", SortOrder = 27 },
                new SChapterICD10() { Id = new Guid("E71C20E6-9F6C-4998-8867-C29B3F0DA643"), Code = "27", Name = "Chương V. Bệnh rối loạn tâm thần và hành vi - U54", SortOrder = 28 },
                new SChapterICD10() { Id = new Guid("F2B02143-9C76-4717-A9A5-711CE23BF81C"), Code = "28", Name = "Chương VI. Bệnh hệ thần kinh - U55", SortOrder = 29 },
                new SChapterICD10() { Id = new Guid("F21CF99C-F691-43EB-92C7-D9CD595FC1B2"), Code = "29", Name = "Chương VII. Bệnh về mắt và phần phụ - U56", SortOrder = 30 },
                new SChapterICD10() { Id = new Guid("B4D1C297-0F9C-41D4-9AA9-B211ECF0CBEE"), Code = "30", Name = "Chương VIII. Bệnh của tai xương chũm - U57", SortOrder = 31 },
                new SChapterICD10() { Id = new Guid("A0570373-F0CE-4051-93E7-3285476367CB"), Code = "31", Name = "Chương IX. Bệnh hệ tuần hoàn - U58", SortOrder = 32 },
                new SChapterICD10() { Id = new Guid("08B63907-E7B9-4E6A-B075-706CCA99F29C"), Code = "32", Name = "Chương X. Bệnh hệ hô hấp U59", SortOrder = 33 },
                new SChapterICD10() { Id = new Guid("E96358F3-2F7C-4D6F-A4FA-0268039DF244"), Code = "33", Name = "Chương XI. Bệnh tiêu hóa - U60", SortOrder = 34 },
                new SChapterICD10() { Id = new Guid("4104F31A-D1AD-4025-8756-4FADDF40D453"), Code = "34", Name = "Chương XII. Bệnh của da và mô dưới da - U61", SortOrder = 35 },
                new SChapterICD10() { Id = new Guid("F9E407F1-0417-4067-9D25-DAE91D19E1BF"), Code = "35", Name = "Chương XIII. Bệnh của hệ xương khớp và mô liên kết - U62", SortOrder = 36 },
                new SChapterICD10() { Id = new Guid("CD456287-B5AA-4D8C-B23D-7027C7676CE7"), Code = "36", Name = "Chương XIV. Bệnh hệ sinh dục - Tiết niệu - U63", SortOrder = 37 },
                new SChapterICD10() { Id = new Guid("A67315A8-8874-4A76-9D56-BB5103740E66"), Code = "37", Name = "Chương XV. Thai nghén, sinh đẻ và hậu sản - U64", SortOrder = 38 },
                new SChapterICD10() { Id = new Guid("0377427B-D6BD-4B58-99A9-D71789475BB2"), Code = "38", Name = "Chương XVI. Dị tật bẩm, biến dạng và bất thường về nhiễm sắc thể - U65", SortOrder = 39 },
                new SChapterICD10() { Id = new Guid("723B5A32-B7A2-4D46-9E19-C42D096839E2"), Code = "39", Name = "Chương XVII. Các triệu chứng dấu hiệu và những biểu hiện lâm sàng bất thường, chưa được phân loại ở nơi khác - U66", SortOrder = 40 },
                new SChapterICD10() { Id = new Guid("C3C34FE9-3D68-4F4C-98AB-ABC10EC96CCC"), Code = "40", Name = "Chương XVIII. Vết thương ngộ độc và hậu quả của một số nguyên nhân bên ngoài - U67", SortOrder = 41 }
            );

        }
    }
}
