using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.RelativeTypes
{
    public class GetAllRelativeTypeInputDto : PagedResultRequestDto
    {
        public string RelativeTypeCodeFilter { get; set; }
        public string RelativeTypeNameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
