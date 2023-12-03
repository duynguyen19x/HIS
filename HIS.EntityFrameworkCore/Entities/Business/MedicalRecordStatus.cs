using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Trạng thái bệnh án. 
    /// </summary>
    public class MedicalRecordStatus : AuditedEntity<int>
    {
        public string MedicalRecordStatusName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public MedicalRecordStatus() { }
    }
}
