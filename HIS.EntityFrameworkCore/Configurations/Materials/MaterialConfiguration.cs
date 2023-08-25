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
    public class MaterialConfiguration : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            builder.ToTable("Materials");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);
            builder.Property(x => x.Description).HasMaxLength(500);

            builder.HasOne(t => t.MaterialType).WithMany()
                .HasForeignKey(pc => pc.MaterialTypeId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(t => t.Unit).WithMany()
                .HasForeignKey(pc => pc.UnitId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
