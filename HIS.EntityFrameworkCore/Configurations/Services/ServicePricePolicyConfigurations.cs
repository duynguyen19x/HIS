using HIS.EntityFrameworkCore.Entities.Categories.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Services
{
    public class ServicePricePolicyConfigurations : IEntityTypeConfiguration<SServicePricePolicy>
    {
        public void Configure(EntityTypeBuilder<SServicePricePolicy> builder)
        {
            builder.ToTable("SServicePricePolicies");
            builder.HasKey(x => x.Id);

            builder.HasOne(t => t.SPatientType)
                .WithMany(pc => pc.SServicePricePolicies)
                .HasForeignKey(pc => pc.PatientTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.SService)
                .WithMany(pc => pc.SServicePricePolicies)
                .HasForeignKey(pc => pc.ServiceId)
                .OnDelete(DeleteBehavior.Restrict); 
        }
    }
}
