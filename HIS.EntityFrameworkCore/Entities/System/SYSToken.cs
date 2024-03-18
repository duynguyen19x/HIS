using HIS.Core.Domain.Entities;

namespace HIS.EntityFrameworkCore.Entities.System
{
    public class SYSToken : Entity<Guid>
    {
        public Guid? UserId { get; set; }
        public string TokenValue { get; set; }
        public string Jti { get; set; }
        public bool IsUsed { get; set; }
        public bool IsRevoked { get; set; }
        public DateTime IssueAt { get; set; }
        public DateTime ExpiredAt { get; set; }

        public SYSUser User { get; set; }
    }
}
