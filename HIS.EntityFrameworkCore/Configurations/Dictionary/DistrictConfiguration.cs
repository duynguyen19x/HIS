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
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "001", DistrictName = "Quận Ba Đình" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "002", DistrictName = "Quận Hoàn Kiếm" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("F3A6BCBB-8F93-49DA-85E7-E9B07ED72986"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "003", DistrictName = "Quận Tây Hồ" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("F3A6BCBB-8F93-49DA-85E7-E9B07ED72987"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "004", DistrictName = "Quận Long Biên" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("F3A6BCBB-8F93-49DA-85E7-E9B07ED72988"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "005", DistrictName = "Quận Cầu Giấy" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("F3A6BCBB-8F93-49DA-85E7-E9B07ED72989"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "006", DistrictName = "Quận Đống Đa" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("F3A6BCBB-8F93-49DA-85E7-E9B07ED72980"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "007", DistrictName = "Quận Hai Bà Trưng" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("C68ED451-7361-48A9-9F1E-9AD4C1B1BB58"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "008", DistrictName = "Quận Hoàng Mai" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D501"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "009", DistrictName = "Quận Thanh Xuân" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D502"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "016", DistrictName = "Huyện Sóc Sơn" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D503"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "017", DistrictName = "Huyện Đông Anh" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D504"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "018", DistrictName = "Huyện Gia Lâm" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D505"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "019", DistrictName = "Quận Nam Từ Liêm" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D506"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "020", DistrictName = "Huyện Thanh Trì" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D507"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "021", DistrictName = "Quận Bắc Từ Liêm" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D508"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "250", DistrictName = "Huyện Mê Linh" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("5B59E188-C5C7-4BEB-A7F1-03293B14D509"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "268", DistrictName = "Quận Hà Đông" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("EF1439E7-3DFA-40D3-A8DE-A0DA87140B45"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "269", DistrictName = "Thị xã Sơn Tây" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("EF1439E7-3DFA-40D3-A8DE-A0DA87140B46"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "271", DistrictName = "Huyện Ba Vì" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("EF1439E7-3DFA-40D3-A8DE-A0DA87140B47"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "272", DistrictName = "Huyện Phúc Thọ" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("EF1439E7-3DFA-40D3-A8DE-A0DA87140B48"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "273", DistrictName = "Huyện Đan Phượng" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("ECDEB90D-8BC9-43EE-A233-D1FDC543B11B"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "274", DistrictName = "Huyện Hoài Đức" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("12518EF2-BC95-4A4D-8991-727782426BA8"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "275", DistrictName = "Huyện Quốc Oai" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("5CF104DF-C5E5-43BF-9AAD-89EB8236092B"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "276", DistrictName = "Huyện Thạch Thất" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("9F693F27-FE31-435B-BE4E-0BB17DBAF8B7"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "277", DistrictName = "Huyện Chương Mỹ" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("4D28238A-1D66-4DCA-AE09-5104B16C5EEF"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "278", DistrictName = "Huyện Thanh Oai" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("A1F6EFFE-C174-4FC0-AD02-32B32CA51A20"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "279", DistrictName = "Huyện Thường Tín" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("7A19295E-DDFC-4AAA-BEE3-EDB7C6AEDDF6"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "280", DistrictName = "Huyện Phú Xuyên" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("010BC204-87E6-4E5F-9E82-79F5A0FC4D04"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "281", DistrictName = "Huyện Ứng Hòa" },
                new District() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("506D29FF-5CBA-4D14-A341-375ED320E229"), ProvinceId = new Guid("889693ED-0453-4387-941B-D70DD4870DC5"), DistrictCode = "282", DistrictName = "Huyện Mỹ Đức" },
            };
            builder.HasData(data);
        }
    }
}
