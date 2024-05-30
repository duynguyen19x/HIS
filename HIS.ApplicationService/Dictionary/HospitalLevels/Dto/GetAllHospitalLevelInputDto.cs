using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.HospitalLevels.Dto
{
    public class GetAllHospitalLevelInputDto : PagedAndSortedResultRequestDto
    {
        public string HospitalLevelCodeFilter { get; set; }
        public string HospitalLevelNameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
