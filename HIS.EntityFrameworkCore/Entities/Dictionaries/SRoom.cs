using HIS.EntityFrameworkCore.BaseEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    public class SRoom : AuditingEntity<Guid>
    {
        public string Code { get; set; }
        public string MohCode { get; set; }
        public string Name { get; set; }
        public Guid RoomTypeId { get; set; }
        public Guid DepartmentId { get; set; }
        public string Description { get; set; }
        public int? SortOrder { get; set; }
        public bool Inactive { get; set; }

        public virtual SRoomType SRoomType { get; set; }
        public virtual SDepartment SDepartment { get; set; }

        public IList<SExecutionRoom> ExecutionRooms { get; set; }
    }
}
