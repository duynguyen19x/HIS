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
        public Guid MedicalRecordId { get; set; }

        public Guid TreatmentId { get; set; }

        public DateTime ReceptionDate { get; set; }

        public Guid UserId { get; set; }

        public Guid BranchId { get; set; } // chi nhánh làm việc

        public Guid DepartmentId { get; set; }

        public Guid RoomId { get; set; } // phòng tiếp đón

        public string Gate { get; set; } // cửa

        public Guid? ServiceId { get; set; } // dịch vụ yêu cầu
         
        public Guid? ExecuteDepartmentId { get; set; } // khoa thực hiện yêu cầu

        public Guid? ExecuteRoomId { get; set; } // phòng thực hiện yêu cầu

        public Guid? ExecuteUserId { get; set; } // người thực hiện

        public int ReceptionObjectTypeId { get; set; } // đối tượng đăng ký khám

        public int PatientObjectTypeId { get; set; } // đối tượng bệnh nhân

        public bool IsPriority { get; set; } // là BN ưu tiên

        public string ChiefComplaint { get; set; } // lý do đến khám

        public string Description { get; set; } // ghi chú tiếp đón
    }
}
