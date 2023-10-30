using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.ColumnTemplates
{
    public class PagedColumnTemplateResultRequestDto : PagedResultRequestDto
    {
        public int? MaxRefTypeFilter { get; set; }
        public int? MinRefTypeFilter { get; set; }
        public string TemplateNameFilter { get; set; }
        public bool? VisibleFilter { get; set; }
    }
}
