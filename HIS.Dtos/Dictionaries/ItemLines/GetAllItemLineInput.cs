using HIS.Core.Application.Services.Dto;

namespace HIS.Dtos.Dictionaries.ItemLines
{
    public  class GetAllItemLineInput : PagedResultRequestDto
    {
        public string CodeFilter { get; set; }
        public string NameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
