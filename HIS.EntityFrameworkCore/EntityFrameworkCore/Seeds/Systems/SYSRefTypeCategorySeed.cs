using HIS.EntityFrameworkCore.Entities.Systems;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.EntityFrameworkCore.Seeds.Systems
{
    internal class SYSRefTypeCategorySeed : ISeed
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SYSRefTypeCategory>().HasData(
                new SYSRefTypeCategory { Id = 1, Name = "Hệ thống", SortOrder = 1 },
                new SYSRefTypeCategory { Id = 101, Name = "Danh mục", SortOrder = 2 },
                new SYSRefTypeCategory { Id = 201, Name = "Tiếp đón", SortOrder = 3 },
                new SYSRefTypeCategory { Id = 301, Name = "Khám bệnh", SortOrder = 4 }
                );
        }
    }
}
