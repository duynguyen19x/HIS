using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.Patients
{
    /// <summary>
    /// Thông tin định danh bệnh nhân.
    /// </summary>
    public class PatientDto : EntityDto<Guid>
    {
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int? BloodTypeId { get; set; }
        public virtual int? BloodRhTypeId { get; set; }
        public virtual bool Inactive { get; set; }
    }
}
