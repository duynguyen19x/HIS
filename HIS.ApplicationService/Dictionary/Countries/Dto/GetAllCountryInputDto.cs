using HIS.Core.Application.Services.Dto;

namespace HIS.Dtos.Dictionaries.Countries
{
    public class GetAllCountryInputDto : PagedAndSortedResultRequestDto
    {
        public string CodeFilter { get; set; }
        public string NameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
