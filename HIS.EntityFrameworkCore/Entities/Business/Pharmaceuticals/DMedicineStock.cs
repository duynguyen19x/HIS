﻿using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Dictionaries;

namespace HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals
{
    public class DMedicineStock : FullAuditedEntity<Guid?>
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

        public SMedicine SMedicine { get; set; }
        public SRoom SStock { get; set; }
    }
}
