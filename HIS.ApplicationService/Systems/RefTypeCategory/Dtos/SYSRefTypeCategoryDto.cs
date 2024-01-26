using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Systems.RefTypeCategory
{
    public class SYSRefTypeCategoryDto : EntityDto<int?>
    {
        public string RefTypeCategoryName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
    }
}
