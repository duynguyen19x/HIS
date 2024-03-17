using HIS.EntityFrameworkCore.Entities.Systems;
using HIS.Utilities.Commons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations
{
    public class SYSUserConfigurations : IEntityTypeConfiguration<SYSUser>
    {
        public void Configure(EntityTypeBuilder<SYSUser> builder)
        {
            //builder.ToTable("SYS_User");
            //builder.HasKey(x => x.Id);

            //builder.Property(x => x.UserName).IsRequired().HasMaxLength(100);
            //builder.Property(x => x.FirstName).IsRequired().HasMaxLength(256);
            //builder.Property(x => x.LastName).IsRequired().HasMaxLength(256);
            //builder.Property(x => x.Dob).IsRequired(false);
            //builder.Property(x => x.GenderId).IsRequired(false);
            //builder.Property(x => x.ProvinceId).IsRequired(false);
            //builder.Property(x => x.DistrictId).IsRequired(false);
            //builder.Property(x => x.WardId).IsRequired(false);
            //builder.Property(x => x.UseType).IsRequired();
            //builder.Property(x => x.Address).IsRequired(false).HasMaxLength(500);
            //builder.Property(x => x.PhoneNumber).IsRequired(false).HasMaxLength(25);
            //builder.Property(x => x.Email).IsRequired(false).HasMaxLength(256);
            //builder.Property(x => x.Password).IsRequired(false).HasMaxLength(1020);

            //builder.HasData(
            //    new SYSUser()
            //    {
            //        Id = new Guid("3382BE1C-2836-4246-99DB-C4E1C781E868"),
            //        UserName = "Administrator",
            //        Password = Security.EncryptMd5("Ihs123456a@"),
            //        FirstName = "Admin",
            //        LastName = "Administrator",
            //        Email = "administrator@gmail.com",
            //        UseType = Utilities.Enums.UseTypes.Admin,
            //        Status = Utilities.Enums.UserStatusTypes.Active,
            //    },
            //    new SYSUser
            //    {
            //        Id = new Guid("49BA7FD4-2EDB-4482-A419-00C81F023F5C"),
            //        UserName = "hainx",
            //        Password = Security.EncryptMd5("123qwe"),
            //        FirstName = "Hai",
            //        LastName = "Nghiem",
            //        Email = "nghiemhai293@gmail.com",
            //        UseType = Utilities.Enums.UseTypes.Admin,
            //        Status = Utilities.Enums.UserStatusTypes.Active
            //    });

            builder.HasData(
                new SYSUser()
                {
                    Id = new Guid("3382BE1C-2836-4246-99DB-C4E1C781E868"),
                    Username = "Administrator",
                    Password = Security.EncryptMd5("Ihs123456a@"),
                    FullName = "Admin",
                    Email = "administrator@gmail.com"
                },
                new SYSUser()
                {
                    Id = new Guid("49BA7FD4-2EDB-4482-A419-00C81F023F5C"),
                    FullName = "ADMIN",
                    Username = "ADMIN",
                    Password = Security.EncryptMd5("123qwe"),
                    Email = "administrator@gmail.com",
                });
        }
    }
}
