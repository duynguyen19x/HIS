using HIS.EntityFrameworkCore.Entities.Dictionaries;
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
                new RightRouteType() { Id = 1, Code = "01", Name ="Đúng tuyến", SortOrder = 1 },
                new RightRouteType() { Id = 2, Code = "02", Name ="Đúng tuyến (giới thiệu)", SortOrder = 2 },
                new RightRouteType() { Id = 3, Code = "03", Name ="Đúng tuyến (giấy hẹn)", SortOrder = 3 },
                new RightRouteType() { Id = 4, Code = "04", Name ="Đúng tuyến (cấp cứu)", SortOrder = 4 },
                new RightRouteType() { Id = 5, Code = "05", Name ="Thông tuyến huyện", SortOrder = 5 },
                new RightRouteType() { Id = 6, Code = "06", Name ="Trái tuyến", SortOrder = 6 },
                new RightRouteType() { Id = 7, Code = "07", Name ="Trái tuyến (thông tuyến tỉnh)", SortOrder = 7 },
            });
        }
    }
}
