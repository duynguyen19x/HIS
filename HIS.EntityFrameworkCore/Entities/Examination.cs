using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{

    public class Examination : AuditedEntity<Guid>
    {
        public DateTime ExaminationDate { get; set; }
        public int ExaminationTypeID { get; set; }

        public Guid ReceptionID { get; set; } 
        public Guid MedicalRecordID { get; set; }
        public Guid TreatmentID { get; set; }
        public Guid OrderID { get; set; }
        public Guid BranchID { get; set; }
    }
}
