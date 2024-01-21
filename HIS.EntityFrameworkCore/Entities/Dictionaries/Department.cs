using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    public class Department : AuditedEntity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string MohCode { get; set; }
        public string Description { get; set; }
        public int? DepartmentTypeId { get; set; }
        public Guid? BranchId { get; set; }
        public int? SortOrder { get; set; }
        public bool Inactive { get; set; }

        [Ignore]
        public virtual DepartmentType DepartmentType { get; set; }
        [Ignore]
        public virtual Branch Branch { get; set; }
    }
}
