using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.ServiceRequestDatas
{
    public class ServiceRequestDataDto : EntityDto<Guid>
    {
        public Guid ServiceRequestId { get; set; } // phiếu chỉ định
        public Guid? InsuranceId { get; set; } // bảo hiểm
        public Guid ServiceId { get; set; } // dịch vụ
        public string ServiceName { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal Price { get; set; } // đơn giá
        public decimal Quantity { get; set; } // số lượng
        public decimal Amount { get; set; } // thành tiền
        public decimal DiscountAmount { get; set; } // chiết khấu

        public int PatientTypeId { get; set; } // đối tượng
        public string Description { get; set; }
    }
}
