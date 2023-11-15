﻿using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Dictionaries.UserAccountBooks;
using HIS.Dtos.Systems.User;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries
{
    /// <summary>
    /// Sổ thu, chi.
    /// </summary>
    public class AccountBookDto : EntityDto<Guid>
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

        public virtual IList<UserAccountBookDto> Users { get; set; } // danh sách user được phân quyền sử dụng sổ
    }
}
