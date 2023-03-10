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
    public class ServiceTypeConfigurations : IEntityTypeConfiguration<SServiceType>
    {
        public void Configure(EntityTypeBuilder<SServiceType> builder)
        {
            builder.ToTable("SServiceTypes");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);

            builder.HasOne(t => t.SServiceUnit).WithMany(pc => pc.SServiceTypes).HasForeignKey(pc => pc.ServiceUnitId);
        }
    }
}
