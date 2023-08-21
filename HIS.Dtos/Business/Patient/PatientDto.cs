using HIS.Application.Core.Services.Dto;

namespace HIS.Dtos.Business
{
    public class PatientDto : EntityDto<Guid?>
    {
        public virtual string Code { get; set; }

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public bool Inactive { get; set; }
    }
}
