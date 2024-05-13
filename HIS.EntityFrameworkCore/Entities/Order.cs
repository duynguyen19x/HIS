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
    /// Phiếu chỉ định dịch vụ
    /// </summary>
    [Table("DOrder")]
    public class Order : AuditedEntity<Guid>
    {
        public string OrderCode { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderTypeID { get; set; }
        public int OrderStatusID { get; set; }
        public Guid PatientID { get; set; }
        public Guid MedicalRecordID { get; set; }
        public Guid TreatmentID { get; set; }
        public Guid BranchID { get; set; }
        public Guid DepartmentID { get; set; }
        public Guid RoomID { get; set; }
        public Guid UserID { get; set; }


    }
}
