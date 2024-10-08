﻿using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Phòng.
    /// </summary>
    [Table("SRooms")]
    public class Room : AuditedEntity<Guid>
    {
        /// <summary>
        /// Mã phòng, buồng.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public virtual string Code { get; set; }

        /// <summary>
        /// Tên phòng, buồng.
        /// </summary>
        [Required]
        [MaxLength(255)]
        public virtual string Name { get; set; }

        /// <summary>
        /// Mã phòng (BYT)
        /// </summary>
        [MaxLength(50)]
        public virtual string MediCode { get; set; }

        /// <summary>
        /// Loại phòng.
        /// </summary>
        public virtual int RoomTypeId { get; set; }

        /// <summary>
        /// Khoa.
        /// </summary>
        public virtual Guid DepartmentId { get; set; }

        [MaxLength(255)]
        public virtual string Description { get; set; }

        public virtual int SortOrder { get; set; }

        public virtual bool Inactive { get; set; }

        [ForeignKey("RoomTypeId")]
        public RoomType RoomTypeFk { get; set; }

        [ForeignKey("DepartmentId")]
        public Department DepartmentFk { get; set; }
    }
}
