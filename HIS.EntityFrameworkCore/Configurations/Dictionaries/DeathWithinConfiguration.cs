using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DeathWithinConfiguration : IEntityTypeConfiguration<DeathWithin>
    {
        public void Configure(EntityTypeBuilder<DeathWithin> builder)
        {
            builder.ToTable("DeathWithins");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.DeathWithinCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.DeathWithinName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);

            builder.HasData(
                new DeathWithin() { Id = new Guid("66C3A43B-F9D0-4876-81E2-B13C5F188589"), DeathWithinCode = "TRONG_24H", DeathWithinName = "Trong 24h vào", SortOrder = 1 },
                new DeathWithin() { Id = new Guid("F91D8342-619C-435B-B51C-8B3D7F541222"), DeathWithinCode = "TRONG_48H", DeathWithinName = "Trong 48h vào", SortOrder = 2 },
                new DeathWithin() { Id = new Guid("7693D6EC-CF0F-44C1-A9D7-FB997335AE10"), DeathWithinCode = "TRONG_72H", DeathWithinName = "Trong 72h vào", SortOrder = 3 },
                new DeathWithin() { Id = new Guid("8F2B1EEB-A4BD-4F84-B59C-98145C58B1AB"), DeathWithinCode = "KHAC", DeathWithinName = "Khác", SortOrder = 4 }
                );
        }
    }
}
