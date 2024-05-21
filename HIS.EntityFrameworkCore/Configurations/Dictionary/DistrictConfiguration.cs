using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            var data = new List<District>()
            {
                new District() { Id = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "001", Name = "Quận Ba Đình" },
                new District() { Id = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "002", Name = "Quận Hoàn Kiếm" },
                new District() { Id = new Guid("F3A6BCBB-8F93-49DA-85E7-E9B07ED72986"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "003", Name = "Quận Tây Hồ" },
                new District() { Id = new Guid("F3A6BCBB-8F93-49DA-85E7-E9B07ED72987"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "004", Name = "Quận Long Biên" },
                new District() { Id = new Guid("F3A6BCBB-8F93-49DA-85E7-E9B07ED72988"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "005", Name = "Quận Cầu Giấy" },
                new District() { Id = new Guid("F3A6BCBB-8F93-49DA-85E7-E9B07ED72989"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "006", Name = "Quận Đống Đa" },
                new District() { Id = new Guid("F3A6BCBB-8F93-49DA-85E7-E9B07ED72980"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "007", Name = "Quận Hai Bà Trưng" },
                new District() { Id = new Guid("C68ED451-7361-48A9-9F1E-9AD4C1B1BB58"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "008", Name = "Quận Hoàng Mai" },
                new District() { Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D501"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "009", Name = "Quận Thanh Xuân" },
                new District() { Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D502"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "016", Name = "Huyện Sóc Sơn" },
                new District() { Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D503"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "017", Name = "Huyện Đông Anh" },
                new District() { Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D504"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "018", Name = "Huyện Gia Lâm" },
                new District() { Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D505"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "019", Name = "Quận Nam Từ Liêm" },
                new District() { Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D506"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "020", Name = "Huyện Thanh Trì" },
                new District() { Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D507"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "021", Name = "Quận Bắc Từ Liêm" },
                new District() { Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D508"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "250", Name = "Huyện Mê Linh" },
                new District() { Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D509"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "268", Name = "Quận Hà Đông" },
                new District() { Id = new Guid("EF1439E7-3DFA-40D3-A8DE-A0DA87140B45"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "269", Name = "Thị xã Sơn Tây" },
                new District() { Id = new Guid("EF1439E7-3DFA-40D3-A8DE-A0DA87140B46"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "271", Name = "Huyện Ba Vì" },
                new District() { Id = new Guid("EF1439E7-3DFA-40D3-A8DE-A0DA87140B47"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "272", Name = "Huyện Phúc Thọ" },
                new District() { Id = new Guid("EF1439E7-3DFA-40D3-A8DE-A0DA87140B48"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "273", Name = "Huyện Đan Phượng" },
                new District() { Id = new Guid("ECDEB90D-8BC9-43EE-A233-D1FDC543B11B"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "274", Name = "Huyện Hoài Đức" },
                new District() { Id = new Guid("12518EF2-BC95-4A4D-8991-727782426BA8"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "275", Name = "Huyện Quốc Oai" },
                new District() { Id = new Guid("5CF104DF-C5E5-43BF-9AAD-89EB8236092B"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "276", Name = "Huyện Thạch Thất" },
                new District() { Id = new Guid("9F693F27-FE31-435B-BE4E-0BB17DBAF8B7"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "277", Name = "Huyện Chương Mỹ" },
                new District() { Id = new Guid("4D28238A-1D66-4DCA-AE09-5104B16C5EEF"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "278", Name = "Huyện Thanh Oai" },
                new District() { Id = new Guid("A1F6EFFE-C174-4FC0-AD02-32B32CA51A20"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "279", Name = "Huyện Thường Tín" },
                new District() { Id = new Guid("7A19295E-DDFC-4AAA-BEE3-EDB7C6AEDDF6"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "280", Name = "Huyện Phú Xuyên" },
                new District() { Id = new Guid("010BC204-87E6-4E5F-9E82-79F5A0FC4D04"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "281", Name = "Huyện Ứng Hòa" },
                new District() { Id = new Guid("506D29FF-5CBA-4D14-A341-375ED320E229"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), Code = "282", Name = "Huyện Mỹ Đức" },
            };
            builder.HasData(data);
        }
    }
}
