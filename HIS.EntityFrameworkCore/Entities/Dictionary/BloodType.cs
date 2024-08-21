using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Nhóm máu
    /// </summary>
    [Table("SBloodTypes")]
    public class BloodType : AuditedEntity<Guid>
    {
        public string BloodTypeCode { get; set; }

        public string BloodTypeName { get; set; }

        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }
    }
}
