using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class RightRouteTypeConfiguration : IEntityTypeConfiguration<RightRouteType>
    {
        public void Configure(EntityTypeBuilder<RightRouteType> builder)
        {
            builder.ToTable("DIC_RightRouteType");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.RightRouteTypeCode).HasMaxLength(50).IsRequired();
            builder.Property(x => x.RightRouteTypeName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(512);

            
        }
    }
}
