using HIS.Core.Application.Services.Dto;
using HIS.Utilities.Enums;

namespace HIS.Dtos.Business.ServiceResultDatas
{
    public class ServiceRequestDetailResultDto : EntityDto<Guid>
    {
        public Guid? ServiceResultIndiceId { get; set; }

        public Guid? ServiceRequestId { get; set; }

        public Guid? ServiceRequestDetailId { get; set; }

        public Guid? ServiceId { get; set; }

        public string Result { get; set; } // Kết quả

        public string NormalRange { get; set; } // Khoảng bình thường

        public string TestingMachine { get; set; } // Máy xét nghiệm

        public ServiceResultDataType ResultType { get; set; }

        public bool IsNumber { get; set; } // Kết quả dạng chữ hoặc số

        public string ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public string ServiceResultIndiceCode { get; set; }
        public string ServiceResultIndiceName { get; set; }
        public string ServiceResultIndiceUnit { get; set; }
    }
}
