using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.PatientRecordTypes
{
    public class GetAllPatientRecordTypeInput : PagedResultRequestDto
    {
        public string PatientRecordTypeCodeFilter { get; set; }
        public string PatientRecordTypeNameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
