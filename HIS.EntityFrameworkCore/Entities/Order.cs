using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Phiếu chỉ định dịch vụ
    /// </summary>
    public class Order : AuditedEntity<Guid>
    {
        public string OrderCode { get; set; } // mã phiếu chỉ định

        public DateTime OrderDate { get; set; } // ngày y lệnh

        public int OrderTypeID { get; set; }  // loại phiếu chỉ định

        public int OrderStatusID { get; set; } // trạng thái phiếu chỉ định
        
        public Guid UserID { get; set; } // người chỉ định

        public Guid BranchID { get; set; } 

        public Guid DepartmentID { get; set; } // khoa chỉ định

        public Guid RoomID { get; set; } // phòng chỉ định

        public bool IsPaid { get; set; } // đã có dịch vụ trả tiền

        

    }
}
