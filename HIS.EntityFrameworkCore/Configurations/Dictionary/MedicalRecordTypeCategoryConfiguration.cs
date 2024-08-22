using HIS.Core.Enums;
using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class MedicalRecordTypeCategoryConfiguration : IEntityTypeConfiguration<MedicalRecordTypeGroup>
    {
        public void Configure(EntityTypeBuilder<MedicalRecordTypeGroup> builder)
        {
            builder.ToTable("SMedicalRecordTypeGroups");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.MedicalRecordTypeGroupCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.MedicalRecordTypeGroupName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);

            builder.HasData(
                new MedicalRecordTypeGroup(new DateTime(2024, 1, 1), (int)MedicalRecordTypeGroups.DTRI_NOITRU, "Nội trú", 1),
                new MedicalRecordTypeGroup(new DateTime(2024, 1, 1), (int)MedicalRecordTypeGroups.DTRI_NGOAITRU, "Ngoại trú", 2),
                new MedicalRecordTypeGroup(new DateTime(2024, 1, 1), (int)MedicalRecordTypeGroups.KHAMBENH, "Khám bệnh", 3)
                );
        }
    }
}
