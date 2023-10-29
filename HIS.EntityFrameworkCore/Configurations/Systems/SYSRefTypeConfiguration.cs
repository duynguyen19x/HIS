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
    public class SYSRefTypeConfiguration : IEntityTypeConfiguration<SYSRefType>
    {
        public void Configure(EntityTypeBuilder<SYSRefType> builder)
        {
            builder.ToTable("SYSRefType");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);
            builder.Property(x => x.RefTypeCategoryId).IsRequired();

            //builder.HasOne(t => t.RefTypeCategory).WithMany(pc => pc.RefTypes).HasForeignKey(pc => pc.RefTypeCategoryId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
