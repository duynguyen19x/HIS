using HIS.Application.Core.Services.Dto;

namespace HIS.Dtos.Dictionaries.Countries
{
    public class GetAllCountryInputDto : PagedResultRequestDto
    {
        public string CodeFilter { get; set; }
        public string NameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
