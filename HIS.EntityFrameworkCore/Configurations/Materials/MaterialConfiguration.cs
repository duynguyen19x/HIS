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
    public class MaterialConfiguration : IEntityTypeConfiguration<SMaterial>
    {
        public void Configure(EntityTypeBuilder<SMaterial> builder)
        {
            builder.ToTable("SMaterials");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);
            builder.Property(x => x.Description).HasMaxLength(500);

            builder.HasOne(t => t.SMaterialType).WithMany(pc => pc.SMaterials)
                .HasForeignKey(pc => pc.MaterialTypeId);

            builder.HasOne(t => t.SServiceUnit).WithMany(pc => pc.SMaterials)
                .HasForeignKey(pc => pc.ServiceUnitId);

            builder.HasOne(t => t.SService).WithMany(pc => pc.SMaterials)
                .HasForeignKey(pc => pc.ServiceId);
        }
    }
}
