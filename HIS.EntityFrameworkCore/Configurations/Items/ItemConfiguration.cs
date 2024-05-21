using HIS.EntityFrameworkCore.Entities.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("SItem");

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

            builder.HasOne(t => t.Unit).WithMany()
                .HasForeignKey(pc => pc.UnitId);

            builder.HasOne(t => t.ItemType).WithMany()
                .HasForeignKey(pc => pc.ItemTypeId);

            builder.HasOne(t => t.ItemLine).WithMany()
                .HasForeignKey(pc => pc.ItemLineId);

            builder.HasOne(t => t.Country).WithMany()
                .HasForeignKey(pc => pc.CountryId);
        }
    }
}
