using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.ExpMests;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.ImpMests;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Business.Pharmaceuticals
{
    internal class ExpMestConfiguration : IEntityTypeConfiguration<DExpMest>
    {
        public void Configure(EntityTypeBuilder<DExpMest> builder)
        {
            builder.ToTable("DExpMests");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasOne(e => e.DImpMest)
                .WithMany()
                .HasForeignKey(e => e.ImpMestId)
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

            builder.HasOne(e => e.ApproverUser)
                .WithMany()
                .HasForeignKey(e => e.ApproverUserId)
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
