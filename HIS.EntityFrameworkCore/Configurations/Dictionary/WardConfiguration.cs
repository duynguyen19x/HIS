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
                new Ward() { DistrictID = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("56C401AC-D00E-4BDF-AE5A-D2FF12B6A51D"), WardCode = "00001", WardName = "Phường Phúc Xá", SearchCode = "HNBDPX" },
                new Ward() { DistrictID = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("56C401AC-D00E-4BDF-AE5A-D2FF12B6A52D"), WardCode = "00004", WardName = "Phường Trúc Bạch", SearchCode = "HNBDTB" },
                new Ward() { DistrictID = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("56C401AC-D00E-4BDF-AE5A-D2FF12B6A53D"), WardCode = "00006", WardName = "Phường Vĩnh Phúc", SearchCode = "HNBDVP" },
                new Ward() { DistrictID = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("56C401AC-D00E-4BDF-AE5A-D2FF12B6A54D"), WardCode = "00007", WardName = "Phường Cống Vị", SearchCode = "HNBDCV" },
                new Ward() { DistrictID = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("56C401AC-D00E-4BDF-AE5A-D2FF12B6A55D"), WardCode = "00008", WardName = "Phường Liễu Giai", SearchCode = "HNBDLG" },
                new Ward() { DistrictID = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("56C401AC-D00E-4BDF-AE5A-D2FF12B6A56D"), WardCode = "00010", WardName = "Phường Nguyễn Trung Trực", SearchCode = "HNBDNTT" },
                new Ward() { DistrictID = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("56C401AC-D00E-4BDF-AE5A-D2FF12B6A57D"), WardCode = "00013", WardName = "Phường Quán Thánh", SearchCode = "HNBDQT" },
                new Ward() { DistrictID = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("56C401AC-D00E-4BDF-AE5A-D2FF12B6A58D"), WardCode = "00016", WardName = "Phường Ngọc Hà", SearchCode = "HNBDNH" },
                new Ward() { DistrictID = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("C95D5E0E-7244-4F7F-BC1B-640EBA36C54E"), WardCode = "00019", WardName = "Phường Điện Biên", SearchCode = "HNBDDB" },
                new Ward() { DistrictID = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("D77C97D4-1E36-4C41-BD8F-F8E6209AEB0C"), WardCode = "00022", WardName = "Phường Đội Cấn", SearchCode = "HNBDDC" },
                new Ward() { DistrictID = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("E6B212D7-D687-4D63-82A5-18920238DA18"), WardCode = "00025", WardName = "Phường Ngọc Khánh", SearchCode = "HNBDNK" },
                new Ward() { DistrictID = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("F44ABB45-6010-4B0E-A442-5DAFBEB4F40C"), WardCode = "00028", WardName = "Phường Kim Mã", SearchCode = "HNBDKM" },
                new Ward() { DistrictID = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("910FA544-1584-4DFC-B450-4D230F0847A9"), WardCode = "00031", WardName = "Phường Giảng Võ", SearchCode = "HNBDGV" },
                new Ward() { DistrictID = new Guid("FDBACAB7-CA1B-4765-B95D-84FAC353A648"), Id = new Guid("D0A93335-CD08-46E6-8CEF-8DE70D076ED0"), WardCode = "00034", WardName = "Phường Thành Công", SearchCode = "HNBDTC" },

                new Ward() { DistrictID = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("8B10A136-54E8-464B-B6A8-3FB6028BEE0E"), WardCode = "00037", WardName = "Phường Phúc Tân", SearchCode = "HNHKPT" },
                new Ward() { DistrictID = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("4DD47DFB-9CA8-4AE6-B958-13EDF873DC28"), WardCode = "00040", WardName = "Phường Đồng Xuân", SearchCode = "HNHKDX" },
                new Ward() { DistrictID = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("8A736B6F-0697-4486-9516-E30CC5C56B98"), WardCode = "00043", WardName = "Phường Hàng Mã", SearchCode = "HNHKHM" },
                new Ward() { DistrictID = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("18F45F82-55C4-4809-97CF-65F779B926D1"), WardCode = "00046", WardName = "Phường Hàng Buồm", SearchCode = "HNHKHB" },
                new Ward() { DistrictID = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("18F45F82-55C4-4809-97CF-65F779B926D2"), WardCode = "00049", WardName = "Phường Hàng Đào", SearchCode = "HNHKHD" },
                new Ward() { DistrictID = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("18F45F82-55C4-4809-97CF-65F779B926D3"), WardCode = "00052", WardName = "Phường Hàng Bồ", SearchCode = "HNHKHB" },
                new Ward() { DistrictID = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("18F45F82-55C4-4809-97CF-65F779B926D4"), WardCode = "00055", WardName = "Phường Cửa Đông", SearchCode = "HNHKCD" },
                new Ward() { DistrictID = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("18F45F82-55C4-4809-97CF-65F779B926D5"), WardCode = "00058", WardName = "Phường Lý Thái Tổ", SearchCode = "HNHKLTT" },
                new Ward() { DistrictID = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("622FF091-9851-46E8-9716-C355C21D4369"), WardCode = "00061", WardName = "Phường Hàng Bạc", SearchCode = "HNHKHB" },
                new Ward() { DistrictID = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("7D55B7A9-B5EF-46E4-9A58-9B31E77108D8"), WardCode = "00064", WardName = "Phường Hàng Gai", SearchCode = "HNHKHG" },
                new Ward() { DistrictID = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("B15D7C09-6930-43CE-BB4B-347740ED7096"), WardCode = "00067", WardName = "Phường Chương Dương", SearchCode = "HNHKCG" },
                new Ward() { DistrictID = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("8D55EB0D-5C0A-40D1-9684-409868C6F393"), WardCode = "00070", WardName = "Phường Hàng Trống", SearchCode = "HNHKHT" },
                new Ward() { DistrictID = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("94BA5688-CF4D-454A-ACC1-8FEE10552375"), WardCode = "00073", WardName = "Phường Cửa Nam", SearchCode = "HNHKCN" },
                new Ward() { DistrictID = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("26CD9859-9E70-4A42-9979-B7D9027C96FD"), WardCode = "00076", WardName = "Phường Hàng Bông", SearchCode = "HNHKHB" },
                new Ward() { DistrictID = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("1594388C-53A1-4D34-81AB-40AF3225936F"), WardCode = "00079", WardName = "Phường Tràng Tiền", SearchCode = "HNHKTT" },
                new Ward() { DistrictID = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("803D0BC0-278B-42E1-B1BC-623E09920F17"), WardCode = "00082", WardName = "Phường Trần Hưng Đạo", SearchCode = "HNHKTHD" },
                new Ward() { DistrictID = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("EB2E1424-B66C-41AE-9C5C-57757EB1224B"), WardCode = "00085", WardName = "Phường Phan Chu Trinh", SearchCode = "HNHKPCT" },
                new Ward() { DistrictID = new Guid("33A82EA4-7AEB-4D08-9CA9-2CB5F06ADEFB"), Id = new Guid("8DBD4EDD-06CE-40A6-A791-16CF3922523A"), WardCode = "00088", WardName = "Phường Hàng Bài", SearchCode = "HNHKHB" },

            };
            builder.HasData(data);
        }
    }
}
