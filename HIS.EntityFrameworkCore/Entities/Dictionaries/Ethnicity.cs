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
        public string Code { get; set; }
        public string MohCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public Ethnicity() { }
        public Ethnicity(Guid id, string code, string mohCode, string name, int sortOrder)
        {
            this.Id = id;
            this.Code = code;
            this.MohCode = mohCode;
            this.Name = name;
            this.SortOrder = sortOrder;
        }
    }
}
