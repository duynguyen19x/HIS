using HIS.EntityFrameworkCore.Constants;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class PatientRecordTypeConfiguration : IEntityTypeConfiguration<PatientRecordType>
    {
        public void Configure(EntityTypeBuilder<PatientRecordType> builder)
        {
            builder.ToTable("DIC_PatientRecordType");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PatientRecordTypeCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.PatientRecordTypeName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);


            builder.HasData(
                new PatientRecordType { Id = PatientRecordTypeConst.NGOAI_TRU, PatientRecordTypeCode = PatientRecordTypeConst.NGOAI_TRU.ToString(), PatientRecordTypeName = "Ngoại trú", SortOrder = 1 },
                new PatientRecordType { Id = PatientRecordTypeConst.NOI_TRU, PatientRecordTypeCode = PatientRecordTypeConst.NOI_TRU.ToString(), PatientRecordTypeName = "Nội trú", SortOrder = 2 },
                new PatientRecordType { Id = PatientRecordTypeConst.DICH_VU, PatientRecordTypeCode = PatientRecordTypeConst.DICH_VU.ToString(), PatientRecordTypeName = "Dịch vụ", SortOrder = 3 }
            );
        }
    }
}
