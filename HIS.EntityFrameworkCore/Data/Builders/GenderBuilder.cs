using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public static class GenderBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SGender>().HasData(
                new SGender()
                {
                    Id = new Guid("97AC7FD8-EDFA-4243-97FC-98468F492DF1"),
                    Code = "KXD",
                    Name = "Chưa xác định",
                    SortOrder = (int)GenderTypes.None
                },
                new SGender()
                {
                    Id = new Guid("FC153433-BF89-4E95-8523-DF3D8CEC8676"),
                    Code = "NAM",
                    Name = "Nam",
                    SortOrder = (int)GenderTypes.Male
                },
                new SGender()
                {
                    Id = new Guid("E9497984-D355-41AF-B917-091500956BE9"),
                    Code = "NU",
                    Name = "Nữ",
                    SortOrder = (int)GenderTypes.Female
                });
        }
    }
}
