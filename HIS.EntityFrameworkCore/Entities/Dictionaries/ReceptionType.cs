using HIS.Core.Entities;
using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Loại tiếp nhận.
    /// </summary>
    public class ReceptionType : AuditedEntity<int>
    {
        [Required]
        [MaxLength(50)]
        public virtual string Code { get; set; }

        [Required]
        [MaxLength(250)]
        public virtual string Name { get; set; }

        [MaxLength(250)]
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
