using HIS.EntityFrameworkCore.Entities.Systems;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.EntityFrameworkCore.Seeds.Systems
{
    internal class SYSRefTypeSeed : ISeed
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SYSRefType>().HasData(
                new SYSRefType { Id = 1, Name = "Chi nhánh", RefTypeCategoryId = 1, SortOrder = 1 },

                new SYSRefType { Id = 101, Name = "Quốc gia", RefTypeCategoryId = 101, SortOrder = 101 },
                new SYSRefType { Id = 102, Name = "Tỉnh, thành phố", RefTypeCategoryId = 101, SortOrder = 102 },
                new SYSRefType { Id = 103, Name = "Quận, huyện", RefTypeCategoryId = 101, SortOrder = 103 },
                new SYSRefType { Id = 104, Name = "Xã, phường", RefTypeCategoryId = 101, SortOrder = 104 },
                new SYSRefType { Id = 105, Name = "Bệnh viện", RefTypeCategoryId = 101, SortOrder = 105 },

                new SYSRefType { Id = 101, Name = "Danh mục", SortOrder = 2 },
                new SYSRefType { Id = 201, Name = "Tiếp đón", SortOrder = 3 },
                new SYSRefType { Id = 301, Name = "Khám bệnh", SortOrder = 4 }
                );
        }
    }
}
