using HIS.Dtos.Base;
using HIS.Dtos.Dictionaries.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.SurgicalProcedureType
{
    public class SSurgicalProcedureTypeDto : EntityDto<Guid?>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int? SortOrder { get; set; }

        public IList<SServiceDto> SServices { get; set; }
    }
}
