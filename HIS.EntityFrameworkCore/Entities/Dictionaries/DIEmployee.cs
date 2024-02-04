using HIS.Core.Domain.Entities;
using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Nhân viên.
    /// </summary>
    [Table("DIEmployee")]
    public class DIEmployee : AuditedEntity<Guid>
    {
        /// <summary>
        /// Mã nhân viên.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string EmployeeCode { get; set; }

        /// <summary>
        /// Tên nhân viên.
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string EmployeeName { get; set; }

        /// <summary>
        /// Ghi chú
        /// </summary>
        [MaxLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Số thứ tự hiển thị
        /// </summary>
        public int SortOrder { get; set; }

        /// <summary>
        /// Khóa
        /// </summary>
        public bool Inactive { get; set; }
    }
}
