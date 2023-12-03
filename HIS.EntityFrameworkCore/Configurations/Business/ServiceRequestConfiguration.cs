using HIS.EntityFrameworkCore.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class ServiceRequestConfiguration : IEntityTypeConfiguration<ServiceRequest>
    {
        public void Configure(EntityTypeBuilder<ServiceRequest> builder)
        {
            builder.ToTable("ServiceRequest");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ServiceRequestCode).IsRequired().HasMaxLength(20);
            builder.Property(x => x.ServiceRequestDate).IsRequired();
            builder.Property(x => x.ServiceRequestUseDate).IsRequired();
            builder.Property(x => x.Barcode).HasMaxLength(20);
            builder.Property(x => x.IcdCode).HasMaxLength(20);
            builder.Property(x => x.IcdName).HasMaxLength(512);
            builder.Property(x => x.IcdSubCode).HasMaxLength(512);
            builder.Property(x => x.IcdText).HasMaxLength(512);
        }
    }
}
