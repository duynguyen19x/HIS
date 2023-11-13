using HIS.EntityFrameworkCore.Constants;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public class TransactionTypeBuilder
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<TransactionType>().HasData(
                new TransactionType() { Id = TransactionTypeConst.THU_TIEN, Code = "TT", Name = "Thu tiền", SortOrder = 1 },
                new TransactionType() { Id = TransactionTypeConst.HOAN_TIEN, Code = "HT", Name = "Hoàn tiền", SortOrder = 2 },
                new TransactionType() { Id = TransactionTypeConst.TAM_UNG, Code = "TU", Name = "Tạm ứng", SortOrder = 3 },
                new TransactionType() { Id = TransactionTypeConst.HOAN_UNG, Code = "HU", Name = "Hoàn ứng", SortOrder = 4 }
                );
        }
    }
}
