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
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("UserRoles");
            builder.HasKey(t => new { t.UserId, t.RoleId });

            builder.HasOne(t => t.User).WithMany(pc => pc.UserRoles)
              .HasForeignKey(pc => pc.UserId);

            builder.HasOne(t => t.Role).WithMany(pc => pc.UserRoles)
              .HasForeignKey(pc => pc.RoleId);
        }
    }
}
