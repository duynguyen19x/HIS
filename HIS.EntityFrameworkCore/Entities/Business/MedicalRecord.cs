using AutoMapper.Configuration.Annotations;
using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thông tin bệnh án theo từng khoa/phòng.
    /// </summary>
    public class MedicalRecord : FullAuditedEntity<Guid>
    {
        //public virtual Guid PatientId { get; set; }
        [Required]
        public virtual Guid PatientRecordID { get; set; }
        [Required]
        public virtual Guid BranchID { get; set; }
        public virtual Guid DepartmentID { get; set; }
        public virtual Guid RoomID { get; set; }
        public virtual Guid BedID { get; set; }
        public int MedicalRecordStatusID { get; set; } // trạng thái bệnh án
        public int MedicalRecordTypeID { get; set; } // loại bệnh án
        public int MedicalRecordEndTypeID { get; set; } // xử trí 
        public virtual DateTime StartDate { get; set; }

        // thông tin ra viện
        public virtual DateTime? EndDate { get; set; }
        
        public virtual string IcdCode { get; set; } // mã bệnh chính (ICD10)
        public virtual string IcdName { get; set; } // tên bệnh chính (ICD10)
        public virtual string IcdSubCode { get; set; } // mã bệnh phụ (ICD10)
        public virtual string IcdSubName { get; set; } // tên bệnh phụ (ICD10)
        public virtual string IcdText { get; set; } // danh sách bệnh kèm theo (ICD10)

        public virtual string Advise { get; set; } // lời dặn của bác sĩ
        public virtual string TreatmentMethod { get; set; } // phương pháp điều trị
        public virtual string Description { get; set; } // ghi chú


        #region thông tin ra viện - tử vong

        public virtual DateTime? DeathTime { get; set; } // thời điểm tử vong
        public virtual string DeathPlace { get; set; } // nơi tử vong
        public virtual string DeathDocumentType { get; set; }
        public virtual string DeathDocumentNumber { get; set; }
        public virtual string DeathDocumentPlace { get; set; }
        public virtual DateTime? DeathDocumentDate { get; set; }
        public virtual int DeathWithinID { get; set; } // thời gian tử vong
        public virtual int DeathCauseID { get; set; } // nguyên nhân tử vong
        public virtual bool IsDeathCertificate { get; set; } // có cấp giấy chứng tử
        public virtual bool IsAutopsy { get; set; } // có khám nghiệm tử thi

        #endregion



        //[Ignore]
        //[ForeignKey(nameof(PatientId))]
        //public virtual Patient PatientFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(PatientRecordID))]
        public virtual PatientRecord PatientRecordFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(BranchID))]
        public virtual Branch BranchFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(DepartmentID))]
        public virtual Department DepartmentFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(RoomID))]
        public virtual Room RoomFk { get; set; }
    }
}
