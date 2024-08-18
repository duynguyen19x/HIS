using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Constants;
using System.ComponentModel.DataAnnotations;

namespace HIS.EntityFrameworkCore.Entities
{
    public class Examination : AuditedEntity<Guid>
    {
        public DateTime ExaminationDate { get; set; }
        public int ExaminationTypeId { get; set; }
        public Guid BranchId { get; set; } // chi nhánh làm việc
        public Guid MedicalRecordId { get; set; } // mã bệnh án
        public Guid TreatmentId { get; set; } // mã điều trị
        public Guid? OrderId { get; set; } // mã phiếu chỉ định (nếu là dịch vụ khám)
        public Guid? ReceptionId { get; set; } // mã tiếp đón

        [StringLength(EntityConst.Length50)]
        public string IcdCode { get; set; }
        [StringLength(EntityConst.Length512)]
        public string IcdName { get; set; }
        [StringLength(EntityConst.Length50)]
        public string IcdSubCode { get; set; }
        [StringLength(EntityConst.Length512)]
        public string IcdText { get; set; }
        [StringLength(EntityConst.Length50)]
        public string TraditionalIcdCode { get; set; } // chẩn đoán bệnh chính theo YHCT
        [StringLength(EntityConst.Length512)]
        public string TraditionalIcdName { get; set; }
        [StringLength(EntityConst.Length50)]
        public string TraditionalIcdSubCode { get; set; }
        [StringLength(EntityConst.Length512)]
        public string TraditionalIcdText { get; set; }

        [StringLength(EntityConst.Length512)]
        public string ChiefComplaint { get; set; } // lý do khám
        public bool IsAllergy { get; set; } // có dịch ứng
        [StringLength(EntityConst.Length512)]
        public string AllergyHistory { get; set; } // tiền sử dị ứng (dị nguyên)
        [StringLength(EntityConst.Length512)]
        public string PathologicalProcess { get; set; } // quá trình bệnh lý
        [StringLength(EntityConst.Length512)]
        public string GeneralExam { get; set; } // khám bệnh (toàn thân)
        [StringLength(EntityConst.Length512)]
        public string PartExam { get; set; } // khám bệnh (các bộ phận)

        public decimal? Pulse { get; set; } // mạch
        public decimal? Temperature { get; set; } // nhiệt độ
        public decimal? SpO2 { get; set; } // SPO2
        public decimal? BloodPressureLow { get; set; } // huyết áp
        public decimal? BloodPressureHight { get; set; } // huyết áp
        public decimal? RespiratoryRate { get; set; } // nhịp thở
        public decimal? Weight { get; set; } // cân nặng
        public decimal? Height { get; set; } // chiều cao

        [StringLength(EntityConst.Length1024)]
        public string Description { get; set; }
    }
}
