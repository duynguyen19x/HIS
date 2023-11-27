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
    public class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.ToTable("Gender");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.GenderCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.GenderName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);
        }
    }
}
