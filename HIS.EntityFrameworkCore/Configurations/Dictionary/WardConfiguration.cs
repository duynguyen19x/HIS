using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class WardConfiguration : IEntityTypeConfiguration<Ward>
    {
        public void Configure(EntityTypeBuilder<Ward> builder)
        {
            var data = new List<Ward>()
            {
                new Ward() { DistrictId = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("56C401AC-D00E-4BDF-AE5A-D2FF12B6A51D"), Code = "00001", Name = "Phường Phúc Xá", SearchCode = "HNBDPX" },
                new Ward() { DistrictId = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("56C401AC-D00E-4BDF-AE5A-D2FF12B6A52D"), Code = "00004", Name = "Phường Trúc Bạch", SearchCode = "HNBDTB" },
                new Ward() { DistrictId = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("56C401AC-D00E-4BDF-AE5A-D2FF12B6A53D"), Code = "00006", Name = "Phường Vĩnh Phúc", SearchCode = "HNBDVP" },
                new Ward() { DistrictId = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("56C401AC-D00E-4BDF-AE5A-D2FF12B6A54D"), Code = "00007", Name = "Phường Cống Vị", SearchCode = "HNBDCV" },
                new Ward() { DistrictId = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("56C401AC-D00E-4BDF-AE5A-D2FF12B6A55D"), Code = "00008", Name = "Phường Liễu Giai", SearchCode = "HNBDLG" },
                new Ward() { DistrictId = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("56C401AC-D00E-4BDF-AE5A-D2FF12B6A56D"), Code = "00010", Name = "Phường Nguyễn Trung Trực", SearchCode = "HNBDNTT" },
                new Ward() { DistrictId = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("56C401AC-D00E-4BDF-AE5A-D2FF12B6A57D"), Code = "00013", Name = "Phường Quán Thánh", SearchCode = "HNBDQT" },
                new Ward() { DistrictId = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("56C401AC-D00E-4BDF-AE5A-D2FF12B6A58D"), Code = "00016", Name = "Phường Ngọc Hà", SearchCode = "HNBDNH" },
                new Ward() { DistrictId = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("C95D5E0E-7244-4F7F-BC1B-640EBA36C54E"), Code = "00019", Name = "Phường Điện Biên", SearchCode = "HNBDDB" },
                new Ward() { DistrictId = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("D77C97D4-1E36-4C41-BD8F-F8E6209AEB0C"), Code = "00022", Name = "Phường Đội Cấn", SearchCode = "HNBDDC" },
                new Ward() { DistrictId = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("E6B212D7-D687-4D63-82A5-18920238DA18"), Code = "00025", Name = "Phường Ngọc Khánh", SearchCode = "HNBDNK" },
                new Ward() { DistrictId = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("F44ABB45-6010-4B0E-A442-5DAFBEB4F40C"), Code = "00028", Name = "Phường Kim Mã", SearchCode = "HNBDKM" },
                new Ward() { DistrictId = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("910FA544-1584-4DFC-B450-4D230F0847A9"), Code = "00031", Name = "Phường Giảng Võ", SearchCode = "HNBDGV" },
                new Ward() { DistrictId = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("D0A93335-CD08-46E6-8CEF-8DE70D076ED0"), Code = "00034", Name = "Phường Thành Công", SearchCode = "HNBDTC" },

                new Ward() { DistrictId = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("8B10A136-54E8-464B-B6A8-3FB6028BEE0E"), Code = "00037", Name = "Phường Phúc Tân", SearchCode = "HNHKPT" },
                new Ward() { DistrictId = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("4DD47DFB-9CA8-4AE6-B958-13EDF873DC28"), Code = "00040", Name = "Phường Đồng Xuân", SearchCode = "HNHKDX" },
                new Ward() { DistrictId = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("8A736B6F-0697-4486-9516-E30CC5C56B98"), Code = "00043", Name = "Phường Hàng Mã", SearchCode = "HNHKHM" },
                new Ward() { DistrictId = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("18F45F82-55C4-4809-97CF-65F779B926D1"), Code = "00046", Name = "Phường Hàng Buồm", SearchCode = "HNHKHB" },
                new Ward() { DistrictId = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("18F45F82-55C4-4809-97CF-65F779B926D2"), Code = "00049", Name = "Phường Hàng Đào", SearchCode = "HNHKHD" },
                new Ward() { DistrictId = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("18F45F82-55C4-4809-97CF-65F779B926D3"), Code = "00052", Name = "Phường Hàng Bồ", SearchCode = "HNHKHB" },
                new Ward() { DistrictId = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("18F45F82-55C4-4809-97CF-65F779B926D4"), Code = "00055", Name = "Phường Cửa Đông", SearchCode = "HNHKCD" },
                new Ward() { DistrictId = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("18F45F82-55C4-4809-97CF-65F779B926D5"), Code = "00058", Name = "Phường Lý Thái Tổ", SearchCode = "HNHKLTT" },
                new Ward() { DistrictId = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("622FF091-9851-46E8-9716-C355C21D4369"), Code = "00061", Name = "Phường Hàng Bạc", SearchCode = "HNHKHB" },
                new Ward() { DistrictId = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("7D55B7A9-B5EF-46E4-9A58-9B31E77108D8"), Code = "00064", Name = "Phường Hàng Gai", SearchCode = "HNHKHG" },
                new Ward() { DistrictId = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("B15D7C09-6930-43CE-BB4B-347740ED7096"), Code = "00067", Name = "Phường Chương Dương", SearchCode = "HNHKCG" },
                new Ward() { DistrictId = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("8D55EB0D-5C0A-40D1-9684-409868C6F393"), Code = "00070", Name = "Phường Hàng Trống", SearchCode = "HNHKHT" },
                new Ward() { DistrictId = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("94BA5688-CF4D-454A-ACC1-8FEE10552375"), Code = "00073", Name = "Phường Cửa Nam", SearchCode = "HNHKCN" },
                new Ward() { DistrictId = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("26CD9859-9E70-4A42-9979-B7D9027C96FD"), Code = "00076", Name = "Phường Hàng Bông", SearchCode = "HNHKHB" },
                new Ward() { DistrictId = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("1594388C-53A1-4D34-81AB-40AF3225936F"), Code = "00079", Name = "Phường Tràng Tiền", SearchCode = "HNHKTT" },
                new Ward() { DistrictId = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("803D0BC0-278B-42E1-B1BC-623E09920F17"), Code = "00082", Name = "Phường Trần Hưng Đạo", SearchCode = "HNHKTHD" },
                new Ward() { DistrictId = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("EB2E1424-B66C-41AE-9C5C-57757EB1224B"), Code = "00085", Name = "Phường Phan Chu Trinh", SearchCode = "HNHKPCT" },
                new Ward() { DistrictId = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("8DBD4EDD-06CE-40A6-A791-16CF3922523A"), Code = "00088", Name = "Phường Hàng Bài", SearchCode = "HNHKHB" },

            };
            builder.HasData(data);
        }
    }
}
