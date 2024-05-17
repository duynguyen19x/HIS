using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DeathCauseConfiguration : IEntityTypeConfiguration<DeathCause>
    {
        public void Configure(EntityTypeBuilder<DeathCause> builder)
        {
            builder.HasData(
                new DeathCause { Id = new Guid("C0A4D767-7BA9-4006-A0A9-020B6322C2EF"), Code = "01", Name = "Do bệnh", SortOrder = 1 },
                new DeathCause { Id = new Guid("4333CA55-4D7C-4BE0-B9A2-2125624F0229"), Code = "02", Name = "Do tai biến điều trị", SortOrder = 2 },
                new DeathCause { Id = new Guid("4D5B5C50-6BE0-434E-8BAA-A528AF4A58B5"), Code = "09", Name = "Khác", SortOrder = 9 }
                );
        }
    }
}
