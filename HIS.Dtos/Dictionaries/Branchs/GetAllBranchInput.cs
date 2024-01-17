using HIS.Core.Services.Dto;

namespace HIS.Dtos.Dictionaries.Branchs
{
    public class GetAllBranchInput : PagedResultRequestDto
    {
        public string BranchCodeFilter { get; set; }
        public string BranchNameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
