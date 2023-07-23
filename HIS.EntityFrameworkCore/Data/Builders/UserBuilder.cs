using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.Utilities.Commons;
using Microsoft.EntityFrameworkCore;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public static class UserBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SUser>().HasData(new SUser()
            {
                Id = new Guid("3382BE1C-2836-4246-99DB-C4E1C781E868"),
                UserName = "Administrator",
                Password = Security.EncryptMd5("Ihs123456a@"),
                FirstName = "Admin",
                LastName = "Administrator",
                Email = "administrator@gmail.com",
                UseType = Utilities.Enums.UseTypes.Admin,
                Status = Utilities.Enums.UserStatusTypes.Active,
            });
        }
    }
}
