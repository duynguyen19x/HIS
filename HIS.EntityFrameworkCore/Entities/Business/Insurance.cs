using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thông tin bảo hiểm y tế.
    /// </summary>
    public class Insurance : FullAuditedEntity<Guid>
    {
        public Guid MedicalRecordID { get; set; }

    }
}
