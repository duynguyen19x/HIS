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
            builder.Property(x => x.BranchName).HasMaxLength(512).IsRequired(); 
            builder.Property(x => x.Address).HasMaxLength(1024);
            builder.Property(x => x.Description).HasMaxLength(512);
        }
    }
}
