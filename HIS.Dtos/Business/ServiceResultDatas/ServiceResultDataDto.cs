using HIS.Application.Core.Services.Dto;
using HIS.Utilities.Enums;

namespace HIS.Dtos.Business.ServiceResultDatas
{
    public class ServiceResultDataDto : EntityDto<Guid>
    {
        public Guid? ServiceResultIndiceId { get; set; }

        public Guid? ServiceId { get; set; }

        public string Result { get; set; }

        public ServiceResultDataType ResultType { get; set; }

        public string ServiceResultIndiceCode { get; set; }
        public string ServiceResultIndiceName { get; set; }
        public string ServiceResultIndicUnit { get; set; }
    }
}
