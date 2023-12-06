using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class TransferFormConfiguration : IEntityTypeConfiguration<TransferForm>
    {
        public void Configure(EntityTypeBuilder<TransferForm> builder)
        {
            builder.ToTable("TransferForms");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TransferFormCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.TransferFormName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);

            builder.HasData(
                new TransferForm { Id = new Guid("1442D51A-072C-49A4-A5A5-2E5C8FBD25F9"), TransferFormCode = "1a", TransferFormName = "Chuyển người bệnh từ tuyến dưới lên tuyến trên liền kề (theo trình tự)", SortOrder = 1, CreatedDate = SqlDateTimeExtensions.MinValue },
                new TransferForm { Id = new Guid("435E227F-FCF6-4400-8E6F-B19ED91A7145"), TransferFormCode = "1b", TransferFormName = "Chuyển người bệnh từ tuyến dưới lên tuyến trên không qua tuyến liền kề (không theo trình tự)", SortOrder = 2, CreatedDate = SqlDateTimeExtensions.MinValue },
                new TransferForm { Id = new Guid("D103F775-FF29-47ED-AA1D-6D847A2153F0"), TransferFormCode = "2", TransferFormName = "Chuyển người bệnh từ tuyến trên về tuyến dưới", SortOrder = 3, CreatedDate = SqlDateTimeExtensions.MinValue },
                new TransferForm { Id = new Guid("2BD53019-A0BD-4491-A65B-A675228B1A7F"), TransferFormCode = "3", TransferFormName = "Chuyển người bệnh giữa các cơ sở khám bệnh, chữa bệnh trong cùng tuyến", SortOrder = 4, CreatedDate = SqlDateTimeExtensions.MinValue }
                );
        }
    }
}
