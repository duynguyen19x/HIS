using HIS.EntityFrameworkCore.Entities.Categories.Patients;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data
{
    public static class PatientTypeBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SPatientType>().HasData(
                new SPatientType()
                {
                    Id = Guid.NewGuid(),
                    Code = "BHYT",
                    Name = "Bảo hiểm y tế",
                    IsActive = true,
                },
                new SPatientType()
                {
                    Id = Guid.NewGuid(),
                    Code = "VP",
                    Name = "Viện phí",
                    IsActive = true,
                },
                new SPatientType()
                {
                    Id = Guid.NewGuid(),
                    Code = "DV",
                    Name = "Dịch vụ",
                    IsActive = true,
                }
            );
        }
    }
}
