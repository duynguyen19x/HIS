using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Dân tộc
    /// </summary>
    public class Ethnicity : AuditedEntity<Guid>
    {
        public string EthnicityCode { get; set; } // mã dân tộc
        public string EthnicityName { get; set; } // tên dân tộc
        public string MohCode { get; set; } // mã theo BYT
        public string Description { get; set; } // ghi chú
        public int SortOrder { get; set; } // thứ tự hiển thị
        public bool Inactive { get; set; } // khóa

        public Ethnicity() { }
        public Ethnicity(Guid id, string code, string mohCode, string name, int sortOrder)
        {
            this.Id = id;
            this.EthnicityCode = code;
            this.EthnicityName = name;
            this.MohCode = mohCode;
            this.SortOrder = sortOrder;
        }
    }
}
