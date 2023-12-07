using HIS.Core.Enums;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class PatientTypeConfiguration : IEntityTypeConfiguration<PatientType>
    {
        public void Configure(EntityTypeBuilder<PatientType> builder)
        {
            builder.ToTable("DIC_PatientType");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PatientTypeCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.PatientTypeName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);


            builder.HasData(
                new PatientType((int)PatientTypes.BHYT, "Bảo hiểm y tế", 1),
                new PatientType((int)PatientTypes.VP, "Viện phí", 2),
                new PatientType((int)PatientTypes.DV, "Dịch vụ", 3),
                new PatientType((int)PatientTypes.NGUOI_NUOC_NGOAI, "Người nước ngoài", 4),
                new PatientType((int)PatientTypes.MIEN_PHI, "Miễn phí", 5)
            );
        }
    }
}
