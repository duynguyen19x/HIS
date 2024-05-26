using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.HospitalLines.Dto
{
    public class GetAllHospitalLineInputDto : PagedAndSortedResultRequestDto
    {
        public string HospitalLineCodeFilter { get; set; }
        public string HospitalLineNameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
