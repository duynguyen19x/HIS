using HIS.Dtos.Dictionaries.Items;
using HIS.Dtos.Dictionaries.Room;

namespace HIS.Dtos.Business.ItemStocks
{
    public class ItemStockDto : ItemDto//EntityDto<Guid?>
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

        public string StockCode { get; set; }
        public string StockName { get; set; }

        public string ItemCode { get; set; }
        public string ItemName { get; set; }

        public ItemDto Item { get; set; }
        public RoomDto Stock { get; set; }
    }
}
