using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.ServiceUnit
{
    public class GetAllUnitInput
    {
        public string CodeFilter { get; set; }
        public string NameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
