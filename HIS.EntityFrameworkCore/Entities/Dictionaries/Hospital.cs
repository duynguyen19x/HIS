using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    public class Hospital : AuditedEntity<Guid>
    {
        public string Code { get; set; } // mã bệnh viện
        public string MohCode { get; set; } // mã đăng ký kcb ban đầu
        public string Name { get; set; }
        public string Grade { get; set; } // hạng bệnh viện
        public string Line { get; set; } // tuyến bệnh viện
        public string Type { get; set; } // loại bệnh viện
        public string Address { get; set; } // địa chỉ
        public string Description { get; set; }
        public bool Inactive { get; set; }
    }
}
