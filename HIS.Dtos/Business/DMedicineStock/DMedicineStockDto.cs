using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.Medicine;
using HIS.Dtos.Dictionaries.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.DMedicineStock
{
    public class DMedicineStockDto : EntityDto<Guid?>
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

        public SMedicineDto SMedicine { get; set; }
        public SRoomDto Stock { get; set; }
    }
}
