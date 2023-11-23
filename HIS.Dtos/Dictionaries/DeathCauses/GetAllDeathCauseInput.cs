using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.DeathCauses
{
    public class GetAllDeathCauseInput : PagedResultRequestDto
    {
        public string DeathCauseCodeFilter { get; set; }
        public string DeathCauseNameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
