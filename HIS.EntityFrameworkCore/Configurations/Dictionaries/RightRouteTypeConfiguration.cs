using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class RightRouteTypeConfiguration : IEntityTypeConfiguration<RightRouteType>
    {
        public void Configure(EntityTypeBuilder<RightRouteType> builder)
        {
            builder.ToTable("RightRouteTypes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.RightRouteTypeCode).HasMaxLength(50).IsRequired();
            builder.Property(x => x.RightRouteTypeName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasData(
                new RightRouteType() { Id = 1, RightRouteTypeCode = "00", RightRouteTypeName = "", Description = "Không chọn", SortOrder = 1 },
                new RightRouteType() { Id = 2, RightRouteTypeCode = "01", RightRouteTypeName = "Đúng tuyến", Description = "", SortOrder = 2 },
                new RightRouteType() { Id = 3, RightRouteTypeCode = "02", RightRouteTypeName = "Đúng tuyến (giới thiệu)", Description = "", SortOrder = 3 },
                new RightRouteType() { Id = 4, RightRouteTypeCode = "03", RightRouteTypeName = "Đúng tuyến (giấy hẹn)", Description = "", SortOrder = 4 },
                new RightRouteType() { Id = 5, RightRouteTypeCode = "04", RightRouteTypeName = "Đúng tuyến (cấp cứu)", Description = "", SortOrder = 5 },
                new RightRouteType() { Id = 6, RightRouteTypeCode = "05", RightRouteTypeName = "Thông tuyến huyện", Description = "", SortOrder = 6 },
                new RightRouteType() { Id = 7, RightRouteTypeCode = "06", RightRouteTypeName = "Trái tuyến", Description = "", SortOrder = 7 },
                new RightRouteType() { Id = 8, RightRouteTypeCode = "07", RightRouteTypeName = "Trái tuyến (thông tuyến tỉnh)", Description = "", SortOrder = 8 }
                );
        }
    }
}
