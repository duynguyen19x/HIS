using HIS.Core.Enums;
using HIS.EntityFrameworkCore.Entities.Dictionary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DIPatientObjectTypeConfiguration : IEntityTypeConfiguration<PatientObjectType>
    {
        public void Configure(EntityTypeBuilder<PatientObjectType> builder)
        {
            builder.HasData(
                new PatientObjectType() { Id = (int)DIPatientObjectType.BH, Code = "BHYT", Name = "Bảo hiểm y tế", SortOrder = 1 },
                new PatientObjectType() { Id = (int)DIPatientObjectType.VP, Code = "VP", Name = "Viện phí", SortOrder = 2 },
                new PatientObjectType() { Id = (int)DIPatientObjectType.DV, Code = "DV", Name = "Dịch vụ", SortOrder = 3 },
                new PatientObjectType() { Id = (int)DIPatientObjectType.NG, Code = "NG", Name = "Người nước ngoài", SortOrder = 4 },
                new PatientObjectType() { Id = (int)DIPatientObjectType.MP, Code = "MP", Name = "Miễn phí", SortOrder = 5  }
            );
        }
    }
}
