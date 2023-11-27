using AutoMapper.Configuration.Annotations;
using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Người nhà bệnh nhân (một bệnh nhân có thể có nhiều người nhà chăm sóc trong quá trình điều trị).
    /// </summary>
    public class Relative : FullAuditedEntity<Guid>
    {
        public Guid RelativeCategoryID { get; set; } // loại quan hệ với bệnh nhân
        public Guid PatientRecordID { get; set; } // hồ sơ bệnh án
        public string RelativeName { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime? IssueDate { get; set; }
        public string IssueBy { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        [Ignore]
        public virtual Career Career { get; set; }
        [Ignore]
        public virtual RelativeCategory RelativeCategory { get; set; }
        [Ignore]
        public virtual MedicalRecord MedicalRecord { get; set; }

        public Relative() { }
    }
}
