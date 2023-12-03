using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thẻ dị ứng.
    /// </summary>
    public class Allergy
    {
        public Guid PatientRecordID { get; set; }
        public Guid MedicalRecordID { get; set; }
        public DateTime IssueTime { get; set; } // ngày cấp thẻ

        public string AllergenicName { get; set; } // tên
        public bool IsDoubt { get; set; } // nghi ngờ
        public bool IsSure { get; set; } // chắc chắn
        public string CLINICAL_EXPRESSION { get; set; } // biểu hiện lâm sàng

        public Allergy() { }
    }
}
