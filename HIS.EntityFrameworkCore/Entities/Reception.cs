using HIS.Core.Domain.Entities.Auditing;
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
    /// Tiếp đón
    /// </summary>
    [Table("DReception")]
    public class Reception : AuditedEntity<Guid>
    {
        public virtual Guid PatientID { get; set; }

        public virtual Guid MedicalRecordID { get; set; }

        public virtual Guid TreatmentID { get; set; }

        public virtual DateTime ReceptionDate { get; set; }

        public virtual int ReceptionObjectTypeID { get; set; } // loại đăng ký khám

        public virtual int PatientObjectTypeID { get; set; }

        [MaxLength(512)]
        public virtual string HospitalizationReason { get; set; }

        [MaxLength(255)]
        public virtual string Description { get; set; }

        public virtual Guid BranchID { get; set; }

        public virtual Guid DepartmentID { get; set; }

        public virtual Guid RoomID { get; set; }

        public virtual int Gate { get; set; }

        public virtual Guid UserID { get; set; } // nhân viên đăng ký

        public virtual Guid? ServiceID { get; set; } // dịch vụ

        public virtual Guid? ExecuteDepartmentID { get; set; } // khoa thực hiện dịch vụ

        public virtual Guid? ExecuteRoomID { get; set; } // phòng thực hiện dịch vụ

        public virtual Guid? ExecuteUserID { get; set; }
    }
}
