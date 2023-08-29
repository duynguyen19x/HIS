using HIS.EntityFrameworkCore.Entities.Categories.Services;
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

            builder.HasOne(t => t.PatientType)
                .WithMany()
                .HasForeignKey(pc => pc.PatientTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(t => t.Service)
                .WithMany()
                .HasForeignKey(pc => pc.ServiceId)
                .OnDelete(DeleteBehavior.NoAction); 
        }
    }
}
