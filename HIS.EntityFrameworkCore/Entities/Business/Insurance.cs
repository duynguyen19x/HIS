using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// thông tin bảo hiểm (bhyt và các loại bảo hiểm khác, dựng mặc định cho thẻ bhyt).
    /// </summary>
    public class Insurance : FullAuditedEntity<Guid>
    {
        public string InsuranceCode { get; set; }
        public string MediOrgCode { get; set; }
        public string MediOrgName { get; set; }
        public Guid LiveAreaId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Address { get; set; } // địa chỉ
        public int RightRouteTypeId { get; set; } // tuyến kcb
        public DateTime Join5YearTime { get; set; } // ngày đóng đủ 5 năm liên tục
        public DateTime FreeCoPaidTime { get; set; } // ngày miễn cùng chi trả
        public bool HasBirthCertificate { get; set; } // có giấy chứng sinh
        public Guid PatientRecordId { get; set; }
        public Guid PatientId { get; set; }

        [Ignore]
        public PatientRecord PatientRecord { get; set; }
        [Ignore]
        public Patient Patient { get; set; }
        [Ignore]
        public LiveArea LiveArea { get; set; }
        [Ignore]
        public RightRouteType RightRouteType { get; set; }

        public Insurance() { }
    }
}
