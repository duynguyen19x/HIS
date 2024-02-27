using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.Role.Dtos
{
    public class GetAllSYSRoleInputDto : PagedAndSortedResultRequestDto
    {
        public string RoleCodeFilter { get; set; }

        public string RoleNameFilter { get; set; }

        public bool? InactiveFilter { get; set; }
    }
}
