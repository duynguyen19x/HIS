using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DistrictConfiguration : IEntityTypeConfiguration<SDistrict>
    {
        public void Configure(EntityTypeBuilder<SDistrict> builder)
        {
            builder.ToTable("SDistricts");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(512).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasOne(t => t.Province).WithMany(pc => pc.Districts).HasForeignKey(pc => pc.ProvinceId).IsRequired();
        }
    }
}
