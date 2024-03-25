using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Business.InOutStockTypes.Dto
{
    public  class GetAllInOutStockTypeInput : PagedAndSortedResultRequestDto
    {
        public bool? InactiveFilter { get; set; }
    }
}
