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
    public class MedicineConfiguration : IEntityTypeConfiguration<SMedicine>
    {
        public void Configure(EntityTypeBuilder<SMedicine> builder)
        {
            builder.ToTable("SMedicines");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.HeInCode).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(512);
            builder.Property(x => x.Tutorial).HasMaxLength(512);
            builder.Property(x => x.Description).HasMaxLength(512);
            builder.Property(x => x.ActiveSubstance).HasMaxLength(250);
            builder.Property(x => x.Concentration).HasMaxLength(250);
            builder.Property(x => x.Content).HasMaxLength(250);
            builder.Property(x => x.Manufacturer).HasMaxLength(512);
            builder.Property(x => x.PackagingSpecifications).HasMaxLength(512);
            builder.Property(x => x.Dosage).HasMaxLength(512);
            builder.Property(x => x.Lot).HasMaxLength(128);
            builder.Property(x => x.TenderDecision).HasMaxLength(256);
            builder.Property(x => x.TenderPackage).HasMaxLength(256);
            builder.Property(x => x.TenderGroup).HasMaxLength(256);

            builder.HasOne(t => t.SUnit).WithMany(pc => pc.SMedicines)
                .HasForeignKey(pc => pc.UnitId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(t => t.SMedicineType).WithMany(pc => pc.SMedicines)
                .HasForeignKey(pc => pc.MedicineTypeId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(t => t.SMedicineLine).WithMany(pc => pc.SMedicines)
                .HasForeignKey(pc => pc.MedicineLineId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(t => t.SCountry).WithMany(pc => pc.SMedicines)
                .HasForeignKey(pc => pc.CountryId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
