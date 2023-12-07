using HIS.EntityFrameworkCore.Constants;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    internal class TransactionTypeConfiguration : IEntityTypeConfiguration<TransactionType>
    {
        public void Configure(EntityTypeBuilder<TransactionType> builder) 
        {
            builder.ToTable("DIC_TransactionType");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.TransactionTypeCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.TransactionTypeName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);

            builder.HasData(
                new TransactionType(TransactionTypeConst.THU_TIEN, "Thu tiền", 1),
                new TransactionType(TransactionTypeConst.HOAN_TIEN, "Hoàn tiền", 2),
                new TransactionType(TransactionTypeConst.TAM_UNG, "Tạm ứng", 3),
                new TransactionType(TransactionTypeConst.HOAN_UNG, "Hoàn ứng", 4)
                );
        }
    }
}
