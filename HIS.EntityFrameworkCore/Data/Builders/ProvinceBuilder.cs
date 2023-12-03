using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public class ProvinceBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Province>().HasData(
               new Province() { Id = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), ProvinceCode = "01", ProvinceName = "Thành phố Hà Nội" },
               new Province() { Id = new Guid("E7FE23CB-4304-4FB0-90A5-9FF4DA5048AA"), ProvinceCode = "02", ProvinceName = "Tỉnh Hà Giang" },
               new Province() { Id = new Guid("F5D76F98-2024-4C60-81AD-577359CB69D1"), ProvinceCode = "04", ProvinceName = "Tỉnh Cao Bằng" },
               new Province() { Id = new Guid("8ED43986-0586-4742-8F89-A673C9F63756"), ProvinceCode = "06", ProvinceName = "Tỉnh Bắc Kạn" },
               new Province() { Id = new Guid("38E1FFEB-7572-40C7-A716-CD880EB8D1CE"), ProvinceCode = "08", ProvinceName = "Tỉnh Tuyên Quang" },
               new Province() { Id = new Guid("528FE36B-AC63-4F15-96F5-104AC221A155"), ProvinceCode = "10", ProvinceName = "Tỉnh Lào Cai" },
               new Province() { Id = new Guid("52B17F24-A4A1-4CC6-88A0-C526EE8256C6"), ProvinceCode = "11", ProvinceName = "Tỉnh Điện Biên" },
               new Province() { Id = new Guid("4E6A7717-9E60-4BAE-A2D4-D29DACD8AF47"), ProvinceCode = "12", ProvinceName = "Tỉnh Lai Châu" },
               new Province() { Id = new Guid("8EB57A8E-8281-41BB-A5AB-637DCAC67177"), ProvinceCode = "14", ProvinceName = "Tỉnh Sơn La" },
               new Province() { Id = new Guid("77E4B05D-6245-43EE-BA94-84FAAECE9018"), ProvinceCode = "15", ProvinceName = "Tỉnh Yên Bái" },
               new Province() { Id = new Guid("003360AA-6ADC-4E1C-8DA9-FD1D1665729D"), ProvinceCode = "17", ProvinceName = "Tỉnh Hoà Bình" },
               new Province() { Id = new Guid("927F685B-F766-4BF8-93ED-AE7AABC4071C"), ProvinceCode = "19", ProvinceName = "Tỉnh Thái Nguyên" },
               new Province() { Id = new Guid("C16DBBE1-BEA2-413B-9216-5B547DEAC9F5"), ProvinceCode = "20", ProvinceName = "Tỉnh Lạng Sơn" },
               new Province() { Id = new Guid("37D13FE4-1FD2-4268-BBAE-4AB301F634C5"), ProvinceCode = "22", ProvinceName = "Tỉnh Quảng Ninh" },
               new Province() { Id = new Guid("9C2A8569-D860-459D-8C3A-49966EA0038D"), ProvinceCode = "24", ProvinceName = "Tỉnh Bắc Giang" },
               new Province() { Id = new Guid("A1F48DDA-F1A3-473A-B4F7-6843312303F4"), ProvinceCode = "25", ProvinceName = "Tỉnh Phú Thọ" },
               new Province() { Id = new Guid("7ACBF3EC-7068-4007-A871-E0FEE1EF28C5"), ProvinceCode = "26", ProvinceName = "Tỉnh Vĩnh Phúc" },
               new Province() { Id = new Guid("2D80DBCF-C7D5-4450-9847-E7E6F737F567"), ProvinceCode = "27", ProvinceName = "Tỉnh Bắc Ninh" },
               new Province() { Id = new Guid("ED0A3763-3A96-46C5-8094-C47A4708E3CB"), ProvinceCode = "30", ProvinceName = "Tỉnh Hải Dương" },
               new Province() { Id = new Guid("46DDF496-DF97-40B4-9B23-BFD17357ABBE"), ProvinceCode = "31", ProvinceName = "Thành phố Hải Phòng" },
               new Province() { Id = new Guid("198417F7-E503-4435-BDE2-7547487C943A"), ProvinceCode = "33", ProvinceName = "Tỉnh Hưng Yên" },
               new Province() { Id = new Guid("1D8B3FF0-1BBD-4FA4-A4C8-1A4E2C394A55"), ProvinceCode = "34", ProvinceName = "Tỉnh Thái Bình" },
               new Province() { Id = new Guid("0FDFD770-BEE4-4DC4-9EB5-D86816BFC2BF"), ProvinceCode = "35", ProvinceName = "Tỉnh Hà Nam" },
               new Province() { Id = new Guid("94DAB20E-C05D-4AA9-93E9-82E972792756"), ProvinceCode = "36", ProvinceName = "Tỉnh Nam Định" },
               new Province() { Id = new Guid("AEE0F859-E3BD-41AE-BE15-17060D5AD617"), ProvinceCode = "37", ProvinceName = "Tỉnh Ninh Bình" },
               new Province() { Id = new Guid("B2CACE92-0D42-4789-97C7-83EA3C3667C5"), ProvinceCode = "38", ProvinceName = "Tỉnh Thanh Hóa" },
               new Province() { Id = new Guid("EC0B077D-3957-4089-85F8-C1D6742AAB19"), ProvinceCode = "40", ProvinceName = "Tỉnh Nghệ An" },
               new Province() { Id = new Guid("B2035AC5-5E24-4A18-8587-62E65FD64697"), ProvinceCode = "42", ProvinceName = "Tỉnh Hà Tĩnh" },
               new Province() { Id = new Guid("3035B967-95AA-46A5-BE3F-B1F7BEC1FD51"), ProvinceCode = "44", ProvinceName = "Tỉnh Quảng Bình" },
               new Province() { Id = new Guid("8F0F2A47-34E4-4AF3-811A-4D9C1FBF1CAE"), ProvinceCode = "45", ProvinceName = "Tỉnh Quảng Trị" },
               new Province() { Id = new Guid("0729FB2E-AE19-41F3-B948-B0F0C51FBF99"), ProvinceCode = "46", ProvinceName = "Tỉnh Thừa Thiên Huế" },
               new Province() { Id = new Guid("40064E04-52C1-460D-B3D3-04F4E991F82C"), ProvinceCode = "48", ProvinceName = "Thành phố Đà Nẵng" },
               new Province() { Id = new Guid("3109E53A-812D-455E-A968-E86FF499D74D"), ProvinceCode = "49", ProvinceName = "Tỉnh Quảng Nam" },
               new Province() { Id = new Guid("AF97B966-5B74-4580-A948-C8A9DF0A5FBA"), ProvinceCode = "51", ProvinceName = "Tỉnh Quảng Ngãi" },
               new Province() { Id = new Guid("7A3C3BE6-FE62-42AB-9764-F8E62D7F5916"), ProvinceCode = "52", ProvinceName = "Tỉnh Bình Định" },
               new Province() { Id = new Guid("C30F4992-257A-4ABF-ABB0-2EA4B36F247F"), ProvinceCode = "54", ProvinceName = "Tỉnh Phú Yên" },
               new Province() { Id = new Guid("5329306E-8290-4CA4-B110-0678C20752E0"), ProvinceCode = "56", ProvinceName = "Tỉnh Khánh Hòa" },
               new Province() { Id = new Guid("68D199CC-B739-4D61-B412-40D2242F374D"), ProvinceCode = "58", ProvinceName = "Tỉnh Ninh Thuận" },
               new Province() { Id = new Guid("33D6EC24-75EE-402E-B8D2-3296E90EA336"), ProvinceCode = "60", ProvinceName = "Tỉnh Bình Thuận" },
               new Province() { Id = new Guid("3BAAFFD5-90A2-471F-8581-B5969184FCBE"), ProvinceCode = "62", ProvinceName = "Tỉnh Kon Tum" },
               new Province() { Id = new Guid("B42CBA39-912A-4400-84A5-FE15EB71766E"), ProvinceCode = "64", ProvinceName = "Tỉnh Gia Lai" },
               new Province() { Id = new Guid("64A15171-A037-45B4-A55D-08EE58CE687D"), ProvinceCode = "66", ProvinceName = "Tỉnh Đắk Lắk" },
               new Province() { Id = new Guid("2C03541E-DB56-4BCB-8012-52B0F130CA09"), ProvinceCode = "67", ProvinceName = "Tỉnh Đắk Nông" },
               new Province() { Id = new Guid("395F3325-851F-41EE-B652-5002CE7CF547"), ProvinceCode = "68", ProvinceName = "Tỉnh Lâm Đồng" },
               new Province() { Id = new Guid("839F0EFB-168D-4110-A041-60B463AE48A1"), ProvinceCode = "70", ProvinceName = "Tỉnh Bình Phước" },
               new Province() { Id = new Guid("6F51A702-3C62-4A43-8042-9CF6E8BF3186"), ProvinceCode = "72", ProvinceName = "Tỉnh Tây Ninh" },
               new Province() { Id = new Guid("EF981A1E-0AF1-4B7F-9FD7-42DE078E7D97"), ProvinceCode = "74", ProvinceName = "Tỉnh Bình Dương" },
               new Province() { Id = new Guid("B6CF7563-F2BE-4273-BCC7-58BB3CD4EDEC"), ProvinceCode = "75", ProvinceName = "Tỉnh Đồng Nai" },
               new Province() { Id = new Guid("0B13943C-EAD8-4E76-80B8-33B31828DD7A"), ProvinceCode = "77", ProvinceName = "Tỉnh Bà Rịa - Vũng Tàu" },
               new Province() { Id = new Guid("7184C251-1C62-4B69-A63F-DE49E85633F0"), ProvinceCode = "79", ProvinceName = "Thành phố Hồ Chí Minh" },
               new Province() { Id = new Guid("9D49B503-AC5F-47F3-AAA2-8D18853BFBA6"), ProvinceCode = "80", ProvinceName = "Tỉnh Long An" },
               new Province() { Id = new Guid("F06E27BF-1470-4F7A-873F-F0DC77E405E4"), ProvinceCode = "82", ProvinceName = "Tỉnh Tiền Giang" },
               new Province() { Id = new Guid("952AA342-C05D-46D3-8FFE-6A22D7512DC2"), ProvinceCode = "83", ProvinceName = "Tỉnh Bến Tre" },
               new Province() { Id = new Guid("702C3CF1-D0B3-4647-8D39-7549DD42F610"), ProvinceCode = "84", ProvinceName = "Tỉnh Trà Vinh" },
               new Province() { Id = new Guid("E5A4E82B-B29D-4B47-A563-82977EA93346"), ProvinceCode = "86", ProvinceName = "Tỉnh Vĩnh Long" },
               new Province() { Id = new Guid("FA11AD72-29B7-49F4-986D-FEA0D53DE210"), ProvinceCode = "87", ProvinceName = "Tỉnh Đồng Tháp" },
               new Province() { Id = new Guid("72478ADD-CA26-4A9B-92BD-2B075006F36A"), ProvinceCode = "89", ProvinceName = "Tỉnh An Giang" },
               new Province() { Id = new Guid("DA06856D-9E6C-49F7-BBED-CA2A06CA81C1"), ProvinceCode = "91", ProvinceName = "Tỉnh Kiên Giang" },
               new Province() { Id = new Guid("619D7AEE-4E6A-4993-9D7A-C6E32958851F"), ProvinceCode = "92", ProvinceName = "Thành phố Cần Thơ" },
               new Province() { Id = new Guid("CD4EAB40-92A3-4898-8A65-C67CCDE721C0"), ProvinceCode = "93", ProvinceName = "Tỉnh Hậu Giang" },
               new Province() { Id = new Guid("3FD18CC5-7204-42A9-A940-C5CF3128518F"), ProvinceCode = "94", ProvinceName = "Tỉnh Sóc Trăng" },
               new Province() { Id = new Guid("B6BDDA7D-B047-45A0-9D73-FFCB4E938E38"), ProvinceCode = "95", ProvinceName = "Tỉnh Bạc Liêu" },
               new Province() { Id = new Guid("F2AAC7AE-5A85-48FC-9166-D9AB6EFB79AB"), ProvinceCode = "96", ProvinceName = "Tỉnh Cà Mau" });
        }
    }
}
