using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    internal class ProvinceConfiguration : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.ToTable("Provinces");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.ProvinceCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.ProvinceName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(512);
        }
    }
}
