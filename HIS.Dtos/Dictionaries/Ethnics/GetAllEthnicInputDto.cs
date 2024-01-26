using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Ethnics
{
    public class GetAllEthnicInputDto : PagedResultRequestDto
    {
        public string EthnicCodeFilter { get; set; }
        public string EthnicNameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
