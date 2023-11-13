using HIS.Core.Entities;
using HIS.Core.Entities.Auditing;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Loại đăng ký khám.
    /// </summary>
    public class ReceptionType : AuditedEntity<int>
    {
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int SortOrder { get; set; }
        public virtual bool Inactive { get; set; }

        public ReceptionType() { }
        public ReceptionType(int id, string code, string name, int sortOrder)
        {
            this.Id = id;  
            this.Code = code;
            this.Name = name;
            this.SortOrder = sortOrder;
            this.Inactive = false;

            this.CreatedDate = new DateTime(1975, 01, 01);
        }
    }
}
