namespace HIS.EntityFrameworkCore.Entities.Systems
{
    public class UserRole
    {
        public Guid? UserId { get; set; }
        public Guid? RoleId { get; set; }

        public SYSUser User { get; set; }
        public Role Role { get; set; }
    }
}
