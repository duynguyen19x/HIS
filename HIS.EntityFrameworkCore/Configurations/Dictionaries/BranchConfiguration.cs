using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class BranchConfiguration : IEntityTypeConfiguration<SBranch>
    {
        public void Configure(EntityTypeBuilder<SBranch> builder)
        {
            builder.ToTable("SBranchs");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired(); ;
            builder.Property(x => x.Name).HasMaxLength(512).IsRequired(); ;
            builder.Property(x => x.Address).HasMaxLength(1024);
            builder.Property(x => x.Description).HasMaxLength(512);
        }
    }
}
