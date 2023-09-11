using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.EntityFrameworkCore.Entities.Business;

namespace HIS.EntityFrameworkCore.Configurations.Business
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
                ;

            builder.HasOne(e => e.ExpStock)
                .WithMany()
                .HasForeignKey(e => e.ExpStockId)
                ;

            builder.HasOne(e => e.InOutStockType)
                .WithMany()
                .HasForeignKey(e => e.InOutStockTypeId)
                ;

            builder.HasOne(e => e.ReceiverUser)
                .WithMany()
                .HasForeignKey(e => e.ReceiverUserId)
                ;

            builder.HasOne(e => e.ApproverUser)
                .WithMany()
                .HasForeignKey(e => e.ApproverUserId)
                ;

            builder.HasOne(e => e.StockImpUser)
                .WithMany()
                .HasForeignKey(e => e.StockImpUserId)
                ;

            builder.HasOne(e => e.StockExpUser)
                .WithMany()
                .HasForeignKey(e => e.StockExpUserId)
                ;

            builder.HasOne(e => e.ReqRoom)
                .WithMany()
                .HasForeignKey(e => e.ReqRoomId)
                ;

            builder.HasOne(e => e.ReqDepartment)
                .WithMany()
                .HasForeignKey(e => e.ReqDepartmentId)
                ;

            builder.HasOne(e => e.PatientRecord)
                .WithMany()
                .HasForeignKey(e => e.PatientRecordId)
                ;

            builder.HasOne(e => e.Patient)
                .WithMany()
                .HasForeignKey(e => e.PatientId)
                ;

            builder.HasOne(e => e.Supplier)
                .WithMany()
                .HasForeignKey(e => e.SupplierId)
                ;

            builder.HasOne(e => e.CreationUser)
                .WithMany()
                .HasForeignKey(e => e.CreationUserId)
                ;
        }
    }
}
