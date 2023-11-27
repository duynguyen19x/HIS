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
    public class BirthCertBookConfiguration : IEntityTypeConfiguration<BirthCertBook>
    {
        public void Configure(EntityTypeBuilder<BirthCertBook> builder)
        {
            builder.ToTable("BirthCertBook");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.BirthCertBookCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.BirthCertBookName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Total).IsRequired();
            builder.Property(x => x.StartNumOrder).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);
        }
    }
}
