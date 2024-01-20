namespace HIS.Core.Domain.Entities.Auditing
{
    public interface IFullAudited : IAudited
    {
        DateTime? DeletedDate { get; set; }
        Guid? DeletedBy { get; set; }
        bool IsDeleted { get; set; }
    }
}
