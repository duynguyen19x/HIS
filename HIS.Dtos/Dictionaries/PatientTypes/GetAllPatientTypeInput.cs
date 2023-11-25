using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.PatientTypes
{
    public class GetAllPatientTypeInput : PagedResultRequestDto
    {
        public string PatientTypeCodeFilter { get; set; }
        public string PatientTypeNameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
