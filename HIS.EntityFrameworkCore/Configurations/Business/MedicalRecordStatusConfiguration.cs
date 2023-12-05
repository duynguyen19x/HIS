using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class MedicalRecordStatusConfiguration : IEntityTypeConfiguration<MedicalRecordStatus>
    {
        public void Configure(EntityTypeBuilder<MedicalRecordStatus> builder)
        {
            builder.ToTable("MedicalRecordStatus");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MedicalRecordStatusName).HasMaxLength(128);
            builder.Property(x => x.Description).HasMaxLength(255);

            builder.HasData(
                new MedicalRecordStatus { Id = 1, MedicalRecordStatusName = "Mới", SortOrder = 1, CreatedDate = SqlDateTimeExtensions.MinValue },
                new MedicalRecordStatus { Id = 2, MedicalRecordStatusName = "Đang điều trị", SortOrder = 2, CreatedDate = SqlDateTimeExtensions.MinValue },
                new MedicalRecordStatus { Id = 3, MedicalRecordStatusName = "Kết thúc", SortOrder = 3, CreatedDate = SqlDateTimeExtensions.MinValue }
                );
        }
    }
}
