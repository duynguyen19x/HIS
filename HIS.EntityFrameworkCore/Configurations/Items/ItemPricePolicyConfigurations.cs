using HIS.EntityFrameworkCore.Entities.Categories.Services;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.EntityFrameworkCore.Entities.Categories.Items;

namespace HIS.EntityFrameworkCore.Configurations.Items
{
    public class ItemPricePolicyConfigurations : IEntityTypeConfiguration<ItemPricePolicy>
    {
        public void Configure(EntityTypeBuilder<ItemPricePolicy> builder)
        {
            builder.ToTable("ItemPricePolicies");
            builder.HasKey(x => x.Id);

            builder.HasOne(t => t.PatientType)
                .WithMany()
                .HasForeignKey(pc => pc.PatientTypeId)
                ;

            builder.HasOne(t => t.Item)
                .WithMany()
                .HasForeignKey(pc => pc.ItemId)
                ;
        }
    }
}
