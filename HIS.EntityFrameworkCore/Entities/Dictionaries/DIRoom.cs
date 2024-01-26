using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Phòng, buồng.
    /// </summary>
    public class DIRoom : AuditedEntity<Guid>
    {
        /// <summary>
        /// Mã phòng, buồng.
        /// </summary>
        public string RoomCode { get; set; }

        /// <summary>
        /// Tên phòng, buồng.
        /// </summary>
        public string RoomName { get; set; }

        /// <summary>
        /// Mã phòng (BYT)
        /// </summary>
        public string MediCode { get; set; }

        /// <summary>
        /// Loại phòng.
        /// </summary>
        public int RoomTypeID { get; set; }

        /// <summary>
        /// Khoa.
        /// </summary>
        public Guid DepartmentID { get; set; }

        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }

        [Ignore]
        public RoomType RoomType { get; set; }

        [Ignore]
        public DIDepartment Department { get; set; }
    }
}
