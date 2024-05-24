using HIS.EntityFrameworkCore.Constants;
using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class MedicalRecordConfig : IEntityTypeConfiguration<MedicalRecord>
    {
        public void Configure(EntityTypeBuilder<MedicalRecord> builder)
        {
            builder.ToTable("DMedicalRecord");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.MedicalRecordCode).IsRequired().HasMaxLength(MedicalRecordConst.MedicalRecordCodeLength);

            builder.HasOne<Patient>().WithMany().HasForeignKey(x => x.PatientId);
        }
    }
}
