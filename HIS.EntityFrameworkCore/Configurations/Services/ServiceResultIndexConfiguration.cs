using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Services
{
    public class ServiceResultIndexConfiguration : IEntityTypeConfiguration<SServiceResultIndice>
    {
        public void Configure(EntityTypeBuilder<SServiceResultIndice> builder)
        {
            builder.ToTable("SServiceResultIndices");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);
            builder.Property(x => x.Unit).HasMaxLength(100);

            builder.HasOne(t => t.SService).WithMany(pc => pc.SServiceResultIndices).HasForeignKey(pc => pc.ServiceId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
