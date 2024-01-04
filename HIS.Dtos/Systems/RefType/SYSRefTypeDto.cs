using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Systems
{
    public class SYSRefTypeDto : EntityDto<int>
    {
        public string RefTypeName { get; set; }
        public int? RefTypeCategoryID { get; set; }
        public string RefTypeCategoryName { get; set; }
        public int? ParentID { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
    }
}
