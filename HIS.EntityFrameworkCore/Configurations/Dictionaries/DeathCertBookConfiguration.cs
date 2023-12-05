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
    public class DeathCertBookConfiguration : IEntityTypeConfiguration<DeathCertBook>
    {
        public void Configure(EntityTypeBuilder<DeathCertBook> builder)
        {
            builder.ToTable("DeathCertBook");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DeathCertBookCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.DeathCertBookName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Total).IsRequired();
            builder.Property(x => x.StartNumOrder).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);
        }
    }
}
