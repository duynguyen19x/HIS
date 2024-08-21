using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Categories;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    public class ServiceRequestDetail : FullAuditedEntity<Guid>
    {
        public Guid? ServiceRequestId { get; set; } // phiếu chỉ định
        public Guid? InsuranceId { get; set; } // bảo hiểm
        public Guid ServiceId { get; set; } // dịch vụ
        public string ServiceName { get; set; }
        public DateTime? StartTime { get; set; } // thời gian bắt đầu thực hiện
        public DateTime? EndTime { get; set; } // thời gian kết thúc
        public bool IsSampled { get; set; } // lấy mẫu bệnh phẩm
        public DateTime? SampleTime { get; set; } // thời gian lấy mẫu bệnh phẩm
        public Guid? SampleRoomId { get; set; } // phòng lấy mẫu bệnh phẩm
        public decimal OriginalPrice { get; set; }
        public decimal Price { get; set; } // đơn giá
        public decimal Quantity { get; set; } // số lượng
        public decimal Amount { get; set; } // thành tiền
        public decimal DiscountAmount { get; set; } // chiết khấu

        public int PatientTypeId { get; set; } // đối tượng
        public string Description { get; set; }

        [Ignore]
        public virtual ServiceRequest ServiceRequest { get; set; }
        [Ignore]
        public virtual Service Service { get; set; }


        public ServiceRequestDetail() { }
    }
}
