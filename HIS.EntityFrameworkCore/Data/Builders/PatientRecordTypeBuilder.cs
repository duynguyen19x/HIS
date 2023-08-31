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
            modelBuilder.Entity<PatientRecordType>().HasData(
                new PatientRecordType((int)PatientRecordTypes.NOITRU, PatientRecordTypes.NOITRU.ToString(), "Nội trú", null, 1, false),
                new PatientRecordType((int)PatientRecordTypes.NGOAITRU, PatientRecordTypes.NGOAITRU.ToString(), "Ngoại trú", null, 2, false),
                new PatientRecordType((int)PatientRecordTypes.DICHVU, PatientRecordTypes.DICHVU.ToString(), "Dịch vụ", null, 3, false)
            );
        }
    }
}
