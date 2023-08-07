namespace HIS.EntityFrameworkCore.Entities.Systems
{
    public class SUserRole
    {
        public Guid? UserId { get; set; }
        public Guid? RoleId { get; set; }

        public SUser User { get; set; }
        public SRole Role { get; set; }
    }
}
