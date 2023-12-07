using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DeathCauseConfiguration : IEntityTypeConfiguration<DeathCause>
    {
        public void Configure(EntityTypeBuilder<DeathCause> builder)
        {
            builder.ToTable("DIC_DeathCause");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);

            builder.HasData(
                new DeathCause { Id = new Guid("C0A4D767-7BA9-4006-A0A9-020B6322C2EF"), Code = "DO_BENH", Name = "Do bệnh", SortOrder = 1 },
                new DeathCause { Id = new Guid("4333CA55-4D7C-4BE0-B9A2-2125624F0229"), Code = "DO_TAI_BIEN", Name = "Do tai biến điều trị", SortOrder = 2 },
                new DeathCause { Id = new Guid("4D5B5C50-6BE0-434E-8BAA-A528AF4A58B5"), Code = "KHAC", Name = "Khác", SortOrder = 3 }
                );
        }
    }
}
