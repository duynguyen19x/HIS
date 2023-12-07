﻿using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class NationalConfiguration : IEntityTypeConfiguration<National>
    {
        public void Configure(EntityTypeBuilder<National> builder)
        {
            builder.ToTable("DIC_National");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(20).IsRequired();
            builder.Property(x => x.HeInCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(512).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasData(
                new National() { Id = new Guid("6B24B562-1294-4537-A69A-26AC34C41521"), Code = "AD", HeInCode = "105", Name = "Andorra", },
                new National() { Id = new Guid("FB10CE71-E68A-4A70-BF7E-5EDEE9388D48"), Code = "AE", HeInCode = "137", Name = "Các Tiểu Vương quốc Ả Rập Thống nhất", },
                new National() { Id = new Guid("8592D87F-720B-48E7-82EE-E82D64CBF984"), Code = "AG", HeInCode = "108", Name = "Antigua và Barbuda", },
                new National() { Id = new Guid("E4C05566-0C8D-42A4-A2E9-AD4D6D33B35F"), Code = "AI", HeInCode = "AI", Name = "Anguilla", },
                new National() { Id = new Guid("66533605-D826-4AEC-9536-E4D30EFFEFDA"), Code = "AL", HeInCode = "103", Name = "Albania", },
                new National() { Id = new Guid("AF3BADC9-B6DA-4EB0-8A42-ECF8DFD6AE19"), Code = "AM", HeInCode = "112", Name = "Armenia", },
                new National() { Id = new Guid("25B7ED9B-8BFD-4601-A4C5-A59DFE5A3FAB"), Code = "AN", HeInCode = "AN", Name = "Netherlands antilles", },
                new National() { Id = new Guid("5701A860-793E-4660-9302-005B27D4348E"), Code = "AO", HeInCode = "106", Name = "Angola", },
                new National() { Id = new Guid("9EB57842-F592-4080-AFFD-71B43F7D0517"), Code = "AQ", HeInCode = "AQ", Name = "Antarctica", },
                new National() { Id = new Guid("FD32D265-24DD-4073-A4B8-59E6358B59ED"), Code = "AR", HeInCode = "111", Name = "Argentina", },
                new National() { Id = new Guid("21668F2B-B3D0-4927-9D67-3F9EEE4736D6"), Code = "AS", HeInCode = "AS", Name = "Samoa thuộc Hoa Kỳ", },
                new National() { Id = new Guid("6C408B50-B4BE-4ECA-A710-11A6D914CF4F"), Code = "AT", HeInCode = "109", Name = "Áo", },
                new National() { Id = new Guid("FC5A0C05-EBAC-4906-8A9F-DDDCDBCC0A9D"), Code = "AU", HeInCode = "284", Name = "Úc", },
                new National() { Id = new Guid("E5837ADB-D926-41F1-8434-73FED9DB7504"), Code = "AW", HeInCode = "AW", Name = "Aruba việt nam", },
                new National() { Id = new Guid("1C3907C5-3CD4-4530-A28C-6D4ACCEEC175"), Code = "AZ", HeInCode = "113", Name = "Azerbaijan", },
                new National() { Id = new Guid("45A0EBE0-51BE-423B-8885-7A7BF06E6F95"), Code = "BA", HeInCode = "127", Name = "Bosna và Hercegovina", },
                new National() { Id = new Guid("332E0E9E-0182-47A0-B894-ADE71DA83708"), Code = "BB", HeInCode = "120", Name = "Barbados", },
                new National() { Id = new Guid("7F233816-FE94-4941-8125-B62C88410FA9"), Code = "BD", HeInCode = "119", Name = "Bangladesh", },
                new National() { Id = new Guid("720AAA71-3CC0-470F-B56C-472AC37A6574"), Code = "BE", HeInCode = "125", Name = "Bỉ", },
                new National() { Id = new Guid("E369137C-1730-4809-88E4-E43031327233"), Code = "BF", HeInCode = "134", Name = "Burkina Faso", },
                new National() { Id = new Guid("E180FF8A-4E49-4EDD-9168-21B372B8D9B7"), Code = "BG", HeInCode = "133", Name = "Bulgaria", },
                new National() { Id = new Guid("1BD96043-4837-4AB4-8812-0230D7CDC37C"), Code = "BH", HeInCode = "117", Name = "Bahrain", },
                new National() { Id = new Guid("09127BF0-FF5D-4660-8FEF-18B3107BF295"), Code = "BI", HeInCode = "135", Name = "Burundi", },
                new National() { Id = new Guid("FD235817-1607-4F4C-83C7-FF5BD0012896"), Code = "BJ", HeInCode = "123", Name = "Benin", },
                new National() { Id = new Guid("7B0C9A9C-E730-4B96-9372-E9EF8AB5339B"), Code = "BM", HeInCode = "BM", Name = "Bermuda", },
                new National() { Id = new Guid("C5C14DB2-753F-4E28-88B5-3B9E502FA0C6"), Code = "BN", HeInCode = "132", Name = "Brunei", },
                new National() { Id = new Guid("AA745539-B444-49D2-AD13-14149F8A1645"), Code = "BO", HeInCode = "126", Name = "Bolivia", },
                new National() { Id = new Guid("1D374C8C-88C5-49AE-9C9C-0B2B362B1198"), Code = "BR", HeInCode = "131", Name = "Brasil", },
                new National() { Id = new Guid("8764EE96-C950-44CF-A1F4-7636126C671B"), Code = "BS", HeInCode = "116", Name = "Bahamas", },
                new National() { Id = new Guid("D94B5935-E6D2-4AA7-B9F7-D332BADACD8D"), Code = "BT", HeInCode = "124", Name = "Bhutan", },
                new National() { Id = new Guid("5F4A7DFD-C3ED-4796-BDE2-94199E595EF0"), Code = "BV", HeInCode = "BV", Name = "Bouvet island", },
                new National() { Id = new Guid("DDF4ECAD-6F97-4BDE-84FE-2B9DC51F0FFD"), Code = "BW", HeInCode = "128", Name = "Botswana", },
                new National() { Id = new Guid("53FDBB96-C808-4474-83BC-084E422A8B95"), Code = "BY", HeInCode = "121", Name = "Belarus", },
                new National() { Id = new Guid("76C42F0F-BFB2-4A11-B5A4-E854F74E72CD"), Code = "BZ", HeInCode = "122", Name = "Belize", },
                new National() { Id = new Guid("686B79DE-DB2F-4CCD-946C-1BEF80CD503E"), Code = "CA", HeInCode = "140", Name = "Canada", },
                new National() { Id = new Guid("2FACB682-01D5-4798-BF0A-928BD471ECB3"), Code = "CC", HeInCode = "CC", Name = "Cocos (keeling) islands", },
                new National() { Id = new Guid("484BE820-41FF-4911-94C6-2D2969764AC4"), Code = "CD", HeInCode = "145", Name = "Cộng hòa Dân chủ Congo", },
                new National() { Id = new Guid("46651A82-3D63-4A24-BAFF-9BB1EE8AC492"), Code = "CF", HeInCode = "280", Name = "Trung Phi", },
                new National() { Id = new Guid("75DE9DEA-EF0F-4492-890A-F5AF36CCE7AA"), Code = "CG", HeInCode = "144", Name = "Cộng hòa Congo", },
                new National() { Id = new Guid("1DF44627-4127-48C0-BBC7-2AFC64CB75D2"), Code = "CH", HeInCode = "274", Name = "Thụy Sĩ", },
                new National() { Id = new Guid("4452EFD3-9727-4C5C-9CC9-76F7270C673D"), Code = "CI", HeInCode = "130", Name = "Bờ Biển Ngà", },
                new National() { Id = new Guid("B4E019B1-042B-465C-BAF9-60D525D9B85C"), Code = "CK", HeInCode = "CK", Name = "Cook islands", },
                new National() { Id = new Guid("067DBCFB-9729-4016-AA0F-526F43657542"), Code = "CL", HeInCode = "141", Name = "Chile", },
                new National() { Id = new Guid("F5874F17-6C1E-4C07-B8BF-41B76546F6F0"), Code = "CM", HeInCode = "138", Name = "Cameroon", },
                new National() { Id = new Guid("3DE67D92-A46E-4113-BD12-2E89A48AA1F0"), Code = "CN", HeInCode = "279", Name = "Trung Quốc", },
                new National() { Id = new Guid("19B9D4E2-DD04-4D66-BA70-E71A800B8563"), Code = "CO", HeInCode = "142", Name = "Colombia", },
                new National() { Id = new Guid("D576474F-DE6A-45FC-BD19-E18A2915F1A4"), Code = "CR", HeInCode = "146", Name = "Costa Rica", },
                new National() { Id = new Guid("BE946A16-A1AF-499C-9BD8-CA12A22FB69C"), Code = "CU", HeInCode = "149", Name = "Cuba", },
                new National() { Id = new Guid("93FC49BE-BD23-41C3-8538-4B424A7806DA"), Code = "CV", HeInCode = "CV", Name = "Cape verde", },
                new National() { Id = new Guid("02CD862F-7BF2-4DEE-9D8D-869F67659EAC"), Code = "CX", HeInCode = "CX", Name = "Christmas island", },
                new National() { Id = new Guid("7EF68B6D-2D6B-4688-95BC-D0FD79FFB6C5"), Code = "CY", HeInCode = "191", Name = "Síp", },
                new National() { Id = new Guid("23063395-5D36-41C9-9711-66722AB8849F"), Code = "CZ", HeInCode = "252", Name = "Séc", },
                new National() { Id = new Guid("9D5769FE-B3AE-4697-9150-44674E8008BA"), Code = "DE", HeInCode = "155", Name = "Đức", },
                new National() { Id = new Guid("A1080C01-E5BB-4E3F-8784-F0678F1EFF58"), Code = "DJ", HeInCode = "150", Name = "Djibouti", },
                new National() { Id = new Guid("502C14CB-18EA-461F-9BC0-9591B056284C"), Code = "DK", HeInCode = "153", Name = "Đan Mạch", },
                new National() { Id = new Guid("7BEA406C-221D-45DD-ACA6-A2CEB90741AA"), Code = "DM", HeInCode = "151", Name = "Dominica", },
                new National() { Id = new Guid("58D12AB1-4946-45F9-BEF5-354E5803F357"), Code = "DO", HeInCode = "152", Name = "Cộng hòa Dominicana", },
                new National() { Id = new Guid("E6E7518F-73EB-4010-B0CF-6DCC5C8F8E01"), Code = "DZ", HeInCode = "104", Name = "Algérie", },
                new National() { Id = new Guid("A3597652-CC84-40FF-B143-208EE8473E93"), Code = "EA", HeInCode = "154", Name = "Đông Timor", },
                new National() { Id = new Guid("C6F6287F-39F6-4470-AD46-AC539EEF3052"), Code = "EC", HeInCode = "156", Name = "Ecuador", },
                new National() { Id = new Guid("ABDFEB5B-A4B8-4AB1-B6B8-83F7FB72EC23"), Code = "EE", HeInCode = "159", Name = "Estonia", },
                new National() { Id = new Guid("8F800608-E254-418D-8163-78F71BE4873F"), Code = "EG", HeInCode = "102", Name = "Ai Cập", },
                new National() { Id = new Guid("FE657D37-7960-4BB3-8F15-81666FCA928D"), Code = "EH", HeInCode = "EH", Name = "Western sahara", },
                new National() { Id = new Guid("4DCD4BDA-0DA9-415D-8F7E-ECD5841AD250"), Code = "ER", HeInCode = "158", Name = "Eritrea", },
                new National() { Id = new Guid("5DC567DE-1249-4AAA-9D49-04DCD3501220"), Code = "ES", HeInCode = "269", Name = "Tây Ban Nha", },
                new National() { Id = new Guid("BA7304BD-7E25-4731-A60F-10C13589C71A"), Code = "ET", HeInCode = "160", Name = "Ethiopia", },
                new National() { Id = new Guid("10A98338-7167-4E5B-B3E4-9515F63BB43D"), Code = "FI", HeInCode = "241", Name = "Phần Lan", },
                new National() { Id = new Guid("DA333D92-E16C-4B49-B9D8-669DF9032F82"), Code = "FJ", HeInCode = "161", Name = "Fiji", },
                new National() { Id = new Guid("F36EB030-510E-4CA0-B7C4-A1C1EF656DD6"), Code = "FK", HeInCode = "FK", Name = "Falkland islands (malvinas)", },
                new National() { Id = new Guid("C4065DF0-2539-4046-BB77-7D699A072734"), Code = "FM", HeInCode = "214", Name = "Micronesia", },
                new National() { Id = new Guid("B83BE42B-CDE9-4DC3-A838-D8197D2C678F"), Code = "FO", HeInCode = "FO", Name = "Faroe islands", },
                new National() { Id = new Guid("226D663E-46EE-4AB2-B385-B062345DEBD9"), Code = "FR", HeInCode = "240", Name = "Pháp", },
                new National() { Id = new Guid("24C5F9FA-E493-43A1-9D2A-C6D25DC2EA89"), Code = "FY", HeInCode = "254", Name = "Serbia", },
                new National() { Id = new Guid("F1C02C7D-3154-4E55-817C-1E24F6EEF729"), Code = "GA", HeInCode = "162", Name = "Gabon", },
                new National() { Id = new Guid("E9455B51-BD57-482F-A979-5ECF6C8C4AFD"), Code = "GB", HeInCode = "107", Name = "Vương quốc Liên hiệp Anh và Bắc Ireland", },
                new National() { Id = new Guid("573DEC77-5908-42B2-B1A5-8A5EE8407DEE"), Code = "GD", HeInCode = "165", Name = "Grenada", },
                new National() { Id = new Guid("9DED845F-06A1-4651-8903-BC46F7978C84"), Code = "GE", HeInCode = "GE", Name = "Georgia", },
                new National() { Id = new Guid("212573B7-EC34-4844-B150-74F567DE2C5D"), Code = "GF", HeInCode = "GF", Name = "French guiana", },
                new National() { Id = new Guid("D34D65E5-253F-4324-9AEE-F74045802E47"), Code = "GG", HeInCode = "GG", Name = "Guernsey", },
                new National() { Id = new Guid("62B0C6C0-4A45-4F33-B35E-D184D815518E"), Code = "GH", HeInCode = "164", Name = "Ghana", },
                new National() { Id = new Guid("CDD52492-D981-4972-9F41-4B1774C002EE"), Code = "GI", HeInCode = "GI", Name = "Gibraltar", },
                new National() { Id = new Guid("F9375017-9897-4487-8916-C98D22FD05B9"), Code = "GL", HeInCode = "GL", Name = "Greenland", },
                new National() { Id = new Guid("347A0E24-276D-4A54-B92B-4B88B60179AF"), Code = "GM", HeInCode = "163", Name = "Gambia", },
                new National() { Id = new Guid("25DF127F-9FB7-4F1D-8A4F-484364E15F91"), Code = "GN", HeInCode = "170", Name = "Guinea", },
                new National() { Id = new Guid("98062645-5015-4D8C-886E-3FB70C247ADA"), Code = "GP", HeInCode = "GP", Name = "Guadeloupe", },
                new National() { Id = new Guid("298CF3D9-CF13-401F-86B5-368D1C71EC77"), Code = "GQ", HeInCode = "169", Name = "Guinea Xích Đạo", },
                new National() { Id = new Guid("8A6A8442-1533-4BBA-9A05-ED707122573E"), Code = "GR", HeInCode = "178", Name = "Hy Lạp", },
                new National() { Id = new Guid("3ADB70B0-AE40-4AC0-8A27-15398CC79D49"), Code = "GS", HeInCode = "GS", Name = "South georgia and the south sandwich islands", },
                new National() { Id = new Guid("4DBC51C5-3FAA-4E76-B0D5-A28DF95C5C01"), Code = "GT", HeInCode = "167", Name = "Guatemala", },
                new National() { Id = new Guid("E4ACC3FD-7E2D-4927-B7E8-797CB8A29A86"), Code = "GU", HeInCode = "GU", Name = "Guam", },
                new National() { Id = new Guid("D892C6C0-BF86-4487-AB8B-5AF35CC32A0C"), Code = "GV", HeInCode = "171", Name = "Guyana", },
                new National() { Id = new Guid("3DAC050E-A2A6-469B-B0BB-DEF2E17544A5"), Code = "GW", HeInCode = "168", Name = "Guinea-Bissau", },
                new National() { Id = new Guid("D3C10501-B94F-4A0E-B871-80D4B3D7BBBB"), Code = "HK", HeInCode = "HK", Name = "Hong kong", },
                new National() { Id = new Guid("3EDFFD99-5E14-4466-9F3E-A72AB48711D7"), Code = "HM", HeInCode = "HM", Name = "Heard and mc donald islands", },
                new National() { Id = new Guid("D50A063A-82EF-4B56-858E-1A8794B32878"), Code = "HN", HeInCode = "176", Name = "Honduras", },
                new National() { Id = new Guid("FD0AC376-BF65-4BF8-9067-245691AA1827"), Code = "HR", HeInCode = "147", Name = "Croatia", },
                new National() { Id = new Guid("C831FB16-910B-4939-804A-1052B8F8ADC1"), Code = "HT", HeInCode = "172", Name = "Haiti", },
                new National() { Id = new Guid("1A52542A-E4E8-4514-B84F-D8F7A0CE8BF5"), Code = "HU", HeInCode = "177", Name = "Hungary", },
                new National() { Id = new Guid("E3A2237C-9D57-462F-BAD8-7A78856303C8"), Code = "ID", HeInCode = "180", Name = "Indonesia", },
                new National() { Id = new Guid("4E6E77AF-56D6-4314-AC68-C39713511D70"), Code = "IE", HeInCode = "183", Name = "Ireland", },
                new National() { Id = new Guid("060539CD-D169-45C2-BEC2-28A91E41BCB3"), Code = "IL", HeInCode = "184", Name = "Israel", },
                new National() { Id = new Guid("4BAB2495-C861-47E7-82E6-1806FD87B767"), Code = "IM", HeInCode = "IM", Name = "Isle of man", },
                new National() { Id = new Guid("EDCECB3C-FFCB-451F-8E24-02A0BF6499AE"), Code = "IN", HeInCode = "115", Name = "Cộng hòa Ấn Độ", },
                new National() { Id = new Guid("D200B4B5-7435-41A9-BE8B-B6A80E14120B"), Code = "IO", HeInCode = "IO", Name = "British indian ocean territory", },
                new National() { Id = new Guid("B16A509F-5C70-42B1-A05E-6D4426C721CA"), Code = "IQ", HeInCode = "182", Name = "Iraq", },
                new National() { Id = new Guid("58357A87-D3A9-4EA4-82EA-EB7775F1C568"), Code = "IR", HeInCode = "181", Name = "Iran", },
                new National() { Id = new Guid("10F310C4-857B-431B-934C-19EBC560571C"), Code = "IS", HeInCode = "179", Name = "Iceland", },
                new National() { Id = new Guid("AA3D56B9-F398-4BE1-B8AE-9F8563101B6E"), Code = "IT", HeInCode = "292", Name = "Ý", },
                new National() { Id = new Guid("50202B21-F7C0-42EB-89BD-4470E82F3943"), Code = "JE", HeInCode = "JE", Name = "Jersey", },
                new National() { Id = new Guid("CBF1C521-494B-4981-9DC9-B6A1B229C01D"), Code = "JM", HeInCode = "185", Name = "Jamaica", },
                new National() { Id = new Guid("665D03C6-346E-43D8-AD21-31492B4382AA"), Code = "JO", HeInCode = "186", Name = "Jordan", },
                new National() { Id = new Guid("9601FC62-41B1-44AF-AF8E-8A03C91C96B8"), Code = "JP", HeInCode = "232", Name = "Nhật Bản", },
                new National() { Id = new Guid("66400B32-893A-489C-A5E1-180D55FB20D4"), Code = "KE", HeInCode = "188", Name = "Kenya", },
                new National() { Id = new Guid("509F7D40-E740-472F-8A7A-84B5A527EB96"), Code = "KG", HeInCode = "192", Name = "Kyrgyzstan", },
                new National() { Id = new Guid("F468CB27-57FB-4B75-B3B7-70BB33CA2705"), Code = "KH", HeInCode = "139", Name = "Campuchia", },
                new National() { Id = new Guid("62947F31-4A3E-441B-A9D2-9642CE61DE2F"), Code = "KI", HeInCode = "189", Name = "Kiribati", },
                new National() { Id = new Guid("7AFAEFC0-9AA8-4BA7-98AE-618682A5BE7F"), Code = "KM", HeInCode = "143", Name = "Comoros", },
                new National() { Id = new Guid("506DDD2C-4F81-4D6D-806C-4C9E605BAB3F"), Code = "KN", HeInCode = "246", Name = "Saint Kitts và Nevis", },
                new National() { Id = new Guid("07C04D8D-4E1C-4896-BA8A-7D8172562B37"), Code = "KP", HeInCode = "277", Name = "Triều Tiên", },
                new National() { Id = new Guid("39EF7FCD-B539-46BE-90A6-BC3F6D1524D8"), Code = "KR", HeInCode = "174", Name = "Hàn Quốc", },
                new National() { Id = new Guid("90B2A6A0-BACD-4175-80E9-B8FDE9233786"), Code = "KW", HeInCode = "190", Name = "Kuwait", },
                new National() { Id = new Guid("994CF06F-B833-4415-84E0-94F3847B6DD8"), Code = "KY", HeInCode = "KY", Name = "Cayman islands", },
                new National() { Id = new Guid("1CC02FDA-F061-49AD-A4F1-ECB564A28C88"), Code = "KZ", HeInCode = "187", Name = "Kazakhstan", },
                new National() { Id = new Guid("18BE6A2D-0CC9-4E57-9B95-0FD5E0999094"), Code = "LA", HeInCode = "193", Name = "Lào", },
                new National() { Id = new Guid("66169C75-2AA7-409A-A7B9-D8CFE6AC80C0"), Code = "LB", HeInCode = "196", Name = "Li ban", },
                new National() { Id = new Guid("2EAB2085-D20B-4CC4-A85B-7567C9CE6EA9"), Code = "LC", HeInCode = "247", Name = "Saint Lucia", },
                new National() { Id = new Guid("9412C9E0-C4FE-442F-8B13-EA064BF48703"), Code = "LI", HeInCode = "199", Name = "Liechtenstein", },
                new National() { Id = new Guid("AFFDF19E-5ED4-497A-97D0-0FC95A547785"), Code = "LK", HeInCode = "262", Name = "Sri Lanka", },
                new National() { Id = new Guid("54CA17F4-F6F7-4BCF-9809-8D45153C2271"), Code = "LR", HeInCode = "197", Name = "Liberia", },
                new National() { Id = new Guid("426516A2-46E9-4103-8B44-22B4A30B21AE"), Code = "LS", HeInCode = "195", Name = "Lesotho", },
                new National() { Id = new Guid("58486ABC-86A6-4BB8-A610-EB0E4BDF0B73"), Code = "LT", HeInCode = "200", Name = "Litva", },
                new National() { Id = new Guid("F034E368-335C-4A9F-A039-B7EA83F8A315"), Code = "LU", HeInCode = "201", Name = "Luxembourg", },
                new National() { Id = new Guid("882C80EF-806D-4370-9FB1-F00A13A7A5C1"), Code = "LV", HeInCode = "194", Name = "Latvia", },
                new National() { Id = new Guid("F5FDCB6C-E0C5-4A57-ADCA-E743BA60CCEE"), Code = "LY", HeInCode = "198", Name = "Libya", },
                new National() { Id = new Guid("1D41F179-BA78-41D6-8ECF-595C7D6DE65A"), Code = "MA", HeInCode = "209", Name = "Maroc", },
                new National() { Id = new Guid("5B526A49-1694-4EB8-B602-4E150D12184D"), Code = "MC", HeInCode = "216", Name = "Monaco", },
                new National() { Id = new Guid("CC2A4D3B-BAE2-4602-9D23-4D4D2D918699"), Code = "MD", HeInCode = "215", Name = "Moldova", },
                new National() { Id = new Guid("B1829E62-C3DD-4F65-8C41-FDBE26AEDB93"), Code = "MG", HeInCode = "203", Name = "Madagascar", },
                new National() { Id = new Guid("BCB96598-0E05-4316-86D3-80413326555A"), Code = "MH", HeInCode = "210", Name = "Quần đảo Marshall", },
                new National() { Id = new Guid("B83926C4-6963-4F82-97F7-DFFA6E87EA7D"), Code = "MK", HeInCode = "202", Name = "Macedonia", },
                new National() { Id = new Guid("B171E933-4B7D-46F5-802A-14C5C9234ED7"), Code = "ML", HeInCode = "207", Name = "Mali", },
                new National() { Id = new Guid("CF8C2EBC-2ED1-404C-875C-D2151D54AB9E"), Code = "MM", HeInCode = "220", Name = "Myanma", },
                new National() { Id = new Guid("FD21963C-7B5E-44A8-8D70-2EDBDA437946"), Code = "MN", HeInCode = "217", Name = "Mông Cổ", },
                new National() { Id = new Guid("6477D7A3-465E-4277-A4EB-EF09B13F5ECA"), Code = "MO", HeInCode = "MO", Name = "Macau", },
                new National() { Id = new Guid("3AF1DAA8-65E1-4502-823D-3C8530608104"), Code = "MP", HeInCode = "MP", Name = "Northern mariana islands", },
                new National() { Id = new Guid("77365013-80D7-44D5-BD8D-472542CAC431"), Code = "MQ", HeInCode = "MQ", Name = "Martinique", },
                new National() { Id = new Guid("AA4399EC-1FF3-4837-A68E-0DF0720162CB"), Code = "MR", HeInCode = "211", Name = "Mauritanie", },
                new National() { Id = new Guid("D2EBAC27-3463-40CB-9EB2-86E1DA12A3BA"), Code = "MS", HeInCode = "MS", Name = "Montserrat", },
                new National() { Id = new Guid("78DCFD52-DE7B-4C1D-9DED-0E5D3F7A8A35"), Code = "MT", HeInCode = "208", Name = "Malta", },
                new National() { Id = new Guid("F1218849-B5CF-43C8-B3C4-B1FF145F27FC"), Code = "MU", HeInCode = "212", Name = "Mauritius", },
                new National() { Id = new Guid("8A003437-323C-451C-B211-1886F79C25F1"), Code = "MV", HeInCode = "206", Name = "Maldives", },
                new National() { Id = new Guid("52595376-4B2B-4746-BB17-16F7BA234A33"), Code = "MW", HeInCode = "204", Name = "Malawi", },
                new National() { Id = new Guid("92B69F82-F3E2-4EA9-9D4B-1763B1A75DEC"), Code = "MX", HeInCode = "213", Name = "Mexico", },
                new National() { Id = new Guid("22174CD0-7B2D-4C6B-BB6C-5273E63D28F0"), Code = "MY", HeInCode = "205", Name = "Malaysia", },
                new National() { Id = new Guid("4589F414-2018-4196-A42A-68FA60B41DAE"), Code = "MZ", HeInCode = "219", Name = "Mozambique", },
                new National() { Id = new Guid("EE707E39-4195-426C-ABF9-1CE21A771350"), Code = "NA", HeInCode = "221", Name = "Namibia", },
                new National() { Id = new Guid("F5F9C1ED-F4FB-4CFF-AEE3-2BCB0D8EED3E"), Code = "NC", HeInCode = "NC", Name = "New Caledonia", },
                new National() { Id = new Guid("264432FF-BA3D-4402-AE05-D3CBBDF7EEF4"), Code = "NE", HeInCode = "229", Name = "Niger", },
                new National() { Id = new Guid("6D5A6761-432B-4BD2-9B04-5E01C421DE23"), Code = "NF", HeInCode = "NF", Name = "Norfolk Island", },
                new National() { Id = new Guid("9ACB769E-D2DE-479C-B66A-424CE710A036"), Code = "NG", HeInCode = "230", Name = "Nigeria", },
                new National() { Id = new Guid("2EB9DE76-3D99-43A5-B17D-BA2F0E08C64A"), Code = "NI", HeInCode = "228", Name = "Nicaragua", },
                new National() { Id = new Guid("AB16A3ED-00CD-4445-8E7C-770B1965232E"), Code = "NL", HeInCode = "173", Name = "Hà Lan", },
                new National() { Id = new Guid("8FF51EA0-476B-4DEC-8736-70CC36EA1D2C"), Code = "NO", HeInCode = "225", Name = "Na Uy", },
                new National() { Id = new Guid("2F4455D6-EFEE-4959-8DFD-6F7DB81FAADD"), Code = "NP", HeInCode = "226", Name = "Nepal", },
                new National() { Id = new Guid("1F0C0C80-DCEB-47C4-9BFB-D9E2B29E8010"), Code = "NR", HeInCode = "224", Name = "Nauru", },
                new National() { Id = new Guid("50C044C3-6CD1-46AD-B10A-E879291806F2"), Code = "NU", HeInCode = "NU", Name = "Niue", },
                new National() { Id = new Guid("1BB67A2C-65B1-4437-B7DB-61BB5C5C945A"), Code = "NZ", HeInCode = "227", Name = "New Zealand", },
                new National() { Id = new Guid("1137907C-6292-4973-8A6A-5A8A55216701"), Code = "OM", HeInCode = "233", Name = "Oman", },
                new National() { Id = new Guid("561D896E-C3C5-4DFC-B13C-790AA25FBD5D"), Code = "PA", HeInCode = "236", Name = "Panama", },
                new National() { Id = new Guid("5A68453D-81D4-4417-A579-33D6A1C27EA6"), Code = "PE", HeInCode = "239", Name = "Peru", },
                new National() { Id = new Guid("58776BC3-EE4B-44AE-AC9E-A501437BDE2F"), Code = "PF", HeInCode = "PF", Name = "French Polynesia", },
                new National() { Id = new Guid("26D0E10A-43EA-4654-93BE-00A21F60B760"), Code = "PG", HeInCode = "237", Name = "Papua New Guinea", },
                new National() { Id = new Guid("7A384197-D55E-44B8-B389-A65F17E74E1F"), Code = "PH", HeInCode = "242", Name = "Philippines", },
                new National() { Id = new Guid("5BD03273-5B23-4181-892C-397126E8DA56"), Code = "PK", HeInCode = "234", Name = "Pakistan", },
                new National() { Id = new Guid("D1FEF153-87BC-403A-9590-0EC4CC8D676E"), Code = "PL", HeInCode = "118", Name = "Ba Lan", },
                new National() { Id = new Guid("788693D2-4AC9-4F85-94BF-13D021BC000D"), Code = "PM", HeInCode = "PM", Name = "St. Pierre and Miquelon", },
                new National() { Id = new Guid("79BC1BA0-A0F6-4065-9783-9E01ADE32CDE"), Code = "PN", HeInCode = "PN", Name = "Pitcairn", },
                new National() { Id = new Guid("0D9BF5F6-20BB-4B4F-8C3E-0B7205EABE19"), Code = "PR", HeInCode = "PR", Name = "Puerto Rico", },
                new National() { Id = new Guid("0105CFD9-5265-4DCC-B2D8-790ABECD5577"), Code = "PS", HeInCode = "PS", Name = "Palestinian Authority", },
                new National() { Id = new Guid("4B12F61E-5980-415F-A62B-B296753FD70D"), Code = "PT", HeInCode = "129", Name = "Bồ Đào Nha", },
                new National() { Id = new Guid("A3C5C224-A013-4E23-8655-641A0A76B38A"), Code = "PW", HeInCode = "235", Name = "Palau", },
                new National() { Id = new Guid("AF9C2425-679E-4459-8C68-2D357F4F93E5"), Code = "PY", HeInCode = "238", Name = "Paraguay", },
                new National() { Id = new Guid("DD951A03-C803-4351-AAC5-ED4EC9922BAB"), Code = "QA", HeInCode = "243", Name = "Qatar", },
                new National() { Id = new Guid("6D2D2371-8785-4A7B-94BA-84C804B2B0A2"), Code = "RE", HeInCode = "RE", Name = "Reunion", },
                new National() { Id = new Guid("DE0D7BE8-8A87-4358-B93E-E809AB17F238"), Code = "RO", HeInCode = "244", Name = "Romania", },
                new National() { Id = new Guid("1C1E8F0D-FA36-4DD5-A349-51F8F8CF1E11"), Code = "RU", HeInCode = "231", Name = "Nga", },
                new National() { Id = new Guid("F21A86DA-A1DE-4023-93C9-3A23D315A8CD"), Code = "RW", HeInCode = "245", Name = "Rwanda", },
                new National() { Id = new Guid("33AEB885-EA5C-4343-8011-B1DCCEBDD65F"), Code = "SA", HeInCode = "110", Name = "Ả Rập Saudi", },
                new National() { Id = new Guid("7E27CB42-41FB-4B20-B26B-3C1EA9B4FF5C"), Code = "SB", HeInCode = "260", Name = "Solomon", },
                new National() { Id = new Guid("63C8621A-FC44-4ABE-BA08-8D80520280CF"), Code = "SC", HeInCode = "255", Name = "Seychelles", },
                new National() { Id = new Guid("A30F588B-166D-4118-9D33-B8294E15AD44"), Code = "SD", HeInCode = "263", Name = "Sudan", },
                new National() { Id = new Guid("0F42743D-F2AE-4D4D-9E9C-6DCD785204FF"), Code = "SE", HeInCode = "273", Name = "Thụy Điển", },
                new National() { Id = new Guid("57C01CF1-7F20-4A6C-BEC9-BCC9A3A039FE"), Code = "SG", HeInCode = "257", Name = "Singapore", },
                new National() { Id = new Guid("5300FBB8-1D3B-48C2-B251-C9DAAB165B94"), Code = "SH", HeInCode = "SH", Name = "St. Helena", },
                new National() { Id = new Guid("92AEA1DA-5CF2-40FA-92A2-CCE297949451"), Code = "SI", HeInCode = "259", Name = "Slovenia", },
                new National() { Id = new Guid("99CFCE62-6540-4525-97B8-9A2E62618E05"), Code = "SJ", HeInCode = "SJ", Name = "Svalbard and Jan Mayen Islands", },
                new National() { Id = new Guid("B6169A90-920F-425D-A275-82601862A220"), Code = "SK", HeInCode = "258", Name = "Slovakia", },
                new National() { Id = new Guid("45696681-B325-4D55-B4EA-56A920227907"), Code = "SL", HeInCode = "256", Name = "Sierra Leone", },
                new National() { Id = new Guid("4B7309A1-DE33-4F43-A2FF-3F11E0E5869B"), Code = "SM", HeInCode = "250", Name = "San Marino", },
                new National() { Id = new Guid("CBA207C9-9EE4-4A20-876B-ECB1160D0845"), Code = "SN", HeInCode = "253", Name = "Sénégal", },
                new National() { Id = new Guid("72D527D4-00DF-4F9A-B0E1-E1FA84A4BA6D"), Code = "SO", HeInCode = "261", Name = "Somalia", },
                new National() { Id = new Guid("3671801A-1C88-4DC6-9E75-D766644C2AF9"), Code = "SR", HeInCode = "264", Name = "Suriname", },
                new National() { Id = new Guid("3F3E1D5E-CA7B-45EF-9E1E-F3C471E8894F"), Code = "ST", HeInCode = "251", Name = "São Tomé và Príncipe", },
                new National() { Id = new Guid("E5439053-279D-4094-852D-0C2EDC6992ED"), Code = "SV", HeInCode = "157", Name = "El Salvador", },
                new National() { Id = new Guid("44FF82D4-3356-4F71-9AA2-DC5F161537F0"), Code = "SY", HeInCode = "266", Name = "Syria", },
                new National() { Id = new Guid("8562FD7F-49AA-46CF-BBC9-71F7460C6BA7"), Code = "SZ", HeInCode = "265", Name = "Swaziland", },
                new National() { Id = new Guid("716A0688-0378-4941-AF8F-C11DC4C45AC2"), Code = "TC", HeInCode = "TC", Name = "Turks and Caicos Islands", },
                new National() { Id = new Guid("36299397-B100-420B-BD1B-3F18EDA310FA"), Code = "TD", HeInCode = "270", Name = "Tchad", },
                new National() { Id = new Guid("2EEAD3FB-8C57-4699-A48D-B9EB2A781D23"), Code = "TF", HeInCode = "TF", Name = "French Southern Territories", },
                new National() { Id = new Guid("BA947C48-36FB-420B-B2D9-663FE308B18C"), Code = "TG", HeInCode = "275", Name = "Togo", },
                new National() { Id = new Guid("F07D3DDE-AEA1-4F0A-BA9D-310CDA4FA6E9"), Code = "TH", HeInCode = "271", Name = "Thái Lan", },
                new National() { Id = new Guid("53B7D739-4B49-4A35-9D04-93520D79D105"), Code = "TJ", HeInCode = "267", Name = "Tajikistan", },
                new National() { Id = new Guid("5351587C-9713-44C9-9088-9626D01300C8"), Code = "TK", HeInCode = "TK", Name = "Tokelau", },
                new National() { Id = new Guid("6B8836AA-2476-4D82-98F1-0B7F56E66F7A"), Code = "TL", HeInCode = "TL", Name = "Timor Leste", },
                new National() { Id = new Guid("7AF80A81-41E5-47DE-ABD3-7CE25F9C39B4"), Code = "TM", HeInCode = "282", Name = "Turkmenistan", },
                new National() { Id = new Guid("1CB83A16-11A1-438B-8FD9-22E661C5904A"), Code = "TN", HeInCode = "281", Name = "Tunisia", },
                new National() { Id = new Guid("05F8A24E-3764-41AF-B79B-3E05DA6964AD"), Code = "TO", HeInCode = "276", Name = "Tonga", },
                new National() { Id = new Guid("EE02AA87-F8DC-44AC-9AC9-830120F05656"), Code = "TR", HeInCode = "272", Name = "Thổ Nhĩ Kỳ", },
                new National() { Id = new Guid("36DDC306-ADF0-4897-A200-6377FF0D9042"), Code = "TT", HeInCode = "278", Name = "Trinidad và Tobago", },
                new National() { Id = new Guid("F79BAAF7-6191-4BA9-B38A-2F1B50D05598"), Code = "TV", HeInCode = "283", Name = "Tuvalu", },
                new National() { Id = new Guid("BF1BF333-4604-4974-838F-886100C006F3"), Code = "TW", HeInCode = "TW", Name = "Đài Loan", },
                new National() { Id = new Guid("FF78779A-45CD-4076-8C61-442A9A3873F2"), Code = "TZ", HeInCode = "268", Name = "Tanzania", },
                new National() { Id = new Guid("AF24512B-01AE-4420-96CB-62051EDE96CC"), Code = "UA", HeInCode = "286", Name = "Ukraina", },
                new National() { Id = new Guid("AD4EF5F1-E823-4ED4-9AD5-CEC4A2CAE6AF"), Code = "UG", HeInCode = "285", Name = "Uganda", },
                new National() { Id = new Guid("05600686-62BC-4BE9-B009-58AE6FAC5DC2"), Code = "UM", HeInCode = "UM", Name = "United States Minor Outlying Islands", },
                new National() { Id = new Guid("97BC234B-7D4C-4870-801B-74F1998741BE"), Code = "US", HeInCode = "175", Name = "Hoa Kỳ", },
                new National() { Id = new Guid("EDB5A6E1-B084-4E46-87AB-22D38DA9CF0A"), Code = "UY", HeInCode = "287", Name = "Uruguay", },
                new National() { Id = new Guid("9EE7B166-4C6F-4136-8928-C6246C3E76D5"), Code = "UZ", HeInCode = "288", Name = "Uzbekistan", },
                new National() { Id = new Guid("1760CDB2-5D9E-4A4D-A422-9D2D54333B72"), Code = "VA", HeInCode = "290", Name = "Thành Vatican", },
                new National() { Id = new Guid("A1F120ED-4785-486E-B796-DD8CD569A415"), Code = "VC", HeInCode = "248", Name = "Saint Vincent và Grenadines", },
                new National() { Id = new Guid("A7A696DE-3FD8-48C2-B87A-6464B222AF87"), Code = "VE", HeInCode = "291", Name = "Venezuela", },
                new National() { Id = new Guid("539247EF-F9A9-4893-B250-2AA204A87640"), Code = "VG", HeInCode = "VG", Name = "Virgin Islands (British)", },
                new National() { Id = new Guid("FB67B422-6903-494E-945D-FA09F031B4F1"), Code = "VI", HeInCode = "VI", Name = "Virgin Islands (U.S.)", },
                new National() { Id = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2"), Code = "VN", HeInCode = "000", Name = "Việt Nam", },
                new National() { Id = new Guid("3D9D9CA5-3356-48B3-B518-EB806A6128EE"), Code = "VU", HeInCode = "289", Name = "Vanuatu", },
                new National() { Id = new Guid("FFD3FABD-A5F1-4442-837B-D53B5D89272E"), Code = "WF", HeInCode = "WF", Name = "Wallis and Futuna Islands", },
                new National() { Id = new Guid("74C266FD-7287-4525-ACA3-6BB66DDCF61F"), Code = "WS", HeInCode = "249", Name = "Samoa", },
                new National() { Id = new Guid("A695B824-CFC2-40A3-B5A1-35243A6E2116"), Code = "YE", HeInCode = "293", Name = "Yemen", },
                new National() { Id = new Guid("C7F500B0-BE15-4AB8-AE5C-1DB430D19B8C"), Code = "YT", HeInCode = "YT", Name = "Mayotte", },
                new National() { Id = new Guid("A1BA5BE8-FEF9-470A-A5F7-EFCF7FC900A4"), Code = "ME", HeInCode = "218", Name = "Montenegro", },
                new National() { Id = new Guid("16BFB332-7FFE-4D31-A2A2-05E7CC250969"), Code = "Z1", HeInCode = "Z1", Name = "Sovereign Military Order of Malta (SMOM)", },
                new National() { Id = new Guid("E43C3F5C-E8D7-430A-9869-E61337BD4188"), Code = "Z2", HeInCode = "Z2", Name = "British Southern and Antarctic Territories", },
                new National() { Id = new Guid("5D60E969-8387-42E4-B866-31DFB209F433"), Code = "Z3", HeInCode = "Z3", Name = "England", },
                new National() { Id = new Guid("20AA6E3B-0838-45FC-9769-161B291E5E24"), Code = "Z4", HeInCode = "Z4", Name = "Scotland", },
                new National() { Id = new Guid("D0357290-582A-47CD-984C-8815D38454BE"), Code = "Z5", HeInCode = "Z5", Name = "Northern Ireland", },
                new National() { Id = new Guid("2E24284D-FE7B-477B-A3E9-23505CCBE379"), Code = "Z6", HeInCode = "Z6", Name = "Great Britain (See United Kingdom)", },
                new National() { Id = new Guid("C8766416-ED13-4631-A9C4-E89E782055C9"), Code = "Z7", HeInCode = "Z7", Name = "Wales", },
                new National() { Id = new Guid("59E93599-98E9-44DE-B9D1-BBBF17C599BF"), Code = "ZA", HeInCode = "223", Name = "Nam Phi", },
                new National() { Id = new Guid("E1FC9395-73B5-4FD6-8C31-37FEF3A3E866"), Code = "ZM", HeInCode = "294", Name = "Zambia", },
                new National() { Id = new Guid("90EF0553-8520-4D57-AE3B-112EBF28B313"), Code = "ZW", HeInCode = "295", Name = "Zimbabwe", },
                new National() { Id = new Guid("39351753-1AF5-4797-89E2-B97589DB8D2E"), Code = "AZ", HeInCode = "114", Name = "Cộng hòa Azerbaijan", },
                new National() { Id = new Guid("DD79EAD4-6E12-4CB8-AFF5-8F00D8BF9E99"), Code = "SD", HeInCode = "222", Name = "Nam Sudan", },
                new National() { Id = new Guid("A8B38E56-D3EA-435F-907A-615ED7CED805"), Code = "AF", HeInCode = "101", Name = "Afghanistan", });
        }
    }
}