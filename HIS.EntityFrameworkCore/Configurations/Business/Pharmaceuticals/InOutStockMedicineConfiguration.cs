using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Business.Pharmaceuticals
{
    public class InOutStockMedicineConfiguration : IEntityTypeConfiguration<InOutStockMedicine>
    {
        public void Configure(EntityTypeBuilder<InOutStockMedicine> builder)
        {
            builder.ToTable("InOutStockMedicines");
            builder.HasKey(x => x.Id);

            builder.HasOne(t => t.InOutStock)
                .WithMany()
                .HasForeignKey(t => t.InOutStockId);

            builder.HasOne(e => e.Medicine)
               .WithMany()
               .HasForeignKey(e => e.MedicineId);
        }
    }
}
