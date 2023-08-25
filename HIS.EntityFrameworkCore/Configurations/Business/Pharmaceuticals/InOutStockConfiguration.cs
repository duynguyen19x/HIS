using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Business.Pharmaceuticals
{
    public class InOutStockConfiguration : IEntityTypeConfiguration<InOutStock>
    {
        public void Configure(EntityTypeBuilder<InOutStock> builder)
        {
            builder.ToTable("InOutStocks");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Description).HasMaxLength(512);
            builder.Property(x => x.Deliverer).HasMaxLength(512);

            builder.HasOne(e => e.ImpStock)
                .WithMany()
                .HasForeignKey(e => e.ImpStockId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.ExpStock)
                .WithMany()
                .HasForeignKey(e => e.ExpStockId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.InOutStockType)
                .WithMany()
                .HasForeignKey(e => e.InOutStockTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.ReceiverUser)
                .WithMany()
                .HasForeignKey(e => e.ReceiverUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.ApproverUser)
                .WithMany()
                .HasForeignKey(e => e.ApproverUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.StockImpUser)
                .WithMany()
                .HasForeignKey(e => e.StockImpUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.StockExpUser)
                .WithMany()
                .HasForeignKey(e => e.StockExpUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.ReqRoom)
                .WithMany()
                .HasForeignKey(e => e.ReqRoomId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.ReqDepartment)
                .WithMany()
                .HasForeignKey(e => e.ReqDepartmentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.PatientRecord)
                .WithMany()
                .HasForeignKey(e => e.PatientRecordId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Patient)
                .WithMany()
                .HasForeignKey(e => e.PatientId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Supplier)
                .WithMany()
                .HasForeignKey(e => e.SupplierId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.CreationUser)
                .WithMany()
                .HasForeignKey(e => e.CreationUserId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
