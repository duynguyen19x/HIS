using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.Careers.Dto
{
    public class GetAllCareerInput : PagedAndSortedResultRequestDto
    {
        public string CodeFilter { get; set; }
        public string NameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
