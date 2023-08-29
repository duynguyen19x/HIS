using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Phiếu chỉ định dịch vụ.
    /// </summary>
    public class ServiceRequest : FullAuditedEntity<Guid>
    {
        public virtual string Code { get; set; }
        public virtual string GroupCode { get; set; }

        public virtual Guid PatientID { get; set; }
        public virtual Guid PatientRecordID { get; set; }
        public virtual Guid MedicalRecordID { get; set; }
        public virtual Guid TreatmentID { get; set; }
        public virtual Guid BranchID { get; set; }

        public virtual DateTime RequestTime { get; set; } // thời gian chỉ định 
        public virtual Guid RequestDepartmentID { get; set; } // khoa chỉ định
        public virtual Guid RequestRoomID { get; set; } // phòng chỉ định

        public virtual DateTime? ExecuteTime { get; set; } // thời gian thực hiện
        public virtual Guid? ExecuteDepartmentID { get; set; } // khoa thực hiện
        public virtual Guid? ExecuteRoomID { get; set; } // phòng thực hiện

        public virtual string Description { get; set; }
        public virtual int Status { get; set; }
    }
}
