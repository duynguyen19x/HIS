﻿using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Business.ServiceResultDatas;

namespace HIS.Dtos.Business.ServiceRequestDatas
{
    public class ServiceRequestDetailDto : EntityDto<Guid>
    {
        public Guid? ServiceRequestId { get; set; } // phiếu chỉ định
        public Guid? InsuranceId { get; set; } // bảo hiểm
        public Guid? ServiceId { get; set; } // dịch vụ
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? SampleTime { get; set; } // thời gian lấy mẫu bệnh phẩm
        public decimal Price { get; set; } // đơn giá
        public decimal Quantity { get; set; } // số lượng
        public decimal Amount { get; set; } // thành tiền
        public decimal DiscountAmount { get; set; } // chiết khấu

        public int PatientTypeId { get; set; } // đối tượng
        public string Description { get; set; }

        public string ServiceCode { get; set; }
        public string ServiceName { get; set; }

        public IList<ServiceRequestDetailResultDto> ServiceResultDatas { get; set; }
    }
}
