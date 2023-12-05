using HIS.Core.Entities;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    public class Gender : Entity<Guid>
    {
        public string GenderCode { get; set; }
        public string GenderName { get; set; }
        public string Description { get; set; }
        public int? SortOrder { get; set; }
        public bool Inactive { get; set; }

        public Gender() { }
        public Gender(Guid id, string code, string name, int order)
        {
            this.Id = id;
            this.GenderCode = code;
            this.GenderName = name;
            this.SortOrder = order;
        }
    }
}
