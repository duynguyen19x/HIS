using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DIDepartmentConfiguration : IEntityTypeConfiguration<DIDepartment>
    {
        public void Configure(EntityTypeBuilder<DIDepartment> builder)
        {
            builder.ToTable("DIC_Department");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(512).IsRequired();
            builder.Property(x => x.MediCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasOne(t => t.DepartmentTypeFk).WithMany().HasForeignKey(p => p.DepartmentTypeID);
            builder.HasOne(t => t.BranchFk).WithMany().HasForeignKey(p => p.BranchId);
        }
    }
}
