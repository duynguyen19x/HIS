using HIS.Core.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Xã, phường.
    /// </summary>
    public class Ward : AuditedEntity<Guid>
    {
        public string WardCode { get; set; } // mã xã, phường
        public string WardName { get; set; } // tên xã, phường
        public string ShortText { get; set; } // viết tắt (T/H/X)
        public string Description { get; set; } // ghi chú
        public int SortOrder { get; set; } // số thứ tự hiển thị trên danh mục
        public bool Inactive { get; set; } // khóa
        public Guid DistrictId { get; set; }

        public virtual District District { get; set; }
    }
}
