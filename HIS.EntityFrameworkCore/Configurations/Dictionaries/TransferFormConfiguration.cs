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
    public class TransferFormConfiguration : IEntityTypeConfiguration<TransferForm>
    {
        public void Configure(EntityTypeBuilder<TransferForm> builder)
        {
            builder.ToTable("TransferForm");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TransferFormCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.TransferFormName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);

            
        }
    }
}
