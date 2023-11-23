using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.PatientObjectTypes
{
    public class GetAllPatientObjectTypeInput : PagedResultRequestDto
    {
        public string PatientObjectTypeCodeFilter { get; set; }
        public string PatientObjectTypeNameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
