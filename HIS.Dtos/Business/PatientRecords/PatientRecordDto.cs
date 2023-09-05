using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.PatientRecords
{
    public class PatientRecordDto : EntityDto
    {
        public virtual Guid PatientRecordId { get; set; }
        public virtual string PatientRecordCode { get; set; }
        public virtual Guid PatientId { get; set; }
        public virtual string PatientCode { get; set; }
        public virtual string PatientName { get; set; }
        public virtual string PatientDescription { get; set; }
        public virtual int BloodTypeId { get; set; }
        public virtual int BloodRhTypeId { get; set; }
        public virtual DateTime? BirthDate { get; set; }
        public virtual int BirthYear { get; set; }
        public virtual string BirthPlace { get; set; }

    }
}
