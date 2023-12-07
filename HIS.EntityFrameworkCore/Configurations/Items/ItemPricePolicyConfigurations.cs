using HIS.EntityFrameworkCore.Entities.Categories.Items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Items
{
    public class ItemPricePolicyConfigurations : IEntityTypeConfiguration<ItemPricePolicy>
    {
        public void Configure(EntityTypeBuilder<ItemPricePolicy> builder)
        {
            builder.ToTable("DIC_ItemPricePolicy");
            builder.HasKey(x => x.Id);

            builder.HasOne(t => t.PatientType).WithMany().HasForeignKey(pc => pc.PatientTypeId);

            builder.HasOne(t => t.Item)
                .WithMany()
                .HasForeignKey(pc => pc.ItemId);
        }
    }
}
