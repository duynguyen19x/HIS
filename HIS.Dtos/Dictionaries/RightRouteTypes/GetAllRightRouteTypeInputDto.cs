using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.RightRouteTypes
{
    public class GetAllRightRouteTypeInputDto : PagedResultRequestDto
    {
        public string RightRouteTypeCodeFilter { get; set; }
        public string RightRouteTypeNameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
