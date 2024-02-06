using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DistrictConfiguration : IEntityTypeConfiguration<DIDistrict>
    {
        public void Configure(EntityTypeBuilder<DIDistrict> builder)
        {
            builder.ToTable("DIC_District");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(512).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasOne(t => t.ProvinceFk).WithMany().HasForeignKey(pc => pc.ProvinceId);
        }
    }
}
