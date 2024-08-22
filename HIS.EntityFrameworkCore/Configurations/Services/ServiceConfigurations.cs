using HIS.EntityFrameworkCore.Entities.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations
{
    public class ServiceConfigurations : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("SServices");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);
            builder.Property(x => x.HeInCode).HasMaxLength(50);
            builder.Property(x => x.HeInName).HasMaxLength(500);

            builder.HasOne(t => t.Unit).WithMany().HasForeignKey(pc => pc.UnitId); 
            builder.HasOne(t => t.ServiceGroup).WithMany().HasForeignKey(pc => pc.ServiceGroupId); 
            builder.HasOne(t => t.ServiceGroupHeIn).WithMany().HasForeignKey(pc => pc.ServiceGroupHeInId); 
            builder.HasOne(t => t.SurgicalProcedureType).WithMany().HasForeignKey(pc => pc.SurgicalProcedureTypeId); 
        }
    }
}
