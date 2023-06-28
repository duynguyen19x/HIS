using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data
{
    public class DepartmentTypeBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SDepartmentType>().HasData(
                new SDepartmentType()
                {
                    Id = new Guid("31471839-6881-4790-AC25-EBD775776DD0"),
                    Code = ((int)DepartmentTypes.ClinicalDepartment).ToString(),
                    Name = "Khoa lâm sàng",
                    SortOrder = 1
                },
                new SDepartmentType()
                {
                    Id = new Guid("A32FAC82-1E9C-4B36-B8E5-C3B5D9FB3C6D"),
                    Code = ((int)DepartmentTypes.ClinicalLaboratoryDepartment).ToString(),
                    Name = "Khoa cận lâm sàng",
                    SortOrder = 2
                },
                new SDepartmentType()
                {
                    Id = new Guid("06C44348-2449-4BD7-8B5D-E32F4ED77972"),
                    Code = ((int)DepartmentTypes.PharmacyDepartment).ToString(),
                    Name = "Khoa dược",
                    SortOrder = 3
                },
                new SDepartmentType()
                {
                    Id = new Guid("97FF5291-A914-4AE4-9BD6-1B79B7976598"),
                    Code = ((int)DepartmentTypes.ComprehensivePlan).ToString(),
                    Name = "Kế hoạch tổng hợp",
                    SortOrder = 4
                });
        }
    }
}
