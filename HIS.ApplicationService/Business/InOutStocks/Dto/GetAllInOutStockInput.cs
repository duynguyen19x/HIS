namespace HIS.ApplicationService.Business.InOutStocks.Dto
{
    public class GetAllInOutStockInput
    {
        public string CodeFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
