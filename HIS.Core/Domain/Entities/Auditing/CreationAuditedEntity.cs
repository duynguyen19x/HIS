using HIS.Core.Domain.Entities;
using HIS.Utilities.Helpers;
using HIS.Utilities.Sections;
using System.Reflection.Metadata;

namespace HIS.Core.Domain.Entities.Auditing
{
    [Serializable]
    public abstract class CreationAuditedEntity<TPrimaryKey> : Entity<TPrimaryKey>, ICreationAudited
    {
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }

        public CreationAuditedEntity()
        {
            if (DatetimeHelper.IsNullOrEmpty(CreatedDate))
            {
                CreatedDate = DateTime.Now;
            }

            if (GuidHelper.IsNullOrEmpty(CreatedBy))
            {
                CreatedBy = SessionExtensions.Login?.Id;
            }
        }
    }
}
