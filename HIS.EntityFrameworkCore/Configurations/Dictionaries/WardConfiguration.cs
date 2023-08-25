using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class WardConfiguration : IEntityTypeConfiguration<SWard>
    {
        public void Configure(EntityTypeBuilder<SWard> builder)
        {
            builder.ToTable("Wards");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(512).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasOne(t => t.District).WithMany(pc => pc.Wards).HasForeignKey(pc => pc.DistrictId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
