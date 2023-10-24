using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thông tin phiếu điều trị.
    /// </summary>
    public class Treatment : FullAuditedEntity<Guid>
    {
        public Guid PatientId { get; set; }
        public Guid PatientRecordId { get; set; }
        public Guid MedicalRecordId { get; set; }

        public string TreatmentCode { get; set; } // mã điều trị
        public int TreatmentTypeID { get; set; } // loại điều trị
        public DateTime TreatmentDate { get; set; } // ngày điều trị

        #region dấu hiệu sinh tồn
        public virtual decimal? Temperature { get; set; } // nhiệt độ
        public virtual int TemperatureType { get; set; } // loại nhiệt độ (oC hay oF)
        public virtual decimal? BloodPressureMin { get; set; } // huyết áp
        public virtual decimal? BloodPressureMax { get; set; } // huyết áp
        public virtual decimal? Pulse { get; set; } // mạch
        public virtual decimal? BreathRate { get; set; } // nhịp thở
        public virtual decimal? Weight { get; set; } // cân nặng
        public virtual decimal? Height { get; set; } // chiều cao
        public virtual decimal? SPO2 { get; set; } // chiều cao
        #endregion

        [NotMapped]
        public decimal? VIR_BMI { get; set; } // chỉ số BMI (hiển thị trên dto)
        [NotMapped]
        public decimal? VIR_BODY_SURFACE_AREA { get; set; } // diện tích da (hiển thị trên dto)



        public Guid BranchID { get; set; }
        public Guid DepartmentID { get; set; }
        public Guid RoomID { get; set; }
    }
}
