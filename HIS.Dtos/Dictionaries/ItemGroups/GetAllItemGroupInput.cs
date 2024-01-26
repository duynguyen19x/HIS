using HIS.Core.Application.Services.Dto;
using HIS.Utilities.Enums;

namespace HIS.Dtos.Dictionaries.ItemGroups
{
    public class GetAllItemGroupInput : PagedResultRequestDto
    {
        public string CodeFilter { get; set; }
        public string NameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
        public CommodityTypes? CommodityTypeFilter { get; set; }
    }
}
