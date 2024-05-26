using HIS.Core.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    [Table("SUserToken")]
    public class UserToken : Entity<Guid>
    {
        public Guid? UserId { get; set; }

        public string TokenValue { get; set; }

        [MaxLength(125)]
        public string Jti { get; set; }

        public bool IsUsed { get; set; }

        public bool IsRevoked { get; set; }

        public DateTime IssueAt { get; set; }

        public DateTime ExpiredAt { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User UserFk { get; set; }
    }
}
