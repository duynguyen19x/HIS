﻿using HIS.Core.Enums;
using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class PatientObjectTypeConfiguration : IEntityTypeConfiguration<PatientObjectType>
    {
        public void Configure(EntityTypeBuilder<PatientObjectType> builder)
        {
            builder.HasData(
                new PatientObjectType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)DIPatientObjectType.BH, Code = "BHYT", Name = "Bảo hiểm y tế", SortOrder = 1 },
                new PatientObjectType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)DIPatientObjectType.VP, Code = "VP", Name = "Viện phí", SortOrder = 2 },
                new PatientObjectType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)DIPatientObjectType.DV, Code = "DV", Name = "Dịch vụ", SortOrder = 3 },
                new PatientObjectType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)DIPatientObjectType.NG, Code = "NG", Name = "Người nước ngoài", SortOrder = 4 },
                new PatientObjectType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)DIPatientObjectType.MP, Code = "MP", Name = "Miễn phí", SortOrder = 5 }
            );
        }
    }
}
