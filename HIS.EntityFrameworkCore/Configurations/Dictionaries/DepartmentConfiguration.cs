﻿using HIS.EntityFrameworkCore.Entities.Categories.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<SDepartment>
    {
        public void Configure(EntityTypeBuilder<SDepartment> builder)
        {
            builder.ToTable("SDepartments");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(512);
            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasOne(t => t.SBranch).WithMany(p => p.Departments).HasForeignKey(p => p.BranchId);
        }
    }
}
