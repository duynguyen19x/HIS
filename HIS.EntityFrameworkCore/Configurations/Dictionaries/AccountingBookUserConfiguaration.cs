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
    public class AccountingBookUserConfiguaration : IEntityTypeConfiguration<AccountingBookUser>
    {
        public void Configure(EntityTypeBuilder<AccountingBookUser> builder)
        {
            builder.ToTable("AccountingBookUser");

            builder.HasKey(x => x.Id);
            builder.HasOne(t => t.User).WithMany().HasForeignKey(pc => pc.UserId);
            builder.HasOne(t => t.AccountingBook).WithMany().HasForeignKey(pc => pc.AccountingBookId);
        }
    }
}
