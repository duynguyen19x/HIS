using HIS.Core.Application.Services.Dto;
using HIS.Utilities.Enums;

namespace HIS.Dtos.Business.ServiceRequests
{
    public class GetAllServiceRequestInputDto : PagedResultRequestDto
    {
        public Guid? ExecuteRoomIdFilter { get; set; }

        public Guid? ExecuteDepartmentIdFilter { get; set; }

        public ServiceRequestStatusTypes? StatusFilter { get; set; }

        public long? UseTimeFromFilter { get; set; }
        public long? UseTimeToFilter { get; set; }

        public long? RequestTimeFromFilter { get; set; }
        public long? RequestTimeToFilter { get; set; }

        public long? StartTimeFromFilter { get; set; } // Ngày bắt đầu (thực hiện)
        public long? StartTimeToFilter { get; set; }// Ngày bắt đầu (thực hiện)

        public long? EndTimeFromFilter { get; set; } // Ngày kết thúc (kết quả)
        public long? EndTimeToFilter { get; set; } // Ngày kết thúc (kết quả)
    }
}
