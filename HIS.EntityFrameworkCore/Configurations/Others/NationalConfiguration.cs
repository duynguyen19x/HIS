using HIS.EntityFrameworkCore.Entities.Categories.Others;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Others
{
    public class NationalConfiguration : IEntityTypeConfiguration<SNational>
    {
        public void Configure(EntityTypeBuilder<SNational> builder)
        {
            builder.ToTable("SNationals");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);
        }
    }
}
