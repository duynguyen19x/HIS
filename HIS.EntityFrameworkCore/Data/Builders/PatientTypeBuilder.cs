using HIS.Core.Enums;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public static class PatientTypeBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<PatientType>().HasData(
                new PatientType((int)PatientTypes.BHYT, PatientTypes.BHYT.ToString(), "Bảo hiểm y tế", null, 1, false),
                new PatientType((int)PatientTypes.VP, PatientTypes.VP.ToString(), "Viện phí", null, 2, false),
                new PatientType((int)PatientTypes.DV, PatientTypes.DV.ToString(), "Dịch vụ", null, 3, false)
            );
        }
    }
}
