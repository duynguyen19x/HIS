using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class BirthCertBookConfiguration : IEntityTypeConfiguration<BirthCertBook>
    {
        public void Configure(EntityTypeBuilder<BirthCertBook> builder)
        {
            builder.ToTable("DIC_BirthCertBook");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(512).IsRequired();
            builder.Property(x => x.Total).IsRequired();
            builder.Property(x => x.StartNumOrder).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);
        }
    }
}
