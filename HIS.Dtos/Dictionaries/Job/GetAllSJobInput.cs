using HIS.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Job
{
    public class GetAllSJobInput
    {
        public string CodeFilter { get; set; }
        public string NameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
