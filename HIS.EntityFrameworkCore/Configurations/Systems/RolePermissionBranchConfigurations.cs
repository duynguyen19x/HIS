using HIS.EntityFrameworkCore.Entities.Systems;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations
{
    public class RolePermissionBranchConfigurations : IEntityTypeConfiguration<RolePermissionBranch>
    {
        public void Configure(EntityTypeBuilder<RolePermissionBranch> builder)
        {
            builder.ToTable("RolePermissionBranchs");
            builder.HasKey(t => new { t.RoleId, t.PermissionId });

            builder.HasOne(t => t.Role).WithMany(pc => pc.RolePermissions)
              .HasForeignKey(pc => pc.RoleId);

            builder.HasOne(t => t.Permission).WithMany(pc => pc.RolePermissions)
              .HasForeignKey(pc => pc.PermissionId);

            //builder.HasOne(t => t.Branch).WithMany(pc => pc.RolePermissions)
            // .HasForeignKey(pc => pc.BranchId);
        }
    }
}
