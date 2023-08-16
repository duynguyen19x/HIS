using HIS.EntityFrameworkCore.Entities.Systems;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Systems
{
    public class SYSRefTypeCategoryConfiguration : IEntityTypeConfiguration<SYSRefTypeCategory>
    {
        public void Configure(EntityTypeBuilder<SYSRefTypeCategory> builder)
        {
            builder.ToTable("SYSRefTypeCategory");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);
        }
    }
}
