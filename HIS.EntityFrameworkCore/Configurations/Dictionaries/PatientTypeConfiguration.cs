using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System.Reflection.Emit;
using HIS.Core.Enums;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class PatientTypeConfiguration : IEntityTypeConfiguration<PatientType>
    {
        public void Configure(EntityTypeBuilder<PatientType> builder)
        {
            builder.ToTable("PatientType");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PatientTypeCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.PatientTypeName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);


            builder.HasData(
                new PatientType((int)PatientTypes.BHYT, "Bảo hiểm y tế", 1),
                new PatientType((int)PatientTypes.VP, "Viện phí", 2),
                new PatientType((int)PatientTypes.DV, "Dịch vụ", 3)
            );
        }
    }
}
