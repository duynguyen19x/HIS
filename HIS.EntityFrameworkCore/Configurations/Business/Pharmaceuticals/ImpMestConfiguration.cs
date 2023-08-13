using HIS.EntityFrameworkCore.Entities.Categories;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.ImpMests;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals;

namespace HIS.EntityFrameworkCore.Configurations.Business.Pharmaceuticals
{
    public class ImpMestConfiguration : IEntityTypeConfiguration<DImpMest>
    {
        public void Configure(EntityTypeBuilder<DImpMest> builder)
        {
            builder.ToTable("DImpMests");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(512);
            builder.Property(x => x.Description).HasMaxLength(512);
            builder.Property(x => x.Deliverer).HasMaxLength(512);

            builder.HasOne(e => e.ImStock)
                .WithMany()
                .HasForeignKey(e => e.ImStockId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.ExStock)
                .WithMany()
                .HasForeignKey(e => e.ExStockId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.DImExMestType)
                .WithMany()
                .HasForeignKey(e => e.ImpExpMestTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.ReceiverUser)
                .WithMany()
                .HasForeignKey(e => e.ReceiverUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.ApproverUser)
                .WithMany()
                .HasForeignKey(e => e.ApproverUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.StockReceiptUser)
                .WithMany()
                .HasForeignKey(e => e.StockReceiptUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.ReqRoom)
                .WithMany()
                .HasForeignKey(e => e.ReqRoomId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.ReqDepartment)
                .WithMany()
                .HasForeignKey(e => e.ReqDepartmentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.STreatment)
                .WithMany()
                .HasForeignKey(e => e.TreatmentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.SPatient)
                .WithMany()
                .HasForeignKey(e => e.PatientId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.SSupplier)
                .WithMany()
                .HasForeignKey(e => e.SupplierId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
