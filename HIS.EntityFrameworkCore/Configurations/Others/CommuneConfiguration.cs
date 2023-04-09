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
    public class CommuneConfiguration : IEntityTypeConfiguration<SCommune>
    {
        public void Configure(EntityTypeBuilder<SCommune> builder)
        {
            builder.ToTable("SCommunes");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);

            builder.HasOne(t => t.District).WithMany(pc => pc.Communes)
               .HasForeignKey(pc => pc.DistrictId);
            builder.HasOne(t => t.Province).WithMany(pc => pc.Communes)
                .HasForeignKey(pc => pc.ProvinceId);
            builder.HasOne(t => t.National).WithMany(pc => pc.Communes)
                .HasForeignKey(pc => pc.NationalId);
        }
    }
}
