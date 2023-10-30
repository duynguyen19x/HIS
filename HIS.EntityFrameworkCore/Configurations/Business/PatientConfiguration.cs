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
            builder.Property(x => x.Code).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(500);
            builder.Property(x => x.BirthYear).IsRequired();
            builder.Property(x => x.GenderId).IsRequired();
            builder.Property(x => x.EthnicId).IsRequired();
            builder.Property(x => x.BirthPlace).HasMaxLength(250);
            builder.Property(x => x.Address).HasMaxLength(500);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.Tel).HasMaxLength(20);
            builder.Property(x => x.Phone).HasMaxLength(20);
            builder.Property(x => x.IdentificationNumber).HasMaxLength(50);
            builder.Property(x => x.IssueBy).HasMaxLength(250);
            builder.Property(x => x.CareerId).IsRequired();
            builder.Property(x => x.WorkPlace).HasMaxLength(250);
            builder.Property(x => x.Description).HasMaxLength(500);

            //builder.HasOne(x => x.Gender).WithMany().HasForeignKey(x => x.GenderId).OnDelete(DeleteBehavior.Restrict);
            //builder.HasOne(x => x.Ethnic).WithMany().HasForeignKey(x => x.EthnicId).OnDelete(DeleteBehavior.Restrict);
            //builder.HasOne(x => x.BloodType).WithMany().HasForeignKey(x => x.BloodTypeId).OnDelete(DeleteBehavior.Restrict);
            //builder.HasOne(x => x.BloodTypeRh).WithMany().HasForeignKey(x => x.BloodTypeRhId).OnDelete(DeleteBehavior.Restrict);
            //builder.HasOne(x => x.Country).WithMany().HasForeignKey(x => x.CountryId).OnDelete(DeleteBehavior.Restrict);
            //builder.HasOne(x => x.Province).WithMany().HasForeignKey(x => x.ProvinceOrCityId).OnDelete(DeleteBehavior.Restrict);
            //builder.HasOne(x => x.District).WithMany().HasForeignKey(x => x.DistrictId).OnDelete(DeleteBehavior.Restrict);
            //builder.HasOne(x => x.Ward).WithMany().HasForeignKey(x => x.WardOrCommuneId).OnDelete(DeleteBehavior.Restrict);
            //builder.HasOne(x => x.Career).WithMany().HasForeignKey(x => x.CareerId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
