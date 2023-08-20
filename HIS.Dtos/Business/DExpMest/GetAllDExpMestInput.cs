using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.DExpMest
{
    public class GetAllDExpMestInput
    {
        public string CodeFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
