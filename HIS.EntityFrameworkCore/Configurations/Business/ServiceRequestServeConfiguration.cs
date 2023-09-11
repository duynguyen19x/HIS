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
    public class ServiceRequestServeConfiguration : IEntityTypeConfiguration<ServiceRequestServe>
    {
        public void Configure(EntityTypeBuilder<ServiceRequestServe> builder)
        {
            builder.ToTable("ServiceRequestServe");
            builder.HasKey(x => x.Id);
            builder.Property(u => u.Description).HasMaxLength(500);
        }
    }
}
