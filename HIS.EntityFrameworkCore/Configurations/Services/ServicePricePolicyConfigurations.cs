using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.Dictionary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Services
{
    public class ServicePricePolicyConfigurations : IEntityTypeConfiguration<ServicePricePolicy>
    {
        public void Configure(EntityTypeBuilder<ServicePricePolicy> builder)
        {
            builder.ToTable("DIC_ServicePricePolicy");
            builder.HasKey(x => x.Id);

            builder.HasOne<PatientObjectType>(t => t.PatientType).WithMany().HasForeignKey(pc => pc.PatientTypeId);

            builder.HasOne(t => t.Service)
                .WithMany()
                .HasForeignKey(pc => pc.ServiceId);
        }
    }
}
