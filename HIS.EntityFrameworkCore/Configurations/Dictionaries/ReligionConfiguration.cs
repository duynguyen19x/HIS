using HIS.Core.Enums;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.Core.Extensions;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class ReligionConfiguration : IEntityTypeConfiguration<Religion>
    {
        public void Configure(EntityTypeBuilder<Religion> builder)
        {
            builder.ToTable("Religion");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ReligionCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.ReligionName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);

            
        }
    }
}
