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
                   Id = new Guid("C587599C-A6A6-454F-8E30-2A92DAC6F588"),
                   Code = "01",
                   Name = "Viên",
                   SortOrder = 1
               },
               new SServiceUnit()
               {
                   Id = new Guid("6CC9258A-5F48-4C22-8CD6-61C0795F5405"),
                   Code = "02",
                   Name = "Lần",
                   SortOrder = 2
               },
               new SServiceUnit()
               {
                   Id = new Guid("AE0ECE26-BB4C-4B23-95CB-1A5D66114634"),
                   Code = "03",
                   Name = "Lọ",
                   SortOrder = 3
               },
               new SServiceUnit()
               {
                   Id = new Guid("DA514A31-4DFC-4445-99BD-4AE29359AD48"),
                   Code = "04",
                   Name = "Tuýt",
                   SortOrder = 4
               },
               new SServiceUnit()
               {
                   Id = new Guid("44AB6FFC-F1A9-47D0-90AB-9F09D767C286"),
                   Code = "05",
                   Name = "Ống",
                   SortOrder = 5
               },
               new SServiceUnit()
               {
                   Id = new Guid("0762AEBF-CBB8-4102-B923-A30DF490F75D"),
                   Code = "06",
                   Name = "Hộp",
                   SortOrder = 06
               },
               new SServiceUnit()
               {
                   Id = new Guid("7A0FED4A-E62A-4E9F-8E92-7332127CA248"),
                   Code = "07",
                   Name = "Tub",
                   SortOrder = 07
               },
               new SServiceUnit()
               {
                   Id = new Guid("9FF4F404-68BD-4780-99BC-1033227CBE3D"),
                   Code = "08",
                   Name = "Gói",
                   SortOrder = 8
               },
               new SServiceUnit()
               {
                   Id = new Guid("2198D1C0-57FA-453F-B605-9CEF55929067"),
                   Code = "09",
                   Name = "Cuộn",
                   SortOrder = 9
               },
               new SServiceUnit()
               {
                   Id = new Guid("BF42CBF7-B5AC-4503-B73D-D91F4051FA8F"),
                   Code = "10",
                   Name = "ml",
                   SortOrder = 10
               },
               new SServiceUnit()
               {
                   Id = new Guid("9E12370E-B3CE-4862-8E7D-83D8F7EC56D1"),
                   Code = "11",
                   Name = "Lít",
                   SortOrder = 11
               },
               new SServiceUnit()
               {
                   Id = new Guid("3BE8BC27-3940-451C-87F5-C062DF716872"),
                   Code = "12",
                   Name = "Gam",
                   SortOrder = 12
               },
               new SServiceUnit()
               {
                   Id = new Guid("CC8713C1-536A-4835-BD7E-187603566F95"),
                   Code = "13",
                   Name = "Kg",
                   SortOrder = 13
               },
               new SServiceUnit()
               {
                   Id = new Guid("49793DB4-C0CE-43C1-B439-EACD554FA06E"),
                   Code = "14",
                   Name = "Met",
                   SortOrder = 14
               },
               new SServiceUnit()
               {
                   Id = new Guid("A7E37E54-47B8-4716-B493-B657D4981E35"),
                   Code = "15",
                   Name = "Minimet",
                   SortOrder = 9
               }
               );
        }
    }
}
