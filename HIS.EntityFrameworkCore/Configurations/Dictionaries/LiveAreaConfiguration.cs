using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class LiveAreaConfiguration : IEntityTypeConfiguration<LiveArea>
    {
        public void Configure(EntityTypeBuilder<LiveArea> builder)
        {
            builder.ToTable("DIC_LiveArea");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
            builder.Property(x => x.MohCode).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);
        }
    }
}
