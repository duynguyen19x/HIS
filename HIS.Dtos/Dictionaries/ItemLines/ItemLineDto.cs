using HIS.Application.Core.Services.Dto;
using System.ComponentModel;

namespace HIS.Dtos.Dictionaries.ItemLines
{
    public class ItemLineDto : EntityDto<Guid?>
    {
        [Description("Mã đường dùng thuốc")]
        public string Code { get; set; }

        [Description("Tên đường dùng thuốc")]
        public string Name { get; set; }

        [Description("Thứ tự sắp xếp")]
        public int? SortOrder { get; set; }

        [Description("Ngưng sử dụng")]
        public bool Inactive { get; set; }
    }
}
