namespace HIS.Core.Entities.Auditing
{
    [Serializable]
    public abstract class CreationAuditedEntity<TPrimaryKey> : Entity<TPrimaryKey>, ICreationAudited
    {
        public DateTime CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }

        public CreationAuditedEntity()
        {
            if (CreatedDate == (DateTime)default)
            {
                CreatedDate = DateTime.Now;
            }
        }
    }
}
