using HIS.EntityFrameworkCore.Entities.Systems;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations
{
    public class PermissionConfigurations : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.ToTable("SYS_Permission");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(100);
            builder.Property(x => x.Name).HasMaxLength(500);
        }
    }
}
