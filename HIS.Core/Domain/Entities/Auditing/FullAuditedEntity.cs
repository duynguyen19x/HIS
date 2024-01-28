namespace HIS.Core.Domain.Entities.Auditing
{
    [Serializable]
    public abstract class FullAuditedEntity<TPrimaryKey> : AuditedEntity<TPrimaryKey>, IFullAudited
    {
        public virtual bool IsDeleted { get; set; }

        public virtual DateTime? DeletedDate { get; set; }

        public virtual Guid? DeletedBy { get; set; }
    }
}
