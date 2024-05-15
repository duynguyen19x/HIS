using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Thông tin bệnh án
    /// </summary>
    public class MedicalRecord : AuditedEntity<Guid>
    {
        public Guid PatientID { get; set; }
        public string MedicalRecordCode { get; set; }
        public DateTime MedicalRecordDate { get; set; }
        public int MedicalRecordTypeID { get; set; }
        public int MedicalRecordStatusID { get; set; }

        public Guid BranchID { get; set; }
        public Guid DepartmentID { get; set; }
        public Guid RoomID { get; set; }
        public Guid UserID { get; set; }

        public DateTime ReceptionDate { get; set; }

        public string Description { get; set; }
        
    }
}
