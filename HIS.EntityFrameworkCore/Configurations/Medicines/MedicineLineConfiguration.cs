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
    public class MedicineLineConfiguration : IEntityTypeConfiguration<SMedicineLine>
    {
        public void Configure(EntityTypeBuilder<SMedicineLine> builder)
        {
            builder.ToTable("SMedicineLines");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);
        }
    }
}
