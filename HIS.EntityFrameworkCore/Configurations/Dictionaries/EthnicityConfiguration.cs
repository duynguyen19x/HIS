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
    public class EthnicityConfiguration : IEntityTypeConfiguration<Ethnicity>
    {
        public void Configure(EntityTypeBuilder<Ethnicity> builder)
        {
            builder.ToTable("Ethnicity");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.EthnicityCode).HasMaxLength(20).IsRequired(); 
            builder.Property(x => x.EthnicityName).HasMaxLength(128).IsRequired(); 
            builder.Property(x => x.Description).HasMaxLength(255);
        }
    }
}
