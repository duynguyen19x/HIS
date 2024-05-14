using HIS.EntityFrameworkCore.Constants;
using HIS.EntityFrameworkCore.Entities;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.Dictionary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class PatientConfig : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable("DPatient");

            builder.Property(x => x.PatientCode).IsRequired().HasMaxLength(PatientConst.PatientCodeLength);
            builder.Property(x => x.PatientName).IsRequired().HasMaxLength(PatientConst.PatientNameLength);
            builder.Property(x => x.BirthPlace).HasMaxLength(PatientConst.BirthPlaceLength);
            builder.Property(x => x.Address).HasMaxLength(PatientConst.AddressLength);
            builder.Property(x => x.PhoneNumber).HasMaxLength(PatientConst.PhoneNumberLength);
            builder.Property(x => x.Email).HasMaxLength(PatientConst.EmailLength);
            builder.Property(x => x.WorkPlace).HasMaxLength(PatientConst.WorkPlaceLength);
            builder.Property(x => x.IdentificationNumber).HasMaxLength(PatientConst.IdentificationNumberLength);
            builder.Property(x => x.IssueBy).HasMaxLength(PatientConst.IssueByLength);
            builder.Property(x => x.ContactName).HasMaxLength(PatientConst.ContactNameLength);
            builder.Property(x => x.ContactRelationshipName).HasMaxLength(PatientConst.ContactRelationshipNameLength);
            builder.Property(x => x.ContactIdentificationNumber).HasMaxLength(PatientConst.ContactIdentificationNumberLength);
            builder.Property(x => x.ContactPhoneNumber).HasMaxLength(PatientConst.ContactPhoneNumberLength);
            builder.Property(x => x.ContactAddress).HasMaxLength(PatientConst.ContactAddressLength);
            builder.Property(x => x.Description).HasMaxLength(PatientConst.DescriptionLength);

            builder.HasOne<BloodType>().WithMany().HasForeignKey(x => x.BloodTypeID);
            builder.HasOne<BloodRhType>().WithMany().HasForeignKey(x => x.BloodRhTypeID);
            builder.HasOne<Gender>().WithMany().HasForeignKey(x => x.GenderID);
            builder.HasOne<Career>().WithMany().HasForeignKey(x => x.CareerID);
            builder.HasOne<Ethnicity>().WithMany().HasForeignKey(x => x.EthnicityID);
            builder.HasOne<Religion>().WithMany().HasForeignKey(x => x.ReligionID);
            builder.HasOne<Country>().WithMany().HasForeignKey(x => x.CountryID);
            builder.HasOne<Province>().WithMany().HasForeignKey(x => x.ProvinceID);
            builder.HasOne<Ward>().WithMany().HasForeignKey(x => x.WardID);
        }
    }
}
