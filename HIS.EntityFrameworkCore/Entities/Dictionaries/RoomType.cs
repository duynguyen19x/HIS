using HIS.Core.Entities;
using HIS.Core.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Loại phòng, buồng.
    /// </summary>
    public class RoomType : AuditedEntity<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? SortOrder { get; set; }
        public bool Inactive { get; set; }

        public virtual IList<Room> SRooms { get; set; }
    }
}
