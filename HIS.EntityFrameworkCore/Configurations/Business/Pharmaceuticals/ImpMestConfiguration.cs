using HIS.EntityFrameworkCore.Entities.Categories;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.DImpMests;
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
            builder.Property(x => x.Description).HasMaxLength(512);
            builder.Property(x => x.Deliverer).HasMaxLength(512);

            builder.HasOne(e => e.DExpMest)
                .WithMany()
                .HasForeignKey(e => e.ExpMestId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.ImpStock)
                .WithMany()
                .HasForeignKey(e => e.ImpStockId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.ExpStock)
                .WithMany()
                .HasForeignKey(e => e.ExpStockId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.DImpExpMestType)
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

            builder.HasOne(e => e.StockImpUser)
                .WithMany()
                .HasForeignKey(e => e.StockImpUserId)
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

            //builder.HasOne(e => e.MRPatient)
            //    .WithMany()
            //    .HasForeignKey(e => e.PatientId)
            //    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.SSupplier)
                .WithMany()
                .HasForeignKey(e => e.SupplierId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
