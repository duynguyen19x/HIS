using HIS.Core.Application.Services.Dto;

namespace HIS.Dtos.Dictionaries.ItemPricePolicies
{
    public class GetAllItemPricePolicyInput : PagedResultRequestDto
    {
        public Guid? ItemIdFilter { get; set; }
        public int? PatientTypeIdFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
