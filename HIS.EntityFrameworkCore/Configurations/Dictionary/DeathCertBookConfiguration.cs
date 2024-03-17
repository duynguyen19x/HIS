using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DeathCertBookConfiguration : IEntityTypeConfiguration<DeathCertBook>
    {
        public void Configure(EntityTypeBuilder<DeathCertBook> builder)
        {
            builder.ToTable("DIC_DeathCertBook");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Total).IsRequired();
            builder.Property(x => x.StartNumOrder).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);
        }
    }
}
