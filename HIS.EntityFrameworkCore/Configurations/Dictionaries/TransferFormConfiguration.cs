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
            builder.ToTable("DIC_TransferForm");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TransferFormCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.TransferFormName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);

            
        }
    }
}
