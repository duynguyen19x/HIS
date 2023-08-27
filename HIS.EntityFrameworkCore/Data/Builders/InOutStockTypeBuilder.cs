using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public class InOutStockTypeBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.Business.Pharmaceuticals.InOutStockType>().HasData(
                new Entities.Business.Pharmaceuticals.InOutStockType() { Id = (int)Utilities.Enums.InOutStockType.ImportFromSupplier, Code = "01", Name = "Nhập hàng hóa từ nhà cung cấp", Inactive = false },
                new Entities.Business.Pharmaceuticals.InOutStockType() { Id = (int)Utilities.Enums.InOutStockType.ExportFormSupplier, Code = "02", Name = "Xuất hàng hóa trả nhà cung cấp", Inactive = false },
                new Entities.Business.Pharmaceuticals.InOutStockType() { Id = (int)Utilities.Enums.InOutStockType.ImportFromAnotherStock, Code = "03", Name = "Nhập từ kho khác", Inactive = false },
                new Entities.Business.Pharmaceuticals.InOutStockType() { Id = (int)Utilities.Enums.InOutStockType.ExportFromAnotherStock, Code = "04", Name = "Xuất trả kho khác", Inactive = false },
                new Entities.Business.Pharmaceuticals.InOutStockType() { Id = (int)Utilities.Enums.InOutStockType.Replenish, Code = "05", Name = "Nhập bù", Inactive = false },
                new Entities.Business.Pharmaceuticals.InOutStockType() { Id = (int)Utilities.Enums.InOutStockType.Liquidate, Code = "06", Name = "Xuất thanh lý", Inactive = false },
                new Entities.Business.Pharmaceuticals.InOutStockType() { Id = (int)Utilities.Enums.InOutStockType.ReleaseForTesting, Code = "07", Name = "Xuất kiểm nghiệm", Inactive = false },
                new Entities.Business.Pharmaceuticals.InOutStockType() { Id = (int)Utilities.Enums.InOutStockType.IssueForDisposal, Code = "08", Name = "Xuất hủy (Mất, hỏng, vỡ)", Inactive = false },
                new Entities.Business.Pharmaceuticals.InOutStockType() { Id = (int)Utilities.Enums.InOutStockType.DischargeMedicalWaste, Code = "09", Name = "Xuất hao phí phòng khám", Inactive = false },
                new Entities.Business.Pharmaceuticals.InOutStockType() { Id = (int)Utilities.Enums.InOutStockType.IssueForRoomUse, Code = "10", Name = "Xuất sử dụng phòng", Inactive = false },
                new Entities.Business.Pharmaceuticals.InOutStockType() { Id = (int)Utilities.Enums.InOutStockType.IssueForDepartmentUse, Code = "11", Name = "Xuất sử dụng khoa", Inactive = false },
                new Entities.Business.Pharmaceuticals.InOutStockType() { Id = (int)Utilities.Enums.InOutStockType.ReplenishCabinetStock, Code = "12", Name = "Nhập bù cơ số tủ trực", Inactive = false },
                new Entities.Business.Pharmaceuticals.InOutStockType() { Id = (int)Utilities.Enums.InOutStockType.IssueToReplenishCabinetStock, Code = "13", Name = "Xuất bù cơ số tủ trực", Inactive = false },
                new Entities.Business.Pharmaceuticals.InOutStockType() { Id = (int)Utilities.Enums.InOutStockType.AddToCabinetInventory, Code = "14", Name = "Bổ sung cơ số tủ trực", Inactive = false },
                new Entities.Business.Pharmaceuticals.InOutStockType() { Id = (int)Utilities.Enums.InOutStockType.ReturnCabinetStock, Code = "15", Name = "Hoàn trả cơ số tủ trực", Inactive = false },
                new Entities.Business.Pharmaceuticals.InOutStockType() { Id = (int)Utilities.Enums.InOutStockType.ReleaseToCustomers, Code = "16", Name = "Xuất bản cho khách hàng", Inactive = false },
                new Entities.Business.Pharmaceuticals.InOutStockType() { Id = (int)Utilities.Enums.InOutStockType.ReturnFromCustomer, Code = "17", Name = "Nhập trả từ khách hàng", Inactive = false },
                new Entities.Business.Pharmaceuticals.InOutStockType() { Id = (int)Utilities.Enums.InOutStockType.OtherIssue, Code = "99", Name = "Xuất khác", Inactive = false }
            );
        }
    }
}
