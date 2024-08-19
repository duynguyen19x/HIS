using HIS.Core.Application.Services.Dto;
using HIS.Utilities.Enums;
using System.ComponentModel;
using System.Globalization;

namespace HIS.Dtos.Business.ServiceRequests
{
    public class GetAllServiceRequestInputDto : PagedResultRequestDto
    {
        public Guid? ExecuteRoomIdFilter { get; set; }

        public Guid? ExecuteDepartmentIdFilter { get; set; }

        public ServiceRequestStatusTypes? StatusFilter { get; set; }

        public DateTime? UseTimeFromFilter { get; set; }
        public DateTime? UseTimeToFilter { get; set; }

        public DateTime? RequestTimeFromFilter { get; set; }
        public DateTime? RequestTimeToFilter { get; set; }

        public DateTime? StartTimeFromFilter { get; set; } // Ngày bắt đầu (thực hiện)
        public DateTime? StartTimeToFilter { get; set; }// Ngày bắt đầu (thực hiện)

        public DateTime? EndTimeFromFilter { get; set; } // Ngày kết thúc (kết quả)
        public DateTime? EndTimeToFilter { get; set; } // Ngày kết thúc (kết quả)
    }
}
