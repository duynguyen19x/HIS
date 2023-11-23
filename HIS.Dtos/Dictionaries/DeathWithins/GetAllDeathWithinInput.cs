using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.DeathWithins
{
    public class GetAllDeathWithinInput : PagedResultRequestDto
    {
        public string DeathWithinCodeFilter { get; set; }
        public string DeathWithinNameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
