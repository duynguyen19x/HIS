using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class EthnicConfiguration : IEntityTypeConfiguration<Ethnic>
    {
        public void Configure(EntityTypeBuilder<Ethnic> builder)
        {
            builder.ToTable("Ethnics");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.EthnicCode).HasMaxLength(20).IsRequired(); 
            builder.Property(x => x.EthnicName).HasMaxLength(128).IsRequired(); 
            builder.Property(x => x.Description).HasMaxLength(255);
        }
    }
}
