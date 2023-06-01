using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Services
{
    public class ServicePricePolicyConfigurations : IEntityTypeConfiguration<SServicePricePolicy>
    {
        public void Configure(EntityTypeBuilder<SServicePricePolicy> builder)
        {
            builder.ToTable("SServicePricePolicies");
            builder.HasKey(x => x.Id);

            builder.HasOne(t => t.PatientType).WithMany(pc => pc.SServicePricePolicies)
             .HasForeignKey(pc => pc.PatientTypeId);

            builder.HasOne(t => t.SService).WithMany(pc => pc.SServicePricePolicies)
              .HasForeignKey(pc => pc.ServiceId);
        }
    }
}
