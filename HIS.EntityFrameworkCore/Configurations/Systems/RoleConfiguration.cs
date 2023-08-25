﻿using HIS.EntityFrameworkCore.Entities.Systems;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIS.EntityFrameworkCore.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");

            // Primary key
            builder.HasKey(r => r.Id);

            // Limit the size of columns to use efficient database types
            builder.Property(r => r.Code).IsRequired().HasMaxLength(20);
            builder.Property(u => u.Name).IsRequired().HasMaxLength(256);
            builder.Property(u => u.Description).HasMaxLength(256);
        }
    }
}
