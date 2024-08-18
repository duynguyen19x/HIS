using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class RightRouteTypeConfiguration : IEntityTypeConfiguration<RightRouteType>
    {
        public void Configure(EntityTypeBuilder<RightRouteType> builder)
        {
            builder.HasData(new List<RightRouteType>()
            {
                new RightRouteType() { CreatedDate = new DateTime(2024, 1, 1), Id = 1, Code = "01", Name ="Đúng tuyến", SortOrder = 1 },
                new RightRouteType() { CreatedDate = new DateTime(2024, 1, 1), Id = 2, Code = "02", Name ="Đúng tuyến (giới thiệu)", SortOrder = 2 },
                new RightRouteType() { CreatedDate = new DateTime(2024, 1, 1), Id = 3, Code = "03", Name ="Đúng tuyến (giấy hẹn)", SortOrder = 3 },
                new RightRouteType() { CreatedDate = new DateTime(2024, 1, 1), Id = 4, Code = "04", Name ="Đúng tuyến (cấp cứu)", SortOrder = 4 },
                new RightRouteType() { CreatedDate = new DateTime(2024, 1, 1), Id = 5, Code = "05", Name ="Thông tuyến huyện", SortOrder = 5 },
                new RightRouteType() { CreatedDate = new DateTime(2024, 1, 1), Id = 6, Code = "06", Name ="Trái tuyến", SortOrder = 6 },
                new RightRouteType() { CreatedDate = new DateTime(2024, 1, 1), Id = 7, Code = "07", Name ="Trái tuyến (thông tuyến tỉnh)", SortOrder = 7 },
            });
        }
    }
}
