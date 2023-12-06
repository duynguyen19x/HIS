using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.ToTable("Genders");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.GenderCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.GenderName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);
        }
    }
}
