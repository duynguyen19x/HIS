using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class TransferReasonConfiguration : IEntityTypeConfiguration<TransferReason>
    {
        public void Configure(EntityTypeBuilder<TransferReason> builder)
        {
            builder.HasData(
                new TransferReason { Id = new Guid("D6FA811F-0EA0-4303-BB6C-6BDCB7D18970"), Code = "4", Name = "Chuyển người bệnh đi các tuyến khi đủ điều kiện", SortOrder = 1 },
                new TransferReason { Id = new Guid("14F21E7E-54D2-40AF-AB18-417468E1CADB"), Code = "5", Name = "Chuyển theo yêu cầu của người bệnh hoặc đại diện hợp pháp của người bệnh", SortOrder = 2 }
                );
        }
    }
}
