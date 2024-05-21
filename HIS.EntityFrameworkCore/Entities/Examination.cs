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
        public Guid BranchID { get; set; } // chi nhánh làm việc
        public Guid MedicalRecordID { get; set; } // mã bệnh án
        public Guid TreatmentID { get; set; } // mã điều trị
        public Guid? OrderID { get; set; } // mã phiếu chỉ định (nếu là dịch vụ khám)
        public Guid? ReceptionID { get; set; } // mã tiếp đón

        public string IcdCode { get; set; }
        public string IcdName { get; set; }
        public string IcdSubCode { get; set; }
        public string IcdText { get; set; }
        public string TraditionalIcdCode { get; set; } // chẩn đoán bệnh chính theo YHCT
        public string TraditionalIcdName { get; set; }
        public string TraditionalIcdSubCode { get; set; }
        public string TraditionalIcdText { get; set; }

        public string ChiefComplaint { get; set; } // lý do khám
        public bool IsAllergy { get; set; } // có dịch ứng
        public string AllergyHistory { get; set; } // tiền sử dị ứng (dị nguyên)
        public string PathologicalProcess { get; set; } // quá trình bệnh lý
        public string GeneralExam { get; set; } // khám bệnh (toàn thân)
        public string PartExam { get; set; } // khám bệnh (các bộ phận)

        public decimal? Pulse { get; set; } // mạch
        public decimal? Temperature { get; set; } // nhiệt độ
        public decimal? SpO2 { get; set; } // SPO2
        public decimal? BloodPressureLow { get; set; } // huyết áp
        public decimal? BloodPressureHight { get; set; } // huyết áp
        public decimal? RespiratoryRate { get; set; } // nhịp thở
        public decimal? Weight { get; set; } // cân nặng
        public decimal? Height { get; set; } // chiều cao

        public string Desciption { get; set; }
    }
}
