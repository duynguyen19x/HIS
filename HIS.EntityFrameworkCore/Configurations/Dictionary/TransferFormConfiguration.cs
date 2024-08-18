using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class TransferFormConfiguration : IEntityTypeConfiguration<TransferForm>
    {
        public void Configure(EntityTypeBuilder<TransferForm> builder)
        {
            builder.HasData(
                new TransferForm { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("FAF04FDE-6DC1-4D6A-B5D8-B9000BB4F6BD"), Code = "1a", Name = "1a: Chuyển người bệnh từ tuyến dưới lên tuyến trên liền kề", SortOrder = 1 },
                new TransferForm { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("B882E676-A760-4468-A687-600770326AAC"), Code = "1b", Name = "1b: Chuyển người bệnh từ tuyến dưới lên tuyến trên không qua tuyến liền kề", SortOrder = 2 },
                new TransferForm { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("48CAC582-B5F8-4F12-BB5B-5F35CA4FCAC1"), Code = "2", Name = "2. Chuyển người bệnh từ tuyến trên về tuyến dưới", SortOrder = 3 },
                new TransferForm { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("32848BDE-D01C-4D6B-B3A0-2104DF2D801C"), Code = "3", Name = "3. Chuyển người bệnh giữa các cơ sở khám bệnh, chữa bệnh trong cùng tuyến", SortOrder = 4 }
                );
        }
    }
}
