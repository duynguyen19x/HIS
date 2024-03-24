using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Đối tượng đăng ký khám.
    /// </summary>
    public class ReceptionObjectType : AuditedEntity<int>
    {
        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }

        public ReceptionObjectType() { }

        public ReceptionObjectType(int id, string name, int order)
        {
            this.Id = id;
            this.Code = id.ToString();
            this.Name = name;
            this.SortOrder = order;
        }
    }
}
