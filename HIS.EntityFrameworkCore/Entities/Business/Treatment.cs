using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thông tin phiếu điều trị.
    /// </summary>
    public class Treatment : FullAuditedEntity<Guid>
    {
        public Guid PatientID { get; set; }
        public Guid PatientRecordID { get; set; }
        public Guid MedicalRecordID { get; set; }

        public string TreatmentCode { get; set; } // mã điều trị
        public int TreatmentTypeID { get; set; } // loại điều trị
        public DateTime TreatmentDate { get; set; } // ngày điều trị

        public Guid BranchID { get; set; }
        public Guid DepartmentID { get; set; }
        public Guid RoomID { get; set; }
    }
}
