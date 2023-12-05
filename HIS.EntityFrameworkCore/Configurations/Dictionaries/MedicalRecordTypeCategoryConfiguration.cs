using HIS.Core.Enums;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class MedicalRecordTypeCategoryConfiguration : IEntityTypeConfiguration<MedicalRecordTypeGroup>
    {
        public void Configure(EntityTypeBuilder<MedicalRecordTypeGroup> builder)
        {
            builder.ToTable("MedicalRecordTypeCategory");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.MedicalRecordTypeGroupCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.MedicalRecordTypeGroupName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);

            builder.HasData(
                new MedicalRecordTypeGroup((int)MedicalRecordTypeGroups.DTRI_NOITRU, "Nội trú", 1),
                new MedicalRecordTypeGroup((int)MedicalRecordTypeGroups.DTRI_NGOAITRU, "Ngoại trú", 2),
                new MedicalRecordTypeGroup((int)MedicalRecordTypeGroups.KHAMBENH, "Khám bệnh", 3)
                );
        }
    }
}
