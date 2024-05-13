using HIS.Core.Authorization;
using HIS.Core.Domain.Entities;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.Dictionary;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.System
{
    /// <summary>
    /// Người dùng vả phòng chức năng.
    /// </summary>
    [Table("UserRoomMapping")]
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
