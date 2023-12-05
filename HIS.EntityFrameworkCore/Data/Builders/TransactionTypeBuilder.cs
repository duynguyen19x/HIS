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
                new TransactionType(TransactionTypeConst.THU_TIEN, "Thu tiền", 1),
                new TransactionType(TransactionTypeConst.HOAN_TIEN, "Hoàn tiền", 2),
                new TransactionType(TransactionTypeConst.TAM_UNG, "Tạm ứng", 3),
                new TransactionType(TransactionTypeConst.HOAN_UNG, "Hoàn ứng", 4)
                );
        }
    }
}
