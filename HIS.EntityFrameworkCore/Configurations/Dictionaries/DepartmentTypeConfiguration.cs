﻿using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DepartmentTypeConfiguration : IEntityTypeConfiguration<SDepartmentType>
    {
        public void Configure(EntityTypeBuilder<SDepartmentType> builder)
        {
            builder.ToTable("SDepartmentTypes");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired(); ;
            builder.Property(x => x.Name).HasMaxLength(512).IsRequired(); ;
            builder.Property(x => x.Description).HasMaxLength(512);
        }
    }
}
