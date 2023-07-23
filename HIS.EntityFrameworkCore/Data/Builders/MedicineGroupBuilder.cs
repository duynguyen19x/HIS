using HIS.EntityFrameworkCore.Entities.Categories;
using Microsoft.EntityFrameworkCore;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public class MedicineGroupBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SMedicineGroup>().HasData(
                new SMedicineGroup()
                {
                    Id = new Guid("2FD41F93-DDB9-47DD-9833-4507CE71128C"),
                    Code = "TH-TD",
                    Name = "Thuốc tân dược",
                    IsSystem = true,
                    SortOrder = 1
                },
                new SMedicineGroup()
                {
                    Id = new Guid("FF9BE71E-A958-4244-9DF1-1582229C67D5"),
                    Code = "TH-NG",
                    Name = "Thuốc gây nghiện",
                    IsSystem = true,
                    SortOrder = 2
                },
                new SMedicineGroup()
                {
                    Id = new Guid("914CA65D-6579-4590-B963-FEE8A743BAE1"),
                    Code = "TH-HT",
                    Name = "Thuốc hướng thần",
                    IsSystem = true,
                    SortOrder = 3
                },
                new SMedicineGroup()
                {
                    Id = new Guid("00BE783E-D679-4F1C-9AE2-A4F4C79DE0EF"),
                    Code = "TH-DY",
                    Name = "Thuốc đông y",
                    IsSystem = true,
                    SortOrder = 4
                },
                new SMedicineGroup()
                {
                    Id = new Guid("C987B9D2-E599-49CC-99F3-D075D27CEE7C"),
                    Code = "TH-DT",
                    Name = "Dịch truyền",
                    IsSystem = true,
                    SortOrder = 5
                },
                new SMedicineGroup()
                {
                    Id = new Guid("35DF3868-8DB6-440D-809F-F4C345D804A7"),
                    Code = "TH-MA",
                    Name = "Máu và chế phẩm máu",
                    IsSystem = true,
                    SortOrder = 6
                });

        }
    }
}
