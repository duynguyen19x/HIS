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
                    Id = (int)DepartmentTypes.ClinicalDepartment,
                    Code = "ClDe",
                    Name = "Khoa lâm sàng",
                    SortOrder = (int)DepartmentTypes.ClinicalDepartment
                },
                new SDepartmentType()
                {
                    Id = (int)DepartmentTypes.ClinicalLaboratoryDepartment,
                    Code = "LaDe",
                    Name = "Khoa cận lâm sàng",
                    SortOrder = (int)DepartmentTypes.ClinicalLaboratoryDepartment
                },
                new SDepartmentType()
                {
                    Id = (int)DepartmentTypes.PharmacyDepartment,
                    Code = "PhDe",
                    Name = "Khoa dược",
                    SortOrder = (int)DepartmentTypes.PharmacyDepartment
                },
                new SDepartmentType()
                {
                    Id = (int)DepartmentTypes.ComprehensivePlan,
                    Code = "CoPl",
                    Name = "Kế hoạch tổng hợp",
                    SortOrder = (int)DepartmentTypes.ComprehensivePlan
                });
        }
    }
}
