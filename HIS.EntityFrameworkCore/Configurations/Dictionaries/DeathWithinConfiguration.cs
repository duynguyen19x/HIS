using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DeathWithinConfiguration : IEntityTypeConfiguration<DeathWithin>
    {
        public void Configure(EntityTypeBuilder<DeathWithin> builder)
        {
            builder.ToTable("DeathWithin");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.DeathWithinCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.DeathWithinName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);

            builder.HasData(
                new DeathWithin() { Id = new Guid(""), DeathWithinCode = "TRONG_24H", DeathWithinName = "Trong 24h vào", SortOrder = 1 },
                new DeathWithin() { Id = new Guid(""), DeathWithinCode = "TRONG_48H", DeathWithinName = "Trong 48h vào", SortOrder = 2 },
                new DeathWithin() { Id = new Guid(""), DeathWithinCode = "TRONG_72H", DeathWithinName = "Trong 72h vào", SortOrder = 3 },
                new DeathWithin() { Id = new Guid(""), DeathWithinCode = "KHAC", DeathWithinName = "Khác", SortOrder = 4 }
                );
        }
    }
}
