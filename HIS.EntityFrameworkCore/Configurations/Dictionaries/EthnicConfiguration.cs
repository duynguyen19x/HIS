using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class EthnicConfiguration : IEntityTypeConfiguration<Ethnic>
    {
        public void Configure(EntityTypeBuilder<Ethnic> builder)
        {
            builder.ToTable("Ethnic");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.EthnicCode).HasMaxLength(20).IsRequired(); 
            builder.Property(x => x.EthnicName).HasMaxLength(128).IsRequired(); 
            builder.Property(x => x.Description).HasMaxLength(255);
        }
    }
}
