using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DeathWithinConfiguration : IEntityTypeConfiguration<DeathWithin>
    {
        public void Configure(EntityTypeBuilder<DeathWithin> builder)
        {
            builder.HasData(
                new DeathWithin() { Id = new Guid("66C3A43B-F9D0-4876-81E2-B13C5F188589"), Code = "24H", Name = "Trong 24h vào", SortOrder = 1, CreatedDate = new DateTime(2024, 1, 1) },
                new DeathWithin() { Id = new Guid("F91D8342-619C-435B-B51C-8B3D7F541222"), Code = "48H", Name = "Trong 48h vào", SortOrder = 2, CreatedDate = new DateTime(2024, 1, 1) },
                new DeathWithin() { Id = new Guid("7693D6EC-CF0F-44C1-A9D7-FB997335AE10"), Code = "72H", Name = "Trong 72h vào", SortOrder = 3, CreatedDate = new DateTime(2024, 1, 1) },
                new DeathWithin() { Id = new Guid("8F2B1EEB-A4BD-4F84-B59C-98145C58B1AB"), Code = "OTH", Name = "Khác", SortOrder = 9, CreatedDate = new DateTime(2024, 1, 1) }
                );
        }
    }
}
