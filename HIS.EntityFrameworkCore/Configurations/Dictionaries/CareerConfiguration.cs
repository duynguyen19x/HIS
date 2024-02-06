using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class CareerConfiguration : IEntityTypeConfiguration<DICareer>
    {
        public void Configure(EntityTypeBuilder<DICareer> builder)
        {
            builder.ToTable("DIC_Career");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(512).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(512);
        }
    }
}
