using AutoMapper.Configuration.Annotations;
using HIS.Application.Core.Services.Dto;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Relatives
{
    public class RelativeDto : EntityDto<Guid>
    {
        public string RelativeCode { get; set; } // mã người nhà
        public string RelativeName { get; set; } // tên người nhà
        public DateTime? BirthDate { get; set; } // ngày sinh
        public string IdentificationNumber { get; set; } // số CMND/CCCD
        public DateTime? IssueDate { get; set; } // ngày cấp
        public string IssueBy { get; set; } // người cấp
        public string Tel { get; set; } // số điện thoại cố định
        public string Mobile { get; set; } // số điện thoại di động
        public string Address { get; set; } // địa chỉ
        public Guid? CareerID { get; set; } // nghề nghiệp
        public string Workplace { get; set; } // nơi làm việc
        public Guid RelativeCategoryID { get; set; } // mối quan hệ với bệnh nhân
        public string Description { get; set; } // ghi chú

        public RelativeDto() { }
    }
}
