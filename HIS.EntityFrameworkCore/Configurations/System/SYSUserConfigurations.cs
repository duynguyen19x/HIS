using HIS.EntityFrameworkCore.Entities;
using HIS.Utilities.Commons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations
{
    public class SYSUserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User() { Id = new Guid("3382BE1C-2836-4246-99DB-C4E1C781E868"), Username = "Administrator", Password = Security.EncryptMd5("Ihs123456a@"), FullName = "Admin", Email = "administrator@gmail.com", CreatedDate = new DateTime(2024, 1, 1), },
                new User() { Id = new Guid("49BA7FD4-2EDB-4482-A419-00C81F023F5C"), FullName = "ADMIN", Username = "ADMIN", Password = Security.EncryptMd5("123qwe"), Email = "administrator@gmail.com", CreatedDate = new DateTime(2024, 1, 1), });
        }
    }
}
