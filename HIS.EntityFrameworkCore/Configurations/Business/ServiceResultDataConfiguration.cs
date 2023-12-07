using HIS.EntityFrameworkCore.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class ServiceResultDataConfiguration : IEntityTypeConfiguration<ServiceResultData>
    {
        public void Configure(EntityTypeBuilder<ServiceResultData> builder)
        {
            builder.ToTable("BUS_ServiceResultData");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Result).HasMaxLength(128);

            builder.HasOne(e => e.Service).WithMany().HasForeignKey(e => e.ServiceId);
            builder.HasOne(e => e.ServiceResultIndice).WithMany().HasForeignKey(e => e.ServiceResultIndiceId);
        }
    }
}
