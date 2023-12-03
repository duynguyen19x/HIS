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
    public class PatientRecordConfiguration : IEntityTypeConfiguration<PatientRecord>
    {
        public void Configure(EntityTypeBuilder<PatientRecord> builder)
        {
            builder.ToTable("PatientRecord");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PatientRecordCode).HasMaxLength(20);
            builder.Property(x => x.PatientName).HasMaxLength(255);
            builder.Property(x => x.Birthplace).HasMaxLength(512);
            builder.Property(x => x.Address).HasMaxLength(512);
            builder.Property(x => x.Workplace).HasMaxLength(512);
            builder.Property(x => x.IdentificationNumber).HasMaxLength(20);
            builder.Property(x => x.IssueBy).HasMaxLength(128);
            builder.Property(x => x.Tel).HasMaxLength(20);
            builder.Property(x => x.Mobile).HasMaxLength(20);
            builder.Property(x => x.Email).HasMaxLength(128);

            builder.HasOne(e => e.Gender).WithMany().HasForeignKey(e => e.GenderId);
            builder.HasOne(e => e.Ethnic).WithMany().HasForeignKey(e => e.EthnicId);
            builder.HasOne(e => e.Religion).WithMany().HasForeignKey(e => e.ReligionId);
            builder.HasOne(e => e.National).WithMany().HasForeignKey(e => e.NationalId);
            builder.HasOne(e => e.Province).WithMany().HasForeignKey(e => e.ProvinceId);
            builder.HasOne(e => e.District).WithMany().HasForeignKey(e => e.DistrictId);
            builder.HasOne(e => e.Ward).WithMany().HasForeignKey(e => e.WardId);
            builder.HasOne(e => e.Career).WithMany().HasForeignKey(e => e.CareerId);
        }
    }
}
