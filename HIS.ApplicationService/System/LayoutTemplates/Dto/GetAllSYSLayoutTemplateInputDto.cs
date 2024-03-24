using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.LayoutTemplates.Dto
{
    public class GetAllSYSLayoutTemplateInputDto : PagedAndSortedResultRequestDto
    {
        public string LayoutTemplateCodeFilter { get; set; }

        public string LayoutTemplateNameFilter { get; set; }

        public bool? IsPublicFilter { get; set; }

        public Guid? UserFilter { get; set; }
    }
}
