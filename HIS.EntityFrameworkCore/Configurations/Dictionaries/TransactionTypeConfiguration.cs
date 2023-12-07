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

            
        }
    }
}
