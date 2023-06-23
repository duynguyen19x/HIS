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
                         Id = new Guid("B169C6E5-FCF4-4170-AB03-9B150E34E478"),
                         Code = "PT-DB",
                         Name = "Phẫu thuật đặc biệt",
                         SortOrder = 1
                     },
                     new SSurgicalProcedureType()
                     {
                         Id = new Guid("B5990C08-5E3C-44FC-83B5-14829D3B8F3C"),
                         Code = "PT-1",
                         Name = "Phẫu thuật loại 1",
                         SortOrder = 2
                     },
                     new SSurgicalProcedureType()
                     {
                         Id = new Guid("19409B13-E324-49E1-AA24-E091A143A7ED"),
                         Code = "PT-2",
                         Name = "Phẫu thuật loại 2",
                         SortOrder = 3
                     },
                     new SSurgicalProcedureType()
                     {
                         Id = new Guid("50E4DEB7-35C0-4D71-81A2-00098A0213F9"),
                         Code = "PT-3",
                         Name = "Phẫu thuật loại 3",
                         SortOrder = 4
                     }, new SSurgicalProcedureType()
                     {
                         Id = new Guid("AFD4DBFE-7205-407D-B538-6492B10A8425"),
                         Code = "TT-DB",
                         Name = "Thủ thuật đặc biệt",
                         SortOrder = 5
                     },
                     new SSurgicalProcedureType()
                     {
                         Id = new Guid("C3971F03-469F-4156-B0F7-89251F424523"),
                         Code = "TT-1",
                         Name = "Thủ thuật loại 1",
                         SortOrder = 6
                     },
                     new SSurgicalProcedureType()
                     {
                         Id = new Guid("080D3C9D-2DAB-4E12-B4BC-DC9819E2295F"),
                         Code = "TT-2",
                         Name = "Thủ thuật loại 2",
                         SortOrder = 7
                     },
                     new SSurgicalProcedureType()
                     {
                         Id = new Guid("DEC5ADCC-D665-4AB3-95E5-4DC29694090C"),
                         Code = "TT-3",
                         Name = "Thủ thuật loại 3",
                         SortOrder = 8
                     });
        }
    }
}
