using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class WardConfiguration : IEntityTypeConfiguration<DIWard>
    {
        public void Configure(EntityTypeBuilder<DIWard> builder)
        {
            builder.ToTable("DIC_Ward");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
            builder.Property(x => x.SearchText).HasMaxLength(20);
            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasOne(x=>x.DistrictFk).WithMany().HasForeignKey(pc => pc.DistrictId);
        }
    }
}
