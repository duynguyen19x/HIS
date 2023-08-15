﻿using HIS.EntityFrameworkCore.Entities.Systems;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<SUserRole>
    {
        public void Configure(EntityTypeBuilder<SUserRole> builder)
        {
            builder.ToTable("SUserRoles");
            builder.HasKey(t => new { t.UserId, t.RoleId });

            builder.HasOne(t => t.User).WithMany(pc => pc.UserRoles)
              .HasForeignKey(pc => pc.UserId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(t => t.Role).WithMany(pc => pc.UserRoles)
              .HasForeignKey(pc => pc.RoleId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
