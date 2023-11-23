using AutoMapper.Configuration.Annotations;
using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Người nhà bệnh nhân.
    /// </summary>
    public class Relative : FullAuditedEntity<Guid>
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

        [Ignore]
        public virtual Career Career { get; set; }
        [Ignore]
        public virtual RelativeCategory RelativeCategory { get; set; }

        public Relative() { }
    }
}
