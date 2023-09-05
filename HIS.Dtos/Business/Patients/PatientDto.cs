using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.Patients
{
    public class PatientDto : EntityDto
    {
        public virtual Guid PatientId { get; set; }
        public virtual string PatientCode { get; set; }
        public virtual string PatientName { get; set; }
        public virtual string Description { get; set; }
        public virtual int BloodTypeId { get; set; }
        public virtual int BloodRhTypeId { get; set; }
        public virtual bool Inactive { get; set; }
    }
}
