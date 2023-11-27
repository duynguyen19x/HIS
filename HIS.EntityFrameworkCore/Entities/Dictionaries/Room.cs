using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    public class Room : AuditedEntity<Guid>
    {
        public string RoomCode { get; set; }
        public string RoomName { get; set; }
        public string MohCode { get; set; }
        public int? RoomTypeId { get; set; }
        public Guid? DepartmentId { get; set; }
        public string Description { get; set; }
        public int? SortOrder { get; set; }
        public bool Inactive { get; set; }

        public virtual RoomType RoomType { get; set; }
        public virtual Department Department { get; set; }
    }
}
