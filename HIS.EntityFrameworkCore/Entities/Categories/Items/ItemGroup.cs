using HIS.Core.Domain.Entities;
using HIS.Core.Domain.Entities.Auditing;
using HIS.Utilities.Enums;
using System.ComponentModel;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class ItemGroup : AuditedEntity<Guid>
    {
        [Description("Mã nhóm thuốc")]
        public string Code { get; set; }

        [Description("Tên nhóm thuốc")]
        public string Name { get; set; }

        [Description("Thứ tự sắp xếp")]
        public int? SortOrder { get; set; }

        [Description("Ngưng sử dụng")]
        public bool Inactive { get; set; }

        [Description("Dữ liệu gốc")]
        public bool IsSystem { get; set; }

        [Description("Loại hàng hóa")]
        public CommodityTypes CommodityType { get; set; }
    }
}
