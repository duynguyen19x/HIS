using HIS.EntityFrameworkCore.Entities.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations
{
    public class GenderConfiguration : IEntityTypeConfiguration<SGender>
    {
        public void Configure(EntityTypeBuilder<SGender> builder)
        {
            builder.ToTable("SGenders");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(50);
        }
    }
}
