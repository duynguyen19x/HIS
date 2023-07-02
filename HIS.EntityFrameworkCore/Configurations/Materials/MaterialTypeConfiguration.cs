using HIS.EntityFrameworkCore.Entities.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations
{
    public class MaterialTypeConfiguration : IEntityTypeConfiguration<SMaterialType>
    {
        public void Configure(EntityTypeBuilder<SMaterialType> builder)
        {
            builder.ToTable("SMaterialTypes");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);
            builder.Property(x => x.Tutorial).HasMaxLength(500);
            builder.Property(x => x.Description).HasMaxLength(500);

            builder.HasOne(t => t.SService).WithMany(pc => pc.SMaterialTypes)
                .HasForeignKey(pc => pc.ServiceId).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.SServiceUnit).WithMany(pc => pc.SMaterialTypes)
                .HasForeignKey(pc => pc.ServiceUnitId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
