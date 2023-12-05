namespace HIS.Core.Entities
{
    [Serializable]
    public abstract class Entity : IEntity
    {
    }

    [Serializable]
    public abstract class Entity<TPrimaryKey> : Entity, IEntity<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; set; }
    }
}
