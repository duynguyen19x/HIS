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
    public class RolePermissionBranchConfigurations : IEntityTypeConfiguration<SRolePermissionBranch>
    {
        public void Configure(EntityTypeBuilder<SRolePermissionBranch> builder)
        {
            builder.ToTable("SRolePermissionBranchs");
            builder.HasKey(t => new { t.RoleId, t.PermissionId });

            builder.HasOne(t => t.Role).WithMany(pc => pc.RolePermissions)
              .HasForeignKey(pc => pc.RoleId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(t => t.Permission).WithMany(pc => pc.RolePermissions)
              .HasForeignKey(pc => pc.PermissionId).OnDelete(DeleteBehavior.NoAction);

            //builder.HasOne(t => t.Branch).WithMany(pc => pc.RolePermissions)
            // .HasForeignKey(pc => pc.BranchId);
        }
    }
}
