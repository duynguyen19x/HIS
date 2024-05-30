using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations
{
    public class SYSTokenConfiguration : IEntityTypeConfiguration<UserToken>
    {
        public void Configure(EntityTypeBuilder<UserToken> builder)
        {
            builder.ToTable("SYS_Token");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.TokenValue);
            builder.Property(x => x.Jti).HasMaxLength(125);

            builder.HasOne(t => t.UserFk).WithMany(pc => pc.UserTokens)
              .HasForeignKey(pc => pc.UserId);
        }
    }
}
