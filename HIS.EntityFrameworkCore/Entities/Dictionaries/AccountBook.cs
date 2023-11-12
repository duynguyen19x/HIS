using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Sổ thu chi.
    /// </summary>
    public class AccountBook : FullAuditedEntity<Guid>
    {
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string TemplateCode { get; set; } // mẫu phiếu thu
        public virtual string SymbolCode { get; set; } // ký hiệu
        public virtual int Total { get; set; } // tổng số phiếu
        public virtual int FromNumberOrder { get; set; } // số bắt đầu
        public virtual int NumberOrder { get; set; } // số phiếu mới nhất đã cấp (tăng lên sau mỗi lần tạo phiếu)
        public virtual DateTime ReleaseDate { get; set; } // ngày bắt đầu sử dụng
        public virtual string Description { get; set; } // ghi chú
        public virtual int SortOrder { get; set; } // thứ tự hiển thị
        public virtual bool Inactive { get; set; } // khóa
        public virtual string TransactionTypeList { get; set; } // loại phiếu thu chi

        public AccountBook() { }
    }
}
