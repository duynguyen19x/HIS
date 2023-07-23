using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public class DepartmentTypeBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SDepartmentType>().HasData(
                new SDepartmentType()
                {
                    Id = (int)DepartmentTypes.ClinicalDepartment,
                    Code = "LS",
                    Name = "Khoa lâm sàng",
                    SortOrder = (int)DepartmentTypes.ClinicalDepartment
                },
                new SDepartmentType()
                {
                    Id = (int)DepartmentTypes.ClinicalLaboratoryDepartment,
                    Code = "CLS",
                    Name = "Khoa cận lâm sàng",
                    SortOrder = (int)DepartmentTypes.ClinicalLaboratoryDepartment
                },
                new SDepartmentType()
                {
                    Id = (int)DepartmentTypes.PharmacyDepartment,
                    Code = "DUOC",
                    Name = "Khoa dược",
                    SortOrder = (int)DepartmentTypes.PharmacyDepartment
                },
                new SDepartmentType()
                {
                    Id = (int)DepartmentTypes.ComprehensivePlan,
                    Code = "KHTH",
                    Name = "Kế hoạch tổng hợp",
                    SortOrder = (int)DepartmentTypes.ComprehensivePlan
                });
        }
    }
}
