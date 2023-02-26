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
    public class MedicineTypeConfiguration : IEntityTypeConfiguration<SMedicineType>
    {
        public void Configure(EntityTypeBuilder<SMedicineType> builder)
        {
            builder.ToTable("SMedicineTypes");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);
            builder.Property(x => x.Tutorial).HasMaxLength(500);
            builder.Property(x => x.Description).HasMaxLength(500);

            builder.HasOne(t => t.SService).WithMany(pc => pc.SMedicineTypes)
                .HasForeignKey(pc => pc.ServiceId);

            builder.HasOne(t => t.SServiceUnit).WithMany(pc => pc.SMedicineTypes)
                .HasForeignKey(pc => pc.ServiceUnitId);

            builder.HasOne(t => t.SMedicineLine).WithMany(pc => pc.SMedicineTypes)
                .HasForeignKey(pc => pc.MedicineLineId);
        }
    }
}
