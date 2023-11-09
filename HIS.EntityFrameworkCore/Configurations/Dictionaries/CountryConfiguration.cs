﻿using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Country");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(20).IsRequired();
            builder.Property(x => x.HeInCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(512).IsRequired();
            
        }
    }
}
