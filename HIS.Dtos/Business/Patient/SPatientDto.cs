using HIS.Core.Application.Services.Dto;

namespace HIS.Dtos.Business.Patient
{
    public class SPatientDto : EntityDto<Guid?>
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
