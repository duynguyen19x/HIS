using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.TreatmentEndTypes
{
    public class GetAllTreatmentEndTypeInput : PagedResultRequestDto
    {
        public string TreatmentEndTypeCodeFilter { get; set; }
        public string TreatmentEndTypeNameFilter { get; set; }
        public bool? IsForOutPatientFilter { get; set; }
        public bool? IsForInPatientFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
