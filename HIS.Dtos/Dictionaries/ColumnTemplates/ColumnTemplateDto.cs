using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.ColumnTemplates
{
    public class ColumnTemplateDto : EntityDto<Guid>
    {
        public string TemplateName { get; set; }
        public int RefType { get; set; }
        public string FieldName { get; set; }
        public int FieldType { get; set; }
        public string Caption { get; set; }
        public string DefaultCaption { get; set; }
        public string TooltipText { get; set; }
        public bool Visible { get; set; }
        public bool VisibleIndex { get; set; }
        public int Width { get; set; }
        public bool IsReadOnly { get; set; }
        public string Description { get; set; }
    }
}
