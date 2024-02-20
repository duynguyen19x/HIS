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
        public string Data { get; set; }

        /// <summary>
        /// Loại giá trị
        /// </summary>
        public int DataType { get; set; }

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

        public int OptionCategoryId { get; set; }

        [ForeignKey("OptionCategoryId")]
        public SYSOptionCategory OptionCategoryFk { get; set; }

        public Guid? BranchId { get; set; }

        [ForeignKey("BranchId")]
        public DIBranch BranchFk { get; set; }

        public Guid? UserId { get; set; }

        [ForeignKey("UserId")]
        public User UserFk { get; set; }
    }
}
