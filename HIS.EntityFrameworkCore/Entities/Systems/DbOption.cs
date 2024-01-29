using HIS.Core.Domain.Entities;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    public class DbOption : Entity<Guid>
    {
        public string DbOptionId { get; set; }
        public string DbOptionValue { get; set; }
        public int DbOptionType { get; set; }
        public string Description { get; set; }
        public Guid? ParentId { get; set; }
        public bool IsParent { get; set; }

    }
}
