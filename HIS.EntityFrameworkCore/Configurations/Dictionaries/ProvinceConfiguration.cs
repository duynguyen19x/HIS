using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    internal class ProvinceConfiguration : IEntityTypeConfiguration<SProvince>
    {
        public void Configure(EntityTypeBuilder<SProvince> builder)
        {
            builder.ToTable("SProvinces");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(512).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasOne(t => t.Country).WithMany(pc => pc.Provinces).HasForeignKey(pc => pc.CountryId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
