using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Dictionaries;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    public class ItemStock : FullAuditedEntity<Guid?>
    {
        public Guid? StockId { get; set; }
        public Guid? ItemId { get; set; }

        /// <summary>
        /// Số lượng tồn kho
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Số lượng khả dụng
        /// </summary>
        public decimal AvailableQuantity { get; set; }

        public Item Item { get; set; }
        public Room Stock { get; set; }
    }
}
