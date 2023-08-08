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
                .WithMany()
                .HasForeignKey(pc => pc.PatientTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(t => t.SService)
                .WithMany()
                .HasForeignKey(pc => pc.ServiceId)
                .OnDelete(DeleteBehavior.NoAction); 
        }
    }
}
