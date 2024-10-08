﻿using HIS.EntityFrameworkCore.Entities.Categories.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Services
{
    public class ServiceResultIndexConfiguration : IEntityTypeConfiguration<ServiceResultIndice>
    {
        public void Configure(EntityTypeBuilder<ServiceResultIndice> builder)
        {
            builder.ToTable("SServiceResultIndices");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(512);
            builder.Property(x => x.Unit).HasMaxLength(128);
            builder.Property(x => x.Normal).HasMaxLength(128);

            builder.HasOne(t => t.Service).WithMany().HasForeignKey(pc => pc.ServiceId);
        }
    }
}
