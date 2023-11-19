using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    public class Exam : FullAuditedEntity<Guid>
    {
        public virtual Guid TreatmentId { get; set; }
        public virtual Guid? TreatmentRecordId { get; set; }
        public virtual Guid BranchId { get; set; }

        public virtual Guid UserId { get; set; }
        public virtual Guid DepartmentId { get; set; }
        public virtual Guid RoomId { get; set; }
    }
}
