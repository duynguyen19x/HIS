﻿using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations
{
    public class SYSTokenConfiguration : IEntityTypeConfiguration<UserToken>
    {
        public void Configure(EntityTypeBuilder<UserToken> builder)
        {
            builder.ToTable("SYSTokens");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.TokenValue);
            builder.Property(x => x.Jti).HasMaxLength(125);
        }
    }
}
