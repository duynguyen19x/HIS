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
    public class ServiceUnitConfigurations : IEntityTypeConfiguration<SServiceUnit>
    {
        public void Configure(EntityTypeBuilder<SServiceUnit> builder)
        {
            builder.ToTable("SServiceUnits");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ServiceUnitCode).HasMaxLength(50);
            builder.Property(x => x.ServiceUnitName).HasMaxLength(500);
        }
    }
}
