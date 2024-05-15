using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Thông tin dịch vụ được chỉ định
    /// </summary>
    public class ServiceRequest : AuditedEntity<Guid>
    {
        public Guid OrderID { get; set; } // mã phiếu chỉ định dịch vụ
        public Guid MedicalRecordID { get; set; } // mã bệnh án
        public Guid TreatmentID { get; set; } // mã điều trị
        public Guid BranchID { get; set; } // chi nhánh làm việc
        public Guid? ParentID { get; set; } // 
        public Guid? ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string ServiceCode { get; set; }
        public string ServiceNameBHYT { get; set; }
        public string ServiceCodeBHYT { get; set; }
        public Guid? UnitID { get; set; } // đơn vị tính
        public string UnitName { get; set; }
        public string UnitCode { get; set; }
        public decimal OriginalPrice { get; set; } // đơn giá theo đối tượng
        public decimal Price { get; set; } // đơn giá
        public decimal Quantity { get; set; } // số lượng
        public decimal Amount { get; set; } // số tiền thanh toán

        public string Machine { get; set; }
        public string ServiceResult { get; set; } // kết quả
        public string ResultUnit { get; set; } // đơn vị tính của kết quả
        public string ServiceResultDescription { get; set; } // mô tả kết quả (kết quả bình thường trong khoảng giá trị)
        public string ServiceResultLH { get; set; } // đánh giá kết quả trả về (cao hơn (H) hoặc thấp (L) hơn khoảng bình thường)
        
    }
}
