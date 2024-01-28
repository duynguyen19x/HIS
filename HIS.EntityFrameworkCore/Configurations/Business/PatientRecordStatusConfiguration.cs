using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class PatientRecordStatusConfiguration : IEntityTypeConfiguration<PatientRecordStatus>
    {
        public void Configure(EntityTypeBuilder<PatientRecordStatus> builder)
        {
            builder.ToTable("BUS_PatientRecordStatus");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PatientRecordStatusName).HasMaxLength(128);
            builder.Property(x => x.Description).HasMaxLength(255);

            builder.HasData(
                new PatientRecordStatus { Id = 1, PatientRecordStatusName = "Mới", SortOrder = 1 },
                new PatientRecordStatus { Id = 2, PatientRecordStatusName = "Đang điều trị", SortOrder = 2 },
                new PatientRecordStatus { Id = 3, PatientRecordStatusName = "Kết thúc", SortOrder = 3 }
                );
        }
    }
}
