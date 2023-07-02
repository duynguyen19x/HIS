using HIS.EntityFrameworkCore.Entities.Business.Patients;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Patients
{
    public class PatientConfiguration : IEntityTypeConfiguration<SPatient>
    {
        public void Configure(EntityTypeBuilder<SPatient> builder)
        {
            builder.ToTable("SPatients");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.FullName).HasMaxLength(500);
            builder.Property(x => x.FirstName).HasMaxLength(50);
            builder.Property(x => x.LastName).HasMaxLength(50);
            builder.Property(x => x.Address).HasMaxLength(50);
            builder.Property(x => x.Mobile).HasMaxLength(20);
            builder.Property(x => x.PhoneNumber).HasMaxLength(20);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.IdentificationNumber).HasMaxLength(50);
            builder.Property(x => x.IdentificationNumberIssuedBy).HasMaxLength(250);
            builder.Property(x => x.TaxCode).HasMaxLength(50);
            builder.Property(x => x.PatientFather).HasMaxLength(150);
            builder.Property(x => x.FatherEducationalLevel).HasMaxLength(150);
            builder.Property(x => x.PatientMother).HasMaxLength(150);
            builder.Property(x => x.MotherEducationalLevel).HasMaxLength(150);
            builder.Property(x => x.PassPortNumber).HasMaxLength(50);
            builder.Property(x => x.PassPortIssuedBy).HasMaxLength(250);
            builder.Property(x => x.RelativeName).HasMaxLength(250);
            builder.Property(x => x.RelativeAddress).HasMaxLength(512);
            builder.Property(x => x.RelativeIdentificationNumber).HasMaxLength(128);
            builder.Property(x => x.RelativePhoneNumbar).HasMaxLength(56);

            builder.HasOne(t => t.Gender).WithMany(pc => pc.SPatients).HasForeignKey(pc => pc.GenderId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.PatientType).WithMany(pc => pc.SPatients).HasForeignKey(pc => pc.PatientTypeId).OnDelete(DeleteBehavior.Restrict); 
        }
    }
}
