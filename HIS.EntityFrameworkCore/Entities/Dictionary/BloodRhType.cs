using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Nhóm máu Rh
    /// </summary>
    [Table("SBloodRhTypes")]
    public class BloodRhType : AuditedEntity<Guid>
    {
        public string BloodRhTypeCode { get; set; }

        public string BloodRhTypeName { get; set; }

        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }
    }
}
