using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.Utilities.Commons;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data
{
    public static class UserBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SUser>().HasData(new SUser()
            {
                Id = Guid.NewGuid(),
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
