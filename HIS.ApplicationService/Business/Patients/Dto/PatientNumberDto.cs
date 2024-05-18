using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Patients.Dto
{
    public class PatientNumberDto : EntityDto<Guid?>
    {
        public DateTime PatientNumberDate { get; set; }
        public int SortOrder { get; set; }
    }
}
