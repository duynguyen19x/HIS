using HIS.EntityFrameworkCore.Entities.Categories.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Services
{
    public  class ServiceGroupHeInConfigurations : IEntityTypeConfiguration<ServiceGroupHeIn>
    {
        public void Configure(EntityTypeBuilder<ServiceGroupHeIn> builder)
        {
            builder.ToTable("ServiceGroupHeIns");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);
        }
    }
}
