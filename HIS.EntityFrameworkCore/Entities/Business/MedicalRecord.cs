using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Bệnh án.
    /// </summary>
    public class MedicalRecord : FullAuditedEntity<Guid>
    {
        public Guid PatientRecordID { get; set; }
        public string MedicalRecordCode { get; set; }
        public DateTime MedicalRecordDate { get; set; }

        public Guid DepartmentID { get; set; }
        public Guid RoomID { get; set; }
        public string ICDCode { get; set; } // mã bệnh chính
        public string ICDName { get; set; } // tên bệnh chính
        public string ICDSubCode { get; set; } // mã bệnh phụ
        public string ICDText { get; set; } 



        public MedicalRecord() { }
    }
}
