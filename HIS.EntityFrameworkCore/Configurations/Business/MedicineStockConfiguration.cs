using HIS.EntityFrameworkCore.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class ItemStockConfiguration : IEntityTypeConfiguration<ItemStock>
    {
        public void Configure(EntityTypeBuilder<ItemStock> builder)
        {
            builder.ToTable("BUS_ItemStock");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.HasOne(e => e.Item)
               .WithMany()
               .HasForeignKey(e => e.ItemId);

            builder.HasOne(e => e.Stock)
                .WithMany()
                .HasForeignKey(e => e.StockId);
        }
    }
}
