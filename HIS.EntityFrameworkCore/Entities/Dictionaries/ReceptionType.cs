using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Đối tượng đăng ký khám.
    /// </summary>
    public class ReceptionType : AuditedEntity<int>
    {
        public string ReceptionTypeCode { get; set; }
        public string ReceptionTypeName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public ReceptionType() { }
        public ReceptionType(int id, string name, int order)
        {
            this.Id = id;
            this.ReceptionTypeCode = id.ToString();
            this.ReceptionTypeName = name;
            this.SortOrder = order;
        }
    }
}
