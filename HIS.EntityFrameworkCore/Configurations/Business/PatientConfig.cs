using HIS.EntityFrameworkCore.Constants;
using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class PatientConfig : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable("DPatient");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.PatientCode).IsRequired().HasMaxLength(DPatientConst.PatientCodeLength);
            builder.Property(x => x.PatientName).IsRequired().HasMaxLength(DPatientConst.PatientNameLength);
            builder.Property(x => x.BirthPlace).HasMaxLength(DPatientConst.BirthPlaceLength);
            builder.Property(x => x.Address).HasMaxLength(DPatientConst.AddressLength);
            builder.Property(x => x.PhoneNumber).HasMaxLength(DPatientConst.PhoneNumberLength);
            builder.Property(x => x.Email).HasMaxLength(DPatientConst.EmailLength);
            builder.Property(x => x.WorkPlace).HasMaxLength(DPatientConst.WorkPlaceLength);
            builder.Property(x => x.IdentificationNumber).HasMaxLength(DPatientConst.IdentificationNumberLength);
            builder.Property(x => x.IssueBy).HasMaxLength(DPatientConst.IssueByLength);
            builder.Property(x => x.ContactName).HasMaxLength(DPatientConst.ContactNameLength);
            builder.Property(x => x.ContactRelationshipName).HasMaxLength(DPatientConst.ContactRelationshipNameLength);
            builder.Property(x => x.ContactIdentificationNumber).HasMaxLength(DPatientConst.ContactIdentificationNumberLength);
            builder.Property(x => x.ContactPhoneNumber).HasMaxLength(DPatientConst.ContactPhoneNumberLength);
            builder.Property(x => x.ContactAddress).HasMaxLength(DPatientConst.ContactAddressLength);
            builder.Property(x => x.Description).HasMaxLength(DPatientConst.DescriptionLength);

            builder.HasOne<BloodType>().WithMany().HasForeignKey(x => x.BloodTypeID);
            builder.HasOne<BloodRhType>().WithMany().HasForeignKey(x => x.BloodRhTypeID);
            builder.HasOne<Gender>().WithMany().HasForeignKey(x => x.GenderID);
            builder.HasOne<Career>().WithMany().HasForeignKey(x => x.CareerID);
            builder.HasOne<Ethnicity>().WithMany().HasForeignKey(x => x.EthnicityID);
            builder.HasOne<Religion>().WithMany().HasForeignKey(x => x.ReligionID);
            builder.HasOne<Country>().WithMany().HasForeignKey(x => x.CountryID);
            builder.HasOne<Province>().WithMany().HasForeignKey(x => x.ProvinceID);
            builder.HasOne<Ward>().WithMany().HasForeignKey(x => x.WardID);
            builder.HasOne<PatientOrder>().WithMany().HasForeignKey(x => x.PatientOrderID);
            builder.HasOne<Branch>().WithMany().HasForeignKey(x => x.BranchID);
        }
    }
}
