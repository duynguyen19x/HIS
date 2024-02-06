using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Phòng, buồng.
    /// </summary>
    [Table("DIRoom")]
    public class DIRoom : AuditedEntity<Guid>
    {
        /// <summary>
        /// Mã phòng, buồng.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        /// <summary>
        /// Tên phòng, buồng.
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// Mã phòng (BYT)
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string MediCode { get; set; }

        /// <summary>
        /// Loại phòng.
        /// </summary>
        public int RoomTypeId { get; set; }

        /// <summary>
        /// Khoa.
        /// </summary>
        public Guid DepartmentId { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }

        [Ignore]
        public RoomType RoomType { get; set; }

        [Ignore]
        public DIDepartment Department { get; set; }
    }
}
