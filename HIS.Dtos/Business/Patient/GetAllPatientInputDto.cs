using HIS.Application.Core.Services.Dto;

namespace HIS.Dtos.Business
{
    public class GetAllPatientInputDto : PagedResultRequestDto
    {
        public string CodeFilter { get; set; }
        public string NameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
