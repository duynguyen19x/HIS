using HIS.EntityFrameworkCore.Entities.Business;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class InOutStockTypeConfiguration : IEntityTypeConfiguration<InOutStockType>
    {
        public void Configure(EntityTypeBuilder<InOutStockType> builder)
        {
            builder.ToTable("DInOutStockType");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(512);

            builder.HasData(
                new InOutStockType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)InOutStockTypeTypes.ImportFromSupplier, Code = "01", Name = "Nhập hàng hóa từ nhà cung cấp", Inactive = false },
                new InOutStockType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)InOutStockTypeTypes.ExportFormSupplier, Code = "02", Name = "Xuất hàng hóa trả nhà cung cấp", Inactive = false },
                new InOutStockType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)InOutStockTypeTypes.ImportFromAnotherStock, Code = "03", Name = "Nhập từ kho khác", Inactive = false },
                new InOutStockType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)InOutStockTypeTypes.ExportFromAnotherStock, Code = "04", Name = "Xuất trả kho khác", Inactive = false },
                new InOutStockType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)InOutStockTypeTypes.Replenish, Code = "05", Name = "Nhập bù", Inactive = false },
                new InOutStockType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)InOutStockTypeTypes.Liquidate, Code = "06", Name = "Xuất thanh lý", Inactive = false },
                new InOutStockType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)InOutStockTypeTypes.ReleaseForTesting, Code = "07", Name = "Xuất kiểm nghiệm", Inactive = false },
                new InOutStockType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)InOutStockTypeTypes.IssueForDisposal, Code = "08", Name = "Xuất hủy (Mất, hỏng, vỡ)", Inactive = false },
                new InOutStockType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)InOutStockTypeTypes.DischargeMedicalWaste, Code = "09", Name = "Xuất hao phí phòng khám", Inactive = false },
                new InOutStockType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)InOutStockTypeTypes.IssueForRoomUse, Code = "10", Name = "Xuất sử dụng phòng", Inactive = false },
                new InOutStockType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)InOutStockTypeTypes.IssueForDepartmentUse, Code = "11", Name = "Xuất sử dụng khoa", Inactive = false },
                new InOutStockType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)InOutStockTypeTypes.ReplenishCabinetStock, Code = "12", Name = "Nhập bù cơ số tủ trực", Inactive = false },
                new InOutStockType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)InOutStockTypeTypes.IssueToReplenishCabinetStock, Code = "13", Name = "Xuất bù cơ số tủ trực", Inactive = false },
                new InOutStockType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)InOutStockTypeTypes.AddToCabinetInventory, Code = "14", Name = "Bổ sung cơ số tủ trực", Inactive = false },
                new InOutStockType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)InOutStockTypeTypes.ReturnCabinetStock, Code = "15", Name = "Hoàn trả cơ số tủ trực", Inactive = false },
                new InOutStockType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)InOutStockTypeTypes.ReleaseToCustomers, Code = "16", Name = "Xuất bán cho khách hàng", Inactive = false },
                new InOutStockType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)InOutStockTypeTypes.ReturnFromCustomer, Code = "17", Name = "Nhập trả từ khách hàng", Inactive = false },
                new InOutStockType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)InOutStockTypeTypes.OpeningBalance, Code = "18", Name = "Nhập đầu kỳ", Inactive = false },
                new InOutStockType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)InOutStockTypeTypes.OtherIssue, Code = "99", Name = "Xuất khác", Inactive = false }
            );
        }
    }
}
