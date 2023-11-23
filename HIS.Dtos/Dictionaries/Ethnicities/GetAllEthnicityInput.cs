using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Ethnicities
{
    public class GetAllEthnicityInput : PagedResultRequestDto
    {
        public string EthnicityCodeFilter { get; set; }
        public string EthnicityNameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
