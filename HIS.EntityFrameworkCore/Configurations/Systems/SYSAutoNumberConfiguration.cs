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
    public class SYSAutoNumberConfiguration : IEntityTypeConfiguration<SYSAutoNumber>
    {
        public void Configure(EntityTypeBuilder<SYSAutoNumber> builder)
        {
            builder.ToTable("SYSAutoNumber");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Prefix).HasMaxLength(50);
            builder.Property(x => x.Value).HasColumnType("decimal(28, 0)").IsRequired();
            builder.Property(x => x.LengthOfValue).IsRequired();
            builder.Property(x => x.Suffix).HasMaxLength(50);
            builder.Property(x => x.RefTypeCategoryId).IsRequired();

            //builder.HasOne(t => t.RefTypeCategory).WithMany(pc => pc.AutoNumbers).HasForeignKey(pc => pc.RefTypeCategoryId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
