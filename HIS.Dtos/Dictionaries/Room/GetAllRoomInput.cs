using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Room
{
    public class GetAllRoomInput
    {
        public string CodeFilter { get; set; }
        public string NameFilter { get; set; }
        public int? RoomTypeIdFilter { get; set; }
        public Guid? DepartmentIdFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
