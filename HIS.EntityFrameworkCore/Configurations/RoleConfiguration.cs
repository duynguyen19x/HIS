using HIS.EntityFrameworkCore.Entities.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIS.EntityFrameworkCore.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<SRole>
    {
        public void Configure(EntityTypeBuilder<SRole> builder)
        {
            builder.ToTable("SRoles");

            // Primary key
            builder.HasKey(r => r.Id);

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.Name).HasMaxLength(256);
            builder.Property(u => u.Description).HasMaxLength(256);
        }
    }
}
