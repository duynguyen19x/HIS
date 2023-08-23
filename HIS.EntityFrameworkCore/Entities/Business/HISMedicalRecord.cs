using AutoMapper.Configuration.Annotations;
using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thông tin bệnh án theo từng khoa/phòng.
    /// </summary>
    public class HISMedicalRecord : FullAuditedEntity<Guid>
    {
        public virtual Guid PatientId { get; set; }
        public virtual Guid PatientRecordId { get; set; }
        public virtual Guid BranchId { get; set; }
        public virtual Guid DepartmentId { get; set; }
        public virtual Guid RoomId { get; set; }
        public virtual Guid BedId { get; set; }
        public int MedicalRecordStatusId { get; set; } // trạng thái bệnh án
        public int MedicalRecordTypeId { get; set; } // loại bệnh án
        public int MedicalRecordEndTypeId { get; set; } // xử trí 
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }

        [Ignore]
        [ForeignKey(nameof(PatientId))]
        public virtual HISPatient PatientFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(PatientRecordId))]
        public virtual HISPatientRecord PatientRecordFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(BranchId))]
        public virtual SBranch BranchFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(DepartmentId))]
        public virtual SDepartment DepartmentFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(RoomId))]
        public virtual SRoom RoomFk { get; set; }
    }
}
