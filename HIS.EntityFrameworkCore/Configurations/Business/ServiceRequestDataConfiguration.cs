using HIS.EntityFrameworkCore.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class ServiceRequestDataConfiguration : IEntityTypeConfiguration<ServiceRequestData>
    {
        public void Configure(EntityTypeBuilder<ServiceRequestData> builder)
        {
            builder.ToTable("ServiceRequestDatas");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ServiceRequestId).IsRequired();
            builder.Property(x => x.ServiceId).IsRequired();
            builder.Property(x => x.ServiceName).HasMaxLength(512);
            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasOne(e => e.ServiceRequest).WithMany().HasForeignKey(e => e.ServiceRequestId);
            builder.HasOne(e => e.Service).WithMany().HasForeignKey(e => e.ServiceId);
        }
    }
}
