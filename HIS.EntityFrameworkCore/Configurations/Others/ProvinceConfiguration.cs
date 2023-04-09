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
    internal class ProvinceConfiguration : IEntityTypeConfiguration<SProvince>
    {
        public void Configure(EntityTypeBuilder<SProvince> builder)
        {
            builder.ToTable("SProvinces");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);

            builder.HasOne(t => t.National).WithMany(pc => pc.Provinces)
               .HasForeignKey(pc => pc.NationalId);
        }
    }
}
