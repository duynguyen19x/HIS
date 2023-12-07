using HIS.EntityFrameworkCore.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class PatientRecordConfiguration : IEntityTypeConfiguration<PatientRecord>
    {
        public void Configure(EntityTypeBuilder<PatientRecord> builder)
        {
            builder.ToTable("BUS_PatientRecord");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.PatientId).IsRequired();
            builder.Property(x => x.PatientRecordCode).IsRequired().HasMaxLength(20);
            builder.Property(x => x.PatientName).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Birthplace).HasMaxLength(512);
            builder.Property(x => x.Address).HasMaxLength(512);
            builder.Property(x => x.Workplace).HasMaxLength(512);
            builder.Property(x => x.IdentificationNumber).HasMaxLength(20);
            builder.Property(x => x.IssueBy).HasMaxLength(128);
            builder.Property(x => x.Tel).HasMaxLength(20);
            builder.Property(x => x.Mobile).HasMaxLength(20);
            builder.Property(x => x.Email).HasMaxLength(128);
            builder.Property(x => x.HospitalizationReason).HasMaxLength(512);
            builder.Property(x => x.RelativeName).HasMaxLength(512);
            builder.Property(x => x.RelativeAddress).HasMaxLength(512);
            builder.Property(x => x.RelativeTel).HasMaxLength(56);
            builder.Property(x => x.RelativeMobile).HasMaxLength(56);
            builder.Property(x => x.RelativeIdentificationNumber).HasMaxLength(56);
            builder.Property(x => x.RelativeIssueBy).HasMaxLength(512);
            builder.Property(x => x.TransferInCode).HasMaxLength(50);
            builder.Property(x => x.TransferInMediOrgCode).HasMaxLength(50);
            builder.Property(x => x.TransferInMediOrgName).HasMaxLength(50);
            builder.Property(x => x.TransferInIcdCode).HasMaxLength(50);
            builder.Property(x => x.TransferInIcdName).HasMaxLength(512);
            builder.Property(x => x.InCode).HasMaxLength(50);
            builder.Property(x => x.InIcdCode).HasMaxLength(50);
            builder.Property(x => x.InIcdName).HasMaxLength(512);          
            builder.Property(x => x.InIcdSubCode).HasMaxLength(50);
            builder.Property(x => x.InIcdText).HasMaxLength(512);        
            builder.Property(x => x.OutIcdCode).HasMaxLength(50);
            builder.Property(x => x.OutIcdName).HasMaxLength(512);      
            builder.Property(x => x.OutIcdSubCode).HasMaxLength(50);
            builder.Property(x => x.OutIcdText).HasMaxLength(512);  
            builder.Property(x => x.OutIcdSubCode).HasMaxLength(50);
            builder.Property(x => x.OutIcdText).HasMaxLength(512);  
            builder.Property(x => x.OutIcdCauseCode).HasMaxLength(50);
            builder.Property(x => x.OutIcdCauseName).HasMaxLength(512);  
            builder.Property(x => x.TreatmentDirection).HasMaxLength(512);
            builder.Property(x => x.TreatmentMethod).HasMaxLength(512);
            builder.Property(x => x.Advise).HasMaxLength(512);
            builder.Property(x => x.TransferMediOrgCode).HasMaxLength(50);
            builder.Property(x => x.TransferMediOrgName).HasMaxLength(512);
            builder.Property(x => x.Transporter).HasMaxLength(512);
            builder.Property(x => x.TransportVehicle).HasMaxLength(512);
            builder.Property(x => x.AutopsyIcdCode).HasMaxLength(50);
            builder.Property(x => x.AutopsyIcdName).HasMaxLength(512);
            builder.Property(x => x.StoreCode).HasMaxLength(50);

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
