using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.RightRouteTypes
{
    public class RightRouteTypeDto : EntityDto<int>
    {
        public string RightRouteTypeCode { get; set; }
        public string RightRouteTypeName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public RightRouteTypeDto() { }
    }
}
