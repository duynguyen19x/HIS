using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Services
{
    public class ServicePricePolicyConfigurations : IEntityTypeConfiguration<ServicePricePolicy>
    {
        public void Configure(EntityTypeBuilder<ServicePricePolicy> builder)
        {
            builder.ToTable("ServicePricePolicies");
            builder.HasKey(x => x.Id);

            builder.HasOne<PatientObjectType>(t => t.PatientObjectType).WithMany().HasForeignKey(pc => pc.PatientObjectTypeId);

            builder.HasOne(t => t.Service)
                .WithMany()
                .HasForeignKey(pc => pc.ServiceId)
                ; 
        }
    }
}
