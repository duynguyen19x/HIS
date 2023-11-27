using HIS.EntityFrameworkCore.Entities.Business;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable("Patient");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PatientCode).IsRequired().HasMaxLength(20);
            builder.Property(x => x.PatientName).IsRequired().HasMaxLength(512);
            builder.Property(x => x.BirthYear);
            builder.Property(x => x.Birthplace).HasMaxLength(512);
            builder.Property(x => x.GenderID).IsRequired();
            builder.Property(x => x.EthnicityID).IsRequired();
            builder.Property(x => x.ReligionID).IsRequired();
            builder.Property(x => x.CountryID).IsRequired();
            builder.Property(x => x.ProvinceOrCityID).IsRequired();
            builder.Property(x => x.DistrictID).IsRequired();
            builder.Property(x => x.WardID).IsRequired();
            builder.Property(x => x.Address).HasMaxLength(512);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.Tel).HasMaxLength(20);
            builder.Property(x => x.Mobile).HasMaxLength(20);
            builder.Property(x => x.IdentificationNumber).HasMaxLength(50);
            builder.Property(x => x.IssueBy).HasMaxLength(255);
            builder.Property(x => x.Workplace).HasMaxLength(255);
            builder.Property(x => x.Description).HasMaxLength(255);

            builder.HasOne(x => x.Gender).WithMany().HasForeignKey(x => x.GenderID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Ethnicity).WithMany().HasForeignKey(x => x.EthnicityID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Religion).WithMany().HasForeignKey(x => x.ReligionID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Country).WithMany().HasForeignKey(x => x.CountryID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.ProvinceOrCity).WithMany().HasForeignKey(x => x.ProvinceOrCityID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.District).WithMany().HasForeignKey(x => x.DistrictID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.WardOrCommune).WithMany().HasForeignKey(x => x.WardID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Career).WithMany().HasForeignKey(x => x.CareerID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.BloodType).WithMany().HasForeignKey(x => x.BloodTypeID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.BloodTypeRh).WithMany().HasForeignKey(x => x.BloodTypeRhID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
