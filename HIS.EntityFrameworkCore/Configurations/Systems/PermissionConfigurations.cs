using HIS.EntityFrameworkCore.Entities.Systems;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations
{
    public class PermissionConfigurations : IEntityTypeConfiguration<SPermission>
    {
        public void Configure(EntityTypeBuilder<SPermission> builder)
        {
            builder.ToTable("SPermissions");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(100);
            builder.Property(x => x.Name).HasMaxLength(500);
        }
    }
}
