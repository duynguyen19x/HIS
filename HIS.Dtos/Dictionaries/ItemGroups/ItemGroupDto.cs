using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.ItemGroups
{
    public class ItemGroupDto : EntityDto<Guid?>
    {
        [Description("Mã nhóm thuốc")]
        public string Code { get; set; }

        [Description("Tên nhóm thuốc")]
        public string Name { get; set; }

        [Description("Thứ tự sắp xếp")]
        public int? SortOrder { get; set; }

        [Description("Dữ liệu gốc")]
        public bool IsSystem { get; set; }

        [Description("Ngưng sử dụng")]
        public bool Inactive { get; set; }
    }
}
