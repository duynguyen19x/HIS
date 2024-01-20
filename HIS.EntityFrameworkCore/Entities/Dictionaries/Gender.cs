using HIS.Core.Domain.Entities;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    public class Gender : Entity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? SortOrder { get; set; }
        public bool Inactive { get; set; }

        public Gender() { }
        public Gender(Guid id, string code, string name, int order)
        {
            this.Id = id;
            this.Code = code;
            this.Name = name;
            this.SortOrder = order;
        }
    }
}
