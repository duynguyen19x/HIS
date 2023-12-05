using HIS.EntityFrameworkCore.Entities.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Services
{
    public class ServiceGroupConfigurations : IEntityTypeConfiguration<ServiceGroup>
    {
        public void Configure(EntityTypeBuilder<ServiceGroup> builder)
        {
            builder.ToTable("ServiceGroups");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);
        }
    }
}
