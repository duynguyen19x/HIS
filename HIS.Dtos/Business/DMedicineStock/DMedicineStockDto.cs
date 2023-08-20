using HIS.Application.Core.Services.Dto;

namespace HIS.Dtos.Business.DMedicineStock
{
    public class DMedicineStockDto: EntityDto<Guid?>
    {
        public Guid? StockId { get; set; }
        public Guid? MedicineId { get; set; }

        /// <summary>
        /// Số lượng tồn kho
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Số lượng khả dụng
        /// </summary>
        public decimal AvailableQuantity { get; set; }

        public string StockCode { get; set; }
        public string StockName { get; set; }

        public string MedicineCode { get; set; }
        public string MedicineName { get; set; }
    }
}
