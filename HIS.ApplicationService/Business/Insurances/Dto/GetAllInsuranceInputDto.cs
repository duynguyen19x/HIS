using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Business.Insurances.Dto
{
    public class GetAllInsuranceInputDto : PagedAndSortedResultRequestDto
    {
        public string InsuranceCodeFilter { get; set; }
    }
}
