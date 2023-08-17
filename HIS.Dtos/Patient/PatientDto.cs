using HIS.Core.Application.Services.Dto;

namespace HIS.Dtos.Patient
{
    public class PatientDto : EntityDto<Guid?>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
    }
}
