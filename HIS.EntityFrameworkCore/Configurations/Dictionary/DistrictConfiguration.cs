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
                new District() { Id = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "001", DistrictName = "Quận Ba Đình" },
                new District() { Id = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "002", DistrictName = "Quận Hoàn Kiếm" },
                new District() { Id = new Guid("F3A6BCBB-8F93-49DA-85E7-E9B07ED72986"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "003", DistrictName = "Quận Tây Hồ" },
                new District() { Id = new Guid("F3A6BCBB-8F93-49DA-85E7-E9B07ED72987"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "004", DistrictName = "Quận Long Biên" },
                new District() { Id = new Guid("F3A6BCBB-8F93-49DA-85E7-E9B07ED72988"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "005", DistrictName = "Quận Cầu Giấy" },
                new District() { Id = new Guid("F3A6BCBB-8F93-49DA-85E7-E9B07ED72989"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "006", DistrictName = "Quận Đống Đa" },
                new District() { Id = new Guid("F3A6BCBB-8F93-49DA-85E7-E9B07ED72980"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "007", DistrictName = "Quận Hai Bà Trưng" },
                new District() { Id = new Guid("C68ED451-7361-48A9-9F1E-9AD4C1B1BB58"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "008", DistrictName = "Quận Hoàng Mai" },
                new District() { Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D501"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "009", DistrictName = "Quận Thanh Xuân" },
                new District() { Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D502"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "016", DistrictName = "Huyện Sóc Sơn" },
                new District() { Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D503"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "017", DistrictName = "Huyện Đông Anh" },
                new District() { Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D504"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "018", DistrictName = "Huyện Gia Lâm" },
                new District() { Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D505"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "019", DistrictName = "Quận Nam Từ Liêm" },
                new District() { Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D506"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "020", DistrictName = "Huyện Thanh Trì" },
                new District() { Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D507"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "021", DistrictName = "Quận Bắc Từ Liêm" },
                new District() { Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D508"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "250", DistrictName = "Huyện Mê Linh" },
                new District() { Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D509"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "268", DistrictName = "Quận Hà Đông" },
                new District() { Id = new Guid("EF1439E7-3DFA-40D3-A8DE-A0DA87140B45"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "269", DistrictName = "Thị xã Sơn Tây" },
                new District() { Id = new Guid("EF1439E7-3DFA-40D3-A8DE-A0DA87140B46"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "271", DistrictName = "Huyện Ba Vì" },
                new District() { Id = new Guid("EF1439E7-3DFA-40D3-A8DE-A0DA87140B47"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "272", DistrictName = "Huyện Phúc Thọ" },
                new District() { Id = new Guid("EF1439E7-3DFA-40D3-A8DE-A0DA87140B48"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "273", DistrictName = "Huyện Đan Phượng" },
                new District() { Id = new Guid("ECDEB90D-8BC9-43EE-A233-D1FDC543B11B"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "274", DistrictName = "Huyện Hoài Đức" },
                new District() { Id = new Guid("12518EF2-BC95-4A4D-8991-727782426BA8"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "275", DistrictName = "Huyện Quốc Oai" },
                new District() { Id = new Guid("5CF104DF-C5E5-43BF-9AAD-89EB8236092B"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "276", DistrictName = "Huyện Thạch Thất" },
                new District() { Id = new Guid("9F693F27-FE31-435B-BE4E-0BB17DBAF8B7"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "277", DistrictName = "Huyện Chương Mỹ" },
                new District() { Id = new Guid("4D28238A-1D66-4DCA-AE09-5104B16C5EEF"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "278", DistrictName = "Huyện Thanh Oai" },
                new District() { Id = new Guid("A1F6EFFE-C174-4FC0-AD02-32B32CA51A20"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "279", DistrictName = "Huyện Thường Tín" },
                new District() { Id = new Guid("7A19295E-DDFC-4AAA-BEE3-EDB7C6AEDDF6"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "280", DistrictName = "Huyện Phú Xuyên" },
                new District() { Id = new Guid("010BC204-87E6-4E5F-9E82-79F5A0FC4D04"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "281", DistrictName = "Huyện Ứng Hòa" },
                new District() { Id = new Guid("506D29FF-5CBA-4D14-A341-375ED320E229"), ProvinceID = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "282", DistrictName = "Huyện Mỹ Đức" },
            };
            builder.HasData(data);
        }
    }
}
