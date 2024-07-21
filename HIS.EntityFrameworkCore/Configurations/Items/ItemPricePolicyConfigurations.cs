using HIS.EntityFrameworkCore.Entities.Categories.Items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Items
{
    public class ItemPricePolicyConfigurations : IEntityTypeConfiguration<ItemPricePolicy>
    {
        public void Configure(EntityTypeBuilder<ItemPricePolicy> builder)
        {
            builder.ToTable("SItemPricePolicy");
            builder.HasKey(x => x.Id);

            builder.HasOne(t => t.PatientTypeFK).WithMany().HasForeignKey(pc => pc.PatientTypeId);

            builder.HasOne(t => t.ItemFK)
                .WithMany()
                .HasForeignKey(pc => pc.ItemId);
        }
    }
}
