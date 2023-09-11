using AutoMapper.Configuration.Annotations;
using HIS.Core.Entities.Auditing;
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
    /// Loại bệnh án.
    /// </summary>
    public class MedicalRecordType : AuditedEntity<int>
    {
        [MaxLength(50)]
        public virtual string Code { get; set; }

        [MaxLength(250)]
        public virtual string Name { get; set; }

        public virtual int GroupTypeId { get; set; }

        [MaxLength(250)]
        public virtual string Description { get; set; }

        public virtual int SortOrder { get; set; }

        public virtual bool Inactive { get; set; }

        public MedicalRecordType() { }

        public MedicalRecordType(int id, string code, string name, int groupTypeId, string description, int sortOrder, bool inactive)
        {
            this.Id = id;
            this.Code = code;
            this.Name = name;
            this.GroupTypeId = groupTypeId;
            this.Description = description;
            this.SortOrder = sortOrder;
            this.Inactive = inactive;

            this.CreatedDate = new DateTime(1975, 01, 01);
        }
    }
}
