using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class AccountingBookConfiguration : IEntityTypeConfiguration<AccountingBook>
    {
        public void Configure(EntityTypeBuilder<AccountingBook> builder)
        {
            builder.ToTable("AccountBook");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
            builder.Property(x => x.TemplateCode).HasMaxLength(20);
            builder.Property(x => x.SymbolCode).HasMaxLength(20);
            builder.Property(x => x.Description).HasMaxLength(255);
            builder.Property(x => x.TransactionTypeList).HasMaxLength(500);
        }
    }
}
