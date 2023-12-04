using HIS.EntityFrameworkCore.Entities.Categories.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Services
{
    public class SurgicalProcedureTypeConfigurations : IEntityTypeConfiguration<SurgicalProcedureType>
    {
        public void Configure(EntityTypeBuilder<SurgicalProcedureType> builder)
        {
            builder.ToTable("SurgicalProcedureTypes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);
        }
    }
}
