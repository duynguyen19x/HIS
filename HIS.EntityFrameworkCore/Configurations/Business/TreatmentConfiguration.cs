using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.EntityFrameworkCore.Entities.Business.Patients;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class TreatmentConfiguration : IEntityTypeConfiguration<STreatment>
    {
        public void Configure(EntityTypeBuilder<STreatment> builder)
        {
            builder.ToTable("STreatments");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired();
            builder.Property(x => x.PatientId).IsRequired();
            builder.Property(x=>x.Year).IsRequired();
            builder.Property(x=>x.InTimeClinical).IsRequired();
            builder.Property(x=>x.GenderId).IsRequired();
            builder.Property(x => x.Address).HasMaxLength(1024);
            //builder.Property(x => x.IdentificationNumber).HasMaxLength(50);
            //builder.Property(x => x.PhoneNumber).HasMaxLength(50);
            //builder.Property(x => x.RelateName).HasMaxLength(254);
            //builder.Property(x => x.RelateIdentificationNumber).HasMaxLength(50);
            //builder.Property(x => x.RelatePhoneNumbar).HasMaxLength(50);
        }
    }
}
