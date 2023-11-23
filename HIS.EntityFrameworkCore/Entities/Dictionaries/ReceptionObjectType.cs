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
    public class ReceptionObjectType : AuditedEntity<int>
    {
        public string ReceptionObjectTypeCode { get; set; }
        public string ReceptionObjectTypeName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public ReceptionObjectType() { }
        public ReceptionObjectType(int id, string name, int order)
        {
            this.Id = id;
            this.ReceptionObjectTypeCode = id.ToString();
            this.ReceptionObjectTypeName = name;
            this.SortOrder = order;
        }
    }
}
