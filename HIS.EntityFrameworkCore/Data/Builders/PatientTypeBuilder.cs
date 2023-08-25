using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public static class PatientTypeBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatientType>().HasData(
                new PatientType()
                {
                    Id = 1,
                    Code = PatientTypes.BHYT,
                    Name = "Bảo hiểm y tế",
                    Inactive = false
                },
                new PatientType()
                {
                    Id = 2,
                    Code = PatientTypes.VP,
                    Name = "Viện phí",
                    Inactive = false
                },
                new PatientType()
                {
                    Id = 3,
                    Code = PatientTypes.DV,
                    Name = "Dịch vụ",
                    Inactive = false
                }
            );
        }
    }
}
