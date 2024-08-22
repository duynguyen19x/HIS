using HIS.Core.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Người dùng vả phòng chức năng.
    /// </summary>
    [Table("SUserRoomMappings")]
    public class UserRoomMapping : Entity<Guid>
    {
        public virtual Guid UserId { get; set; }

        public virtual Guid RoomId { get; set; }

        [ForeignKey("RoomId")]
        public virtual Room RoomFk { get; set; }

        [ForeignKey("UserId")]
        public virtual User UserFk { get; set; }

        public UserRoomMapping() 
        { 
        }

        public UserRoomMapping(Guid userId, Guid roomId)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            RoomId = roomId;
        }
    }
}
