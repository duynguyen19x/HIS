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
    public class PatientObjectTypeConfiguration : IEntityTypeConfiguration<PatientObjectType>
    {
        public void Configure(EntityTypeBuilder<PatientObjectType> builder)
        {
            builder.ToTable("PatientObjectType");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PatientObjectTypeCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.PatientObjectTypeName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);


            builder.HasData(
                new PatientObjectType((int)PatientObjectTypes.BHYT, "Bảo hiểm y tế", 1),
                new PatientObjectType((int)PatientObjectTypes.VP, "Viện phí", 2),
                new PatientObjectType((int)PatientObjectTypes.DV, "Dịch vụ", 3)
            );
        }
    }
}
