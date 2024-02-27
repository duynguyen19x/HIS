using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    /// <summary>
    /// Tùy chọn.
    /// </summary>
    [Table("SYSOption")]
    public class SYSOption : AuditedEntity<Guid>
    {
        [Required]
        [MaxLength(128)]
        public string Code { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// Giá trị
        /// </summary>
        public string OptionValue { get; set; }

        /// <summary>
        /// Loại giá trị
        /// </summary>
        public int ValueType { get; set; }

        [MaxLength(512)]
        public string Description { get; set; }

        public int SortOrder { get; set; }

        /// <summary>
        /// Là cấu hình hình dùng chung (cho chi nhánh).
        /// </summary>
        public bool IsGlobalOption { get; set; } 

        /// <summary>
        /// Là cấu hình của người dùng.
        /// </summary>
        public bool IsUserOption { get; set; }

        /// <summary>
        /// Là cấu hình mặc định của hệ thống (khi thêm mới tùy chọn theo chi nhánh hay người dùng thì thì sao chép từ tùy chọn này).
        /// </summary>
        public bool IsDefault { get; set; }

        public int OptionCategoryID { get; set; }

        public Guid? BranchID { get; set; }

        public Guid? UserID { get; set; }

        [ForeignKey("OptionCategoryID")]
        public SYSOptionCategory OptionCategoryFk { get; set; }

        [ForeignKey("BranchID")]
        public DIBranch BranchFk { get; set; }

        [ForeignKey("UserID")]
        public SYSUser UserFk { get; set; }
    }
}
