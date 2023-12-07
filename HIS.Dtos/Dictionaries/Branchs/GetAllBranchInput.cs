using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Branchs
{
    public class GetAllBranchInput : PagedResultRequestDto
    {
        public string BranchCodeFilter { get; set; }
        public string BranchNameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
