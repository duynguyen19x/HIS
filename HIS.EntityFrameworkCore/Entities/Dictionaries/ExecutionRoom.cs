using HIS.Core.Domain.Entities;
using HIS.EntityFrameworkCore.Entities.Categories;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Phòng thực hiện
    /// </summary>
    public class ExecutionRoom : Entity<Guid>
    {
        public Guid? ServiceId { get; set; }
        public Guid? RoomId { get; set; }

        /// <summary>
        /// Đánh dấu phòng thực hiện chính
        /// </summary>
        public bool IsMain { get; set; }

        public Service Service { get; set; }
        public DIRoom Room { get; set; }
    }
}
