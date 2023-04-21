using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Room
{
    public class GetAllSRoomInput
    {
        public string CodeFilter { get; set; }
        public string NameFilter { get; set; }
        public Guid? DepartmentIdFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
