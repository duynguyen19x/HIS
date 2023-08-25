using HIS.EntityFrameworkCore.Entities.Categories;
using Microsoft.EntityFrameworkCore;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public class MedicineGroupBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedicineGroup>().HasData(
                new MedicineGroup()
                {
                    Id = new Guid("2FD41F93-DDB9-47DD-9833-4507CE71128C"),
                    Code = "TV",
                    Name = "Thuốc viên",
                    IsSystem = true,
                    SortOrder = 1
                },
                new MedicineGroup()
                {
                    Id = new Guid("FF9BE71E-A958-4244-9DF1-1582229C67D5"),
                    Code = "TU",
                    Name = "Thuốc uống",
                    IsSystem = true,
                    SortOrder = 2
                },
                new MedicineGroup()
                {
                    Id = new Guid("914CA65D-6579-4590-B963-FEE8A743BAE1"),
                    Code = "DC",
                    Name = "Dịch truyền",
                    IsSystem = true,
                    SortOrder = 3
                },
                new MedicineGroup()
                {
                    Id = new Guid("00BE783E-D679-4F1C-9AE2-A4F4C79DE0EF"),
                    Code = "TKSV",
                    Name = "Thuốc kháng sinh viên",
                    IsSystem = true,
                    SortOrder = 4
                },
                new MedicineGroup()
                {
                    Id = new Guid("C987B9D2-E599-49CC-99F3-D075D27CEE7C"),
                    Code = "TDY",
                    Name = "Thuốc đông y",
                    IsSystem = true,
                    SortOrder = 5
                },
                new MedicineGroup()
                {
                    Id = new Guid("35DF3868-8DB6-440D-809F-F4C345D804A7"),
                    Code = "TS",
                    Name = "Thuốc siro",
                    IsSystem = true,
                    SortOrder = 6
                },
                new MedicineGroup()
                {
                    Id = new Guid("B5F03233-D733-4349-93DF-DB562B7D4376"),
                    Code = "THD",
                    Name = "Thuốc hỗn dịch",
                    IsSystem = true,
                    SortOrder = 6
                },
                new MedicineGroup()
                {
                    Id = new Guid("CC48BB40-FBF0-4054-818C-EB49545AAEEA"),
                    Code = "TDN",
                    Name = "Thuốc dùng ngoài",
                    IsSystem = true,
                    SortOrder = 7
                },
                new MedicineGroup()
                {
                    Id = new Guid("8590AE3D-351C-4438-BFE5-3F69DCF97349"),
                    Code = "TB",
                    Name = "Thuốc bột",
                    IsSystem = true,
                    SortOrder = 8
                },
                new MedicineGroup()
                {
                    Id = new Guid("DDF105E8-6534-46E4-832B-598DAA84C4D5"),
                    Code = "TGN",
                    Name = "Thuốc gây nghiện",
                    IsSystem = true,
                    SortOrder = 9
                },
                new MedicineGroup()
                {
                    Id = new Guid("2F5148CB-8ADF-45EC-88EE-F84530CFA164"),
                    Code = "THTT",
                    Name = "Thuốc hướng tâm thần",
                    IsSystem = true,
                    SortOrder = 10
                },
                new MedicineGroup()
                {
                    Id = new Guid("E482E866-9243-49D8-8676-403377DE353C"),
                    Code = "TKSO",
                    Name = "Thuốc kháng sinh ống",
                    IsSystem = true,
                    SortOrder = 11
                },
                new MedicineGroup()
                {
                    Id = new Guid("6375B8A1-B6E7-4724-A1B4-8CC3ACC98E43"),
                    Code = "KCVI",
                    Name = "Khoáng chất và Vitamin",
                    IsSystem = true,
                    SortOrder = 5
                },
                new MedicineGroup()
                {
                    Id = new Guid("31D26CA7-2B5F-4DFD-B961-F3609E6A0B69"),
                    Code = "TCO",
                    Name = "Nhóm thuốc corticoid",
                    IsSystem = true,
                    SortOrder = 12
                },
                new MedicineGroup()
                {
                    Id = new Guid("CD5D7538-B1D2-448D-B6FF-C139C35F9DC7"),
                    Code = "TGTM",
                    Name = "Thuốc gây tê, mê",
                    IsSystem = true,
                    SortOrder = 13
                },
                new MedicineGroup()
                {
                    Id = new Guid("AE04ABD7-D012-470D-9B8A-F38D9C5C94A8"),
                    Code = "TG",
                    Name = "Thuốc gói",
                    IsSystem = true,
                    SortOrder = 14
                },
                new MedicineGroup()
                {
                    Id = new Guid("E47AB5DE-9EA5-4075-8DA5-7AE9F36538E2"),
                    Code = "TUT",
                    Name = "Thuốc ung thư",
                    IsSystem = true,
                    SortOrder = 15
                },
                new MedicineGroup()
                {
                    Id = new Guid("A28FB46E-E9B9-410E-9C31-D8EBFD22015C"),
                    Code = "TKTT",
                    Name = "Thuốc kê tự túc",
                    IsSystem = true,
                    SortOrder = 16
                },
                new MedicineGroup()
                {
                    Id = new Guid("EA57A262-6647-4E88-880C-82BC4227E916"),
                    Code = "TNM",
                    Name = "Thuốc nhỏ mắt",
                    IsSystem = true,
                    SortOrder = 17
                },
                new MedicineGroup()
                {
                    Id = new Guid("3144745C-477C-4CE2-9C33-A38EB2153057"),
                    Code = "SP",
                    Name = "Sinh phẩm",
                    IsSystem = true,
                    SortOrder = 18
                },
                new MedicineGroup()
                {
                    Id = new Guid("25454CE7-BFF0-4FD5-A47A-069554C1535A"),
                    Code = "VC",
                    Name = "Vaccine",
                    IsSystem = true,
                    SortOrder = 19
                },
                new MedicineGroup()
                {
                    Id = new Guid("9E144DFF-29F6-47DA-B7ED-B55ABD1A2CD3"),
                    Code = "VTNT",
                    Name = "Vật tư nhà thuốc",
                    IsSystem = true,
                    SortOrder = 20
                },
                new MedicineGroup()
                {
                    Id = new Guid("05A24915-0BED-4F61-B53D-B5E52482E44C"),
                    Code = "TK",
                    Name = "Thuốc khác",
                    IsSystem = true,
                    SortOrder = 21
                });

        }
    }
}
