using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.PatientRecords
{
    public class PatientRecordRequestDto : PagedResultRequestDto
    {
        public virtual string PatientRecordCodeFilter { get; set; }
        public virtual string PatientCodeFilter { get; set; }
        public virtual string PatientNameFilter { get; set; }
        public virtual DateTime? BirthFromDateFilter { get; set; }
        public virtual DateTime? BirthToDateFilter { get; set; }
        public virtual DateTime? ReceptionFromDateFilter { get; set; }
        public virtual DateTime? ReceptionToDateFilter { get; set; }
    }
}
