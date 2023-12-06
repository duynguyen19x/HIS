using HIS.EntityFrameworkCore.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class InOutStockItemConfiguration : IEntityTypeConfiguration<InOutStockItem>
    {
        public void Configure(EntityTypeBuilder<InOutStockItem> builder)
        {
            builder.ToTable("InOutStockItems");
            builder.HasKey(x => x.Id);

            builder.HasOne(t => t.InOutStock)
                .WithMany()
                .HasForeignKey(t => t.InOutStockId);

            builder.HasOne(e => e.Item)
               .WithMany()
               .HasForeignKey(e => e.ItemId);

            builder.HasOne(e => e.ItemType)
               .WithMany()
               .HasForeignKey(e => e.ItemTypeId);
        }
    }
}
