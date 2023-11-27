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
    public class ReceptionConfiguration : IEntityTypeConfiguration<Reception>
    {
        public void Configure(EntityTypeBuilder<Reception> builder)
        {
            builder.ToTable("Reception");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MedicalRecordID).IsRequired();
            builder.Property(x => x.TreatmentID).IsRequired();
            builder.Property(x => x.BranchID).IsRequired();
            builder.Property(x => x.DepartmentID).IsRequired();
            builder.Property(x => x.RoomID).IsRequired();
            builder.Property(x => x.UserID).IsRequired();
            builder.Property(x => x.PatientTypeID).IsRequired();
            builder.Property(x => x.ReceptionTypeID).IsRequired();
            builder.Property(x => x.ExecuteDepartmentID).IsRequired();
            builder.Property(x => x.ExecuteRoomID).IsRequired();
            builder.Property(x => x.ReceptionDate).IsRequired();
            builder.Property(x => x.HospitalizationReason).HasMaxLength(512);
            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasOne(x => x.MedicalRecord).WithMany().HasForeignKey(x => x.MedicalRecordID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Treatment).WithMany().HasForeignKey(x => x.TreatmentID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Branch).WithMany().HasForeignKey(x => x.BranchID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Department).WithMany().HasForeignKey(x => x.DepartmentID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Room).WithMany().HasForeignKey(x => x.RoomID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.ExecuteDepartment).WithMany().HasForeignKey(x => x.ExecuteDepartmentID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.ExecuteRoom).WithMany().HasForeignKey(x => x.ExecuteRoomID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.ExecuteUser).WithMany().HasForeignKey(x => x.ExecuteUserID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Service).WithMany().HasForeignKey(x => x.ServiceID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.PatientType).WithMany().HasForeignKey(x => x.PatientTypeID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.ReceptionType).WithMany().HasForeignKey(x => x.ReceptionTypeID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
