using HIS.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.RelativeTypes
{
    public class RelativeTypeDto : EntityDto<Guid>
    {
        public string RelativeTypeCode { get; set; }
        public string RelativeTypeName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public RelativeTypeDto() { }
    }
}
