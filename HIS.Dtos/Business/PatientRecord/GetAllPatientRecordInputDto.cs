using HIS.Application.Core.Services.Dto;

namespace HIS.Dtos.Business
{
    public class GetAllPatientRecordInputDto : PagedResultRequestDto
    {
        public string CodeFilter { get; set; }
        public Guid? PatientIdFilter { get; set; }
        public string PatientCodeFilter { get; set; }
        public string PatientNameFilter { get; set; }
        public Guid? GenderIdFilter { get; set; }
        public Guid? EthnicityIdFilter { get; set; }
        public Guid? CareerIdFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
