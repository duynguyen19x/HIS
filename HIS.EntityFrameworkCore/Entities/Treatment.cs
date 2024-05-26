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

        public int TreatmentTypeId { get; set; }

        public int TreatmentStatusId { get; set; }

        public Guid PatientId { get; set; } // mã bệnh nhân

        public Guid MedicalRecordId { get; set; } // mã hồ sơ bệnh án

        public Guid UserId { get; set; } // người tạo đợt điều trị

        public Guid BranchId { get; set; } // chi nhánh làm việc

        public Guid DepartmentId { get; set; }

        public Guid? RoomId { get; set; }

        public Guid? ChamberId { get; set; }

        public Guid? BedId { get; set; }

        public string IcdCode { get; set; } // chẩn đoán bệnh chính

        public string IcdName { get; set; }

        public string IcdSubCode { get; set; }

        public string IcdText { get; set; }

        public string TraditionalIcdCode { get; set; } // chẩn đoán bệnh chính theo YHCT

        public string TraditionalIcdName { get; set; }

        public string TraditionalIcdSubCode { get; set; }

        public string TraditionalIcdText { get; set; }

        public string IcdCauseCode { get; set; } // chẩn đoán nguyên nhân

        public string IcdCauseName { get; set; }

        public DateTime BeginDate { get; set; } // ngày vào khoa

        public string IcdInCode { get; set; } // chẩn đoán vào khoa

        public string IcdInName { get; set; }

        public string IcdInSubCode { get; set; }

        public string IcdInText { get; set; }

        public string TraditionalIcdInCode { get; set; } // chẩn đoán vào khoa theo YHCT

        public string TraditionalIcdInName { get; set; }

        public string TraditionalIcdInSubCode { get; set; }

        public string TraditionalIcdInText { get; set; }

        public DateTime EndDate { get; set; } // ngày ra khoa

        public int TreatmentEndTypeId { get; set; } // hình thức xử trí

        public int TreatmentResultId { get; set; } // kết quả điều trị
    }
}
