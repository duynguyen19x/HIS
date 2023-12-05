using HIS.Core.Enums;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public class TreatmentResultBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TreatmentResult>().HasData(
                new TreatmentResult() { Id = (int)TreatmentResults.KHOI, TreatmentResultCode = TreatmentResults.KHOI.ToString(), TreatmentResultName = "Khỏi", SortOrder = 1 },
                new TreatmentResult() { Id = (int)TreatmentResults.DO_GIAM, TreatmentResultCode = TreatmentResults.DO_GIAM.ToString(), TreatmentResultName = "Đỡ, giảm", SortOrder = 2 },
                new TreatmentResult() { Id = (int)TreatmentResults.KHONGTHAYDOI, TreatmentResultCode = TreatmentResults.KHONGTHAYDOI.ToString(), TreatmentResultName = "Không thay đổi", SortOrder = 3 },
                new TreatmentResult() { Id = (int)TreatmentResults.NANGHON, TreatmentResultCode = TreatmentResults.NANGHON.ToString(), TreatmentResultName = "Nặng hơn", SortOrder = 4 },
                new TreatmentResult() { Id = (int)TreatmentResults.TUVONG, TreatmentResultCode = TreatmentResults.TUVONG.ToString(), TreatmentResultName = "Tử vong", SortOrder = 5 },
                new TreatmentResult() { Id = (int)TreatmentResults.KHAC, TreatmentResultCode = TreatmentResults.KHAC.ToString(), TreatmentResultName = "Khác", SortOrder = 6 }
                );
        }
    }
}
