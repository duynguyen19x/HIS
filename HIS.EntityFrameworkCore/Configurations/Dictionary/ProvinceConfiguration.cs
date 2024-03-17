using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    internal class ProvinceConfiguration : IEntityTypeConfiguration<DIProvince>
    {
        public void Configure(EntityTypeBuilder<DIProvince> builder)
        {
            builder.ToTable("DIC_Province");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasData(
               new DIProvince() { Id = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "01", Name = "Thành phố Hà Nội" },
               new DIProvince() { Id = new Guid("E7FE23CB-4304-4FB0-90A5-9FF4DA5048AA"), Code = "02", Name = "Tỉnh Hà Giang" },
               new DIProvince() { Id = new Guid("F5D76F98-2024-4C60-81AD-577359CB69D1"), Code = "04", Name = "Tỉnh Cao Bằng" },
               new DIProvince() { Id = new Guid("8ED43986-0586-4742-8F89-A673C9F63756"), Code = "06", Name = "Tỉnh Bắc Kạn" },
               new DIProvince() { Id = new Guid("38E1FFEB-7572-40C7-A716-CD880EB8D1CE"), Code = "08", Name = "Tỉnh Tuyên Quang" },
               new DIProvince() { Id = new Guid("528FE36B-AC63-4F15-96F5-104AC221A155"), Code = "10", Name = "Tỉnh Lào Cai" },
               new DIProvince() { Id = new Guid("52B17F24-A4A1-4CC6-88A0-C526EE8256C6"), Code = "11", Name = "Tỉnh Điện Biên" },
               new DIProvince() { Id = new Guid("4E6A7717-9E60-4BAE-A2D4-D29DACD8AF47"), Code = "12", Name = "Tỉnh Lai Châu" },
               new DIProvince() { Id = new Guid("8EB57A8E-8281-41BB-A5AB-637DCAC67177"), Code = "14", Name = "Tỉnh Sơn La" },
               new DIProvince() { Id = new Guid("77E4B05D-6245-43EE-BA94-84FAAECE9018"), Code = "15", Name = "Tỉnh Yên Bái" },
               new DIProvince() { Id = new Guid("003360AA-6ADC-4E1C-8DA9-FD1D1665729D"), Code = "17", Name = "Tỉnh Hoà Bình" },
               new DIProvince() { Id = new Guid("927F685B-F766-4BF8-93ED-AE7AABC4071C"), Code = "19", Name = "Tỉnh Thái Nguyên" },
               new DIProvince() { Id = new Guid("C16DBBE1-BEA2-413B-9216-5B547DEAC9F5"), Code = "20", Name = "Tỉnh Lạng Sơn" },
               new DIProvince() { Id = new Guid("37D13FE4-1FD2-4268-BBAE-4AB301F634C5"), Code = "22", Name = "Tỉnh Quảng Ninh" },
               new DIProvince() { Id = new Guid("9C2A8569-D860-459D-8C3A-49966EA0038D"), Code = "24", Name = "Tỉnh Bắc Giang" },
               new DIProvince() { Id = new Guid("A1F48DDA-F1A3-473A-B4F7-6843312303F4"), Code = "25", Name = "Tỉnh Phú Thọ" },
               new DIProvince() { Id = new Guid("7ACBF3EC-7068-4007-A871-E0FEE1EF28C5"), Code = "26", Name = "Tỉnh Vĩnh Phúc" },
               new DIProvince() { Id = new Guid("2D80DBCF-C7D5-4450-9847-E7E6F737F567"), Code = "27", Name = "Tỉnh Bắc Ninh" },
               new DIProvince() { Id = new Guid("ED0A3763-3A96-46C5-8094-C47A4708E3CB"), Code = "30", Name = "Tỉnh Hải Dương" },
               new DIProvince() { Id = new Guid("46DDF496-DF97-40B4-9B23-BFD17357ABBE"), Code = "31", Name = "Thành phố Hải Phòng" },
               new DIProvince() { Id = new Guid("198417F7-E503-4435-BDE2-7547487C943A"), Code = "33", Name = "Tỉnh Hưng Yên" },
               new DIProvince() { Id = new Guid("1D8B3FF0-1BBD-4FA4-A4C8-1A4E2C394A55"), Code = "34", Name = "Tỉnh Thái Bình" },
               new DIProvince() { Id = new Guid("0FDFD770-BEE4-4DC4-9EB5-D86816BFC2BF"), Code = "35", Name = "Tỉnh Hà Nam" },
               new DIProvince() { Id = new Guid("94DAB20E-C05D-4AA9-93E9-82E972792756"), Code = "36", Name = "Tỉnh Nam Định" },
               new DIProvince() { Id = new Guid("AEE0F859-E3BD-41AE-BE15-17060D5AD617"), Code = "37", Name = "Tỉnh Ninh Bình" },
               new DIProvince() { Id = new Guid("B2CACE92-0D42-4789-97C7-83EA3C3667C5"), Code = "38", Name = "Tỉnh Thanh Hóa" },
               new DIProvince() { Id = new Guid("EC0B077D-3957-4089-85F8-C1D6742AAB19"), Code = "40", Name = "Tỉnh Nghệ An" },
               new DIProvince() { Id = new Guid("B2035AC5-5E24-4A18-8587-62E65FD64697"), Code = "42", Name = "Tỉnh Hà Tĩnh" },
               new DIProvince() { Id = new Guid("3035B967-95AA-46A5-BE3F-B1F7BEC1FD51"), Code = "44", Name = "Tỉnh Quảng Bình" },
               new DIProvince() { Id = new Guid("8F0F2A47-34E4-4AF3-811A-4D9C1FBF1CAE"), Code = "45", Name = "Tỉnh Quảng Trị" },
               new DIProvince() { Id = new Guid("0729FB2E-AE19-41F3-B948-B0F0C51FBF99"), Code = "46", Name = "Tỉnh Thừa Thiên Huế" },
               new DIProvince() { Id = new Guid("40064E04-52C1-460D-B3D3-04F4E991F82C"), Code = "48", Name = "Thành phố Đà Nẵng" },
               new DIProvince() { Id = new Guid("3109E53A-812D-455E-A968-E86FF499D74D"), Code = "49", Name = "Tỉnh Quảng Nam" },
               new DIProvince() { Id = new Guid("AF97B966-5B74-4580-A948-C8A9DF0A5FBA"), Code = "51", Name = "Tỉnh Quảng Ngãi" },
               new DIProvince() { Id = new Guid("7A3C3BE6-FE62-42AB-9764-F8E62D7F5916"), Code = "52", Name = "Tỉnh Bình Định" },
               new DIProvince() { Id = new Guid("C30F4992-257A-4ABF-ABB0-2EA4B36F247F"), Code = "54", Name = "Tỉnh Phú Yên" },
               new DIProvince() { Id = new Guid("5329306E-8290-4CA4-B110-0678C20752E0"), Code = "56", Name = "Tỉnh Khánh Hòa" },
               new DIProvince() { Id = new Guid("68D199CC-B739-4D61-B412-40D2242F374D"), Code = "58", Name = "Tỉnh Ninh Thuận" },
               new DIProvince() { Id = new Guid("33D6EC24-75EE-402E-B8D2-3296E90EA336"), Code = "60", Name = "Tỉnh Bình Thuận" },
               new DIProvince() { Id = new Guid("3BAAFFD5-90A2-471F-8581-B5969184FCBE"), Code = "62", Name = "Tỉnh Kon Tum" },
               new DIProvince() { Id = new Guid("B42CBA39-912A-4400-84A5-FE15EB71766E"), Code = "64", Name = "Tỉnh Gia Lai" },
               new DIProvince() { Id = new Guid("64A15171-A037-45B4-A55D-08EE58CE687D"), Code = "66", Name = "Tỉnh Đắk Lắk" },
               new DIProvince() { Id = new Guid("2C03541E-DB56-4BCB-8012-52B0F130CA09"), Code = "67", Name = "Tỉnh Đắk Nông" },
               new DIProvince() { Id = new Guid("395F3325-851F-41EE-B652-5002CE7CF547"), Code = "68", Name = "Tỉnh Lâm Đồng" },
               new DIProvince() { Id = new Guid("839F0EFB-168D-4110-A041-60B463AE48A1"), Code = "70", Name = "Tỉnh Bình Phước" },
               new DIProvince() { Id = new Guid("6F51A702-3C62-4A43-8042-9CF6E8BF3186"), Code = "72", Name = "Tỉnh Tây Ninh" },
               new DIProvince() { Id = new Guid("EF981A1E-0AF1-4B7F-9FD7-42DE078E7D97"), Code = "74", Name = "Tỉnh Bình Dương" },
               new DIProvince() { Id = new Guid("B6CF7563-F2BE-4273-BCC7-58BB3CD4EDEC"), Code = "75", Name = "Tỉnh Đồng Nai" },
               new DIProvince() { Id = new Guid("0B13943C-EAD8-4E76-80B8-33B31828DD7A"), Code = "77", Name = "Tỉnh Bà Rịa - Vũng Tàu" },
               new DIProvince() { Id = new Guid("7184C251-1C62-4B69-A63F-DE49E85633F0"), Code = "79", Name = "Thành phố Hồ Chí Minh" },
               new DIProvince() { Id = new Guid("9D49B503-AC5F-47F3-AAA2-8D18853BFBA6"), Code = "80", Name = "Tỉnh Long An" },
               new DIProvince() { Id = new Guid("F06E27BF-1470-4F7A-873F-F0DC77E405E4"), Code = "82", Name = "Tỉnh Tiền Giang" },
               new DIProvince() { Id = new Guid("952AA342-C05D-46D3-8FFE-6A22D7512DC2"), Code = "83", Name = "Tỉnh Bến Tre" },
               new DIProvince() { Id = new Guid("702C3CF1-D0B3-4647-8D39-7549DD42F610"), Code = "84", Name = "Tỉnh Trà Vinh" },
               new DIProvince() { Id = new Guid("E5A4E82B-B29D-4B47-A563-82977EA93346"), Code = "86", Name = "Tỉnh Vĩnh Long" },
               new DIProvince() { Id = new Guid("FA11AD72-29B7-49F4-986D-FEA0D53DE210"), Code = "87", Name = "Tỉnh Đồng Tháp" },
               new DIProvince() { Id = new Guid("72478ADD-CA26-4A9B-92BD-2B075006F36A"), Code = "89", Name = "Tỉnh An Giang" },
               new DIProvince() { Id = new Guid("DA06856D-9E6C-49F7-BBED-CA2A06CA81C1"), Code = "91", Name = "Tỉnh Kiên Giang" },
               new DIProvince() { Id = new Guid("619D7AEE-4E6A-4993-9D7A-C6E32958851F"), Code = "92", Name = "Thành phố Cần Thơ" },
               new DIProvince() { Id = new Guid("CD4EAB40-92A3-4898-8A65-C67CCDE721C0"), Code = "93", Name = "Tỉnh Hậu Giang" },
               new DIProvince() { Id = new Guid("3FD18CC5-7204-42A9-A940-C5CF3128518F"), Code = "94", Name = "Tỉnh Sóc Trăng" },
               new DIProvince() { Id = new Guid("B6BDDA7D-B047-45A0-9D73-FFCB4E938E38"), Code = "95", Name = "Tỉnh Bạc Liêu" },
               new DIProvince() { Id = new Guid("F2AAC7AE-5A85-48FC-9166-D9AB6EFB79AB"), Code = "96", Name = "Tỉnh Cà Mau" });
        }
    }
}
