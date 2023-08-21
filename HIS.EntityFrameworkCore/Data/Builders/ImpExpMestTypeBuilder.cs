﻿using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public class ImpExpMestTypeBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DImpExpMestType>().HasData(
                new DImpExpMestType() { Id = (int)ImpExpMestType.ImportMedicineFromSupplier, Code = "01", Name = "Nhập thuốc từ nhà cung cấp", Inactive = false },
                new DImpExpMestType() { Id = (int)ImpExpMestType.ExportMedicineFormSupplier, Code = "02", Name = "Xuất thuốc trả nhà cung cấp", Inactive = false },
                new DImpExpMestType() { Id = (int)ImpExpMestType.ImportFromAnotherStock, Code = "03", Name = "Nhập từ kho khác", Inactive = false },
                new DImpExpMestType() { Id = (int)ImpExpMestType.ExportFromAnotherStock, Code = "04", Name = "Xuất trả kho khác", Inactive = false },
                new DImpExpMestType() { Id = (int)ImpExpMestType.Replenish, Code = "05", Name = "Nhập bù", Inactive = false },
                new DImpExpMestType() { Id = (int)ImpExpMestType.Liquidate, Code = "06", Name = "Xuất thanh lý", Inactive = false },
                new DImpExpMestType() { Id = (int)ImpExpMestType.ReleaseForTesting, Code = "07", Name = "Xuất kiểm nghiệm", Inactive = false },
                new DImpExpMestType() { Id = (int)ImpExpMestType.IssueForDisposal, Code = "08", Name = "Xuất hủy (Mất, hỏng, vỡ)", Inactive = false },
                new DImpExpMestType() { Id = (int)ImpExpMestType.DischargeMedicalWaste, Code = "09", Name = "Xuất hao phí phòng khám", Inactive = false },
                new DImpExpMestType() { Id = (int)ImpExpMestType.IssueForRoomUse, Code = "10", Name = "Xuất sử dụng phòng", Inactive = false },
                new DImpExpMestType() { Id = (int)ImpExpMestType.IssueForDepartmentUse, Code = "11", Name = "Xuất sử dụng khoa", Inactive = false },
                new DImpExpMestType() { Id = (int)ImpExpMestType.ReplenishCabinetStock, Code = "12", Name = "Nhập bù cơ số tủ trực", Inactive = false },
                new DImpExpMestType() { Id = (int)ImpExpMestType.IssueToReplenishCabinetStock, Code = "13", Name = "Xuất bù cơ số tủ trực", Inactive = false },
                new DImpExpMestType() { Id = (int)ImpExpMestType.AddToCabinetInventory, Code = "14", Name = "Bổ sung cơ số tủ trực", Inactive = false },
                new DImpExpMestType() { Id = (int)ImpExpMestType.ReturnCabinetStock, Code = "15", Name = "Hoàn trả cơ số tủ trực", Inactive = false },
                new DImpExpMestType() { Id = (int)ImpExpMestType.ReleaseToCustomers, Code = "16", Name = "Xuất bản cho khách hàng", Inactive = false },
                new DImpExpMestType() { Id = (int)ImpExpMestType.ReturnFromCustomer, Code = "17", Name = "Nhập trả từ khách hàng", Inactive = false },
                new DImpExpMestType() { Id = (int)ImpExpMestType.ImportMaterialFromSupplier, Code = "18", Name = "Nhập VTYT từ nhà cung cấp", Inactive = false },
                new DImpExpMestType() { Id = (int)ImpExpMestType.ExportMaterialFormSupplier, Code = "19", Name = "Xuất VTYT trả nhà cung cấp", Inactive = false },
                new DImpExpMestType() { Id = (int)ImpExpMestType.OtherIssue, Code = "99", Name = "Xuất khác", Inactive = false }
            );
        }
    }
}
