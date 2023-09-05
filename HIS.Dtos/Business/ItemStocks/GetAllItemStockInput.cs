namespace HIS.Dtos.Business.ItemStocks
{
    public class GetAllItemStockInput
    {
        public Guid? StockIdFilter { get; set; }
        public Guid? ItemIdFilter { get; set; }
    }
}
