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
    /// Loại điều trị.
    /// </summary>
    public class PatientRecordType : AuditedEntity<int>
    {
        [MaxLength(50)]
        public virtual string Code { get; set; }

        [MaxLength(250)]
        public virtual string Name { get; set; }

        [MaxLength(250)]
        public virtual string Description { get; set; }

        public virtual int SortOrder { get; set; }

        public virtual bool Inactive { get; set; }

        public PatientRecordType() { }

        public PatientRecordType(int id, string code, string name, string description, int sortOrder, bool inactive)
        {
            this.Id = id;
            this.Code = code;
            this.Name = name;
            this.Description = description;
            this.SortOrder = sortOrder;
            this.Inactive = inactive;

            this.CreatedDate = new DateTime(1975, 01, 01);
        }
    }
}
