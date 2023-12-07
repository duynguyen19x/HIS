using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class MedicalRecordStatusConfiguration : IEntityTypeConfiguration<MedicalRecordStatus>
    {
        public void Configure(EntityTypeBuilder<MedicalRecordStatus> builder)
        {
            builder.ToTable("BUS_MedicalRecordStatus");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MedicalRecordStatusName).HasMaxLength(128);
            builder.Property(x => x.Description).HasMaxLength(255);

            //builder.HasData(
            //    new PatientRecordStatus { Id = 1, PatientRecordStatusName = "Mới", SortOrder = 1, CreatedDate = SqlDateTimeExtensions.MinValue },
            //    new PatientRecordStatus { Id = 2, PatientRecordStatusName = "Đang điều trị", SortOrder = 2, CreatedDate = SqlDateTimeExtensions.MinValue },
            //    new PatientRecordStatus { Id = 3, PatientRecordStatusName = "Kết thúc", SortOrder = 3, CreatedDate = SqlDateTimeExtensions.MinValue }
            //    );
        }
    }
}
