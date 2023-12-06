using HIS.EntityFrameworkCore.Entities.Systems;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Systems
{
    public class DbOptionConfigurations : IEntityTypeConfiguration<DbOption>
    {
        public void Configure(EntityTypeBuilder<DbOption> builder)
        {
            builder.ToTable("DbOptions");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.DbOptionId).HasMaxLength(128);
            builder.Property(x => x.DbOptionValue).HasMaxLength(256);
            builder.Property(x => x.Description).HasMaxLength(512);
        }
    }
}
