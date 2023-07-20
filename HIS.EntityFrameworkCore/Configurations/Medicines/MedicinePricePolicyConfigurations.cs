using HIS.EntityFrameworkCore.Entities.Categories.Services;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.EntityFrameworkCore.Entities.Categories.Medicines;

namespace HIS.EntityFrameworkCore.Configurations.Medicines
{
    public class MedicinePricePolicyConfigurations : IEntityTypeConfiguration<SMedicinePricePolicy>
    {
        public void Configure(EntityTypeBuilder<SMedicinePricePolicy> builder)
        {
            builder.ToTable("SMedicinePricePolicies");
            builder.HasKey(x => x.Id);

            builder.HasOne(t => t.SPatientType)
                .WithMany(pc => pc.SMedicinePricePolicies)
                .HasForeignKey(pc => pc.PatientTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.SMedicine)
                .WithMany(pc => pc.SMedicinePricePolicies)
                .HasForeignKey(pc => pc.MedicineId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
