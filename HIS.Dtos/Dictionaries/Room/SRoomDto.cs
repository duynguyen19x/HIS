using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Room
{
    public class SRoomDto
    {
        public Guid? Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid DepartmentId { get; set; }
        public bool Inactive { get; set; }
    }
}
