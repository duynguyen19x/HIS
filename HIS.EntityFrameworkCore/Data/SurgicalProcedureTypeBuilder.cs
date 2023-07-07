using HIS.EntityFrameworkCore.Entities.Categories.Services;
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
    public class SurgicalProcedureTypeBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SSurgicalProcedureType>().HasData(
                     new SSurgicalProcedureType()
                     {
                         Id = (int)SurgicalProcedureTypes.SpecialSurgery,
                         Code = "PTDB",
                         Name = "Phẫu thuật đặc biệt",
                         SortOrder = (int)SurgicalProcedureTypes.SpecialSurgery
                     },
                     new SSurgicalProcedureType()
                     {
                         Id = (int)SurgicalProcedureTypes.TypeSurgery1,
                         Code = "PT01",
                         Name = "Phẫu thuật loại 1",
                         SortOrder = (int)SurgicalProcedureTypes.TypeSurgery1
                     },
                     new SSurgicalProcedureType()
                     {
                         Id = (int)SurgicalProcedureTypes.TypeSurgery2,
                         Code = "PT02",
                         Name = "Phẫu thuật loại 2",
                         SortOrder = (int)SurgicalProcedureTypes.TypeSurgery2
                     },
                     new SSurgicalProcedureType()
                     {
                         Id = (int)SurgicalProcedureTypes.TypeSurgery3,
                         Code = "PT03",
                         Name = "Phẫu thuật loại 3",
                         SortOrder = (int)SurgicalProcedureTypes.TypeSurgery3
                     }, new SSurgicalProcedureType()
                     {
                         Id = (int)SurgicalProcedureTypes.SpecialTrick,
                         Code = "TTDB",
                         Name = "Thủ thuật đặc biệt",
                         SortOrder = (int)SurgicalProcedureTypes.SpecialTrick
                     },
                     new SSurgicalProcedureType()
                     {
                         Id = (int)SurgicalProcedureTypes.TypeTrick1,
                         Code = "TT01",
                         Name = "Thủ thuật loại 1",
                         SortOrder = (int)SurgicalProcedureTypes.TypeTrick1
                     },
                     new SSurgicalProcedureType()
                     {
                         Id = (int)SurgicalProcedureTypes.TypeTrick2,
                         Code = "TT02",
                         Name = "Thủ thuật loại 2",
                         SortOrder = (int)SurgicalProcedureTypes.TypeTrick2
                     },
                     new SSurgicalProcedureType()
                     {
                         Id = (int)SurgicalProcedureTypes.TypeTrick3,
                         Code = "TT03",
                         Name = "Thủ thuật loại 3",
                         SortOrder = (int)SurgicalProcedureTypes.TypeTrick3
                     });
        }
    }
}
