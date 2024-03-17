using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.Permission.Dtos
{
    public class GetAllSYSPermissionInputDto : PagedAndSortedResultRequestDto
    {
        public string PermissionNameFilter { get; set; }
    }
}
