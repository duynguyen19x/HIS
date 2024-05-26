using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.HospitalSpecialities.Dto
{
    public class GetAllHospitalSpecialityInputDto : PagedAndSortedResultRequestDto
    {
        public string HospitalSpecialityCodeFilter { get; set; }
        public string HospitalSpecialityNameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
