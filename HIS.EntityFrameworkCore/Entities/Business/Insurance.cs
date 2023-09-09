using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thông tin bảo hiểm của bệnh nhân được sử dụng trong đợt điều trị.
    /// </summary>
    public class Insurance : AuditedEntity<Guid>
    { 
        public virtual string Code { get; set; } // số thẻ bhyt
        public virtual DateTime FromDate { get; set; } // từ ngày
        public virtual DateTime ToDate { get; set; } // đến ngày
        public virtual string MediOrgCode { get; set; } // nơi đăng kyus kcb ban đầu
        public virtual string MediOrgName { get; set; } // tên nơi đăng ký kcb ban đầu
        public virtual string Address { get; set; } // địa chỉ nơi đăng ký kcb ban đầu
        public virtual string LevelCode { get; set; } // tuyến kcb
        public virtual string LiveAreaCode { get; set; } // nơi sống (K1, K2, K3)
        public virtual bool HasBirthCertificate { get; set; } // TE có giấy khai sinh  
        public virtual DateTime? FreeCoPaidDate { get; set; } // ngày miễn cùng chi trả
        public virtual DateTime? Join5YearDate { get; set; } // ngày đóng đủ 5 năm liên tục

        public virtual Guid PatientId { get; set; }
        public virtual Guid PatientRecordId { get; set; }
    }
}
