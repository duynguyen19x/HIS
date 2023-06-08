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
                         Id = Guid.NewGuid(),
                         Code = "PT-DB",
                         Name = "Phẫu thuật đặc biệt"
                     },
                     new SSurgicalProcedureType()
                     {
                         Id = Guid.NewGuid(),
                         Code = "PT-1",
                         Name = "Phẫu thuật loại 1"
                     },
                     new SSurgicalProcedureType()
                     {
                         Id = Guid.NewGuid(),
                         Code = "PT-2",
                         Name = "Phẫu thuật loại 2"
                     },
                     new SSurgicalProcedureType()
                     {
                         Id = Guid.NewGuid(),
                         Code = "PT-3",
                         Name = "Phẫu thuật loại 3"
                     }, new SSurgicalProcedureType()
                     {
                         Id = Guid.NewGuid(),
                         Code = "TT-DB",
                         Name = "Thủ thuật đặc biệt"
                     },
                     new SSurgicalProcedureType()
                     {
                         Id = Guid.NewGuid(),
                         Code = "TT-1",
                         Name = "Thủ thuật loại 1"
                     },
                     new SSurgicalProcedureType()
                     {
                         Id = Guid.NewGuid(),
                         Code = "TT-2",
                         Name = "Thủ thuật loại 2"
                     },
                     new SSurgicalProcedureType()
                     {
                         Id = Guid.NewGuid(),
                         Code = "TT-3",
                         Name = "Thủ thuật loại 3"
                     });
        }
    }
}
