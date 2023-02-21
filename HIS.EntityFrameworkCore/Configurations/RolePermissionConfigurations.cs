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
    public class RolePermissionConfigurations : IEntityTypeConfiguration<RolePermission>
    {
        public void Configure(EntityTypeBuilder<RolePermission> builder)
        {
            builder.ToTable("RolePermission");
            builder.HasKey(t => new { t.RoleId, t.PermissionId });

            builder.HasOne(t => t.Role).WithMany(pc => pc.RolePermissions)
              .HasForeignKey(pc => pc.RoleId);

            builder.HasOne(t => t.Permission).WithMany(pc => pc.RolePermissions)
              .HasForeignKey(pc => pc.PermissionId);
        }
    }
}
