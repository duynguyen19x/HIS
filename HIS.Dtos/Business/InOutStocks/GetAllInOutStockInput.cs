namespace HIS.Dtos.Business.InOutStocks
{
    public class GetAllInOutStockInput
    {
        public string CodeFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
