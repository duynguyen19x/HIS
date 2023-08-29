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
    internal class MedicalRecordResultBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedicalRecordResult>().HasData(
                new MedicalRecordResult((int)MedicalRecordResults.KHOI, MedicalRecordResults.KHOI.ToString(), "Khỏi", null, 1, false),
                new MedicalRecordResult((int)MedicalRecordResults.DO_GIAM, MedicalRecordResults.DO_GIAM.ToString(), "Đỡ, giảm", null, 2, false),
                new MedicalRecordResult((int)MedicalRecordResults.KHONGTHAYDOI, MedicalRecordResults.KHONGTHAYDOI.ToString(), "Không thay đổi", null, 3, false),
                new MedicalRecordResult((int)MedicalRecordResults.NANGHON, MedicalRecordResults.NANGHON.ToString(), "Nặng hơn", null, 4, false),
                new MedicalRecordResult((int)MedicalRecordResults.TUVONG, MedicalRecordResults.TUVONG.ToString(), "Tử vong", null, 5, false),
                new MedicalRecordResult((int)MedicalRecordResults.KHAC, MedicalRecordResults.KHAC.ToString(), "Khác", null, 6, true)
            );
        }
    }
}
