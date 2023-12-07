﻿using AutoMapper.Configuration.Annotations;
using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    public class ServiceRequestData : FullAuditedEntity<Guid>
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

        [Ignore]
        public virtual ServiceRequest ServiceRequest { get; set; }
        [Ignore]
        public virtual Service Service { get; set; }


        public ServiceRequestData() { }
    }
}