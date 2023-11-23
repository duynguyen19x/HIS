using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.RelativeCategories
{
    public class GetAllRelativeCategoryInput : PagedResultRequestDto
    {
        public string RelativeCategoryCodeFilter { get; set; }
        public string RelativeCategoryNameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
