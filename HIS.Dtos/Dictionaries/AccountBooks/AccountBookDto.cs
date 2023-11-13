using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Dictionaries.UserAccountBooks;

namespace HIS.Dtos.Dictionaries.AccountBooks
{
    public class AccountBookDto : EntityDto<Guid>
    {
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string TemplateCode { get; set; } // mẫu phiếu thu
        public virtual string SymbolCode { get; set; } // ký hiệu
        public virtual int Total { get; set; } // tổng số phiếu
        public virtual int FromNumberOrder { get; set; } // số bắt đầu
        public virtual DateTime ReleaseDate { get; set; } // ngày bắt đầu sử dụng
        public virtual string Description { get; set; } // ghi chú
        public virtual int SortOrder { get; set; } // thứ tự hiển thị
        public virtual bool Inactive { get; set; } // khóa
        public virtual Guid UserId { get; set; } // người tạo phiếu
        public virtual string TransactionTypeList { get; set; } // danh sách loại phiếu thu, chi
    }
}
