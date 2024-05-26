using HIS.Core.Application.Services.Dto;

namespace HIS.Dtos.Dictionaries.Branchs
{
    public class GetAllBranchInputDto : PagedAndSortedResultRequestDto
    {
        public string BranchCodeFilter { get; set; }

        public string BranchNameFilter { get; set; }

        public bool? InactiveFilter { get; set; }
    }
}
