using HIS.Core.Entities;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Dân tộc
    /// </summary>
    public class Ethnic : Entity<Guid>
    {
        public string Code { get; set; } // mã dân tộc
        public string Name { get; set; } // tên dân tộc
        public string MohCode { get; set; } // mã theo BYT
        public string Description { get; set; } // ghi chú
        public int SortOrder { get; set; } // thứ tự hiển thị
        public bool Inactive { get; set; } // khóa

        public Ethnic() { }
        public Ethnic(Guid id, string code, string mohCode, string name, int sortOrder)
        {
            this.Id = id;
            this.Code = code;
            this.Name = name;
            this.MohCode = mohCode;
            this.SortOrder = sortOrder;
        }
    }
}
