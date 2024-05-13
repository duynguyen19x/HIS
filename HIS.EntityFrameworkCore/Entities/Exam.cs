using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Thông tin khám bệnh
    /// </summary>
    [Table("DExam")]
    public class Exam : AuditedEntity<Guid>
    {
        public Guid PatientID { get; set; }
        public Guid MedicalRecordID { get; set; }
        public Guid TreatmentID { get; set; }



    }
}
