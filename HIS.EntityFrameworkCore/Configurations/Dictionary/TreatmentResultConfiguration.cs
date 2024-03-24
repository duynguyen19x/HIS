using HIS.Core.Enums;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class TreatmentResultConfiguration : IEntityTypeConfiguration<TreatmentResult>
    {
        public void Configure(EntityTypeBuilder<TreatmentResult> builder)
        {
            //builder.ToTable("DIC_TreatmentResult");

            //builder.HasKey(x => x.Id);
            //builder.Property(x => x.Code).HasMaxLength(20).IsRequired();
            //builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
            //builder.Property(x => x.Description).HasMaxLength(255);

            builder.HasData(
                new TreatmentResult() { Id = (int)TreatmentResults.KHOI, Code = TreatmentResults.KHOI.ToString(), Name = "Khỏi", SortOrder = 1 },
                new TreatmentResult() { Id = (int)TreatmentResults.DO_GIAM, Code = TreatmentResults.DO_GIAM.ToString(), Name = "Đỡ, giảm", SortOrder = 2 },
                new TreatmentResult() { Id = (int)TreatmentResults.KHONGTHAYDOI, Code = TreatmentResults.KHONGTHAYDOI.ToString(), Name = "Không thay đổi", SortOrder = 3 },
                new TreatmentResult() { Id = (int)TreatmentResults.NANGHON, Code = TreatmentResults.NANGHON.ToString(), Name = "Nặng hơn", SortOrder = 4 },
                new TreatmentResult() { Id = (int)TreatmentResults.TUVONG, Code = TreatmentResults.TUVONG.ToString(), Name = "Tử vong", SortOrder = 5 },
                new TreatmentResult() { Id = (int)TreatmentResults.KHAC, Code = TreatmentResults.KHAC.ToString(), Name = "Khác", SortOrder = 6 }
                );
        }
    }
}
