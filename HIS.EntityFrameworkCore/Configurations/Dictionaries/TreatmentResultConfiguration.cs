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
            builder.ToTable("DIC_TreatmentResult");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.TreatmentResultCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.TreatmentResultName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);

            //builder.HasData(
            //    new TreatmentResult() { Id = (int)TreatmentResults.KHOI, TreatmentResultCode = TreatmentResults.KHOI.ToString(), TreatmentResultName = "Khỏi", SortOrder = 1 },
            //    new TreatmentResult() { Id = (int)TreatmentResults.DO_GIAM, TreatmentResultCode = TreatmentResults.DO_GIAM.ToString(), TreatmentResultName = "Đỡ, giảm", SortOrder = 2 },
            //    new TreatmentResult() { Id = (int)TreatmentResults.KHONGTHAYDOI, TreatmentResultCode = TreatmentResults.KHONGTHAYDOI.ToString(), TreatmentResultName = "Không thay đổi", SortOrder = 3 },
            //    new TreatmentResult() { Id = (int)TreatmentResults.NANGHON, TreatmentResultCode = TreatmentResults.NANGHON.ToString(), TreatmentResultName = "Nặng hơn", SortOrder = 4 },
            //    new TreatmentResult() { Id = (int)TreatmentResults.TUVONG, TreatmentResultCode = TreatmentResults.TUVONG.ToString(), TreatmentResultName = "Tử vong", SortOrder = 5 },
            //    new TreatmentResult() { Id = (int)TreatmentResults.KHAC, TreatmentResultCode = TreatmentResults.KHAC.ToString(), TreatmentResultName = "Khác", SortOrder = 6 }
            //    );
        }
    }
}
