using HIS.Core.Enums;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class TreatmentResultTypeConfiguration : IEntityTypeConfiguration<TreatmentResult>
    {
        public void Configure(EntityTypeBuilder<TreatmentResult> builder)
        {
            builder.HasData(
                new TreatmentResult() { Id = (int)DITreatmentResultType.KHOI, Code = DITreatmentResultType.KHOI.ToString(), Name = "Khỏi", SortOrder = 1 },
                new TreatmentResult() { Id = (int)DITreatmentResultType.DO_GIAM, Code = DITreatmentResultType.DO_GIAM.ToString(), Name = "Đỡ, giảm", SortOrder = 2 },
                new TreatmentResult() { Id = (int)DITreatmentResultType.KHONGTHAYDOI, Code = DITreatmentResultType.KHONGTHAYDOI.ToString(), Name = "Không thay đổi", SortOrder = 3 },
                new TreatmentResult() { Id = (int)DITreatmentResultType.NANGHON, Code = DITreatmentResultType.NANGHON.ToString(), Name = "Nặng hơn", SortOrder = 4 },
                new TreatmentResult() { Id = (int)DITreatmentResultType.TUVONG, Code = DITreatmentResultType.TUVONG.ToString(), Name = "Tử vong", SortOrder = 5 },
                new TreatmentResult() { Id = (int)DITreatmentResultType.KHAC, Code = DITreatmentResultType.KHAC.ToString(), Name = "Khác", SortOrder = 6 }
                );
        }
    }
}
