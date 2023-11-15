using AutoMapper.Configuration.Annotations;
using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Sổ thu, chi.
    /// </summary>
    public class AccountBook : AuditedEntity<Guid>
    {
        public virtual string Code { get; set; } // mã sổ
        public virtual string Name { get; set; } // tên sổ
        public virtual string TemplateCode { get; set; } // mẫu số
        public virtual string SymbolCode { get; set; } // ký hiệu
        public virtual DateTime ReleaseDate { get; set; } // ngày phát hành
        public virtual int Total { get; set; } // tổng số phiếu
        public virtual int StartValue { get; set; } // băt đầu từ số phiếu
        public virtual int Value { get; set; } // số hiện tại
        public virtual string TransactionTypeList { get; set; } // danh sách loại giao dịch sử dụng sổ (vd: '1;2')
        public virtual string Description { get; set; } // ghi chú
        public virtual bool Inactive { get; set; } // khóa

        [Ignore]
        public virtual User User { get; set; }

        public AccountBook() { }
    }
}
