using HIS.EntityFrameworkCore.Entities.Systems;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations
{
    public class TokenConfiguration : IEntityTypeConfiguration<SToken>
    {
        public void Configure(EntityTypeBuilder<SToken> builder)
        {
            builder.ToTable("Tokens");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.TokenValue);
            builder.Property(x => x.Jti).HasMaxLength(125);

            builder.HasOne(t => t.User).WithMany(pc => pc.UserTokens)
              .HasForeignKey(pc => pc.UserId);
        }
    }
}
