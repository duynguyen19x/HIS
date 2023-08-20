using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.PatientRecord
{
    public class GetAllPatientRecordInputDto : PagedResultRequestDto
    {
        public string CodeFilter { get; set; }
        public Guid? PatientIdFilter { get; set; }
        public string PatientCodeFilter { get; set; }
        public string PatientNameFilter { get; set; }
        public Guid? GenderIdFilter { get; set; }
        public Guid? EthnicityIdFilter { get; set; }
        public Guid? CareerIdFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
