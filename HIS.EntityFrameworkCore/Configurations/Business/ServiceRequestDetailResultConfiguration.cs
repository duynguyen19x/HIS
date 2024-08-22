using HIS.EntityFrameworkCore.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class ServiceRequestDetailResultConfiguration : IEntityTypeConfiguration<ServiceRequestDetailResult>
    {
        public void Configure(EntityTypeBuilder<ServiceRequestDetailResult> builder)
        {
            builder.ToTable("DServiceRequestDetailResults");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Result).HasMaxLength(128);
            builder.Property(x => x.TestingMachine).HasMaxLength(1024);

            builder.HasOne(e => e.Service).WithMany().HasForeignKey(e => e.ServiceId);
            builder.HasOne(e => e.ServiceResultIndice).WithMany().HasForeignKey(e => e.ServiceResultIndiceId);
            builder.HasOne(e => e.ServiceRequestData).WithMany().HasForeignKey(e => e.ServiceRequestDetailId);
            builder.HasOne(e => e.ServiceRequests).WithMany().HasForeignKey(e => e.ServiceRequestId);
        }
    }
}
