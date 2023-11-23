using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.TreatmentResults
{
    public class GetAllTreatmentResultInput : PagedResultRequestDto
    {
        public string TreatmentResultCodeFilter { get; set; }
        public string TreatmentResultNameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
