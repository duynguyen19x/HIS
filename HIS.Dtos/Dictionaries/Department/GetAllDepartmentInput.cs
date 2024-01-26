using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Department
{
    public class GetAllDepartmentInput : PagedResultRequestDto
    {
        public string DepartmentCodeFilter { get; set; }
        public string DepartmentNameFilter { get; set; }
        public Guid? BranchFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
