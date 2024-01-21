using HIS.Core.Services.Dto;

namespace HIS.Dtos.Business.ServiceRequests
{
    public class GetAllServiceRequestInputDto : PagedResultRequestDto
    {
        public Guid? ExecuteRoomIdFilter { get; set; }
        public Guid? ExecuteDepartmentIdFilter { get; set; }
        public int? ServiceRequestStatusIdFilter { get; set; }

        public long? ServiceRequestUseDateFromFilter { get; set; }
        public long? ServiceRequestUseDateToFilter { get; set; }

        public long? ServiceRequestDateFromFilter { get; set; }
        public long? ServiceRequestDateToFilter { get; set; }
    }
}
