using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.EntityFrameworkCore.Entities.Business;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            //builder.Property(x => x.Code).HasMaxLength(20).IsRequired();
            //builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
            //builder.Property(x => x.Description).HasMaxLength(255);
        }
    }
}
