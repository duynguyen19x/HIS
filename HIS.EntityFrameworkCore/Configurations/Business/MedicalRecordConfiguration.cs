using HIS.EntityFrameworkCore.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class MedicalRecordConfiguration : IEntityTypeConfiguration<MedicalRecord>
    {
        public void Configure(EntityTypeBuilder<MedicalRecord> builder)
        {
            builder.ToTable("MedicalRecord");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MedicalRecordCode).IsRequired().HasMaxLength(20);
            builder.Property(x => x.PatientName).IsRequired().HasMaxLength(512);
            builder.Property(x => x.BirthYear);
            builder.Property(x => x.Birthplace).HasMaxLength(512);
            builder.Property(x => x.Address).HasMaxLength(512);
            builder.Property(x => x.Tel).HasMaxLength(20);
            builder.Property(x => x.Mobile).HasMaxLength(20);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.IdentificationNumber).HasMaxLength(50);
            builder.Property(x => x.IssueBy).HasMaxLength(255);
            builder.Property(x => x.Workplace).HasMaxLength(255);
            
            builder.Property(x => x.HospitalizationReason).HasMaxLength(512);
            builder.Property(x => x.Description).HasMaxLength(255);

            builder.Property(x => x.TransferInCode).HasMaxLength(20);
            builder.Property(x => x.TransferInMediOrgCode).HasMaxLength(20);
            builder.Property(x => x.TransferInMediOrgName).HasMaxLength(255);
            builder.Property(x => x.TransferInIcdCode).HasMaxLength(20);
            builder.Property(x => x.TransferInIcdName).HasMaxLength(512);
            builder.Property(x => x.TransferInNote).HasMaxLength(512);

            builder.Property(x => x.IcdCode).HasMaxLength(20);
            builder.Property(x => x.IcdName).HasMaxLength(512);
            builder.Property(x => x.TraditionalIcdCode).HasMaxLength(20);
            builder.Property(x => x.TraditionalIcdName).HasMaxLength(512);

            builder.Property(x => x.ClinicalCourse).HasMaxLength(512);
            builder.Property(x => x.ParalinicalResult).HasMaxLength(512);
            builder.Property(x => x.TreatmentDirection).HasMaxLength(512);
            builder.Property(x => x.TreatmentMethod).HasMaxLength(512);
            builder.Property(x => x.Advise).HasMaxLength(512);
            builder.Property(x => x.PatientCondition).HasMaxLength(512);

            builder.Property(x => x.TransferCode).HasMaxLength(20);
            builder.Property(x => x.TransportVehicle).HasMaxLength(255);
            builder.Property(x => x.Transporter).HasMaxLength(255);

            builder.Property(x => x.AutopsyIcdCode).HasMaxLength(20);
            builder.Property(x => x.AutopsyIcdName).HasMaxLength(512);


        }
    }
}
