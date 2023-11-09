using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    internal class ProvinceConfiguration : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.ToTable("Province");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(512).IsRequired();

            builder.HasOne(t => t.Country).WithMany().HasForeignKey(pc => pc.CountryId);
        }
    }
}
