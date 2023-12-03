using AutoMapper.Configuration.Annotations;
using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
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
        public string MedicalRecordTypeCode { get; set; }
        public string MedicalRecordTypeName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }
        public int MedicalRecordTypeGroupID { get; set; }

        [Ignore]
        public virtual MedicalRecordTypeGroup MedicalRecordTypeGroup { get; set; }

        public MedicalRecordType() { }
        public MedicalRecordType(int id, string name, int groupType, int order)
        {
            this.Id = id;
            this.MedicalRecordTypeCode = id.ToString();
            this.MedicalRecordTypeName = name;
            this.MedicalRecordTypeGroupID = groupType;
            this.SortOrder = order;
        }
    }
}
