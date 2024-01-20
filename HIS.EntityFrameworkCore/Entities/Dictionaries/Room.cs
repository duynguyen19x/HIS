using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    public class Room : AuditedEntity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string MohCode { get; set; }
        public int RoomTypeId { get; set; }
        public Guid DepartmentId { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        [Ignore]
        public RoomType RoomType { get; set; }
        [Ignore]
        public Department Department { get; set; }
    }
}
