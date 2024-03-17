using HIS.Core.Enums;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DIPatientObjectTypeConfiguration : IEntityTypeConfiguration<DIPatientObjectType>
    {
        public void Configure(EntityTypeBuilder<DIPatientObjectType> builder)
        {
            builder.HasData(
                new DIPatientObjectType() { Id = (int)PatientTypes.BHYT, Code = "BHYT", Name = "Bảo hiểm y tế", SortOrder = 1 },
                new DIPatientObjectType() { Id = (int)PatientTypes.VP, Code = "VP", Name = "Viện phí", SortOrder = 2 },
                new DIPatientObjectType() { Id = (int)PatientTypes.DV, Code = "DV", Name = "Dịch vụ", SortOrder = 3 },
                new DIPatientObjectType() { Id = (int)PatientTypes.NGUOI_NUOC_NGOAI, Code = "NGUOI_NUOC_NGOAI", Name = "Người nước ngoài", SortOrder = 4 },
                new DIPatientObjectType() { Id = (int)PatientTypes.MIEN_PHI, Code = "MIEN_PHI", Name = "Miễn phí", SortOrder = 5  }
            );
        }
    }
}
