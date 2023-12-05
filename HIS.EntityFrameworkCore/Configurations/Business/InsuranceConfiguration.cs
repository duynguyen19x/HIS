using HIS.EntityFrameworkCore.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class InsuranceConfiguration : IEntityTypeConfiguration<Insurance>
    {
        public void Configure(EntityTypeBuilder<Insurance> builder)
        {
            builder.ToTable("Insurance");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.InsuranceCode).HasMaxLength(50).IsRequired();
            builder.Property(x => x.MediOrgCode).HasMaxLength(20);
            builder.Property(x => x.MediOrgName).HasMaxLength(512);
            builder.Property(x => x.Address).HasMaxLength(512);

            builder.HasOne(e => e.LiveArea).WithMany().HasForeignKey(e => e.LiveAreaId);
            builder.HasOne(e => e.RightRouteType).WithMany().HasForeignKey(e => e.RightRouteTypeId);
            builder.HasOne(e => e.Patient).WithMany().HasForeignKey(e => e.PatientId);
            builder.HasOne(e => e.PatientRecord).WithMany().HasForeignKey(e => e.PatientRecordId);
        }
    }
}
