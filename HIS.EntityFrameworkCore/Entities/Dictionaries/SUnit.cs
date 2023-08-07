using HIS.Core.Entities;
using HIS.EntityFrameworkCore.Entities.Categories;
using System.ComponentModel;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    public class SUnit : Entity<Guid>
    {
        [Description("Mã ĐVT")]
        public string Code { get; set; }

        [Description("Tên ĐVT")]
        public string Name { get; set; }

        [Description("Thứ tự sắp xếp")]
        public int? SortOrder { get; set; }

        public int UnitType { get; set; }

        public bool Inactive { get; set; }

        public IList<SService> SServices { get; set; }
        public IList<SMedicineType> SMedicineTypes { get; set; }
        public IList<SMedicine> SMedicines { get; set; }

        public IList<SMaterial> SMaterials { get; set; }
        public IList<SMaterialType> SMaterialTypes { get; set; }
    }
}
