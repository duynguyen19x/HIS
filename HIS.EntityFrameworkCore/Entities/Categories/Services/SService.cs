using HIS.EntityFrameworkCore.BaseEntitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class SService : FullAuditingEntity<Guid>
    {
        [Description("Mã dịch vụ")]
        public string Code { get; set; }

        [Description("Tên dịch vụ")]
        public string Name { get; set; }

        [Description("Thứ tự sắp xếp")]
        public int? SoftOrder { get; set; }

        [Description("Đang sử dụng")]
        public bool? IsActive { get; set; }

        public Guid? ServiceTypeId { get; set; }
        public Guid ServiceUnitId { get; set; }
        public Guid ServiceGroupId { get; set; }

        public SServiceUnit SServiceUnit { get; set; }
        public SServiceType SServiceType { get; set; }
        public SServiceGroup SServiceGroup { get; set; }

        public IList<SMedicineType> SMedicineTypes { get; set; }
        public IList<SMedicine> SMedicines { get; set; }

        public IList<SMaterial> SMaterials { get; set; }
        public IList<SMaterialType> SMaterialTypes { get; set; }
    }
}
