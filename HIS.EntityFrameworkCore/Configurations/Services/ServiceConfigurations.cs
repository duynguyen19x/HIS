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
    public class ServiceConfigurations : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Services");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);
            builder.Property(x => x.HeInCode).HasMaxLength(50);
            builder.Property(x => x.HeInName).HasMaxLength(500);

            builder.HasOne(t => t.Unit).WithMany().HasForeignKey(pc => pc.UnitId).OnDelete(DeleteBehavior.NoAction); 
            builder.HasOne(t => t.ServiceGroup).WithMany().HasForeignKey(pc => pc.ServiceGroupId).OnDelete(DeleteBehavior.NoAction); 
            builder.HasOne(t => t.ServiceGroupHeIn).WithMany().HasForeignKey(pc => pc.ServiceGroupHeInId).OnDelete(DeleteBehavior.NoAction); 
            builder.HasOne(t => t.SurgicalProcedureType).WithMany().HasForeignKey(pc => pc.SurgicalProcedureTypeId).OnDelete(DeleteBehavior.NoAction); 
        }
    }
}
