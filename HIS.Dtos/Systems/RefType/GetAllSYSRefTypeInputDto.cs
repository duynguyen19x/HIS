using HIS.Core.Services.Dto;

namespace HIS.Dtos.Systems.RefType
{
    public class GetAllSYSRefTypeInputDto : PagedAndSortedResultRequestDto
    {
        public string RefTypeNameFilter { get; set; }
        public int? RefTypeCategoryFilter { get; set; }
    }
}
