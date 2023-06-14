using HIS.Dtos.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.ServiceUnit
{
    public  class SServiceUnitDto : EntityDto<Guid?>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public int? SortOrder { get; set; }

        public bool Inactive { get; set; }
    }
}
