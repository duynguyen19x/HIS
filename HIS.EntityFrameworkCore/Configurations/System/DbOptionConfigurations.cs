using HIS.EntityFrameworkCore.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Systems
{
    public class DbOptionConfigurations : IEntityTypeConfiguration<DbOption>
    {
        public void Configure(EntityTypeBuilder<DbOption> builder)
        {
            builder.ToTable("SYS_DbOption");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.DbOptionId).HasMaxLength(128);
            builder.Property(x => x.DbOptionValue).HasMaxLength(256);
            builder.Property(x => x.Description).HasMaxLength(512);
        }
    }
}
