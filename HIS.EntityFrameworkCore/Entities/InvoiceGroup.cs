using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Sổ thanh toán
    /// </summary>
    [Table("SInvoiceGroups")]
    public class InvoiceGroup : AuditedEntity<Guid>
    {
        [MaxLength(50)]
        [Required]
        public virtual string Code { get; set; }

        [MaxLength(255)]
        [Required]
        public virtual string Name { get; set; }

        /// <summary>
        /// Tổng số phiếu
        /// </summary>
        [Required]
        public virtual int Total { get; set; }

        /// <summary>
        /// Số bắt đầu
        /// </summary>
        [Required]
        public virtual int StartNumOrder { get; set; }

        /// <summary>
        /// Mẫu số hóa đơn
        /// </summary>
        [MaxLength(EntityConst.Length256)]
        public virtual string InvTemplateNo { get; set; }

        /// <summary>
        /// Ký hiệu hóa đơn
        /// </summary>
        [MaxLength(EntityConst.Length256)]
        public virtual string InvSeries { get; set; }

        /// <summary>
        /// Danh sách loại phiếu thu, chi được phép sử dụng sổ.
        /// </summary>
        [MaxLength(EntityConst.Length256)]
        public virtual string InvoiceTypeList { get; set; }

        [MaxLength(EntityConst.Length512)]
        public virtual string Description { get; set; }

        public virtual int SortOrder { get; set; }

        public virtual bool Inactive { get; set; }

        /// <summary>
        /// Người tạo
        /// </summary>
        public virtual Guid UserId { get; set; }
    }
}
