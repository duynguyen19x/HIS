using HIS.Core.Services.Dto;

namespace HIS.Dtos.Business.ServiceRequests
{
    public class GetAllServiceRequestInputDto : PagedResultRequestDto
    {
        public Guid? ExecuteRoomIdFilter { get; set; }
        public Guid? ExecuteDepartmentIdFilter { get; set; }
        public int? ServiceRequestStatusIdFilter { get; set; }

        public DateTime? ServiceRequestUseDateFromFilter { get; set; }
        public DateTime? ServiceRequestUseDateToFilter { get; set; }

        public string ServiceRequestDateFromFilter { get; set; }
        public string ServiceRequestDateToFilter { get; set; }
    }
}
