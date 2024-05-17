using HIS.EntityFrameworkCore.Entities;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DepartmentTypeConfiguration : IEntityTypeConfiguration<DepartmentType>
    {
        public void Configure(EntityTypeBuilder<DepartmentType> builder)
        {
            builder.HasData(
                new DepartmentType()
                {
                    Id = (int)DepartmentTypes.ClinicalDepartment,
                    Code = "LS",
                    Name = "Khoa lâm sàng",
                    SortOrder = (int)DepartmentTypes.ClinicalDepartment
                },
                new DepartmentType()
                {
                    Id = (int)DepartmentTypes.ClinicalLaboratoryDepartment,
                    Code = "CLS",
                    Name = "Khoa cận lâm sàng",
                    SortOrder = (int)DepartmentTypes.ClinicalLaboratoryDepartment
                },
                new DepartmentType()
                {
                    Id = (int)DepartmentTypes.PharmacyDepartment,
                    Code = "DUOC",
                    Name = "Khoa dược",
                    SortOrder = (int)DepartmentTypes.PharmacyDepartment
                },
                new DepartmentType()
                {
                    Id = (int)DepartmentTypes.ComprehensivePlan,
                    Code = "KHTH",
                    Name = "Kế hoạch tổng hợp",
                    SortOrder = (int)DepartmentTypes.ComprehensivePlan
                });
        }
    }
}
