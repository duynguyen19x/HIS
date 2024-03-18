using HIS.EntityFrameworkCore.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations
{
    public class SYSTokenConfiguration : IEntityTypeConfiguration<SYSToken>
    {
        public void Configure(EntityTypeBuilder<SYSToken> builder)
        {
            builder.ToTable("SYS_Token");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.TokenValue);
            builder.Property(x => x.Jti).HasMaxLength(125);

            builder.HasOne(t => t.User).WithMany(pc => pc.UserTokens)
              .HasForeignKey(pc => pc.UserId);
        }
    }
}
