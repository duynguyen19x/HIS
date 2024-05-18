using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {

            builder.HasData(
                new PaymentMethod { Id = new Guid("8BFF9824-1DF2-419E-88AB-E098A6FC4E7E"), Code = "TM", Name = "Tiền mặt", SortOrder = 1 },
                new PaymentMethod { Id = new Guid("DD39AFC0-1DE0-4287-A126-4DADA6788508"), Code = "CK", Name = "Chuyển khoản", SortOrder = 2 },
                new PaymentMethod { Id = new Guid("0B348363-C888-4C9A-B145-C3389FDCCA37"), Code = "TM/CK", Name = "Tiền mặt hoặc chuyển khoản", SortOrder = 3 }
                );
        }
    }
}
