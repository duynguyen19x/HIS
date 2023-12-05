using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class TransferReasonConfiguration : IEntityTypeConfiguration<TransferReason>
    {
        public void Configure(EntityTypeBuilder<TransferReason> builder)
        {
            builder.ToTable("TransferReason");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TransferReasonCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.TransferReasonName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);

            //builder.HasData(
            //    new TransferReason { Id = new Guid("D6FA811F-0EA0-4303-BB6C-6BDCB7D18970"), TransferReasonCode = "4", TransferReasonName = "Chuyển người bệnh đi các tuyến khi đủ điều kiện", SortOrder = 1, CreatedDate = SqlDateTimeExtensions.MinValue },
            //    new TransferReason { Id = new Guid("14F21E7E-54D2-40AF-AB18-417468E1CADB"), TransferReasonCode = "5", TransferReasonName = "Chuyển theo yêu cầu của người bệnh hoặc đại diện hợp pháp của người bệnh", SortOrder = 2, CreatedDate = SqlDateTimeExtensions.MinValue }
            //    );
        }
    }
}
