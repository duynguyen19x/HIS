using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DepartmentTypeConfiguration : IEntityTypeConfiguration<DIDepartmentType>
    {
        public void Configure(EntityTypeBuilder<DIDepartmentType> builder)
        {
            builder.ToTable("DIC_DepartmentType");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired(); 
            builder.Property(x => x.Name).HasMaxLength(512).IsRequired(); 
            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasData(
                new DIDepartmentType()
                {
                    Id = (int)DepartmentTypes.ClinicalDepartment,
                    Code = "LS",
                    Name = "Khoa lâm sàng",
                    SortOrder = (int)DepartmentTypes.ClinicalDepartment
                },
                new DIDepartmentType()
                {
                    Id = (int)DepartmentTypes.ClinicalLaboratoryDepartment,
                    Code = "CLS",
                    Name = "Khoa cận lâm sàng",
                    SortOrder = (int)DepartmentTypes.ClinicalLaboratoryDepartment
                },
                new DIDepartmentType()
                {
                    Id = (int)DepartmentTypes.PharmacyDepartment,
                    Code = "DUOC",
                    Name = "Khoa dược",
                    SortOrder = (int)DepartmentTypes.PharmacyDepartment
                },
                new DIDepartmentType()
                {
                    Id = (int)DepartmentTypes.ComprehensivePlan,
                    Code = "KHTH",
                    Name = "Kế hoạch tổng hợp",
                    SortOrder = (int)DepartmentTypes.ComprehensivePlan
                });
        }
    }
}
