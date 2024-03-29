﻿using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class WardConfiguration : IEntityTypeConfiguration<Ward>
    {
        public void Configure(EntityTypeBuilder<Ward> builder)
        {
            builder.ToTable("DIC_Ward");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.WardCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.WardName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.ShortText).HasMaxLength(20);
            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasOne(x=>x.District).WithMany().HasForeignKey(pc => pc.DistrictId);
        }
    }
}
