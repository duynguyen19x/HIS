using HIS.EntityFrameworkCore.Entities.Systems;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(256);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(256);
            builder.Property(x => x.Dob).IsRequired(false);
            builder.Property(x => x.GenderId).IsRequired(false);
            builder.Property(x => x.ProvinceId).IsRequired(false);
            builder.Property(x => x.DistrictId).IsRequired(false);
            builder.Property(x => x.WardId).IsRequired(false);
            builder.Property(x => x.UseType).IsRequired();
            builder.Property(x => x.Address).IsRequired(false).HasMaxLength(500);
            builder.Property(x => x.PhoneNumber).IsRequired(false).HasMaxLength(25);
            builder.Property(x => x.Email).IsRequired(false).HasMaxLength(256);
            builder.Property(x => x.Password).IsRequired(false).HasMaxLength(1020);
        }
    }
}
