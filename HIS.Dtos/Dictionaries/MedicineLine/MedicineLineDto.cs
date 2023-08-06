using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.MedicineLine
{
    public class MedicineLineDto : EntityDto<Guid?>
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
