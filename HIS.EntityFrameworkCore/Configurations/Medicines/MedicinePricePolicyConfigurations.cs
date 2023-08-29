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
    public class MedicinePricePolicyConfigurations : IEntityTypeConfiguration<MedicinePricePolicy>
    {
        public void Configure(EntityTypeBuilder<MedicinePricePolicy> builder)
        {
            builder.ToTable("MedicinePricePolicies");
            builder.HasKey(x => x.Id);

            builder.HasOne(t => t.PatientType)
                .WithMany()
                .HasForeignKey(pc => pc.PatientTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(t => t.Medicine)
                .WithMany()
                .HasForeignKey(pc => pc.MedicineId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
