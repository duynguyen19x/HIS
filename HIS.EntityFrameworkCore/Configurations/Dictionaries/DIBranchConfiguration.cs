using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DIBranchConfiguration : IEntityTypeConfiguration<DIBranch>
    {
        public void Configure(EntityTypeBuilder<DIBranch> builder)
        {
            builder.ToTable("DIBranch");
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

            builder.HasOne(x => x.ProvinceFk).WithMany().HasForeignKey(pc => pc.ProvinceID);
            builder.HasOne(x => x.DistrictFk).WithMany().HasForeignKey(pc => pc.DistrictID);
            builder.HasOne(x => x.WardFk).WithMany().HasForeignKey(pc => pc.WardID);
        }
    }
}
