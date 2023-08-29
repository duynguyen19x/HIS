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
    public class MedicineTypeConfiguration : IEntityTypeConfiguration<MedicineType>
    {
        public void Configure(EntityTypeBuilder<MedicineType> builder)
        {
            builder.ToTable("MedicineTypes");

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
            builder.Property(x => x.RegistrationNumber).HasMaxLength(512);
            builder.Property(x => x.ProprietaryDrug).HasMaxLength(512);
            builder.Property(x => x.PackagingSpecifications).HasMaxLength(512);
            builder.Property(x => x.Origin).HasMaxLength(512);
            builder.Property(x => x.ScientificName).HasMaxLength(512);
            builder.Property(x => x.ScientificNameChildren).HasMaxLength(512);
            builder.Property(x => x.DugStatus).HasMaxLength(512);
            builder.Property(x => x.RequirementUseDug).HasMaxLength(512);
            builder.Property(x => x.PharmaceuticalDivision).HasMaxLength(512);
            builder.Property(x => x.ProcessingLossRate).HasMaxLength(512);
            builder.Property(x => x.PreparationMethod).HasMaxLength(512);
            builder.Property(x => x.QualityStandards).HasMaxLength(512);
            builder.Property(x => x.PharmaceuticalFormulation).HasMaxLength(512);

            builder.HasOne(t => t.MedicineGroup).WithMany()
                .HasForeignKey(pc => pc.MedicineGroupId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(t => t.Unit).WithMany()
                .HasForeignKey(pc => pc.UnitId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(t => t.MedicineLine).WithMany()
                .HasForeignKey(pc => pc.MedicineLineId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(t => t.Country).WithMany()
                .HasForeignKey(pc => pc.CountryId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
