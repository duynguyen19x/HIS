using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.ServiceGroup
{
    public class SServiceGroupDto : EntityDto<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int? SortOrder { get; set; }
        public bool Inactive { get; set; }
    }
}
