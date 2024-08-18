using HIS.EntityFrameworkCore.Entities.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HIS.EntityFrameworkCore.Configurations
{
    public class ItemGroupConfiguration : IEntityTypeConfiguration<ItemGroup>
    {
        public void Configure(EntityTypeBuilder<ItemGroup> builder)
        {
            builder.ToTable("SItemGroup");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);

            builder.HasData(
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("2FD41F93-DDB9-47DD-9833-4507CE71128C"), Code = "TV", Name = "Thuốc viên", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 1 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("FF9BE71E-A958-4244-9DF1-1582229C67D5"), Code = "TU", Name = "Thuốc uống", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 2 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("914CA65D-6579-4590-B963-FEE8A743BAE1"), Code = "DC", Name = "Dịch truyền", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 3 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("00BE783E-D679-4F1C-9AE2-A4F4C79DE0EF"), Code = "TKSV", Name = "Thuốc kháng sinh viên", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 4 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("C987B9D2-E599-49CC-99F3-D075D27CEE7C"), Code = "TDY", Name = "Thuốc đông y", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 5 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("35DF3868-8DB6-440D-809F-F4C345D804A7"), Code = "TS", Name = "Thuốc siro", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 6 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("B5F03233-D733-4349-93DF-DB562B7D4376"), Code = "THD", Name = "Thuốc hỗn dịch", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 6 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("CC48BB40-FBF0-4054-818C-EB49545AAEEA"), Code = "TDN", Name = "Thuốc dùng ngoài", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 7 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("8590AE3D-351C-4438-BFE5-3F69DCF97349"), Code = "TB", Name = "Thuốc bột", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 8 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("DDF105E8-6534-46E4-832B-598DAA84C4D5"), Code = "TGN", Name = "Thuốc gây nghiện", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 9 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("2F5148CB-8ADF-45EC-88EE-F84530CFA164"), Code = "THTT", Name = "Thuốc hướng tâm thần", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 10 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("E482E866-9243-49D8-8676-403377DE353C"), Code = "TKSO", Name = "Thuốc kháng sinh ống", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 11 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("6375B8A1-B6E7-4724-A1B4-8CC3ACC98E43"), Code = "KCVI", Name = "Khoáng chất và Vitamin", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 5 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("31D26CA7-2B5F-4DFD-B961-F3609E6A0B69"), Code = "TCO", Name = "Nhóm thuốc corticoid", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 12 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("CD5D7538-B1D2-448D-B6FF-C139C35F9DC7"), Code = "TGTM", Name = "Thuốc gây tê, mê", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 13 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("AE04ABD7-D012-470D-9B8A-F38D9C5C94A8"), Code = "TG", Name = "Thuốc gói", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 14 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("E47AB5DE-9EA5-4075-8DA5-7AE9F36538E2"), Code = "TUT", Name = "Thuốc ung thư", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 15 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("A28FB46E-E9B9-410E-9C31-D8EBFD22015C"), Code = "TKTT", Name = "Thuốc kê tự túc", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 16 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("EA57A262-6647-4E88-880C-82BC4227E916"), Code = "TNM", Name = "Thuốc nhỏ mắt", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 17 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("3144745C-477C-4CE2-9C33-A38EB2153057"), Code = "SP", Name = "Sinh phẩm", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 18 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("25454CE7-BFF0-4FD5-A47A-069554C1535A"), Code = "VC", Name = "Vaccine", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 19 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("9E144DFF-29F6-47DA-B7ED-B55ABD1A2CD3"), Code = "VTNT", Name = "Vật tư nhà thuốc", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 20 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("05A24915-0BED-4F61-B53D-B5E52482E44C"), Code = "TK", Name = "Thuốc khác", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Medicine, SortOrder = 21 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("C9C64187-BF8C-49F4-8B5B-2A04C9AAFB5B"), Code = "VTYT", Name = "Vật tư y tế", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Material, SortOrder = 22 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("18B82FB4-2BA8-4713-871F-3BA51C031B42"), Code = "VTTH", Name = "Vật tư tiêu hoa", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Material, SortOrder = 23 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("891AD741-F6DC-48EE-BE99-3E678B5E8F6C"), Code = "VTTT", Name = "Vật tư thay thế", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Material, SortOrder = 24 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("58215BD0-FF85-45B4-90BB-4550F7E97838"), Code = "VTHC", Name = "Vật tư hóa chất", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Material, SortOrder = 25 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("2A8C130B-8170-4776-B3BC-51EB9DA01D35"), Code = "VTNV", Name = "Vật tư nẹp vít", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Material, SortOrder = 26 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("077FE8B3-03D1-4C4C-B7BE-5F7FB2015957"), Code = "VTAC", Name = "Vật tư ấn chỉ", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Material, SortOrder = 27 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("A15B74B8-1A38-42DE-B958-A62BBD5D8A02"), Code = "VTTB", Name = "Vật tư thiết bị y tế", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Material, SortOrder = 28 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("D3EE2C41-AC9F-4356-8B76-A9B319929970"), Code = "VTDC", Name = "Vật tư dụng cụ", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Material, SortOrder = 29 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("27988A81-EEAB-41F0-A279-C774259ECDCF"), Code = "VTCC", Name = "Vật tư công cụ - dụng cụ", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Material, SortOrder = 30 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("54EED868-2C02-46B3-ACDF-E064A4DDB893"), Code = "VTXH", Name = "Vật tư xã hội hóa", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Material, SortOrder = 31 },
                new ItemGroup() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("58291959-C2CA-45D6-B68D-EF81568FC163"), Code = "VTXH", Name = "Vật tư khác", IsSystem = true, CommodityType = Utilities.Enums.CommodityTypes.Material, SortOrder = 32 });
        }
    }
}
