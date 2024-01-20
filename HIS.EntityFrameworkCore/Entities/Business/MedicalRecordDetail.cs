using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// chi tiết bệnh án: phần bệnh án
    /// </summary>
    public class MedicalRecordDetail : AuditedEntity<Guid>
    {
        public Guid PatientRecordID { get; set; }
        public Guid MedicalRecordID { get; set; }

        public string HospitalizationReason { get; set; } // lý do khám, nhập viện (200)
        public string PathologicalProcess { get; set; } // quá trình bệnh lý (4000)
        public string PathologicalHistory { get; set; } // tiền sử bệnh - bản thân (500)
        public string PathologicalHistoryFamily { get; set; } // tiền sử bệnh - gia đình (500)
        public string DeseaseRelationAllergy { get; set; } // đặc điểm liên quan bệnh - dị ứng
        public string DeseaseRelationDrug { get; set; } // đặc điểm liên quan bệnh - ma túy
        public string DeseaseRelationWine { get; set; } // đặc điểm liên quan bệnh - rượu bia
        public string DeseaseRelationTobacco { get; set; } // đặc điểm liên quan bệnh - thuốc lá
        public string DeseaseRelationPipeTobacco { get; set; } // đặc điểm liên quan bệnh - thuốc lào
        public string DeseaseRelationOther { get; set; } // đặc điểm liên quan bệnh - khác

    }
}
