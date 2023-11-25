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
    public class RelativeConfiguration : IEntityTypeConfiguration<Relative>
    {
        public void Configure(EntityTypeBuilder<Relative> builder)
        {
            builder.ToTable("Relative");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.RelativeName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.IdentificationNumber).HasMaxLength(20);
            builder.Property(x => x.IssueBy).HasMaxLength(128);
            builder.Property(x => x.Tel).HasMaxLength(20);
            builder.Property(x => x.Mobile).HasMaxLength(20);
            builder.Property(x => x.Address).HasMaxLength(255);

            builder.HasOne(t => t.RelativeCategory).WithMany().HasForeignKey(p => p.RelativeCategoryID);
            builder.HasOne(t => t.PatientRecord).WithMany().HasForeignKey(p => p.PatientRecordID);
        }
    }
}
