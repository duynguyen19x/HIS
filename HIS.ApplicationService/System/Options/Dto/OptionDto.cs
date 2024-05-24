using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.System.Options.Dto
{
    public class OptionDto : EntityDto<Guid?>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public int OptionCategoryId { get; set; }

        public Guid? BranchId { get; set; }

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

        public string Description { get; set; }

        public int SortOrder { get; set; }
    }
}
