using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class CountryConfiguration : IEntityTypeConfiguration<SCountry>
    {
        public void Configure(EntityTypeBuilder<SCountry> builder)
        {
            builder.ToTable("SCountries");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(512).IsRequired();
            builder.Property(x => x.HeInCode).HasMaxLength(50).IsRequired();
        }
    }
}
