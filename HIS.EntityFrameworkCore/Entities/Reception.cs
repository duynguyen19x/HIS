using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Thông tin tiếp đón.
    /// </summary>
    public class Reception : AuditedEntity<Guid>
    {
        public DateTime ReceptionDate { get; set; }

        public Guid PatientID { get; set; }

        public Guid MedicalRecordID { get; set; }

        public Guid BranchID { get; set; }

        public Guid DepartmentID { get; set; }

        public Guid RoomID { get; set; }

        public Guid UserID { get; set; }

        public string Gate { get; set; }

        public int ReceptionObjectTypeID { get; set; }

        public int PatientObjectTypeID { get; set; }

        public string HospitalizationReason { get; set; }

        public string Description { get; set; }

        public Guid? ServiceID { get; set; } // dịch vụ khám

        public Guid? ExecuteDepartmentID { get; set; } // khoa thực hiện

        public Guid? ExecuteRoomID { get; set; } // phòng thực hiện

        public Guid? ExecuteUserID { get; set; } // 

    }
}
