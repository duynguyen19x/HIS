using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class RoomTypeConfiguration : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            builder.ToTable("RoomTypes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.RoomTypeCode).HasMaxLength(20).IsRequired(); 
            builder.Property(x => x.RoomTypeName).HasMaxLength(255).IsRequired(); 
            builder.Property(x => x.Description).HasMaxLength(512);
        }
    }
}
