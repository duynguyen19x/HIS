using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thông tin chi tiết bệnh án khám bệnh theo khoa/phòng.
    /// </summary>
    public class HISMedicalRecordExam : AuditedEntity<Guid>
    {
        public virtual Guid MedicalRecordId { get; set; }

    }
}
