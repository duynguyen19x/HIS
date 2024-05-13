using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Thông tin khám, điều trị
    /// </summary>
    [Table("DTreatment")]
    public class Treatment : AuditedEntity<Guid>
    {
        [StringLength(TreatmentConst.MaxTreatmentCodeLength, MinimumLength = TreatmentConst.MinTreatmentCodeLength)]
        public string TreatmentCode { get; set; }
        public DateTime TreatmentDate { get; set; }
        public int TreatmentStatusID { get; set; }
        public int MedicalRecordTypeID { get; set; } // loại bệnh án
        public DateTime? TreatmentStartDate { get; set; }
        public DateTime? TreatmentEndDate { get; set; }
        public Guid? TreatmentPrevID { get; set; }
        public Guid PatientID { get; set; }
        public Guid MedicalRecordID { get; set; }
        public Guid BranchID { get; set; }
        public Guid DepartmentID { get; set; }
        public Guid? RoomID { get; set; }
        public Guid? ChamberID { get; set; }
        public Guid? BedID { get; set; }

        public string IcdInCode { get; set; } // chẩn đoán vào khoa
        public string IcdInName { get; set; }
        public string IcdInSubCode { get; set; }
        public string IcdInText { get; set; }

        public string TraditionalIcdInCode { get; set; } // chẩn đoán vào khoa (YHCT)
        public string TraditionalIcdInName { get; set; }
        public string TraditionalIcdInSubCode { get; set; }
        public string TraditionalIcdInText { get; set; }

        public string IcdCauseCode { get; set; } // chẩn đoán nguyên nhân
        public string IcdCauseName { get; set; }

        public string IcdCode { get; set; } // chẩn đoán bệnh chính
        public string IcdName { get; set; }
        public string IcdSubCode { get; set; }
        public string IcdText { get; set; }

        public string TraditionalIcdCode { get; set; } // chẩn đoán bệnh chính (YHCT)
        public string TraditionalIcdName { get; set; }
        public string TraditionalIcdSubCode { get; set; }
        public string TraditionalIcdText { get; set; }

        public int TreatmentResultID { get; set; } // kết quả điều trị
        public int TreatmentEndTypeID { get; set; } // hình thức ra viện
        public int TreatmentInTypeID { get; set; } // hình thức vào viện (trực tiếp, khoa cấp cứu, khoa khám bệnh, chuyển khoa, ....)
    }
}
