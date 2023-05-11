﻿using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class JobConfiguration : IEntityTypeConfiguration<SJob>
    {
        public void Configure(EntityTypeBuilder<SJob> builder)
        {
            builder.ToTable("SJobs");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired(); ;
            builder.Property(x => x.Name).HasMaxLength(512).IsRequired(); ;
            builder.Property(x => x.Description).HasMaxLength(512);
        }
    }
}
