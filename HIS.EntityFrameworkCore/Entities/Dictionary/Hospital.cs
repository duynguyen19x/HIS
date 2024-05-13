using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    [Table("SHospital")]
    public class Hospital : AuditedEntity<Guid>
    {
        [Required]
        [MaxLength(50)]
        public string Code { get; set; } // mã bệnh viện

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string MediOrgCode { get; set; } // mã đăng ký kcb ban đầu

        [MaxLength(50)]
        public string Grade { get; set; } // hạng bệnh viện

        [MaxLength(50)]
        public string Line { get; set; } // tuyến bệnh viện

        [MaxLength(50)]
        public string Type { get; set; } // loại bệnh viện

        [MaxLength(512)]
        public string Address { get; set; } // địa chỉ

        [MaxLength(255)]
        public string Description { get; set; }

        public bool Inactive { get; set; }
    }
}
