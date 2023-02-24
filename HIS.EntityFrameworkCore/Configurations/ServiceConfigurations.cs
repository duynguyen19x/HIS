using HIS.EntityFrameworkCore.Entities.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations
{
    public class ServiceConfigurations : IEntityTypeConfiguration<SService>
    {
        public void Configure(EntityTypeBuilder<SService> builder)
        {
            builder.ToTable("SServices");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ServiceCode).HasMaxLength(50);
            builder.Property(x => x.ServiceName).HasMaxLength(500);

            builder.HasOne(t => t.SServiceUnit).WithMany(pc => pc.SServices).HasForeignKey(pc => pc.ServiceUnitId);
            builder.HasOne(t => t.SServiceType).WithMany(pc => pc.SServices).HasForeignKey(pc => pc.ServiceTypeId);
        }
    }
}
