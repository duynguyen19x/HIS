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
    public class PatientRecordTypeBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatientType>().HasData(
                new PatientType((int)PatientRecordTypes.NOITRU, PatientRecordTypes.NOITRU.ToString(), "Nội trú", null, 1, false),
                new PatientType((int)PatientRecordTypes.NGOAITRU, PatientRecordTypes.NGOAITRU.ToString(), "Ngoại trú", null, 2, false),
                new PatientType((int)PatientRecordTypes.DICHVU, PatientRecordTypes.DICHVU.ToString(), "Dịch vụ", null, 3, false)
            );
        }
    }
}
