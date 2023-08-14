using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Business.Pharmaceuticals
{
    public class MedicineStockConfiguration : IEntityTypeConfiguration<DMedicineStock>
    {
        public void Configure(EntityTypeBuilder<DMedicineStock> builder)
        {
            builder.ToTable("DMedicineStocks");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.HasOne(e => e.SMedicine)
               .WithMany()
               .HasForeignKey(e => e.MedicineId)
               .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.SStock)
                .WithMany()
                .HasForeignKey(e => e.StockId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
