using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.ToTable("Branch");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.BranchCode).HasMaxLength(50).IsRequired(); 
            builder.Property(x => x.BranchName).HasMaxLength(255).IsRequired(); 
            builder.Property(x => x.MediOrgCode).HasMaxLength(20);
            builder.Property(x => x.MediOrgAcceptCode).HasMaxLength(4000);
            builder.Property(x => x.Level).HasMaxLength(20);
            builder.Property(x => x.Type).HasMaxLength(20);
            builder.Property(x => x.Line).HasMaxLength(20);
            builder.Property(x => x.ParentOrganizationName).HasMaxLength(20);
            builder.Property(x => x.Tel).HasMaxLength(20);
            builder.Property(x => x.Address).HasMaxLength(512);
            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasOne(x => x.Province).WithMany().HasForeignKey(pc => pc.ProvinceId);
            builder.HasOne(x => x.District).WithMany().HasForeignKey(pc => pc.DistrictId);
            builder.HasOne(x => x.Ward).WithMany().HasForeignKey(pc => pc.WardId);
        }
    }
}
