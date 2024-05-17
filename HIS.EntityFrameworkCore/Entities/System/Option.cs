﻿using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.System
{
    /// <summary>
    /// Tùy chọn.
    /// </summary>
    [Table("SYSOption")]
    public class Option : AuditedEntity<Guid>
    {
        [MaxLength(128)]
        [Required]
        public string Code { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// Nhóm tùy chọn.
        /// </summary>
        public int OptionCategoryId { get; set; }

        /// <summary>
        /// Tùy chọn của chi nhánh.
        /// </summary>
        public Guid? BranchId { get; set; }

        /// <summary>
        /// Tùy chọn của người dùng.
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// Giá trị
        /// </summary>
        public string OptionValue { get; set; }

        /// <summary>
        /// Loại giá trị
        /// </summary>
        public int ValueType { get; set; }

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

        [MaxLength(512)]
        public string Description { get; set; }

        public int SortOrder { get; set; }

        [ForeignKey(nameof(OptionCategoryId))]
        public virtual OptionCategory OptionCategoryFk { get; set; }

        [ForeignKey(nameof(BranchId))]
        public virtual Branch BranchFk { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User UserFk { get; set; }
    }
}
