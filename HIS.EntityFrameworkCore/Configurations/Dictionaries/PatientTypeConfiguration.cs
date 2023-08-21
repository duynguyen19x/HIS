using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class PatientTypeConfiguration : IEntityTypeConfiguration<SPatientType>
    {
        public void Configure(EntityTypeBuilder<SPatientType> builder)
        {
            builder.ToTable("SPatientTypes");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(250);
            builder.Property(x => x.Description).HasMaxLength(512);
        }
    }
}
