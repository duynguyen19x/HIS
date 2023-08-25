using HIS.Core.Entities;
using HIS.EntityFrameworkCore.Entities.Categories;
using System.ComponentModel;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    public class Unit : Entity<Guid>
    {
        [Description("Mã ĐVT")]
        public string Code { get; set; }

        [Description("Tên ĐVT")]
        public string Name { get; set; }

        [Description("Thứ tự sắp xếp")]
        public int? SortOrder { get; set; }

        public int UnitType { get; set; }

        public bool Inactive { get; set; }

        public IList<Service> Services { get; set; }
        public IList<MedicineType> MedicineTypes { get; set; }
        public IList<Medicine> Medicines { get; set; }

        public IList<Material> Materials { get; set; }
        public IList<MaterialType> MaterialTypes { get; set; }
    }
}
