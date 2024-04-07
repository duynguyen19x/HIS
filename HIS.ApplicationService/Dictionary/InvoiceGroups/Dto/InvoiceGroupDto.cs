using HIS.ApplicationService.Dictionary.InvoiceTypes.Dto;
using HIS.ApplicationService.Systems.Users.Dto;
using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.InvoiceGroups.Dto
{
    public class InvoiceGroupDto : EntityDto<Guid?>
    {
        public virtual string Code { get; set; }

        public virtual string Name { get; set; }

        /// <summary>
        /// Tổng số phiếu
        /// </summary>
        public virtual int Total { get; set; }

        /// <summary>
        /// Số bắt đầu
        /// </summary>
        public virtual int StartNumOrder { get; set; }

        /// <summary>
        /// Danh sách loại phiếu thu, chi được phép sử dụng sổ.
        /// </summary>
        public virtual string InvoiceTypeList { get; set; }

        public virtual string Description { get; set; }

        public virtual int SortOrder { get; set; }

        /// <summary>
        /// Người tạo
        /// </summary>
        public virtual Guid UserId { get; set; }

        /// <summary>
        /// Danh sách loại phiếu
        /// </summary>
        public virtual IList<InvoiceTypeDto> InvoiceTypes { get; set; }

        /// <summary>
        /// Danh sách người dùng được phân quyền sử dụng
        /// </summary>
        public virtual IList<UserDto> Users { get; set; }
    }
}
