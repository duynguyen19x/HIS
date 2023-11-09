using HIS.EntityFrameworkCore.Entities.Systems;
using HIS.Utilities.Commons;
using Microsoft.EntityFrameworkCore;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public static class UserBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = new Guid("3382BE1C-2836-4246-99DB-C4E1C781E868"),
                UserName = "Administrator",
                Password = Security.EncryptMd5("Ihs123456a@"),
                FirstName = "Admin",
                LastName = "Administrator",
                Email = "administrator@gmail.com",
                UseType = Utilities.Enums.UseTypes.Admin,
                Status = Utilities.Enums.UserStatusTypes.Active,
            },
            new User
            {
                Id = new Guid("49BA7FD4-2EDB-4482-A419-00C81F023F5C"),
                UserName = "hainx",
                Password = Security.EncryptMd5("123qwe"),
                FirstName = "Hai",
                LastName = "Nghiem",
                Email = "nghiemhai293@gmail.com",
                UseType = Utilities.Enums.UseTypes.Admin,
                Status = Utilities.Enums.UserStatusTypes.Active
            });
        }
    }
}
