using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DeathCertBookConfiguration : IEntityTypeConfiguration<DeathCertBook>
    {
        public void Configure(EntityTypeBuilder<DeathCertBook> builder)
        {
            builder.ToTable("DeathCertBooks");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DeathCertBookCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.DeathCertBookName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Total).IsRequired();
            builder.Property(x => x.StartNumOrder).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);
        }
    }
}
