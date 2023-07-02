using HIS.EntityFrameworkCore.Entities.Business.Patients;
using HIS.Utilities.Enums;
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
                    Id = new Guid("A080ECAA-6CD6-459D-A450-D89351E0904D"),
                    Code = PatientTypes.BHYT,
                    Name = "Bảo hiểm y tế",
                    Inactive = false,
                },
                new SPatientType()
                {
                    Id = new Guid("8522AA82-5B5E-4D46-A001-26BAD813DB10"),
                    Code = PatientTypes.VP,
                    Name = "Viện phí",
                    Inactive = false,
                },
                new SPatientType()
                {
                    Id = new Guid("447FE0B2-6F08-4E1A-B456-EBC0DDB6FEED"),
                    Code = PatientTypes.DV,
                    Name = "Dịch vụ",
                    Inactive = false,
                }
            );
        }
    }
}
