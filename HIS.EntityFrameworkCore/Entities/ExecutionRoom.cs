using HIS.Core.Domain.Entities;
using HIS.EntityFrameworkCore.Entities.Categories;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Phòng thực hiện
    /// </summary>
    [Table("SExecutionRooms")]
    public class ExecutionRoom : Entity<Guid>
    {
        public Guid? ServiceId { get; set; }
        public Guid? RoomId { get; set; }

        /// <summary>
        /// Đánh dấu phòng thực hiện chính
        /// </summary>
        public bool IsMain { get; set; }

        public Service Service { get; set; }
        public Room Room { get; set; }
    }
}
