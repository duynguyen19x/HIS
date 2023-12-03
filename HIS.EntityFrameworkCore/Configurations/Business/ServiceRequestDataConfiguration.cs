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
    public class ServiceRequestDataConfiguration : IEntityTypeConfiguration<ServiceRequestData>
    {
        public void Configure(EntityTypeBuilder<ServiceRequestData> builder)
        {
            builder.ToTable("ServiceRequest");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ServiceName).HasMaxLength(512);
            builder.Property(x => x.Description).HasMaxLength(512);

        }
    }
}
