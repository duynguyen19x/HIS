using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.Genders.Dto
{
    public class GetAllGenderInputDto : PagedAndSortedResultRequestDto
    {
        public string CodeFilter { get; set; }

        public string NameFilter { get; set; }

        public bool? InactiveFilter { get; set; }
    }
}
