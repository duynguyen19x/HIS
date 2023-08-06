namespace HIS.Core.Entities.Auditing
{
    [Serializable]
    public abstract class AuditedEntity<TPrimaryKey> : CreationAuditedEntity<TPrimaryKey>, IAudited
    {
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual Guid? ModifiedBy { get; set; }
    }
}
