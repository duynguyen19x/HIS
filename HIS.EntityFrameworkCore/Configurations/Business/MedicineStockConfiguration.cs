using HIS.EntityFrameworkCore.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class MedicineStockConfiguration : IEntityTypeConfiguration<MedicineStock>
    {
        public void Configure(EntityTypeBuilder<MedicineStock> builder)
        {
            builder.ToTable("MedicineStocks");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.HasOne(e => e.Medicine)
               .WithMany()
               .HasForeignKey(e => e.MedicineId)
               .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Stock)
                .WithMany()
                .HasForeignKey(e => e.StockId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
