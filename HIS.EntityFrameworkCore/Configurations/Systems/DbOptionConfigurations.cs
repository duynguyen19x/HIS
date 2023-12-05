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
        }
    }
}
