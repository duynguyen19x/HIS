using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.DepartmentCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.DepartmentName).HasMaxLength(512).IsRequired();
            builder.Property(x => x.MohCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasOne(t => t.DepartmentType).WithMany().HasForeignKey(p => p.DepartmentTypeId);
            builder.HasOne(t => t.Branch).WithMany().HasForeignKey(p => p.BranchId);
        }
    }
}
