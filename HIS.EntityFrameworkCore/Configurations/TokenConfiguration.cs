using HIS.EntityFrameworkCore.Entities.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations
{
    public class TokenConfiguration : IEntityTypeConfiguration<Token>
    {
        public void Configure(EntityTypeBuilder<Token> builder)
        {
            builder.ToTable("Tokens");

            // Composite primary key consisting of the UserId, LoginProvider and Name
            builder.HasKey(x => x.Id);

            // Limit the size of the composite key columns due to common DB restrictions
            builder.Property(x => x.TokenValue);
            builder.Property(x => x.Jti).HasMaxLength(125);

            builder.HasOne(t => t.User).WithMany(pc => pc.UserTokens)
              .HasForeignKey(pc => pc.UserId);
        }
    }
}
