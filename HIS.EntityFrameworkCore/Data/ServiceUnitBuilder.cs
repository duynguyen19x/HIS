using HIS.EntityFrameworkCore.Entities.Categories;
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
    public static class ServiceUnitBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SServiceUnit>().HasData(
               new SServiceUnit()
               {
                   Id = Guid.NewGuid(),
                   Code = "01",
                   Name = "Viên",
                   SortOrder = 1
               },
               new SServiceUnit()
               {
                   Id = Guid.NewGuid(),
                   Code = "02",
                   Name = "Lần",
                   SortOrder = 2
               },
               new SServiceUnit()
               {
                   Id = Guid.NewGuid(),
                   Code = "03",
                   Name = "Lọ",
                   SortOrder = 3
               },
               new SServiceUnit()
               {
                   Id = Guid.NewGuid(),
                   Code = "04",
                   Name = "Tuýt",
                   SortOrder = 4
               },
               new SServiceUnit()
               {
                   Id = Guid.NewGuid(),
                   Code = "05",
                   Name = "Ống",
                   SortOrder = 5
               },
               new SServiceUnit()
               {
                   Id = Guid.NewGuid(),
                   Code = "06",
                   Name = "Hộp",
                   SortOrder = 06
               },
               new SServiceUnit()
               {
                   Id = Guid.NewGuid(),
                   Code = "07",
                   Name = "Tub",
                   SortOrder = 07
               },
               new SServiceUnit()
               {
                   Id = Guid.NewGuid(),
                   Code = "08",
                   Name = "Gói",
                   SortOrder = 8
               },
               new SServiceUnit()
               {
                   Id = Guid.NewGuid(),
                   Code = "09",
                   Name = "Cuộn",
                   SortOrder = 9
               },
               new SServiceUnit()
               {
                   Id = Guid.NewGuid(),
                   Code = "10",
                   Name = "ml",
                   SortOrder = 10
               },
               new SServiceUnit()
               {
                   Id = Guid.NewGuid(),
                   Code = "11",
                   Name = "Lít",
                   SortOrder = 11
               },
               new SServiceUnit()
               {
                   Id = Guid.NewGuid(),
                   Code = "12",
                   Name = "Gam",
                   SortOrder = 12
               },
               new SServiceUnit()
               {
                   Id = Guid.NewGuid(),
                   Code = "13",
                   Name = "Kg",
                   SortOrder = 13
               },
               new SServiceUnit()
               {
                   Id = Guid.NewGuid(),
                   Code = "14",
                   Name = "Met",
                   SortOrder = 14
               },
               new SServiceUnit()
               {
                   Id = Guid.NewGuid(),
                   Code = "15",
                   Name = "Minimet",
                   SortOrder = 9
               }
               );
        }
    }
}
