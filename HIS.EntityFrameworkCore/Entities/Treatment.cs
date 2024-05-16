using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Điều trị
    /// </summary>
    public class Treatment : AuditedEntity<Guid>
    {
        public string TreatmentCode { get; set; }
        public DateTime TreatmentDate { get; set; }
        public int TreatmentTypeID { get; set; }
        public int TreatmentStatusID { get; set; }
        public Guid PatientID { get; set; }
        public Guid MedicalRecordID { get; set; }
        public Guid UserID { get; set; }
        public Guid BranchID { get; set; }
        public Guid DepartmentID { get; set; }
        public Guid? RoomID { get; set; }
        public Guid? ChamberID { get; set; }
        public Guid? BedID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public int TreatmentEndTypeID { get; set; }
        public int TreatmentResultID { get; set; }
    }
}
