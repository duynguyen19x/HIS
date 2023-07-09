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
    public class ServiceConfigurations : IEntityTypeConfiguration<SService>
    {
        public void Configure(EntityTypeBuilder<SService> builder)
        {
            builder.ToTable("SServices");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);
            builder.Property(x => x.HeInCode).HasMaxLength(50);
            builder.Property(x => x.HeInName).HasMaxLength(500);

            builder.HasOne(t => t.SServiceUnit).WithMany(pc => pc.SServices).HasForeignKey(pc => pc.ServiceUnitId).OnDelete(DeleteBehavior.Restrict); 
            builder.HasOne(t => t.SServiceGroup).WithMany(pc => pc.SServices).HasForeignKey(pc => pc.ServiceGroupId).OnDelete(DeleteBehavior.Restrict); 
            builder.HasOne(t => t.SServiceGroupHeIn).WithMany(pc => pc.SServices).HasForeignKey(pc => pc.ServiceGroupHeInId).OnDelete(DeleteBehavior.Restrict); 
            builder.HasOne(t => t.SSurgicalProcedureType).WithMany(pc => pc.SServices).HasForeignKey(pc => pc.SurgicalProcedureTypeId).OnDelete(DeleteBehavior.Restrict); 
        }
    }
}
