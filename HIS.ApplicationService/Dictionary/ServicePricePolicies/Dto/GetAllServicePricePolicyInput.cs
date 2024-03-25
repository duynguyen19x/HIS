using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.ServicePricePolicies.Dto
{
    public class GetAllServicePricePolicyInput : PagedAndSortedResultRequestDto
    {
        public Guid? ServiceIdFilter { get; set; }
        public Guid? PatientTypeIdFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
