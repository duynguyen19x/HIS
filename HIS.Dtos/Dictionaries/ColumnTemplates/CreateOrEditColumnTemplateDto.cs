using HIS.Application.Core.Services.Dto;
using HIS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.ColumnTemplates
{
    public class CreateOrEditColumnTemplateDto
    {
        public string TemplateName { get; set; }
        public int RefType { get; set; }
        public IList<ColumnTemplateDto> Details { get; set; }
    }
}
