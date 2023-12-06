using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class ChapterIcdConfigurations : IEntityTypeConfiguration<ChapterIcd>
    {
        public void Configure(EntityTypeBuilder<ChapterIcd> builder)
        {
            builder.ToTable("ChapterIcds");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);
        }
    }
}
