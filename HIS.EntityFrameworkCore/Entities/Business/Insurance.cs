using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thông tin bảo hiểm
    /// </summary>
    [Table("DInsurance")]
    public class Insurance : FullAuditedEntity<Guid>
    {
        public virtual Guid PatientId { get; set; }

        public virtual Guid PatientRecordId { get; set; }

        /// <summary>
        /// Số thẻ
        /// </summary>
        [MaxLength(50)]
        public virtual string Code { get; set; }

        /// <summary>
        /// Nơi KCBBĐ
        /// </summary>
        [MaxLength(50)]
        public virtual string MediOrgCode { get; set; }

        /// <summary>
        /// Tên nơi KCBBĐ
        /// </summary>
        [MaxLength(255)]
        public virtual string MediOrgName { get; set; }

        /// <summary>
        /// Hạn thẻ từ ngày
        /// </summary>
        public virtual DateTime FromDate { get; set; }

        /// <summary>
        /// Hạn thẻ đến ngày
        /// </summary>
        public virtual DateTime ToDate { get; set; }

        /// <summary>
        /// Khu vực
        /// </summary>
        public virtual Guid? LiveAreaId { get; set; }

        /// <summary>
        /// Địa chỉ thẻ
        /// </summary>
        [MaxLength(255)]
        public virtual string Address { get; set; }

        /// <summary>
        /// Tuyến KCB
        /// </summary>
        public int RightRouteTypeId { get; set; }

        public DateTime Join5YearTime { get; set; } // ngày đóng đủ 5 năm liên tục

        public DateTime FreeCoPaidTime { get; set; } // ngày miễn cùng chi trả

        public bool HasBirthCertificate { get; set; } // có giấy chứng sinh

        [ForeignKey("LiveAreaId")]
        public virtual LiveArea LiveAreaFk { get; set; }

        [ForeignKey("RightRouteTypeId")]
        public virtual RightRouteType RightRouteTypeFk { get; set; }
    }
}
