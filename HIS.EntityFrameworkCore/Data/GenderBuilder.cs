using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Enums;
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
            modelBuilder.Entity<SGender>().HasData(
                new SGender()
                {
                    Id = new Guid("97AC7FD8-EDFA-4243-97FC-98468F492DF1"),
                    Code = ((int)GenderTypes.None).ToString(),
                    Name = "Chưa xác định",
                    SortOrder = 1
                },
                new SGender()
                {
                    Id = new Guid("FC153433-BF89-4E95-8523-DF3D8CEC8676"),
                    Code = ((int)GenderTypes.Male).ToString(),
                    Name = "Nam",
                    SortOrder = 2
                },
                new SGender()
                {
                    Id = new Guid("E9497984-D355-41AF-B917-091500956BE9"),
                    Code = ((int)GenderTypes.Female).ToString(),
                    Name = "Nữ",
                    SortOrder = 3
                });
        }
    }
}
