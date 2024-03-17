using HIS.Core.Application.Services.Dto;

namespace HIS.Dtos.Dictionaries.Branchs
{
    public class GetAllDIBranchInputDto : PagedAndSortedResultRequestDto
    {
        public string BranchCodeFilter { get; set; }
        public string BranchNameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
