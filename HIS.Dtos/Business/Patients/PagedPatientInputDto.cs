using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.Patients
{
    public class PagedPatientInputDto : PagedResultRequestDto
    {
        public virtual string CodeFilter { get; set; }
        public virtual string NameFilter { get; set; }
        
        public virtual DateTime? MaxBirthDateFilter { get; set; }
        public virtual DateTime? MinBirthDateFilter { get; set; }
        public virtual int? MaxBirthYearFilter { get; set; }
        public virtual int? MinBirthYearFilter { get; set; }
        public virtual Guid? GenderIdFilter { get; set; }
        public virtual Guid? CountryIdFilter { get; set; }
        public virtual Guid? EthnicIdFilter { get; set; }
        public virtual Guid? CareerIdFilter { get; set; }

    }
}
