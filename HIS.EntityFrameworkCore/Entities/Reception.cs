using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Thông tin tiếp đón.
    /// </summary>
    [Table("DReception")]
    public class Reception : AuditedEntity<Guid>
    {
        public Guid MedicalRecordID { get; set; }

        public Guid TreatmentID { get; set; }

        public DateTime ReceptionDate { get; set; }

        public Guid UserID { get; set; }

        public Guid BranchID { get; set; } // chi nhánh làm việc

        public Guid DepartmentID { get; set; }

        public Guid RoomID { get; set; } // phòng tiếp đón

        public string Gate { get; set; } // cửa

        public Guid? ServiceID { get; set; } // dịch vụ yêu cầu
         
        public Guid? ExecuteDepartmentID { get; set; } // khoa thực hiện yêu cầu

        public Guid? ExecuteRoomID { get; set; } // phòng thực hiện yêu cầu

        public Guid? ExecuteUserID { get; set; } // người thực hiện

        public int ReceptionObjectTypeID { get; set; } // đối tượng đăng ký khám

        public int PatientObjectTypeID { get; set; } // đối tượng bệnh nhân

        public bool IsPriority { get; set; } // là BN ưu tiên

        public string ChiefComplaint { get; set; } // lý do đến khám

        public string Description { get; set; } // ghi chú tiếp đón
    }
}
