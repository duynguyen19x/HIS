using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data
{
    public static class GenderBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<SGender>().HasData(
            //    new SGender()
            //    {
            //        Id = Guid.NewGuid(),
            //        Code = Utilities.Enums.GenderTypes.None,
            //        Name = "Chưa xác định"
            //    },
            //    new SGender()
            //    {
            //        Id = Guid.NewGuid(),
            //        Code = Utilities.Enums.GenderTypes.Male,
            //        Name = "Nam"
            //    },
            //    new SGender()
            //    {
            //        Id = Guid.NewGuid(),
            //        Code = Utilities.Enums.GenderTypes.Female,
            //        Name = "Nữ"
            //    });
        }
    }
}
