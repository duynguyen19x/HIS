using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// bệnh án.
    /// </summary>
    public class MedicalRecord : FullAuditedEntity<Guid>
    {
        public Guid PatientId { get; set; }
        public Guid PatientRecordId { get; set; }

        public DateTime MedicalRecordDate { get; set; }
        public Guid BranchId { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid RooomId { get; set; }

        public string IcdCode { get; set; } // mã bệnh
        public string IcdName { get; set; } // tên bệnh
        public string IcdSubCode { get; set; } // mã bệnh kèm theo
        public string IcdText { get; set; } // danh sách mã bệnh kèm theo
    }
}
