using HIS.EntityFrameworkCore.Constants;
using HIS.EntityFrameworkCore.Entities;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.EntityFrameworkCore.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("DOrder");
            builder.HasKey(x => x.Id);

            //builder.Property(x => x.OrderCode).IsRequired().HasMaxLength(OrderConst.OrderCodeLength);
            //builder.Property(x => x.Barcode).HasMaxLength(OrderConst.BarcodeLength);
            //builder.Property(x => x.IcdCode).HasMaxLength(IcdConst.IcdCodeLength);
            //builder.Property(x => x.IcdName).HasMaxLength(IcdConst.IcdNameLength);
            //builder.Property(x => x.IcdSubCode).HasMaxLength(IcdConst.IcdSubCodeLength);
            //builder.Property(x => x.IcdText).HasMaxLength(IcdConst.IcdTextLength);

            //builder.HasOne<MedicalRecord>().WithMany().HasForeignKey(x => x.MedicalRecordId);
            //builder.HasOne<Treatment>().WithMany().HasForeignKey(x => x.TreatmentId);
            //builder.HasOne<Reception>().WithMany().HasForeignKey(x => x.ReceptionId);
            //builder.HasOne<Insurance>().WithMany().HasForeignKey(x => x.InsuranceId);
            //builder.HasOne<User>().WithMany().HasForeignKey(x => x.UserId);
            //builder.HasOne<Branch>().WithMany().HasForeignKey(x => x.BranchId);
            //builder.HasOne<Department>().WithMany().HasForeignKey(x => x.DepartmentId);
            //builder.HasOne<Room>().WithMany().HasForeignKey(x => x.RoomId);
        }
    }
}
